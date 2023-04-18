namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultado = new System.Windows.Forms.TextBox();
            this.op2 = new System.Windows.Forms.Label();
            this.b8 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bponto = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.opDividir = new System.Windows.Forms.Button();
            this.opMultiplicar = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.opSomar = new System.Windows.Forms.Button();
            this.opIgual = new System.Windows.Forms.Button();
            this.opSubtrair = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(36, 32);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(180, 23);
            this.resultado.TabIndex = 0;
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(152, 9);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(38, 15);
            this.op2.TabIndex = 1;
            this.op2.Text = "label1";
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(82, 61);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 36);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(82, 145);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 36);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(36, 145);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 36);
            this.b1.TabIndex = 4;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(176, 103);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(40, 36);
            this.CE.TabIndex = 5;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(130, 103);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 36);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(82, 103);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 36);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(36, 103);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 36);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // bponto
            // 
            this.bponto.Location = new System.Drawing.Point(176, 61);
            this.bponto.Name = "bponto";
            this.bponto.Size = new System.Drawing.Size(40, 36);
            this.bponto.TabIndex = 9;
            this.bponto.Text = ".";
            this.bponto.UseVisualStyleBackColor = true;
            this.bponto.Click += new System.EventHandler(this.bponto_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(130, 61);
            this.b9.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 36);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(36, 61);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 36);
            this.b7.TabIndex = 11;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(130, 145);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 36);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // opDividir
            // 
            this.opDividir.Location = new System.Drawing.Point(176, 187);
            this.opDividir.Name = "opDividir";
            this.opDividir.Size = new System.Drawing.Size(40, 36);
            this.opDividir.TabIndex = 13;
            this.opDividir.Text = "/";
            this.opDividir.UseVisualStyleBackColor = true;
            this.opDividir.Click += new System.EventHandler(this.opDividir_Click);
            // 
            // opMultiplicar
            // 
            this.opMultiplicar.Location = new System.Drawing.Point(176, 145);
            this.opMultiplicar.Name = "opMultiplicar";
            this.opMultiplicar.Size = new System.Drawing.Size(40, 36);
            this.opMultiplicar.TabIndex = 14;
            this.opMultiplicar.Text = "*";
            this.opMultiplicar.UseVisualStyleBackColor = true;
            this.opMultiplicar.Click += new System.EventHandler(this.opMultiplicar_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(82, 187);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(40, 36);
            this.b0.TabIndex = 15;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // opSomar
            // 
            this.opSomar.Location = new System.Drawing.Point(36, 187);
            this.opSomar.Name = "opSomar";
            this.opSomar.Size = new System.Drawing.Size(40, 36);
            this.opSomar.TabIndex = 16;
            this.opSomar.Text = "+";
            this.opSomar.UseVisualStyleBackColor = true;
            this.opSomar.Click += new System.EventHandler(this.opSomar_Click);
            // 
            // opIgual
            // 
            this.opIgual.Location = new System.Drawing.Point(36, 229);
            this.opIgual.Name = "opIgual";
            this.opIgual.Size = new System.Drawing.Size(180, 36);
            this.opIgual.TabIndex = 17;
            this.opIgual.Text = "=";
            this.opIgual.UseVisualStyleBackColor = true;
            this.opIgual.Click += new System.EventHandler(this.opIgual_Click);
            // 
            // opSubtrair
            // 
            this.opSubtrair.Location = new System.Drawing.Point(130, 187);
            this.opSubtrair.Name = "opSubtrair";
            this.opSubtrair.Size = new System.Drawing.Size(40, 36);
            this.opSubtrair.TabIndex = 18;
            this.opSubtrair.Text = "-";
            this.opSubtrair.UseVisualStyleBackColor = true;
            this.opSubtrair.Click += new System.EventHandler(this.opSubtrair_Click);
            // 
            // op
            // 
            this.op.AutoSize = true;
            this.op.Location = new System.Drawing.Point(38, 9);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(38, 15);
            this.op.TabIndex = 19;
            this.op.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 277);
            this.Controls.Add(this.op);
            this.Controls.Add(this.opSubtrair);
            this.Controls.Add(this.opIgual);
            this.Controls.Add(this.opSomar);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.opMultiplicar);
            this.Controls.Add(this.opDividir);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bponto);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox resultado;
        private Label op2;
        private Button b8;
        private Button b2;
        private Button b1;
        private Button CE;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button bponto;
        private Button b9;
        private Button b7;
        private Button b3;
        private Button opDividir;
        private Button opMultiplicar;
        private Button b0;
        private Button opSomar;
        private Button opIgual;
        private Button opSubtrair;
        private Label op;
    }
}