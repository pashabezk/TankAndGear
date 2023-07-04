namespace TankAndGear
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
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			tank = new PictureBox();
			gear = new PictureBox();
			pictureBox1 = new PictureBox();
			targetLabel = new Label();
			collectedLabel = new Label();
			winLabel = new Label();
			continueBtn = new Button();
			((System.ComponentModel.ISupportInitialize)tank).BeginInit();
			((System.ComponentModel.ISupportInitialize)gear).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tank
			// 
			tank.BackColor = Color.SeaGreen;
			tank.Image = Properties.Resources.tankUp;
			tank.Location = new Point(450, 500);
			tank.Name = "tank";
			tank.Size = new Size(100, 100);
			tank.SizeMode = PictureBoxSizeMode.StretchImage;
			tank.TabIndex = 0;
			tank.TabStop = false;
			// 
			// gear
			// 
			gear.BackColor = Color.Green;
			gear.Image = Properties.Resources.gear2;
			gear.Location = new Point(149, 194);
			gear.Name = "gear";
			gear.Size = new Size(40, 40);
			gear.SizeMode = PictureBoxSizeMode.StretchImage;
			gear.TabIndex = 1;
			gear.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.grass;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1000, 800);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// targetLabel
			// 
			targetLabel.AutoSize = true;
			targetLabel.Font = new Font("Goudy Stout", 9F, FontStyle.Bold, GraphicsUnit.Point);
			targetLabel.ForeColor = Color.FromArgb(0, 64, 0);
			targetLabel.Location = new Point(24, 29);
			targetLabel.Name = "targetLabel";
			targetLabel.Padding = new Padding(5);
			targetLabel.Size = new Size(116, 34);
			targetLabel.TabIndex = 3;
			targetLabel.Text = "Цель: 10";
			// 
			// collectedLabel
			// 
			collectedLabel.AutoSize = true;
			collectedLabel.Font = new Font("Goudy Stout", 9F, FontStyle.Bold, GraphicsUnit.Point);
			collectedLabel.ForeColor = Color.FromArgb(0, 64, 0);
			collectedLabel.Location = new Point(24, 81);
			collectedLabel.Name = "collectedLabel";
			collectedLabel.Padding = new Padding(5);
			collectedLabel.Size = new Size(134, 34);
			collectedLabel.TabIndex = 4;
			collectedLabel.Text = "Собрано: 0";
			// 
			// winLabel
			// 
			winLabel.AutoSize = true;
			winLabel.Font = new Font("Goudy Stout", 16F, FontStyle.Bold, GraphicsUnit.Point);
			winLabel.ForeColor = Color.FromArgb(0, 64, 0);
			winLabel.Location = new Point(252, 293);
			winLabel.Name = "winLabel";
			winLabel.Padding = new Padding(5);
			winLabel.Size = new Size(525, 54);
			winLabel.TabIndex = 5;
			winLabel.Text = "МИССИЯ ВЫПОЛНЕНА!!!";
			// 
			// continueBtn
			// 
			continueBtn.Font = new Font("Gadugi", 14F, FontStyle.Bold, GraphicsUnit.Point);
			continueBtn.Location = new Point(402, 378);
			continueBtn.Name = "continueBtn";
			continueBtn.Size = new Size(202, 74);
			continueBtn.TabIndex = 6;
			continueBtn.Text = "Продолжить";
			continueBtn.UseVisualStyleBackColor = true;
			continueBtn.Click += continueBtn_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(978, 644);
			Controls.Add(continueBtn);
			Controls.Add(winLabel);
			Controls.Add(collectedLabel);
			Controls.Add(targetLabel);
			Controls.Add(gear);
			Controls.Add(tank);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(1000, 700);
			MinimumSize = new Size(1000, 700);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tank and gear";
			KeyDown += Form1_KeyDown;
			((System.ComponentModel.ISupportInitialize)tank).EndInit();
			((System.ComponentModel.ISupportInitialize)gear).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox tank;
		private PictureBox gear;
		private PictureBox pictureBox1;
		private Label targetLabel;
		private Label collectedLabel;
		private Label winLabel;
		private Button continueBtn;
	}
}