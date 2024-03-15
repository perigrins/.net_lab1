namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox_numberOfElements = new TextBox();
			textBox_capacity = new TextBox();
			textBox_seed = new TextBox();
			textBox_results = new TextBox();
			textBox_sortedBagView = new TextBox();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// textBox_numberOfElements
			// 
			textBox_numberOfElements.Location = new Point(68, 150);
			textBox_numberOfElements.MaxLength = 100;
			textBox_numberOfElements.Name = "textBox_numberOfElements";
			textBox_numberOfElements.Size = new Size(250, 47);
			textBox_numberOfElements.TabIndex = 0;
			textBox_numberOfElements.Tag = "numberofitems";
			textBox_numberOfElements.TextChanged += textBox_numberOfElements_TextChanged;
			// 
			// textBox_capacity
			// 
			textBox_capacity.Location = new Point(68, 285);
			textBox_capacity.MaxLength = 100;
			textBox_capacity.Name = "textBox_capacity";
			textBox_capacity.Size = new Size(250, 47);
			textBox_capacity.TabIndex = 1;
			textBox_capacity.TextChanged += textBox_capacity_TextChanged;
			// 
			// textBox_seed
			// 
			textBox_seed.Location = new Point(68, 425);
			textBox_seed.MaxLength = 100;
			textBox_seed.Name = "textBox_seed";
			textBox_seed.Size = new Size(250, 47);
			textBox_seed.TabIndex = 2;
			textBox_seed.TextChanged += textBox_seed_TextChanged;
			// 
			// textBox_results
			// 
			textBox_results.BackColor = SystemColors.ControlLightLight;
			textBox_results.Location = new Point(68, 650);
			textBox_results.Multiline = true;
			textBox_results.Name = "textBox_results";
			textBox_results.ReadOnly = true;
			textBox_results.Size = new Size(609, 266);
			textBox_results.TabIndex = 3;
			// 
			// textBox_sortedBagView
			// 
			textBox_sortedBagView.BackColor = SystemColors.ControlLightLight;
			textBox_sortedBagView.Location = new Point(722, 194);
			textBox_sortedBagView.Multiline = true;
			textBox_sortedBagView.Name = "textBox_sortedBagView";
			textBox_sortedBagView.ReadOnly = true;
			textBox_sortedBagView.ScrollBars = ScrollBars.Vertical;
			textBox_sortedBagView.Size = new Size(805, 1022);
			textBox_sortedBagView.TabIndex = 4;
			// 
			// button1
			// 
			button1.Location = new Point(445, 539);
			button1.Name = "button1";
			button1.Size = new Size(232, 72);
			button1.TabIndex = 5;
			button1.Text = "run";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(68, 106);
			label1.Name = "label1";
			label1.Size = new Size(237, 41);
			label1.TabIndex = 6;
			label1.Text = "number of items";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(68, 241);
			label2.Name = "label2";
			label2.Size = new Size(126, 41);
			label2.TabIndex = 7;
			label2.Text = "capacity";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(68, 381);
			label3.Name = "label3";
			label3.Size = new Size(81, 41);
			label3.TabIndex = 8;
			label3.Text = "seed";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(722, 150);
			label4.Name = "label4";
			label4.Size = new Size(162, 41);
			label4.TabIndex = 9;
			label4.Text = "sorted bag";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(68, 606);
			label5.Name = "label5";
			label5.Size = new Size(104, 41);
			label5.TabIndex = 10;
			label5.Text = "results";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1570, 1246);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox_sortedBagView);
			Controls.Add(textBox_results);
			Controls.Add(textBox_seed);
			Controls.Add(textBox_capacity);
			Controls.Add(textBox_numberOfElements);
			Name = "Form1";
			Text = "Knapsack";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox_numberOfElements;
		private TextBox textBox_capacity;
		private TextBox textBox_seed;
		private TextBox textBox_results;
		private TextBox textBox_sortedBagView;
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}
