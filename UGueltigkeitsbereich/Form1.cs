using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGueltigkeitsbereich
{
	public partial class Form1 : Form
	{
		private double x = 0.0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnAnzeigen1_Click(object sender, EventArgs e)
		{
			var y = 0.0;
			const double Pi = 3.14;

			x += 0.1; // x = x + 0.1;
			y += 0.1;

			lblAnzeige.Text =
				"x: " + x + "\n"
				+ "y: " + y;
		}

		private void btnAnzeigen2_Click(object sender, EventArgs e)
		{
			var z = 0.0;
			x += 0.1;
			z += 0.1;

			lblAnzeige.Text =
				"x: " + x + "\n"
				+ "z: " + z;
		}
	}
}
