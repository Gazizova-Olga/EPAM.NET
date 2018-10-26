using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedTest = new LinkedList<int>();
            List<int> listTest = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                linkedTest.AddLast(i);
                listTest.Add(i);
            }
            PrintingList(listTest);
            //PrintingLinkedList(linkedTest);
            RemoveEachSecondItemLinkedList(linkedTest);
            RemoveEachSecondItemList(listTest);
            PrintingList(listTest);
            Console.ReadKey();
        }

        public static void PrintingList<T>(List<T> list)
        {
            Console.WriteLine("List");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        /*public static void PrintingLinkedList<T>(LinkedList<T> llist)
        {
            Console.WriteLine("Linked List");
            var current = llist.First;
            var currentValue = llist.First.Value;
            //  for (int i = 0; i < llist.Count; i++)
            int i = -1;
             while(i< llist.Count-1)
            {
                i++;
                current=current.Next;
                currentValue=current.Value;
                Console.WriteLine(currentValue);
            }
        }*/

        private static void RemoveEachSecondItemList<T>(List<T> list)
        {
            int i = 0;

            while (list.Count != 1)
            {
                if (i == list.Count - 1)
                {
                    i = -1;
                }
                else
                {
                    if (i > list.Count - 1)
                    {
                        i = 0;
                    }
                }
                i++;
                list.RemoveAt(i);
            }
        }

        private static void RemoveEachSecondItemLinkedList<T>(LinkedList<T> list)
        {
            var delItem = list.First;
            while (list.Count > 1)
            {
                if (delItem.Next != null)
                {
                    list.Remove(delItem.Next);
                }
                else
                {
                    list.Remove(list.First);
                    delItem = list.First;
                    continue;
                }

                if (delItem.Next != null)
                {
                    delItem = delItem.Next;
                }
                else
                {
                    delItem = list.First;
                }
            }
        }

       
    }
}
