using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_110423
{
	public partial class MainMenu : Form
	{
		Gas gas = new Gas();
		Cafe cafe = new Cafe();
		Clients clients = new Clients();

		public MainMenu()
		{
			InitializeComponent();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			gas.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string Sum = (gas.Sum + cafe.Sum).ToString();
			MessageBox.Show("Результат: " + Sum + " грн.");
			clients.Add(Sum);
			gas = new Gas();
			cafe = new Cafe();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cafe.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			clients.ShowDialog();
		}
	}
}
