using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    public class autotrain : Vehicle
    {
        protected const int tankWidth = 701;
        protected const int tankHeight = 200;
        public autotrain(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - tankWidth)
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
                    if (_startPosY + step < _pictureHeight - tankHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlue = new SolidBrush(MainColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillRectangle(brBlue, _startPosX + 585, _startPosY + 50, 60, 60);
            g.FillRectangle(brGray, _startPosX + 400, _startPosY + 100, 245, 20);
            g.FillEllipse(brBlack, _startPosX + 404, _startPosY + 102, 27, 27);
            g.FillEllipse(brBlack, _startPosX + 530, _startPosY + 102, 27, 27);
            g.FillEllipse(brBlack, _startPosX + 560, _startPosY + 102, 27, 27);
            g.FillEllipse(brBlack, _startPosX + 615, _startPosY + 102, 27, 27);
            g.FillRectangle(brBlue, _startPosX + 585, _startPosY + 26, 20, 20);
        }
    }
}