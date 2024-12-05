namespace Client.Forms
{
	partial class PartForm
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
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			textBox2 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(96, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 15);
			label1.Name = "label1";
			label1.Size = new Size(62, 15);
			label1.TabIndex = 0;
			label1.Text = "Название:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 38);
			label2.Name = "label2";
			label2.Size = new Size(65, 15);
			label2.TabIndex = 2;
			label2.Text = "Описание:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(12, 56);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.ScrollBars = ScrollBars.Vertical;
			textBox2.Size = new Size(184, 37);
			textBox2.TabIndex = 3;
			// 
			// button2
			// 
			button2.Location = new Point(111, 99);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 5;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(22, 99);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// PartForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(212, 133);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "PartForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Добавление детали";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private TextBox textBox2;
		private Button button2;
		private Button button1;
	}
}