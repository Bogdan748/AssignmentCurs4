using System;
using System.Text;


namespace AssignmentCurs4
{
    class Program
    {
        static void Main(string[] args)
        {

            string text;

            bool b = citeste() || citeste() || citeste() ;

            text = String.IsNullOrWhiteSpace(text) ? "Nu am continut" : $"Textul introdus este: {text}";

            Console.WriteLine(text);


            bool citeste()
            {
                text = Console.ReadLine();
                return !String.IsNullOrWhiteSpace(text);
            }
        }
    }
}
