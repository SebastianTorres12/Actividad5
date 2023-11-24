using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases
{   
    //Herencia de la interfaz
    internal class CEmpleado : IMostrarInformacion
    {
        //Atributos
        private string nombre;
        private double salario;


        //Acceso a los atributos desde fuera de la clase
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        //Constructor de la clase
        public CEmpleado(string nombre)
        {
            Nombre = nombre;
            Salario = 0.0;
        }

        //Métodos
        public void calcularSalarioAnual(double salarioE)
        {
            //Redondear a 2 decimales
            Salario = Math.Round(salarioE*12,2);
        }

        //Implementación de método de la interfaz
        public void mostrarInformacionGeneral()
        {
            Console.WriteLine($"Nombre: {Nombre}\nSalario Anual: {Salario}\n\n");
        }

    }
}
