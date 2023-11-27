
window.onload = letoltes

function letoltes() {
	fetch('/questions/all')
		.then(response => response.json())
		.then(data => kiiratas(data)

		);
}

function kiiratas(lista) {
	console.log(lista)
	for (var i = 0; i < lista.length; i++) {
		let ujElem = document.createElement("div");
		ujElem.innerText = lista[i];
		document.getElementById("eredmeny").appendChild(ujElem);
	}
}