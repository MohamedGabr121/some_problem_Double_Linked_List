using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class DoubleLinkedList
	{
		Node head;
		Node tail;
		public DoubleLinkedList()
		{
			head = null;
			tail = null;
		}

		public void InsertAtBeginning(int data)
		{
			Node newNoed = new Node(data);

			if (head == null)
			{
				head = newNoed;
				tail = newNoed;
				newNoed.Next = newNoed.Per = null;
			}
			else
			{
				newNoed.Per = tail;
				newNoed.Next = null;
				tail.Next = newNoed;
				tail = newNoed;
			}

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
