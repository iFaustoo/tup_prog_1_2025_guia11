namespace Ej1
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
            label1 = new Label();
            btnGenerar = new Button();
            lbNumero = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Número Generado";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(555, 52);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 42);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.BackColor = SystemColors.ControlDark;
            lbNumero.Location = new Point(264, 59);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(182, 28);
            lbNumero.TabIndex = 2;
            lbNumero.Text = "Ingresar un número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 470);
            Controls.Add(lbNumero);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerar;
        private Label lbNumero;
    }
}
