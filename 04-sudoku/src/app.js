const manageUserInput = () => {
	let selectedValue = null;

	const selectionButtons = document.querySelectorAll(
		".selection-container input",
	);

	for (button of selectionButtons) {
		button.addEventListener("click", function () {
			selectedValue = this.value;
			console.log(selectedValue);
		});
	}

	const gridCells = document.querySelectorAll(".grid-cell");
	for (cell of gridCells) {
		cell.addEventListener("click", function () {
            console.log(this.value);
			if (selectedValue !== null && this.value === "") {
				this.value = selectedValue;
			}
		});
	}
};

document.addEventListener("DOMContentLoaded", () => {
	manageUserInput();
});
