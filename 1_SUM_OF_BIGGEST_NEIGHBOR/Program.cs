// See https://aka.ms/new-console-template for more information



using _1_SUM_OF_BIGGEST_NEIGHBOR;

public class Program
{
	public static void Main(string[] args)
	{

		var neighbor = new Neigbor();

		int[] list = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
		int[] list2 = { 1, 1, 5, 5, 3, 3, 3 };
		int[] list3 = { 1,6,1,2,6,1,6,6};
		int[] list4 = { 2, 1, 1, 6 };

       var result = neighbor.Challenge(list4);

		Console.WriteLine(result);

    }


   

}


