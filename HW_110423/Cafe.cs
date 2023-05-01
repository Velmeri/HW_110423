using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_110423
{
	public partial class Cafe : Form
	{
		public double Sum;

		public Cafe()
		{
			InitializeComponent();
			CafePrice.Text = "";
			this.Text = "GasOil";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void Cafe_Count_Changed(object sender, EventArgs e)
		{
			double hotDogCount, hotDogPrice, hamburgerCount, hamburgerPrice, frenchFryCount, frenchFryPrice, colaCount, colaPrice;
			if (double.TryParse(tHotDogCount.Text, out hotDogCount) && double.TryParse(tHotDogPrice.Text, out hotDogPrice)
				&& double.TryParse(tHamburgerCount.Text, out hamburgerCount) && double.TryParse(tHamburgerPrice.Text, out hamburgerPrice)
				&& double.TryParse(tFrenchFryCount.Text, out frenchFryCount) && double.TryParse(tFrachFryPrice.Text, out frenchFryPrice)
				&& double.TryParse(tColaCount.Text, out colaCount) && double.TryParse(tColaPrice.Text, out colaPrice)) {
				double sum = 0;
				sum += hotDogCount * hotDogPrice;
				sum += hamburgerCount * hamburgerPrice;
				sum += frenchFryCount * frenchFryPrice;
				sum += colaCount * colaPrice;
				CafePrice.Text = sum.ToString() + " грн.";
			} else {
				CafePrice.Text = "ERROR";
			}
		}

		private void checkHotDog_CheckedChanged(object sender, EventArgs e)
		{
			if (checkHotDog.Checked) tHotDogCount.ReadOnly = false;
			else {
				tHotDogCount.ReadOnly = true;
				tHotDogCount.Text = "0";
			}
		}

		private void checkHamburger_CheckedChanged(object sender, EventArgs e)
		{
			if (checkHamburger.Checked) tHamburgerCount.ReadOnly = false;
			else {
				tHamburgerCount.ReadOnly = true;
				tHamburgerCount.Text = "0";
			}
		}

		private void checkFrenchFry_CheckedChanged(object sender, EventArgs e)
		{
			if (checkFrenchFry.Checked) tFrenchFryCount.ReadOnly = false;
			else {
				tFrenchFryCount.ReadOnly = true;
				tFrenchFryCount.Text = "0";
			}
		}

		private void checkCola_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCola.Checked) tColaCount.ReadOnly = false;
			else {
				tColaCount.ReadOnly = true;
				tColaCount.Text = "0";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] str = CafePrice.Text.Split(' ');
			if (double.TryParse(str[0], out Sum)) this.Close();
			else MessageBox.Show("INVALID VALUE ENTERED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
