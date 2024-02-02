
using System;
using System.Globalization;


    /*static void Main()
    {
        
        System.Console.WriteLine("Digite seu numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0) {
            System.Console.WriteLine("NEGATIVO");
        }
        else if ( numero > 0) {
            System.Console.WriteLine("Não negativo");
        }
        else {
            System.Console.WriteLine("Não negativo");
        }

    }*/

    /*static void Main()
    {

        System.Console.WriteLine("DIgite seu numero: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero % 2 == 0 ) {
            System.Console.WriteLine("PAR");
        }
        else if (numero < 0 ) {
            System.Console.WriteLine("IMPAR");
        }
      */  

        /*
        static void Main() 
        {
            System.Console.WriteLine("Digite quanto tempo você jogou: ");
            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaInicial - horaFinal;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
        */

/*
      namespace Program
{
    class Program
    {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            // Certifique-se de verificar se há pelo menos dois elementos no array
            if (valores.Length >= 2) {
                int codigo = int.Parse(valores[0]);
                int quantidade = int.Parse(valores[1]);

                double total;
                if (codigo == 1) {
                    total = quantidade * 4.0;
                }
                else if (codigo == 2) {
                    total = quantidade * 4.5;
                }
                else if (codigo == 3) {
                    total = quantidade * 5.0;
                }
                else if (codigo == 4) {
                    total = quantidade * 2.0;
                }
                else {
                    total = quantidade * 1.5;
                }

                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Entrada inválida. Certifique-se de fornecer pelo menos dois valores separados por espaço.");
            }
        }
    }
}*/





