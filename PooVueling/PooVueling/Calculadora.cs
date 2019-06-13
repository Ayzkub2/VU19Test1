using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    /// <summary>
    /// Clase que opera con enteros
    /// </summary>
    /// <seelaso cref="ICalculadora"/>
    public class Calculadora : ICalculadora, ICloneable
    {
        #region Iclonable implementation
        public object Clone()
        {
            throw new NotImplementedException("The method is not implemented yet");
        }
        #endregion

        #region ICalculadora implementation
        /// <summary>
        /// Divide num1 entre num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Division(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        /// Multiplica num1 por num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Resta num1 - num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Suma num1 y num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        #endregion
    }
}
