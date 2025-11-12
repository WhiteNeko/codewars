namespace Kyu4AddingBigNumbers;

public class Kata
{
    public static string Add(string a, string b)
    {
        bool overflow = false;
        string result = "";
        (string num1, string num2) = makeNumberEqualLenght(a, b);


        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int z = 0;
            int x = num1[i] - '0';
            int y = num2[i] - '0';
            z = y + x;


            if (overflow)
            {
                z++;
                overflow = false;
            }

            if (i == 0)
            {
                result = z.ToString() + result;
                break;
            }

            if (z >= 10)
            {
                z %= 10;
                overflow = true;
            }

            result = z.ToString() + result;
        }

        result = removeExtraZeroes(result);
        return result;
    }

    public static (string a, string b) makeNumberEqualLenght(string a, string b)
    {
        string num1 = a;
        string num2 = b;
        if (a.Length > b.Length)
        {
            for (int i = 0; i < num1.Length - num2.Length; i++) b = "0" + b;
            return (a, b);
        }

        for (int i = 0; i < num2.Length - num1.Length; i++) a = "0" + a;
        return (a, b);
    }

    public static string removeExtraZeroes(string a)
    {
        return a[0] == '0' ? a.Remove(0) : a;
    }
}