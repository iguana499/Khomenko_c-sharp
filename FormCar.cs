using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_lab_1
{
    public partial class FormCar : Form
    {

        private ITransport car;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormCar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        /// 
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxCar.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Обработка нажатия кнопки "Создать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();


        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new wagons(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
           Color.Yellow, true, true, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCar.Width,
           pictureBoxCar.Height);
            Draw();

        }

        private void ButtonCreateCar_Click_1(object sender, EventArgs e)
        {

            Random rnd = new Random();
            car = new autotrain(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCar.Width,
           pictureBoxCar.Height);
            Draw();
        }
    }
}