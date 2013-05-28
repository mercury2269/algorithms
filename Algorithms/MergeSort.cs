using System;
using System.Collections.Generic;

namespace MergeSort
{
	public class MergeSort
	{
		public static int[] Merge(int[] firstArray, int[] secondArray) 
		{
			if (firstArray.Length == 0)
				return secondArray;

			if (secondArray.Length == 0) 
				return firstArray;

			if (firstArray [0] < secondArray [0]) 
			{
				return Concat (firstArray[0], Merge (firstArray.SubArray(1, firstArray.Length - 1), secondArray));
			} 
			else 
			{
				return Concat (secondArray[0], Merge (firstArray, secondArray.SubArray (1, secondArray.Length - 1)));			
			}

		}

		public static int[] Sort(int[] arrayToSort) 
		{
			if (arrayToSort.Length == 1)
				return arrayToSort;

			int middle = Convert.ToInt32 (Math.Floor (arrayToSort.Length / 2m));
			var leftHalf = arrayToSort.SubArray (0, middle);
			var rightHalf = arrayToSort.SubArray (middle, (arrayToSort.Length - middle));
			return IterativeMerge (Sort(leftHalf), Sort (rightHalf));

		}

		public static int[] IterativeMerge(int[] leftArray, int[] rightArray) 
		{
			var result = new int[leftArray.Length + rightArray.Length];
			int leftIndex = 0;
			int rightIndex = 0;


			for (int i = 0; leftIndex < leftArray.Length && rightIndex < rightArray.Length; i++) 
			{
				if(leftArray[leftIndex] < rightArray[rightIndex])
				{
					result [i] = leftArray [leftIndex];
					leftIndex++;
				}
				else 
				{
					result [i] = rightArray [rightIndex];
					rightIndex++;
				}

				if(rightIndex >= rightArray.Length) {
					for(; leftIndex < leftArray.Length; leftIndex++) 
					{
						i++;
						result [i] = leftArray [leftIndex];
					}
				}

				if(leftIndex >= leftArray.Length) 
				{
					for(; rightIndex < rightArray.Length; rightIndex++) 
					{
						i++;
						result [i] = rightArray [rightIndex];
					}
				}
			}
			return result;
		}

		public static T[] Concat<T>(T item, T[] array) {
			var result = new T[array.Length + 1];
			result [0] = item;
			Array.Copy (array, 0, result, 1, array.Length);
			return result;

		}
	}
}

