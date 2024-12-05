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
			makeTextBoxLabel = new Label();
			modelTextBoxLabel = new Label();
			modelTextBox = new TextBox();
			makeTextBox = new TextBox();
			yearTextBoxLabel = new Label();
			yearTextBox = new TextBox();
			addButton = new Button();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// makeTextBoxLabel
			// 
			makeTextBoxLabel.AutoSize = true;
			makeTextBoxLabel.Location = new Point(12, 15);
			makeTextBoxLabel.Name = "makeTextBoxLabel";
			makeTextBoxLabel.Size = new Size(46, 15);
			makeTextBoxLabel.TabIndex = 0;
			makeTextBoxLabel.Text = "Марка:";
			// 
			// modelTextBoxLabel
			// 
			modelTextBoxLabel.AutoSize = true;
			modelTextBoxLabel.Location = new Point(12, 44);
			modelTextBoxLabel.Name = "modelTextBoxLabel";
			modelTextBoxLabel.Size = new Size(53, 15);
			modelTextBoxLabel.TabIndex = 2;
			modelTextBoxLabel.Text = "Модель:";
			// 
			// modelTextBox
			// 
			modelTextBox.Location = new Point(96, 41);
			modelTextBox.Name = "modelTextBox";
			modelTextBox.Size = new Size(100, 23);
			modelTextBox.TabIndex = 3;
			// 
			// makeTextBox
			// 
			makeTextBox.Location = new Point(96, 12);
			makeTextBox.Name = "makeTextBox";
			makeTextBox.Size = new Size(100, 23);
			makeTextBox.TabIndex = 1;
			// 
			// yearTextBoxLabel
			// 
			yearTextBoxLabel.AutoSize = true;
			yearTextBoxLabel.Location = new Point(12, 73);
			yearTextBoxLabel.Name = "yearTextBoxLabel";
			yearTextBoxLabel.Size = new Size(78, 15);
			yearTextBoxLabel.TabIndex = 4;
			yearTextBoxLabel.Text = "Год выпуска:";
			// 
			// yearTextBox
			// 
			yearTextBox.Location = new Point(96, 70);
			yearTextBox.Name = "yearTextBox";
			yearTextBox.Size = new Size(100, 23);
			yearTextBox.TabIndex = 5;
			// 
			// addButton
			// 
			addButton.Location = new Point(22, 99);
			addButton.Name = "addButton";
			addButton.Size = new Size(75, 23);
			addButton.TabIndex = 6;
			addButton.Text = "Добавить";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(111, 99);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(75, 23);
			cancelButton.TabIndex = 7;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// CarForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(212, 133);
			Controls.Add(cancelButton);
			Controls.Add(addButton);
			Controls.Add(yearTextBox);
			Controls.Add(yearTextBoxLabel);
			Controls.Add(modelTextBox);
			Controls.Add(modelTextBoxLabel);
			Controls.Add(makeTextBox);
			Controls.Add(makeTextBoxLabel);
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

		private Label makeTextBoxLabel;
		private Label modelTextBoxLabel;
		private TextBox modelTextBox;
		private TextBox makeTextBox;
		private Label yearTextBoxLabel;
		private TextBox yearTextBox;
		private Button addButton;
		private Button cancelButton;
	}
}