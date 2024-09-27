

namespace AT_Net_Q1
{
    // Definição do delegate que aceita dois inteiros e retorna um inteiro
    public delegate int Operacao(int n1, int n2);

    internal class Program
    {
        // Método para somar
        public static int Somar(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }

        // Método para subtrair
        public static int Subtrair(int n1, int n2)
        {
            int resultado = n1 - n2;
            return resultado;
        }

        // Método para multiplicar
        public static int Multiplicar(int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }

        static void Main(string[] args)
        {
            // Solicitar os números ao usuário
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            // Solicitar a operação ao usuário
            Console.WriteLine("Escolha a operação que deseja realizar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");

            int escolha = int.Parse(Console.ReadLine());

            // Definir uma variável do tipo Operacao (delegate)
            Operacao operacao;

            // Atribuir o método correspondente com base na escolha do usuário
            switch (escolha)
            {
                case 1:
                    operacao = Somar;
                    break;
                case 2:
                    operacao = Subtrair;
                    break;
                case 3:
                    operacao = Multiplicar;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            // Executar a operação escolhida e exibir o resultado
            int resultado = operacao(n1, n2);
            Console.WriteLine($"O resultado da operação é: {resultado}");
        }
    }
}
