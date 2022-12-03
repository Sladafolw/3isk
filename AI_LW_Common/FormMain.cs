using Network;

namespace AI_LW3
{
    public partial class FormMain : Form
    {
        private readonly MultilayerNeuralNetwork network;
        private readonly PictureBoxArtist boxArtist;
        private readonly Dictionary<char, int> pairs;
        private readonly string relativePath = @"..\..\..";

        public FormMain()
        {
            InitializeComponent();

            double steepness = 5;
            double learningSpeed = 1e-1;

            pairs = new()
            {
                { 'П', 0 },
                { 'Е', 1 },
                { 'Т', 2 },
                { 'Л', 3 },
                { 'И', 4 },
                { 'Н', 5 },
                { 'М', 6},
            };
            ComboBoxSelectLetter.SelectedItem = "П";
            boxArtist = new(PictureBoxImage, 1.0 / 3, new Pen(Color.Black, 5f)
            {
                StartCap = System.Drawing.Drawing2D.LineCap.Round,
                EndCap = System.Drawing.Drawing2D.LineCap.Round
            });

            if (MessageBox.Show("Генерировать веса снова?", "Генерация весов", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] layersSizes = new int[] { 200, 200, 7 };
                int inputLayerSize = 2500;

                network = new(layersSizes, inputLayerSize, steepness, learningSpeed);
                return;
            }

            network = new(@$"{relativePath}\weights", $@"{relativePath}\LayersSizes.txt", 
                steepness, learningSpeed);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            string path;

            fileDialog.Filter = "Картинки|*.PNG";
            fileDialog.Title = "Выберите образ картинки";
            fileDialog.InitialDirectory = @$"{relativePath}\letters";
            fileDialog.ShowDialog();
            path = fileDialog.FileName;

            if (!path.Equals(string.Empty))
            {
                PictureBoxImage.Image = new Bitmap(path);
            }
        }

        private void ButtonLearning_Click(object sender, EventArgs e)
        {
                foreach (var control in Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = false;
                    }
                }

                var allPaths = Directory.GetFiles(@$"{relativePath}\letters");
                int learningPairsCount = allPaths.Length;
                (double[] inputVector, double[] expectedOutVector)[] learningPairs =
                    new (double[] inputVector, double[] expectedOutVector)[learningPairsCount];
                Random random = new();
                int counter = 0;

                for (int i = 0; i < learningPairsCount; i++)
                {
                    var path = allPaths[i];
                    Bitmap bitmap = new(path);
                    double[] inputVector;
                    double[] targetVector = new double[7];
                    int pos = pairs[path[path.LastIndexOf('\\') + 1]];

                    inputVector = GetInputSignals(bitmap);

                    targetVector[pos] = 1;
                    learningPairs[i] = new(inputVector, targetVector);
                }

                learningPairs = learningPairs.OrderBy(p => random.Next()).ToArray();

                network.Learning(learningPairs, Convert.ToInt32(NumericUpDownIterationsCount.Value), ProgressBarProgress);
                for (int i = 0; i < learningPairsCount; i++)
                {
                    var outputVector = network.GetOutputVector(learningPairs[i].inputVector);

                    if (outputVector.Any(p => p >= 0.95))
                    {
                        counter++;
                    }
                }
                RichTextBoxChat.AppendText($"Всего обучено {counter} из {learningPairsCount}\n");
                network.SaveWeightsToFile(@$"{relativePath}\tmp");

                foreach (var control in Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = true;
                    }
                }
                ProgressBarProgress.Value = 0;
       

        
        }

        private void PictureBoxImage_MouseMove(object sender, MouseEventArgs e)
        {
            boxArtist.Drawing(e.Location);
        }

        private void PictureBoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            boxArtist.EndDrawing();
        }

        private void PictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            boxArtist.StartDrawing(e.Location);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            boxArtist.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            char letter = ComboBoxSelectLetter.Text.First();
            int id = Directory.GetFiles(@$"..\..\..\letters").Length;

            boxArtist.SaveTo(@$"..\..\..\letters\{letter}_{id + 1}.png");
        }
        #region
int a = 5;
        #endregion

        private void ButtonRecognize_Click(object sender, EventArgs e)
        {
            var inputSignals = GetInputSignals(new(PictureBoxImage.Image));

            var outputVector = network.GetOutputVector(inputSignals);
            double probability = outputVector.Max();
            char letter = Array.IndexOf(outputVector, probability) switch
            {
                0 => 'П',
                1 => 'Е',
                2 => 'Т',
                3 => 'Л',
                4 => 'И',
                5 => 'Н',
                _ => 'М'
            };

            probability *= 100;
            if (probability < 95)
            {
                RichTextBoxChat.AppendText($"Я не знаю точно, что это за буква, " +
                    $"но с вероятностью {string.Format("{0:F3}", probability)}% это {letter}.\n");
                return;
            }
            RichTextBoxChat.AppendText($"Я знаю точно, что это буква {letter}.\n");
        }

        private static double[] GetInputSignals(Bitmap bitmap)
        {
            List<double> inputSignals = new();

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    int inputSignal = bitmap.GetPixel(j, i).A == 0 ? 0 : 1;

                    inputSignals.Add(inputSignal);
                }
            }

            return inputSignals.ToArray();
        }

        private void ButtonClearChat_Click(object sender, EventArgs e)
        {
            RichTextBoxChat.Clear();
        }

        private void ComboBoxSelectLetter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}