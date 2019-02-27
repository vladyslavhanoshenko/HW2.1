using System;

namespace HW2
{
    class Program
    {
        private static bool isGuesed = true;

        private static int random = RandomIntGenerate();

        private static int userInput;

        public static int RandomIntGenerate (){
            Random random1 = new Random();
            int random = random1.Next(100);

            return random;

        }

        public static void Start(){
            Console.WriteLine("Enter you number: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            Guessed(random,userInput);


        }

        public static void MoreOrLower(int random, int userInput){
            if(random>userInput){
                Console.WriteLine("Your number is less than random. Try again");
            }
            else if(random<userInput){
                Console.WriteLine("Your number is grater that random. Try again");
            }

        }
        public static void Guessed(int random, int userInput){
            if(random==userInput){
              Console.WriteLine("You have guessed the number!");
              isGuesed = false;
        }
        else{
            MoreOrLower(random,userInput);
        }
        }
        static void Main(string[] args)
        {
          Console.WriteLine("Hello! You are in the game Guess number. I have generated random number recently. Try to guess this number. Good luck!");
          //Console.WriteLine(random);
          
          while(isGuesed==true){
              Start();
          }   
          }
        }
    }
