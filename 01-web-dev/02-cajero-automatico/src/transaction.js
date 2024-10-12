const process_transaction = (db, value, target_index) => {
	if (db[target_index].balance >= value) {
		db[target_index].balance -= value;
		sessionStorage.setItem("user_data", JSON.stringify(db));
		return true;
	}
	return false;
};

document.addEventListener("DOMContentLoaded", () => {
	const user_data = JSON.parse(sessionStorage.getItem("user_data"));
	const user_index = sessionStorage.getItem("user_index");

	document.getElementById("welcome").textContent =
		`Bienvenido, ${user_data[user_index].name}`;
	document.getElementById("balance").textContent =
		`Tu saldo es de: ${user_data[user_index].balance}`;

	document.addEventListener("submit", (e) => {
		e.preventDefault();

		if (e.submitter.value === "Salir") {
			window.location.href = "/views/index.html";
		} else {
			const success = process_transaction(
				user_data,
				document.getElementById("bill-options").value,
				user_index,
			);

			if (!success) {
				document.getElementById("error").textContent = "Dinero insuficiente";
			} else {
				window.location.href = "/views/success.html";
			}
		}
	});
});
