



public class Program
{
    static async Task Main(string[] args)
    {
        var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);

        Console.WriteLine(averageSalary);
    }



    public static async Task<(long averageSalary, long numberOfEmployee)> SomeCalculation(long num1, long num2, bool b)
    {
        long averageSalary = num1;
        long numberOfEmployee = num2;

        await Task.Run(() =>
        {
            int count = b ? 1 : 2;
            for (int i = 0; i < count; i++)
            {
                averageSalary = (averageSalary + (num1 - num2) / count);
                numberOfEmployee = count;
            }
        });

        return (averageSalary, numberOfEmployee);
    }

}