let reset = false;

const manageResets = () => {
    const gridCells = document.querySelectorAll(".grid-cell");
    document.getElementById("reset").addEventListener("click", () => {
        gridCells.forEach((cell) => {
            cell.value = "";
            cell.style.color = "#000"; // Reset color to default
        });
    });
    reset = true;
};
