namespace Exercicio22
{
    class Alistamento_Militar
    {
        public static void Main(String[] args)
        {
            /*22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua situação em relação ao alistamento militar.
            Se estiver antes dos 18 anos, mostre em quantos anos faltam para o alistamento.
            Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do alistamento.*/

            //Declaração de variáveis
            int opcao = 0, ano_alistamento = 18, ano_virgente = 2022;

            //Solicitando ao usuário o ano de nascimento
            Console.Write("Informe seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            //Processamento do ano informado
            int resultado = ano_virgente - ano;

            /*Condição que irá verificar se o usuário pode ou não se alistar, em quanto tempo ele poderá se alistar ou já há quanto tempo se passaram para ele
             * fazer seu alistamento.*/
            if(resultado < 18)
            {
                Console.WriteLine("Você ainda não pode fazer seu alistamento, pois só tem " + resultado + " anos.\nOBSERVAÇÕES: Você poderá fazer seu alistamento em " + (ano_alistamento - resultado) + " anos.");
            }else if(resultado >= 18)
            {
                Console.WriteLine("Você deveria ter feito seu alistamento há " + (resultado - ano_alistamento) + " atrás.");
            }

        }
    }
}