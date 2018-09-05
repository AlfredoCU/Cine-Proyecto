using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Capa_de_Negocio
{
    class Validar
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar)) //Va a capturar si es número o no. para letras es: IsLetter
                {
                    e.Handled = false; //Esto sera que si se escriba.
                }
                else if (Char.IsControl(e.KeyChar)) //Para borrar. IsSeparator es para validar espacios.
                {
                    e.Handled = false; //Que se puede borrar si es necesario.
                }
                else
                {
                    e.Handled = true; //No se escriba si no es un núnero.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de validación: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de validación: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
