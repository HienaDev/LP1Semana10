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

            hash.Add("Ola");
            hash.Add("Adeus");
            hash.Add("Ola");
            hash.Add("Hello");
            hash.Add("World");

            
        }
    }
}
