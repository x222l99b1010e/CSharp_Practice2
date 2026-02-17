namespace PracticeInterfaceWinform01
{
	partial class Form2
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
			btnOpenForm3 = new Button();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// btnOpenForm3
			// 
			btnOpenForm3.Location = new Point(12, 84);
			btnOpenForm3.Name = "btnOpenForm3";
			btnOpenForm3.Size = new Size(139, 29);
			btnOpenForm3.TabIndex = 2;
			btnOpenForm3.Text = "Open Form3";
			btnOpenForm3.UseVisualStyleBackColor = true;
			btnOpenForm3.Click += btnOpenForm3_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(178, 27);
			textBox1.TabIndex = 3;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(296, 137);
			Controls.Add(textBox1);
			Controls.Add(btnOpenForm3);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOpenForm3;
		private TextBox textBox1;
	}
}