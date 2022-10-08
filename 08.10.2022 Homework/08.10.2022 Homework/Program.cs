using System;

namespace _08._10._2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = " Salam rOvshan ";
            Console.WriteLine(name.ToLower());
            //=======================================
            Console.WriteLine(name.ToUpper());
            //=======================================
            Console.WriteLine(name.Trim());
            if (name.StartsWith("S"))
            {
                Console.WriteLine("Var");
            }
            else
            {
                Console.WriteLine("No"); 
            }
            //=======================================
            Console.WriteLine(name.IndexOf("a"));
            //=======================================
            Console.WriteLine(name.LastIndexOf("a"));
            //=======================================
            Console.WriteLine(name.Replace("a","c"));
            //=======================================
            Console.WriteLine(name.Replace("Salam","Sagol"));
            //=======================================
            Console.WriteLine(name.Remove(4,3));
            //=======================================
            Console.WriteLine(name.Substring(4));
            //=======================================
            var result = name.Split(" ");
                foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //=======================================
            string[] words = { "Monday", "Tuesday", "Wednesday", "Thursday" };
            Console.WriteLine(string.Join(",",words));
            //=======================================
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //=======================================
            string text = null;
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //======================================
            Console.WriteLine(name.EndsWith(" "));
            //======================================
            Console.WriteLine(name.IsNormalized());
            //=====================================
            Console.WriteLine(name.Clone());
            //=====================================
            Console.WriteLine(name.GetEnumerator());
            //=====================================
            Console.WriteLine(name.GetHashCode());
            Console.WriteLine(name.GetType());
        }
    }
}
