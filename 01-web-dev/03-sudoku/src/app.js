const manageUserInput = () => {
	let selectedValue = null;

	const selectionButtons = document.querySelectorAll(
		".selection-container input",
	);
	for (button of selectionButtons) {
		button.addEventListener("click", function () {
			selectedValue = this.value;
		});
	}

	const gridCells = document.querySelectorAll(".grid-cell");
	for (cell of gridCells) {
		cell.addEventListener("click", function () {
			if (selectedValue !== null && this.value === "") {
				this.value = selectedValue;
			}
		});
	}
};

document.addEventListener("DOMContentLoaded", () => {
	const grids = document.querySelectorAll(".grid");

	manageUserInput();
	randomizeGrids(grids);
});
