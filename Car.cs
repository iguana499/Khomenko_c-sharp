using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    public class Car : Vehicle , IComparable<Car>, IEquatable<Car>
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;
        public Car(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Car(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush warCar = new SolidBrush(MainColor);
            Brush blackBrush = new SolidBrush(Color.Black);
            g.FillRectangle(warCar, _startPosX + 60, _startPosY + 35, 50, 45);
            g.FillRectangle(blackBrush, _startPosX + 80, _startPosY + 40, 30, 30);
            g.FillRectangle(warCar, _startPosX - 20, _startPosY + 30, 80, 50);
            g.DrawRectangle(pen, _startPosX - 20, _startPosY + 30, 80, 50);
            g.DrawRectangle(pen, _startPosX - 15, _startPosY + 35, 60, 30);
            g.DrawRectangle(pen, _startPosX + 60, _startPosY + 35, 50, 45);
            g.FillEllipse(blackBrush, _startPosX - 18, _startPosY + 70, 40, 40);
            g.FillEllipse(blackBrush, _startPosX + 55, _startPosY + 70, 40, 40);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public int CompareTo(Car other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        public bool Equals(Car other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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
            if (!(obj is Car carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}