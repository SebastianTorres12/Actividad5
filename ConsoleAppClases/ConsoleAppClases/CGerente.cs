using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases
{
    //Herencia de la clase CEmpleado y la interfaz IMostrarInformacion
    internal class CGerente : CEmpleado, IMostrarInformacion
    {
        //Atributo extra de la clase CGerente
        private string departamento;

        //Acceso a los atributos desde fuera de la clase
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        //Constructor de la clase
        public CGerente(string nombre, string departamento)
            : base(nombre)
        {
            Departamento = departamento;
        }

        //Métodos
        //Sobrecarga del método calcularSalarioAnual
        public void calcularSalarioAnual(double salarioG, double bono) 
        {
            double salarioA = salarioG * 12 + (bono*1.1);
            //Redondear a 2 decimales
            Salario = Math.Round(salarioA, 2);
        }

        //Implementación de método de la interfaz
        public void mostrarInformacionGeneral()
        {
            Console.WriteLine($"Nombre: {Nombre}\nSalario Anual: {Salario}\nDepartamento: {Departamento}\n\n");
        }
    }
}
