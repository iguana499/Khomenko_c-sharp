﻿using NLog;
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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;



        FormCarConfig form;


        private Logger logger;


        public FormParking()

        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();


            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт
             // не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу
             //listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
       
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();

        }

        private void buttonSetCar_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Car(100, 1000, dialog.Color);
                    int place = parking[listBoxLevels.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }

        }

        private void buttonSetSportCar_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {

                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new autotrain(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTakeCar_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var car = parking[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                       pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(5, 5, pictureBoxTakeCar.Width,
                       pictureBoxTakeCar.Height);
                        car.DrawCar(gr);
                        pictureBoxTakeCar.Image = bmp;
                        logger.Info("Изъят автомобиль " + car.ToString() + " с места "
                       + maskedTextBox.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        logger.Error("Не найдено");
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                       pictureBoxTakeCar.Height);
                        pictureBoxTakeCar.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error("Неизвестная ошибка");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddCar(ITransport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + car;
                    logger.Info("Добавлен автомобиль " + car.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Error("Переполнениe");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddCar);
            form.Show();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error("Unknown error while saving");
                    MessageBox.Show(ex.Message, "Unknown error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Error("Garages occupied place");
                    MessageBox.Show(ex.Message, "Place taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Unknown error while upload");
                    MessageBox.Show(ex.Message, "Unknown error while upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }      
    }
}