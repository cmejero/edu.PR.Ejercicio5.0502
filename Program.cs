namespace edu.PR.Ejercicio5._0502Prueba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fecha1;
            Console.WriteLine("introduzca una fecha en formato: dd/MM/YYYY");
            fecha1 = Console.ReadLine();

            string fecha2;
            Console.WriteLine("Introduzca otra fecha con formato: dd/MM/YYYY");
            fecha2 = Console.ReadLine();

            DateTime fechaUsuario1 = Convert.ToDateTime(fecha1);
            Console.WriteLine(fechaUsuario1.ToString());
            DateTime fechaUsuario2 = Convert.ToDateTime(fecha2);
            Console.WriteLine(fechaUsuario2.ToString());

            TimeSpan restaFecha = fechaUsuario1 - fechaUsuario2;
            Console.WriteLine(restaFecha.ToString());

            
            

                double calculoDias = restaFecha.TotalDays;
                Console.WriteLine("dia: " + calculoDias);
            int parteEnteraDias = (int)calculoDias;
            double parteDecimalDias = calculoDias - parteEnteraDias;
            Console.WriteLine("Parte decimal DIAS: " + parteDecimalDias);

                double calculoHoras = parteDecimalDias * 24.0;
                Console.WriteLine("calculo de horas: " + calculoHoras.ToString());
            int parteEnteraHoras = (int)calculoHoras;
            double parteDecimalHoras = calculoHoras - parteEnteraHoras;
            Console.WriteLine("Parte decimas Horas: " + parteDecimalHoras);
            
                
                double calculoMinutos = parteDecimalHoras * 60.0;
                Console.WriteLine("calculo de minutos totales: " + calculoMinutos.ToString());
            int parteEnteraMinutos = (int)calculoMinutos;
            double parteDecimalMinutos = calculoMinutos -   parteEnteraMinutos;
            Console.WriteLine("Parte decimal Minutos: " + parteDecimalMinutos);
               
                double calculoSegundos = parteDecimalMinutos * 60.0;
                Console.WriteLine("calculo de segundos totales: " + calculoSegundos);
            int parteEnteraSegundos = (int)calculoSegundos;
            double parteDecimalSegundos = calculoSegundos - parteEnteraSegundos;
            Console.WriteLine("Parte decimal Segunos: " + parteDecimalSegundos);



                Console.WriteLine("#########################################");
                Console.WriteLine("DIAS: " + parteEnteraDias);
                double horasReales = parteEnteraHoras % 24.0;
                Console.WriteLine("HORAS: " + horasReales);
                double minutosReales = parteEnteraMinutos % 60.0;
                Console.WriteLine("MINUTOS: " +  minutosReales);
                double segundosReales = parteEnteraSegundos % 60.0;
                Console.WriteLine("SEGUNDOS: " +  segundosReales);




            


            
           


            
           


        }
    }
}