/*

Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius.

A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9. 

Em que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius.

*/

static void main()
{
    Console.Write("Escreva uma temperatura em Fahrenheit --> ");
    string f = Console.ReadLine();
    double fNumber = double.Parse(f);

    double c = (fNumber - 32) * 5 / 9;

    Console.WriteLine($"\n\nA temperatura em Fahrenheit é {fNumber}");
    Console.WriteLine($"A temperatura em graus Celsius é {c}º");
}

main();
