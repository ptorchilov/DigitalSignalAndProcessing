// -----------------------------------------------------------------------
// <copyright file="Function.cs" company="BSUIR">
//  Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_FFTandDFT
{
    using System.Numerics;

    /// <summary>
    /// Class for function
    /// </summary>
    public static class Function
    {
        /// <summary>
        /// Gets the function.
        /// </summary>
        /// <param name="x">The executable.</param>
        /// <returns>
        /// Function for x
        /// </returns>
        public static Complex GetFunction(Complex x)
        {
            return Complex.Cos(x) + Complex.Sin(2 * x);
        }
    }
}
