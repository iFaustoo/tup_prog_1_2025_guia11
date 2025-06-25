namespace Ej3
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
            btnImprimirNombre = new Button();
            tbNombre = new TextBox();
            label1 = new Label();
            lsbInvitaciones = new ListBox();
            SuspendLayout();
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(499, 13);
            btnImprimirNombre.Margin = new Padding(4, 4, 4, 4);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(176, 94);
            btnImprimirNombre.TabIndex = 6;
            btnImprimirNombre.Text = "Imprimir nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(286, 31);
            tbNombre.Margin = new Padding(4, 4, 4, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(170, 34);
            tbNombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 4;
            label1.Text = "Nombre del invitado";
            // 
            // lsbInvitaciones
            // 
            lsbInvitaciones.FormattingEnabled = true;
            lsbInvitaciones.ItemHeight = 28;
            lsbInvitaciones.Location = new Point(101, 112);
            lsbInvitaciones.Name = "lsbInvitaciones";
            lsbInvitaciones.Size = new Size(369, 116);
            lsbInvitaciones.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 378);
            Controls.Add(lsbInvitaciones);
            Controls.Add(btnImprimirNombre);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimirNombre;
        private TextBox tbNombre;
        private Label label1;
        private ListBox lsbInvitaciones;
    }
}
