using _3_Evaluacion_ADO;
using Biblioteca_de_Clases;
using Form_Animales;
using Google.Protobuf.WellKnownTypes;
using System.IO;
using System.Windows.Forms;

namespace Form_Principal
{
    public partial class FormPrincipal : Form
    {
        private List<Animal> misAnimales;
        public List<Animal> MisAnimales { get => misAnimales; }


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                if (Clase_ADO.GuardarUno(formAlta.NuevoAnimal))
                {
                    MessageBox.Show("Animal guardado con exito ");
                    misAnimales.Add(formAlta.nuevoAnimal);
                }
                else
                {
                    MessageBox.Show("El animal no se guardo");
                }
                ActualizarLista();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Animal aEliminar = dgb_Animales.CurrentRow.DataBoundItem as Animal;

            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar el Personaje {aEliminar.Nombre}?\n" +
                $"ESTA ACCION ES IRREVERSIBLE", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (Clase_ADO.EliminarPorId(aEliminar.Id))
            {
                MessageBox.Show("Animal Eliminado");
                ActualizarLista();

            }
            else
            {
                MessageBox.Show("Animal No Eliminado");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {


            Animal aModificar = dgb_Animales.CurrentRow.DataBoundItem as Animal;
            FormModificar formModificar = new FormModificar(aModificar);

            formModificar.ShowDialog();

            if (formModificar.DialogResult == DialogResult.OK)
            {
                int index = -1;

                foreach (Animal item in misAnimales)
                {
                    if (item.Id == formModificar.animalModificado.Id)
                    {
                        index = misAnimales.IndexOf(item);
                        break;
                    }
                }

                if (index != -1)
                {
                    if ((Clase_ADO.Actualizar(formModificar.animalModificado)))
                    {
                        MessageBox.Show("Animal Modificado");
                    }
                    else
                    {
                        MessageBox.Show("Animal No Modificado");
                    }
                }
                ActualizarLista();
            }
        }

        private void ActualizarLista()
        {
            this.misAnimales = Clase_ADO.LeerTodos();
            dgb_Animales.DataSource = null;
            dgb_Animales.DataSource = misAnimales;
        }
        private void btn_Archivo_Click(object sender, EventArgs e)
        {
            FormArchivo formArchivo = new FormArchivo(this);
            formArchivo.ShowDialog();

            if (formArchivo.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Archivo guardado con exito!");

            }
            else
            {
                MessageBox.Show("El archivo no fue guardado");
            }
        }
    }
}
