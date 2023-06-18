using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class DoubleLinkedList
	{
		Node head;
		Node tail;


		public DoubleLinkedList()
		{
			head = tail = null;
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
				newNoed.Next = head;
				newNoed.Per = null;
				head.Per = newNoed;
				head = newNoed;
			}
		}

		public void InsertAtEnd(int data)
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
				newNoed.Next = null;
				newNoed.Per = tail;
				tail.Next = newNoed;
				tail = newNoed;
			}
		}

		public void DisplayDoubleLinkedList()
		{
			Node current = head;

			if (head == null)
			{
				Console.WriteLine("The Linked List Is Empty");
			}
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}
		}
	}
}
