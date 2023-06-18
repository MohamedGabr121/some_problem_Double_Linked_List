using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q6
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
		public void InsertMiddel(int data)
		{
			Node newNode = new Node(data);
			int size = SizeList();
			int middel = size / 2;
			if (head == null)
			{
				head = newNode;
				tail = newNode;
			}
			else
			{
				Node current = head;
				for (int i = 1; i <= middel - 1; i++)
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
