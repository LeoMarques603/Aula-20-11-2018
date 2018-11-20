using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20_11_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploCollection();
        }

        static void ExemploCollection()
        {
            // Cria uma fila. (Queue)
            Queue fila = new Queue();

            // Adiciona elementos a fila. (X.Enqueue(Y)).
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);

            // Conta e adiciona o valor ao número entre chaves. (X.Count).
            Console.WriteLine("A fila possui {0} elementos", fila.Count);

            // Retira elementos da fila. (Dequeue).
            int elemento = (int)fila.Dequeue();

            Console.WriteLine("O primeiro elemento: " + elemento);
            Console.WriteLine("A fila possui {0} elementos", fila.Count);

            //while () { };

            // Cria uma lista. (ArrayList).
            ArrayList lista = new ArrayList();

            // Adiciona elementos a lista. (X.Add(Y)).
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            Console.WriteLine("A lista possui {0} elementos", lista.Count);

            //Checa se a variável marcada possui o elemento pedido, no caso se "lista" tem o número 2 e responde em Bool. (X.Contains(Y)).
            Console.WriteLine("Existe o Elemento 2? {0}", lista.Contains(2));

            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + "\t");

            // Cria uma "pilha" de elementos. (Stack).
            Stack pilha = new Stack();
            // Adiciona elementos a "pilha". (X.Push(Y)).
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);

            // Remove e retorna o elemento ao topo da pilha. (X.Pop()).
            while (pilha.Count > 0)
                Console.WriteLine(pilha.Pop());

            Console.ReadKey();
        }
    }
}
