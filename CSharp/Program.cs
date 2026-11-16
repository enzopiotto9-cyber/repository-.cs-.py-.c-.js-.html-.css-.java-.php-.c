namespace CSharp;

class Program
{
    static void Main(string[] args)
    {
        Operacao();
    }

    public static double Operacao()
    {
        System.Console.WriteLine("Digite o sinal da operação que gostaria de realizar \n+ Soma\n- Subtração");
        while (true)
        {
            string opcao = Console.ReadLine();
            if (opcao == "+")
            {
                System.Console.WriteLine("Digite a soma que gostaria de fazer: ");
                var estrada = Console.ReadLine().Split('+');
                (double x, double y) = (double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
                System.Console.WriteLine("Exemplo: x+y");
                break;
            }
            if (opcao == "-")
            {
                System.Console.WriteLine("-");
                break;
            }
            else
            {
                System.Console.WriteLine("Você digitou uma opção inválida. Digite uma válida");
            }
        }
        return 0;
    }
    public static void VerificarParImpar()
    {
        System.Console.Write("Digite um número: ");
        while (true)
        {
            try
            {
                double n = double.Parse(Console.ReadLine());
                string verificar = n % 2 == 0 ? "par" : "ímpar";
                System.Console.WriteLine($"O número {n} é {verificar}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Você não digitou um valor válido. Digite novamente: ");
            }
        }
    }
}
