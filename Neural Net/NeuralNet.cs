using System;
using System.Collections.Generic;
using Neural_Net_Training_Test.Neural_Net.Neuron;
using Neuronal_Net_Test.NeuralNet.Neurons;

namespace Neural_Net_Training_Test.Neural_Net
{
    class NeuralNet
    {
        private List<InputNeuron> _inputLayer = new List<InputNeuron>();
        private List<WorkingNeuron> _hiddenLayer = new List<WorkingNeuron>();
        private List<WorkingNeuron> _outputLayer = new List<WorkingNeuron>();

        private void CalculateValues()
        {
            foreach (var neuron in _hiddenLayer)
            {
                neuron.GetValue();
            }
            foreach (var neuron in _outputLayer)
            {
                neuron.GetValue();
            }
        }

        public void CreateLayers(int inputSize, int hiddenSize, int outputSize)
        {
            for (var i = 0; i < inputSize; i++)
            {
                _inputLayer.Add(new InputNeuron());
            }
            for (var i = 0; i < hiddenSize; i++)
            {
                _hiddenLayer.Add(new WorkingNeuron());
            }
            for (var i = 0; i < outputSize; i++)
            {
                _outputLayer.Add(new WorkingNeuron());
            }
            GenerateFullMesh();
        }

        public void AddInputNeuron(InputNeuron neuron) => _inputLayer.Add(neuron);

        public void AddHiddenNeuron(WorkingNeuron neuron) => _hiddenLayer.Add(neuron);

        public void AddOutputNeuron(WorkingNeuron neuron) => _outputLayer.Add(neuron);

        public void GenerateFullMesh()
        {
            var rand = new Random();
            foreach (var wn in _hiddenLayer)
            {
                foreach (var input in _inputLayer)
                {
                    wn.AddNeuronConnection(new Connection(input, rand.Next(-10, 10)));
                }
            }

            foreach (var wn in _outputLayer)
            {
                foreach (var wn2 in _hiddenLayer)
                {
                    wn.AddNeuronConnection(new Connection(wn2, 1));
                }
            }
        }

        public void Invalidate()
        {
            foreach (var wn in _hiddenLayer)
            {
                wn.Invalidate();
            }
            foreach (var wn in _outputLayer)
            {
                wn.Invalidate();
            }
        }
    }
}
