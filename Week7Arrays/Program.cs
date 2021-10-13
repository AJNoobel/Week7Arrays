using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "võileib juustuga", "jogurt", "banaan", "peekon", "muna" };

            food[3] = "viiner";
            food[1] = "viin";

            Console.WriteLine("Menüüs:");

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            Console.WriteLine("Vali Toit (Sisesta number 1-5: ");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"oled valinud {food[userchoice]} ");
        }
    }
}
