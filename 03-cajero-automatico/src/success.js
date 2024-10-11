document.addEventListener("submit", (e) => {
	e.preventDefault();
	if (e.submitter.value === "Sí") {
		window.location.href = "/views/transaction.html";
	} else if (e.submitter.value === "No") {
		window.location.href = "/views/index.html";
	}
});
