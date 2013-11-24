// -----------------------------------------------------------------------
// <copyright file="Functions.cs" company="BSUIR">
//  Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_FFTandDFT
{
    using System;

    /// <summary>
    /// Class for function
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Gets the function.
        /// </summary>
        /// <param name="x">The executable.</param>
        /// <returns>
        /// Functions for x
        /// </returns>
        public static double GetOriginalFunction(double x)
        {
            return Math.Cos(x) + Math.Sin(2 * x);
        }

        /// <summary>
        /// Gets the function for convulation.
        /// </summary>
        /// <param name="x">The executable.</param>
        /// <returns></returns>
        public static double GetFunctionForConvolution(double x)
        {
            return Math.Sin(2 * x);
        }
    }
}
