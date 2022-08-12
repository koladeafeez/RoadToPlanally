using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SUM_OF_BIGGEST_NEIGHBOR
{
    internal class Neigbor
    {

		public int Challenge(int[] input)
		{
			// Get the highest frequency of the element : M

			// eliminate all element of M - 1

			// find highest neighbor sum

			var memory = new Dictionary<int, int>();

			// Loop through the array and update each frequency
			for (var i = 0; i < input.Length; i++)
			{

				if (memory.ContainsKey(input[i]))
					memory[input[i]] += 1;
				else
					memory[input[i]] = 1;
			}
			// Get the maximum frequency
			var maxFrequncy = memory.Values.Max();

			// Select all the element with frequency less than maximum
			var lessThanMaxList = memory.Where(x => x.Value < maxFrequncy - 1).Select(x => x.Key).ToArray();

			// remove all the element less than maximum
			var validList = input.Where(x => !lessThanMaxList.Contains(x)).ToArray();

			// calculate initial neighbor sum
			var max_sum = 0;
			for (var i = 0; i < 2; i++)
			{
				max_sum += validList[i];
			}

			var window_sum = max_sum;

			// calculate next and compare
			for (var i = 2; i < validList.Length; i++)
			{
				window_sum += validList[i] - validList[i - 2];
				max_sum = Math.Max(max_sum, window_sum);
			}

			return max_sum;

		}

	}
}
