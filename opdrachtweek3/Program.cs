using System;
using System.Collections.Generic;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int number;

            List<String> dataList = new List<String>();
            Dictionary<int, String> dataDictionary = new Dictionary<int, String>();
            String[] dataArray = new String[11];
            
            //Ask user for number and convert it to Int32
            Console.Write("number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            Product(dataList, dataArray, dataDictionary, number);

            PrintData(dataList, dataArray, dataDictionary);
            

        }

        private static void Product(List<String> list, String[] array, Dictionary<int, String> dictionary, int getal){
            Console.WriteLine("\nProduct:\n");
            for(int i = 0; i < 11; i++){
                int uitkomst = i * getal;
                String product = i + " x " + getal + " = " + uitkomst;
                Console.WriteLine(product);

                AddData(list, array, dictionary, i, product);
            }
        }

        private static void AddData(List<String> list, String[] array, Dictionary<int, String> dictionary, int i, String x){
           
            list.Add(x);
            array[i] = x;
            dictionary.Add(i, x);
        }

        private static void PrintData(List<String> list, String[] array, Dictionary<int, String> dictionary){
            Console.WriteLine("\n================= LIST =================");
            foreach (String item in list){
                Console.WriteLine(item);
            }

            Console.WriteLine("\n================= ARRAY =================");
            foreach (String item in array){
                Console.WriteLine(item);
            }

            Console.WriteLine("\n================= DICTIONARY =================");
            foreach (var item in dictionary){
                Console.WriteLine(item.Value);
            }
        }
        
    }
}
