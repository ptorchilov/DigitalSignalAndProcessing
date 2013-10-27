// -----------------------------------------------------------------------
// <copyright file="TransformUtils.cs" company="BSUIR">
//  Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_FFTandDFT
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Class for transform function
    /// </summary>
    public static class TransformUtils
    {
        #region Constants

        /// <summary>
        /// The number of samples.
        /// </summary>
        private const int N = 8;

        /// <summary>
        /// The period
        /// </summary>
        private const double Period = Math.PI * 2;

        #endregion

        #region TransformMethods

        /// <summary>
        /// Gets the function vector.
        /// </summary>
        /// <returns>Values vector for function</returns>
        public static Complex[] GetFunctionVector()
        {
            const double Interval = Period / N;
            var valuesVector = new Complex[N];
            Complex count = 0;

            for (var i = 0; i < N; i++)
            {
                valuesVector[i] = Function.GetFunction(count);
                count += Interval;
            }

            return valuesVector;
        }

        #endregion
    }
}
