namespace Network
{
    public partial class MultilayerNeuralNetwork
    {
        private readonly Layer[] layers;
        private readonly double learningSpeed;
        public int OutputVectorSize { get => layers.Last().OutputVecSize; }

        public MultilayerNeuralNetwork(string pathToWeights, string pathToSizes, 
            double steepness, double learningSpeed)
        {
            var paths = Directory.GetFiles(pathToWeights);
            StreamReader reader;
            string? line;
            int pathsLength = paths.Length;
            int[] layersSizes = new int[pathsLength];
            double[][,] weights = new double[pathsLength][,];
            int counter = 0;

            reader = new(pathToSizes);
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(' ');
                int rowsNumber = int.Parse(values[0]);
                int colsNumber = int.Parse(values[1]);

                layersSizes[counter] = rowsNumber;
                weights[counter++] = new double[rowsNumber, colsNumber];
            }
            reader.Close();

            for (int i = 0; i < pathsLength; i++)
            {
                var weightsI = weights[i];

                reader = new(paths[i]);
                for (int j = 0; j < weightsI.GetLength(0); j++)
                {
                    var values = reader.ReadLine().Split(' ');

                    for (int k = 0; k < weightsI.GetLength(1); k++)
                    {
                        weightsI[j, k] = double.Parse(values[k]);
                    }
                }
                reader.Close();
            }

            layers = new Layer[pathsLength];
            for (int i = 0; i < pathsLength; i++)
            {
                layers[i] = new Layer(weights[i], steepness);
            }

            this.learningSpeed = learningSpeed;
        }

        public MultilayerNeuralNetwork(int[] layersSizes, int inputLayerSize, 
            double steepness, double learningSpeed)
        {
            int layerCount = layersSizes.Length;
            int inputVecSize = inputLayerSize;
            int outputVecSize;

            layers = new Layer[layerCount];
            for (int i = 0; i < layerCount; i++)
            {
                outputVecSize = layersSizes[i];
                layers[i] = new Layer(inputVecSize, outputVecSize, steepness);
                inputVecSize = outputVecSize;
            }

            this.learningSpeed = learningSpeed;
        }

        public int LayerCount { get => layers.Length; }

        public double[] GetOutputVector(double[] inputVector)
        {
            for (int i = 0; i < layers.Length; i++)
            {
                inputVector = layers[i].GetOutputVector(inputVector);
            }

            return inputVector;
        }

        public void Learning((double[] inputVector, double[] targetVector)[] learningPairs, 
            int iterationsCount, ProgressBar progressBar)
        {
            int j = 0;
  
          
            for (j = 0; j < iterationsCount; j++)
            {          
                for (int i = 0; i < learningPairs.Length; i++)
                {
                    progressBar.Value = Convert.ToInt32(j * 100.0 / iterationsCount);

                    var (inputVector, targetVector) = learningPairs[i];
                    var outputVector = GetOutputVector(inputVector);

                    BackPropagation(outputVector, targetVector);
                }
            }
            progressBar.Value = 100;
        }

        public void SaveWeightsToFile(string path)
        {
            for (int i = 0; i < LayerCount; i++)
            {
                layers[i].SaveWeightsToFile(@$"{path}\{i}.txt");
            }
        }

        private void BackPropagation(double[] outputVector, double[] targetVector)
        {
            var layer = layers.Last();
            int outputVecSize = layer.OutputVecSize;
            double[] deltas = new double[outputVecSize];

            for (int i = 0; i < OutputVectorSize; i++)
            {
                double outValue = outputVector[i];

                deltas[i] = outValue * (1 - outValue) * (targetVector[i] - outValue);
            }
            layers.Last().ChangeWeights(learningSpeed, deltas);

            for (int i = LayerCount - 2; i >= 0; i--)
            {
                int deltasTempCount = deltas.Length;
                var nextLayer = layers[i + 1];
                double[] deltasTemp = new double[deltasTempCount];

                layer = layers[i];
                outputVector = nextLayer.inputVector;
                outputVecSize = layer.OutputVecSize;

                deltas.CopyTo(deltasTemp, 0);
                deltas = new double[outputVecSize];
                for (int q = 0; q < outputVecSize; q++)
                {
                    double outValue = outputVector[q];
                    double sum = 0;

                    for (int k = 0; k < deltasTempCount; k++)
                    {
                        sum += deltasTemp[k] * nextLayer.GetWeight(q, k);
                    }
                    deltas[q] = outValue * (1 - outValue) * sum;
                }
                layer.ChangeWeights(learningSpeed, deltas);
            }
        }
    }
}
