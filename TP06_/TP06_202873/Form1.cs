using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP06_202873
{
    public partial class FormPrincipal : Form
    {

        #region Variavéis Globais
        int []x = new int[50];
        int i = 1, j, aux, vez;
        int soma, media;
        Boolean muda;

        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
            InvisiblePanel();
        }

        #region SubMenu
        private void InvisiblePanel()
        {
            panelSubOpera.Visible = false;
        }
        private void InvisiblePanel2()
        {
            if (panelSubOpera.Visible == true)
            {
                panelSubOpera.Visible = false;
            }
        }
        private void VisiblePanel(Panel Sub)
        {
            if (Sub.Visible == false)
            {
                InvisiblePanel2();
                Sub.Visible = true;
            }
            else
            {
                Sub.Visible = false;
            }
        }

        private void BtnOpera_Click(object sender, EventArgs e)
        {
            VisiblePanel(panelSubOpera);
            //Mostrar InvisiblePanel2 nos bototes
        }
        #endregion

        #region Valores Start
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            muda = true;
        }
        #endregion

        #region LIMPAR
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            string msg = "Confirma?";
            string titulo = "Limpar...";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Information;
            MessageBoxDefaultButton definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                i = 1;
                j = 0;
                aux = 0;
                vez = 0;
                soma = 0;
                media = 0;
                TxtBAltura.Clear();
                TxtBMedia.Clear();
                listBoxAltura.Items.Clear();
                listBoxRol.Items.Clear();
                lblVez.Text = "1";
            }
        }

        #endregion

        #region SOBRE
        private void BtnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Murilo Lima dos Santos Braz\n RA:202873 \n Disciplina:Programação Visual e Games", "Elaborado por...");
        }
        #endregion

        #region COR MSG
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (muda == true)
            {
                lblMedia.ForeColor = Color.Red;
                muda = false;
            }
            else
            {
                lblMedia.ForeColor = Color.Black;
                muda = true;
            }
        }
        #endregion

        #region ROL
        private void BtnRol_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= vez - 1; i++)
                for (j = i + 1; j <= vez; j++)
                    if (x[i] > x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
            for (i = 1; i <= vez; i++)
            {
                listBoxRol.Items.Add(Convert.ToString(x[i]));
            }
        }
        #endregion

        #region Sequencia

        private void Verifica(object sneder, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Validar
        private void TxtBAltura_Validating(object sender, CancelEventArgs e)
        {
           // Convert.ToInt32 //

            x[i] = int.Parse(TxtBAltura.Text);

            if(x[i] >= 120 && x[i] <= 220)
            {
                if(i <= 50)
                {
                    listBoxAltura.Items.Add(Convert.ToString(x[i]));
                    vez++;
                    i++;
                    lblVez.Text = Convert.ToString(i);
                    TxtBAltura.Clear();
                    TxtBAltura.Focus();
                }
                else
                {
                    TxtBAltura.Enabled = false;
                    listBoxAltura.Items.Add(Convert.ToString(x[i]));
                    lblVez.Text = Convert.ToString(i);
                }
            }
            else
            {
                MessageBox.Show("Altura Incorreta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBAltura.Clear();
                TxtBAltura.Focus();
            }
        }
        #endregion

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= vez; i++)
            {
                soma += x[i];
            }
            media = soma / vez;
            TxtBMedia.Text = Convert.ToString(media);
        }

        #region SAIR
        private void BtnSair_Click(object sender, EventArgs e)
        {
            string msg = "Tem certeza?";
            string titulo = "Sair do programa...";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;
            MessageBoxDefaultButton definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region LIXO
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
