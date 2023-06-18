namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 8. Write a program in C to delete a node from the last node of a doubly linked list.

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
			list.DeleteAnyPosition(2);
			Console.Write("After The Delete Last Element In The linked List = ");
			list.DisplayLinkedList();
		}
	}
}