namespace HighTECH
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.pnMenu = new System.Windows.Forms.Panel();
			this.pnConteudo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.pnBarra = new System.Windows.Forms.Panel();
			this.pnIndicador = new System.Windows.Forms.Panel();
			this.picBoxIcone = new System.Windows.Forms.PictureBox();
			this.picBoxFechar = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnMenu.SuspendLayout();
			this.pnConteudo.SuspendLayout();
			this.pnBarra.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFechar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.Color.Black;
			this.pnMenu.Controls.Add(this.picBoxIcone);
			this.pnMenu.Controls.Add(this.pnIndicador);
			this.pnMenu.Controls.Add(this.btnMenu);
			this.pnMenu.Controls.Add(this.btnHome);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnMenu.Location = new System.Drawing.Point(0, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(192, 450);
			this.pnMenu.TabIndex = 0;
			// 
			// pnConteudo
			// 
			this.pnConteudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnConteudo.Controls.Add(this.pnBarra);
			this.pnConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnConteudo.Location = new System.Drawing.Point(0, 0);
			this.pnConteudo.Name = "pnConteudo";
			this.pnConteudo.Size = new System.Drawing.Size(800, 450);
			this.pnConteudo.TabIndex = 1;
			// 
			// btnHome
			// 
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Location = new System.Drawing.Point(0, 127);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(192, 50);
			this.btnHome.TabIndex = 0;
			this.btnHome.Text = "    Home";
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
			this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
			// 
			// btnMenu
			// 
			this.btnMenu.FlatAppearance.BorderSize = 0;
			this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenu.ForeColor = System.Drawing.Color.White;
			this.btnMenu.Location = new System.Drawing.Point(0, 183);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(192, 50);
			this.btnMenu.TabIndex = 1;
			this.btnMenu.Text = "    Menu";
			this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
			this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
			// 
			// pnBarra
			// 
			this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pnBarra.Controls.Add(this.pictureBox1);
			this.pnBarra.Controls.Add(this.picBoxFechar);
			this.pnBarra.Location = new System.Drawing.Point(191, 0);
			this.pnBarra.Name = "pnBarra";
			this.pnBarra.Size = new System.Drawing.Size(609, 23);
			this.pnBarra.TabIndex = 0;
			this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
			this.pnBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseMove);
			this.pnBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseUp);
			// 
			// pnIndicador
			// 
			this.pnIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.pnIndicador.Location = new System.Drawing.Point(0, 127);
			this.pnIndicador.Name = "pnIndicador";
			this.pnIndicador.Size = new System.Drawing.Size(10, 50);
			this.pnIndicador.TabIndex = 2;
			// 
			// picBoxIcone
			// 
			this.picBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIcone.Image")));
			this.picBoxIcone.InitialImage = null;
			this.picBoxIcone.Location = new System.Drawing.Point(25, 0);
			this.picBoxIcone.Name = "picBoxIcone";
			this.picBoxIcone.Size = new System.Drawing.Size(136, 121);
			this.picBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxIcone.TabIndex = 3;
			this.picBoxIcone.TabStop = false;
			// 
			// picBoxFechar
			// 
			this.picBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFechar.Image")));
			this.picBoxFechar.Location = new System.Drawing.Point(588, 4);
			this.picBoxFechar.Name = "picBoxFechar";
			this.picBoxFechar.Size = new System.Drawing.Size(15, 15);
			this.picBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxFechar.TabIndex = 1;
			this.picBoxFechar.TabStop = false;
			this.picBoxFechar.Click += new System.EventHandler(this.picBoxFechar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(562, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(15, 15);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnMenu);
			this.Controls.Add(this.pnConteudo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPrincipal";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.pnMenu.ResumeLayout(false);
			this.pnConteudo.ResumeLayout(false);
			this.pnBarra.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFechar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel pnConteudo;
		private System.Windows.Forms.Panel pnBarra;
		private System.Windows.Forms.Panel pnIndicador;
		private System.Windows.Forms.PictureBox picBoxIcone;
		private System.Windows.Forms.PictureBox picBoxFechar;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

