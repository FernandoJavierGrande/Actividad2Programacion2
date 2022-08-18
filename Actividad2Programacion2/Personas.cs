using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2Programacion2
{
    public partial class Personas : Form
    {
        public Personas()
        {

            InitializeComponent();

        }
        Persona persona; 
        private void b_persona_Click(object sender, EventArgs e)
        {
            persona = new Persona();
            bool resp = false;
            DateTime salida;
            cambiarColor(false);
            try
            {
                if (txt_nombre.Text.Equals(""))
                {
                    cambiarColor(false,txt_nombre);
                    throw new Exception("El nombre no puede estar vacio");
                }
                persona.Nombre = txt_nombre.Text.Trim();

                if (txt_dni.Text.Length < 7 || txt_dni.Text.Length > 8)
                {
                    cambiarColor(false, txt_dni);
                    throw new Exception("El largo del Dni es incorrecto");
                }
                else
                    persona.Dni = int.Parse(txt_dni.Text.Trim());
 
                resp = DateTime.TryParse(txt_fechaNac.Text, out salida);
                if (!resp)
                {
                    cambiarColor(false,txt_fechaNac);
                    throw new Exception("La fecha es incorrecta");
                }

                persona.FechaNacimineto = salida;  

                cambiarColor(true);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }

        }

        private void b_Edad_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = persona.EdadDeLaPersona().ToString();
            }
            catch (Exception)
            {
                cambiarColor(false,txt_fechaNac);
                throw new Exception("Ocurrio un error verifique la fecha de nacimiento");
            }
            
        }
        public void cambiarColor(bool booleano)
        {
            Color color;

            if (booleano == true)
            {
                color = Color.LightGreen;
                b_Edad.Enabled = true;
            }
            else
            {
                color = Color.White;
            }

            txt_dni.BackColor = color;  
            txt_fechaNac.BackColor = color;
            txt_nombre.BackColor = color;   

        }
        public void cambiarColor(bool booleano, TextBox txt)
        {
            Color color;

            if (booleano == true)
            {
                color = Color.LightGreen;
                b_Edad.Enabled = true;
            }
            else
            {
                color = Color.OrangeRed;
                b_Edad.Enabled = false;
            }

            txt.BackColor = color;

        }
    }
}
