using _3_Evaluacion_ADO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Animales
{
    public partial class FormModificar : Form
    {
        public Animal animalModificado;

        public Animal AnimalModificado
        {
            set { animalModificado = value; }
            get { return animalModificado; }
        }

        public FormModificar()
        {
            InitializeComponent();
        }

        public FormModificar(Animal animal) : this()
        {
            this.animalModificado = animal;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {

            cmb_Tipo.DataSource = new List<string>() { "Perro", "Gato" };           

            
            txt_Nombre.Text = this.animalModificado.Nombre;
            numeric_Edad.Value = this.animalModificado.Edad;


            if (this.animalModificado is Perro)
            {
                Perro perro = (Perro)this.animalModificado;
                txt_Rol.Text = perro.Rol;
                txt_Tamanio.Text= perro.Tamanio;
                cmb_Tipo.SelectedItem = "Perro";
            }

            if (this.animalModificado is Gato)
            {
                Gato gato = (Gato)this.animalModificado;
                txt_Raza.Text = gato.ColorDePelo;
                txt_Color.Text = gato.Raza;
                cmb_Tipo.SelectedItem = "Gato";
            }

            foreach (CheckBox cb in grp_Vacunas.Controls)
            {
                cb.Checked = false;

                if (this.animalModificado.Vacunas.Contains(cb.Text))
                {
                    cb.Checked = true;
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmb_Tipo.SelectedItem!.ToString() == "Perro")
            {
                gp_Perro.Enabled = true;
                gp_Gato.Enabled = false;
            }
            else if (cmb_Tipo.SelectedItem.ToString() == "Gato")
            {
                gp_Perro.Enabled = false;
                gp_Gato.Enabled = true;
            }


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int id = animalModificado.Id;
            string nombre = this.txt_Nombre.Text;
            int edad = (int)this.numeric_Edad.Value;
            bool listaConValores = false;
            bool control = false;

            if (cmb_Tipo.SelectedItem!.ToString() == "Perro")
            {
                string rol = txt_Rol.Text;
                string tamanio = txt_Tamanio.Text;

                this.animalModificado = new Perro(nombre, edad, rol, tamanio);
                foreach (CheckBox item in grp_Vacunas.Controls)
                {
                    if (item.Checked)
                    {
                        this.animalModificado.Vacunas = item.Text;
                        listaConValores = true;
                    }
                }
                if (!string.IsNullOrEmpty(nombre) &&
                !string.IsNullOrEmpty(rol) && !string.IsNullOrEmpty(tamanio) && listaConValores)
                {
                    control = true;
                }
            }
            else if (cmb_Tipo.SelectedItem!.ToString() == "Gato")
            {
                string color = txt_Color.Text;
                string raza = txt_Raza.Text;

                this.animalModificado = new Gato(nombre, edad, raza, color);
                foreach (CheckBox item in grp_Vacunas.Controls)
                {
                    if (item.Checked)
                    {
                        this.animalModificado.Vacunas = item.Text;
                        listaConValores = true;
                    }
                }

                if (!string.IsNullOrEmpty(nombre) &&
                !string.IsNullOrEmpty(color) && !string.IsNullOrEmpty(raza) && listaConValores)
                {
                    control = true;
                }
            }

            if (control)
            {
                animalModificado.Id = id;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un elemento de cada categoria", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
