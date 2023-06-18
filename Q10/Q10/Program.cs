namespace Q10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 10. Write a program in C to delete a node from the middle of a doubly linked list.

			DoubelLinkedList list = new DoubelLinkedList();
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
			int res = list.MaxElementOfList();
			Console.Write(res);
			//list.DisplayLinkedList();
		}
	}
}