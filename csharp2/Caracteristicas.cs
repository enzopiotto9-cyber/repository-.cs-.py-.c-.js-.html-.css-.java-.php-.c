namespace repository_.cs_.py_.c_.js_.html_.css_.java_.php_.c;

public class Caracteristicas
{
    public string NomeCompleto;
    public int Idade;
    public string NomeMae;
    public string NomePai;
    public string Sexo;
    public string DataNascimento;
    public string Escola;
    public string Faculdade;
    public string Trabalho;
    public float Salario;

    public void PesquisaDeCampos()
    {
        Console.Write("Digite seu nome completo > ");
        NomeCompleto = Console.ReadLine();

        Console.Write("Digite sua idade > ");
        Idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome completo de sua Mãe > ");
        NomeMae = Console.ReadLine();

        Console.Write("Digite o nome completo de seu Pai > ");
        NomePai = Console.ReadLine();

        Console.Write("Digite seu Sexo > ");
        Sexo = Console.ReadLine();

        Console.Write("Digite sua data de nascimento > ");
        DataNascimento = Console.ReadLine();

        Console.Write("Digite o nome da escola onde estudou | estuda > ");
        Escola = Console.ReadLine();

        Console.WriteLine("Caso não esteja na faculdade esse campo não é obrigatório.");
        Console.Write("Digite o nome da faculdade onde cursou | cursa > ");
        Faculdade = Console.ReadLine();

        Console.Write("Digite em que área pretende trabalhar | com o que trabalha > ");
        Trabalho = Console.ReadLine();

        Console.Write("Digite seu salário | quanto pretende receber > ");
        Salario = float.Parse(Console.ReadLine());
    }
}

