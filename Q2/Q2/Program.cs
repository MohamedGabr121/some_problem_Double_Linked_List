namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 2. Write a program in C to create a doubly linked list and display it in reverse order.

			DoubleLinkedList list = new DoubleLinkedList();
			Console.Write("Input the number of nodes :");
			int numberOfNode = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNode; i++)
			{
				Console.Write($"Input data for node {i} : ");
				int noedOfList = int.Parse(Console.ReadLine());
				list.ReversList(noedOfList);
			}
			// Display the doubly linked list
			list.DisplayLinkedList();
		}
	}
}