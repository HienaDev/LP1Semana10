using System;
using System.Collections;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> lista = new List<string>();
            Stack<string> pilha = new Stack<string>();
            Queue<string> fila = new Queue<string>();
            SortedSet<string> ordenado = new SortedSet<string>();
            ICollection<string> hash = new HashSet<string>();

            lista.Add("Ola");
            lista.Add("Adeus");
            lista.Add("Ola");
            lista.Add("Hello");
            lista.Add("World");

            pilha.Push("Ola");
            pilha.Push("Adeus");
            pilha.Push("Ola");
            pilha.Push("Hello");
            pilha.Push("World");

            fila.Enqueue("Ola");
            fila.Enqueue("Adeus");
            fila.Enqueue("Ola");
            fila.Enqueue("Hello");
            fila.Enqueue("World");

            ordenado.Add("Ola");
            ordenado.Add("Adeus");
            ordenado.Add("Ola");
            ordenado.Add("Hello");
            ordenado.Add("World");

            hash.Add("Ola");
            hash.Add("Adeus");
            hash.Add("Ola");
            hash.Add("Hello");
            hash.Add("World");

            foreach (string x in lista)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (string x in pilha)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (string x in fila)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (string x in ordenado)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (string x in hash)
            {
                Console.WriteLine(x);
            }
        }
    }
}
