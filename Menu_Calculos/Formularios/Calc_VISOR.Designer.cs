namespace Menu_Calculos
{
    partial class Calc_VISOR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblVisor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.lblHist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblVisor
            // 
            this.LblVisor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisor.Location = new System.Drawing.Point(6, 27);
            this.LblVisor.Name = "LblVisor";
            this.LblVisor.Size = new System.Drawing.Size(415, 70);
            this.LblVisor.TabIndex = 20;
            this.LblVisor.Text = "0";
            this.LblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.btnVirgula);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 417);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(173, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 69);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "<=";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnBack.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(93, 19);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(74, 69);
            this.button20.TabIndex = 33;
            this.button20.Text = "CE";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button20.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(13, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 69);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnLimpar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(93, 319);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(74, 69);
            this.button18.TabIndex = 31;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Digitos);
            this.button18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button18.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.White;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(173, 319);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(74, 69);
            this.btnVirgula.TabIndex = 30;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            this.btnVirgula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnVirgula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(13, 319);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(74, 69);
            this.button16.TabIndex = 29;
            this.button16.Text = "+/-";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(173, 244);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(74, 69);
            this.button15.TabIndex = 28;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Digitos);
            this.button15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(93, 244);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(74, 69);
            this.button14.TabIndex = 27;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Digitos);
            this.button14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(13, 244);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(74, 69);
            this.button13.TabIndex = 26;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Digitos);
            this.button13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(173, 169);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 69);
            this.button12.TabIndex = 25;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Digitos);
            this.button12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(93, 169);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 69);
            this.button11.TabIndex = 24;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Digitos);
            this.button11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(13, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 69);
            this.button10.TabIndex = 23;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Digitos);
            this.button10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(173, 94);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 69);
            this.button9.TabIndex = 22;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Digitos);
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(93, 94);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 69);
            this.button8.TabIndex = 21;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Digitos);
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 69);
            this.button7.TabIndex = 20;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Digitos);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.button7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIgual);
            this.panel2.Controls.Add(this.btnExpo);
            this.panel2.Controls.Add(this.btnDivisao);
            this.panel2.Controls.Add(this.btnMulti);
            this.panel2.Controls.Add(this.btnMais);
            this.panel2.Controls.Add(this.btnMenos);
            this.panel2.Location = new System.Drawing.Point(289, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 417);
            this.panel2.TabIndex = 22;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.White;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(30, 332);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(84, 56);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.button6_Click_1);
            this.btnIgual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnIgual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnExpo
            // 
            this.btnExpo.BackColor = System.Drawing.Color.White;
            this.btnExpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpo.Location = new System.Drawing.Point(30, 270);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(84, 56);
            this.btnExpo.TabIndex = 18;
            this.btnExpo.Text = "^";
            this.btnExpo.UseVisualStyleBackColor = false;
            this.btnExpo.Click += new System.EventHandler(this.operaçoes);
            this.btnExpo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnExpo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.White;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(30, 208);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(84, 56);
            this.btnDivisao.TabIndex = 17;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.operaçoes);
            this.btnDivisao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnDivisao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.White;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(30, 146);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(84, 56);
            this.btnMulti.TabIndex = 16;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.operaçoes);
            this.btnMulti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnMulti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.White;
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(30, 84);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(84, 56);
            this.btnMais.TabIndex = 15;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.operaçoes);
            this.btnMais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnMais.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(30, 19);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(84, 56);
            this.btnMenos.TabIndex = 14;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.operaçoes);
            this.btnMenos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.btnMenos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyUp);
            // 
            // lblHist
            // 
            this.lblHist.Location = new System.Drawing.Point(6, 9);
            this.lblHist.Name = "lblHist";
            this.lblHist.Size = new System.Drawing.Size(415, 33);
            this.lblHist.TabIndex = 23;
            this.lblHist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHist.Click += new System.EventHandler(this.lblHist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // Calc_VISOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 572);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHist);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblVisor);
            this.KeyPreview = true;
            this.Name = "Calc_VISOR";
            this.Text = "Calc_VISOR";
            this.Click += new System.EventHandler(this.Digitos);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_VISOR_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblVisor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblHist;
        private System.Windows.Forms.Label label1;
    }
}