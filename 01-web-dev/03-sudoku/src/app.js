let reset = false;

const manageResets = () => {
    const gridCells = document.querySelectorAll(".grid-cell");
    document.getElementById("reset").addEventListener("click", () => {
        gridCells.forEach((cell) => {
            cell.value = "";
            cell.style.color = "#000";
        });
        generateRandomSudoku();
    });
    reset = true;
};

const shuffleArray = (array) => array.sort(() => Math.random() - 0.5);

const generateSudokuTemplate = () => {
    const template = Array(81).fill(0);
    const baseNumbers = shuffleArray([1, 2, 3, 4, 5, 6, 7, 8, 9]);

    for (let i = 0; i < 9; i++) {
        for (let j = 0; j < 3; j++) {
            const pos = Math.floor(Math.random() * 9);
            const index = (Math.floor(i / 3) * 27) + ((i % 3) * 3) +
                (Math.floor(pos / 3) * 9) + (pos % 3);
            template[index] = baseNumbers[j];
        }
    }
    return template;
};

const generateRandomSudoku = () => {
    const gridCells = document.querySelectorAll(".grid-cell");
    const template = generateSudokuTemplate();

    template.forEach((val, index) => {
        gridCells[index].value = val ? val : ""; // 0 means empty
        gridCells[index].style.color = "#000";
    });
};

const manageUserInput = () => {
    let selectedValue = null;

    document.querySelectorAll(".selection-container input").forEach(
        (button) => {
            button.addEventListener(
                "click",
                () => (selectedValue = button.value),
            );
        },
    );

    document.querySelectorAll(".grid-cell").forEach((cell) => {
        cell.addEventListener("click", () => {
            if (selectedValue && !cell.value) {
                cell.value = selectedValue;
            }
        });
    });
};

document.addEventListener("DOMContentLoaded", () => {
    manageUserInput();
    manageResets();
});
