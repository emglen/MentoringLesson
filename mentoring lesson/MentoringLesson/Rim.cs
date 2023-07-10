namespace RimConverter;

public class Rim
{
    public string Convert(int number)
    {
        int[] arabic = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        string romanNumber = "";

        for (int i = 0; i < arabic.Length; i++)
        {
            while (number >= arabic[i])
            {
                romanNumber += roman[i];
                number -= arabic[i];
            }
        }
        return romanNumber;
    }
    
}