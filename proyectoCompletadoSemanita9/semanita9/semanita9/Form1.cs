using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanita9
{
    public partial class Form1 : Form
    {

        private Estudiantes estudiante = new Estudiantes();

        public Form1()
        {
            InitializeComponent();
            //LISTA DE COLECCION DE DATOS
            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNombres);
            listTextBox.Add(textBoxApellidos);
            listTextBox.Add(textBoxNid);
            listTextBox.Add(textBoxCorreo);
            //LISTA LABEL
            var listLabel = new List<Label>();
            listLabel.Add(labelNombres);
            listLabel.Add(labelApellidos);
            listLabel.Add(labelNid);
            listLabel.Add(labelCorreo);

            Object[] objetos = { pictureBoxImage, listLabel };

            estudiante = new Estudiantes(listTextBox, listLabel,objetos);




        }


        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadimage.CargarImagen(pictureBoxImage);

        }

        private void textBoxNombres_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombres.Text.Equals(""))
            {
                labelNombres.ForeColor = Color.LightSlateGray;
            }else
            {
                labelNombres.ForeColor= Color.Green;
                labelNombres.Text = "Nombre";
            }
        }

        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text.Equals(""))
            {
                labelApellidos.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellidos.ForeColor = Color.Green;
                labelApellidos.Text = "Apellido";
            }
        }

        private void textBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBoxNid_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text = "Nid";
            }

        }

        private void textBoxNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

            if (textBoxCorreo.Text.Equals(""))
            {
                labelCorreo.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCorreo.ForeColor = Color.Green;
                labelCorreo.Text = "Correo";
            }

        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Resgistrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void labelCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
