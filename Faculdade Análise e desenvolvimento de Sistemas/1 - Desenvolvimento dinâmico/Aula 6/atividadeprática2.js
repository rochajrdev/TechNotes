// Função para solicitar a escolha da bebida
function escolherBebida() {
    // Solicita ao usuário que escolha uma bebida
    let bebida = prompt("Escolha sua bebida: café, leite ou chá");

    // Declaração da variável para armazenar o valor da bebida
    let valor;

    // Estrutura de decisão 'switch' para determinar o valor da bebida escolhida
    switch (bebida.toLowerCase()) {
        case 'café':
            valor = 5.00;
            alert(`Você escolheu ${bebida}. O valor a ser pago é R$ ${valor.toFixed(2)}.`);
            break;
        case 'leite':
            valor = 3.50;
            alert(`Você escolheu ${bebida}. O valor a ser pago é R$ ${valor.toFixed(2)}.`);
            break;
        case 'chá':
            valor = 4.00;
            alert(`Você escolheu ${bebida}. O valor a ser pago é R$ ${valor.toFixed(2)}.`);
            break;
        default:
            alert("Escolha inválida! Por favor, escolha entre café, leite ou chá.");
            break;
    }
}

// Chama a função para executar
escolherBebida();
