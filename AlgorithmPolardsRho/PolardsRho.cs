using System.Numerics;

namespace AlgorithmPolardsRho;

public class PolardsRho
{
    public static int X = 2;
    public static int Y= 2;
    public static int C= 2;
    public static int Counter = 0;
    
    public static BigInteger Algorithm(int num)
    {
        try
        {
            int turtle = Function(X, num);
            int hare = Function(Function(Y, num), num);
            int dif = Math.Abs(turtle - hare);
            var result = BigInteger.GreatestCommonDivisor(dif, num);
        
            if (Counter < 1000)
            {
                if (dif == 0)
                {
                    X = 2;
                    Y = 2;
                    C += 1;
                    Counter++;
                    result = PolardsRho.Algorithm(num);
                }

                if (result == num || result == 1)
                {
                    X = turtle;
                    Y = hare;
                    Counter++;
                    result = PolardsRho.Algorithm(num);
                }
            }
            else
            {
                throw new Exception($"Не удалось факторизовать {num} за 1000 попыток. Скорее всего число простое.");
            }
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e); 
            return 0;
        }
    }

    private static int Function(int k, int num)
    {
        return ((k * k + C) % num);
    }
}