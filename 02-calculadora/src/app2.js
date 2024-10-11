const result_field = document.getElementById("result");
let is_initial = true;

const reset_input = () => {
	result_field.value = "0";
	is_initial = true;
};

const update_input = (value) => {
	if (is_initial) {
		result_field.value = "";
		is_initial = false;
	}
	result_field.value += value;
};

const handle_equals = () => {
	try {
		result_field.value = eval(result_field.value) || "Error";
	} catch {
		result_field.value = "Error";
	}
};

const handle_backspace = () => {
	result_field.value = result_field.value.slice(0, -1) || "0";
};

reset_input();

document.querySelector(".buttons").addEventListener("click", ({ target }) => {
	const value = target.textContent;
	if (!Number.isNaN(value) || value === ".") {
		update_input(value);
	} else if (value === "=") {
		handle_equals();
	} else if (value === "C") {
		reset_input();
	} else if (value === "←") {
		handle_backspace();
	} else {
		update_input(value);
	}
});
