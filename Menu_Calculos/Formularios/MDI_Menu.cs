using Github_csharp;
using Github_csharp.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos.Formularios
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            name.Text = DateTime.Now.ToString();
        }

        private void calculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm<Calc_bts>(); // ChildForm é o tipo do formulário filho
        }
        private void OpenChildForm<T>() where T : Form, new()
        {
            var existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (existingForm != null)
            {
                // Se já existe, traz para frente e ativa
                existingForm.BringToFront();
                existingForm.Activate();
            }
            else
            {
                // Se não existe, cria e exibe
                var newForm = new T
                {
                    MdiParent = this,
                };
                newForm.Show();
            }
        }
        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<Calc_bts>(); // ChildForm é o tipo do formulário filho
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?",
                "Saindo...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
          
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<CalcRadio>(); // ChildForm é o tipo do formulário filho
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm<CalcRadio>(); // ChildForm é o tipo do formulário filho
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cascatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.LayoutMdi(MdiLayout.Cascade);
            
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vErticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void visorUnicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm<CalcDeVdd>();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm<CalcDeVdd>();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/gustavnerisfx/Solu-o_Calculos_DS/blob/master/README.md",
                UseShellExecute = true
            });
        }

        private void calculadoraWindownsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void nAvegadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://duckduckgo.com/",
                UseShellExecute = true
            });
        }

        private void desenvolvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Matheus Henrique Fernandes Mello, Luiz Felipe Silva Oliveira";
            string title = "Desenvolvedores";
            MessageBox.Show(message, title);
        }
    }
}
