using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    class wagons : autotrain
    {
        public Color DopColor { private set; get; }
        public bool second { private set; get; }
        public bool third { private set; get; }
        public bool dontWork { private set; get; }
        public bool Refrigerator { private set; get; }
        public wagons(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool secondWagon, bool thirdWagon, bool backSpoiler, bool refrigerator): base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            second = secondWagon;
            third = thirdWagon;
            dontWork = backSpoiler;
            Refrigerator = refrigerator;
        }
        public override void DrawCar(Graphics g)
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
                g.FillRectangle(brBlue, _startPosX + 401, _startPosY + 10, 170, 100);
            }
            base.DrawCar(g);
        }
    }
}