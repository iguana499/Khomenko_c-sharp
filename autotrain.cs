using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    class autotrain:Car
    {
		public Color DopColor { private set; get; }
		public bool second { private set; get; }
		public bool third { private set; get; }
		public bool Refrigerator { private set; get; }
		public autotrain(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontSpoiler, bool sideSpoiler, bool backSpoiler) :
        base(maxSpeed, weight, mainColor)
        {
			DopColor = dopColor;
			second = frontSpoiler;
			third = sideSpoiler;
			Refrigerator = backSpoiler;
			Random rnd = new Random();
		}
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override void DrawCar(Graphics g)
        {
			Pen pen = new Pen(Color.Black);
			Brush brBlue = new SolidBrush(MainColor);
			Brush brDark = new SolidBrush(Color.Gray);
			Brush brGray = new SolidBrush(DopColor);
			Brush brBlack = new SolidBrush(Color.Black);
			if (second)
			{
				g.FillRectangle(brGray, _startPosX + 400, _startPosY + 10, 180, 100);
				g.FillRectangle(brGray, _startPosX + 201, _startPosY + 10, 190, 100);
				g.FillRectangle(brDark, _startPosX + 201, _startPosY + 100, 190, 20);
				g.FillEllipse(brBlack, _startPosX + 204, _startPosY + 102, 27, 27);
				g.FillEllipse(brBlack, _startPosX + 330, _startPosY + 102, 27, 27);
				g.FillEllipse(brBlack, _startPosX + 360, _startPosY + 102, 27, 27);
				g.FillRectangle(brBlack, _startPosX + 390, _startPosY + 90, 30, 10);
			}
			if (third)
			{
				g.FillRectangle(brBlue, _startPosX - 1, _startPosY + 10, 190, 100);
				g.FillRectangle(brDark, _startPosX - 1, _startPosY + 100, 190, 20);
				g.FillEllipse(brBlack, _startPosX + 4, _startPosY + 102, 27, 27);
				g.FillEllipse(brBlack, _startPosX + 130, _startPosY + 102, 27, 27);
				g.FillEllipse(brBlack, _startPosX + 160, _startPosY + 102, 27, 27);
				g.FillRectangle(brBlack, _startPosX + 190, _startPosY + 90, 11, 10);
			}
			if (Refrigerator)
			{
				g.FillRectangle(brBlue, _startPosX + 585, _startPosY + 26, 20, 20);
			}
			base.DrawCar(g);
	}
    }
}