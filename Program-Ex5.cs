/*

Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. 
A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5. 

Em que a variável F representa é a temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius. 

*/


static void main()
{
    Console.Write("Escreva uma temperatura em graus Celsius --> ");
    string c = Console.ReadLine();
    double cNumber = double.Parse(c);

    double f = (9 * cNumber + 160) / 5;

    Console.WriteLine($"\n\nA temperatura em celsius foi {cNumber}º");
    Console.WriteLine($"A temperatura em fahrenheit foi {f}");
}
main();

