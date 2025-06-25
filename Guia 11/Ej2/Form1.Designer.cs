namespace Ej2
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
            tbNombre = new TextBox();
            btnImprimirNombre = new Button();
            tbInvitaciones = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre del invitado";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(271, 38);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 34);
            tbNombre.TabIndex = 1;
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(473, 38);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(128, 67);
            btnImprimirNombre.TabIndex = 2;
            btnImprimirNombre.Text = "Imprimir nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // tbInvitaciones
            // 
            tbInvitaciones.Location = new Point(91, 120);
            tbInvitaciones.Multiline = true;
            tbInvitaciones.Name = "tbInvitaciones";
            tbInvitaciones.Size = new Size(342, 71);
            tbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 456);
            Controls.Add(tbInvitaciones);
            Controls.Add(btnImprimirNombre);
            Controls.Add(tbNombre);
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
        private TextBox tbNombre;
        private Button btnImprimirNombre;
        private TextBox tbInvitaciones;
    }
}
