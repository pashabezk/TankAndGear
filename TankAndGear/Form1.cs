namespace TankAndGear
{
	public partial class Form1 : Form
	{
		int target = 5;
		int collected = 0;

		public Form1() {
			InitializeComponent();
			KeyPreview = true;

			startGame();
		}

		private void startGame() {
			tank.Location = new Point(450, 500);
			tank.Image = Properties.Resources.tankUp;
			placeGear();

			setTargetLabel();
			setCollectedLabel();

			setVisibleWinControls(false);
		}

		private void placeGear() {
			Random rand = new Random();
			gear.Top = rand.Next(0, 600);
			gear.Left = rand.Next(0, 900);

			if (tank.Bounds.IntersectsWith(gear.Bounds)) {
				placeGear();
			}
		}

		private void setTargetLabel() {
			targetLabel.Text = "Цель: " + target;
		}

		private void setCollectedLabel() {
			collectedLabel.Text = "Собрано: " + collected;
		}

		private void setVisibleWinControls(bool visible) {
			winLabel.Visible = visible;
			continueBtn.Visible = visible;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			int speed = 10;
			if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && tank.Left > 10) {
				tank.Left -= speed;
				tank.Image = Properties.Resources.tankLeft;
			}
			else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && tank.Right < 980) {
				tank.Left += speed;
				tank.Image = Properties.Resources.tankRight;
			}
			else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && tank.Top > 0) {
				tank.Top -= speed;
				tank.Image = Properties.Resources.tankUp;
			}
			else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && tank.Bottom < 650) {
				tank.Top += speed;
				tank.Image = Properties.Resources.tankDown;
			}

			if (tank.Bounds.IntersectsWith(gear.Bounds)) {
				collected++;
				setCollectedLabel();
				placeGear();
			}

			if (target == collected) {
				setVisibleWinControls(true);
			}
		}

		private void continueBtn_Click(object sender, EventArgs e) {
			target += 5;
			collected = 0;
			startGame();
		}
	}
}