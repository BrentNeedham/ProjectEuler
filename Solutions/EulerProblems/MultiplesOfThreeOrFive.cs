namespace Solutions.EulerProblems;

public static class MultiplesOfThreeOrFive
{
    public static int DoublePass()
    {
        const int MAX_VALUE = 1000;
        int sum = 0;

        for (int i = 3; i < MAX_VALUE; i += 3)
        {
            sum += i;
        }

        for (int i = 5; i < MAX_VALUE; i += 5)
        {
            if (i % 3 != 0)
            {
                sum += i;
            }
        }

        return sum;
    }

    public static int BruteForce()
    {
        const int MAX_VALUE = 1000;
        int sum = 0;

        for (int i = 0; i < MAX_VALUE; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
            }
            else if (i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}
