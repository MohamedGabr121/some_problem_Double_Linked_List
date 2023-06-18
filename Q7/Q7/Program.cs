namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 7. Write a program in C to delete a node from the beginning of a doubly linked list.

			DoubleLinkedList list = new DoubleLinkedList();
			Console.Write("Input the number of nodes :");
			int numberOfNode = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNode; i++)
			{
				Console.Write($"Input data for node {i} : ");
				int noedOfList = int.Parse(Console.ReadLine());
				list.AddNode(noedOfList);
			}
			// Display the doubly linked list
			list.DisplayLinkedList();
			Console.WriteLine();
			//int res = list.SizeList();
			//Console.WriteLine(res);
			list.DeleteFirstElementInLinkedList();
			Console.Write("After The Delete First Element In The linked List = ");
			list.DisplayLinkedList();
		}
	}
}