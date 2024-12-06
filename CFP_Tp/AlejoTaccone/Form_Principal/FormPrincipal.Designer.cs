namespace Form_Principal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            dgb_Animales = new DataGridView();
            btn_Agregar = new Button();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            btn_Archivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgb_Animales).BeginInit();
            SuspendLayout();
            // 
            // dgb_Animales
            // 
            dgb_Animales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgb_Animales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgb_Animales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_Animales.Location = new Point(125, 73);
            dgb_Animales.Margin = new Padding(4, 5, 4, 5);
            dgb_Animales.Name = "dgb_Animales";
            dgb_Animales.RowHeadersWidth = 62;
            dgb_Animales.Size = new Size(1143, 495);
            dgb_Animales.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.Tan;
            btn_Agregar.Location = new Point(798, 632);
            btn_Agregar.Margin = new Padding(4, 5, 4, 5);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(160, 58);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.Tan;
            btn_Eliminar.Location = new Point(235, 632);
            btn_Eliminar.Margin = new Padding(4, 5, 4, 5);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(161, 58);
            btn_Eliminar.TabIndex = 2;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.Tan;
            btn_Modificar.Location = new Point(420, 632);
            btn_Modificar.Margin = new Padding(4, 5, 4, 5);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(170, 58);
            btn_Modificar.TabIndex = 3;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Archivo
            // 
            btn_Archivo.BackColor = Color.Tan;
            btn_Archivo.Location = new Point(981, 632);
            btn_Archivo.Margin = new Padding(4, 5, 4, 5);
            btn_Archivo.Name = "btn_Archivo";
            btn_Archivo.Size = new Size(170, 58);
            btn_Archivo.TabIndex = 4;
            btn_Archivo.Text = "Guardar Archivo";
            btn_Archivo.UseVisualStyleBackColor = false;
            btn_Archivo.Click += btn_Archivo_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 750);
            Controls.Add(btn_Archivo);
            Controls.Add(btn_Modificar);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_Eliminar);
            Controls.Add(dgb_Animales);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "Gestion de Animales";
            Load += Form_Principal_Load;
            ((System.ComponentModel.ISupportInitialize)dgb_Animales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgb_Animales;
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Button btn_Archivo;
    }
}
