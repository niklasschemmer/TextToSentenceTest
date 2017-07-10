using System.Collections.Generic;
using Neuronal_Net_Test.NeuralNet.Neurons;

namespace Neural_Net_Training_Test.Neural_Net.Neuron
{
    class WorkingNeuron : Neuron
    {
        private float? _value;
        private List<Connection> _connections = new List<Connection>();

        public void AddNeuronConnection(Connection conn) => _connections.Add(conn);

        private void Calculate()
        {
            float value = 0;
            foreach (var c in _connections)
            {
                value += c.GetValue();
            }
            value = Neuron.Sigmoid(value);
            _value = value;
        }

        public void Invalidate() => _value = null;

        public override float GetValue()
        {
            if (_value == null)
            {
                Calculate();
            }
            return _value??0;
        }
    }
}
