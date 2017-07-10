using Neural_Net_Training_Test.Neural_Net.Neuron;

namespace Neuronal_Net_Test.NeuralNet.Neurons
{
    class Connection
    {
        public float weight = 1;
        public Neuron entrieNeuron;

        public Connection(Neuron n, float weight)
        {
            this.weight = weight;
            this.entrieNeuron = n;
        }

        public float GetValue() => weight * entrieNeuron.GetValue();
    }
}
