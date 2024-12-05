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
			partComboBoxLabel = new Label();
			partComboBox = new ComboBox();
			dateDateTimePicker = new DateTimePicker();
			dateDateTimePickerLabel = new Label();
			cancelButton = new Button();
			addButton = new Button();
			SuspendLayout();
			// 
			// partComboBoxLabel
			// 
			partComboBoxLabel.AutoSize = true;
			partComboBoxLabel.Location = new Point(12, 9);
			partComboBoxLabel.Name = "partComboBoxLabel";
			partComboBoxLabel.Size = new Size(48, 15);
			partComboBoxLabel.TabIndex = 0;
			partComboBoxLabel.Text = "Деталь:";
			// 
			// partComboBox
			// 
			partComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			partComboBox.FormattingEnabled = true;
			partComboBox.Items.AddRange(new object[] { "<Выберите деталь>" });
			partComboBox.Location = new Point(73, 6);
			partComboBox.Name = "partComboBox";
			partComboBox.Size = new Size(121, 23);
			partComboBox.TabIndex = 1;
			// 
			// dateDateTimePicker
			// 
			dateDateTimePicker.Location = new Point(12, 50);
			dateDateTimePicker.Name = "dateDateTimePicker";
			dateDateTimePicker.Size = new Size(182, 23);
			dateDateTimePicker.TabIndex = 3;
			// 
			// dateDateTimePickerLabel
			// 
			dateDateTimePickerLabel.AutoSize = true;
			dateDateTimePickerLabel.Location = new Point(12, 32);
			dateDateTimePickerLabel.Name = "dateDateTimePickerLabel";
			dateDateTimePickerLabel.Size = new Size(80, 15);
			dateDateTimePickerLabel.TabIndex = 2;
			dateDateTimePickerLabel.Text = "Дата замены:";
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
			// PartReplacementForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(212, 133);
			Controls.Add(cancelButton);
			Controls.Add(addButton);
			Controls.Add(dateDateTimePickerLabel);
			Controls.Add(dateDateTimePicker);
			Controls.Add(partComboBox);
			Controls.Add(partComboBoxLabel);
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

		private Label partComboBoxLabel;
		private ComboBox partComboBox;
		private DateTimePicker dateDateTimePicker;
		private Label dateDateTimePickerLabel;
		private Button cancelButton;
		private Button addButton;
	}
}