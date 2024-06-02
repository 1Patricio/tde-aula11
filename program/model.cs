// // Exercício 1: Criação de uma Classe Simples
// // Crie uma classe chamada Produto com as propriedades Nome e Preco. Implemente um construtor padrão que inicializa Nome como "Desconhecido" e Preco como 0.0, e um construtor parametrizado que aceita valores para Nome e Preco.

// public class Produto
// {
//     string nome;
//     double preco;
//     public Produto(){
//         this.nome = "Desconhecido";
//         this.preco = 0;
//     }
//     public Produto (string nome, double preco){
//         this.nome = nome;
//         this.preco = preco;
//     }


// //  Exercício 2: Na classe Produto do exercício anterior, crie um método ExibirInfo que exibe as informações do produto. Em seguida, sobrecarregue este método para que ele aceite um parâmetro booleano exibirPreco. Se exibirPreco for verdadeiro, o método deve exibir também o preço do produto.

//     // Dentro do class Produto
//     public void ExibirInfo(){
//         Console.WriteLine($"Nome: {nome} || Preço: R${preco}");
//     }
//     public void ExibirInfo(bool exibirPreco){
//         if(exibirPreco){
//             Console.WriteLine($"Nome: {nome} || Preço: R${preco}");}
//         else{
//             Console.WriteLine($"Nome: {nome}");
//         }
//     }
// }


// // Exercício 3: Crie uma classe chamada Calculadora com métodos sobrecarregados para somar dois, três e quatro números inteiros.
// public class Calculadora{ //criando a class
//     float n1, n2, n3, n4; //criando as variáveis

//     public void Somar(float n1, float n2){
//         float soma = n1 + n2;
//         Console.WriteLine(soma);
//     }
//     public void Somar(float n1, float n2,float n3){ //atribuindo variáveis
//         float soma = n1+n2+n3; //somando
//         Console.WriteLine(soma); //retorno
//     }
//     public void Somar(float n1, float n2,float n3, float n4){
//         float soma = n1+n2+n3+n4;
//         Console.WriteLine(soma);
//     }
// }


// // Exercicio 4: Crie uma classe Aluno com propriedades Nome e Idade. Implemente um construtor padrão que inicializa Nome como "Não Informado" e Idade como 0. Crie também um construtor parametrizado que aceita Nome e Idade como argumentos.
// public class Aluno{
//     string nome; //declarando variáveis
//     int idade;

//     public void estudante(){ //Primeira parte
//         this.nome = "Não informado";
//         this.idade = 0;
//         Console.WriteLine($"Nome: {this.nome} Idade: {this.idade}");
//     }
//     public void estudante(string nome,int idade){ //Segunda parte
//         this.nome = nome;
//         this.idade = idade;
//         Console.WriteLine($"Nome: {this.nome} Idade: {this.idade}");
//     }
// }


// // Exercicio 5: Crie uma classe Funcionario com as propriedades Nome, Cargo e Salario. Implemente um construtor padrão que inicializa Nome como "Desconhecido", Cargo como "Não Informado" e Salario como 0.0. Crie também um construtor parametrizado que aceita Nome, Cargo e Salario.
// public class Funcionario{
//     string Nome;
//     string Cargo;
//     double Salario;
    
//     public Funcionario(){
//         this.Nome = "Desconhecido";
//         this.Cargo = "Não informado";
//         this.Salario = 0.0f;
//     }
//     public Funcionario(string Nome, string Cargo, double Salario){
//         this.Nome = Nome;
//         this.Cargo = Cargo;
//         this.Salario = Salario;

//     }
//     public void mostrarInformacoes(){
//         Console.WriteLine($"Nome: {this.Nome}, Cargo: {this.Cargo} e Salario {this.Salario}");
//     }
// }


// //Exercício 6: Crie uma classe Retangulo com propriedades Altura e Largura. Implemente métodos sobrecarregados CalcularArea para calcular a área do retângulo. O método deve funcionar tanto com a altura e largura da instância quanto com valores passados como parâmetros.
// public class Retangulo{
//     float altura;
//     float largura;
//     float area;
//     public void Calculo(float altura, float largura){
//         this.altura = altura;
//         this.largura = largura;
//         this.area = altura*largura;
//         Console.WriteLine($"Área do Retângulo é {this.area}");
//     }
// }


