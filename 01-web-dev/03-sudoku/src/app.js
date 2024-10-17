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

const validateUserInput = (selectedCell) => {
    const gridCells = Array.from(document.querySelectorAll(".grid-cell"));
    const gridSize = Math.sqrt(gridCells.length);
    const rowIndex = Math.floor(gridCells.indexOf(selectedCell) / gridSize);
    const colIndex = gridCells.indexOf(selectedCell) % gridSize;

    const checkViolation = (cells) => {
        const count = {};
        cells.forEach((cell) => {
            const val = cell.value;
            if (val && count[val]) cell.style.color = "#ff0000";
            else count[val] = 1;
        });
    };

    checkViolation(
        gridCells.slice(rowIndex * gridSize, (rowIndex + 1) * gridSize),
    );
    checkViolation(gridCells.filter((_, i) => i % gridSize === colIndex));
    checkViolation(get3x3GridCells(gridCells, rowIndex, colIndex));
};

const get3x3GridCells = (gridCells, row, col) => {
    const gridRowStart = Math.floor(row / 3) * 3;
    const gridColStart = Math.floor(col / 3) * 3;
    const cells = [];

    for (let i = 0; i < 3; i++) {
        for (let j = 0; j < 3; j++) {
            cells.push(gridCells[(gridRowStart + i) * 9 + (gridColStart + j)]);
        }
    }
    return cells;
};

const generateValidSudoku = (emptyCells = 40) => {
    const grid = Array(9).fill(0).map(() => Array(9).fill(0));

    const isValid = (row, col, num) => {
        for (let i = 0; i < 9; i++) {
            if (grid[row][i] === num || grid[i][col] === num) return false;
        }
        const startRow = Math.floor(row / 3) * 3;
        const startCol = Math.floor(col / 3) * 3;
        for (let i = 0; i < 3; i++) {
            for (let j = 0; j < 3; j++) {
                if (grid[startRow + i][startCol + j] === num) return false;
            }
        }
        return true;
    };

    const fillGrid = (row = 0, col = 0) => {
        if (row === 9) return true;
        if (col === 9) return fillGrid(row + 1, 0);
        if (grid[row][col] !== 0) return fillGrid(row, col + 1);

        const nums = shuffleArray([1, 2, 3, 4, 5, 6, 7, 8, 9]);
        for (const num of nums) {
            if (isValid(row, col, num)) {
                grid[row][col] = num;
                if (fillGrid(row, col + 1)) return true;
                grid[row][col] = 0;
            }
        }
        return false;
    };

    fillGrid();

    for (let i = 0; i < emptyCells; i++) {
        let row, col;
        do {
            row = Math.floor(Math.random() * 9);
            col = Math.floor(Math.random() * 9);
        } while (grid[row][col] === 0); // Ensure we only remove filled cells
        grid[row][col] = 0; // Set the cell to empty
    }

    return grid.flat();
};

const generateRandomSudoku = () => {
    const gridCells = document.querySelectorAll(".grid-cell");
    const template = generateValidSudoku(40); // Specify number of empty cells

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
                validateUserInput(cell);
            }
        });
    });
};

document.addEventListener("DOMContentLoaded", () => {
    manageUserInput();
    manageResets();
    generateRandomSudoku();
});
