namespace CalculatorApp
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPersen = new System.Windows.Forms.Button();
            this.btnAkar = new System.Windows.Forms.Button();
            this.btnPhi = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnKuadrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInput.Location = new System.Drawing.Point(14, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(492, 30);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.HotPink;
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Location = new System.Drawing.Point(12, 96);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(94, 47);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.HotPink;
            this.btnTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTime.Location = new System.Drawing.Point(312, 96);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(94, 47);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "×";
            this.btnTime.UseVisualStyleBackColor = false;
            this.btnTime.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.HotPink;
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnD.Location = new System.Drawing.Point(212, 96);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(94, 47);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "=>";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.HotPink;
            this.btnCE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCE.Location = new System.Drawing.Point(112, 96);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(94, 47);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.HotPink;
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(112, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(94, 47);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.HotPink;
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(212, 149);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(94, 47);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.HotPink;
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivide.Location = new System.Drawing.Point(312, 149);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(94, 47);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.HotPink;
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(12, 149);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(94, 47);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.HotPink;
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(112, 202);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(94, 47);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.HotPink;
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(212, 202);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(94, 47);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.HotPink;
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinus.Location = new System.Drawing.Point(312, 202);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(94, 47);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.HotPink;
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(12, 202);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 47);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.HotPink;
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(112, 255);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 47);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleDescription = "";
            this.btn3.BackColor = System.Drawing.Color.HotPink;
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(212, 255);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(94, 47);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.HotPink;
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlus.Location = new System.Drawing.Point(312, 255);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(94, 47);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.HotPink;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(12, 255);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 47);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.HotPink;
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(112, 308);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(94, 47);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnAngka_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.HotPink;
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlusMinus.Location = new System.Drawing.Point(212, 308);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(94, 47);
            this.btnPlusMinus.TabIndex = 20;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.HotPink;
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquals.Location = new System.Drawing.Point(312, 308);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(94, 47);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.HotPink;
            this.btnComma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComma.Location = new System.Drawing.Point(12, 308);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(94, 47);
            this.btnComma.TabIndex = 18;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.UseWaitCursor = true;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Location = new System.Drawing.Point(13, 48);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(493, 42);
            this.txtResult.TabIndex = 22;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPersen
            // 
            this.btnPersen.BackColor = System.Drawing.Color.HotPink;
            this.btnPersen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersen.Location = new System.Drawing.Point(412, 96);
            this.btnPersen.Name = "btnPersen";
            this.btnPersen.Size = new System.Drawing.Size(94, 47);
            this.btnPersen.TabIndex = 23;
            this.btnPersen.Text = "%";
            this.btnPersen.UseVisualStyleBackColor = false;
            this.btnPersen.Click += new System.EventHandler(this.btnPersen_Click);
            // 
            // btnAkar
            // 
            this.btnAkar.BackColor = System.Drawing.Color.HotPink;
            this.btnAkar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAkar.Location = new System.Drawing.Point(412, 149);
            this.btnAkar.Name = "btnAkar";
            this.btnAkar.Size = new System.Drawing.Size(94, 47);
            this.btnAkar.TabIndex = 24;
            this.btnAkar.Text = "×²";
            this.btnAkar.UseVisualStyleBackColor = false;
            this.btnAkar.Click += new System.EventHandler(this.btnAkar_Click);
            // 
            // btnPhi
            // 
            this.btnPhi.BackColor = System.Drawing.Color.HotPink;
            this.btnPhi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPhi.Location = new System.Drawing.Point(412, 202);
            this.btnPhi.Name = "btnPhi";
            this.btnPhi.Size = new System.Drawing.Size(94, 47);
            this.btnPhi.TabIndex = 25;
            this.btnPhi.Text = "𝝿";
            this.btnPhi.UseVisualStyleBackColor = false;
            this.btnPhi.Click += new System.EventHandler(this.btnPhi_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.HotPink;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMod.Location = new System.Drawing.Point(412, 255);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(94, 47);
            this.btnMod.TabIndex = 26;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnKuadrat
            // 
            this.btnKuadrat.BackColor = System.Drawing.Color.HotPink;
            this.btnKuadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKuadrat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKuadrat.Location = new System.Drawing.Point(412, 308);
            this.btnKuadrat.Name = "btnKuadrat";
            this.btnKuadrat.Size = new System.Drawing.Size(94, 47);
            this.btnKuadrat.TabIndex = 27;
            this.btnKuadrat.Text = "√ ";
            this.btnKuadrat.UseVisualStyleBackColor = false;
            this.btnKuadrat.Click += new System.EventHandler(this.btnKuadrat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(518, 369);
            this.Controls.Add(this.btnKuadrat);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnPhi);
            this.Controls.Add(this.btnAkar);
            this.Controls.Add(this.btnPersen);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPersen;
        private System.Windows.Forms.Button btnAkar;
        private System.Windows.Forms.Button btnPhi;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnKuadrat;
    }
}

