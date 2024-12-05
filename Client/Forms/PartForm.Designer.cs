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
			nameTextBox = new TextBox();
			nameTextBoxLabel = new Label();
			descriptionTextBoxLabel = new Label();
			descriptionTextBox = new TextBox();
			cancelButton = new Button();
			addButton = new Button();
			SuspendLayout();
			// 
			// nameTextBox
			// 
			nameTextBox.Location = new Point(96, 12);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(100, 23);
			nameTextBox.TabIndex = 1;
			// 
			// nameTextBoxLabel
			// 
			nameTextBoxLabel.AutoSize = true;
			nameTextBoxLabel.Location = new Point(12, 15);
			nameTextBoxLabel.Name = "nameTextBoxLabel";
			nameTextBoxLabel.Size = new Size(62, 15);
			nameTextBoxLabel.TabIndex = 0;
			nameTextBoxLabel.Text = "Название:";
			// 
			// descriptionTextBoxLabel
			// 
			descriptionTextBoxLabel.AutoSize = true;
			descriptionTextBoxLabel.Location = new Point(12, 38);
			descriptionTextBoxLabel.Name = "descriptionTextBoxLabel";
			descriptionTextBoxLabel.Size = new Size(65, 15);
			descriptionTextBoxLabel.TabIndex = 2;
			descriptionTextBoxLabel.Text = "Описание:";
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Location = new Point(12, 56);
			descriptionTextBox.Multiline = true;
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.ScrollBars = ScrollBars.Vertical;
			descriptionTextBox.Size = new Size(184, 37);
			descriptionTextBox.TabIndex = 3;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(111, 99);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(75, 23);
			cancelButton.TabIndex = 5;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// addButton
			// 
			addButton.Location = new Point(22, 99);
			addButton.Name = "addButton";
			addButton.Size = new Size(75, 23);
			addButton.TabIndex = 4;
			addButton.Text = "Добавить";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// PartForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(212, 133);
			Controls.Add(cancelButton);
			Controls.Add(addButton);
			Controls.Add(descriptionTextBox);
			Controls.Add(descriptionTextBoxLabel);
			Controls.Add(nameTextBox);
			Controls.Add(nameTextBoxLabel);
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

		private TextBox nameTextBox;
		private Label nameTextBoxLabel;
		private Label descriptionTextBoxLabel;
		private TextBox descriptionTextBox;
		private Button cancelButton;
		private Button addButton;
	}
}