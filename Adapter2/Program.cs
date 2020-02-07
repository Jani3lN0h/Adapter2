using Adapter2.Domain.Entities;
using Adapter2.Services;
using Adapter2.Services.Interfaces;
using System;

namespace Adapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequirementService srvRequeriment = new RequirementAdapter();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Captura el Id del RQM: ");
            Console.ResetColor();
            int iIdReq = Convert.ToInt32(Console.ReadLine());
            Requirement resp = (Requirement)srvRequeriment.GetInfoRequeriment(iIdReq);
            string cReturn = string.Format("Se obtiene la info del Requerimiento: {0}, cuyo nombre es {1} y se estimó en {2} LOC.", resp.ID, resp.Name, resp.LOC);
            Console.WriteLine(cReturn);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nPresione una tecla para salir.");
            Console.ReadKey();

        }
    }
}
