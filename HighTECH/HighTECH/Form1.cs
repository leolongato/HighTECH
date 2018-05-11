using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighTECH
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}
		private bool mouseDown;
		private Point lastLocation;

		private void pnBarra_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void pnBarra_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
				Update();
			}
		}

		private void pnBarra_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			pnIndicador.Location = btnHome.Location;
			pnIndicador.BringToFront();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			pnIndicador.Location = btnMenu.Location;
			pnIndicador.BringToFront();
		}

		private void btnHome_MouseEnter(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.Gray;
		}

		private void btnHome_MouseLeave(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.Transparent;
		}

		private void btnMenu_MouseEnter(object sender, EventArgs e)
		{
			btnMenu.BackColor = Color.Gray;
		}

		private void btnMenu_MouseLeave(object sender, EventArgs e)
		{
			btnMenu.BackColor = Color.Transparent;
		}

		private void picBoxFechar_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			ActiveForm.WindowState = FormWindowState.Minimized;
		}
	}
}
