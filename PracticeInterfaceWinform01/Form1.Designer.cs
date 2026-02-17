namespace PracticeInterfaceWinform01
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
			btnOpenForm2 = new Button();
			btnOpenForm3 = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnOpenForm2
			// 
			btnOpenForm2.Location = new Point(12, 108);
			btnOpenForm2.Name = "btnOpenForm2";
			btnOpenForm2.Size = new Size(189, 29);
			btnOpenForm2.TabIndex = 0;
			btnOpenForm2.Text = "Open Form2";
			btnOpenForm2.UseVisualStyleBackColor = true;
			btnOpenForm2.Click += btnOpenForm2_Click;
			// 
			// btnOpenForm3
			// 
			btnOpenForm3.Location = new Point(92, 12);
			btnOpenForm3.Name = "btnOpenForm3";
			btnOpenForm3.Size = new Size(189, 29);
			btnOpenForm3.TabIndex = 1;
			btnOpenForm3.Text = "Open Form3";
			btnOpenForm3.UseVisualStyleBackColor = true;
			btnOpenForm3.Click += btnOpenForm3_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(51, 19);
			label1.TabIndex = 2;
			label1.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(291, 175);
			Controls.Add(label1);
			Controls.Add(btnOpenForm3);
			Controls.Add(btnOpenForm2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOpenForm2;
		private Button btnOpenForm3;
		private Label label1;
	}
}
