namespace Ej8
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
            btnAgregar = new Button();
            btnQuitar = new Button();
            lsbServiciosElegidos = new ListBox();
            lsbServicios = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Servicios:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(400, 258);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 50);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar>";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(760, 12);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 50);
            btnQuitar.TabIndex = 3;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lsbServiciosElegidos
            // 
            lsbServiciosElegidos.FormattingEnabled = true;
            lsbServiciosElegidos.ItemHeight = 28;
            lsbServiciosElegidos.Items.AddRange(new object[] { "" });
            lsbServiciosElegidos.Location = new Point(529, 81);
            lsbServiciosElegidos.Name = "lsbServiciosElegidos";
            lsbServiciosElegidos.Size = new Size(325, 424);
            lsbServiciosElegidos.TabIndex = 4;
            // 
            // lsbServicios
            // 
            lsbServicios.FormattingEnabled = true;
            lsbServicios.ItemHeight = 28;
            lsbServicios.Items.AddRange(new object[] { "Cambio de aceite", "Reemplazo batería", "Reemplazo filtros de aire", "Alineación y balanceo", "Verificación de frenos", "Verificación de luces", "Reemplazo de bobina de arranque" });
            lsbServicios.Location = new Point(22, 81);
            lsbServicios.Name = "lsbServicios";
            lsbServicios.Size = new Size(332, 424);
            lsbServicios.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 617);
            Controls.Add(lsbServicios);
            Controls.Add(lsbServiciosElegidos);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
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
        private Button btnAgregar;
        private Button btnQuitar;
        private ListBox lsbServiciosElegidos;
        private ListBox lsbServicios;
    }
}
