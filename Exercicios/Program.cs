using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declarações 
            int numero;
            double preco = 0;

            //Inicialização;
            numero = 10;

            //Uso Correto 
            System.Console.WriteLine(numero);
            //Erro de compilação 
            System.Console.WriteLine(preco);
            */
    
            int umMaisUm = 1 + 1;  //umMaisUm = 2
            int tresVezesDois = 3 * 2; //tresVezesDois = 6
            int quatroDivididoPor2 = 4 / 2; // quatroDivididoPor2
            int seisModuloCinco = 6 % 5; //seisModuloCinco
            int x = 7;

            x = x + 1 * 2; //x = 9
            x = x - 3; // x = 6
            x = x / (6 - 2 + (3*5) / (16- 1)); // x = 2

            int valor = 1;  // valor = 1
            Console.WriteLine(valor);
            valor += 2; // valor = 3
            Console.WriteLine(valor);
            valor -= 1; // valor = 2
            Console.WriteLine(valor);
            valor *= 6; // valor =  12
            Console.WriteLine(valor);
            valor /= 3; // valor = 4
            Console.WriteLine(valor);
            valor %= 3; // Valor = 1
            Console.WriteLine(valor);


            int valor1 = 1;
            valor1 = valor1 + 2;
            Console.WriteLine(valor1);
            valor1 = valor1 - 1;
            Console.WriteLine(valor1);
            valor1 = valor1 * 6;
            Console.WriteLine(valor1);
            valor1 = valor1 / 3;
            Console.WriteLine(valor1);
            valor1 = valor1 % 3;
            Console.WriteLine(valor1);
            Console.ReadLine();
            Console.WriteLine(valor1);
            Console.ReadLine();
           
            int valor2 = 2;
            bool t = false;
            t = (valor2 == 2); // t = true 
            Console.WriteLine(t);
            t = (valor2 != 2); // t = false 
            Console.WriteLine(t);
            t = (valor2 < 2); // t = false
            Console.WriteLine(t);
            t = (valor2 <= 2); // t = true 
            Console.WriteLine(t);
            t = (valor2 > 1); // t = true 
            Console.WriteLine(t);
            t = (valor2 >= 1); // t = true
            Console.WriteLine(t);
            Console.ReadLine();

            int valor4 = 30;
            bool teste = false;
            teste = valor4 < 40 && valor4 > 20;
            Console.WriteLine(valor4);
            teste = valor4 < 40 && valor4 > 30;
            Console.WriteLine(valor4);
            teste = valor4 > 30 || valor4 > 20;
            Console.WriteLine(valor4);
            teste = valor4 > 30 || valor4 < 20;
            Console.WriteLine(valor4);
            teste = valor4 < 50 && valor4 == 30;
            Console.WriteLine(valor4);

            /*Exercicio 01*/
            double c = 3, b = 4, a = 5;
            b = Math.Pow(b, 2);
            c = Math.Pow(c, 2);
            double hipotenusa = b + c;
            hipotenusa = Math.Sqrt(hipotenusa);
            Console.WriteLine(hipotenusa);
            Console.ReadLine();

        }
    }
}
