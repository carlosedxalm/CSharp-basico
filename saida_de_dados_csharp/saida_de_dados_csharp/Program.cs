using System;
using System.Globalization;

namespace saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //para imprimir os dados na mesma linha do console:
            Console.Write("Bom Dia! ");
            Console.Write("Boa Noite!");

            //para imprimir os dados com quebra de linha no console:
            //usando vazio para somente pular 2 linhas.
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Bom Dia!");
            Console.WriteLine("Boa Noite");


            //Imprimindo variaveis:
            int x, y;
            x = 30;
            y = 70;
            Console.WriteLine(x);
            Console.WriteLine(y);


            //variavel do tipo CultureInfo para deixar o código mais limpo.
            CultureInfo CI = CultureInfo.InvariantCulture;

            double z;
            z = 2.4530;
            //Usando o ToString para adicionar um padrão de casas decimais "F4".
            //Usando o CultureInfo.InvariantCulture para ao invez de imprimir o numero
            //real com "," no padrão PT-BR imprimir com "." no padrão inglês.
            //para usar o CultureInfo.InvariantCulture
            //precisa usar o namescapace System.Globalization
            Console.WriteLine(z.ToString("F4", CI));

            //Imprimindo dados concatenados: 
            int idade;
            double salario;
            string nome;
            char genero;

            idade = 23;
            nome = "Soraia Silva";
            genero = 'F';
            salario = 4.300;

            Console.WriteLine("A funcionaria " + nome + ", de genero " + genero + " e de " + idade 
                + " anos " + "recebe um salario de " + salario.ToString("F3", CI) + " reais");



        }
    }
}