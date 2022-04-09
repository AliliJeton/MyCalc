namespace MyCalc
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnGeteilt = new System.Windows.Forms.Button();
            this.btnGleich = new System.Windows.Forms.Button();
            this.btnPunkt = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.BtnCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(352, 44);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Silver;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDel.Location = new System.Drawing.Point(12, 68);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 63);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "⌫";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.BS);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Silver;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCE.Location = new System.Drawing.Point(104, 68);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 63);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.Silver;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPlusMinus.Location = new System.Drawing.Point(288, 68);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(75, 63);
            this.btnPlusMinus.TabIndex = 1;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Silver;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPlus.Location = new System.Drawing.Point(288, 145);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 59);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.Info;
            this.btn9.Location = new System.Drawing.Point(196, 145);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 59);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Info;
            this.btn8.Location = new System.Drawing.Point(104, 145);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 59);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Info;
            this.btn7.Location = new System.Drawing.Point(12, 145);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 59);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Silver;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMinus.Location = new System.Drawing.Point(288, 218);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 63);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Info;
            this.btn6.Location = new System.Drawing.Point(196, 218);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 63);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Info;
            this.btn5.Location = new System.Drawing.Point(104, 218);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 63);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Info;
            this.btn4.Location = new System.Drawing.Point(12, 218);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 63);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Silver;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.Info;
            this.btnX.Location = new System.Drawing.Point(288, 295);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 63);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Info;
            this.btn3.Location = new System.Drawing.Point(196, 295);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 63);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Info;
            this.btn2.Location = new System.Drawing.Point(104, 295);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 63);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Info;
            this.btn1.Location = new System.Drawing.Point(12, 295);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 63);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnGeteilt
            // 
            this.btnGeteilt.BackColor = System.Drawing.Color.Silver;
            this.btnGeteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeteilt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGeteilt.Location = new System.Drawing.Point(288, 372);
            this.btnGeteilt.Name = "btnGeteilt";
            this.btnGeteilt.Size = new System.Drawing.Size(75, 63);
            this.btnGeteilt.TabIndex = 14;
            this.btnGeteilt.Text = "/";
            this.btnGeteilt.UseVisualStyleBackColor = false;
            this.btnGeteilt.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btnGleich
            // 
            this.btnGleich.BackColor = System.Drawing.Color.Silver;
            this.btnGleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGleich.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGleich.Location = new System.Drawing.Point(196, 372);
            this.btnGleich.Name = "btnGleich";
            this.btnGleich.Size = new System.Drawing.Size(75, 63);
            this.btnGleich.TabIndex = 15;
            this.btnGleich.Text = "=";
            this.btnGleich.UseVisualStyleBackColor = false;
            // 
            // btnPunkt
            // 
            this.btnPunkt.BackColor = System.Drawing.Color.Silver;
            this.btnPunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunkt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPunkt.Location = new System.Drawing.Point(104, 372);
            this.btnPunkt.Name = "btnPunkt";
            this.btnPunkt.Size = new System.Drawing.Size(75, 63);
            this.btnPunkt.TabIndex = 16;
            this.btnPunkt.Text = ".";
            this.btnPunkt.UseVisualStyleBackColor = false;
            this.btnPunkt.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.Info;
            this.btn0.Location = new System.Drawing.Point(12, 372);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 63);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumericValue);
            // 
            // BtnCC
            // 
            this.BtnCC.BackColor = System.Drawing.Color.Silver;
            this.BtnCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCC.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnCC.Location = new System.Drawing.Point(196, 68);
            this.BtnCC.Name = "BtnCC";
            this.BtnCC.Size = new System.Drawing.Size(75, 63);
            this.BtnCC.TabIndex = 18;
            this.BtnCC.Text = "C";
            this.BtnCC.UseVisualStyleBackColor = false;
            this.BtnCC.Click += new System.EventHandler(this.BtnCC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(376, 449);
            this.Controls.Add(this.BtnCC);
            this.Controls.Add(this.btnGeteilt);
            this.Controls.Add(this.btnGleich);
            this.Controls.Add(this.btnPunkt);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.NumericValue);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnGeteilt;
        private System.Windows.Forms.Button btnGleich;
        private System.Windows.Forms.Button btnPunkt;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button BtnCC;
    }
}

