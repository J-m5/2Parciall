namespace proyectoParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonJugadores = new Button();
            buttonInventario = new Button();
            buttonSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonJugadores
            // 
            buttonJugadores.BackColor = SystemColors.ActiveCaption;
            buttonJugadores.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJugadores.Location = new Point(127, 81);
            buttonJugadores.Margin = new Padding(3, 4, 3, 4);
            buttonJugadores.Name = "buttonJugadores";
            buttonJugadores.Size = new Size(241, 61);
            buttonJugadores.TabIndex = 0;
            buttonJugadores.Text = "GESTIÓN DE JUGADORES";
            buttonJugadores.UseVisualStyleBackColor = false;
            buttonJugadores.Click += buttonJugadores_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.BackColor = SystemColors.ActiveCaption;
            buttonInventario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInventario.Location = new Point(128, 270);
            buttonInventario.Margin = new Padding(3, 4, 3, 4);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Size = new Size(240, 59);
            buttonInventario.TabIndex = 2;
            buttonInventario.Text = "GESTIÓN DE INVENTARIO";
            buttonInventario.UseVisualStyleBackColor = false;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = SystemColors.ActiveCaption;
            buttonSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(763, 508);
            buttonSalir.Margin = new Padding(3, 4, 3, 4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(110, 48);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(731, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1010, 689);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonInventario);
            Controls.Add(buttonJugadores);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJugadores;
        private Button buttonInventario;
        private Button buttonSalir;
        private PictureBox pictureBox1;
    }
}
