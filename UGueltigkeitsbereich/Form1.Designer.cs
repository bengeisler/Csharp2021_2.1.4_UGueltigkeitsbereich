
namespace UGueltigkeitsbereich
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAnzeigen2 = new System.Windows.Forms.Button();
			this.btnAnzeigen1 = new System.Windows.Forms.Button();
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAnzeigen2
			// 
			this.btnAnzeigen2.Location = new System.Drawing.Point(362, 63);
			this.btnAnzeigen2.Name = "btnAnzeigen2";
			this.btnAnzeigen2.Size = new System.Drawing.Size(145, 51);
			this.btnAnzeigen2.TabIndex = 0;
			this.btnAnzeigen2.Text = "Anzeigen 2";
			this.btnAnzeigen2.UseVisualStyleBackColor = true;
			this.btnAnzeigen2.Click += new System.EventHandler(this.btnAnzeigen2_Click);
			// 
			// btnAnzeigen1
			// 
			this.btnAnzeigen1.Location = new System.Drawing.Point(362, 12);
			this.btnAnzeigen1.Name = "btnAnzeigen1";
			this.btnAnzeigen1.Size = new System.Drawing.Size(145, 45);
			this.btnAnzeigen1.TabIndex = 1;
			this.btnAnzeigen1.Text = "Anzeigen 1";
			this.btnAnzeigen1.UseVisualStyleBackColor = true;
			this.btnAnzeigen1.Click += new System.EventHandler(this.btnAnzeigen1_Click);
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(12, 9);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(51, 20);
			this.lblAnzeige.TabIndex = 2;
			this.lblAnzeige.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 132);
			this.Controls.Add(this.lblAnzeige);
			this.Controls.Add(this.btnAnzeigen1);
			this.Controls.Add(this.btnAnzeigen2);
			this.Name = "Form1";
			this.Text = "Gültigkeitsbereich";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnzeigen2;
		private System.Windows.Forms.Button btnAnzeigen1;
		private System.Windows.Forms.Label lblAnzeige;
	}
}

