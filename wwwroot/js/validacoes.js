function validarTelefone(telefone) {
    // Remove caracteres não numéricos
    telefone = telefone.replace(/\D/g, '');

    // Verifica se tem 10 ou 11 dígitos numéricos
    return telefone.length === 10 || telefone.length === 11;
}

function validarDataCadastro(dataCadastro) {
    const dataAtual = new Date().toISOString().split('T')[0]; // Data atual no formato yyyy-mm-dd
    return dataCadastro <= dataAtual; // Verifica se a data de cadastro não é futura
}

function validarAgencia(agencia) {
    // Verifica se a agência está no formato xxx-x
    return /^\d{3}-\d$/.test(agencia);
}

function validarConta(conta) {
    // Verifica se a conta está no formato xx.xxx-x
    return /^\d{2}\.\d{3}-\d$/.test(conta);
}

function validarCNPJ(cnpj) {

    cnpj = cnpj.replace(/[^\d]+/g, '');

    if (cnpj == '') return false;

    if (cnpj.length != 14)
        return false;

    // Elimina CNPJs invalidos conhecidos
    if (cnpj == "00000000000000" ||
        cnpj == "11111111111111" ||
        cnpj == "22222222222222" ||
        cnpj == "33333333333333" ||
        cnpj == "44444444444444" ||
        cnpj == "55555555555555" ||
        cnpj == "66666666666666" ||
        cnpj == "77777777777777" ||
        cnpj == "88888888888888" ||
        cnpj == "99999999999999")
        return false;

    // Valida DVs
    tamanho = cnpj.length - 2
    numeros = cnpj.substring(0, tamanho);
    digitos = cnpj.substring(tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(0))
        return false;

    tamanho = tamanho + 1;
    numeros = cnpj.substring(0, tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(1))
        return false;

    return true;

}

document.getElementById("empresa-form").addEventListener('submit', function (event) {
    var telefone = document.getElementById("telefone").value;
    if (!validarTelefone(telefone)) {
        event.preventDefault(); // Impede o envio do formulário se o telefone for inválido
        document.getElementById("telefone-error").textContent = "Telefone inválido. Digite o número completo.";
    } else {
        document.getElementById("telefone-error").textContent = " ";
    }

    var agencia = document.getElementById("agencia").value;
    if (!validarAgencia(agencia)) {
        event.preventDefault(); // Impede o envio do formulário se a agência for inválida
        document.getElementById("agencia-error").textContent = "Preencha a agência corretamente. Use o formato xxx-x.";
    } else {
        document.getElementById("agencia-error").textContent = " ";
    }

    var conta = document.getElementById("conta").value;
    if (!validarConta(conta)) {
        event.preventDefault(); // Impede o envio do formulário se a conta for inválida
        document.getElementById("conta-error").textContent = "Preencha a conta corretamente. Use o formato xx.xxx-x.";
    } else {
        document.getElementById("conta-error").textContent = " ";
    }

    var cnpj = document.getElementById("cnpj").value;
    if (!validarCNPJ(cnpj)) {
        event.preventDefault(); // Impede o envio do formulário se o CNPJ for inválido
        document.getElementById("cnpj-error").textContent = "CNPJ inválido.";
    } else {
        document.getElementById("cnpj-error").textContent = " ";
    }

    var dataCadastro = document.getElementById("data_cadastro").value;
    if (!validarDataCadastro(dataCadastro)) {
        event.preventDefault();
        document.getElementById("data_cadastro-error").textContent = "Data de cadastro inválida.";
    } else {
        document.getElementById("data_cadastro-error").textContent = " ";
    }

});