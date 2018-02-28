using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            string faturas = ""; // var string with name "faturas"(dossie)


            Console.WriteLine("pff insira a frase da fatura"); // write a line on da screen
            faturas = Console.ReadLine();  // read a line by user + guarda o q leu na variavel faturas 
            Console.WriteLine("A frase que escreveu: " + faturas); // escreve o valor de faturas 

            Console.WriteLine("\n");

            Console.WriteLine("pff insira 2 frases: ");
            faturas = "primeira frase: ";
            faturas += Console.ReadLine();
            faturas += " segunda frase: ";
            faturas += Console.ReadLine();
            Console.WriteLine("as duas frases: \n" + faturas);

            Console.WriteLine("\n");

            string idade = ""; // variavel idade em texto
            Console.WriteLine("Pff peça a idade: "); // pedir idade ao utilizador
            idade = Console.ReadLine(); // recebe e lê a idade q o utilizador colocar
            int myIdade = Convert.ToInt32(idade); // converter texto em numero
            Console.WriteLine("a tua idade: " + myIdade); // imprimir o conteudo de myIdade
            myIdade += 10; // altera o valor + 10;
            Console.WriteLine("a nova idade: " + myIdade); // imprimi a nova myIdade

            Console.WriteLine("\n");




            string score = ""; // variavel
            Console.WriteLine("pff insira score: ");
            score = Console.ReadLine();
            int myScore = Convert.ToInt32(score);

            Console.WriteLine("o meu score agr é: " + myScore); // da a variavel 
            if (myScore == 0)
            {          // se o score é igual a zero ent   

                Console.WriteLine("o meu resultado é zero");  // primeira opcao

            }
            else if (myScore % 2 != 0)   // se nao, dividido por 2 tem q ser diferente de 0 
            {
                Console.WriteLine("o meu resultado é impar");  // imprime se é impar
            }
            else
            {
                Console.WriteLine("o meu resultado é par"); // se nao for impar, é par 
            }


            switch (myScore)
            {
                case 0:
                    Console.WriteLine("este resultado é zero");
                    break;
                default:                                    // nao consegue virificar situação ent tomas
                    Console.WriteLine("este numero nao e zero");
                    break;


            }


            Console.WriteLine("\n");

            int taboo = 40; // taboo nada a ver c FOR   
            for (int i = 1; i <= 10; i++)   // usado no FOR
            {
                Console.WriteLine(taboo * i);

            }

            Console.WriteLine("\n)");

            string number = "";
            Console.WriteLine("pedir nr ao utilizador: ");
            number = Console.ReadLine();
            int myNumber = Convert.ToInt32(number);

            Console.WriteLine("o meu number agr é: " + myNumber);

            for (int i = 1; i <= 5; i++)
            {
                myNumber = myNumber + (myNumber * i);  //myNumber += myNumber* i 
                Console.WriteLine(myNumber);
            }
        }
    }
}
