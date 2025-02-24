using System;
using System.Collections;

namespace ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.


            //int arrSize, queriesNumber;

            //do
            //{
            //    Console.Write("Enter the size of the array: ");
            //} while (!int.TryParse(Console.ReadLine(), out arrSize));

            //do
            //{
            //    Console.Write("Enter the number of queries: ");
            //} while (!int.TryParse(Console.ReadLine(), out queriesNumber));

            //int[] arr = new int[arrSize];

            //Console.WriteLine("Enter the elements of the array");

            //for (int i = 0; i < arrSize; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the element number {i + 1}: ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}

            //int[] queries = new int[queriesNumber];

            //for (int i = 0; i < queriesNumber; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the query number {i + 1}: ");
            //    } while (!int.TryParse(Console.ReadLine(), out queries[i]));
            //}

            //Helper.PrintGreaterThanValue(arr, queries);

            #endregion
            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int[] numbers = [1, 3, 2, 3, 1];

            //bool isPlaindrome = Helper.IsPlaindrome(numbers);

            //if (isPlaindrome)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            //isPlaindrome = Helper.IsPlindrome2(numbers);

            //if (isPlaindrome)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            #endregion
            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.


            //Queue<int> queue = new([1, 2, 3, 4]);
            //Queue<int> reversedQueue = Helper.ReverseQueueUsingStack(queue);

            //foreach (var item in reversedQueue)
            //    Console.Write(item + " ");
            #endregion
            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string str = "[()]{}";
            //bool isBalanced = Helper.IsBalancedString(str);

            //if (isBalanced)
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");

            #endregion
            #region 5. Given an array, implement a function to remove duplicate elements from an array.

            //int[] arr = [1, 4, 4, 2, 5, 2];
            //int[] result = Helper.RemoveDuplicates(arr);

            //Helper.PrintCollection(result);

            #endregion
            #region 6. Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Helper.RemoveOddNumbers(list);

            //Helper.PrintCollection(list);

            #endregion
            #region 7. Implement a queue that can hold different data types. 


            //Queue queue = new();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Helper.PrintCollection(queue);


            #endregion
            #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).

            //Stack<int> numbers = new([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);

            //int target = 5;

            //Helper.FindTargetInStack(numbers, target);
            #endregion
            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int[] arr1 = [1, 2, 3, 4, 4];
            //int[] arr2 = [10, 4, 4];

            //int[] result = Helper.FindInteresection(arr1, arr2);

            //Helper.PrintCollection(result);

            //char[] arr3 = ['a', 'b', 'b', 'c', 'd', 'c'];
            //char[] arr4 = ['b', 'b', 'c', 'd', 'c'];

            //char[] result2 = Helper.FindInteresection(arr3, arr4);

            //Helper.PrintCollection(result2);
            #endregion
            #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //ArrayList arrayList = [1, 2, 3, 7, 5];
            //int target = 12;

            //int[] result = Helper.FindContSubArray(arrayList, target)!;

            //Helper.PrintCollection(result);

            #endregion
            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            //Queue<int> queue = new Queue<int>([1, 2, 3, 4, 5]);
            //int k = 3;

            //Queue<int> result = Helper.ReverseKElements(queue, k)!;

            //Helper.PrintCollection(result);

            #endregion
        }
    }
}
