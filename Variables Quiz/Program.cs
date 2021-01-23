using System;

namespace Variables_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Veriable Decleration
            int age;
            int weight;
            string fullName;
            bool goodHealth;
            char nickName = 'J';
            double workOutdays = 4;
            decimal weightLoss = 25.5m;

            //Variable Initalization
            age = 30;
            weight = 165;
            fullName = "John Smith";
            goodHealth = true;

            Console.WriteLine($"{fullName} is {age} years old and his weightis is {weight} lbs. He had a {weightLoss} lbs weight loss and is in good health.");
 
            Console.WriteLine(goodHealth);
            Console.WriteLine('\n');
            Console.WriteLine($"{fullName} is his name but we call him {nickName} for short and he achived this by working out {workOutdays} days a week");

            if (goodHealth == true)
            {
                Console.WriteLine('\n');
                Console.WriteLine($"{nickName} loves to work out.");

            }
            else

                Console.WriteLine($"{nickName} hates to work out.");

        }
    }
}
