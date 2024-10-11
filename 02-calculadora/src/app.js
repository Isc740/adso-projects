const operations = {
	"+": (a, b) => a + b,
	"-": (a, b) => a - b,
	"*": (a, b) => a * b,
	"/": (a, b) => a / b,
};

let is_initial = true;
const result_field = document.getElementById("result");

const reset_input = () => {
	result_field.value = "0";
	is_initial = true;
};

const handle_number_input = (value) => {
	if (is_initial) {
		result_field.value = "";
		is_initial = false;
	}
	result_field.value += value;
};

const handle_operator_input = (operator) => {
	if (!is_initial) {
		result_field.value += operator;
	}
	is_initial = false;
};

const handle_equals = () => {
	// try {
	const result = evaluate_expression(result_field.value);
	result_field.value = result;
	// } catch (e) {
	// result_field.value = "Error";
	// }
};

const evaluate_expression = (expression) => {
	const tokens = expression.split(/([+\-*/])/);
	let result = Number.parseFloat(tokens[0]);

	for (let i = 1; i < tokens.length; i += 2) {
		const operator = tokens[i];
		const value = Number.parseFloat(tokens[i + 1]);

		if (operator in operations) {
			result = operations[operator](result, value);
		}
	}
	return result;
};

const handle_backspace = () => {
	result_field.value = result_field.value.slice(0, -1) || "0";
	if (result_field.value.length === 1) is_initial = true;
};

const handle_clear = () => {
	reset_input();
};

reset_input();

document.querySelector(".buttons").addEventListener("click", ({ target }) => {
	const value = target.textContent;
	if (!Number.isNaN(Number(value)) || value === ".") {
		handle_number_input(value);
	} else if (value in operations) {
		handle_operator_input(value);
	} else if (value === "=") {
		handle_equals();
	} else if (value === "C") {
		handle_clear();
	} else if (value === "←") {
		handle_backspace();
	}
});
