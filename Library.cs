public static class Library
{
    public static string[] CreateArrayString(int count)
    {
        return new string[count];
    }

    public static string[] FillArrayString(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
        return array;
    }

    public static void PrintArrayString(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    public static void ArrayLength3(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }
}