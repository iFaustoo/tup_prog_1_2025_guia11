namespace Ej7
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
            rbExcelente = new RadioButton();
            rbBueno = new RadioButton();
            rbInsuficiente = new RadioButton();
            rbBase = new RadioButton();
            rbFULL = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnVotar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbFULL = new Label();
            lbBase = new Label();
            lbInsuficientes = new Label();
            lbBuenos = new Label();
            lbExcelentes = new Label();
            lbTotal = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(6, 33);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(114, 32);
            rbExcelente.TabIndex = 0;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(6, 71);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(88, 32);
            rbBueno.TabIndex = 1;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(6, 109);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(131, 32);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // rbBase
            // 
            rbBase.AutoSize = true;
            rbBase.Location = new Point(6, 49);
            rbBase.Name = "rbBase";
            rbBase.Size = new Size(72, 32);
            rbBase.TabIndex = 3;
            rbBase.TabStop = true;
            rbBase.Text = "Base";
            rbBase.UseVisualStyleBackColor = true;
            // 
            // rbFULL
            // 
            rbFULL.AutoSize = true;
            rbFULL.Location = new Point(6, 87);
            rbFULL.Name = "rbFULL";
            rbFULL.Size = new Size(75, 32);
            rbFULL.TabIndex = 4;
            rbFULL.TabStop = true;
            rbFULL.Text = "FULL";
            rbFULL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbExcelente);
            groupBox1.Controls.Add(rbBueno);
            groupBox1.Controls.Add(rbInsuficiente);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 163);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opinión";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbBase);
            groupBox2.Controls.Add(rbFULL);
            groupBox2.Location = new Point(25, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Producto";
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(373, 153);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(105, 52);
            btnVotar.TabIndex = 7;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 60);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 8;
            label1.Text = "Cantidad de votaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 129);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 9;
            label2.Text = "Cantidad de excelentes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 192);
            label3.Name = "label3";
            label3.Size = new Size(191, 28);
            label3.TabIndex = 10;
            label3.Text = "Cantidad de buenos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 248);
            label4.Name = "label4";
            label4.Size = new Size(233, 28);
            label4.TabIndex = 11;
            label4.Text = "Cantidad de insuficientes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 307);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 12;
            label5.Text = "Cantidad de Base:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 368);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 13;
            label6.Text = "Cantidad de FILL:";
            // 
            // lbFULL
            // 
            lbFULL.AutoSize = true;
            lbFULL.Location = new Point(360, 368);
            lbFULL.Name = "lbFULL";
            lbFULL.Size = new Size(65, 28);
            lbFULL.TabIndex = 14;
            lbFULL.Text = "label7";
            // 
            // lbBase
            // 
            lbBase.AutoSize = true;
            lbBase.Location = new Point(360, 307);
            lbBase.Name = "lbBase";
            lbBase.Size = new Size(65, 28);
            lbBase.TabIndex = 15;
            lbBase.Text = "label8";
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.AutoSize = true;
            lbInsuficientes.Location = new Point(360, 248);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(65, 28);
            lbInsuficientes.TabIndex = 16;
            lbInsuficientes.Text = "label9";
            // 
            // lbBuenos
            // 
            lbBuenos.AutoSize = true;
            lbBuenos.Location = new Point(360, 192);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(76, 28);
            lbBuenos.TabIndex = 17;
            lbBuenos.Text = "label10";
            // 
            // lbExcelentes
            // 
            lbExcelentes.AutoSize = true;
            lbExcelentes.Location = new Point(360, 129);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(76, 28);
            lbExcelentes.TabIndex = 18;
            lbExcelentes.Text = "label11";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(360, 59);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(76, 28);
            lbTotal.TabIndex = 19;
            lbTotal.Text = "label12";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lbFULL);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lbBase);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lbInsuficientes);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lbBuenos);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lbExcelentes);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(532, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(524, 421);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados de la encuesta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 584);
            Controls.Add(groupBox3);
            Controls.Add(btnVotar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbExcelente;
        private RadioButton rbBueno;
        private RadioButton rbInsuficiente;
        private RadioButton rbBase;
        private RadioButton rbFULL;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnVotar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbFULL;
        private Label lbBase;
        private Label lbInsuficientes;
        private Label lbBuenos;
        private Label lbExcelentes;
        private Label lbTotal;
        private GroupBox groupBox3;
    }
}
