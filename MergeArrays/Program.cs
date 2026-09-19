namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {

        string[] names1 = {"andy", "bob", "zach"};
        string[] names2 = {"ben", "wisdom", "xavier"};

        var sortednames = MergeSortedArrays<string>(names1, names2);

        System.Console.WriteLine(sortednames[0]);
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];

        int index1 = 0;
        int index2 = 0;
        int indexResult = 0;

        while (index1 < array1.Length && index2 < array2.Length)
        {
            if (array1[index1] <= array2[index2])
            {
                result[indexResult] = array1[index1];
                index1++;
            }
            else
            {
                result[indexResult] = array2[index2];
                index2++;
            }
            indexResult++;
        }

        while (index1 < array1.Length)
        {
            result[indexResult] = array1[index1];
            index1++;
            indexResult++;
        }

        while (index2 < array2.Length)
        {
            result[indexResult] = array2[index2];
            index2++;
            indexResult++;
        }

        return result;
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    // TODO
    public static T[] MergeSortedArrays<T>(T[] array1, T[] array2) where T:IComparable<T>
    {

        T[] result = new T[array1.Length + array2.Length];

        int index1 = 0;
        int index2 = 0;
        int indexResult = 0;

        // LOOP
        while (index1 < array1.Length && index2 < array2.Length)
        {
            if (array1[index1].CompareTo(array2[index2]) <= 0)
            {
                result[indexResult] = array1[index1];
                index1++;
            }
            else
            {
                result[indexResult] = array2[index2];
                index2++;
            }
            indexResult++;
        }

        while (index1 < array1.Length)
        {
            result[indexResult] = array1[index1];
            index1++;
            indexResult++;
        }

        while (index2 < array2.Length)
        {
            result[indexResult] = array2[index2];
            index2++;
            indexResult++;
        }
        // END LOOP

        return result;
    }
}

