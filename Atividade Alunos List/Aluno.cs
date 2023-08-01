public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateOnly DataNascimento { get; set; }
    public Aluno()
    {

    }
    public Aluno(int matricula, string nome, string cpf, DateOnly datanascimento)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.CPF = cpf;
        this.DataNascimento = datanascimento;
    }
}
