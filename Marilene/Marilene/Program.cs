
using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;
Console.WriteLine("Produtos:");
Console.WriteLine(value: $"{produto1},Cujo o preço é {preco1:f2} ");
Console.WriteLine(value: $"{produto2},Cujo o preço é {preco2:f2} \n");
Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2} \n", idade, codigo, genero);
Console.WriteLine($"Medida com oito casas decimais: {medida:f8}");
Console.WriteLine($"Arredondado (três casas decimais): {medida:f3}");
Console.WriteLine($"Separador decimal invariant culture: " + medida. ToString("f2", CultureInfo.InvariantCulture));