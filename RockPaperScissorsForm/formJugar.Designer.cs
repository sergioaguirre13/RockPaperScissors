namespace RockPaperScissorsForm
{
    partial class formJugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJugar));
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijera = new Button();
            lblBienvenidaNombre = new Label();
            txbCpu = new TextBox();
            lblContadorVictorias = new Label();
            lblNumeroVictorias = new Label();
            SuspendLayout();
            // 
            // btnPiedra
            // 
            btnPiedra.BackgroundImage = (Image)resources.GetObject("btnPiedra.BackgroundImage");
            btnPiedra.BackgroundImageLayout = ImageLayout.Zoom;
            btnPiedra.Cursor = Cursors.Hand;
            btnPiedra.Location = new Point(44, 111);
            btnPiedra.Name = "btnPiedra";
            btnPiedra.Size = new Size(95, 100);
            btnPiedra.TabIndex = 0;
            btnPiedra.UseVisualStyleBackColor = true;
            btnPiedra.Click += btnPiedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.BackgroundImage = (Image)resources.GetObject("btnPapel.BackgroundImage");
            btnPapel.BackgroundImageLayout = ImageLayout.Zoom;
            btnPapel.Cursor = Cursors.Hand;
            btnPapel.Location = new Point(169, 111);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(95, 100);
            btnPapel.TabIndex = 3;
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTijera
            // 
            btnTijera.BackgroundImage = (Image)resources.GetObject("btnTijera.BackgroundImage");
            btnTijera.BackgroundImageLayout = ImageLayout.Zoom;
            btnTijera.Cursor = Cursors.Hand;
            btnTijera.Location = new Point(292, 111);
            btnTijera.Name = "btnTijera";
            btnTijera.Size = new Size(95, 100);
            btnTijera.TabIndex = 4;
            btnTijera.UseVisualStyleBackColor = true;
            btnTijera.Click += btnTijera_Click;
            // 
            // lblBienvenidaNombre
            // 
            lblBienvenidaNombre.AutoSize = true;
            lblBienvenidaNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenidaNombre.ForeColor = SystemColors.ButtonFace;
            lblBienvenidaNombre.Location = new Point(61, 44);
            lblBienvenidaNombre.Name = "lblBienvenidaNombre";
            lblBienvenidaNombre.Size = new Size(326, 25);
            lblBienvenidaNombre.TabIndex = 5;
            lblBienvenidaNombre.Text = "Bienvenido nombre - hora de JUGAR!";
            // 
            // txbCpu
            // 
            txbCpu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCpu.Location = new Point(44, 267);
            txbCpu.Multiline = true;
            txbCpu.Name = "txbCpu";
            txbCpu.PlaceholderText = "Bienvenido usuario - Aqui veras la selección de la CPU";
            txbCpu.Size = new Size(343, 61);
            txbCpu.TabIndex = 7;
            // 
            // lblContadorVictorias
            // 
            lblContadorVictorias.AutoSize = true;
            lblContadorVictorias.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContadorVictorias.ForeColor = SystemColors.ButtonFace;
            lblContadorVictorias.Location = new Point(92, 346);
            lblContadorVictorias.Name = "lblContadorVictorias";
            lblContadorVictorias.Size = new Size(249, 32);
            lblContadorVictorias.TabIndex = 8;
            lblContadorVictorias.Text = "TOTAL DE VICTORIAS: ";
            // 
            // lblNumeroVictorias
            // 
            lblNumeroVictorias.AutoSize = true;
            lblNumeroVictorias.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroVictorias.ForeColor = SystemColors.ButtonFace;
            lblNumeroVictorias.Location = new Point(166, 378);
            lblNumeroVictorias.Name = "lblNumeroVictorias";
            lblNumeroVictorias.Size = new Size(98, 32);
            lblNumeroVictorias.TabIndex = 9;
            lblNumeroVictorias.Text = "numero";
            // 
            // formJugar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(427, 436);
            Controls.Add(lblNumeroVictorias);
            Controls.Add(lblContadorVictorias);
            Controls.Add(txbCpu);
            Controls.Add(lblBienvenidaNombre);
            Controls.Add(btnTijera);
            Controls.Add(btnPapel);
            Controls.Add(btnPiedra);
            Name = "formJugar";
            Text = "formJugar";
            Load += formJugar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPiedra;
        private Button btnPapel;
        private Button btnTijera;
        private Label lblBienvenidaNombre;
        private TextBox txbCpu;
        private Label lblContadorVictorias;
        private Label lblNumeroVictorias;
    }
}