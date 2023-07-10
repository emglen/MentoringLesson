namespace mentoring_lesson;

public class FizzBuzz
{
    public FizzBuzz()
    {
    }

    public string Process (int number) {
        var x = (number % 3) == 0;
        var y = (number % 5) == 0;
        if (x && y)
            return "FizzBuzz";
        else if (y)
            return "Buzz";
        else if (x)
            return "Fizz";
        else return number.ToString();
    }
}