using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ArrayOperations
    {
        int[] marksArray;
        public void CreateArray(int num)
        {
            marksArray = new int[num];
        }
        public void insertMarks(int num)
        {
            for (int i = 0; i< num; i++)
            {
                int marks = 0;
                Console.WriteLine("enter marks for subject{0}", i + 1);
                marks = int.Parse(Console.ReadLine());
                marksArray[i] = marks;
            }
        }
        public int findTotal()
        {
            int total = 0;
            foreach (int m in marksArray)
            {
                total = total + m;

            }
            return total;
        }
        public int avgMarks()
        {
            int avg = findTotal() / marksArray.Length;
            return avg;
        }
        public int minMarks()
        {
            int min = marksArray[0];
            foreach (int marks in marksArray)
            {
                if (marks < min)
                {
                    min = marks;
                }
            }
            return min;
        }
        public int maxMarks()
        {
            int max = marksArray[0];
            foreach (int marks in marksArray)
            {
                if (marks > max)
                {
                    max = marks;
                }
            }
            return max;
        }
        public void sortAscending()
        {
            Array.Sort(marksArray);
            Console.WriteLine("marks in ascending order");
            foreach (int marks in marksArray)
            {
                Console.Write(marks + "");
            }
            Console.WriteLine();
        }
        public void sortDescending()
        {
            Array.Reverse(marksArray);
            Console.WriteLine("marks in descending ordr:");
            foreach (int marks in marksArray)
            {
                Console.Write(marks + "");
            }
            Console.WriteLine();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations arr = new ArrayOperations();
            int num;
            Console.WriteLine("enter no of subjects");
            num = Convert.ToInt32(Console.ReadLine());
            arr.CreateArray(num);
            arr.insertMarks(num);
            int ch;
            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("select your choice:\n1.total marks\n2.average marks\n3. min.marks\n4.max.marks\n5.marks in acs order\n6.marks in des order\n7.exit");
                Console.WriteLine("------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("total marks:{0}", arr.findTotal());
                        break;
                    case 2:
                        Console.WriteLine("average of marks:{0}", arr.avgMarks());
                        break;
                    case 3:
                        Console.WriteLine("min marks:{0}", arr.minMarks());
                        break;
                    case 4:
                        Console.WriteLine("max marks:{0}", arr.maxMarks());
                        break;
                    case 5:
                        arr.sortDescending();
                        break;
                    case 6:
                        arr.sortAscending();
                        break;
                    default:
                        Console.WriteLine("wrong choice!");
                        break;
                }
            }
            while (ch != 7);
        }
    }
}
