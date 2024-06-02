// // Exercício 1: Criação de uma Classe Simples
// // Crie uma classe chamada Produto com as propriedades Nome e Preco. Implemente um construtor padrão que inicializa Nome como "Desconhecido" e Preco como 0.0, e um construtor parametrizado que aceita valores para Nome e Preco.
// using System.Runtime.Intrinsics.Arm;

// Produto produto1 = new Produto();
// produto1.ExibirInfo();


// //  Exercício 2: Na classe Produto do exercício anterior, crie um método ExibirInfo que exibe as informações do produto. Em seguida, sobrecarregue este método para que ele aceite um parâmetro booleano exibirPreco. Se exibirPreco for verdadeiro, o método deve exibir também o preço do produto.
// Produto produto2 = new Produto("Notebook", 2500.0);

// produto2.ExibirInfo();  // Saída: Nome: Notebook, Preço: 2500
// produto2.ExibirInfo(false);  // Saída: Nome: Notebook


// // Exercício 3: Crie uma classe chamada Calculadora com métodos sobrecarregados para somar dois, três e quatro números inteiros.
// Calculadora Calc = new Calculadora();
// Calc.Somar(1,2); //chamando função
// Calc.Somar(1,2,5);
// Calc.Somar(3,6,8,9);


// // Exercicio 4: Crie uma classe Aluno com propriedades Nome e Idade. Implemente um construtor padrão que inicializa Nome como "Não Informado" e Idade como 0. Crie também um construtor parametrizado que aceita Nome e Idade como argumentos.
// Aluno info = new Aluno();
// info.estudante();

// Aluno info2 = new Aluno();
// Console.WriteLine("Digite um nome");
// String nome = Console.ReadLine();
// Console.WriteLine("Digite a Idade");
// int idade = Convert.ToInt32(Console.ReadLine());
// info2.estudante(nome,idade);


// // Exercicio 5: Crie uma classe Funcionario com as propriedades Nome, Cargo e Salario. Implemente um construtor padrão que inicializa Nome como "Desconhecido", Cargo como "Não Informado" e Salario como 0.0. Crie também um construtor parametrizado que aceita Nome, Cargo e Salario.
// Funcionario setor = new Funcionario();
// setor.mostrarInformacoes();

// Console.WriteLine("Digite nome do Funcionário");
// string Nome = Console.ReadLine();
// Console.WriteLine("Digite cargo do funcionário");
// string Cargo = Console.ReadLine();
// Console.WriteLine("Digite o salário do funcionário");
// double Salario = Convert.ToDouble(Console.ReadLine());

// Funcionario setor2 = new Funcionario(Nome, Cargo, Salario);
// setor2.mostrarInformacoes();


// //Exercício 6: Crie uma classe Retangulo com propriedades Altura e Largura. Implemente métodos sobrecarregados CalcularArea para calcular a área do retângulo. O método deve funcionar tanto com a altura e largura da instância quanto com valores passados como parâmetros.
// Retangulo medidas = new Retangulo();

// Console.WriteLine("Digite largura do Retângulo");
// float largura = float.Parse(Console.ReadLine());
// Console.WriteLine("Digite altura do Retângulo");
// float altura = float.Parse(Console.ReadLine());
// medidas.Calculo(largura,altura);


// //Exercício 7: Crie uma classe Livro com propriedades Titulo, Autor e Ano. Implemente um construtor padrão e um construtor parametrizado que aceita Titulo, Autor e Ano. Crie um método ExibirInfo para exibir as informações do livro.
// Livro modelo = new Livro();
// modelo.mostrarLivro();
// Livro modelo2 = new Livro("Percy Jackson & the Olympians", "Rick Riordan", 2005);
// modelo2.mostrarLivro();


// // Exercício 8: Crie uma classe ContaBancaria com propriedades NumeroConta, Titular e Saldo. Implemente um construtor padrão que inicializa NumeroConta e Titular como "Desconhecido" e Saldo como 0.0. Crie também um construtor parametrizado que aceita NumeroConta, Titular e Saldo.
// ContaBancaria contaCliente = new ContaBancaria();
// contaCliente.mostrarConta();

// //Não é necessário declaras as variáveis aqui de novo
// ContaBancaria contaCliente2 = new ContaBancaria("22","Anderson", 25000);
// contaCliente2.mostrarConta();


// // Exercício 9: Crie uma classe Veiculo com as propriedades Marca, Modelo e Ano. Implemente um construtor padrão que inicializa Marca, Modelo como "Desconhecido" e Ano como 0. Crie também um construtor parametrizado que aceita Marca, Modelo e Ano.
// Veiculo carro = new Veiculo();
// carro.mostrarVeiculo();
// Veiculo carro2 = new Veiculo("Honda", "Civic", 2019);
// carro2.mostrarVeiculo();


// Exercício 10: Crie uma classe Conversor com métodos sobrecarregados para converter diferentes tipos de dados. Implemente métodos para converter int para double, double para int, string para int, e string para double.
Conversor converter = new Conversor();
converter.converter(5); //Converter int para double Saída = 5.5
converter.converterdouble(5.5); //Converter double para int Saída = 6
converter.converter(10);
 