function validarFormulario() {
  var login = document.getElementById("login").value;
  var senha = document.getElementById("senha").value;
  var confirmarSenha = document.getElementById("confirmarSenha").value;

  var loginError = document.getElementById("loginError");
  var senhaError = document.getElementById("senhaError");
  var confirmarSenhaError = document.getElementById("confirmarSenhaError");

  loginError.textContent = "";
  senhaError.textContent = "";
  confirmarSenhaError.textContent = "";

  var isValid = true;

  if (login === "") {
    loginError.textContent = "Por favor, preencha o campo Login.";
    isValid = false;
  }

  if (senha === "") {
    senhaError.textContent = "Por favor, preencha o campo Senha.";
    isValid = false;
  }

  if (confirmarSenha === "") {
    confirmarSenhaError.textContent =
      "Por favor, preencha o campo Confirmar Senha.";
    isValid = false;
  }

  if (senha !== confirmarSenha) {
    confirmarSenhaError.textContent = "As senhas não coincidem.";
    senha = "";
    isValid = false;
  }

  if (senha.length < 6 || senha.length > 10) {
    senhaError.textContent = "A senha deve ter entre 6 e 10 caracteres.";
    isValid = false;
  }

  return isValid;
}
