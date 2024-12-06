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

namespace Form_Animales
{
    public partial class FormAlta : Form
    {

        public Animal nuevoAnimal;
        public Animal NuevoAnimal { get => nuevoAnimal; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            cmb_Tipo.DataSource = new List<string>() { "Perro", "Gato" };
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

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            int edad = (int)numeric_Edad.Value;
            

            bool listaConValores = false;
            bool control = false;
            if (cmb_Tipo.SelectedItem!.ToString() == "Perro")
            {
                string rol = txt_Rol.Text;
                string tamanio = txt_Tamanio.Text;

                this.nuevoAnimal = new Perro(nombre, edad, rol, tamanio);

                foreach (CheckBox item in grp_Vacunas.Controls)
                {
                    if (item.Checked)
                    {
                        this.nuevoAnimal.Vacunas =item.Text;
                        listaConValores = true;
                        
                    }
                }              
                if (!string.IsNullOrEmpty(nombre)  &&
                !string.IsNullOrEmpty(rol) && !string.IsNullOrEmpty(tamanio) && listaConValores)
                {
                    control = true;
                }

            }
            else if (cmb_Tipo.SelectedItem!.ToString() == "Gato")
            {
                string raza = txt_Raza.Text;
                string color = txt_Color.Text;

                this.nuevoAnimal = new Gato(nombre, edad, raza, color);
                


                foreach (CheckBox item in grp_Vacunas.Controls)
                {
                    if (item.Checked)
                    {
                        this.nuevoAnimal.Vacunas = item.Text;
                        listaConValores = true;
                    }
                }

                if (!string.IsNullOrEmpty(nombre) &&
                !string.IsNullOrEmpty(raza) && !string.IsNullOrEmpty(color) && listaConValores)
                {
                    control = true;
                }
            }

            if (control)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un elemento de cada categoria", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
