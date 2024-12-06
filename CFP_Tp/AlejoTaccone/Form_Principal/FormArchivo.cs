using _3_Evaluacion_ADO;
using Biblioteca_de_Clases;
using Form_Principal;
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
    public partial class FormArchivo : Form
    {
        private FormPrincipal form1;
        public FormArchivo(FormPrincipal form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void FormArchivo_Load(object sender, EventArgs e)
        {
            cmb_Tipo.DataSource = new List<string>() { "txt", "json", "xml" };
        }
        private void btn_Crear_Click(object sender, EventArgs e)
        {
            bool exito = true;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string nombreFile =  txt_Nombre.Text + "." + cmb_Tipo.SelectedItem!.ToString();
            foreach (Animal animal in form1.MisAnimales)
            {
                if (cmb_Tipo.SelectedItem.ToString() == "txt")
                {
                    try
                    {                      
                        MiClaseSerealizadoraGenerica<Animal>.EscribirTxt(path, nombreFile, animal.Informacion);
                    }
                    catch (Exception ex)
                    {
                        exito = false;
                    }
                }
                else
                {
                    try 
                    {
                        if (animal is Gato)
                        {
                            MiClaseSerealizadoraGenerica<Gato>.EscribirXmlOJson(path, nombreFile, (Gato)animal);
                        }
                        else if (animal is Perro)
                        {
                            MiClaseSerealizadoraGenerica<Perro>.EscribirXmlOJson(path, nombreFile, (Perro)animal);
                        }
                    }
                    catch (Exception ex) 
                    {
                        exito = false;
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (exito)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
