using System;

namespace Neural_Net_Training_Test.Neural_Net.Neuron
{
    abstract class Neuron
    {
        public abstract float GetValue();

        public static float Sigmoid(float x)
        {
            var et = (float)Math.Pow(Math.E, x);
            return Double.IsNegativeInfinity(et) ? 0 : Double.IsPositiveInfinity(et) ? 1 : et / (1 + et);
        }
    }
}
