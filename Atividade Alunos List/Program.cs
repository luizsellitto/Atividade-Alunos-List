using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> list = new List<Aluno>();
        while (true)
        {
            Console.WriteLine("Digite 0 se for para para e 1 para continuar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 0:
                    foreach (Aluno a in list)
                    {
                        Console.WriteLine($"O nome do aluno é {a.Nome}, o CPF é {a.CPF}, a matrícola é {a.Matricula} e a Data de nascimento é {a.DataNascimento}");
                    }
                    goto exit;
                case 1:
                    Aluno aluno = new Aluno();
                    Console.WriteLine("\n Digite o nome: ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("\n Digite o CPF: ");
                    aluno.CPF = Console.ReadLine();
                    Console.WriteLine("\n Digite a matrícula: ");
                    aluno.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n Digite a data em que este aluno nasceu: ");
                    aluno.DataNascimento = DateOnly.Parse(Console.ReadLine());
                    list.Add(aluno);
                    break;
                default:
                    Console.WriteLine("Esta opção não exite\n");
                    break;
            }
        }exit:;
    }
}