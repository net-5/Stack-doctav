using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        //problema: obtinerea primului (celui mai de jos) element dintr-un stack, FARA a afecta valorile din stack
        //rezolvare: am implementat un extension method pentru Stack<>
        static void Main(string[] args)
        {
            
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            //apelez metoda extinsa pe care am implementat-o pentru Stack<>
            Console.WriteLine(myStack.getFirstElement());   //obtinem valoarea "cea mai de jos" din stiva si stack-ul nu este afectat
            Console.WriteLine(myStack.Pop());  //obtinem, asa cum e normal, valoarea cea mai de sus din stiva deoarece nu este afecatata de operatiunea precedenta
        }
    }

    static class Extensions
    {
        public static T getFirstElement<T>(this Stack<T> myStack)
        {
            T[] vector = myStack.ToArray();
            if (vector.Length > 0)
            {   //daca am macar o valoare in array
                return vector[vector.Length - 1];  //returnez ultima valoare din array, care este de fapt valoarea "cea mai de jos" din stack-ul initial
            }
            else
            {
                return default(T);
            }
        }
    }
}
