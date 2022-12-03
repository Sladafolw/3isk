namespace AI_LW3
{
    internal class PictureBoxArtist
    {
        private readonly PictureBox pictureBox;
        private readonly Pen pen;
        private readonly double scale;
        private readonly int width;
        private readonly int height;
        private Bitmap bitmap;
        private Graphics graphics;
        private Point lastPoint;
        private bool isDrawing;
        
        public PictureBoxArtist(PictureBox pictureBox, double scale, Pen pen)
        {
            this.pictureBox = pictureBox;
            this.pen = pen;
            this.scale = scale;
            isDrawing = false;
            width = Convert.ToInt32(pictureBox.Width * scale);
            height = Convert.ToInt32(pictureBox.Height * scale);
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            lastPoint = new();
        }

        public void StartDrawing(Point startPoint)
        {
            int x = Convert.ToInt32(startPoint.X * scale);
            int y = Convert.ToInt32(startPoint.Y * scale);

            lastPoint = new(x, y);
            isDrawing = true;
            Drawing(startPoint);
        }

        public void Clear()
        {
            graphics = Graphics.FromImage(bitmap = new Bitmap(width, height));
            pictureBox.Image = bitmap;
        }

        public void Drawing(Point toPoint)
        {
            if (!isDrawing)
            {
                return;
            }

            int x = Convert.ToInt32(toPoint.X * scale);
            int y = Convert.ToInt32(toPoint.Y * scale);
            Point scaledToPoint = new(x, y);

            graphics.DrawLine(pen, lastPoint, scaledToPoint);
            pictureBox.Image = bitmap;
            lastPoint = scaledToPoint;
        }

        public void EndDrawing()
        {
            isDrawing = false;
        }

        public void SaveTo(string path)
        {
            bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
