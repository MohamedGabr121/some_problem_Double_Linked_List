using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class DoubleLinkedList
	{
		Node head;
		Node tail;
		public DoubleLinkedList()
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

		public void InsertAnyPosition(int data ,int position)
		{
			Node newNode = new Node(data);

			if(position == 1)
			{
				newNode.Next = head;
				newNode.Previous = null;
				head.Previous = newNode;
				head = newNode;
			}
			else
			{
				Node current = head;
				for (int i = 1; i < position-1; i++)
				{
					current = current.Next;
				}
				newNode.Next = current.Next;
				newNode.Previous = current;
				current.Next = newNode;
				current.Next.Previous = newNode;
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