// //Exercício 7: Crie uma classe Livro com propriedades Titulo, Autor e Ano. Implemente um construtor padrão e um construtor parametrizado que aceita Titulo, Autor e Ano. Crie um método ExibirInfo para exibir as informações do livro.
// public class Livro{
//     string Titulo;
//     string Autor;
//     int Ano;

// //Construtor padrão
//     public Livro(){ 
//         Console.WriteLine("Título do livro: ");
//         Titulo = Console.ReadLine();
//         Console.WriteLine("Autor do livro: ");
//         Autor = Console.ReadLine();
//         Console.WriteLine("Ano do livro: ");
//         Ano = Convert.ToInt32(Console.ReadLine());  
//     }

// //Construtor parametizado
//     public Livro(string Titulo,string Autor,int Ano){
//         this.Titulo = Titulo;
//         this.Autor = Autor;
//         this.Ano = Ano;
//     }
//     public void mostrarLivro(){
//         Console.WriteLine($"Titulo do Livro:{this.Titulo}, Autor do livro:{this.Autor} e Ano do livro:{this.Ano}");
//     }
// }


// // Exercício 8: Crie uma classe ContaBancaria com propriedades NumeroConta, Titular e Saldo. Implemente um construtor padrão que inicializa NumeroConta e Titular como "Desconhecido" e Saldo como 0.0. Crie também um construtor parametrizado que aceita NumeroConta, Titular e Saldo.
// public class ContaBancaria{
//     string NumeroConta;
//     string Titular;
//     float Saldo;

// //Construtor Padrão
//     public ContaBancaria(){ 
//         NumeroConta = "Desconhecido";
//         Titular = "Desconhecido";
//         Saldo = 0.0f;
//     }
// //Construtor Parametizado
//     public ContaBancaria(string NumeroConta, string Titular, float Saldo){
//         this.NumeroConta = NumeroConta;
//         this.Titular = Titular;
//         this.Saldo = Saldo;
//     }
//     public void mostrarConta(){
//         System.Console.WriteLine($"Número da conta: {this.NumeroConta}");
//         System.Console.WriteLine($"Titular da conta: {this.Titular}");
//         System.Console.WriteLine($"Saldo da conta: {this.Saldo}");
//     }
// }


// // Exercício 9: Crie uma classe Veiculo com as propriedades Marca, Modelo e Ano. Implemente um construtor padrão que inicializa Marca, Modelo como "Desconhecido" e Ano como 0. Crie também um construtor parametrizado que aceita Marca, Modelo e Ano.
// public class Veiculo{
//     string marca;
//     string modelo;
//     int ano;

// //Construtor padrão
//     public Veiculo(){
//         this.marca = "Desconhecido";
//         this.modelo = "Desconhecido";
//         this.ano = 0;
//     }
// //Construtor parametizado
//    public Veiculo(string marca, string modelo, int ano){
//         this.marca = marca;
//         this.modelo = modelo;
//         this.ano = ano;
//     }

//     public void mostrarVeiculo(){
//         Console.WriteLine($"O carro da marca {marca}, modelo {modelo} e ano {ano}");
//     }
// }



// Exercício 10: Crie uma classe Conversor com métodos sobrecarregados para converter diferentes tipos de dados. Implemente métodos para converter int para double, double para int, string para int, e string para double.
public class Conversor{
    int inteiro;
    double dobro;
    string letras;

    public int converter(int inteiro){
        inteiro = (int)Convert.ToDouble(inteiro);
        Console.WriteLine(inteiro + 0.5);
        return inteiro;
    }
    public double converterdouble(double dobro){
        dobro = (double)Convert.ToInt32(dobro);
        Console.WriteLine(dobro);
        return dobro;
    }
     public int Converter(string num){
        int inteiro = int.Parse(num);
        return inteiro;
    }
    public double ConverterDouble(string num){
        if(!string.IsNullOrEmpty(num))
        {
            double doubleNum = double.Parse(num);
            return doubleNum;
        }else{
            System.Console.WriteLine("Informe um valor válido para conversão, pois o que inseriu não é um número!");
            return 0;
        };
    }
}