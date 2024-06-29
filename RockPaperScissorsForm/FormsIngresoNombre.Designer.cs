namespace RockPaperScissorsForm
{
    partial class FormsIngresoNombre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCargarNombre = new Button();
            tbxNombre = new TextBox();
            SuspendLayout();
            // 
            // btnCargarNombre
            // 
            btnCargarNombre.Location = new Point(110, 56);
            btnCargarNombre.Name = "btnCargarNombre";
            btnCargarNombre.Size = new Size(105, 32);
            btnCargarNombre.TabIndex = 0;
            btnCargarNombre.Text = "Cargar nombre";
            btnCargarNombre.UseVisualStyleBackColor = true;
            btnCargarNombre.Click += btnCargarNombre_Click;
            // 
            // tbxNombre
            // 
            tbxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNombre.Location = new Point(58, 15);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.PlaceholderText = "INGRESE SU NOMBRE";
            tbxNombre.Size = new Size(203, 29);
            tbxNombre.TabIndex = 1;
            // 
            // FormsIngresoNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 100);
            Controls.Add(tbxNombre);
            Controls.Add(btnCargarNombre);
            Name = "FormsIngresoNombre";
            Text = "FormsIngresoNombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarNombre;
        private TextBox tbxNombre;
    }
}