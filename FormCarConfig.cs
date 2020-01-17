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
    public partial class FormCarConfig : Form


    {

        private event carDelegate eventAddCar;

        ITransport car = null;
        public FormCarConfig()
        {
           
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };

        }


        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(40, 5, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawCar(gr);
                pictureBoxCar.Image = bmp;
            }
        }

        private void labelCar_MouseDown(object sender, MouseEventArgs e)
        {

            labelCar.DoDragDrop(labelCar.Text, DragDropEffects.Move |
            DragDropEffects.Copy);

        }

        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {

            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Тягач":
                    car = new Car(100, 500, Color.White);
                    break;
                case "Автопоезд":
                    car = new autotrain(100, 500, Color.White, Color.Black, true, true,
                   true);
                    break;
            }
            DrawCar();

        }

        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }




        }

        private void labelSportCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelSportCar.DoDragDrop(labelSportCar.Text, DragDropEffects.Move |
                DragDropEffects.Copy);

        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }


        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            

            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }




        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is autotrain)
                {
                    (car as autotrain).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }


        public void AddEvent(carDelegate ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new carDelegate(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}