namespace repository_.cs_.py_.c_.js_.html_.css_.java_.php_.c;

public class Caracteristicas
{
    public string NomeCompleto;//+
    public int Idade;//+
    public string NomeMãe;//+
    public string NomePai;//+
    public string Sexo; //+
    public string DataNascimento;//+
    public string Escola;
    public string Faculdade;
    public string Trabalho;
    public float salario;

    public void PerquisaDeCampos()
    {
        Console.Write("Digite seu nome completo > ");
        Console.Write("Digite sua idade > ");
        Console.Write("Digite o nome completo de sua Mãe > ");
        Console.Write("Digite o nome completo de sua Pai > ");
        Console.Write("Digite seu Sexo > ");
        Console.Write("Digite o nome da escola onde estudou | estuda > ");
        Console.WriteLine("caso não esteja na faculdade esse campo não é obrigatorio");
        Console.Write("Digite o nome da faculdade onde cursou | cursa > ");
        Console.Write("Digite em que area pretende trabalhar | com oque trabalha > ");
        Console.Write("Digite seu salario | quanto pretende receber > ");
    }
}
