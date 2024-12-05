namespace Client.Forms
{
	partial class CarForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			textBox3 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 15);
			label1.Name = "label1";
			label1.Size = new Size(46, 15);
			label1.TabIndex = 0;
			label1.Text = "Марка:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 44);
			label2.Name = "label2";
			label2.Size = new Size(53, 15);
			label2.TabIndex = 2;
			label2.Text = "Модель:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(96, 41);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 3;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(96, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 73);
			label3.Name = "label3";
			label3.Size = new Size(78, 15);
			label3.TabIndex = 4;
			label3.Text = "Год выпуска:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(96, 70);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new Point(22, 99);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 6;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(111, 99);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 7;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// CarForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(212, 133);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CarForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Добавление автомобиля";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label3;
		private TextBox textBox3;
		private Button button1;
		private Button button2;
	}
}