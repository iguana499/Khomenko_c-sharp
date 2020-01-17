using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    class autotrain
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int autotrainWidth = 701;
        private const int autotrainHeight = 200;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool second { private set; get; }
        public bool third { private set; get; }
        public bool dontWork { private set; get; }
        public bool Refrigerator { private set; get; }
        public autotrain(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool secondWagon, bool thirdWagon, bool backSpoiler, bool refrigerator)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            second = secondWagon;
            third = thirdWagon;
            dontWork = backSpoiler;
           Refrigerator = refrigerator;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - autotrainWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - autotrainHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlack = new SolidBrush(Color.Black);
            if (second)
            {
                g.FillRectangle(brBlue, _startPosX + 201, _startPosY + 10, 190, 100);
                g.FillRectangle(brGray, _startPosX + 201, _startPosY + 100, 190, 20);
                g.FillEllipse(brBlack, _startPosX + 204, _startPosY + 102, 27, 27);
                g.FillEllipse(brBlack, _startPosX + 330, _startPosY + 102, 27, 27);
                g.FillEllipse(brBlack, _startPosX + 360, _startPosY + 102, 27, 27);
                g.FillRectangle(brBlack, _startPosX + 390, _startPosY + 90, 30, 10);
            }
            if (third)
            {
                g.FillRectangle(brBlue, _startPosX - 1, _startPosY + 10, 190, 100);
                g.FillRectangle(brGray, _startPosX - 1, _startPosY + 100, 190, 20);
                g.FillEllipse(brBlack, _startPosX + 4, _startPosY + 102, 27, 27);
                g.FillEllipse(brBlack, _startPosX + 130, _startPosY + 102, 27, 27);
                g.FillEllipse(brBlack, _startPosX + 160, _startPosY + 102, 27, 27);
                g.FillRectangle(brBlack, _startPosX + 190, _startPosY + 90, 11, 10);
            }
            if (Refrigerator)
            {
                g.FillRectangle(brBlue, _startPosX + 585, _startPosY + 26, 20, 20);
            }
            g.FillRectangle(brBlue, _startPosX + 400, _startPosY + 10, 180, 100);
            g.FillRectangle(brBlue, _startPosX + 585, _startPosY + 50, 60, 60);
            g.FillRectangle(brGray, _startPosX + 400, _startPosY + 100, 245, 20);
            g.FillEllipse(brBlack, _startPosX + 404, _startPosY + 102, 27, 27);
            g.FillEllipse(brBlack, _startPosX + 530, _startPosY + 102, 27, 27);
            g.FillEllipse(brBlack, _startPosX + 560, _startPosY + 102, 27, 27);
            g.FillEllipse(brBlack, _startPosX + 615, _startPosY + 102, 27, 27);
        }
    }
}
