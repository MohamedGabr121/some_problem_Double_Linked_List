using Q10;

namespace Q12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 12. Write a C program to convert a Doubly Linked list into a string.
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

			string res = list.ConvertToString();

			Console.WriteLine(res);
		}
	}
}