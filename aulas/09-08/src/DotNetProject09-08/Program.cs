using System;

namespace DotNetProject09_08
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercicio 1 Calculo de area

            Console.WriteLine("Digite A altura :");
            int altura = Convert.ToInt32(Console.ReadLine()); // ou int altura = Int32.Parse(Console.ReadLine()); ambos funcionam
            // utilizando a maneira do parse somente uma str pode ser convertida,, com o metodo ToTint32 qualquer tipo pode ser convertido
            Console.WriteLine("Digite outro numero :");            
            int largura = Convert.ToInt32(Console.ReadLine());
            
            int soma = Convert.ToInt32(altura + largura);
            Console.WriteLine("Com os dados de altura : " + altura + " e largura " + largura + " a area do terreno é de : "+ soma);

            //------------------------------------------------------------------------------------------------------------------------

            // Exercicio 2 Conversor monetario
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          Conversor monetario          ");
            Console.WriteLine("---------------------------------------");

            const double valorDolar         = 5.18;
            const double valorEuro          = 5.31;
            const double valorPesoArgentino = 0.04;

            Console.WriteLine("Digite a quantidade de reais a serem convertidos : R$");
            double valorReais = Convert.ToDouble(Console.ReadLine());
            double valorConvertidoDolar         = valorReais / valorDolar;
            double valorConvertidoEuro          = valorReais / valorEuro;
            double valorConvertidoPesoArgentino = valorReais / valorPesoArgentino;

            Console.WriteLine(@$"Quantidade de reais:   R$ {valorReais}
            Quantidade convertida em dolar:             U$ {valorConvertidoDolar}
            Quantidade convertida em dural:             EUR {valorConvertidoEuro}
            Quantidade convertida em pesos argentinos:  ARS {valorConvertidoPesoArgentino}
            ");

            //------------------------------------------------------------------------------------------------------------------------

            //Exercicio 3 menor maior
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("              Maior Menor              ");
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("Digite o valor 1 : ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor 2 : ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double valorMaior = valor1;
            if (valorMaior < valor2)
            {
                valorMaior = valor2;
            }
            Console.WriteLine($"Dentre os valores [{valor1},{valor2}] o maior valor inserido foi : {valorMaior}");

            //------------------------------------------------------------------------------------------------------------------------

            //Exercicio 4 
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("                 Idade                 ");
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("Digite o seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine($"{nome} digite a sua idade : ");
            double idade = Convert.ToDouble(Console.ReadLine());

            string resposta = "Criança";
            if (idade > 13 && idade <= 18)
            {
                resposta = "Adolecente";
            }else
            {
                if(idade > 18 && idade <= 60)
                {
                    resposta = "Adulto";

                }else
                {
                    if (idade > 60)
                    {
                        resposta = "Idoso";
                    }
                }
            }
            Console.WriteLine($"{nome} com base na idade inserida {idade} a pessoa é do tipo : {resposta}"); 


            //------------------------------------------------------------------------------------------------------------------------

            //Exercicio 5
            Random randomNumber = new Random();
            int[] list = new int[10];
            for (int i = 0; i < 10; i++)
            {
                list[i] = randomNumber.Next();
                //Console.WriteLine($"{list[i]}");
            }
            Array.Sort(list);

            Console.Write("Lista ordenada em ordem crescente: \n"); 
            foreach(int value in list) 
            { 
                Console.Write(value + " "); 
            } 

            Array.Reverse(list);

            Console.Write("\n\nLista ordenada em ordem decrescente: \n");
            foreach(int value in list) 
            { 
                Console.Write(value + " "); 
            }

        }
    }
}