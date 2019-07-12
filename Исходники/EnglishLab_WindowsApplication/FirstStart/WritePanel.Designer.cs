namespace FirstStart
{
    partial class WritePanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.answer = new System.Windows.Forms.TextBox();
            this.next = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.browser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.answer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.next, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 288);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // browser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.browser, 2);
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.IsWebBrowserContextMenuEnabled = false;
            this.browser.Location = new System.Drawing.Point(3, 3);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScrollBarsEnabled = false;
            this.browser.Size = new System.Drawing.Size(373, 244);
            this.browser.TabIndex = 0;
            this.browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browser_Navigated);
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.answer.Location = new System.Drawing.Point(3, 253);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(272, 32);
            this.answer.TabIndex = 1;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Location = new System.Drawing.Point(281, 253);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(95, 32);
            this.next.TabIndex = 2;
            this.next.Text = "Далее";
            // 
            // WritePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WritePanel";
            this.Size = new System.Drawing.Size(379, 288);
            this.VisibleChanged += new System.EventHandler(this.WritePanel_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.TextBox answer;
        private MetroFramework.Controls.MetroButton next;
    }
}
