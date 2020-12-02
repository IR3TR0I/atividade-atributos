using System;
namespace Atividade_atributos.Classes
{
    public class Aluno
    {
        public string nomeCompleto;
        public string curso;
        public int idade;
        public string RG;
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;

        public void VerMediaFinal(double media) {
            Console.WriteLine($"A média do aluno é: {media}");
        }
        
        public void VerMensalidade(bool temBolsa, double mensalidade) {
            if(temBolsa == true){
                Console.WriteLine("Esse aluno é bolsista.");
                Console.WriteLine($"Mensalidade: {mensalidade}");

                Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");
            } else {
                Console.WriteLine("Esse aluno NÃO é Bolsista.");
                Console.WriteLine($"Mensalidade: {mensalidade}");
            }
        }
            


        
    }
}