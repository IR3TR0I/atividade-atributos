using System;
using Atividade_atributos.Classes;

namespace Atividade_atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nomeCompleto = Console.ReadLine();

            Console.WriteLine("Insira o Curso: ");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("Insira a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o RG do Aluno");
            aluno1.RG = Console.ReadLine();

            Console.WriteLine("O aluno é bolsista? (S/N)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "s") {
                aluno1.bolsista = true;
            } else if (resposta.ToLower() == "n") {
                aluno1.bolsista = false;
            }

            Console.WriteLine("insira a média do aluno: ");
            aluno1.mediaFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor da mensalidade: ");
            aluno1.valorDaMensalidade = double.Parse(Console.ReadLine());

            // Console infos (aluno1)
            Console.WriteLine(aluno1.nomeCompleto);
            Console.WriteLine(aluno1.curso);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(aluno1.RG);
            Console.WriteLine(aluno1.bolsista);

            //Console (Média aluno 1)

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsista, aluno1.valorDaMensalidade);
        }
    }
}
