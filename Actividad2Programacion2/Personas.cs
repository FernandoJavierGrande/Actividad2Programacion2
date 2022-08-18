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

            try
            {
                persona.Nombre = txt_nombre.Text.Trim();

                persona.FechaNacimineto = DateTime.Parse(txt_fechaNac.Text.Trim());

                persona.Dni = int.Parse(txt_dni.Text.Trim());

                //Console.WriteLine(persona.FechaNacimineto.ToString());

                cambiarColor(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                cambiarColor(false);
                MessageBox.Show("Error en los datos a cargar");
                
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

                throw new Exception("Ocurrio un error verifique las fechas");
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
                color = Color.OrangeRed;
                b_Edad.Enabled = false;
            }

            txt_dni.BackColor = color;  
            txt_fechaNac.BackColor = color;
            txt_nombre.BackColor = color;   

        }
    }
}
