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

        public static int Complexibility = 0;

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
            Complexibility = 0;
            var DFTVector = new Complex[N];

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    DFTVector[i] += functionVector[j] * GetComplexExponent(direction, i, j);
                    Complexibility++;
                }

                if (direction == TransformDirection.Direct)
                {
                    DFTVector[i] /= N;
                }
            }

            return DFTVector;
        }

        /// <summary>
        /// Makes the FFT.
        /// </summary>
        /// <param name="functionVector">The function vector.</param>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        public static Complex[] MakeFFT(Complex[] functionVector, TransformDirection direction)
        {
            if (functionVector.Length == 1)
            {
                return functionVector;
            }
            int N = functionVector.Length;

            var wN = Complex.Exp(-(int)direction * 2 * Math.PI * Complex.ImaginaryOne / N);
            var w = new Complex(1, 0);
            var FFTVector = new Complex[N];

            var leftPath = new Complex[N / 2];
            var rightPath = new Complex[N / 2];

            for (var i = 0; i < N / 2; i++)
            {
                leftPath[i] = functionVector[i] + functionVector[i + N / 2];
                rightPath[i] = (functionVector[i] - functionVector[i + N / 2]) * w;
                w *= wN;
                Complexibility++;
            }

            var leftResult = MakeFFT(leftPath, direction);
            var rightResult = MakeFFT(rightPath, direction);

            if (direction == TransformDirection.Direct)
            {
                for (var i = 0; i < N / 2; i++)
                {
                    FFTVector[i] = leftResult[i] / 2;
                    FFTVector[i + N / 2] = rightResult[i] / 2;
                }
            }
            else
            {
                for (var i = 0; i < N / 2; i++)
                {
                    FFTVector[i] = leftResult[i];
                    FFTVector[i + N / 2] = rightResult[i];
                }
            }

            return FFTVector;
        }

        /// <summary>
        /// Makes the FFT full.
        /// </summary>
        /// <param name="functionVector">The function vector.</param>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        public static Complex[] MakeFFTFull(Complex[] functionVector, TransformDirection direction)
        {
            Complexibility = 0;
            var values = MakeFFT(functionVector, direction);
            FFTReorder(values);
            return values;
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

        /// <summary>
        /// FFTs the reorder.
        /// </summary>
        /// <param name="vector">The vector.</param>
        private static void FFTReorder(Complex[] vector)
        {
            if (vector.Length <= 2)
            {
                return;
            }

            int r = 0;

            for (var i = 1; i < vector.Length; i++)
            {
                r = ReverseNextValue(r, vector.Length);
                if (r > i)
                {
                    Swap(vector, i, r);
                }
            }
        }

        /// <summary>
        /// Swaps the specified vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="i">The attribute.</param>
        /// <param name="r">The argument.</param>
        private static void Swap(Complex[] vector, int i, int r)
        {
            Complex temp = vector[i];
            vector[i] = vector[r];
            vector[r] = temp;
        }

        /// <summary>
        /// Reverses the next value.
        /// </summary>
        /// <param name="r">The argument.</param>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        private static int ReverseNextValue(int r, int length)
        {
            do
            {
                length = length >> 1;
                r = r ^ length;
            }
            while ((r & length) == 0);
            return r;
        }

        #endregion
    }
}
