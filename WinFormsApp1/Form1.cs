using lab1_grzebieluch_3;
using System.Xml.Linq;
using System.Drawing.Text;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp1
{
	public static class Globals
	{
		public static int elementsG;
		public static int capacityG;
		public static int seedG;
	}
	public partial class Form1 : Form
	{
		int elements;
		int capacity;
		int seed;

		public Form1()
		{
			InitializeComponent();
		}

		public class Item : IComparable<Item>
		{
			public int value { get; }
			public int weight { get; }
			public bool inside { get; set; }        // 1 - inside, 0 - not inside
			public double proportion { get; }       // value / weight
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
			}
		}
		public class Knapsack
		{
			//int seed;
			private int capacity;
			private readonly int nr;        // number of items
			public Item[] items;
			private int valueSum;
			//private int itemSize;

			public Knapsack(int Nr, int Capacity)
			{
				nr = Nr;
				capacity = Capacity;
			}

			public int ItemSize { get => items.Length; }
			public int ValueSum { get => valueSum; set => valueSum = value; }

			public void Generate()
			{ 
				Random random = new Random(Globals.seedG);
				items = new Item[nr];     // nr = items.length
				for (var i = 0; i < nr; i++)
				{
					items[i] = new Item(random.Next(1, 10), random.Next(1, 10));
				}
			}

			public void Sort()
			{
				Sorting sortDesc = new Sorting();       // descending (v/w)
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
			public void DisplayResults(System.Windows.Forms.TextBox textBox_results)
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
				valueSum = value_sum;
				//textBox_results.Clear();
				textBox_results.AppendText($"total value in the knapsack: {value_sum:00}\n");
				textBox_results.AppendText(Environment.NewLine);
				textBox_results.AppendText($"total weight in the knapsack: {weight_sum:00}");
			}

			public void DisplayBag(System.Windows.Forms.TextBox textBox_sortedBagView)
			{
				for (var i = 0; i < nr; i++)        // nr or items.Length
				{
					textBox_sortedBagView.AppendText(
					$"{i + 1:00} | w/v: {items[i].proportion:00.00} | w: {items[i].weight:00} | v: {items[i].value:00} | inside: {items[i].inside}");
				
					textBox_sortedBagView.AppendText(Environment.NewLine);
				}
			}
		}

		/*private void textBox_numberOfElements_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
			{
				MessageBox.Show("enter only numbers");
			}
		}*/
		private void textBox_numberOfElements_TextChanged(object sender, EventArgs e)
		{

			string input = textBox_numberOfElements.Text;
			if (input != null && input != "")
			{
				elements = int.Parse(input);
				//elements = textBox_numberOfElements.Text;
			}
			if (elements > 100)
			{
				textBox_numberOfElements.BackColor = Color.Red;
			}
			else textBox_numberOfElements.BackColor = Color.Green;
			Globals.elementsG = elements;
		}
		private void textBox_capacity_TextChanged(object sender, EventArgs e)
		{
			string input = textBox_numberOfElements.Text;
			if (input != null && input != "")
			{
				capacity = int.Parse(input);
			}
			if (capacity > 100)
			{
				textBox_capacity.BackColor = Color.Red;
			}
			else textBox_capacity.BackColor = Color.Green;
			Globals.capacityG = capacity;
		}
		private void textBox_seed_TextChanged(object sender, EventArgs e)
		{
			string input = textBox_numberOfElements.Text;
			//var seed = 0;
			if (input != null && input != "")
			{
				seed = int.Parse(input);
			}
			if (seed > 1000)
			{
				textBox_seed.BackColor = Color.Red;
			}
			else textBox_seed.BackColor = Color.Green;
			Globals.seedG = seed;
		}
		public void button1_Click(object sender, EventArgs e)
		{
			var newBag = new Knapsack(Globals.elementsG, Globals.capacityG);
			textBox_results.Clear();
			textBox_sortedBagView.Clear();
			newBag.Generate();
			newBag.Sort();
			newBag.Fit();
			newBag.DisplayResults(textBox_results);
			newBag.DisplayBag(textBox_sortedBagView);
		}
	}
}
