using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;

namespace lambda1
{
    internal class Program
    {
        delegate List<int> ex6delegate(List<int> list, int x);
        static void Main(string[] args)
        {
            Action ex8 = () => { Console.WriteLine("Create an Action delegate that accepts a list of strings and a predicate as input. The delegate should remove all elements from the list that satisfy the predicate and print the updated list."); };
            ex8();

            List<string> ex8List = new List<string> { "Create", "Action", "Solution", "Etc" };
            string predicate = "Create";
            Action<List<string>, string> ex8solution = (list, x) =>
            {
                    if (ex8List.Contains(x)) { list.Remove(x); }
            };
            ex8solution(ex8List, predicate);
            foreach (string a in ex8List) { Console.WriteLine(a); }

            
            Action ex7 =() => { Console.WriteLine("Write a lambda expression that takes a list of integers as input and returns the sum of all prime numbers in the list."); };
            ex7();
            List<int> ex7list = new List<int> { 1, 3, 5, 8, 9, 11, 13, 14, 21, 23 };
            List<int> ex7lambda = ex7list.Where(IsPrime).ToList();
            bool IsPrime(int number)
            {
                if (number < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
            foreach (int  i in ex7lambda)
            { Console.WriteLine(i); }

            //
            Action ex6 = () => { Console.WriteLine("Create an Action delegate that accepts an integer and a list of integers as input. The delegate should multiply each element in the list by the input integer and print the updated list."); };
            ex6();
            List<int> integers = new List<int> { 9,8,7,6,5,4,3,2,1 };
            int x = 5;

            Action<int, List<int>> ex6Multiplication = (x,integers) =>
            {
                for(int i = 0; i < integers.Count; i++) { integers[i] *= x; }
            };
            ex6Multiplication(x,integers);
            foreach (int i in integers)
            { Console.WriteLine(i); }
            
            //ex6 second solution
            //List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int x = 5;
            //ex6delegate multiply5 = (integers, x) =>
            //{

            //    List<int> integersNew = new List<int>();
            //    foreach (int i in integers)
            //    {
            //        integersNew.Add(i * x);
            //    }
            //    return integersNew;
            //};

            //List<int> integersMultiplied = multiply5(integers, x);
            //foreach (int i in integersMultiplied)
            //{ Console.WriteLine(i); }

            //
            Action ex5= () => { Console.WriteLine("Write a lambda expression that takes a list of strings as input and returns a new list of strings with only the elements that have a length greater than 5."); };
            ex5();

            List<string> list = new List<string> { "Macius", "Celestynka", "Bobi" };
            List<string> selection = list.Where(s=>s.Length >5).ToList();
            foreach (string word in selection) { Console.WriteLine(word);}

            //
            Action ex4 = () => { Console.WriteLine("Create a Func delegate that accepts a string and returns the number of vowels present in the string."); };
                ex4();
            Func<string, int> ex4vowels = (e) =>
            {
                int count = 0;
                foreach(char c in e)
                {
                    int asciiValue = (int)char.ToLower(c);
                    if (asciiValue == 97 || asciiValue == 101 || asciiValue == 69 || asciiValue == 105 || asciiValue == 117 || asciiValue == 111)
                    { count++; }
                }
                return count;
            };
            Console.WriteLine("Please enter any text and I will tell you how many vowels there are.");
            string text = Console.ReadLine();
            Console.WriteLine(ex4vowels(text));
            //
            Action ex3 = () => Console.WriteLine("Write a lambda expression that takes an array of integers as input and returns the count of even numbers in the array.");
            ex3();
            Func<int[], int> ex3count = (a) =>
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++) 
                {if (a[i] % 2 == 0)
                    {
                        sum+= a[i];}
                }
                return sum;
            };
            int[] array3 = {1,2,3,4,5};
            Console.WriteLine(ex3count(array3));
            //
            Func<string> ex2 = () => $"Create a Func delegate that accepts a string and an integer as input and returns a new string that concatenates the input string with the input integer.";
            Console.WriteLine(ex2());
            Func<string, int, string> ex2concatenate = (c, d) => c + d ;
            Console.WriteLine(ex2concatenate("Dorota", 33)); 
            //
            Action ex1 = () => Console.WriteLine("Write a lambda expression that takes two integers as input and returns their sum.");
            ex1();
            Action<int, int> ex1add = (a,b) => Console.WriteLine(a+b);
            ex1add(6, 8); 
        }

        
        
            
    }
}