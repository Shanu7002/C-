
using System.Runtime.InteropServices.Marshalling;

void menulogo() {
    Console.WriteLine("Welcome to calculator");
}

void menuOptions(){
     Console.WriteLine("Type 1 for the addition operation");
     Console.WriteLine("Type 2 for the subtraction operation");
     Console.WriteLine("Type 3 for the multiplication operation");
     Console.WriteLine("Type 4 for the division operation");
     Console.WriteLine("Type 0 to leave the calculator");

     Console.Write("Type your option: ");
     string optionString = Console.ReadLine()!;
     int optionInt = int.Parse(optionString);

     switch (optionInt){
            case 1:
                addition();
                break;
            case 2:
                subtraction();
                break;
            case 3:
                multiplication();
                break;
            case 4:
                division();
                break;
            case 0:
                exit();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
     }
}

void addition() {
Console.Write("Type the first number: ");
string primeiroNumero = Console.ReadLine()!;

Console.Write("Type the second number: ");
string segundoNumero = Console.ReadLine()!;

int primeiroNumeroint = int.Parse(primeiroNumero)!;
int segundoNumeroint = int.Parse(segundoNumero)!;
int additionCount =  primeiroNumeroint + segundoNumeroint;
Console.WriteLine($"The addition is: {additionCount}");
Console.Write("Do you want to do another operation? ");
string resposta = Console.ReadLine()!;
if (resposta == "yes"){
    Console.Clear();
    menulogo();
    menuOptions();
} else if (resposta == "no") {
    Console.Clear();
    exit();
} else {
    Console.WriteLine("Invalid answer");
}
}

void subtraction() {
Console.Write("Type the first number: ");
string primeiroNumero = Console.ReadLine()!;

Console.Write("Type the second number: ");
string segundoNumero = Console.ReadLine()!;

int primeiroNumeroint = int.Parse(primeiroNumero);
int segundoNumeroint = int.Parse(segundoNumero);
int subtractionCount = primeiroNumeroint - segundoNumeroint;
Console.WriteLine($"The subtraction is: {subtractionCount} ");
Console.Write("Do you want to do another operation? ");
string resposta = Console.ReadLine()!;
if (resposta == "yes"){
    Console.Clear();
    menulogo();
    menuOptions();
} else if (resposta == "no"){
    Console.Clear();
    exit();
} else {
    Console.WriteLine("Invalid answer");
}
}

void multiplication() {
Console.Write("Type the first number: ");
string primeiroNumero = Console.ReadLine()!;

Console.Write("Type the second number: ");
string segundoNumero = Console.ReadLine()!;
     
int primeiroNumeroint = int.Parse(primeiroNumero);
int segundoNumeroint = int.Parse(segundoNumero);
int multiplicationCount = primeiroNumeroint * segundoNumeroint;
Console.WriteLine($"The multiplication is: {multiplicationCount}");
Console.Write("Do you want to do another operation? ");
string resposta = Console.ReadLine()!;
if (resposta == "yes"){
    Console.Clear();
    menulogo();
    menuOptions();
} else if (resposta == "no") {
    Console.Clear();
    exit();
} else {
    Console.WriteLine("Invalid answer");
}
}

void division() {
Console.Write("Type the first number: ");
string primeiroNumero = Console.ReadLine()!;

Console.Write("Type the second number: ");
string segundoNumero = Console.ReadLine()!;
int primeiroNumeroint = int.Parse(primeiroNumero);
int segundoNumeroint = int. Parse(segundoNumero);
if (segundoNumeroint == 0){
    Console.WriteLine("You can't divide a number per 0");
} else {
    int divisionCount = primeiroNumeroint / segundoNumeroint;
Console.WriteLine($"The division is: {divisionCount}");
Console.Write("Do you want to do another operation? ");
string resposta = Console.ReadLine()!;
if (resposta == "yes"){
    Console.Clear();
    menulogo();
    menuOptions();
} else if (resposta == "no"){
    Console.Clear();
    exit();
} else {
    Console.WriteLine("Invalid answer");
}
}
}

void exit() {
    Console.WriteLine("Hope you liked our calculator, see you later :D");
}
menulogo();
menuOptions();



