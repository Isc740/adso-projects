const check_credentials = (arr, target_id, target_passwd) => {
	for (let i = 0; i < arr.length; i++) {
		console.log(
			`Checking ID: ${arr[i].id} with ${target_id}, Password: ${arr[i].passwd} with ${target_passwd}`,
		);
		if (arr[i].id === target_id && arr[i].passwd === target_passwd) {
			return { result: true, index: i };
		}
	}
	return { result: false, index: null };
};

let user_data;

if (sessionStorage.getItem("user_data")) {
	user_data = JSON.parse(sessionStorage.getItem("user_data"));
} else {
	user_data = [
		{ id: 1111, passwd: 111, balance: 500000, name: "Isaac" },
		{ id: 2222, passwd: 222, balance: 800000, name: "Matias" },
		{ id: 3333, passwd: 333, balance: 600000, name: "Santiago" },
		{ id: 4444, passwd: 444, balance: 600000, name: "Camilo" },
		{ id: 5555, passwd: 555, balance: 650000, name: "Anderson" },
		{ id: 6666, passwd: 666, balance: 550000, name: "Esteban" },
		{ id: 7777, passwd: 777, balance: 650000, name: "Moises" },
		{ id: 8888, passwd: 888, balance: 600000, name: "Jhoan" },
		{ id: 9999, passwd: 999, balance: 700000, name: "Vera" },
		{ id: 1010, passwd: 101, balance: 800000, name: "Alizair" },
	];
}

const login_form = document.getElementById("login-form");

login_form.addEventListener("submit", (e) => {
	e.preventDefault();

	const user_id = Number(document.getElementById("user-id").value);
	const user_passwd = Number(document.getElementById("user-passwd").value);

	console.log("User ID:", user_id);
	console.log("User Password:", user_passwd);
	console.log("User Data:", user_data);

	const credentials = check_credentials(user_data, user_id, user_passwd);
	console.table(user_data);

	if (
		Number.isNaN(user_id) ||
		Number.isNaN(user_passwd) ||
		!credentials.result
	) {
		document.getElementById("error-message").textContent =
			"Credenciales ingresadas no validas!";
	} else {
		sessionStorage.setItem("user_index", credentials.index);
		sessionStorage.setItem("user_data", JSON.stringify(user_data));

		window.location.href = "/views/transaction.html";
	}
});
