
class guessingGame
{
    private int numeroSecreto;

    public guessingGame(){
        numeroSecreto = gerarNumeroSecreto();
    }
    int gerarNumeroSecreto(){
        Random random = new Random();
    return random.Next(1,101);

}
    void escolha(){
        Console.Write("Try to guess the secret number between 1 and 100: ");
        int numeroEscolhido;
        while (true) {
            string algarismoEscolhido = Console.ReadLine()!;

            if (!int.TryParse(algarismoEscolhido, out numeroEscolhido)) {
                Console.WriteLine("Write a valid number");
                continue;
            } if (numeroEscolhido == numeroSecreto) {
                Console.WriteLine("Congratulations you got it!");
                break;
            } else if(numeroEscolhido > numeroSecreto) {
                Console.WriteLine("Try a lower number");
            } else if (numeroEscolhido < numeroSecreto){
                Console.WriteLine("Try a bigger number");
            }
    }
    }
    public void menu(){
        escolha();
    }

}
class program{
    static void Main(){
        guessingGame game = new guessingGame();
        game.menu();
    }
}