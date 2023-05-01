using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_110423
{
	public partial class Gas : Form
	{
		public double Sum;

		public Gas()
		{
			InitializeComponent();
			GasOil.DropDownStyle = ComboBoxStyle.DropDownList;
			GasOil.SelectedIndex = 0;
			tCount.Text = "0";
			GasOilPrice.Text = "";
			this.Text = "GasOil";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void GasOil_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (GasOil.SelectedIndex) {
				case 0: {
						tGasOilPrice.Text = "44.79";
						break;
					}
				case 1: {
						tGasOilPrice.Text = "46.55";
						break;
					}
			}
			if (Regex.IsMatch(tCount.Text, @"^(\d+(\.\d+)?|\.\d+|\s*)$")) {
				double count, gasOilPrice, sum;
				if (double.TryParse(tCount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out count)
					&& double.TryParse(tGasOilPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out gasOilPrice)) {
					sum = count * gasOilPrice;
					tSum.Text = sum.ToString();
				} else {
					tSum.Text = "ERROR";
				}
			}
		}

		private void rCount_CheckedChanged(object sender, EventArgs e)
		{
			if (rCount.Checked) {
				tCount.ReadOnly = false;
				tSum.ReadOnly = true;
			} else if (rSum.Checked) {
				tSum.ReadOnly = false;
				tCount.ReadOnly = true;
			}
		}

		private void tCount_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(tCount.Text, @"^(\d+(\.\d+)?|\.\d+|\s*)$")) {
				if (rCount.Checked) {
					double count, gasOilPrice, sum;
					if (double.TryParse(tCount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out count)
						&& double.TryParse(tGasOilPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out gasOilPrice)) {
						sum = count * gasOilPrice;
						tSum.Text = sum.ToString();
					} else {
						tSum.Text = "ERROR";
					}
				}
			}
		}

		private void tSum_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(tSum.Text, @"^(\d+(\.\d+)?|\.\d+|\s*)$")) {
				if (rSum.Checked) {
					double sum, gasOilPrice, count;
					if (double.TryParse(tSum.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out sum)
						&& double.TryParse(tGasOilPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out gasOilPrice)) {
						count = sum / gasOilPrice;
						tCount.Text = count.ToString();
					} else {
						tSum.Text = "ERROR";
					}
				}
			}

			GasOilPrice.Text = tSum.Text + " грн.";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (double.TryParse(tSum.Text, out Sum)) this.Close();
			else MessageBox.Show("INVALID VALUE ENTERED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
