function habilitarCampos() {
    var pessoaFisica = document.getElementById('pessoaFisica');
    var pessoaJuridica = document.getElementById('pessoaJuridica');
    var cpfInput = document.getElementById('cpf');
    var cnpjInput = document.getElementById('cnpj');
    var dataNascimentoInput = document.getElementById('dataNascimento');

    cpfInput.disabled = !pessoaFisica.checked;
    cnpjInput.disabled = !pessoaJuridica.checked;
    dataNascimentoInput.disabled = !pessoaFisica.checked;
  }

  function somenteNumeros(evt) {
    var theEvent = evt || window.event;
    var key = theEvent.keyCode || theEvent.which;
    key = String.fromCharCode(key);
    var regex = /^[0-9\b]+$/;
    if (!regex.test(key)) {
      theEvent.returnValue = false;
      if (theEvent.preventDefault) theEvent.preventDefault();
    }
  }