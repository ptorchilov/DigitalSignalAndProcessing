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
            var count = 0.0;

            for (var i = 0; i < N; i++)
            {
                valuesVector[i] = Function.GetFunction(count);
                count += Interval;
            }

            return valuesVector;
        }

        /// <summary>
        /// Makes the DFT.
        /// </summary>
        /// <param name="functionVector">The function vector.</param>
        /// <param name="direction">The direction.</param>
        /// <returns>Vector of function after DFT</returns>
        public static Complex[] MakeDFT(Complex[] functionVector, TransformDirection direction)
        {
            var DFTVector = new Complex[N];

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    DFTVector[i] += functionVector[j] * GetComplexExponent(direction, i, j);
                }

                if (direction == TransformDirection.Direct)
                {
                    DFTVector[i] /= N;
                }
            }

            return DFTVector;
        }

        #endregion

        #region PrivateMethods

        /// <summary>
        /// Gets the complex exponent.
        /// </summary>
        /// <param name="direction">The direction.</param>
        /// <param name="i">The attribute.</param>
        /// <param name="j">The object.</param>
        /// <returns>
        /// Complex exponent
        /// </returns>
        private static Complex GetComplexExponent(TransformDirection direction, int i, int j)
        {
            return Complex.Exp(-(int)direction * 2 * Math.PI * Complex.ImaginaryOne * i * j / N);
        }

        #endregion
    }
}
