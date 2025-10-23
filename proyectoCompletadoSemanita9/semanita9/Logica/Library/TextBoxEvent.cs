using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class TextBoxEvent
    {

        public void textKeyPress(KeyPressEventArgs e)
        {
            //CONDICION QUE NOS PERMITA INGRESAR SOLO TEXTO
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }

            //CONDICION QUE NO PERMITA DAR SALTOS DE LINEA
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //CONDICION QUE NOS PERMITA USAR BACKSPACE
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //CONDICION QUE NOS PERMITA UTILIZAR TECLA DE ESPACIO
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)){ e.Handled = false; }

            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
                        
            //CONDICION QUE NO PERMITA DAR SALTOS DE LINEA
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //CONDICION QUE NOS PERMITA USAR BACKSPACE
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //CONDICION QUE NOS PERMITA UTILIZAR TECLA DE ESPACIO
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        public bool comprobarFormatoEmail(string email)
        { 
          return new EmailAddressAttribute().IsValid(email);

        }










    }
}
