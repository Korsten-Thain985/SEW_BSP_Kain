namespace SEW_BSP_Kain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Ganzzahl ein um zu Prüfen ob sie eine Primzahl ist");
            int inpt;
            int.TryParse(Console.ReadLine(), out inpt);


            if (inpt % inpt == 0 ) 
            {
                Console.WriteLine($"{inpt} ist eine Primzahl");
            }
            else { Console.WriteLine($"{inpt} ist keine Primzahl");}
            Console.ReadKey();
        }
    }
}