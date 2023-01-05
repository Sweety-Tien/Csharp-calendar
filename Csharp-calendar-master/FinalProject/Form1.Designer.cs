namespace FinalProject
{
    partial class Calender
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calender));
            this.tabMonth = new System.Windows.Forms.TabPage();
            this.tabDay = new System.Windows.Forms.TabPage();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.labelToDo = new System.Windows.Forms.Label();
            this.checkBoxToDo = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tabDay.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMonth
            // 
            this.tabMonth.Location = new System.Drawing.Point(4, 25);
            this.tabMonth.Name = "tabMonth";
            this.tabMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonth.Size = new System.Drawing.Size(982, 598);
            this.tabMonth.TabIndex = 0;
            this.tabMonth.Text = "月行事曆";
            // 
            // tabDay
            // 
            this.tabDay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDay.BackgroundImage")));
            this.tabDay.Controls.Add(this.deleteBtn);
            this.tabDay.Controls.Add(this.txtDay);
            this.tabDay.Controls.Add(this.btnRight);
            this.tabDay.Controls.Add(this.btnLeft);
            this.tabDay.Controls.Add(this.labelDate);
            this.tabDay.Controls.Add(this.monthCalendar);
            this.tabDay.Controls.Add(this.labelToDo);
            this.tabDay.Controls.Add(this.checkBoxToDo);
            this.tabDay.Controls.Add(this.btnAdd);
            this.tabDay.Location = new System.Drawing.Point(4, 25);
            this.tabDay.Name = "tabDay";
            this.tabDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDay.Size = new System.Drawing.Size(982, 598);
            this.tabDay.TabIndex = 1;
            this.tabDay.Text = "日行事曆";
            this.tabDay.UseVisualStyleBackColor = true;
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDay.Location = new System.Drawing.Point(338, 78);
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDay.Size = new System.Drawing.Size(613, 493);
            this.txtDay.TabIndex = 61;
            this.txtDay.Text = resources.GetString("txtDay.Text");
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRight.Location = new System.Drawing.Point(380, 19);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(36, 36);
            this.btnRight.TabIndex = 60;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLeft.Location = new System.Drawing.Point(338, 19);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(36, 36);
            this.btnLeft.TabIndex = 59;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDate.Location = new System.Drawing.Point(422, 19);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(133, 43);
            this.labelDate.TabIndex = 58;
            this.labelDate.Text = "2022年";
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monthCalendar.Location = new System.Drawing.Point(26, 153);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 57;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar.TrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.BackColor = System.Drawing.SystemColors.Menu;
            this.labelToDo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelToDo.Location = new System.Drawing.Point(22, 376);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(93, 20);
            this.labelToDo.TabIndex = 56;
            this.labelToDo.Text = "待辦事項";
            // 
            // checkBoxToDo
            // 
            this.checkBoxToDo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxToDo.FormattingEnabled = true;
            this.checkBoxToDo.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4.",
            "5."});
            this.checkBoxToDo.Location = new System.Drawing.Point(26, 407);
            this.checkBoxToDo.Name = "checkBoxToDo";
            this.checkBoxToDo.Size = new System.Drawing.Size(283, 164);
            this.checkBoxToDo.TabIndex = 55;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(26, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(283, 81);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "+加入行程";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabDay);
            this.tab.Controls.Add(this.tabMonth);
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(990, 627);
            this.tab.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 598);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "月計畫";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(26, 106);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(283, 40);
            this.deleteBtn.TabIndex = 62;
            this.deleteBtn.Text = "-移除行程";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 654);
            this.Controls.Add(this.tab);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Calender";
            this.Text = "行事曆";
            this.Load += new System.EventHandler(this.Calender_Load);
            this.tabDay.ResumeLayout(false);
            this.tabDay.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabMonth;
        private System.Windows.Forms.TabPage tabDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.CheckedListBox checkBoxToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button deleteBtn;
    }
}

