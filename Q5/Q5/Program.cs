namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 5. Write a program in C to insert a new node at any position in a doubly linked list.


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
            Console.Write("Insert The Data In Linked List = ");
            int dataInsert = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please Enter The Position = ");
			int position = int.Parse(Console.ReadLine());
            Console.WriteLine();
			list.InsertAnyPosition(dataInsert, position);
			list.DisplayLinkedList();

		}
	}
}