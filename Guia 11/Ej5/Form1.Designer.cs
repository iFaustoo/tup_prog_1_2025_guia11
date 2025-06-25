namespace Ej5
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
            btnVotar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbBuenos = new ListBox();
            lbExcelentes = new ListBox();
            lbInsuficientes = new ListBox();
            lbTotal = new ListBox();
            SuspendLayout();
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(53, 33);
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
            rbBueno.Location = new Point(53, 89);
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
            rbInsuficiente.Location = new Point(53, 142);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(131, 32);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(349, 73);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(120, 65);
            btnVotar.TabIndex = 3;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 221);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de votaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 272);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 5;
            label2.Text = "Excelentes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 332);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 6;
            label3.Text = "Buenos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 379);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 7;
            label4.Text = "Insuficientes:";
            // 
            // lbBuenos
            // 
            lbBuenos.FormattingEnabled = true;
            lbBuenos.ItemHeight = 28;
            lbBuenos.Location = new Point(150, 332);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(319, 32);
            lbBuenos.TabIndex = 8;
            // 
            // lbExcelentes
            // 
            lbExcelentes.FormattingEnabled = true;
            lbExcelentes.ItemHeight = 28;
            lbExcelentes.Location = new Point(150, 272);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(319, 32);
            lbExcelentes.TabIndex = 9;
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.FormattingEnabled = true;
            lbInsuficientes.ItemHeight = 28;
            lbInsuficientes.Location = new Point(150, 382);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(319, 32);
            lbInsuficientes.TabIndex = 10;
            // 
            // lbTotal
            // 
            lbTotal.FormattingEnabled = true;
            lbTotal.ItemHeight = 28;
            lbTotal.Location = new Point(239, 221);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(319, 32);
            lbTotal.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 469);
            Controls.Add(lbTotal);
            Controls.Add(lbInsuficientes);
            Controls.Add(lbExcelentes);
            Controls.Add(lbBuenos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVotar);
            Controls.Add(rbInsuficiente);
            Controls.Add(rbBueno);
            Controls.Add(rbExcelente);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbExcelente;
        private RadioButton rbBueno;
        private RadioButton rbInsuficiente;
        private Button btnVotar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lbBuenos;
        private ListBox lbExcelentes;
        private ListBox lbInsuficientes;
        private ListBox lbTotal;
    }
}
