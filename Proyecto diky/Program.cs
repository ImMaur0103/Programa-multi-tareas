using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_diky
{
    class Program
    {
        static void Main(string[] args)
        {
            void Añocalculo (ref int dias, int dia ,int Meses, bool bisiesto)
            {
                if(bisiesto)
                {
                switch (Meses)
                {
                    case 1:
                        dias = 366 - dia;
                        break;
                    case 2:
                        dias = 366 - 31 - dia;
                        break;
                    case 3:
                        dias = 366 - 60 - dia;
                        break;
                    case 4:
                        dias = 366 - 91 - dia;
                        break;
                    case 5:
                        dias = 366 - 121 - dia;
                        break;
                    case 6:
                        dias = 366 - 152 - dia;
                        break;
                    case 7:
                        dias = 366 - 182 - dia;
                        break;
                    case 8:
                        dias = 366 - 213 - dia;
                        break;
                    case 9:
                        dias = 366 - 244 - dia;
                        break;
                    case 10:
                        dias = 366 - 274 - dia;
                        break;
                    case 11:
                        dias = 366 - 305 - dia;
                        break;
                    case 12:
                        dias = 366 - 335 - dia;
                        break;
                }
                }
                else if(!bisiesto)
                {
                    switch (Meses)
                    {
                        case 1:
                            dias = 365 - dia;
                            break;
                        case 2:
                            dias = 365 - 31 - dia;
                            break;
                        case 3:
                            dias = 365 - 59 - dia;
                            break;
                        case 4:
                            dias = 365 - 90 - dia;
                            break;
                        case 5:
                            dias = 365 - 120 - dia;
                            break;
                        case 6:
                            dias = 365 - 151 - dia;
                            break;
                        case 7:
                            dias = 365 - 181 - dia;
                            break;
                        case 8:
                            dias = 365 - 212 - dia;
                            break;
                        case 9:
                            dias = 365 - 243 - dia;
                            break;
                        case 10:
                            dias = 365 - 273 - dia;
                            break;
                        case 11:
                            dias = 365 - 304 - dia;
                            break;
                        case 12:
                            dias = 365 - 334 - dia;
                            break;
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string Nombre = null;
            string Correo = null;
            string Domicilio = null;
            string NombreS = null;
            string CorreoS = null;
            string DomicilioS = null;
            bool menu = false;
            bool salir = false;
            int opc1 = 0, opc2 = 0, opc3 = 0, opc4 = 0, opc5 = 0, opc6 = 0;
            do
            {
                if ((Nombre == "") || (Correo == "") || (Domicilio == ""))
                {
                    Console.WriteLine("Si desea salir escriba yes: ");
                    string res = Console.ReadLine();
                    if((res == "yes") || (res == "y"))
                    {
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Bienvenidos a MASTERMIND");
                if (salir)
                {
                    Console.WriteLine("Si desea salir escriba yes: ");
                    string op1 = Console.ReadLine();
                    if (op1 == "Yes" || op1 == "Y" || op1 == "Si" || op1 == "si" || op1 == "yes" || op1 == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("Gracias Por usar MASTERMIND\n" + NombreS + " usted ingreso: ");
                        if (opc1 > 1 || opc1 == 0)
                        {
                            Console.WriteLine(opc1 + " veces a la opcion 1.");
                        }
                        else
                        {
                            Console.WriteLine(opc1 + " vez a la opcion 1.");
                        }
                        if (opc2 > 1 || opc2 == 0)
                        {
                            Console.WriteLine(opc2 + " veces a la opcion 2.");
                        }
                        else
                        {
                            Console.WriteLine(opc2 + " vez a la opcion 2.");
                        }
                        if (opc3 > 1 || opc3 == 0)
                        {
                            Console.WriteLine(opc3 + " veces a la opcion 3.");
                        }
                        else
                        {
                            Console.WriteLine(opc3 + " vez a la opcion 3.");
                        }
                        if (opc4 > 1 || opc4 == 0)
                        {
                            Console.WriteLine(opc4 + " veces a la opcion 4.");
                        }
                        else
                        {
                            Console.WriteLine(opc4 + " vez a la opcion 4.");
                        }
                        if (opc5 > 1 || opc5 == 0)
                        {
                            Console.WriteLine(opc5 + " veces a la opcion 5.");
                        }
                        else
                        {
                            Console.WriteLine(opc5 + " vez a la opcion 5.");
                        }
                        if (opc6 > 1 || opc6 == 0)
                        {
                            Console.WriteLine(opc6 + " veces a la opcion 6.");
                        }
                        else
                        {
                            Console.WriteLine(opc6 + " vez a la opcion 6.");
                        }
                        Console.WriteLine("Su correo es " + CorreoS);
                        Console.ReadKey();
                        break;
                    }
                }
                Console.Write("Ingrese su nombre: ");

                Nombre = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese su correo: ");
                Correo = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese su lugar de domicilio: ");
                Domicilio = Console.ReadLine();
                Console.WriteLine();

                menu = !((Nombre == null) || (Correo == null) || (Domicilio == null) || (Nombre == "") || (Correo == "") || (Domicilio == ""));
                while (menu)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string op = "";
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("1)Cálculo Salarial \n2)Adultos y niños dentro de la funcion teatral");
                    Console.WriteLine("3)Validacion del departamento y municipio(DPI) \n4)Cálculo de interés");
                    Console.WriteLine("5)Días de existencia \n6)Cálculo de masa corporal");
                    Console.WriteLine("7)Salír");
                    op = Console.ReadLine();
                    if (op == "1")
                    {
                        opc1++;
                        Console.Clear();
                        Console.WriteLine("Ingrese el !Numero! de dias completos");
                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el !Numero! de dias de medio tiempo");
                        int y = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("La jornada de trabajo normalmente es de 8 horas y el pago por hora es de Q40.00");
                        Console.WriteLine("\nEl total de quetzales por dias completos es de: " + (x * 8 * 40) + "\nEl total de Quetzales por medio tiempo es de: " + (y * 4 * 40));
                        Console.WriteLine("El total de Quetzales a pagar es: ");
                        int resultado = (40 * 8 * x) + (40 * 4 * y);
                        Console.WriteLine("Q" + resultado);
                        Console.ReadKey();
                    }
                    if (op == "2")
                    {
                        opc2++;
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero total de espectadores: ");
                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el total recaudado: ");
                        int y = Convert.ToInt32(Console.ReadLine());

                        int AsistieronNiños = (x * 5 - y) / (5 - 2);
                        int AsistieronAdultos = (x * 2 - y) / (2 - 5);

                        if (AsistieronAdultos >= 0 && AsistieronNiños >= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("En un teatro las entradas de adultos costaban Q5.00 y la de niños Q2.00\nDonde asistieron " + x + " espectadores y se recaudaron Q" + y);
                            Console.ReadKey();
                            Console.WriteLine("\nEl total de niños que asistieron fue de " + AsistieronNiños + ".\nEl total de adultos fue de " + AsistieronAdultos);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("no ingreso datos correctos");
                            Console.ReadKey();
                        }
                    }
                    if (op == "3")
                    {
                        opc3++;
                        Console.Clear();
                        Console.WriteLine("Ingrese un dpi");
                        string DPI = Console.ReadLine();
                        string[] DPI_split = new string[13];
                        if(DPI.Length == 13)
                        {
                            for (int i = 1; i <= 23;)
                            {
                                DPI = DPI.Insert(i, " ");
                                i += 2;
                            }
                            DPI_split = DPI.Split();
                            string departamento = DPI_split[9] + DPI_split[10];
                            string municipio = DPI_split[11] + DPI_split[12];
                            if (Convert.ToInt16(departamento) > 0 && Convert.ToInt16(departamento) < 23)
                            {
                                switch (departamento)
                                {
                                    case "01":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 18)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Guatemala\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "02":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 9)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de El Progreso\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "03":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 17)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Sacatepéquez\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "04":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 17)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Chimaltenango \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "05":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 14)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Escuintla \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "06":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 15)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Santa Rosa\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "07":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 20)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Sololá \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "08":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 9)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Totonicapán \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "09":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 25)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Quetzaltenango \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "10":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 22)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Suchitepéquez \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "11":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 10)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Retalhuleu \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "12":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 31)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de San Marcos\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "13":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 33)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Huehuetenango \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "14":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 22)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Quiché \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "15":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 9)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Baja Verapaz\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "16":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 18)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Alta Verapaz\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "17":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 15)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Petén \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "18":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 6)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Izabal \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "19":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 12)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Zacapa \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "20":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 12)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Chiquimula \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "21":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 8)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Jalapa \nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "22":
                                        if (Convert.ToInt16(municipio) > 0 && Convert.ToInt16(municipio) < 18)
                                        {
                                            Console.WriteLine("El dueño del DPI pertenece al departamento de Jutiapa\nEl CUI es valido");
                                            Console.ReadLine();
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("el CUI no es valido");
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Console.WriteLine("no ingreso un DPI Valido");
                            Console.ReadKey();
                        }
                        
                    }
                    if (op == "4")
                    {
                        opc4++;
                        string banco1, banco2, banco3;
                        double tazaI1, tazaI2, tazaI3;
                        Console.Clear();
                        Console.WriteLine("ingrese el monto que desea prestar: ");
                        int P = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("ingrese los años en que desea pagar el prestamo: ");
                        int TiempoA = Convert.ToInt32(Console.ReadLine());
                        int TiempoM = TiempoA * 12;

                        Console.Clear();
                        Console.WriteLine("A continuacion ingrese los bancos junto con sus tazas de interes.");

                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del banco: ");
                        banco1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ingrese la taza de interes en porcentaje anual del banco " + banco1 + ": ");
                        tazaI1 = Convert.ToDouble(Console.ReadLine()) / (100 * 12);

                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del banco: ");
                        banco2 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ingrese la taza de interes en porcentaje anual del banco " + banco2 + ": ");
                        tazaI2 = Convert.ToDouble(Console.ReadLine()) / (100 * 12);

                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del banco: ");
                        banco3 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ingrese la taza de interes en porcentaje anual del banco " + banco3 + ": ");
                        tazaI3 = Convert.ToDouble(Console.ReadLine()) / (100 * 12);

                        double Cuota1, Cuota2, Cuota3;
                        double interes1, interes2, interes3;
                        interes1 = P * tazaI1 * TiempoA;
                        interes2 = P * tazaI2 * TiempoA;
                        interes3 = P * tazaI3 * TiempoA;
                        Cuota1 = (P * tazaI1) / (1 - Math.Pow((1 + tazaI1), (TiempoM * -1)));
                        Cuota2 = (P * tazaI2) / (1 - Math.Pow((1 + tazaI2), (TiempoM * -1)));
                        Cuota3 = (P * tazaI3) / (1 - Math.Pow((1 + tazaI3), (TiempoM * -1)));
                        if (interes1 < interes2 && interes2 < interes3)
                        {
                            Console.Clear();
                            Console.WriteLine("El banco que se recomieda solicitar el prestamo es el " + banco1);
                            Console.WriteLine(banco1 + ": el pago en este banco debe de ser de Q" + Cuota1 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco2 + ": el pago en este banco debe de ser de Q" + Cuota2 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco3 + ": el pago en este banco debe de ser de Q" + Cuota3 + " por mes en el plazo de " + TiempoA + "Años");
                        }
                        else if (interes1 < interes3 && interes3 < interes2)
                        {
                            Console.Clear();
                            Console.WriteLine("El banco que se recomieda solicitar el prestamo es el " + banco1);
                            Console.WriteLine(banco1 + ": el pago en este banco debe de ser de Q" + Cuota1 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco3 + ": el pago en este banco debe de ser de Q" + Cuota3 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco2 + ": el pago en este banco debe de ser de Q" + Cuota2 + " por mes en el plazo de " + TiempoA + "Años");
                        }
                        else if (interes2 < interes1 && interes1 < interes3)
                        {
                            Console.Clear();
                            Console.WriteLine("El banco que se recomieda solicitar el prestamo es el " + banco2);
                            Console.WriteLine(banco2 + ": el pago en este banco debe de ser de Q" + Cuota2 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco1 + ": el pago en este banco debe de ser de Q" + Cuota1 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco3 + ": el pago en este banco debe de ser de Q" + Cuota3 + " por mes en el plazo de " + TiempoA + "Años");
                        }
                        else if (interes2 < interes3 && interes3 < interes1)
                        {
                            Console.Clear();
                            Console.WriteLine("El banco que se recomieda solicitar el prestamo es el " + banco2);
                            Console.WriteLine(banco2 + ": el pago en este banco debe de ser de Q" + Cuota2 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco3 + ": el pago en este banco debe de ser de Q" + Cuota3 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco1 + ": el pago en este banco debe de ser de Q" + Cuota1 + " por mes en el plazo de " + TiempoA + "Años");
                        }
                        else if (interes3 < interes2 && interes2 < interes1)
                        {
                            Console.Clear();
                            Console.WriteLine("El banco que se recomieda solicitar el prestamo es el " + banco3);
                            Console.WriteLine(banco3 + ": el pago en este banco debe de ser de Q" + Cuota3 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco2 + ": el pago en este banco debe de ser de Q" + Cuota2 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco1 + ": el pago en este banco debe de ser de Q" + Cuota1 + " por mes en el plazo de " + TiempoA + "Años");
                        }
                        else if (interes3 < interes1 && interes1 < interes2)
                        {
                            Console.Clear();
                            Console.WriteLine("El banco que se recomieda solicitar el prestamo es el " + banco3);
                            Console.WriteLine(banco3 + ": el pago en este banco debe de ser de Q" + Cuota3 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco1 + ": el pago en este banco debe de ser de Q" + Cuota1 + " por mes en el plazo de " + TiempoA + "Años");

                            Console.WriteLine(banco2 + ": el pago en este banco debe de ser de Q" + Cuota2 + " por mes en el plazo de " + TiempoA + "Años");
                        }
                        Console.ReadKey();
                    }
                    if (op == "5")
                    {
                        opc5++;
                        Console.Clear();
                        Console.WriteLine("Bienvenido a la calculadora de tiempo\nIngrese su dia de nacimiento");
                        int dia = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Ingrese su mes de nacimiento");
                        string n = "";
                        int Meses = 0;
                        n = Console.ReadLine();
                        if ((n == "1") || (n == "2") || (n == "3") || (n == "4") || (n == "5") || (n == "6")
                            || (n == "7") || (n == "8") || (n == "9") || (n == "10") || (n == "11") || (n == "12"))
                        {
                            Meses = Convert.ToInt16(n);
                        }
                        else
                        {
                            switch (n)
                            {
                                case "enero":
                                    Meses = 1;
                                    break;
                                case "febrero":
                                    Meses = 2;
                                    break;
                                case "marzo":
                                    Meses = 3;
                                    break;
                                case "abril":
                                    Meses = 4;
                                    break;
                                case "mayo":
                                    Meses = 5;
                                    break;
                                case "junio":
                                    Meses = 6;
                                    break;
                                case "julio":
                                    Meses = 7;
                                    break;
                                case "agosto":
                                    Meses = 8;
                                    break;
                                case "septiembre":
                                    Meses = 9;
                                    break;
                                case "octubre":
                                    Meses = 10;
                                    break;
                                case "noviembre":
                                    Meses = 11;
                                    break;
                                case "diciembre":
                                    Meses = 12;
                                    break;
                            }
                        }
                        Console.WriteLine("ingrese su año de nacimiento");
                        int año = Convert.ToInt16(Console.ReadLine());
                        if ((año < 2001 || año > 2003) && (año >= 1980 && año <= 2018))
                        {
                            Console.Clear();
                            int dias = 0;
                            switch (año)
                            {
                                case 1980://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 13878;
                                    break;
                                case 1981:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 13514;
                                    break;
                                case 1982:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 13149;
                                    break;
                                case 1983:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 12784;
                                    break;
                                case 1984://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 12418;
                                    break;
                                case 1985:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 12053;
                                    break;
                                case 1986:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 11688;
                                    break;
                                case 1987:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 11323;
                                    break;
                                case 1988://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 10957;
                                    break;
                                case 1989:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 10592;
                                    break;
                                case 1990:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 102277;
                                    break;
                                case 1991:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 9862;
                                    break;
                                case 1992://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 9497;
                                    break;
                                case 1993:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 9131;
                                    break;
                                case 1994:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 8766;
                                    break;
                                case 1995:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 8401;
                                    break;
                                case 1996://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 8035;
                                    break;
                                case 1997:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 7670;
                                    break;
                                case 1998:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 7305;
                                    break;
                                case 1999:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 6940;
                                    break;
                                case 2000://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 6574;
                                    break;
                                case 2004://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 5113;
                                    break;
                                case 2005:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 4748;
                                    break;
                                case 2006:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 4383;
                                    break;
                                case 2007:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 4018;
                                    break;
                                case 2008://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 3652;
                                    break;
                                case 2009:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 3287;
                                    break;
                                case 2010:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 2922;
                                    break;
                                case 2011:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 2557;
                                    break;
                                case 2012://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 2191;
                                    break;
                                case 2013:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 1826;
                                    break;
                                case 2014:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 1461;
                                    break;
                                case 2015:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 1096;
                                    break;
                                case 2016://bisiesto
                                    Añocalculo(ref dias, dia, Meses, true);
                                    dias += 730;
                                    break;
                                case 2017:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    dias += 365;
                                    break;
                                case 2018:
                                    Añocalculo(ref dias, dia, Meses, false);
                                    break;
                            }
                            dias += 280;
                            Console.WriteLine("Los días que tiene existiendo son igual a " + dias + " días\nDesea saber a cuantos segundos equivalen " + dias + "?");
                            string op1 = Console.ReadLine();
                            if (op1 == "Yes" || op1 == "Y" || op1 == "Si" || op1 == "si" || op1 == "yes" || op1 == "y")
                            {
                                Console.WriteLine("Usted ha vidido un aproximado de " + (dias * 86400) + "seg");
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("no es posible calcular su fecha de nacimiento.");
                            Console.ReadLine();
                        }
                    }
                    if (op == "6")
                    {
                        opc6++;
                        Console.Clear();
                        Console.WriteLine("Ingrese por favor su genero: ");
                        string generoLeido = Console.ReadLine();
                        if(generoLeido == "Femenino"  || generoLeido == "F" || generoLeido == "femenino" || generoLeido == "f")
                        {
                            Console.WriteLine("Ingrese su Altura: ");
                            double Altura = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese su Peso: ");
                            double Peso = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese su Edad: ");
                            int Edad = Convert.ToInt16(Console.ReadLine());

                            double IMC = Peso / Math.Pow(Altura, 2);

                            double IndiceGraza = (1.2 * IMC) + (0.23 * Edad) - 5.4;
                            Console.WriteLine("Su porcentaje de graza corporal se encuentra en " + IndiceGraza + "%");
                            Console.ReadKey();
                        }
                        else if (generoLeido == "Masculino" || generoLeido == "M" || generoLeido == "masculino" || generoLeido == "m")
                        {
                            Console.WriteLine("Ingrese su Altura: ");
                            double Altura = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese su Peso: ");
                            double Peso = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese su Edad: ");
                            int Edad = Convert.ToInt16(Console.ReadLine());

                            double IMC = Peso / Math.Pow(Altura, 2);

                            double IndiceGraza = (1.2 * IMC) + (0.23 * Edad) - 5.4 - 10.8;
                            Console.WriteLine("Su porcentaje de graza corporal se encuentra en " + IndiceGraza + "%");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No ingreso un genero valido");
                        }

                    }
                    if (op == "7")
                    {
                        menu = false;
                        salir = true;
                        NombreS = Nombre;
                        CorreoS = Correo;
                        DomicilioS = Domicilio;
                        salir = true;
                        Nombre = null;
                        Correo = null;
                        Domicilio = null;
                        break;
                    }
                }
            } while (true);
            

        }
    }
}
