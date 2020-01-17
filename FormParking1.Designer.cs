namespace PT_lab_1
{
    partial class FormParking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetCar = new System.Windows.Forms.Button();
            this.buttonSetSportCar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 1);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(550, 413);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(630, 143);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(98, 41);
            this.buttonSetCar.TabIndex = 1;
            this.buttonSetCar.Text = "припарковать автомобиль";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click_1);
            // 
            // buttonSetSportCar
            // 
            this.buttonSetSportCar.Location = new System.Drawing.Point(632, 212);
            this.buttonSetSportCar.Name = "buttonSetSportCar";
            this.buttonSetSportCar.Size = new System.Drawing.Size(95, 45);
            this.buttonSetSportCar.TabIndex = 2;
            this.buttonSetSportCar.Text = "припарковать гоночный автомобиль";
            this.buttonSetSportCar.UseVisualStyleBackColor = true;
            this.buttonSetSportCar.Click += new System.EventHandler(this.buttonSetSportCar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeCar);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(633, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "забрать машину";
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(27, 67);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(67, 21);
            this.buttonTakeCar.TabIndex = 2;
            this.buttonTakeCar.Text = "забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click_1);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(72, 26);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(23, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " место";
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(632, 370);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(768, 273);
            this.pictureBoxTakeCar.TabIndex = 4;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(597, 25);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(149, 95);
            this.listBoxLevels.TabIndex = 5;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 655);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeCar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetSportCar);
            this.Controls.Add(this.buttonSetCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetCar;
        private System.Windows.Forms.Button buttonSetSportCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}