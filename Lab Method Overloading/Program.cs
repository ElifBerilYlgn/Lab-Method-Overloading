
class Program
{
    static void Main()
    {



        int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };

        Console.WriteLine(CalculateAverage(70, 90));
        Console.WriteLine(CalculateAverage(70, 75, 90));
        Console.WriteLine(CalculateAverage(grades));
    }

    static int CalculateAverage(int grade1, int grade2)
    {
        return (grade1 + grade2) / 2;
    }

    static int CalculateAverage(int grade1, int grade2, int grade3)
    {
        return (grade1 + grade2 + grade3) / 3;
    }

    static double CalculateAverage(int[] grades)
    {
        double sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        return sum / grades.Length;
    }
}
