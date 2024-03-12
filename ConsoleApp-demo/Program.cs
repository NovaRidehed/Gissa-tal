namespace ConsoleApp_demo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa talet mellan 1-20. Du ka gissa tre gånger.");
            Random rand = new Random();
            //Random nummer mellan 1-20
            int tal = rand.Next(1, 21);
            //Hur många gånger man har gissat
            

            string gissningstring = Console.ReadLine();
            //Gör om stringformat till ett tal
            int gissning = int.Parse(gissningstring);

            //int gissningar = 0;
            int gissningar = 0;
            for (; gissningar < 3; gissningar++)
            {


                if (gissning == tal)
                {
                    Console.WriteLine("Du har gissat rätt! Talet är " + tal + "!");
                    gissningar = 4;
                }
                else if (gissning > tal && gissningar <2)
                {
                    Console.WriteLine("Lägre");
                }
                else if (gissning < tal && gissningar < 2)
                {
                    Console.WriteLine("Högre");
                }
             
                

                if(gissningar < 2)
                {
                    Console.WriteLine("Gissa igen!");
                    gissningstring = Console.ReadLine();
                    gissning = int.Parse(gissningstring);
                }
                

            }
            if (gissningar == 3)
            {
                Console.WriteLine("Du har gissat tre gånger. Talet var " + tal + "!");
            }
            // gissning nummer två


        }
    }
}