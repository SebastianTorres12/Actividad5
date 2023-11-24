using ConsoleAppClases;

class Program
{
    static void Main()
    {
        //Creación de objeto Empleado
        CEmpleado empleado = new CEmpleado("Luis Chacón");
        //Cálculo del salario anual para empleado
        empleado.calcularSalarioAnual(425.3);
        //Mostrar información de empleado
        empleado.mostrarInformacionGeneral();

        //Creación objeto Gerente
        CGerente gerente = new CGerente("Sebastián Vega", "Ventas");
        //Cálculo del salario anual para gerente
        gerente.calcularSalarioAnual(520.4,20);
        //Mostrar información del gerente
        gerente.mostrarInformacionGeneral();
    }
}