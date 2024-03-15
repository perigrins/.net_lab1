using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Drawing;
[assembly: InternalsVisibleTo("UnitTest1")]
[assembly: InternalsVisibleTo("testproject_lab1_grzebieluch")]
[assembly: InternalsVisibleTo("test_lab1_grzebieluch")]
[assembly: InternalsVisibleTo("Form1")]
[assembly: InternalsVisibleTo("WinFormsApp1")]

namespace lab1_grzebieluch_3
{
	public class Item : IComparable<Item>
	{
		public int value { get; }
		public int weight { get; }
		public bool inside { get; set; }		// 1 - inside, 0 - not inside
		public double proportion { get; }		// value / weight
		public Item(int Weight, int Value)
		{
			weight = Weight;
			value = Value;
			proportion = (double) value / weight;
		}
		public int CompareTo(Item other)
		{
			return proportion.CompareTo(other.proportion);
		}
	}

	public class Sorting : IComparer<Item>
	{
		public int Compare(Item a, Item b)
		{
			return b.proportion.CompareTo(a.proportion);
			//return -a.proportion.CompareTo(b.proportion);
		}
	}
	public class Knapsack
	{
		private int capacity;
		private readonly int nr;		// number of items
		private Item[] items;
		private int itemSize;
		private int valueSum;

		public Knapsack(int Nr, int Capacity)
		{
			nr = Nr;
			capacity = Capacity;
		}
		public int ItemSize { get => items.Length; }
		public int ValueSum { get => valueSum; set => valueSum = value; }

		public void Generate()
		{
			// ----------------------------------------------------------------------
			// DO TESTÓW JEDNOSTKOWYCH ZAKOMENTOWAĆ 2 PIERWSZE LINIJKI I ZMIENIĆ SEED

			//Console.WriteLine("enter seed: ");
			//int seed = int.Parse(Console.ReadLine());
			int seed = 7;
			Random random = new Random(seed);
			items = new Item[nr];
			for (var i = 0; i < nr; i++)
			{
				items[i] = new Item(random.Next(1, 10), random.Next(1, 10));
				//items[i] = new Item(random.Next(10), random.Next(10));
			}
		}
		public void Show()
		{
			for (var i = 0; i < items.Length; i++)		// nr albo items.Length()
			{
				Console.WriteLine(
					$"{i + 1:00}| w/v: {items[i].proportion:00.00}| w: {items[i].weight:00}| v: {items[i].value:00}| inside: {items[i].inside}");
			}
		}
		public void Sort()
		{
			Sorting sortDesc = new Sorting();		// malejąco po proportion (v/w)
			Array.Sort(items, sortDesc);
		}
		public void Fit()
		{
			var sum = 0;
			var i = 0;
			while (i < nr)
			{
				items[i].inside = true;
				sum += items[i].weight;

				if ((sum + items[i].weight) > capacity)
				{
					break;
				}
				i++;
				
			}
		}
		public void Result()
		{
			var value_sum = 0;
			var weight_sum = 0;
			foreach (var item in items)
			{
				if (item.inside)
				{
					value_sum += item.value;
					weight_sum += item.weight;
				}
			}
			ValueSum = value_sum;
			//Console.WriteLine($"total value in the knapsack: {value_sum:00}");
			//Console.WriteLine($"total weight in the knapsack: {weight_sum:00}");
		}
		
	}

}
