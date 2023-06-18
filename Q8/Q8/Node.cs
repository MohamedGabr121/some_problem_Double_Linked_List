using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Node
	{
		int data;
		Node Next;
		Node per;
		public Node(int value)
		{
			data = value;
			Next = null;
			per = null;
		}
		public int Data
		{
			get { return data; }
			set { data = value; }
		}
		public Node Next
		{
			get { return Next; }
			set { Next = value; }
		}
		public Node Previous
		{
			get { return per; }
			set { per = value; }
		}
	}
}
