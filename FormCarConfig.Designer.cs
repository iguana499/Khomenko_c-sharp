namespace PT_lab_1
{
    partial class FormCarConfig
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
			this.pictureBoxCar = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelCar = new System.Windows.Forms.Label();
			this.labelSportCar = new System.Windows.Forms.Label();
			this.panelCar = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelGray = new System.Windows.Forms.Panel();
			this.panelGold = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panelCar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxCar
			// 
			this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCar.Location = new System.Drawing.Point(18, 45);
			this.pictureBoxCar.Name = "pictureBoxCar";
			this.pictureBoxCar.Size = new System.Drawing.Size(650, 235);
			this.pictureBoxCar.TabIndex = 0;
			this.pictureBoxCar.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelCar);
			this.groupBox1.Controls.Add(this.labelSportCar);
			this.groupBox1.Location = new System.Drawing.Point(12, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(169, 166);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// labelCar
			// 
			this.labelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCar.Location = new System.Drawing.Point(19, 67);
			this.labelCar.Name = "labelCar";
			this.labelCar.Size = new System.Drawing.Size(126, 37);
			this.labelCar.TabIndex = 2;
			this.labelCar.Text = "Тягач";
			this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
			// 
			// labelSportCar
			// 
			this.labelSportCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSportCar.Location = new System.Drawing.Point(22, 113);
			this.labelSportCar.Name = "labelSportCar";
			this.labelSportCar.Size = new System.Drawing.Size(123, 40);
			this.labelSportCar.TabIndex = 3;
			this.labelSportCar.Text = "Автопоезд";
			this.labelSportCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSportCar_MouseDown);
			// 
			// panelCar
			// 
			this.panelCar.AllowDrop = true;
			this.panelCar.Controls.Add(this.labelDopColor);
			this.panelCar.Controls.Add(this.labelBaseColor);
			this.panelCar.Controls.Add(this.pictureBoxCar);
			this.panelCar.Location = new System.Drawing.Point(196, 34);
			this.panelCar.Name = "panelCar";
			this.panelCar.Size = new System.Drawing.Size(690, 388);
			this.panelCar.TabIndex = 2;
			this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
			this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(18, 349);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(131, 33);
			this.labelDopColor.TabIndex = 2;
			this.labelDopColor.Text = "Дополнительный цвет";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(18, 304);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(131, 34);
			this.labelBaseColor.TabIndex = 1;
			this.labelBaseColor.Text = "Основной цвет";
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.Location = new System.Drawing.Point(1084, 59);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(55, 46);
			this.panelBlack.TabIndex = 3;
			// 
			// panelWhite
			// 
			this.panelWhite.BackColor = System.Drawing.Color.White;
			this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWhite.Location = new System.Drawing.Point(1169, 59);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(54, 45);
			this.panelWhite.TabIndex = 4;
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.Green;
			this.panelGreen.Location = new System.Drawing.Point(1084, 127);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(54, 46);
			this.panelGreen.TabIndex = 5;
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.Location = new System.Drawing.Point(1169, 127);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(53, 45);
			this.panelBlue.TabIndex = 6;
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panelRed.Location = new System.Drawing.Point(1087, 190);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(52, 47);
			this.panelRed.TabIndex = 7;
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.Location = new System.Drawing.Point(1169, 191);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(53, 46);
			this.panelYellow.TabIndex = 8;
			// 
			// panelGray
			// 
			this.panelGray.BackColor = System.Drawing.Color.Gray;
			this.panelGray.Location = new System.Drawing.Point(1087, 255);
			this.panelGray.Name = "panelGray";
			this.panelGray.Size = new System.Drawing.Size(52, 42);
			this.panelGray.TabIndex = 9;
			// 
			// panelGold
			// 
			this.panelGold.BackColor = System.Drawing.Color.Gold;
			this.panelGold.Location = new System.Drawing.Point(1169, 255);
			this.panelGold.Name = "panelGold";
			this.panelGold.Size = new System.Drawing.Size(53, 42);
			this.panelGold.TabIndex = 10;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(71, 305);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(119, 41);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(58, 210);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(124, 47);
			this.buttonAdd.TabIndex = 12;
			this.buttonAdd.Text = "добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// FormCarConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1235, 496);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.panelGold);
			this.Controls.Add(this.panelGray);
			this.Controls.Add(this.panelYellow);
			this.Controls.Add(this.panelRed);
			this.Controls.Add(this.panelBlue);
			this.Controls.Add(this.panelGreen);
			this.Controls.Add(this.panelWhite);
			this.Controls.Add(this.panelBlack);
			this.Controls.Add(this.panelCar);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCarConfig";
			this.Text = "FormCarConfig";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.panelCar.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelSportCar;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}