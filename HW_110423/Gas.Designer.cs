namespace HW_110423
{
	partial class Gas
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
			if (disposing && (components != null)) {
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
			this.GasOil = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.GasOilPrice = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rSum = new System.Windows.Forms.RadioButton();
			this.rCount = new System.Windows.Forms.RadioButton();
			this.tSum = new System.Windows.Forms.TextBox();
			this.tCount = new System.Windows.Forms.TextBox();
			this.tGasOilPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GasOil
			// 
			this.GasOil.Items.AddRange(new object[] {
            "А92",
            "А95"});
			this.GasOil.Location = new System.Drawing.Point(138, 9);
			this.GasOil.Name = "GasOil";
			this.GasOil.Size = new System.Drawing.Size(121, 24);
			this.GasOil.TabIndex = 17;
			this.GasOil.SelectedIndexChanged += new System.EventHandler(this.GasOil_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.GasOilPrice);
			this.groupBox2.Location = new System.Drawing.Point(15, 170);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(259, 89);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "До оплати";
			// 
			// GasOilPrice
			// 
			this.GasOilPrice.AutoSize = true;
			this.GasOilPrice.Location = new System.Drawing.Point(104, 55);
			this.GasOilPrice.Name = "GasOilPrice";
			this.GasOilPrice.Size = new System.Drawing.Size(0, 16);
			this.GasOilPrice.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rSum);
			this.groupBox1.Controls.Add(this.rCount);
			this.groupBox1.Location = new System.Drawing.Point(15, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 89);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// rSum
			// 
			this.rSum.AutoSize = true;
			this.rSum.Location = new System.Drawing.Point(6, 47);
			this.rSum.Name = "rSum";
			this.rSum.Size = new System.Drawing.Size(71, 20);
			this.rSum.TabIndex = 2;
			this.rSum.Text = "Сумма";
			this.rSum.UseVisualStyleBackColor = true;
			// 
			// rCount
			// 
			this.rCount.AutoSize = true;
			this.rCount.Checked = true;
			this.rCount.Location = new System.Drawing.Point(6, 21);
			this.rCount.Name = "rCount";
			this.rCount.Size = new System.Drawing.Size(85, 20);
			this.rCount.TabIndex = 2;
			this.rCount.TabStop = true;
			this.rCount.Text = "Кількість";
			this.rCount.UseVisualStyleBackColor = true;
			this.rCount.CheckedChanged += new System.EventHandler(this.rCount_CheckedChanged);
			// 
			// tSum
			// 
			this.tSum.Location = new System.Drawing.Point(138, 124);
			this.tSum.Name = "tSum";
			this.tSum.ReadOnly = true;
			this.tSum.Size = new System.Drawing.Size(100, 22);
			this.tSum.TabIndex = 14;
			this.tSum.Text = "0";
			this.tSum.TextChanged += new System.EventHandler(this.tSum_TextChanged);
			// 
			// tCount
			// 
			this.tCount.Location = new System.Drawing.Point(138, 96);
			this.tCount.Name = "tCount";
			this.tCount.Size = new System.Drawing.Size(100, 22);
			this.tCount.TabIndex = 15;
			this.tCount.Text = "0";
			this.tCount.TextChanged += new System.EventHandler(this.tCount_TextChanged);
			// 
			// tGasOilPrice
			// 
			this.tGasOilPrice.Location = new System.Drawing.Point(138, 40);
			this.tGasOilPrice.Name = "tGasOilPrice";
			this.tGasOilPrice.ReadOnly = true;
			this.tGasOilPrice.Size = new System.Drawing.Size(100, 22);
			this.tGasOilPrice.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(244, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "л.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(244, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "грг.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(244, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "грг.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Ціна";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Бензин";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 265);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(262, 32);
			this.button1.TabIndex = 18;
			this.button1.Text = "END";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Gas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 309);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.GasOil);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tSum);
			this.Controls.Add(this.tCount);
			this.Controls.Add(this.tGasOilPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Gas";
			this.Text = "Gas";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox GasOil;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label GasOilPrice;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rSum;
		private System.Windows.Forms.RadioButton rCount;
		private System.Windows.Forms.TextBox tSum;
		private System.Windows.Forms.TextBox tCount;
		private System.Windows.Forms.TextBox tGasOilPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}