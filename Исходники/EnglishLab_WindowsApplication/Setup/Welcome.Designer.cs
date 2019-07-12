namespace Setup
{
    partial class Welcome
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.openDialog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.next = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вас приветствует программа установки \r\nприложения для изучения английского языка " +
    "\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(127, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Расположение: \r";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path.Location = new System.Drawing.Point(252, 308);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(316, 29);
            this.path.TabIndex = 4;
            this.path.Text = "C:\\Program Files (x86)";
            // 
            // openDialog
            // 
            this.openDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDialog.Image = global::Setup.Properties.Resources.folder__2_;
            this.openDialog.Location = new System.Drawing.Point(574, 308);
            this.openDialog.Name = "openDialog";
            this.openDialog.Size = new System.Drawing.Size(34, 29);
            this.openDialog.TabIndex = 5;
            this.openDialog.UseVisualStyleBackColor = true;
            this.openDialog.Click += new System.EventHandler(this.openDialog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Setup.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(264, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(296, 356);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(166, 41);
            this.next.TabIndex = 0;
            this.next.Text = "Продолжить";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Выберите папку, куда будет произведено копирование файлов, обеспечивающих работу " +
    "приложения. Этот параметр можно оставить по умолчанию.";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.info.Location = new System.Drawing.Point(14, 401);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(28, 13);
            this.info.TabIndex = 6;
            this.info.Text = "info";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.info);
            this.Controls.Add(this.next);
            this.Controls.Add(this.openDialog);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(734, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openDialog;
        private MetroFramework.Controls.MetroButton next;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label info;
        public System.Windows.Forms.TextBox path;
    }
}
