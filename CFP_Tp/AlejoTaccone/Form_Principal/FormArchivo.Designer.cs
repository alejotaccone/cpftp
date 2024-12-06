namespace Form_Animales
{
    partial class FormArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchivo));
            cmb_Tipo = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            txt_Nombre = new TextBox();
            btn_Cancelar = new Button();
            btn_Crear = new Button();
            SuspendLayout();
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.BackColor = SystemColors.InactiveCaption;
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Location = new Point(380, 99);
            cmb_Tipo.Margin = new Padding(4, 5, 4, 5);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(293, 33);
            cmb_Tipo.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(211, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 3;
            label1.Text = "Elegir Tipo:";
            // 
            // label8
            // 
            label8.BackColor = Color.Tan;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.InfoText;
            label8.Location = new Point(217, 173);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 32);
            label8.TabIndex = 17;
            label8.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = SystemColors.InactiveCaption;
            txt_Nombre.Location = new Point(380, 173);
            txt_Nombre.Margin = new Padding(4, 5, 4, 5);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(293, 31);
            txt_Nombre.TabIndex = 16;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Tan;
            btn_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Cancelar.Location = new Point(163, 310);
            btn_Cancelar.Margin = new Padding(4, 3, 4, 3);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(227, 65);
            btn_Cancelar.TabIndex = 19;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.Tan;
            btn_Crear.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Crear.Location = new Point(523, 310);
            btn_Crear.Margin = new Padding(4, 3, 4, 3);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(227, 65);
            btn_Crear.TabIndex = 18;
            btn_Crear.Text = "Guardar";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // FormArchivo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 450);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Crear);
            Controls.Add(label8);
            Controls.Add(txt_Nombre);
            Controls.Add(cmb_Tipo);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormArchivo";
            Text = "Guardar Archivo";
            Load += FormArchivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Tipo;
        private Label label1;
        private Label label8;
        private TextBox txt_Nombre;
        private Button btn_Cancelar;
        private Button btn_Crear;
    }
}