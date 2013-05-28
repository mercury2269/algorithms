using System;

namespace MergeSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var input = new int[] { 5, 4, 9, 3, 2, 4, 5, 12, 99, 101, 1, 7, 9, 10, 13 };

			var result = MergeSort.Sort (input);


			foreach (var item in result) 
			{
				Console.WriteLine (item);
			}
		}
	}
}
