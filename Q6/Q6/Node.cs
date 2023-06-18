using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Node
	{
		int data;
		Node next;
		Node per;
		public Node(int value)
		{
			data = value;
			next = null;
			per = null;
		}
		public int Data
		{
			get { return data; }
			set { data = value; }
		}
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}
		public Node Previous
		{
			get { return per; }
			set { per = value; }
		}
	}
}
