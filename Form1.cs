using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Neural_Net_Training_Test.Neural_Net;

namespace Neural_Net_Training_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var net = new NeuralNet();
            net.CreateLayers(20,40,20);
        }
    }
}
