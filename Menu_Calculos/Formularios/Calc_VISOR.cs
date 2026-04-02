using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class Calc_VISOR : Form
    {
        decimal vNumAnt;
        string vOperação;
        bool vlimparVisor;

        

        public Calc_VISOR()
        {
            InitializeComponent();
        }

        private void Digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender). Text ;
            if (LblVisor.Text == "0" || vlimparVisor)
            {
                LblVisor.Text = "";
                vlimparVisor = false;
            }
            LblVisor.Text += digito;

            this.ActiveControl = null;

        }

        private void operaçoes(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(LblVisor.Text);
            vOperação = ((Button)sender).Text;
            vlimparVisor = true;
            lblHist.Text = ""; 
            lblHist.Text = vNumAnt + " " + vOperação + " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(LblVisor.Text);

            switch (vOperação)
            {
                case "+":
                    LblVisor.Text = (vNumAnt + vNumAtual).ToString();
                break;

                case "-":
                    LblVisor.Text = (vNumAnt - vNumAtual).ToString();
                break;

                case "/":
                    LblVisor.Text = (vNumAnt / vNumAtual).ToString();
                break;
                case "^":
                    LblVisor.Text = (Math.Pow((double)vNumAnt, (double)vNumAtual)).ToString();
                    break;
            }
            lblHist.Text += vNumAtual + " =";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!LblVisor.Text.Contains(","))
            {
                LblVisor.Text = ",";
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vNumAnt = 0;
            LblVisor.Text = "0";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            LblVisor.Text = LblVisor.Text.Substring(0,LblVisor.Text.Length - 1);
            if (LblVisor.Text == "0") LblVisor.Text = "";
           
        }

        private void Calc_VISOR_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            Button botao = new Button();
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode >= Keys.NumPad0  &&  e.KeyCode <= Keys.NumPad9) 
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                foreach (Control item in panel1.Controls)
                {
                    if (((Button)item).Text == botao.Text)
                    {
                        item.BackColor = Color.Black;
                    }
                    
                }
                
                Digitos(botao, e);
            }
            switch (e.KeyCode)
            {
                case Keys.Add:
                    botao.Text = "+";
                    operaçoes(botao, e);
                    break;
                case Keys.Subtract:
                    botao.Text = "-";
                    operaçoes(botao, e);
                    break;
                case Keys.Divide:
                    botao.Text = "/";
                    operaçoes(botao, e);
                    break;
                case Keys.Multiply:
                    botao.Text = "*";
                    operaçoes(botao, e);
                    break;
                case Keys.Return:
                    button6_Click_1(botao, e);
                    break;
            }

            this.KeyPreview = true;
        }
        private void Calc_VISOR_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            Button botao = new Button();
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                foreach (Control item in panel1.Controls)
                {
                    if (((Button)item).Text == botao.Text)
                    {
                        item.BackColor = Color.White;
                    }

                }

                Digitos(botao, e);
            }
        }

        private void lblHist_Click(object sender, EventArgs e)
        {

        }
    }
}
