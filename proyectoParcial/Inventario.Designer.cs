namespace proyectoParcial
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            label1 = new Label();
            buttonRegresarMI = new Button();
            label2 = new Label();
            comboBoxINV = new ComboBox();
            dataGridViewINV = new DataGridView();
            buttonexportarinvt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewINV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(245, 34);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Inventario";
            // 
            // buttonRegresarMI
            // 
            buttonRegresarMI.BackColor = SystemColors.ActiveCaption;
            buttonRegresarMI.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresarMI.Location = new Point(149, 373);
            buttonRegresarMI.Margin = new Padding(3, 4, 3, 4);
            buttonRegresarMI.Name = "buttonRegresarMI";
            buttonRegresarMI.Size = new Size(163, 66);
            buttonRegresarMI.TabIndex = 1;
            buttonRegresarMI.Text = "Menú Principal";
            buttonRegresarMI.UseVisualStyleBackColor = false;
            buttonRegresarMI.Click += buttonRegresarMI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 149);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 2;
            label2.Text = "Buscar Tipo/Rareza";
            // 
            // comboBoxINV
            // 
            comboBoxINV.FormattingEnabled = true;
            comboBoxINV.Location = new Point(149, 217);
            comboBoxINV.Name = "comboBoxINV";
            comboBoxINV.Size = new Size(151, 28);
            comboBoxINV.TabIndex = 3;
            // 
            // dataGridViewINV
            // 
            dataGridViewINV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewINV.Location = new Point(612, 47);
            dataGridViewINV.Name = "dataGridViewINV";
            dataGridViewINV.RowHeadersWidth = 51;
            dataGridViewINV.Size = new Size(545, 433);
            dataGridViewINV.TabIndex = 4;
            // 
            // buttonexportarinvt
            // 
            buttonexportarinvt.BackColor = SystemColors.ActiveCaption;
            buttonexportarinvt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonexportarinvt.Location = new Point(201, 472);
            buttonexportarinvt.Name = "buttonexportarinvt";
            buttonexportarinvt.Size = new Size(303, 68);
            buttonexportarinvt.TabIndex = 5;
            buttonexportarinvt.Text = "Exportar Datos del inventario hacia Excel";
            buttonexportarinvt.UseVisualStyleBackColor = false;
            buttonexportarinvt.Click += buttonexportarinvt_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1203, 600);
            Controls.Add(buttonexportarinvt);
            Controls.Add(dataGridViewINV);
            Controls.Add(comboBoxINV);
            Controls.Add(label2);
            Controls.Add(buttonRegresarMI);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dataGridViewINV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonRegresarMI;
        private Label label2;
        private ComboBox comboBoxINV;
        private DataGridView dataGridViewINV;
        private Button buttonexportarinvt;
    }
}