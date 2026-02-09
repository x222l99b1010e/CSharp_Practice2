using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1A2B
{
	public partial class Form1 : Form
	{
		NumberGuessingGame _game;
		public Form1()
		{
			InitializeComponent();
			_game = new NumberGuessingGame();
			_game.NewGame();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
			var guessValue = txtGuess.Text;
			var validationResult = _game.ValidateGuess(guessValue);
			if (validationResult.IsSuccess == false)
			{
				MessageBox.Show("輸入結果失敗，錯誤原因：" + validationResult.ErrorMessage);
				return;
			}

			GameResult gameResult = _game.CompareGuessValue(guessValue);
			if (gameResult.CountA == 4)
			{
				MessageBox.Show("恭喜你猜對了！");
				txtGuess.Text = "";//清空
				txtHistory.Text = "";//清空
				_game.NewGame();
				return;
			}
			string messages = $"{guessValue} {gameResult.CountA}A{gameResult.CountB}B\r\n";
			txtHistory.Text += messages;
			txtGuess.Text = "";
			txtGuess.Focus();
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
			_game.NewGame();
			txtGuess.Text = txtHistory.Text = "";
			txtGuess.Focus();
		}

		private void btnGetAnswer_Click(object sender, EventArgs e)
		{
			string answer = _game.GetAnswer();
			MessageBox.Show(answer);
		}

		private void txtHistory_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
