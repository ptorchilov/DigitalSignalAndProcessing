// -----------------------------------------------------------------------
// <copyright file="CorrelationUtils.cs" company="BSUIR">
// Torchilov Pavel 
// </copyright>
// -----------------------------------------------------------------------

namespace Lab02_C_n_C
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Methods for correlation
    /// </summary>
    public static class CorrelationUtils
    {
        /// <summary>
        /// Gets the correlation.
        /// </summary>
        /// <param name="originalVector">The original vector.</param>
        /// <param name="correlationVector">The correlation vector.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Different length of vectors</exception>
        public static Complex[] GetCorrelation(Complex[] originalVector, Complex[] correlationVector)
        {
            if (originalVector.Length != correlationVector.Length)
            {
                throw new ArgumentException("Different length of vectors");
            }

            // ReSharper disable once InconsistentNaming
            var N = originalVector.Length;
            var result = new Complex[N];

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (i + j < N)
                    {
                        result[i] += originalVector[j] + correlationVector[i + j];
                    }
                    else
                    {
                        result[i] += originalVector[j] + correlationVector[i + j - N];
                    }
                }

                result[i] /= N;
            }

            return result;
        }

        public static Complex[] GetCorrelationWithFFT(Complex[] originalVector, Complex[] correlationVector)
        {
            if (originalVector.Length != correlationVector.Length)
            {
                throw new ArgumentException("Different length of vectors");
            }

            // ReSharper disable once InconsistentNaming
            var N = originalVector.Length;
            var result = new Complex[N];

            return result;
        }
    }
}
