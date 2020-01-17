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
        private autotrain autotrain;
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
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            autotrain.DrawCar(gr);
            pictureBoxCar.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
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
                    autotrain.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    autotrain.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    autotrain.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    autotrain.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {

            Random rnd = new Random();
            autotrain = new autotrain(rnd.Next(100, 120), rnd.Next(1000, 2000), Color.Green,
           Color.Yellow, true, false, true, false);
            autotrain.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCar.Width,
           pictureBoxCar.Height);
            Draw();

        }
    }
}