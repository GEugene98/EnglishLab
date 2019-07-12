namespace FirstStart.Views
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.skip = new MetroFramework.Controls.MetroLink();
            this.end = new MetroFramework.Controls.MetroLink();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.panelForQuestion = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.53992F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.46008F));
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.metroButton1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 149);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(279, 34);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(188, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 28);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Далее";
            // 
            // skip
            // 
            this.skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skip.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.skip.Location = new System.Drawing.Point(624, 459);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(147, 23);
            this.skip.Style = MetroFramework.MetroColorStyle.Blue;
            this.skip.TabIndex = 3;
            this.skip.Text = "Пропустить вопрос";
            this.skip.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.skip.UseStyleColors = true;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // end
            // 
            this.end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.end.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.end.Location = new System.Drawing.Point(3, 459);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(117, 23);
            this.end.Style = MetroFramework.MetroColorStyle.Red;
            this.end.TabIndex = 2;
            this.end.Text = "Завершить тест";
            this.end.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.end.UseStyleColors = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.46012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.53988F));
            this.tableLayoutPanel1.Controls.Add(this.end, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.skip, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.progress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.status, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelForQuestion, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.227848F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 485);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // progress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progress, 2);
            this.progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress.Location = new System.Drawing.Point(3, 3);
            this.progress.Name = "progress";
            this.progress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progress.Size = new System.Drawing.Size(768, 14);
            this.progress.Step = 1;
            this.progress.Style = MetroFramework.MetroColorStyle.Red;
            this.progress.TabIndex = 4;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.status, 2);
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.status.Location = new System.Drawing.Point(3, 20);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(768, 24);
            this.status.TabIndex = 5;
            this.status.Text = "status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForQuestion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelForQuestion, 2);
            this.panelForQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForQuestion.Location = new System.Drawing.Point(3, 47);
            this.panelForQuestion.Name = "panelForQuestion";
            this.panelForQuestion.Size = new System.Drawing.Size(768, 398);
            this.panelForQuestion.TabIndex = 6;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(814, 535);
            this.Name = "Test";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Тест";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test_FormClosed);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink skip;
        private MetroFramework.Controls.MetroLink end;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroProgressBar progress;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panelForQuestion;
    }
}