using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    public interface ICalculadora
    {
        /// <summary>
        /// Sumas the specifies num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Suma(int num1, int num2);

        /// <summary>
        /// Resta el num1 al num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Resta(int num1, int num2);

        /// <summary>
        /// Multiplica num1 por num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Multiplicacion(int num1, int num2);

        /// <summary>
        /// Divide num1 por num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Division(int num1, int num2);

    }
}
