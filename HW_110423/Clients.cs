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
	public partial class Clients : Form
	{
		public Clients()
		{
			InitializeComponent();
			this.Text = "Gas Oil";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		public void Add(string price)
		{
			listBox1.Items.Add("Пользователь №" + listBox1.Items.Count.ToString() + ": " + price + " грн.");
		}
	}
}
