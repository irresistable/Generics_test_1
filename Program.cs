using System;
using System.Collections.Generic;

namespace Generics_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HERE");
            {
                IEnumerator<int> intsEnumerator = GetInts(); // линкуем к хипу? код в GetInts() выполняться не будет.
                Console.WriteLine("linked");                    

                intsEnumerator.MoveNext(); //дернули код, начали исполнять внутри GetInts() и до первого yeild return 1                  
                Console.WriteLine(intsEnumerator.Current); //вывели first а уже потом 1 и встали нафиг

                intsEnumerator.MoveNext();
                Console.WriteLine(intsEnumerator.Current);


            }
        }
        class Account<Motherfucker>//внутри <> может быть любое название.
                                   // это универсальный параметр, вместо него можно подставить любой тип
        {
            public Motherfucker Id { get; set; }
            public int Sum { get; set; }
        }

        static IEnumerator<int> GetInts() // нужен using System.Collections.Generic для работы с дженериками;
        {
            Console.WriteLine("first");
            yield return 1;

            Console.WriteLine("second");
            yield return 2;

            Console.WriteLine("third");
            yield return 3;
        }

        

    }
}
