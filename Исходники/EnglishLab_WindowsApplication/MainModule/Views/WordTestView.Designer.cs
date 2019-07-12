namespace MainModule.Views
{
    partial class WordTestView
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
            this.toMainView = new System.Windows.Forms.Button();
            this.variant1 = new System.Windows.Forms.Button();
            this.variant2 = new System.Windows.Forms.Button();
            this.variant3 = new System.Windows.Forms.Button();
            this.variant4 = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.Label();
            this.wordBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.play = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toMainView
            // 
            this.toMainView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toMainView.BackColor = System.Drawing.Color.White;
            this.toMainView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toMainView.FlatAppearance.BorderSize = 0;
            this.toMainView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toMainView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toMainView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMainView.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMainView.Image = global::MainModule.Properties.Resources.home;
            this.toMainView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toMainView.Location = new System.Drawing.Point(699, 18);
            this.toMainView.Name = "toMainView";
            this.toMainView.Size = new System.Drawing.Size(126, 39);
            this.toMainView.TabIndex = 16;
            this.toMainView.Text = "На главную";
            this.toMainView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toMainView.UseVisualStyleBackColor = false;
            this.toMainView.Click += new System.EventHandler(this.toMainView_Click);
            // 
            // variant1
            // 
            this.variant1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.tableLayoutPanel1.SetColumnSpan(this.variant1, 2);
            this.variant1.FlatAppearance.BorderSize = 0;
            this.variant1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variant1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant1.ForeColor = System.Drawing.Color.Black;
            this.variant1.Location = new System.Drawing.Point(3, 240);
            this.variant1.Name = "variant1";
            this.variant1.Size = new System.Drawing.Size(392, 73);
            this.variant1.TabIndex = 17;
            this.variant1.Text = "яркий";
            this.variant1.UseVisualStyleBackColor = false;
            this.variant1.Click += new System.EventHandler(this.variant_Click);
            this.variant1.MouseEnter += new System.EventHandler(this.Variant_MouseEnter);
            this.variant1.MouseLeave += new System.EventHandler(this.Variant_MouseLeave);
            // 
            // variant2
            // 
            this.variant2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.variant2.FlatAppearance.BorderSize = 0;
            this.variant2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variant2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant2.ForeColor = System.Drawing.Color.Black;
            this.variant2.Location = new System.Drawing.Point(401, 240);
            this.variant2.Name = "variant2";
            this.variant2.Size = new System.Drawing.Size(399, 73);
            this.variant2.TabIndex = 18;
            this.variant2.Text = "светлый";
            this.variant2.UseVisualStyleBackColor = false;
            this.variant2.Click += new System.EventHandler(this.variant_Click);
            this.variant2.MouseEnter += new System.EventHandler(this.Variant_MouseEnter);
            this.variant2.MouseLeave += new System.EventHandler(this.Variant_MouseLeave);
            // 
            // variant3
            // 
            this.variant3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.tableLayoutPanel1.SetColumnSpan(this.variant3, 2);
            this.variant3.FlatAppearance.BorderSize = 0;
            this.variant3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variant3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant3.ForeColor = System.Drawing.Color.Black;
            this.variant3.Location = new System.Drawing.Point(3, 319);
            this.variant3.Name = "variant3";
            this.variant3.Size = new System.Drawing.Size(392, 76);
            this.variant3.TabIndex = 19;
            this.variant3.Text = "розовый";
            this.variant3.UseVisualStyleBackColor = false;
            this.variant3.Click += new System.EventHandler(this.variant_Click);
            this.variant3.MouseEnter += new System.EventHandler(this.Variant_MouseEnter);
            this.variant3.MouseLeave += new System.EventHandler(this.Variant_MouseLeave);
            // 
            // variant4
            // 
            this.variant4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.variant4.FlatAppearance.BorderSize = 0;
            this.variant4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.variant4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variant4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant4.ForeColor = System.Drawing.Color.Black;
            this.variant4.Location = new System.Drawing.Point(401, 319);
            this.variant4.Name = "variant4";
            this.variant4.Size = new System.Drawing.Size(399, 76);
            this.variant4.TabIndex = 20;
            this.variant4.Text = "сияющий";
            this.variant4.UseVisualStyleBackColor = false;
            this.variant4.Click += new System.EventHandler(this.variant_Click);
            this.variant4.MouseEnter += new System.EventHandler(this.Variant_MouseEnter);
            this.variant4.MouseLeave += new System.EventHandler(this.Variant_MouseLeave);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.descriptionBox, 3);
            this.descriptionBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.ForeColor = System.Drawing.Color.Green;
            this.descriptionBox.Location = new System.Drawing.Point(3, 156);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(797, 81);
            this.descriptionBox.TabIndex = 22;
            this.descriptionBox.Text = "Description";
            this.descriptionBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wordBox
            // 
            this.wordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.wordBox, 2);
            this.wordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordBox.ForeColor = System.Drawing.Color.Navy;
            this.wordBox.Location = new System.Drawing.Point(383, 0);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(417, 156);
            this.wordBox.TabIndex = 21;
            this.wordBox.Text = "light";
            this.wordBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.366127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31133F));
            this.tableLayoutPanel1.Controls.Add(this.play, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.variant2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.wordBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.variant4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.variant1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.variant3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.descriptionBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.55024F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.44976F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 398);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Image = global::MainModule.Properties.Resources.speaker;
            this.play.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.play.Location = new System.Drawing.Point(3, 3);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(374, 150);
            this.play.TabIndex = 23;
            this.play.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // WordTestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toMainView);
            this.Name = "WordTestView";
            this.Size = new System.Drawing.Size(846, 496);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toMainView;
        private System.Windows.Forms.Button variant1;
        private System.Windows.Forms.Button variant2;
        private System.Windows.Forms.Button variant3;
        private System.Windows.Forms.Button variant4;
        private System.Windows.Forms.Label descriptionBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label wordBox;
        private System.Windows.Forms.Button play;
    }
}
