namespace HW_110423
{
	partial class Cafe
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CafePrice = new System.Windows.Forms.Label();
			this.tColaCount = new System.Windows.Forms.TextBox();
			this.tColaPrice = new System.Windows.Forms.TextBox();
			this.tFrenchFryCount = new System.Windows.Forms.TextBox();
			this.tFrachFryPrice = new System.Windows.Forms.TextBox();
			this.tHamburgerCount = new System.Windows.Forms.TextBox();
			this.checkCola = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tHamburgerPrice = new System.Windows.Forms.TextBox();
			this.checkFrenchFry = new System.Windows.Forms.CheckBox();
			this.tHotDogCount = new System.Windows.Forms.TextBox();
			this.checkHamburger = new System.Windows.Forms.CheckBox();
			this.tHotDogPrice = new System.Windows.Forms.TextBox();
			this.checkHotDog = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.CafePrice);
			this.groupBox3.Location = new System.Drawing.Point(12, 147);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(339, 89);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "До оплати";
			// 
			// CafePrice
			// 
			this.CafePrice.AutoSize = true;
			this.CafePrice.Location = new System.Drawing.Point(93, 55);
			this.CafePrice.Name = "CafePrice";
			this.CafePrice.Size = new System.Drawing.Size(0, 16);
			this.CafePrice.TabIndex = 3;
			// 
			// tColaCount
			// 
			this.tColaCount.Location = new System.Drawing.Point(251, 119);
			this.tColaCount.Name = "tColaCount";
			this.tColaCount.ReadOnly = true;
			this.tColaCount.Size = new System.Drawing.Size(100, 22);
			this.tColaCount.TabIndex = 13;
			this.tColaCount.Text = "0";
			this.tColaCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// tColaPrice
			// 
			this.tColaPrice.Location = new System.Drawing.Point(129, 117);
			this.tColaPrice.Name = "tColaPrice";
			this.tColaPrice.ReadOnly = true;
			this.tColaPrice.Size = new System.Drawing.Size(100, 22);
			this.tColaPrice.TabIndex = 14;
			this.tColaPrice.Text = "4,40";
			// 
			// tFrenchFryCount
			// 
			this.tFrenchFryCount.Location = new System.Drawing.Point(251, 91);
			this.tFrenchFryCount.Name = "tFrenchFryCount";
			this.tFrenchFryCount.ReadOnly = true;
			this.tFrenchFryCount.Size = new System.Drawing.Size(100, 22);
			this.tFrenchFryCount.TabIndex = 15;
			this.tFrenchFryCount.Text = "0";
			this.tFrenchFryCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// tFrachFryPrice
			// 
			this.tFrachFryPrice.Location = new System.Drawing.Point(129, 89);
			this.tFrachFryPrice.Name = "tFrachFryPrice";
			this.tFrachFryPrice.ReadOnly = true;
			this.tFrachFryPrice.Size = new System.Drawing.Size(100, 22);
			this.tFrachFryPrice.TabIndex = 16;
			this.tFrachFryPrice.Text = "7,20";
			// 
			// tHamburgerCount
			// 
			this.tHamburgerCount.Location = new System.Drawing.Point(251, 63);
			this.tHamburgerCount.Name = "tHamburgerCount";
			this.tHamburgerCount.ReadOnly = true;
			this.tHamburgerCount.Size = new System.Drawing.Size(100, 22);
			this.tHamburgerCount.TabIndex = 17;
			this.tHamburgerCount.Text = "0";
			this.tHamburgerCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// checkCola
			// 
			this.checkCola.AutoSize = true;
			this.checkCola.Location = new System.Drawing.Point(12, 119);
			this.checkCola.Name = "checkCola";
			this.checkCola.Size = new System.Drawing.Size(96, 20);
			this.checkCola.TabIndex = 9;
			this.checkCola.Text = "Кока-Кола";
			this.checkCola.UseVisualStyleBackColor = true;
			this.checkCola.CheckedChanged += new System.EventHandler(this.checkCola_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(269, 14);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 16);
			this.label10.TabIndex = 7;
			this.label10.Text = "Кількість";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(160, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "Ціна";
			// 
			// tHamburgerPrice
			// 
			this.tHamburgerPrice.Location = new System.Drawing.Point(129, 61);
			this.tHamburgerPrice.Name = "tHamburgerPrice";
			this.tHamburgerPrice.ReadOnly = true;
			this.tHamburgerPrice.Size = new System.Drawing.Size(100, 22);
			this.tHamburgerPrice.TabIndex = 18;
			this.tHamburgerPrice.Text = "5,40";
			// 
			// checkFrenchFry
			// 
			this.checkFrenchFry.AutoSize = true;
			this.checkFrenchFry.Location = new System.Drawing.Point(12, 91);
			this.checkFrenchFry.Name = "checkFrenchFry";
			this.checkFrenchFry.Size = new System.Drawing.Size(117, 20);
			this.checkFrenchFry.TabIndex = 10;
			this.checkFrenchFry.Text = "Картопля-Фрі";
			this.checkFrenchFry.UseVisualStyleBackColor = true;
			this.checkFrenchFry.CheckedChanged += new System.EventHandler(this.checkFrenchFry_CheckedChanged);
			// 
			// tHotDogCount
			// 
			this.tHotDogCount.Location = new System.Drawing.Point(251, 33);
			this.tHotDogCount.Name = "tHotDogCount";
			this.tHotDogCount.ReadOnly = true;
			this.tHotDogCount.Size = new System.Drawing.Size(100, 22);
			this.tHotDogCount.TabIndex = 19;
			this.tHotDogCount.Text = "0";
			this.tHotDogCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// checkHamburger
			// 
			this.checkHamburger.AutoSize = true;
			this.checkHamburger.Location = new System.Drawing.Point(12, 63);
			this.checkHamburger.Name = "checkHamburger";
			this.checkHamburger.Size = new System.Drawing.Size(99, 20);
			this.checkHamburger.TabIndex = 11;
			this.checkHamburger.Text = "Гамбургер";
			this.checkHamburger.UseVisualStyleBackColor = true;
			this.checkHamburger.CheckedChanged += new System.EventHandler(this.checkHamburger_CheckedChanged);
			// 
			// tHotDogPrice
			// 
			this.tHotDogPrice.Location = new System.Drawing.Point(129, 33);
			this.tHotDogPrice.Name = "tHotDogPrice";
			this.tHotDogPrice.ReadOnly = true;
			this.tHotDogPrice.Size = new System.Drawing.Size(100, 22);
			this.tHotDogPrice.TabIndex = 20;
			this.tHotDogPrice.Text = "4,00";
			// 
			// checkHotDog
			// 
			this.checkHotDog.AutoSize = true;
			this.checkHotDog.Location = new System.Drawing.Point(12, 33);
			this.checkHotDog.Name = "checkHotDog";
			this.checkHotDog.Size = new System.Drawing.Size(79, 20);
			this.checkHotDog.TabIndex = 12;
			this.checkHotDog.Text = "Хот-Дог";
			this.checkHotDog.UseVisualStyleBackColor = true;
			this.checkHotDog.CheckedChanged += new System.EventHandler(this.checkHotDog_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 243);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(339, 37);
			this.button1.TabIndex = 22;
			this.button1.Text = "END";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Cafe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 293);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.tColaCount);
			this.Controls.Add(this.tColaPrice);
			this.Controls.Add(this.tFrenchFryCount);
			this.Controls.Add(this.tFrachFryPrice);
			this.Controls.Add(this.tHamburgerCount);
			this.Controls.Add(this.checkCola);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tHamburgerPrice);
			this.Controls.Add(this.checkFrenchFry);
			this.Controls.Add(this.tHotDogCount);
			this.Controls.Add(this.checkHamburger);
			this.Controls.Add(this.tHotDogPrice);
			this.Controls.Add(this.checkHotDog);
			this.Name = "Cafe";
			this.Text = "Cafe";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label CafePrice;
		private System.Windows.Forms.TextBox tColaCount;
		private System.Windows.Forms.TextBox tColaPrice;
		private System.Windows.Forms.TextBox tFrenchFryCount;
		private System.Windows.Forms.TextBox tFrachFryPrice;
		private System.Windows.Forms.TextBox tHamburgerCount;
		private System.Windows.Forms.CheckBox checkCola;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tHamburgerPrice;
		private System.Windows.Forms.CheckBox checkFrenchFry;
		private System.Windows.Forms.TextBox tHotDogCount;
		private System.Windows.Forms.CheckBox checkHamburger;
		private System.Windows.Forms.TextBox tHotDogPrice;
		private System.Windows.Forms.CheckBox checkHotDog;
		private System.Windows.Forms.Button button1;
	}
}