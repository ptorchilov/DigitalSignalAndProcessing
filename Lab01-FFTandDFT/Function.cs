// -----------------------------------------------------------------------
// <copyright file="Function.cs" company="BSUIR">
//  Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_FFTandDFT
{
    using System;

    /// <summary>
    /// Class for function
    /// </summary>
    public static class Function
    {
        /// <summary>
        /// Gets the function.
        /// </summary>
        /// <param name="x">The executable.</param>
        /// <returns>Function for x</returns>
        public static double GetFunction(double x)
        {
            return Math.Cos(x) + Math.Sin(2 * x);
        }
    }
}
