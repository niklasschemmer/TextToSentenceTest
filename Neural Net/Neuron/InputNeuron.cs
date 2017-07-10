namespace Neural_Net_Training_Test.Neural_Net.Neuron
{
    class InputNeuron : Neuron
    {
        private float _value;
        public void Setvalue(float x) => _value = x;
        public override float GetValue() => _value;
    }
}
