namespace Form_Animales
{
    partial class FormAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlta));
            txt_Nombre = new TextBox();
            label1 = new Label();
            cmb_Tipo = new ComboBox();
            grp_Vacunas = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_Crear = new Button();
            btn_Cancelar = new Button();
            txt_Tamanio = new TextBox();
            txt_Rol = new TextBox();
            gp_Perro = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            gp_Gato = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            txt_Raza = new TextBox();
            txt_Color = new TextBox();
            label7 = new Label();
            numeric_Edad = new NumericUpDown();
            label2 = new Label();
            label8 = new Label();
            grp_Vacunas.SuspendLayout();
            gp_Perro.SuspendLayout();
            gp_Gato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Edad).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = SystemColors.InactiveCaption;
            txt_Nombre.Location = new Point(217, 147);
            txt_Nombre.Margin = new Padding(4, 5, 4, 5);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(293, 31);
            txt_Nombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(60, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 1;
            label1.Text = "Elegir Tipo:";
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.BackColor = SystemColors.InactiveCaption;
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Location = new Point(217, 38);
            cmb_Tipo.Margin = new Padding(4, 5, 4, 5);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(293, 33);
            cmb_Tipo.TabIndex = 2;
            cmb_Tipo.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // grp_Vacunas
            // 
            grp_Vacunas.BackColor = SystemColors.InactiveCaption;
            grp_Vacunas.Controls.Add(checkBox6);
            grp_Vacunas.Controls.Add(checkBox5);
            grp_Vacunas.Controls.Add(checkBox4);
            grp_Vacunas.Controls.Add(checkBox3);
            grp_Vacunas.Controls.Add(checkBox2);
            grp_Vacunas.Controls.Add(checkBox1);
            grp_Vacunas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_Vacunas.ForeColor = Color.Black;
            grp_Vacunas.Location = new Point(693, 38);
            grp_Vacunas.Margin = new Padding(4, 3, 4, 3);
            grp_Vacunas.Name = "grp_Vacunas";
            grp_Vacunas.Padding = new Padding(4, 3, 4, 3);
            grp_Vacunas.Size = new Size(669, 277);
            grp_Vacunas.TabIndex = 6;
            grp_Vacunas.TabStop = false;
            grp_Vacunas.Text = "Vacunas";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Transparent;
            checkBox6.Location = new Point(59, 192);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(237, 29);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Bordetella bronchiseptica";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Transparent;
            checkBox5.Location = new Point(353, 192);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(143, 29);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Leptospirosis";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Transparent;
            checkBox4.Location = new Point(59, 127);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(176, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Parvovirus canino";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Location = new Point(353, 127);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Rabia";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Location = new Point(59, 68);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(171, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Moquillo canino ";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(353, 68);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(245, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Hepatitis infecciosa canina";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.Tan;
            btn_Crear.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Crear.Location = new Point(741, 650);
            btn_Crear.Margin = new Padding(4, 3, 4, 3);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(227, 65);
            btn_Crear.TabIndex = 7;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Tan;
            btn_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Cancelar.Location = new Point(381, 650);
            btn_Cancelar.Margin = new Padding(4, 3, 4, 3);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(227, 65);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // txt_Tamanio
            // 
            txt_Tamanio.BackColor = SystemColors.InactiveCaption;
            txt_Tamanio.Location = new Point(171, 130);
            txt_Tamanio.Margin = new Padding(4, 5, 4, 5);
            txt_Tamanio.Name = "txt_Tamanio";
            txt_Tamanio.Size = new Size(293, 31);
            txt_Tamanio.TabIndex = 10;
            // 
            // txt_Rol
            // 
            txt_Rol.BackColor = SystemColors.InactiveCaption;
            txt_Rol.Location = new Point(171, 37);
            txt_Rol.Margin = new Padding(4, 5, 4, 5);
            txt_Rol.Name = "txt_Rol";
            txt_Rol.Size = new Size(293, 31);
            txt_Rol.TabIndex = 9;
            // 
            // gp_Perro
            // 
            gp_Perro.BackColor = Color.Transparent;
            gp_Perro.Controls.Add(label4);
            gp_Perro.Controls.Add(label3);
            gp_Perro.Controls.Add(txt_Rol);
            gp_Perro.Controls.Add(txt_Tamanio);
            gp_Perro.Location = new Point(54, 372);
            gp_Perro.Margin = new Padding(4, 5, 4, 5);
            gp_Perro.Name = "gp_Perro";
            gp_Perro.Padding = new Padding(4, 5, 4, 5);
            gp_Perro.Size = new Size(554, 207);
            gp_Perro.TabIndex = 10;
            gp_Perro.TabStop = false;
            gp_Perro.Text = "groupBox1";
            // 
            // label4
            // 
            label4.BackColor = Color.Tan;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(0, 130);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 32);
            label4.TabIndex = 16;
            label4.Text = "Tamaño:";
            // 
            // label3
            // 
            label3.BackColor = Color.Tan;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(0, 37);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 16;
            label3.Text = "Rol:";
            // 
            // gp_Gato
            // 
            gp_Gato.BackColor = Color.Transparent;
            gp_Gato.Controls.Add(label6);
            gp_Gato.Controls.Add(label5);
            gp_Gato.Controls.Add(txt_Raza);
            gp_Gato.Controls.Add(txt_Color);
            gp_Gato.Controls.Add(label7);
            gp_Gato.Location = new Point(682, 372);
            gp_Gato.Margin = new Padding(4, 5, 4, 5);
            gp_Gato.Name = "gp_Gato";
            gp_Gato.Padding = new Padding(4, 5, 4, 5);
            gp_Gato.Size = new Size(680, 207);
            gp_Gato.TabIndex = 13;
            gp_Gato.TabStop = false;
            gp_Gato.Text = "groupBox2";
            // 
            // label6
            // 
            label6.BackColor = Color.Tan;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.InfoText;
            label6.Location = new Point(11, 135);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 32);
            label6.TabIndex = 17;
            label6.Text = "Color:";
            // 
            // label5
            // 
            label5.BackColor = Color.Tan;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(11, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 17;
            label5.Text = "Raza:";
            // 
            // txt_Raza
            // 
            txt_Raza.BackColor = SystemColors.InactiveCaption;
            txt_Raza.Location = new Point(182, 45);
            txt_Raza.Margin = new Padding(4, 5, 4, 5);
            txt_Raza.Name = "txt_Raza";
            txt_Raza.Size = new Size(293, 31);
            txt_Raza.TabIndex = 9;
            // 
            // txt_Color
            // 
            txt_Color.BackColor = SystemColors.InactiveCaption;
            txt_Color.Location = new Point(182, 138);
            txt_Color.Margin = new Padding(4, 5, 4, 5);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(293, 31);
            txt_Color.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 133);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 12;
            // 
            // numeric_Edad
            // 
            numeric_Edad.BackColor = SystemColors.InactiveCaption;
            numeric_Edad.Location = new Point(217, 257);
            numeric_Edad.Margin = new Padding(4, 5, 4, 5);
            numeric_Edad.Name = "numeric_Edad";
            numeric_Edad.Size = new Size(294, 31);
            numeric_Edad.TabIndex = 13;
            // 
            // label2
            // 
            label2.BackColor = Color.Tan;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(54, 257);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 14;
            label2.Text = "Edad:";
            // 
            // label8
            // 
            label8.BackColor = Color.Tan;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.InfoText;
            label8.Location = new Point(54, 147);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 32);
            label8.TabIndex = 15;
            label8.Text = "Nombre:";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1436, 775);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(numeric_Edad);
            Controls.Add(gp_Gato);
            Controls.Add(gp_Perro);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Crear);
            Controls.Add(grp_Vacunas);
            Controls.Add(cmb_Tipo);
            Controls.Add(label1);
            Controls.Add(txt_Nombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAlta";
            Text = "Cargar Animal";
            Load += FormAlta_Load;
            grp_Vacunas.ResumeLayout(false);
            grp_Vacunas.PerformLayout();
            gp_Perro.ResumeLayout(false);
            gp_Perro.PerformLayout();
            gp_Gato.ResumeLayout(false);
            gp_Gato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Edad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private Label label1;
        private ComboBox cmb_Tipo;
        private GroupBox grp_Vacunas;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_Crear;
        private Button btn_Cancelar;
        private TextBox txt_Tamanio;
        private TextBox txt_Rol;
        private GroupBox gp_Perro;
        private GroupBox gp_Gato;
        private TextBox txt_Raza;
        private TextBox txt_Color;
        private Label label7;
        private NumericUpDown numeric_Edad;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label8;
    }
}