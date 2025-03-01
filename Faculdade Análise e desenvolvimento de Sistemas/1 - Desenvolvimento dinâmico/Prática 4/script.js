// Classe base Funcionario
class Funcionario {
    constructor(nome, idade, cargo) {
      this.nome = nome;
      this.idade = idade;
      this.cargo = cargo;
    }
  
    seApresentar() {
      return `Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e sou ${this.cargo}.`;
    }
  
    trabalhar() {
      return `${this.nome} está trabalhando como ${this.cargo}.`;
    }
  }
  
  // Classe Gerente herda de Funcionario
  class Gerente extends Funcionario {
    constructor(nome, idade, cargo, departamento) {
      super(nome, idade, cargo);
      this.departamento = departamento;
    }
  
    gerenciar() {
      return `${this.nome} está gerenciando o departamento de ${this.departamento}.`;
    }
  }
  
  // Classe Desenvolvedor herda de Funcionario
  class Desenvolvedor extends Funcionario {
    constructor(nome, idade, cargo, linguagem) {
      super(nome, idade, cargo);
      this.linguagem = linguagem;
    }
  
    programar() {
      return `${this.nome} está programando em ${this.linguagem}.`;
    }
  }
  
  // Função para exibir mensagem de erro
  function exibirErro(mensagem) {
    const erroDiv = document.getElementById('erro');
    erroDiv.textContent = mensagem;
  }
  
  // Função para limpar mensagens de erro
  function limparErro() {
    const erroDiv = document.getElementById('erro');
    erroDiv.textContent = '';
  }
  
  // Função para processar o formulário
  document.getElementById('formFuncionario').addEventListener('submit', function(event) {
    event.preventDefault(); // Previne o envio do formulário
  
    limparErro(); // Limpa os erros anteriores
  
    try {
      // Obtendo os valores do formulário
      const nome = document.getElementById('nome').value;
      const idade = document.getElementById('idade').value;
      const cargo = document.getElementById('cargo').value;
      const departamento = document.getElementById('departamento').value;
      const linguagem = document.getElementById('linguagem').value;
  
      // Validação básica dos campos
      if (!nome || !idade || !cargo) {
        throw new Error("Por favor, preencha todos os campos obrigatórios.");
      }
  
      let funcionario;
      let resultado = '';
  
      // Criando instância com base no cargo
      if (cargo.toLowerCase() === 'gerente') {
        if (!departamento) {
          throw new Error("O campo 'Departamento' é obrigatório para Gerentes.");
        }
        funcionario = new Gerente(nome, idade, cargo, departamento);
        resultado += funcionario.seApresentar() + '<br>';
        resultado += funcionario.trabalhar() + '<br>';
        resultado += funcionario.gerenciar();
      } else if (cargo.toLowerCase() === 'desenvolvedor') {
        if (!linguagem) {
          throw new Error("O campo 'Linguagem de Programação' é obrigatório para Desenvolvedores.");
        }
        funcionario = new Desenvolvedor(nome, idade, cargo, linguagem);
        resultado += funcionario.seApresentar() + '<br>';
        resultado += funcionario.trabalhar() + '<br>';
        resultado += funcionario.programar();
      } else {
        throw new Error("O cargo deve ser 'Gerente' ou 'Desenvolvedor'.");
      }
  
      // Exibindo o resultado na página
      document.getElementById('resultado').innerHTML = resultado;
  
    } catch (error) {
      // Exibindo a mensagem de erro no DOM
      exibirErro(error.message);
    }
  });
  