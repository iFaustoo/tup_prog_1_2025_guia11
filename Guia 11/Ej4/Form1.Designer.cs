namespace Ej4
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
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            nudMinuto = new NumericUpDown();
            nudHora = new NumericUpDown();
            label3 = new Label();
            lbMinutos = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(458, 33);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(106, 50);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 1;
            label1.Text = "Tiempo en H:M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 42);
            label2.Name = "label2";
            label2.Size = new Size(16, 28);
            label2.TabIndex = 2;
            label2.Text = ":";
            // 
            // nudMinuto
            // 
            nudMinuto.Location = new Point(357, 42);
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(53, 34);
            nudMinuto.TabIndex = 3;
            // 
            // nudHora
            // 
            nudHora.Location = new Point(265, 42);
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(64, 34);
            nudHora.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 139);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 5;
            label3.Text = "Tiempo en Minutos:";
            // 
            // lbMinutos
            // 
            lbMinutos.AutoSize = true;
            lbMinutos.BackColor = SystemColors.ControlDark;
            lbMinutos.Location = new Point(224, 139);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(101, 28);
            lbMinutos.TabIndex = 6;
            lbMinutos.Text = "lbMinutos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 328);
            Controls.Add(lbMinutos);
            Controls.Add(label3);
            Controls.Add(nudHora);
            Controls.Add(nudMinuto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label label1;
        private Label label2;
        private NumericUpDown nudMinuto;
        private NumericUpDown nudHora;
        private Label label3;
        private Label lbMinutos;
    }
}
