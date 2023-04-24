//Receba dois números. Exiba o maior.
Console.WriteLine("--- Exibindo o maior número ---");

Console.Write("Digite o primeiro número...: ");
int numero1 = int.Parse(Console.ReadLine()!);
        
Console.Write("Digite o segundo número....: ");
int numero2 = int.Parse(Console.ReadLine()!);

if (numero1 > numero2) {
    Console.WriteLine($"\nO maior número é...........: {numero1}");

} else if (numero1 < numero2) {
    Console.WriteLine($"\nO maior número é...........: {numero2}");

}else {
    Console.WriteLine("\nOs números são iguais");
}

