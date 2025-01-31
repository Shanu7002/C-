Console.WriteLine("Digite sua nota");
Console.Write("Minha primeira nota é: ");
int notaFinal = 0;
string notaString = Console.ReadLine()!;
int notaNumero1 = int.Parse(notaString!);
if (notaNumero1 > 10) {
    Console.WriteLine("Insira um valor válido");
} else {
    notaFinal += notaNumero1;
}
Console.Write("Minha segunda nota é: ");
notaString = Console.ReadLine()!;
int notaNumero2 = int.Parse(notaString!);
if (notaNumero2 > 10) {
    Console.WriteLine("Insira um valor válido");
} else {
    notaFinal += notaNumero2;
}
Console.Write("Minha terceira nota é: ");
notaString = Console.ReadLine()!;
int notaNumero3 = int.Parse(notaString!);
if (notaNumero3 > 10) {
    Console.WriteLine("Insira um valor válido");
} else {
    notaFinal += notaNumero3;
}
Console.Write("Minha quarta nota é: ");
notaString = Console.ReadLine()!;
int notaNumero4 = int.Parse(notaString!);
if (notaNumero4 > 10) {
    Console.WriteLine("Insira um valor válido");
} else {
    notaFinal += notaNumero4;
}
notaFinal /= 4;
if (notaFinal >= 5 && notaFinal <= 10) {
    Console.WriteLine("Nota suficiente para aprovação");
} else {
    Console.WriteLine("Nota insuficiente para aprovação");
} 