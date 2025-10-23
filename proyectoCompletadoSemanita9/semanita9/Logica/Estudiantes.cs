using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Estudiantes : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;

        public Estudiantes()
        {
        }

        public Estudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            image = (PictureBox)objetos[0];
        }

        //CREAR METODO REGISTRAR
        public void Resgistrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "Campo nombre vacío";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();

            }else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "Campo apellido vacío";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();

                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "Campo Nid vacío";
                        listLabel[2].ForeColor = Color.Red;
                        listTextBox[2].Focus();

                    }
                    else
                    {

                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "Campo Email vacío";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();

                        }
                        else
                        {
                            if (textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                            {
                                uploadimage.ImageToByte(image.Image);
                            }
                            else 
                            {
                                listLabel[3].Text = "correo no valido";
                                listLabel[3].ForeColor = Color.Red;
                                listTextBox[3].Focus();
                            }


                        }
                    }
                }
            }
        }

       
    }
}
