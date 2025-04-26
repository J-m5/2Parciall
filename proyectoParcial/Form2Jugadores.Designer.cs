namespace proyectoParcial
{
    partial class Form2Jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Jugadores));
            label1 = new Label();
            label2 = new Label();
            textBoxIDjugador = new TextBox();
            label3 = new Label();
            textBoxNombreJugadores = new TextBox();
            label4 = new Label();
            textBoxNivelJugadores = new TextBox();
            buttonAgregarJ = new Button();
            buttonModificarJ = new Button();
            buttonEliminarJ = new Button();
            buttonRegresarM = new Button();
            dataGridView1 = new DataGridView();
            buttonEXP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(245, 33);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Jugadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(27, 22);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // textBoxIDjugador
            // 
            textBoxIDjugador.Location = new Point(91, 113);
            textBoxIDjugador.Margin = new Padding(3, 4, 3, 4);
            textBoxIDjugador.Name = "textBoxIDjugador";
            textBoxIDjugador.Size = new Size(266, 27);
            textBoxIDjugador.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // textBoxNombreJugadores
            // 
            textBoxNombreJugadores.Location = new Point(91, 165);
            textBoxNombreJugadores.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreJugadores.Name = "textBoxNombreJugadores";
            textBoxNombreJugadores.Size = new Size(266, 27);
            textBoxNombreJugadores.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 227);
            label4.Name = "label4";
            label4.Size = new Size(47, 22);
            label4.TabIndex = 5;
            label4.Text = "Nivel";
            // 
            // textBoxNivelJugadores
            // 
            textBoxNivelJugadores.Location = new Point(91, 227);
            textBoxNivelJugadores.Margin = new Padding(3, 4, 3, 4);
            textBoxNivelJugadores.Name = "textBoxNivelJugadores";
            textBoxNivelJugadores.Size = new Size(266, 27);
            textBoxNivelJugadores.TabIndex = 6;
            // 
            // buttonAgregarJ
            // 
            buttonAgregarJ.BackColor = SystemColors.ActiveCaption;
            buttonAgregarJ.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregarJ.Location = new Point(27, 318);
            buttonAgregarJ.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarJ.Name = "buttonAgregarJ";
            buttonAgregarJ.Size = new Size(101, 40);
            buttonAgregarJ.TabIndex = 7;
            buttonAgregarJ.Text = "Agregar";
            buttonAgregarJ.UseVisualStyleBackColor = false;
            buttonAgregarJ.Click += buttonAgregarJ_Click;
            // 
            // buttonModificarJ
            // 
            buttonModificarJ.BackColor = SystemColors.ActiveCaption;
            buttonModificarJ.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificarJ.Location = new Point(277, 318);
            buttonModificarJ.Margin = new Padding(3, 4, 3, 4);
            buttonModificarJ.Name = "buttonModificarJ";
            buttonModificarJ.Size = new Size(112, 40);
            buttonModificarJ.TabIndex = 8;
            buttonModificarJ.Text = "Modificar";
            buttonModificarJ.UseVisualStyleBackColor = false;
            buttonModificarJ.Click += buttonModificarJ_Click;
            // 
            // buttonEliminarJ
            // 
            buttonEliminarJ.BackColor = SystemColors.ActiveCaption;
            buttonEliminarJ.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminarJ.Location = new Point(153, 318);
            buttonEliminarJ.Margin = new Padding(3, 4, 3, 4);
            buttonEliminarJ.Name = "buttonEliminarJ";
            buttonEliminarJ.Size = new Size(101, 40);
            buttonEliminarJ.TabIndex = 9;
            buttonEliminarJ.Text = "Eliminar";
            buttonEliminarJ.UseVisualStyleBackColor = false;
            buttonEliminarJ.Click += buttonEliminarJ_Click;
            // 
            // buttonRegresarM
            // 
            buttonRegresarM.BackColor = SystemColors.ActiveCaption;
            buttonRegresarM.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresarM.Location = new Point(425, 298);
            buttonRegresarM.Margin = new Padding(3, 4, 3, 4);
            buttonRegresarM.Name = "buttonRegresarM";
            buttonRegresarM.Size = new Size(141, 69);
            buttonRegresarM.TabIndex = 11;
            buttonRegresarM.Text = "Menú Principal";
            buttonRegresarM.UseVisualStyleBackColor = false;
            buttonRegresarM.Click += buttonRegresarM_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(683, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(519, 412);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonEXP
            // 
            buttonEXP.BackColor = SystemColors.ActiveCaption;
            buttonEXP.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEXP.Location = new Point(121, 416);
            buttonEXP.Name = "buttonEXP";
            buttonEXP.Size = new Size(268, 104);
            buttonEXP.TabIndex = 13;
            buttonEXP.Text = "Transferir Archivos de Jugadores Hacia Excel";
            buttonEXP.UseVisualStyleBackColor = false;
            buttonEXP.Click += buttonEXP_Click;
            // 
            // Form2Jugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1261, 600);
            Controls.Add(buttonEXP);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRegresarM);
            Controls.Add(buttonEliminarJ);
            Controls.Add(buttonModificarJ);
            Controls.Add(buttonAgregarJ);
            Controls.Add(textBoxNivelJugadores);
            Controls.Add(label4);
            Controls.Add(textBoxNombreJugadores);
            Controls.Add(label3);
            Controls.Add(textBoxIDjugador);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2Jugadores";
            Text = "Form2Jugadores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIDjugador;
        private Label label3;
        private TextBox textBoxNombreJugadores;
        private Label label4;
        private TextBox textBoxNivelJugadores;
        private Button buttonAgregarJ;
        private Button buttonModificarJ;
        private Button buttonEliminarJ;
        private Button buttonRegresarM;
        private DataGridView dataGridView1;
        private Button buttonEXP;
    }
}