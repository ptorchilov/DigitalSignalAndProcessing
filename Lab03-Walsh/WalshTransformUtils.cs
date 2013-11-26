// -----------------------------------------------------------------------
// <copyright file="WalshTrnsformUtils.cs" company="BSUIR">
// Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab03_Walsh
{
    using System;
    using Lab01_FFTandDFT;

    /// <summary>
    /// Class for Walsh Transform
    /// </summary>
    public static class WalshTransformUtils
    {
        /// <summary>
        /// Gets the fast walsh transform.
        /// </summary>
        /// <param name="functionVector">The function vector.</param>
        /// <param name="direction">The direction.</param>
        /// <returns>Result of Walsh transform</returns>
        /// <exception cref="System.ArgumentException">Invalid length of vector.</exception>
        public static double[] GetFastWalshTransform(double[] functionVector, TransformDirection direction)
        {
            if (functionVector.Length <= 1)
            {
                throw new ArgumentException("Invalid length of vector.");
            }

            // ReSharper disable once InconsistentNaming
            var N = functionVector.Length;

            var leftPath = new double[N / 2];
            var rightPath = new double[N / 2];

            for (var i = 0; i < N / 2; i++)
            {
                leftPath[i] = functionVector[i] + functionVector[i + N / 2];
                rightPath[i] = functionVector[i] - functionVector[i + N / 2];
            }

            var leftResult = GetFastWalshTransform(leftPath, direction);
            var rightResult = GetFastWalshTransform(rightPath, direction);

            var result = new double[N];

            if (direction == TransformDirection.Direct)
            {
                for (var i = 0; i < N / 2; i++)
                {
                    result[i] = leftResult[i] / 2;
                    result[i + N / 2] = rightResult[i] / 2;
                }
            }
            else
            {
                for (var i = 0; i < N / 2; i++)
                {
                    result[i] = leftResult[i];
                    result[i + N / 2] = rightResult[i];
                }
            }

            return result;
        }
    }
}