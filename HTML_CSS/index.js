function purchase(destino, tempo, valor) {
  alert(
    `Contratou o destino: ${destino}\nTempo de Viagem: ${tempo}\nValor: ${valor}`
  );
}

document.addEventListener("DOMContentLoaded", function () {
  const contactForm = document.getElementById("contact");
  const form = contactForm.querySelector("form");

  const successMessage = document.createElement("p");
  const userMessageIs = document.createElement("p");
  const showUserMessage = document.createElement("h2");

  successMessage.style.display = "none";
  userMessageIs.style.display = "none";
  showUserMessage.style.display = "none";

  form.addEventListener("submit", function (e) {
    e.preventDefault();
    successMessage.textContent = "Mensagem enviada com sucesso!";
    userMessageIs.textContent = "Sua mensagem é:";
    showUserMessage.textContent = document.querySelector("#mensagem").value;
    form.style.display = "none";

    const backButton = document.createElement("button");
    backButton.textContent = "Voltar à Página Inicial";
    backButton.classList.add("contactBtn");
    successMessage.style.display = "block";
    userMessageIs.style.display = "block";
    showUserMessage.style.display = "block";

    const showMessageDiv = document.createElement("div");
    showMessageDiv.classList.add("showMessage");
    showMessageDiv.appendChild(successMessage);
    showMessageDiv.appendChild(userMessageIs);
    showMessageDiv.appendChild(showUserMessage);
    showMessageDiv.appendChild(backButton);

    contactForm.appendChild(showMessageDiv);


    backButton.addEventListener("click", function () {
      form.style.display = "flex";
      successMessage.style.display = "none";
      userMessageIs.style.display = "none";
      showUserMessage.style.display = "none";
      window.scrollTo({ top: 0, behavior: "smooth" });
      document.querySelector("#nome").value = "";
      document.querySelector("#email").value = "";
      document.querySelector("#mensagem").value = "";
      backButton.style.display = "none";
    });
  });
});
