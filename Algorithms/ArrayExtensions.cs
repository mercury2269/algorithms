using System;

namespace MergeSort
{
	public static class ArrayExtensions
	{
		public static T[] Concat<T>(this T[] first, T[] second) 
		{
			if(first == null) throw new InvalidOperationException("Missing first array");
			if(second == null) throw new InvalidOperationException("Missing second array");

			var oldSize = first.Length;

			Array.Resize<T>(ref first, first.Length + second.Length);
			Array.Copy (second, 0, first, oldSize, second.Length);
			return first;
		}

		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			T[] result = new T[length];
			Array.Copy(data, index, result, 0, length);
			return result;
		}

	}
}

