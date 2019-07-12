namespace Setup
{
    partial class ProcessSetup
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.next = new System.Windows.Forms.Button();
            this.logger = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(3, 223);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(728, 23);
            this.progress.TabIndex = 1;
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Enabled = false;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(313, 382);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(107, 29);
            this.next.TabIndex = 2;
            this.next.Text = "Готово";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // logger
            // 
            this.logger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logger.Location = new System.Drawing.Point(3, 262);
            this.logger.Multiline = true;
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            this.logger.Size = new System.Drawing.Size(728, 114);
            this.logger.TabIndex = 3;
            this.logger.TextChanged += new System.EventHandler(this.logger_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Setup.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(260, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ProcessSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.next);
            this.Controls.Add(this.progress);
            this.Name = "ProcessSetup";
            this.Size = new System.Drawing.Size(734, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox logger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
