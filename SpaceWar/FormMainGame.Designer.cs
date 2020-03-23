namespace SpaceWar
{
    partial class FormMainGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainGame));
            this.pictureBoxMyShip = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyShip = new System.Windows.Forms.PictureBox();
            this.timerEnemyShip = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMyShip
            // 
            this.pictureBoxMyShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyShip.Image")));
            this.pictureBoxMyShip.Location = new System.Drawing.Point(456, 399);
            this.pictureBoxMyShip.Name = "pictureBoxMyShip";
            this.pictureBoxMyShip.Size = new System.Drawing.Size(61, 68);
            this.pictureBoxMyShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyShip.TabIndex = 0;
            this.pictureBoxMyShip.TabStop = false;
            // 
            // pictureBoxEnemyShip
            // 
            this.pictureBoxEnemyShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyShip.Image")));
            this.pictureBoxEnemyShip.Location = new System.Drawing.Point(313, 34);
            this.pictureBoxEnemyShip.Name = "pictureBoxEnemyShip";
            this.pictureBoxEnemyShip.Size = new System.Drawing.Size(61, 68);
            this.pictureBoxEnemyShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyShip.TabIndex = 1;
            this.pictureBoxEnemyShip.TabStop = false;
            // 
            // timerEnemyShip
            // 
            this.timerEnemyShip.Enabled = true;
            this.timerEnemyShip.Interval = 10;
            this.timerEnemyShip.Tick += new System.EventHandler(this.timerEnemyShip_Tick);
            // 
            // FormMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(911, 516);
            this.Controls.Add(this.pictureBoxEnemyShip);
            this.Controls.Add(this.pictureBoxMyShip);
            this.KeyPreview = true;
            this.Name = "FormMainGame";
            this.Text = "Космические войны";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMainGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMainGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMyShip;
        private System.Windows.Forms.PictureBox pictureBoxEnemyShip;
        private System.Windows.Forms.Timer timerEnemyShip;
    }
}

