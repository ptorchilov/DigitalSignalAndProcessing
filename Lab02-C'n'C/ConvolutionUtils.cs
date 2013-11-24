// -----------------------------------------------------------------------
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
    public static class ConvolutionUtils
    {
        public static Complex[] GetConvolution(Complex[] originalVector, Complex[] convolutionVector)
        {
            if (originalVector.Length != convolutionVector.Length)
            {
                throw new ArgumentException("Different length of vectors");
            }

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

    }
}
