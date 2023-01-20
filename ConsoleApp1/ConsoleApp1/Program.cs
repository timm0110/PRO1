class Program
{
    static void Main(string[] args)
    {
        Random nakljucno = new Random();
        Console.WriteLine("zacetno ");
        String beri = Console.ReadLine();
        int denar = int.Parse(beri);
        int zacentni = denar;
        
        Console.WriteLine("koliko stavis");
        beri = Console.ReadLine();
        int Pstava = int.Parse(beri);
        int stava = Pstava;

        int min = denar + 1;
        int max = 0;
        int umes = 0;

        for (int i = 0; i < 10; i++)
        {
            int rand = nakljucno.Next(36);

            if (rand % 2 == 0)
            {
                denar = denar + stava;
                Console.WriteLine("rdeca stanje je: " + denar);
                Console.WriteLine("");
                stava = Pstava;
                if (max < denar)
                {
                    max = denar;
                }

                continue;

            }
            else
            {
                denar = denar - stava;
                Console.WriteLine("crna stanje je: " + denar);
                Console.WriteLine("");
                stava = stava + stava;
                if (min > denar)
                {
                    min = denar;
                }

            }

        }
        int konc = denar;
        int razlika = konc - zacentni;
        Console.WriteLine("Najmanj si imel: " + min);
        Console.WriteLine("Največ si imel: " + max);
        Console.WriteLine("Razlika: " + razlika);

    }


}










