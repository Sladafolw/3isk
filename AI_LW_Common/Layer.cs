using System.Text;

namespace Network
{
    public partial class MultilayerNeuralNetwork
    {
        private class Layer
        {
            private readonly double[,] weights;
            private readonly Func<double, double> function;
            public double[] inputVector;

            public Layer(double[,] weights, double steepness)
            {
                this.weights = weights;
                function = net => 1 / (1 + Math.Exp(-steepness * net));
            }

            public Layer(int inputVecSize, int outputVecSize, double steepness)
            {
                weights = new double[outputVecSize, inputVecSize];
                function = net => 1 / (1 + Math.Exp(-steepness * net));
                for (int i = 0; i < outputVecSize; i++)
                {
                    for (int j = 0; j < inputVecSize; j++)
                    {
                        weights[i, j] = Math.Round(NumberGenerator.GetDoubleRandomValue(-0.1, 0.1), 12);
                    }
                }
            }

            public double[] GetOutputVector(double[] inputVector)
            {
                double[] outputVector = new double[OutputVecSize];

                this.inputVector = new double[InputVecSize];
                inputVector.CopyTo(this.inputVector, 0);

                for (int i = 0; i < OutputVecSize; i++)
                {
                    double outValue = 0;

                    for (int j = 0; j < InputVecSize; j++)
                    {
                        outValue += weights[i, j] * inputVector[j];
                    }
                    outputVector[i] = function(outValue);
                }

                return outputVector;
            }

            public void ChangeWeights(double learningSpeed, double[] deltas)
            {
                for (int p = 0; p < InputVecSize; p++)
                {
                    for (int q = 0; q < OutputVecSize; q++)
                    {
                        weights[q, p] += learningSpeed * deltas[q] * inputVector[p];
                    }
                }
            }

            public double GetWeight(int q, int k)
            {
                return weights[k, q];
            }

            public void SaveWeightsToFile(string path)
            {
                StreamWriter writer = new(path, false);

                for (int i = 0; i < OutputVecSize; i++)
                {
                    StringBuilder builder = new(weights[i, 0].ToString());

                    for (int j = 1; j < InputVecSize; j++)
                    {
                        builder.Append($" {weights[i, j]}");
                    }
                    writer.WriteLine(builder);
                }

                writer.Flush();
                writer.Close();
            }

            public int InputVecSize { get => weights.GetLength(1); }
            public int OutputVecSize { get => weights.GetLength(0); }
        }
    }
}
