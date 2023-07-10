using System.Text;
using System.Text.RegularExpressions;

namespace SummString;

public class SummStringClass
{
    public int SummNumbers(string textNumbers)
    {
        if (string.IsNullOrEmpty(textNumbers))
            return 0;
        string[] numbers = textNumbers.Split(GetSeparator(textNumbers)); 
        int sum = 0;
        string[] clearNumbers = removeSymbols(numbers);
        foreach (string number in clearNumbers) {
            int parsedNumber;
            if (int.TryParse(number, out parsedNumber)) {
                sum += parsedNumber;
            }
        }
        return sum;
    }
    private string GetSeparator(string textNumbers)
    {
        if (textNumbers.StartsWith("//"))
        {
            int separatorEndIndex = textNumbers.IndexOf('\n');
            return textNumbers.Substring(2, separatorEndIndex - 2);
        }
        else
        {
            return " ";
        }
    }

    private string[] removeSymbols(string[] textNumbers)
    {
        string[] numbers = new string[textNumbers.Length];

        for (int i = 0; i < textNumbers.Length; i++)
        {
            string onlyNumbers = Regex.Replace(textNumbers[i], "[^0-9]", "");
            numbers[i] = onlyNumbers;
        }

        return numbers;
    }
}