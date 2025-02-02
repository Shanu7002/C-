class Calculator {
(int, int) valores() {
Console.Write("Type the first number: ");
string primeiroNumero = Console.ReadLine()!;

Console.Write("Type the second number: ");
string segundoNumero = Console.ReadLine()!;

int primeiroNumeroint = int.Parse(primeiroNumero);
int segundoNumeroint = int.Parse(segundoNumero);

return (primeiroNumeroint, segundoNumeroint);
}

void anotherOperation(){
    Console.Write("Do you want to do another operation? ");
string resposta = Console.ReadLine()!;
if (resposta == "yes"){
    Console.Clear();
    ShowMenu();
} else if (resposta == "no"){
    Console.Clear();
    exit();
} else {
    Console.WriteLine("Invalid answer");
}
}

void ShowMenu(){
     Console.WriteLine("Welcome to calculator");
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
var (primeiroNumeroint, segundoNumeroint) = valores();
int additionCount =  primeiroNumeroint + segundoNumeroint;
Console.WriteLine($"The addition is: {additionCount}");
anotherOperation();
}

void subtraction() {
var (primeiroNumeroint,segundoNumeroint) = valores();
int subtractionCount = primeiroNumeroint - segundoNumeroint;
Console.WriteLine($"The subtraction is: {subtractionCount} ");
anotherOperation();
}

void multiplication() {
var (primeiroNumeroint, segundoNumeroint) = valores();
int multiplicationCount = primeiroNumeroint * segundoNumeroint;
Console.WriteLine($"The multiplication is: {multiplicationCount}");
anotherOperation();
}

void division() {
var (primeiroNumeroint, segundoNumeroint) = valores();
if (segundoNumeroint == 0){
    Console.WriteLine("You can't divide a number per 0");
} else {
    int divisionCount = primeiroNumeroint / segundoNumeroint;
Console.WriteLine($"The division is: {divisionCount}");
anotherOperation();
}
}
void exit() {
    Console.WriteLine("Hope you liked our calculator, see you later :D");
}
    public void Start(){
        ShowMenu();
}
}
class Program{
    static void Main(){
        Calculator calc = new Calculator();
        calc.Start();
    }
}



