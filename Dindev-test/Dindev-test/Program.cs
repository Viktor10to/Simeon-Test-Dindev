namespace Dindev_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4 , 3 , 2 , 36 , 6 , 12 , 11 , 23, 5, 8, 1, 7 };
            Array.Sort(arr);

            int start = arr[0];
            int length = 1;
            int maxStart = start;
            int maxLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        maxStart = arr[i - length + 1];
                    }
                }
                else
                {
                    length = 1;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
           
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write((maxStart + i) + " ");
            }
            Console.WriteLine();
            Console.Write("duljina - ");
            Console.WriteLine(maxLength);
        }
    }
}
