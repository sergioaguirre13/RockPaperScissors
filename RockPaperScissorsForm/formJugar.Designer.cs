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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJugar));
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijera = new Button();
            lblNombre = new Label();
            tbxNombre = new TextBox();
            txbCpu = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
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
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(133, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(169, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Ingrese su nombre";
            // 
            // tbxNombre
            // 
            tbxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNombre.Location = new Point(133, 47);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(169, 29);
            tbxNombre.TabIndex = 6;
            // 
            // txbCpu
            // 
            txbCpu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCpu.Location = new Point(44, 267);
            txbCpu.Multiline = true;
            txbCpu.Name = "txbCpu";
            txbCpu.Size = new Size(343, 61);
            txbCpu.TabIndex = 7;
            txbCpu.Text = "Bienvenido usuario - Aqui veras la selección de la CPU";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // formJugar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(427, 436);
            Controls.Add(txbCpu);
            Controls.Add(tbxNombre);
            Controls.Add(lblNombre);
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
        private Label lblNombre;
        private TextBox tbxNombre;
        private TextBox txbCpu;
        private System.Windows.Forms.Timer timer1;
    }
}