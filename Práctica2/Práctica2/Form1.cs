using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // botón que cierra la aplicación
        private void btnsalir_Click(object sender, EventArgs e)
        {
            var tituloCuadro = "Confirmación de salida";
            var mensajeCuadro = "¿Desea cerrar la aplicación?";

            // cuadro Aceptar - Cancelar
            var result = MessageBox.Show(mensajeCuadro, tituloCuadro, MessageBoxButtons.OKCancel);
          
            if(result == DialogResult.OK)
            {
                Close();
            }
            
        }


        private void btnsobre_Click(object sender, EventArgs e)
        {
            frmsobre fmsobreautor = new frmsobre();
            fmsobreautor.ShowDialog();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text == "") || (txtdireccion.Text == "") || (cbciudad.Text == ""))
            {
                MessageBox.Show("Ha de rellenar el formulario.");
            }
            else
            {
                MessageBox.Show("Los datos se han rellenado correctamente.");
            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = null;
            txtdireccion.Text = null;
            cbciudad.Text = null;
            picfoto.Image = null;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdfoto = new OpenFileDialog();

            // solo se podrán insertar imágenes en estos formatos
            ofdfoto.Filter = "Bitmap|*.bmp|JPEG|*.jpg";

            //Muestra el cuadro de diálogo.
            if (ofdfoto.ShowDialog() == DialogResult.OK)
            {
                //Cargar la imagen. Picfoto es el PictureBox.
                picfoto.Image = Image.FromFile(ofdfoto.FileName);
            }

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si pulsamos enter en este campo pasamos el foto al campo dirección
            if (e.KeyChar == (char)13)
            {
                txtdireccion.Focus();
            }
        }

        private void btnanadir_Click(object sender, EventArgs e)
        {
            if(txtidioma.Text != "")
            {
                clbIdiomas.Items.Add(txtidioma.Text);
                txtidioma.Clear();
            }
            else
            {
                MessageBox.Show("El campo idioma está vacío.");
            }
            
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (clbIdiomas.SelectedItems.Count > 0)
            {
                int x = clbIdiomas.SelectedIndex;
                int indice = x + 1;
                clbIdiomas.Items.RemoveAt(x);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún idioma para borrar.");
            }

        }

        private void btnborrarlista_Click(object sender, EventArgs e)
        {
            clbIdiomas.Items.Clear();
        }
    }
}
