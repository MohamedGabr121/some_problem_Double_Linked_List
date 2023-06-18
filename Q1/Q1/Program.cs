﻿namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. Write a program in C to create and display a doubly linked list.
			DoubleLinkedList list = new DoubleLinkedList();
			Console.Write("Input the number of nodes :");
			int numberOfNode =int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNode; i++)
			{
				Console.Write($"Input data for node {i} : ");
				int noedOfList = int.Parse(Console.ReadLine());
				list.InsertAtBeginning(noedOfList);
			}
			// Display the doubly linked list
			list.DisplayDoubleLinkedList();
		}
	}
}