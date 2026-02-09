namespace Game1A2B
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.btnGuess = new System.Windows.Forms.Button();
			this.txtHistory = new System.Windows.Forms.TextBox();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.btnGetAnswer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtGuess
			// 
			this.txtGuess.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtGuess.Location = new System.Drawing.Point(33, 82);
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(100, 25);
			this.txtGuess.TabIndex = 1;
			// 
			// btnGuess
			// 
			this.btnGuess.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnGuess.Location = new System.Drawing.Point(164, 81);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(100, 26);
			this.btnGuess.TabIndex = 2;
			this.btnGuess.Text = "猜數字";
			this.btnGuess.UseVisualStyleBackColor = false;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// txtHistory
			// 
			this.txtHistory.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtHistory.Enabled = false;
			this.txtHistory.Location = new System.Drawing.Point(33, 130);
			this.txtHistory.Multiline = true;
			this.txtHistory.Name = "txtHistory";
			this.txtHistory.Size = new System.Drawing.Size(231, 274);
			this.txtHistory.TabIndex = 3;
			this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
			// 
			// btnNewGame
			// 
			this.btnNewGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnNewGame.Location = new System.Drawing.Point(33, 34);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(100, 23);
			this.btnNewGame.TabIndex = 4;
			this.btnNewGame.Text = "新遊戲";
			this.btnNewGame.UseVisualStyleBackColor = false;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// btnGetAnswer
			// 
			this.btnGetAnswer.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnGetAnswer.Location = new System.Drawing.Point(164, 34);
			this.btnGetAnswer.Name = "btnGetAnswer";
			this.btnGetAnswer.Size = new System.Drawing.Size(100, 23);
			this.btnGetAnswer.TabIndex = 5;
			this.btnGetAnswer.Text = "偷看答案";
			this.btnGetAnswer.UseVisualStyleBackColor = false;
			this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnGuess;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 442);
			this.Controls.Add(this.btnGetAnswer);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.txtHistory);
			this.Controls.Add(this.btnGuess);
			this.Controls.Add(this.txtGuess);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.TextBox txtHistory;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Button btnGetAnswer;
	}
}

