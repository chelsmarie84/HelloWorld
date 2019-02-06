
namespace Hello_World
{

    using System;
  

    class Program
    {
        static void Main(string[] args)
        {

            //print out this line to the console 
            Console.WriteLine("Hi! I'm Chelsie 2.0. What is your name?");

            //read the console line and store it in this variable 
            string _friendname = Console.ReadLine();

            // value data types
            //int _myintegervariable;
            //char _mycharvariable = 'y';
            //bool _b;
            //double _dakllj = 123.456;
            //decimal _dkals = 2.65m;
            //float _fall = 345.36F;


            //use the variable and print it out. 
            Console.WriteLine("Nice to meet you. How do you make a hotdog stand, {0}?", _friendname);
            Console.ReadLine();                       
            Console.WriteLine("You take away his chair, {0}!", _friendname);
            Console.ReadLine();
            Console.WriteLine("Talk soon, hope you have a WONDERFUL day! Bye!");
            Console.ReadLine();


        }


    }


}
