// -----------------------------------------------------------------------
// <copyright file="CorrelationUtils.cs" company="BSUIR">
// Torchilov Pavel 
// </copyright>
// -----------------------------------------------------------------------

namespace Lab02_C_n_C
{
    using System;
    using System.Linq;
    using System.Numerics;

    using Lab01_FFTandDFT;

    /// <summary>
    /// Methods for correlation
    /// </summary>
    public static class CorrelationUtils
    {
        /// <summary>
        /// The correlation complexibility
        /// </summary>
        public static int CorrelationComplexibility = 0;

        /// <summary>
        /// The correlation complexibility with FFT
        /// </summary>
        public static int CorrelationComplexibilityWithFFT = 0;

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

            CorrelationComplexibility = 0;

            // ReSharper disable once InconsistentNaming
            var N = originalVector.Length;
            var result = new Complex[N];

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (i + j < N)
                    {
                        result[i] += originalVector[j] * correlationVector[i + j];
                        CorrelationComplexibility++;
                    }
                    else
                    {
                        result[i] += originalVector[j] * correlationVector[i + j - N];
                        CorrelationComplexibility++;
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

            CorrelationComplexibilityWithFFT = 0;

            // ReSharper disable once InconsistentNaming
            var originalVectorWithFFT = FourierTransformUtils.MakeFFT(originalVector, TransformDirection.Direct);
            CorrelationComplexibilityWithFFT += FourierTransformUtils.Complexibility;

            var correlationVectorWithFFT = FourierTransformUtils.MakeFFT(correlationVector, TransformDirection.Direct);
            CorrelationComplexibilityWithFFT += FourierTransformUtils.Complexibility;

            var result =
                originalVectorWithFFT.Zip(correlationVectorWithFFT, (x, y) => Complex.Conjugate(x) * y).ToArray();

            return FourierTransformUtils.MakeFFT(result, TransformDirection.Reverse);
        }
    }
}
