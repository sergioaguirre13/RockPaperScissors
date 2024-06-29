namespace RockPaperScissorsForm
{
    partial class FormInicial
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
            dtvListaJugadores = new DataGridView();
            btnEmpezar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvListaJugadores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(354, 36);
            label1.TabIndex = 0;
            label1.Text = "PIEDRA - PAPEL - TIJERA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtvListaJugadores
            // 
            dtvListaJugadores.AllowUserToOrderColumns = true;
            dtvListaJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvListaJugadores.Location = new Point(52, 147);
            dtvListaJugadores.Name = "dtvListaJugadores";
            dtvListaJugadores.Size = new Size(291, 263);
            dtvListaJugadores.TabIndex = 1;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Location = new Point(151, 90);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(94, 34);
            btnEmpezar.TabIndex = 2;
            btnEmpezar.Text = "EMPEZAR";
            btnEmpezar.UseVisualStyleBackColor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(399, 436);
            Controls.Add(btnEmpezar);
            Controls.Add(dtvListaJugadores);
            Controls.Add(label1);
            Name = "FormInicial";
            Text = "Inicio";
            Load += FormInicial_Load;
            ((System.ComponentModel.ISupportInitialize)dtvListaJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtvListaJugadores;
        private Button btnEmpezar;
    }
}
