namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 6. Write a program in C to insert a new node in the middle of a doubly linked list.



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
			Console.Write("Insert The Data To Middle  The Linked List = ");
			int dataInsert = int.Parse(Console.ReadLine());
			Console.WriteLine();
			list.InsertMiddel(dataInsert);
			list.DisplayLinkedList();
		}
	}
}