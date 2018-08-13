using System;
using System.Collections;


namespace SystemCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingArrayList();
            UsingHashtable();
        }

        static void UsingArrayList()
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);


            list.Add("value1");
            list.Insert(0, "value2");
            list.AddRange(new string[] { "value3", "value4", "value5" });

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);

            list.Remove("value4");
            list.RemoveAt(0);

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);

            list.TrimToSize();

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);

            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            
        }

        static void UsingHashtable()
        {
            Hashtable hashTable = new Hashtable();

            hashTable.Add("lemon", 25.5);
            
            hashTable["apple"] = 17.9;
            hashTable["plum"] = 50.0;

            foreach (DictionaryEntry pair in hashTable)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
        }
    }
}
