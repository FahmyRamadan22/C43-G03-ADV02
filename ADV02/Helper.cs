using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
    internal static class Helper
    {
        #region Question 01

        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
                Console.Write(item + " ");

            Console.WriteLine();

        }


        public static void PrintGreaterThanValue(int[] arr, int[] queries)
        {
            for (int i = 0; i < queries.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                    if (arr[j] > queries[i])
                        count++;

                Console.WriteLine($"Number of elements greater than {queries[i]} is: {count}");
            }
        }


        #endregion

        #region Question 02

        public static bool IsPlaindrome(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] != numbers[numbers.Length - i - 1])
                    return false;
            }

            return true;
        }


       
        public static bool IsPlindrome2(int[] numbers)
        {

            return numbers.SequenceEqual(numbers.Reverse());
        }



        #endregion

        #region Question 03

        public static Queue<T> ReverseQueueUsingStack<T>(Queue<T> queue)
        {
            Stack<T> tempStack = new Stack<T>();

            while (queue.Count > 0)
                tempStack.Push(queue.Dequeue());

            while (tempStack.Count > 0)
                queue.Enqueue(tempStack.Pop());

            return queue;


        }

        #endregion

        #region Question 04

        public static bool IsMatchedPair(char Open, char Closed)
        {
            if (Open == '(' && Closed == ')')
                return true;
            else if (Open == '{' && Closed == '}')
                return true;
            else if (Open == '[' && Closed == ']')
                return true;

            return false;
        }


        public static bool IsBalancedString(string expression)
        {
            Stack<char> tempStack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' || expression[i] == '[' || expression[i] == '{')
                    tempStack.Push(expression[i]);
                else if (expression[i] == ')' || expression[i] == ']' || expression[i] == '}')
                {
                    if (tempStack.Count == 0 || !IsMatchedPair(tempStack.Peek(), expression[i]))
                        return false;
                    else
                        tempStack.Pop();
                }

            }

            return tempStack.Count == 0;
        }
        #endregion

        #region Question 05

        public static T[] RemoveDuplicates<T>(T[] arr) where T : struct
        {
            if (arr.Length == 0)
                return arr;

        


            Array.Sort(arr);

            T[] tempArray = new T[arr.Length];
            tempArray[0] = arr[0];
            int count = 1;


            for (int i = 1; i < arr.Length; i++)
                if (!arr[i].Equals(arr[i - 1]))

                    

                    tempArray[count++] = arr[i];  

            T[] result = new T[count]; // 4
            Array.Copy(tempArray, result, count);

            return result;

        }


        #endregion

        #region Question 06

        public static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((int?)list[i] % 2 != 0)
                {

                    list.RemoveAt(i);
                }

            }
        }


        #endregion

        #region Question 08

        public static void FindTargetInStack(Stack<int> stack, int target)
        {
            bool found = false;
            int count = 0;

            foreach (var item in stack)
            {
                if (item == target)
                {
                    found = true;
                    break;
                }

                count++;

            }

            if (found)
                Console.WriteLine($"Target is found and the count is {count}");
            else
                Console.WriteLine("Target is not found");




        }

        #endregion

        #region Question 09
        public static T[] FindInteresection<T>(T[] arr1, T[] arr2) where T : struct, IComparable
        {

            Array.Sort(arr1);
            Array.Sort(arr2);

            List<T> intersectionList = [];

            int i = 0, j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i].CompareTo(arr2[j]) == -1)
                    i++;
                else if (arr1[i].CompareTo(arr2[j]) == 1)
                    j++;
                else
                {
                    
                    intersectionList.Add(arr1[i]);
                    i++;
                    j++;


                }
            }

            return intersectionList.ToArray();

        }



        #endregion

        #region Question 10
        public static int[]? FindContSubArray(ArrayList arrayList, int target)
        {
            if (arrayList.Count == 0)
                return null;

            int n = arrayList.Count;

            int[] arr = (int[])arrayList.ToArray(typeof(int));

         

            for (int i = 0; i < n; i++)
            {
                int currentSum = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == target)
                    {
                        int[] result = new int[j - i + 1];
                        Array.Copy(arr, i, result, 0, j - i + 1);
                        return result;
                    }
                }
            }
            return null;
        }

        #endregion

        #region Question 11

        public static Queue<int>? ReverseKElements(Queue<int> queue, int k)
        {
            if (k <= 0 || k >= queue.Count)
            {
                Console.WriteLine("Invalid K value");
                return null;
            }

            Stack<int> tempStack = new Stack<int>();

            for (int i = 0; i < k; i++)
                tempStack.Push(queue.Dequeue());

            for (int i = 0; i < k; i++)
                queue.Enqueue(tempStack.Pop());

            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());

            return queue;


        }

        #endregion
    }

}

