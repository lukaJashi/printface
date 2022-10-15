using System;
#pragma warning disable


namespace PrintFace
{
    public static class Program
    {

        public static void Main()
        {
            Console.WriteLine("Hello, world! ");
            SayHelloUser("User");
            PrintFace();
            Console.ReadLine();
        }


        public static void SayHelloUser(string userName)
        {
            Console.WriteLine($"Hello, {userName}!");

            //throw new NotImplementedException();
        }


        public static void PrintFace()
        {
            string a = " +\"\"\"\"\"+";
            string b = "(| o o |)";
            string c = " |  ^  |";
            string d = " | '-' |";
            string e = " +-----+";




            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);

        }
    }
}
