const manageUserInput = (gridCells) => {
	let selectedValue = null;

	const selectionButtons = document.querySelectorAll(
		".selection-container input",
	);

	for (button of selectionButtons) {
		button.addEventListener("click", function () {
			selectedValue = this.value;
		});
	}

	for (cell of gridCells) {
		cell.addEventListener("click", function () {
			if (selectedValue !== null && this.value === "") {
				this.value = selectedValue;
			}
		});
	}
};

const randomize_grid = () => {
}

document.addEventListener("DOMContentLoaded", () => {
	const gridCells = document.querySelectorAll(".grid-cell");

	manageUserInput(gridCells);
});
