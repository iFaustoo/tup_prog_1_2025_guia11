namespace Ej9
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
            cmbServicios = new ComboBox();
            lsbServiciosElegidos = new ListBox();
            btnQuitar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 62);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Servicios:";
            // 
            // cmbServicios
            // 
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Items.AddRange(new object[] { "Cambio de aceite", "Reemplazo de batería", "Reemplazo filtros de aire", "Alineación y balanceo", "Verificación de frenos", "Verificación de luces", "Reemplazo de bobina de arranque" });
            cmbServicios.Location = new Point(22, 104);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(325, 36);
            cmbServicios.TabIndex = 1;
            // 
            // lsbServiciosElegidos
            // 
            lsbServiciosElegidos.FormattingEnabled = true;
            lsbServiciosElegidos.ItemHeight = 28;
            lsbServiciosElegidos.Items.AddRange(new object[] { "" });
            lsbServiciosElegidos.Location = new Point(616, 104);
            lsbServiciosElegidos.Name = "lsbServiciosElegidos";
            lsbServiciosElegidos.Size = new Size(325, 424);
            lsbServiciosElegidos.TabIndex = 5;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(847, 12);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 41);
            btnQuitar.TabIndex = 6;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(424, 276);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 48);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar>";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 629);
            Controls.Add(btnAgregar);
            Controls.Add(btnQuitar);
            Controls.Add(lsbServiciosElegidos);
            Controls.Add(cmbServicios);
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
        private ComboBox cmbServicios;
        private ListBox lsbServiciosElegidos;
        private Button btnQuitar;
        private Button btnAgregar;
    }
}
