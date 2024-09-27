namespace AT_Net_Q2
{
    public delegate void OperacaoString(string input);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            OperacaoString paraMaiusculas = delegate (string input)
            {
                Console.WriteLine("Frase em maiúsculas: " + input.ToUpper());
            };

            OperacaoString paraMinusculas = delegate (string input)
            {
                Console.WriteLine("Frase em minúsculas: " + input.ToLower());
            };

            // Chamar os delegates com a frase inserida pelo usuário
            paraMaiusculas(frase);
            paraMinusculas(frase);
        }
    }
}

