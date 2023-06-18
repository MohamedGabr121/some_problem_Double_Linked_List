using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Node
	{
		int data;
		Node next;
		Node per;

		public Node(int Data)
		{
			data = Data;
			next = null;
			per = null;
		}

		public int Data
		{
			get { return data; }
			set { data = value; }
		}
		public Node Per
		{
			get { return per; }
			set { per = value; }
		}
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}
	}
}
