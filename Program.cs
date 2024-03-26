// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.

string aluno = "Paulo";
int idade = 17;
double nota = 7.5;

// Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

Console.WriteLine("Aluno: " + aluno + " \ntem " + idade + " anos e \nnota " + nota);

Console.WriteLine($"Aluno: {aluno} \ntem {idade} anos e \nnota {nota}");

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double
// ( ) long
// ( ) decimal 

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (x) double para long
// ( ) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal
 

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings

Console.WriteLine("Digite três letras:");

Console.Write("Primeira letra: ");
char letra1 = Console.ReadKey().KeyChar;
Console.Write("\nSegunda letra: ");
char letra2 = Console.ReadKey().KeyChar;
Console.Write("\nTerceira letra: ");
char letra3 = Console.ReadKey().KeyChar;

Console.WriteLine("\nOrdem reversa usando concatenação: " + letra3 + letra2 + letra1);

Console.WriteLine($"Ordem reversa usando interpolação: {letra3}{letra2}{letra1}");

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (F) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (V) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (V) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical
 

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado:
 
Console.WriteLine("Digite dois valores:");

Console.Write("Primeiro valor: ");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Segundo valor: ");
double valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma: {valor1 + valor2}");
Console.WriteLine($"Subtração: {valor1 - valor2}");
Console.WriteLine($"Multiplicação: {valor1 * valor2}");
Console.WriteLine($"Divisão: {valor1 / valor2}");
Console.WriteLine($"Exponenciação: {Math.Pow(valor1, valor2)}");
Console.WriteLine($"Módulo: {valor1 % valor2}");



// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário)
 

Console.Write("Digite o nome: ");
string nome = Console.ReadLine();


Console.Write("Digite a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

if ((nome == "admin" || nome == "maria") && senha == 123)
{

    Console.WriteLine("Login feito com sucesso");
}
else
{

    Console.WriteLine("Login inválido");
}

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.Write("Digite o primeiro número inteiro (x): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número inteiro (y): ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O número x é {(x % 2 == 0 ? "par" : "ímpar")}");

Console.WriteLine($"O número y é {(y % 2 == 0 ? "par" : "ímpar")}");
