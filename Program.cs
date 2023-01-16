//using System;

//namespace SortArrayExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
//            int temp = 0;

//            for (int i = 0; i <= intArray.Length - 1; i++)
//            {
//                for (int j = i + 1; j < intArray.Length; j++)
//                {
//                    if (intArray[i] > intArray[j])
//                    {
//                        temp = intArray[i];
//                        intArray[i] = intArray[j];
//                        intArray[j] = temp;
//                    }
//                }
//            }
//            Console.WriteLine("Array sort in asscending order");
//            foreach (var item in intArray)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadLine();
//        }
//    }
//}

//int[] arr = { 1, 2, 8, 5, 31 };

//    int i = 0;
//    int sum = 0;
//    float average = 0.0F;

//   for (i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}

//    average = (float)sum / arr.Length;

//Console.WriteLine("Average of Array elements: " + average);


//int[] arr = new int[] { 5, 2, 3, 24, 9 };
//int length = arr.Length - 1;
//    string strReverse = null;
//    while (length >= 0)
//{
//    strReverse = strReverse + arr[length];
//    length--;
//}
//Console.WriteLine();
//Console.WriteLine("Reverse Array is " + " " + strReverse);
//Console.ReadLine();
