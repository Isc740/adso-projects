const manageClear = () => {
	const gridCells = document.querySelectorAll(".cell");
	document.getElementById("clear").addEventListener("click", function() {
		for (const cell of gridCells) {
			cell.value = "";
		}
	});
};

const manageUserInput = () => {
	let selectedValue = null;
	const selectionButtons = document.querySelectorAll(
		".selection-container input",
	);

	for (const button of selectionButtons) {
		button.addEventListener("click", function() {
			selectedValue = this.value;
		});
	}

	const gridCells = document.querySelectorAll(".cell");
	for (cell of gridCells) {
		cell.addEventListener("click", function() {
			if (selectedValue !== null && this.value === "") {
				this.value = selectedValue;
			}
		});
	}

	manageClear();
};

document.addEventListener("DOMContentLoaded", () => {
	manageUserInput();
});
