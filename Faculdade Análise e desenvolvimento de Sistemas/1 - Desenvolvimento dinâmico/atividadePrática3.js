// Classe base Funcionario
class Funcionario {
    constructor(nome, idade, cargo) {
      this.nome = nome;
      this.idade = idade;
      this.cargo = cargo;
    }
  
    // Método para o funcionário se apresentar
    seApresentar() {
      console.log(`Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e sou ${this.cargo}.`);
    }
  
    // Método de trabalhar
    trabalhar() {
      console.log(`${this.nome} está trabalhando como ${this.cargo}.`);
    }
  }
  
  // Classe Gerente herda de Funcionario
  class Gerente extends Funcionario {
    constructor(nome, idade, cargo, departamento) {
      super(nome, idade, cargo); // Chamando o construtor da classe Funcionario
      this.departamento = departamento;
    }
  
    // Método específico de gerente
    gerenciar() {
      console.log(`${this.nome} está gerenciando o departamento de ${this.departamento}.`);
    }
  }
  
  // Classe Desenvolvedor herda de Funcionario
  class Desenvolvedor extends Funcionario {
    constructor(nome, idade, cargo, linguagem) {
      super(nome, idade, cargo); // Chamando o construtor da classe Funcionario
      this.linguagem = linguagem;
    }
  
    // Método específico de desenvolvedor
    programar() {
      console.log(`${this.nome} está programando em ${this.linguagem}.`);
    }
  }
  
  // Criando um gerente
  let gerente = new Gerente('Carlos', 45, 'Gerente', 'Vendas');
  
  // Criando um desenvolvedor
  let desenvolvedor = new Desenvolvedor('Ana', 30, 'Desenvolvedora', 'JavaScript');
  
  // Chamando os métodos para o gerente
  gerente.seApresentar();
  gerente.trabalhar();
  gerente.gerenciar();
  
  // Chamando os métodos para o desenvolvedor
  desenvolvedor.seApresentar();
  desenvolvedor.trabalhar();
  desenvolvedor.programar();
  