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
			carListBox = new ListBox();
			partReplacementListBox = new ListBox();
			addCarButton = new Button();
			deleteCarButton = new Button();
			addPartButton = new Button();
			deletePartButton = new Button();
			carListBoxLabel = new Label();
			autoGroupBox = new GroupBox();
			deletePartReplacementButton = new Button();
			addPartReplacementButton = new Button();
			partReplacementListBoxLabel = new Label();
			partGroupBox = new GroupBox();
			partListBox = new ListBox();
			partListBoxLabel = new Label();
			autoGroupBox.SuspendLayout();
			partGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// carListBox
			// 
			carListBox.FormattingEnabled = true;
			carListBox.ItemHeight = 15;
			carListBox.Location = new Point(6, 37);
			carListBox.Name = "carListBox";
			carListBox.Size = new Size(250, 424);
			carListBox.TabIndex = 3;
			carListBox.SelectedIndexChanged += carListBox_SelectedIndexChanged;
			carListBox.DoubleClick += carListBox_DoubleClick;
			// 
			// partReplacementListBox
			// 
			partReplacementListBox.FormattingEnabled = true;
			partReplacementListBox.ItemHeight = 15;
			partReplacementListBox.Location = new Point(262, 37);
			partReplacementListBox.Name = "partReplacementListBox";
			partReplacementListBox.Size = new Size(250, 424);
			partReplacementListBox.TabIndex = 4;
			partReplacementListBox.SelectedIndexChanged += partReplacementListBox_SelectedIndexChanged;
			partReplacementListBox.DoubleClick += partReplacementListBox_DoubleClick;
			// 
			// addCarButton
			// 
			addCarButton.Location = new Point(16, 468);
			addCarButton.Name = "addCarButton";
			addCarButton.Size = new Size(75, 23);
			addCarButton.TabIndex = 5;
			addCarButton.Text = "Добавить";
			addCarButton.UseVisualStyleBackColor = true;
			addCarButton.Click += addCarButton_Click;
			// 
			// deleteCarButton
			// 
			deleteCarButton.Enabled = false;
			deleteCarButton.Location = new Point(171, 468);
			deleteCarButton.Name = "deleteCarButton";
			deleteCarButton.Size = new Size(75, 23);
			deleteCarButton.TabIndex = 6;
			deleteCarButton.Text = "Удалить";
			deleteCarButton.UseVisualStyleBackColor = true;
			deleteCarButton.Click += deleteCarButton_Click;
			// 
			// addPartButton
			// 
			addPartButton.Location = new Point(16, 468);
			addPartButton.Name = "addPartButton";
			addPartButton.Size = new Size(75, 23);
			addPartButton.TabIndex = 12;
			addPartButton.Text = "Добавить";
			addPartButton.UseVisualStyleBackColor = true;
			addPartButton.Click += addPartButton_Click;
			// 
			// deletePartButton
			// 
			deletePartButton.Enabled = false;
			deletePartButton.Location = new Point(171, 468);
			deletePartButton.Name = "deletePartButton";
			deletePartButton.Size = new Size(75, 23);
			deletePartButton.TabIndex = 13;
			deletePartButton.Text = "Удалить";
			deletePartButton.UseVisualStyleBackColor = true;
			deletePartButton.Click += deletePartButton_Click;
			// 
			// carListBoxLabel
			// 
			carListBoxLabel.AutoSize = true;
			carListBoxLabel.Location = new Point(6, 19);
			carListBoxLabel.Name = "carListBoxLabel";
			carListBoxLabel.Size = new Size(125, 15);
			carListBoxLabel.TabIndex = 1;
			carListBoxLabel.Text = "Список автомобилей";
			// 
			// autoGroupBox
			// 
			autoGroupBox.Controls.Add(deletePartReplacementButton);
			autoGroupBox.Controls.Add(addPartReplacementButton);
			autoGroupBox.Controls.Add(partReplacementListBoxLabel);
			autoGroupBox.Controls.Add(carListBox);
			autoGroupBox.Controls.Add(partReplacementListBox);
			autoGroupBox.Controls.Add(carListBoxLabel);
			autoGroupBox.Controls.Add(addCarButton);
			autoGroupBox.Controls.Add(deleteCarButton);
			autoGroupBox.Location = new Point(12, 12);
			autoGroupBox.Name = "autoGroupBox";
			autoGroupBox.Size = new Size(518, 497);
			autoGroupBox.TabIndex = 0;
			autoGroupBox.TabStop = false;
			autoGroupBox.Text = "Панель автомобилей";
			// 
			// deletePartReplacementButton
			// 
			deletePartReplacementButton.Enabled = false;
			deletePartReplacementButton.Location = new Point(427, 468);
			deletePartReplacementButton.Name = "deletePartReplacementButton";
			deletePartReplacementButton.Size = new Size(75, 23);
			deletePartReplacementButton.TabIndex = 8;
			deletePartReplacementButton.Text = "Удалить";
			deletePartReplacementButton.UseVisualStyleBackColor = true;
			deletePartReplacementButton.Click += deletePartReplacementButton_Click;
			// 
			// addPartReplacementButton
			// 
			addPartReplacementButton.Enabled = false;
			addPartReplacementButton.Location = new Point(272, 468);
			addPartReplacementButton.Name = "addPartReplacementButton";
			addPartReplacementButton.Size = new Size(75, 23);
			addPartReplacementButton.TabIndex = 7;
			addPartReplacementButton.Text = "Добавить";
			addPartReplacementButton.UseVisualStyleBackColor = true;
			addPartReplacementButton.Click += addPartReplacementButton_Click;
			// 
			// partReplacementListBoxLabel
			// 
			partReplacementListBoxLabel.AutoSize = true;
			partReplacementListBoxLabel.Location = new Point(262, 19);
			partReplacementListBoxLabel.Name = "partReplacementListBoxLabel";
			partReplacementListBoxLabel.Size = new Size(165, 15);
			partReplacementListBoxLabel.TabIndex = 2;
			partReplacementListBoxLabel.Text = "Список замененных деталей";
			// 
			// partGroupBox
			// 
			partGroupBox.Controls.Add(partListBox);
			partGroupBox.Controls.Add(partListBoxLabel);
			partGroupBox.Controls.Add(addPartButton);
			partGroupBox.Controls.Add(deletePartButton);
			partGroupBox.Location = new Point(536, 12);
			partGroupBox.Name = "partGroupBox";
			partGroupBox.Size = new Size(262, 497);
			partGroupBox.TabIndex = 9;
			partGroupBox.TabStop = false;
			partGroupBox.Text = "Панель деталей";
			// 
			// partListBox
			// 
			partListBox.FormattingEnabled = true;
			partListBox.ItemHeight = 15;
			partListBox.Location = new Point(6, 37);
			partListBox.Name = "partListBox";
			partListBox.Size = new Size(250, 424);
			partListBox.TabIndex = 11;
			partListBox.SelectedIndexChanged += PartListBox_SelectedIndexChanged;
			partListBox.DoubleClick += PartListBox_DoubleClick;
			// 
			// partListBoxLabel
			// 
			partListBoxLabel.AutoSize = true;
			partListBoxLabel.Location = new Point(6, 19);
			partListBoxLabel.Name = "partListBoxLabel";
			partListBoxLabel.Size = new Size(94, 15);
			partListBoxLabel.TabIndex = 10;
			partListBoxLabel.Text = "Список деталей";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(810, 521);
			Controls.Add(partGroupBox);
			Controls.Add(autoGroupBox);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Система учета замененных запчастей в автомобиле";
			Load += Form1_Load;
			autoGroupBox.ResumeLayout(false);
			autoGroupBox.PerformLayout();
			partGroupBox.ResumeLayout(false);
			partGroupBox.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ListBox carListBox;
		private ListBox partReplacementListBox;
		private Button addCarButton;
		private Button deleteCarButton;
		private Button addPartButton;
		private Button deletePartButton;
		private Label carListBoxLabel;
		private GroupBox autoGroupBox;
		private Label partReplacementListBoxLabel;
		private GroupBox partGroupBox;
		private ListBox partListBox;
		private Label partListBoxLabel;
		private Button deletePartReplacementButton;
		private Button addPartReplacementButton;
	}
}
