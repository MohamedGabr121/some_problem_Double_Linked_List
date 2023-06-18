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

