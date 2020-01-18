using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    class autotrain : Car , IComparable<autotrain>, IEquatable<autotrain>
    {
        public Color DopColor { private set; get; }
        public bool second { private set; get; }
        public bool third { private set; get; }
        public bool Refrigerator { private set; get; }
        private int _countLines;
        public int CountLines
        {
            set
            {
                if (value > 0 && value < 4) _countLines = value;
            }
            get { return _countLines; }
        }
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
        public autotrain(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                second = Convert.ToBoolean(strs[4]);
                Refrigerator = Convert.ToBoolean(strs[5]);
                third = Convert.ToBoolean(strs[6]);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            if (second)
            {
                Brush brFirstGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);
                g.FillRectangle(brFirstGun, _startPosX + 5, _startPosY + 10, 85, 10);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);
            }
            if (third)
            {
                Brush brSecondGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 85, 6);
                g.FillRectangle(brSecondGun, _startPosX + 5, _startPosY + 40, 85, 6);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 85, 6);

            }
            if (Refrigerator)
            {
                Brush brThirdGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX - 35, _startPosY + 32, 80, 6);
                g.FillRectangle(brThirdGun, _startPosX - 35, _startPosY + 32, 80, 6);
                g.DrawRectangle(pen, _startPosX - 35, _startPosY + 32, 80, 6);
            }
            Brush brTank = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 5, 20, 10);
            g.FillRectangle(brTank, _startPosX + 10, _startPosY - 5, 20, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);
            g.FillEllipse(brTank, _startPosX, _startPosY, 52, 31);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);
            base.DrawCar(g);
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + second + ";" +
           third + ";" + Refrigerator+";0";
        }
        public int CompareTo(autotrain other)
        {
            var res = (this is Car).CompareTo(other is Car);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (second != other.second)
            {
                return second.CompareTo(other.second);
            }
            if (third != other.third)
            {
                return third.CompareTo(other.third);
            }
            if (Refrigerator != other.Refrigerator)
            {
                return Refrigerator.CompareTo(other.Refrigerator);
            }
            return 0;
        }
        public bool Equals(autotrain other)
        {
            var res = (this as Car).Equals(other as Car);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (second != other.second)
            {
                return false;
            }
 
            if (third != other.third)
            {
                return false;
            }
            if (Refrigerator != other.Refrigerator)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is autotrain carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}