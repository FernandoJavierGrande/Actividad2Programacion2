using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2Programacion2
{
    public class Persona
    {


        #region Propiedades

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimineto { get => fechaNacimiento; set => fechaNacimiento = value; }
        #endregion

        #region atributos

        private int dni;

        private string nombre;

        private DateTime fechaNacimiento;

        #endregion

        #region Const
        public Persona()
        {
            
        }
        public Persona(int dni, string nombre, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.fechaNacimiento=fechaNacimiento;
        }
        #endregion

        #region Metodos
        public int EdadDeLaPersona()
        {
            int edad = 0;
            try
            {
                if (fechaNacimiento.Date > DateTime.Today)
                    throw new Exception("La fecha es incorrecta");

                else
                { 
                    edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year-1;
                    return edad;
                }
            }
            catch (Exception )
            {

                return -1;
                
            }
            
        }
        #endregion
    }
}
