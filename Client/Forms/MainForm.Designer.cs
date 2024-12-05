namespace Client.Forms
{
	partial class MainForm
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
			listBox1 = new ListBox();
			listBox2 = new ListBox();
			button1 = new Button();
			button2 = new Button();
			button5 = new Button();
			button6 = new Button();
			label1 = new Label();
			groupBox1 = new GroupBox();
			button4 = new Button();
			button3 = new Button();
			label2 = new Label();
			groupBox2 = new GroupBox();
			listBox3 = new ListBox();
			label3 = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(6, 37);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(250, 424);
			listBox1.TabIndex = 3;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			listBox1.DoubleClick += listBox1_DoubleClick;
			// 
			// listBox2
			// 
			listBox2.FormattingEnabled = true;
			listBox2.ItemHeight = 15;
			listBox2.Location = new Point(262, 37);
			listBox2.Name = "listBox2";
			listBox2.Size = new Size(250, 424);
			listBox2.TabIndex = 4;
			listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
			listBox2.DoubleClick += listBox2_DoubleClick;
			// 
			// button1
			// 
			button1.Location = new Point(16, 468);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 5;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Enabled = false;
			button2.Location = new Point(171, 468);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 6;
			button2.Text = "Удалить";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button5
			// 
			button5.Location = new Point(16, 468);
			button5.Name = "button5";
			button5.Size = new Size(75, 23);
			button5.TabIndex = 12;
			button5.Text = "Добавить";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Enabled = false;
			button6.Location = new Point(171, 468);
			button6.Name = "button6";
			button6.Size = new Size(75, 23);
			button6.TabIndex = 13;
			button6.Text = "Удалить";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(125, 15);
			label1.TabIndex = 1;
			label1.Text = "Список автомобилей";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button4);
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(listBox1);
			groupBox1.Controls.Add(listBox2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(button2);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(518, 497);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Панель автомобилей";
			// 
			// button4
			// 
			button4.Enabled = false;
			button4.Location = new Point(427, 468);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 8;
			button4.Text = "Удалить";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Enabled = false;
			button3.Location = new Point(272, 468);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 7;
			button3.Text = "Добавить";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(262, 19);
			label2.Name = "label2";
			label2.Size = new Size(165, 15);
			label2.TabIndex = 2;
			label2.Text = "Список замененных деталей";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(listBox3);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(button5);
			groupBox2.Controls.Add(button6);
			groupBox2.Location = new Point(536, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(262, 497);
			groupBox2.TabIndex = 9;
			groupBox2.TabStop = false;
			groupBox2.Text = "Панель деталей";
			// 
			// listBox3
			// 
			listBox3.FormattingEnabled = true;
			listBox3.ItemHeight = 15;
			listBox3.Location = new Point(6, 37);
			listBox3.Name = "listBox3";
			listBox3.Size = new Size(250, 424);
			listBox3.TabIndex = 11;
			listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
			listBox3.DoubleClick += listBox3_DoubleClick;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 19);
			label3.Name = "label3";
			label3.Size = new Size(94, 15);
			label3.TabIndex = 10;
			label3.Text = "Список деталей";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(810, 521);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Система учета замененных запчастей в автомобиле";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ListBox listBox1;
		private ListBox listBox2;
		private Button button1;
		private Button button2;
		private Button button5;
		private Button button6;
		private Label label1;
		private GroupBox groupBox1;
		private Label label2;
		private GroupBox groupBox2;
		private ListBox listBox3;
		private Label label3;
		private Button button4;
		private Button button3;
	}
}
