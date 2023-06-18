using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
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
		public void DeleteFirstElementInLinkedList()
		{
			
			int size =SizeList();
			if(size ==0)
			{
                Console.WriteLine("Empty List ");
            }
			else if(size ==1)
			{
				head = tail = null;
			}
			else
			{
				head = head.Next;
				head.Previous = null;

			}
		}

		public void DeleteLastElementInLinkedList()
		{
			int size = SizeList();

			if (size == 0)
			{
				Console.WriteLine("Empty List ");
			}
			else if (size == 1)
			{
				head = tail = null;
			}
			else
			{
				tail = tail.Previous;
				tail.Next = null;
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
