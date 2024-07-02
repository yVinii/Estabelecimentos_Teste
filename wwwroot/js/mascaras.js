const cnpjInput = document.getElementById('cnpj');

function cnpj(value) {
    if (!value.match(/^(\d{2}).(\d{3}).(\d{3})\\(\d{4})-(\d{2})$/)) {
        value = value.replace(/\D/g, "");
        console.log(value);
        value = value.replace(/(\d{2})(\d)/, "$1.$2");
        console.log(value);
        value = value.replace(/(\d{3})(\d)/, "$1.$2");
        console.log(value);
        value = value.replace(/(\d{3})(\d)/, "$1/$2");
        console.log(value);
        value = value.replace(/(\d{4})(\d)/, "$1-$2");
        console.log(value);
    }
    return value
}


cnpjInput.addEventListener('input', function (event) {
    const cnpjcleanedInput = event.target.value.replace(/\D/g, '');
    event.target.value = cnpj(cnpjcleanedInput);
});

const telefoneInput = document.getElementById('telefone');

function telefone(value) {
    value = value.replace(/\D/g, ""); // Remove tudo o que não é dígito
    value = value.replace(/(\d{2})(\d)/, "($1) $2"); // Coloca parênteses em volta dos dois primeiros dígitos
    value = value.replace(/(\d{5})(\d)/, "$1-$2"); // Coloca um traço entre o quinto e o sexto dígitos
    return value
}

telefoneInput.addEventListener('input', function (event) {
    const telefonecleanedInput = event.target.value.replace(/\D/g, '');
    event.target.value = telefone(telefonecleanedInput);
});

const agenciaInput = document.getElementById('agencia');

function agencia(value) {
    value = value.replace(/\D/g, ""); // Remove tudo o que não é dígito
    value = value.replace(/(\d{3})(\d)/, "$1-$2"); // Coloca um traço entre o terceiro e o quarto dígitos
    return value;
}

agenciaInput.addEventListener('input', function (event) {
    const agenciacleanedInput = event.target.value.replace(/\D/g, '');
    event.target.value = agencia(agenciacleanedInput);
});

const contaInput = document.getElementById('conta');

function conta(value) {
    value = value.replace(/\D/g, ""); // Remove tudo o que não é dígito
    value = value.replace(/(\d{2})(\d)/, "$1.$2"); // Coloca um ponto após os dois primeiros dígitos
    value = value.replace(/(\d{3})(\d)/, "$1-$2"); // Coloca um traço após os cinco dígitos
    return value;
}

contaInput.addEventListener('input', function (event) {
    const contacleanedInput = event.target.value.replace(/\D/g, '');
    event.target.value = conta(contacleanedInput);
});