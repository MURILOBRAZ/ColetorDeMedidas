namespace TP06_202873
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panelMenuE = new System.Windows.Forms.Panel();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.panelSubOpera = new System.Windows.Forms.Panel();
            this.BtnMedia = new System.Windows.Forms.Button();
            this.BtnRol = new System.Windows.Forms.Button();
            this.BtnOpera = new System.Windows.Forms.Button();
            this.panelImagem = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.listBoxRol = new System.Windows.Forms.ListBox();
            this.listBoxAltura = new System.Windows.Forms.ListBox();
            this.groupBoxMedia = new System.Windows.Forms.GroupBox();
            this.groupBoxAltura = new System.Windows.Forms.GroupBox();
            this.groupBoxRol = new System.Windows.Forms.GroupBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtBMedia = new System.Windows.Forms.TextBox();
            this.panelMenuE.SuspendLayout();
            this.panelSubOpera.SuspendLayout();
            this.panelImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxMedia.SuspendLayout();
            this.groupBoxRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuE
            // 
            this.panelMenuE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenuE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenuE.Controls.Add(this.BtnSobre);
            this.panelMenuE.Controls.Add(this.BtnSair);
            this.panelMenuE.Controls.Add(this.BtnLimpar);
            this.panelMenuE.Controls.Add(this.panelSubOpera);
            this.panelMenuE.Controls.Add(this.BtnOpera);
            this.panelMenuE.Controls.Add(this.panelImagem);
            this.panelMenuE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuE.Location = new System.Drawing.Point(0, 0);
            this.panelMenuE.Name = "panelMenuE";
            this.panelMenuE.Size = new System.Drawing.Size(250, 541);
            this.panelMenuE.TabIndex = 0;
            // 
            // BtnSobre
            // 
            this.BtnSobre.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobre.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSobre.Location = new System.Drawing.Point(0, 441);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSobre.Size = new System.Drawing.Size(246, 45);
            this.BtnSobre.TabIndex = 5;
            this.BtnSobre.Text = "Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.UseVisualStyleBackColor = true;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSair.Location = new System.Drawing.Point(0, 492);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(246, 46);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.Location = new System.Drawing.Point(0, 240);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnLimpar.Size = new System.Drawing.Size(246, 45);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // panelSubOpera
            // 
            this.panelSubOpera.Controls.Add(this.BtnMedia);
            this.panelSubOpera.Controls.Add(this.BtnRol);
            this.panelSubOpera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubOpera.Location = new System.Drawing.Point(0, 145);
            this.panelSubOpera.Name = "panelSubOpera";
            this.panelSubOpera.Size = new System.Drawing.Size(246, 95);
            this.panelSubOpera.TabIndex = 2;
            // 
            // BtnMedia
            // 
            this.BtnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMedia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMedia.FlatAppearance.BorderSize = 0;
            this.BtnMedia.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedia.ForeColor = System.Drawing.Color.White;
            this.BtnMedia.Location = new System.Drawing.Point(0, 45);
            this.BtnMedia.Name = "BtnMedia";
            this.BtnMedia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnMedia.Size = new System.Drawing.Size(246, 45);
            this.BtnMedia.TabIndex = 1;
            this.BtnMedia.Text = "Média";
            this.BtnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedia.UseVisualStyleBackColor = false;
            this.BtnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
            // 
            // BtnRol
            // 
            this.BtnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRol.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRol.FlatAppearance.BorderSize = 0;
            this.BtnRol.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRol.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRol.ForeColor = System.Drawing.Color.White;
            this.BtnRol.Location = new System.Drawing.Point(0, 0);
            this.BtnRol.Name = "BtnRol";
            this.BtnRol.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnRol.Size = new System.Drawing.Size(246, 45);
            this.BtnRol.TabIndex = 0;
            this.BtnRol.Text = "ROL";
            this.BtnRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRol.UseVisualStyleBackColor = false;
            this.BtnRol.Click += new System.EventHandler(this.BtnRol_Click);
            // 
            // BtnOpera
            // 
            this.BtnOpera.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOpera.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnOpera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpera.ForeColor = System.Drawing.Color.Transparent;
            this.BtnOpera.Location = new System.Drawing.Point(0, 100);
            this.BtnOpera.Name = "BtnOpera";
            this.BtnOpera.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOpera.Size = new System.Drawing.Size(246, 45);
            this.BtnOpera.TabIndex = 1;
            this.BtnOpera.Text = "Operações";
            this.BtnOpera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpera.UseVisualStyleBackColor = true;
            this.BtnOpera.Click += new System.EventHandler(this.BtnOpera_Click);
            // 
            // panelImagem
            // 
            this.panelImagem.Controls.Add(this.pictureBox2);
            this.panelImagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImagem.Location = new System.Drawing.Point(0, 0);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(246, 100);
            this.panelImagem.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TP06_202873.Properties.Resources.medidor_de_altura4;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMedia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtBAltura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblVez);
            this.panel2.Location = new System.Drawing.Point(482, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 60);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "(cm)";
            // 
            // TxtBAltura
            // 
            this.TxtBAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBAltura.Location = new System.Drawing.Point(140, 16);
            this.TxtBAltura.Name = "TxtBAltura";
            this.TxtBAltura.Size = new System.Drawing.Size(41, 29);
            this.TxtBAltura.TabIndex = 2;
            this.TxtBAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBAltura.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBAltura_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "° Altura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.ForeColor = System.Drawing.Color.White;
            this.lblVez.Location = new System.Drawing.Point(15, 14);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(26, 29);
            this.lblVez.TabIndex = 8;
            this.lblVez.Text = "1";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.White;
            this.lblMedia.Location = new System.Drawing.Point(6, 37);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(457, 25);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Insira 50 Alturas de uma Determinada Amostra";
            // 
            // listBoxRol
            // 
            this.listBoxRol.FormattingEnabled = true;
            this.listBoxRol.Location = new System.Drawing.Point(6, 16);
            this.listBoxRol.Name = "listBoxRol";
            this.listBoxRol.Size = new System.Drawing.Size(189, 290);
            this.listBoxRol.TabIndex = 2;
            this.listBoxRol.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxAltura
            // 
            this.listBoxAltura.FormattingEnabled = true;
            this.listBoxAltura.Location = new System.Drawing.Point(570, 122);
            this.listBoxAltura.Name = "listBoxAltura";
            this.listBoxAltura.Size = new System.Drawing.Size(192, 290);
            this.listBoxAltura.TabIndex = 4;
            // 
            // groupBoxMedia
            // 
            this.groupBoxMedia.Controls.Add(this.TxtBMedia);
            this.groupBoxMedia.Location = new System.Drawing.Point(258, 410);
            this.groupBoxMedia.Name = "groupBoxMedia";
            this.groupBoxMedia.Size = new System.Drawing.Size(278, 119);
            this.groupBoxMedia.TabIndex = 5;
            this.groupBoxMedia.TabStop = false;
            this.groupBoxMedia.Text = ".:Média das Alturas:.";
            // 
            // groupBoxAltura
            // 
            this.groupBoxAltura.Location = new System.Drawing.Point(562, 106);
            this.groupBoxAltura.Name = "groupBoxAltura";
            this.groupBoxAltura.Size = new System.Drawing.Size(207, 319);
            this.groupBoxAltura.TabIndex = 6;
            this.groupBoxAltura.TabStop = false;
            this.groupBoxAltura.Text = ".:Alturas Fornecidas:.";
            // 
            // groupBoxRol
            // 
            this.groupBoxRol.Controls.Add(this.listBoxRol);
            this.groupBoxRol.Location = new System.Drawing.Point(798, 106);
            this.groupBoxRol.Name = "groupBoxRol";
            this.groupBoxRol.Size = new System.Drawing.Size(201, 319);
            this.groupBoxRol.TabIndex = 7;
            this.groupBoxRol.TabStop = false;
            this.groupBoxRol.Text = ".:Alturas em ROL:.";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP06_202873.Properties.Resources.MãoRegua;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(258, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 298);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtBMedia
            // 
            this.TxtBMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBMedia.Location = new System.Drawing.Point(15, 49);
            this.TxtBMedia.Name = "TxtBMedia";
            this.TxtBMedia.Size = new System.Drawing.Size(244, 29);
            this.TxtBMedia.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.groupBoxMedia);
            this.Controls.Add(this.listBoxAltura);
            this.Controls.Add(this.groupBoxAltura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuE);
            this.Controls.Add(this.groupBoxRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coletor de Altura";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenuE.ResumeLayout(false);
            this.panelSubOpera.ResumeLayout(false);
            this.panelImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxMedia.ResumeLayout(false);
            this.groupBoxMedia.PerformLayout();
            this.groupBoxRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuE;
        private System.Windows.Forms.Panel panelSubOpera;
        private System.Windows.Forms.Button BtnMedia;
        private System.Windows.Forms.Button BtnRol;
        private System.Windows.Forms.Button BtnOpera;
        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxRol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxAltura;
        private System.Windows.Forms.GroupBox groupBoxMedia;
        private System.Windows.Forms.GroupBox groupBoxAltura;
        private System.Windows.Forms.GroupBox groupBoxRol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBAltura;
        private System.Windows.Forms.Button BtnSobre;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.TextBox TxtBMedia;
    }
}

