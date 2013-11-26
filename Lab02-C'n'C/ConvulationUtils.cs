// -----------------------------------------------------------------------
// <copyright file="ConvolutionUtils.cs" company="BSUIR">
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
    /// Methods for convolution funstion
    /// </summary>
    public static class ConvulationUtils
    {
        /// <summary>
        /// The convolution complexibility
        /// </summary>
        public static int ConvolutionComplexibility = 0;

        /// <summary>
        /// The convolution complexibility FFT
        /// </summary>
        public static int ConvolutionComplexibilityFFT = 0;

        /// <summary>
        /// Gets the convolution.
        /// </summary>
        /// <param name="originalVector">The original vector.</param>
        /// <param name="convolutionVector">The convolution vector.</param>
        /// <returns>Result of convolution</returns>
        /// <exception cref="System.ArgumentException">Different length of vectors</exception>
        public static Complex[] GetConvolution(Complex[] originalVector, Complex[] convolutionVector)
        {
            if (originalVector.Length != convolutionVector.Length)
            {
                throw new ArgumentException("Different length of vectors");
            }

            ConvolutionComplexibility = 0;

            // ReSharper disable once InconsistentNaming
            var N = originalVector.Length;
            var result = new Complex[N];

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (i - j >= 0)
                    {
                        result[i] += originalVector[j] * convolutionVector[i - j];
                        ConvolutionComplexibility++;
                    }
                    else
                    {
                        result[i] += originalVector[j] * convolutionVector[i - j + N];
                        ConvolutionComplexibility++;
                    }
                }

                result[i] /= N;
            }

            return result;
        }

        /// <summary>
        /// Gets the convolution with FFT.
        /// </summary>
        /// <param name="originalVector">The original vector.</param>
        /// <param name="convolutionVector">The convolution vector.</param>
        /// <returns>Result of convolution with FFT</returns>
        /// <exception cref="System.ArgumentException">Different length of vectors</exception>
        public static Complex[] GetConvolutionWithFFT(Complex[] originalVector, Complex[] convolutionVector)
        {
            if (originalVector.Length != convolutionVector.Length)
            {
                throw new ArgumentException("Different length of vectors");
            }

            ConvolutionComplexibilityFFT = 0;
            
            var originalVectorWithFFT = FourierTransformUtils.MakeFFT(originalVector, TransformDirection.Direct);
            ConvolutionComplexibilityFFT += FourierTransformUtils.Complexibility;

            var convolutionVectorWithFFT = FourierTransformUtils.MakeFFT(convolutionVector, TransformDirection.Direct);
            ConvolutionComplexibilityFFT += FourierTransformUtils.Complexibility;

            var result = originalVectorWithFFT.Zip(convolutionVectorWithFFT, (x, y) => x * y).ToArray();

            return FourierTransformUtils.MakeFFT(result, TransformDirection.Reverse);
        }

    }
}
