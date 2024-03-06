using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    internal class DesafiosTarget
    {
        public static void QuestaoUm()
        {
            AberturaDeQuestoes.QuestaoUm();
            int i = 13;
            int soma = 0;
            int k = 0;

            while(k < i)
            {
                k++;
                soma += k;
            }
            Console.WriteLine($"Resultado usando o WHILE: {soma}");

            for(i = 13 ; k < i; k++)
            {
                soma += k;
            }
            Console.WriteLine($"Resultado usando o FOR: {soma}");
        }
        public static void QuestaoDois()
        {
            AberturaDeQuestoes.QuestaoDois();
            Console.WriteLine("Informe um número");
            int entradaDeNumero = int.Parse(Console.ReadLine());

            int anterior1 = 1;
            int anterior2 = 0;

            Console.Write($"Sequência de Fibonacci {anterior2} {anterior1}");

            for(int i = 3; i < 20; i++)
            {
                int atual = anterior1 + anterior2;
                anterior2 = anterior1;
                anterior1 = atual;

                Console.Write($" {atual}");

                if (entradaDeNumero == 0 || entradaDeNumero == 1 || entradaDeNumero == atual)
                {
                    Console.Write(" ...");
                    Console.WriteLine($"\nO número {entradaDeNumero} pertence a sequência de Fibonacci");
                    return;
                }

            }
            Console.Write(" ...");
            Console.WriteLine($"\nO número {entradaDeNumero} não pertence a sequência de Fibonacci");


        }
        public static void QuestaoTres()
        {
            AberturaDeQuestoes.QuestaoTres();

            Console.WriteLine("Resposta Letra a: 9  --  Numeros Impares");
            Console.WriteLine("Resposta Letra b: 128  --  Anterior multiplicado por 2");
            Console.WriteLine("Resposta Letra c: 49  --  Numero em sequência ao quadrado");
            Console.WriteLine("Resposta Letra d: 100 -- Começando somando 12 e a cada soma acrescenta 8 na soma anterior");
            Console.WriteLine("Resposta Letra e: 13  --  Sequencia de Fibonacci");
            Console.WriteLine("Resposta Letra f: 200  --  Números naturais que a pronuncia começa com a letra D");

        }
        public static void QuestaoQuatro()
        {
            AberturaDeQuestoes.QuestaoQuatro();

            Console.WriteLine("Possuem 3 interruptores, eu ligaria o interrupitor (1) deixaria ligado por 5 minutos e após isso ligaria interruptor (2)");
            Console.WriteLine("Após isso iria para a sala (1) e analisaria:");

            Console.WriteLine("Caso 1:Se a lâmpada estiver acessa, então para esta sala é o interruptor (2)");
            Console.WriteLine("Caso 2:Se a lâmpada estiver apagada e quente então é o interruptor (1)");
            Console.WriteLine("Caso 3:Se a lâmpada estiver apagada e fria então é o interruptor (3)");

            Console.WriteLine("\nAssim, eu voltaria para a sala e se fosse o Caso 1 eu ligaria o interruptor (1) e iria para a sala (2).");
            Console.Write("Se nessa estiver acessa então para esta é o interrupir (1), caso não, é o (3)");

            Console.WriteLine("\n\nSe fosse o Caso 2 eu ligaria o interruptor (2) e iria para a sala(2).");
            Console.Write("Se nessa estiver acessa então para esta é o interrupir (2), caso não, é o (3)");

            Console.WriteLine("\n\nSe fosse o Caso 3 eu ligaria o interruptor (2) e iria para a sala(2).");
            Console.Write("Se nessa estiver acessa então para esta é o interrupir (2), caso não, é o (1)\n");

        }
        public static void QuestaoCinco()
        {
            AberturaDeQuestoes.QuestaoCinco();
            Console.WriteLine("**********************************");
            Console.WriteLine("*** Vamos inverter uma string! ***");
            Console.WriteLine("**********************************");
            Console.WriteLine("Digite um texto!");
            string original = Console.ReadLine();
            string invertida = InverterString(original);
            Console.WriteLine($"\nString original: {original}");
            Console.WriteLine($"String invertida: {invertida}");

        }
        static string InverterString(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim)
            {
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;

                inicio++;
                fim--;
            }
            return new string (caracteres);
        }

    }

}
