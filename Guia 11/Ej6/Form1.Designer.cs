namespace Ej6
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
            chbOpcion1 = new CheckBox();
            chbOpcion3 = new CheckBox();
            chbOpcion2 = new CheckBox();
            btnResponder = new Button();
            label1 = new Label();
            label2 = new Label();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // chbOpcion1
            // 
            chbOpcion1.AutoSize = true;
            chbOpcion1.Location = new Point(22, 70);
            chbOpcion1.Name = "chbOpcion1";
            chbOpcion1.Size = new Size(311, 32);
            chbOpcion1.TabIndex = 0;
            chbOpcion1.Text = "No siempre se debe inicializarse";
            chbOpcion1.UseVisualStyleBackColor = true;
            // 
            // chbOpcion3
            // 
            chbOpcion3.AutoSize = true;
            chbOpcion3.Location = new Point(22, 173);
            chbOpcion3.Name = "chbOpcion3";
            chbOpcion3.Size = new Size(259, 32);
            chbOpcion3.TabIndex = 2;
            chbOpcion3.Text = "Siempre debe inicializarse";
            chbOpcion3.UseVisualStyleBackColor = true;
            // 
            // chbOpcion2
            // 
            chbOpcion2.AutoSize = true;
            chbOpcion2.Location = new Point(22, 120);
            chbOpcion2.Name = "chbOpcion2";
            chbOpcion2.Size = new Size(243, 32);
            chbOpcion2.TabIndex = 3;
            chbOpcion2.Text = "Nunca debe inicializarse";
            chbOpcion2.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            btnResponder.Location = new Point(381, 97);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(126, 55);
            btnResponder.TabIndex = 4;
            btnResponder.Text = "Responder";
            btnResponder.UseVisualStyleBackColor = true;
            btnResponder.Click += btnResponder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 5;
            label1.Text = "Una variable local:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 246);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 6;
            label2.Text = "Resultado:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(145, 246);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 28);
            lbResultado.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 546);
            Controls.Add(lbResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnResponder);
            Controls.Add(chbOpcion2);
            Controls.Add(chbOpcion3);
            Controls.Add(chbOpcion1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbOpcion1;
        private CheckBox chbOpcion3;
        private CheckBox chbOpcion2;
        private Button btnResponder;
        private Label label1;
        private Label label2;
        private Label lbResultado;
    }
}
