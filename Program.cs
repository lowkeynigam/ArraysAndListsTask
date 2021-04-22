using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Using Arrays - Exercise One");

            // string[] names = new string[5];

            // names [0] = "Rishabh";
            // names [1] = "5FDP";
            // names [2] = "Big Chungus";
            // names [3] = "Red Sus";
            // names [4] = "Cold Play";

            // foreach(string name in names)
            // Console.WriteLine(name);

            // Console.WriteLine("----------------------------------------");
            // Console.WriteLine("Using Arrays - Exercise Two");

            // int[] numbers = new int[10] {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};

            // int sum = 0;

            // Array.ForEach(numbers, i => sum += i);
            // Console.WriteLine(sum);

            // Console.WriteLine("------------------------------------------");
            // Console.WriteLine("Using Lists - Exercise One");


            // List<int> mynumbers = new List<int>();
            // List<int> mynumbers = new List<int>();
            // mynumbers.Add (int.Parse(Console.ReadLine()));
            // mynumbers.Add (int.Parse(Console.ReadLine()));
            // mynumbers.Add (int.Parse(Console.ReadLine()));
            // mynumbers.Add (int.Parse(Console.ReadLine()));
            // mynumbers.Add (int.Parse(Console.ReadLine()));
            
            // Console.WriteLine("Insert 1 more number please.");
            // int input1 = int.Parse(Console.ReadLine()); 
            //     if (mynumbers.Contains(input1))
            //     {
            //         Console.WriteLine("This number has already been entered ");
            //     }   
            //     else
            //     {
            //         Console.WriteLine("This number hasn't been entered already.");
            //     }

            // 
                
            //     Console.WriteLine("------------------------------------------");
            //     Console.WriteLine("Using Lists - Exercise Two");    

            //         List<int> myNumbers = new List<int>();
			// HashSet<int> uniqueNumbers = new HashSet<int>();
            // Dictionary<int, int> numberDict = new Dictionary<int, int>();

			// Console.WriteLine("Please enter five numbers");
			// for (int i = 1; i <= 5; i++)
			// {
			// 	int number = int.Parse(Console.ReadLine());
			// 	myNumbers.Add(number);
			// 	uniqueNumbers.Add(number);
			// }


            // Console.WriteLine("Numbers");
            // foreach (int num in myNumbers)
            // {
            //     if (uniqueNumbers.Contains(num))
            //     {
            //         if (!numberDict.ContainsKey(num))
            //         {
            //             numberDict.Add(num, 1);
            //         }
            //         else
            //         {
            //             numberDict[num] = numberDict[num] + 1;
            //         }
            //     }
            // }

            // foreach(KeyValuePair<int, int> kvp in numberDict)
            // {
            //     Console.WriteLine("{0} repeats {1} times", kvp.Key, kvp.Value);
                 Console.WriteLine("------------------------------------------");
                 Console.WriteLine("Using Lists - Exercise Three");

                List<string> words = new List<string>();
                bool isWordStop = false
                 while (!isWordStop) 
                 {
                    string word = Console.ReadLine();

                    if (word == "stop")
                    {
                        isWordStop = true;
                    }
                    words.Add(word);
                 }
                words.Reverse();

                Console.WriteLine();
                foreach (string word in words) 
                {

                }
                
                    
                
            
            
        
            
                
        }
    }
}
}

