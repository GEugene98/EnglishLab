namespace MainModule.Views
{
    partial class WordCardsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCardsView));
            this.wordBox = new System.Windows.Forms.Label();
            this.translationBox = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.userKnows = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.toMainView = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordBox
            // 
            this.wordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.wordBox, 3);
            this.wordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordBox.ForeColor = System.Drawing.Color.Navy;
            this.wordBox.Location = new System.Drawing.Point(3, 84);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(723, 52);
            this.wordBox.TabIndex = 11;
            this.wordBox.Text = "Word";
            this.wordBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translationBox
            // 
            this.translationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.translationBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.translationBox, 3);
            this.translationBox.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translationBox.ForeColor = System.Drawing.Color.Purple;
            this.translationBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.translationBox.Location = new System.Drawing.Point(3, 188);
            this.translationBox.Name = "translationBox";
            this.translationBox.Size = new System.Drawing.Size(723, 52);
            this.translationBox.TabIndex = 12;
            this.translationBox.Text = "Translation";
            this.translationBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.descriptionBox.Location = new System.Drawing.Point(3, 136);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(723, 52);
            this.descriptionBox.TabIndex = 13;
            this.descriptionBox.Text = "Description";
            this.descriptionBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.previous, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.translationBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.descriptionBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.next, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.userKnows, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.play, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 338);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // previous
            // 
            this.previous.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Image = global::MainModule.Properties.Resources.left_arrow;
            this.previous.Location = new System.Drawing.Point(3, 243);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(236, 92);
            this.previous.TabIndex = 0;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Image = global::MainModule.Properties.Resources.right_arrow;
            this.next.Location = new System.Drawing.Point(487, 243);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(239, 92);
            this.next.TabIndex = 1;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // userKnows
            // 
            this.userKnows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userKnows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userKnows.FlatAppearance.BorderSize = 0;
            this.userKnows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.userKnows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.userKnows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userKnows.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userKnows.Image = global::MainModule.Properties.Resources.light_bulb;
            this.userKnows.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userKnows.Location = new System.Drawing.Point(245, 243);
            this.userKnows.Name = "userKnows";
            this.userKnows.Size = new System.Drawing.Size(236, 92);
            this.userKnows.TabIndex = 14;
            this.userKnows.Text = "Я знаю это слово!";
            this.userKnows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userKnows.UseVisualStyleBackColor = true;
            this.userKnows.Click += new System.EventHandler(this.userKnows_Click);
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Image = global::MainModule.Properties.Resources.speaker;
            this.play.Location = new System.Drawing.Point(245, 3);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(236, 78);
            this.play.TabIndex = 2;
            this.play.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.BackColor = System.Drawing.Color.White;
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print.Image = global::MainModule.Properties.Resources.printer;
            this.print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print.Location = new System.Drawing.Point(468, 15);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(155, 39);
            this.print.TabIndex = 16;
            this.print.Text = "Печать карточек";
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
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
            this.toMainView.Location = new System.Drawing.Point(629, 15);
            this.toMainView.Name = "toMainView";
            this.toMainView.Size = new System.Drawing.Size(126, 39);
            this.toMainView.TabIndex = 15;
            this.toMainView.Text = "На главную";
            this.toMainView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toMainView.UseVisualStyleBackColor = false;
            this.toMainView.Click += new System.EventHandler(this.toMainView_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // WordCardsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.print);
            this.Controls.Add(this.toMainView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WordCardsView";
            this.Size = new System.Drawing.Size(793, 456);
            this.Load += new System.EventHandler(this.WordCardsView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label translationBox;
        private System.Windows.Forms.Label wordBox;
        private System.Windows.Forms.Label descriptionBox;
        private System.Windows.Forms.Button userKnows;
        private System.Windows.Forms.Button toMainView;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}
