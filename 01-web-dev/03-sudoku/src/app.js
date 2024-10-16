const manageResets = () => {
    const grids = document.querySelectorAll(".grid");
    document.getElementById("reset").addEventListener("click", function () {
        for (const grid of grids) {
            for (const cell of grid.children) {
                cell.value = "";
            }
        }
    });
};

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
    manageUserInput();
    manageResets();
});
