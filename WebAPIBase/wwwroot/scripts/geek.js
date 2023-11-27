var viccek;

window.onload = _ => letoltes()

function letoltes() {
	fetch('/jokes.json')
		.then(response => response.json())
		.then(data => letoltesBef(data)
		);
}

function letoltesBef(d) {
	console.log("Sikeres letöltés")
	console.log(d)
	let ide = document.getElementById("ide");
	viccek = d;

	for (var i = 0; i < viccek.length; i++) {
		console.log(viccek[i].text)
		let elem = document.createElement("li")
		elem.innerHTML = viccek[i].text
		ide.appendChild(elem)
	}
}