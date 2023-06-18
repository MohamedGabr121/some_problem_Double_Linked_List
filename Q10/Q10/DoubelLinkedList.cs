using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
	internal class DoubelLinkedList
	{
		Node head;
		Node tail;
		public DoubelLinkedList()
		{
			head = tail = null;
		}
		public void AddNode(int data)
		{
			Node newNoed = new Node(data);
			if (head == null)
			{
				head = newNoed;
				tail = newNoed;
				newNoed.Next = newNoed.Previous = null;
			}
			else
			{
				newNoed.Next = null;
				newNoed.Previous = tail;
				tail.Next = newNoed;
				tail = newNoed;
			}
		}

		public int SizeList()
		{
			Node current = head;
			int count = 0;
			while (current != null)
			{
				current = current.Next;
				count++;
			}
			return count;
		}

		public void DeleteToMiddelList()
		{
			int size = SizeList();
			int middle = size / 2;
			if(size == 0)
			{
                Console.WriteLine("The List IS Empty ");
            }
            else
            {
				Node curr = head;
				for (int i = 1; i < middle-1; i++)
				{
					curr = curr.Next;
				}
				if(curr !=null && curr.Next != null)
				{
					Node deleNode = curr.Next;
					curr.Next= curr.Next.Next;
					if(curr.Next.Next != null)
						curr.Next.Next.Previous = curr.Next;
					deleNode = null;
				}
            }
        }

		public int MaxElementOfList()
		{
			int max = head.Data;
			Node current = head;

			while (current != null)
			{
				if (current.Data > max)
				{
					max = current.Data;
				}
				current = current.Next;
			}

			return max;

		}
		public void DisplayLinkedList()
		{
			Node current = head;
			if (head == null)
			{
				Console.WriteLine("The List Is Empty ");
			}
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}
		}
	}
}

