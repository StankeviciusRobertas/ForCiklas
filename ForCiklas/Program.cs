namespace ForCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;                
            //}
            //Console.WriteLine("Suma: " + sum);

            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    int sum = i * i;                
            //    Console.WriteLine("Kvadratu: " + sum);
            //}
            //

            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int vidurkis = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    sum = 0;

            //    for (int j = 1; j <= i; j++)
            //    {
            //        sum += j;
            //        //Console.WriteLine("vidurkis: " + vidurkis);
            //    }
            //    vidurkis = sum / i;
            //    Console.WriteLine("vidurkis: " + vidurkis);
            //}

            //int userInput = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < userInput; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //int userInput = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= 100; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //int num = 1;
            //int num2 = 9;
            //int sum = 0;

            //for (int i = 1; i <= num2; i++)
            //{                                
            //    for (int j = 1; j <= num2; j++)
            //    {
            //        sum = j * i;
            //        Console.WriteLine(i + " x " + j + " = " + sum);
            //    }                
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 2; i <= userInput; i++)
            {
                bool arTuriLiekana = false;
                int liekana = 0;

                for (int j = 2; j < i; j++)
                {
                    liekana = i % j;
                    if (liekana == 0)
                    {              
                        arTuriLiekana = true;
                    }                  
                    
                }
                if (!arTuriLiekana)
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}