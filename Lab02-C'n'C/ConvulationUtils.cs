﻿// -----------------------------------------------------------------------
// <copyright file="ConvolutionUtils.cs" company="BSUIR">
// Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab02_C_n_C
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Methods for convolution funstion
    /// </summary>
    public static class ConvulationUtils
    {
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

            // ReSharper disable once InconsistentNaming
            var N = originalVector.Length;
            var result = new Complex[N];

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (i + j < N)
                    {
                        result[i] += originalVector[j] + convolutionVector[i + j];
                    }
                    else
                    {
                        result[i] += originalVector[j] + convolutionVector[i + j - N];
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

            // ReSharper disable once InconsistentNaming
            var N = originalVector.Length;
            var result = new Complex[N];

            return result;
        }

    }
}