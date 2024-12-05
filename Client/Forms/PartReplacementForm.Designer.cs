namespace Client.Forms
{
	partial class PartReplacementForm
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
			comboBox1 = new ComboBox();
			dateTimePicker1 = new DateTimePicker();
			label2 = new Label();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(48, 15);
			label1.TabIndex = 0;
			label1.Text = "Деталь:";
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "<Выберите деталь>" });
			comboBox1.Location = new Point(73, 6);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 50);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(182, 23);
			dateTimePicker1.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 32);
			label2.Name = "label2";
			label2.Size = new Size(80, 15);
			label2.TabIndex = 2;
			label2.Text = "Дата замены:";
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
			// PartReplacementForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(212, 133);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(dateTimePicker1);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "PartReplacementForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Добавление замененной детали";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox comboBox1;
		private DateTimePicker dateTimePicker1;
		private Label label2;
		private Button button2;
		private Button button1;
	}
}