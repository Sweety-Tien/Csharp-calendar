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
            this.googleBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMon = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSun = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSat = new System.Windows.Forms.CheckedListBox();
            this.checkBoxFri = new System.Windows.Forms.CheckedListBox();
            this.checkBoxThur = new System.Windows.Forms.CheckedListBox();
            this.checkBoxWed = new System.Windows.Forms.CheckedListBox();
            this.checkBoxTue = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteWeek = new System.Windows.Forms.Button();
            this.btnAddWeek = new System.Windows.Forms.Button();
            this.labelSun = new System.Windows.Forms.Label();
            this.labelThur = new System.Windows.Forms.Label();
            this.labelFri = new System.Windows.Forms.Label();
            this.labelwed = new System.Windows.Forms.Label();
            this.labelTue = new System.Windows.Forms.Label();
            this.labelSat = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabDay.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMonth
            // 
            this.tabMonth.Location = new System.Drawing.Point(4, 28);
            this.tabMonth.Name = "tabMonth";
            this.tabMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonth.Size = new System.Drawing.Size(982, 595);
            this.tabMonth.TabIndex = 0;
            this.tabMonth.Text = "月行事曆";
            this.tabMonth.Enter += new System.EventHandler(this.tabMonth_Enter);
            // 
            // tabDay
            // 
            this.tabDay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDay.BackgroundImage")));
            this.tabDay.Controls.Add(this.googleBtn);
            this.tabDay.Controls.Add(this.deleteBtn);
            this.tabDay.Controls.Add(this.txtDay);
            this.tabDay.Controls.Add(this.btnRight);
            this.tabDay.Controls.Add(this.btnLeft);
            this.tabDay.Controls.Add(this.labelDate);
            this.tabDay.Controls.Add(this.monthCalendar);
            this.tabDay.Controls.Add(this.labelToDo);
            this.tabDay.Controls.Add(this.checkBoxToDo);
            this.tabDay.Controls.Add(this.btnAdd);
            this.tabDay.Location = new System.Drawing.Point(4, 28);
            this.tabDay.Name = "tabDay";
            this.tabDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDay.Size = new System.Drawing.Size(982, 595);
            this.tabDay.TabIndex = 1;
            this.tabDay.Text = "日行事曆";
            this.tabDay.UseVisualStyleBackColor = true;
            // 
            // googleBtn
            // 
            this.googleBtn.Location = new System.Drawing.Point(876, 29);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.Size = new System.Drawing.Size(75, 23);
            this.googleBtn.TabIndex = 63;
            this.googleBtn.Text = "Google";
            this.googleBtn.UseVisualStyleBackColor = true;
            this.googleBtn.Click += new System.EventHandler(this.googleBtn_Click);
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
            this.labelDate.Size = new System.Drawing.Size(158, 50);
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
            this.labelToDo.Size = new System.Drawing.Size(110, 24);
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
            this.checkBoxToDo.Size = new System.Drawing.Size(283, 148);
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
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBoxMon);
            this.tabPage1.Controls.Add(this.checkBoxSun);
            this.tabPage1.Controls.Add(this.checkBoxSat);
            this.tabPage1.Controls.Add(this.checkBoxFri);
            this.tabPage1.Controls.Add(this.checkBoxThur);
            this.tabPage1.Controls.Add(this.checkBoxWed);
            this.tabPage1.Controls.Add(this.checkBoxTue);
            this.tabPage1.Controls.Add(this.btnDeleteWeek);
            this.tabPage1.Controls.Add(this.btnAddWeek);
            this.tabPage1.Controls.Add(this.labelSun);
            this.tabPage1.Controls.Add(this.labelThur);
            this.tabPage1.Controls.Add(this.labelFri);
            this.tabPage1.Controls.Add(this.labelwed);
            this.tabPage1.Controls.Add(this.labelTue);
            this.tabPage1.Controls.Add(this.labelSat);
            this.tabPage1.Controls.Add(this.labelMon);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 595);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "月計畫";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 50);
            this.label1.TabIndex = 36;
            this.label1.Text = "Week Plan";
            // 
            // checkBoxMon
            // 
            this.checkBoxMon.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxMon.FormattingEnabled = true;
            this.checkBoxMon.Location = new System.Drawing.Point(269, 45);
            this.checkBoxMon.Name = "checkBoxMon";
            this.checkBoxMon.Size = new System.Drawing.Size(206, 236);
            this.checkBoxMon.TabIndex = 35;
            // 
            // checkBoxSun
            // 
            this.checkBoxSun.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxSun.FormattingEnabled = true;
            this.checkBoxSun.Location = new System.Drawing.Point(750, 332);
            this.checkBoxSun.Name = "checkBoxSun";
            this.checkBoxSun.Size = new System.Drawing.Size(206, 236);
            this.checkBoxSun.TabIndex = 34;
            // 
            // checkBoxSat
            // 
            this.checkBoxSat.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxSat.FormattingEnabled = true;
            this.checkBoxSat.Location = new System.Drawing.Point(509, 332);
            this.checkBoxSat.Name = "checkBoxSat";
            this.checkBoxSat.Size = new System.Drawing.Size(206, 236);
            this.checkBoxSat.TabIndex = 33;
            // 
            // checkBoxFri
            // 
            this.checkBoxFri.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxFri.FormattingEnabled = true;
            this.checkBoxFri.Location = new System.Drawing.Point(269, 332);
            this.checkBoxFri.Name = "checkBoxFri";
            this.checkBoxFri.Size = new System.Drawing.Size(206, 236);
            this.checkBoxFri.TabIndex = 32;
            // 
            // checkBoxThur
            // 
            this.checkBoxThur.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxThur.FormattingEnabled = true;
            this.checkBoxThur.Location = new System.Drawing.Point(27, 332);
            this.checkBoxThur.Name = "checkBoxThur";
            this.checkBoxThur.Size = new System.Drawing.Size(206, 236);
            this.checkBoxThur.TabIndex = 31;
            // 
            // checkBoxWed
            // 
            this.checkBoxWed.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxWed.FormattingEnabled = true;
            this.checkBoxWed.Location = new System.Drawing.Point(750, 45);
            this.checkBoxWed.Name = "checkBoxWed";
            this.checkBoxWed.Size = new System.Drawing.Size(206, 236);
            this.checkBoxWed.TabIndex = 30;
            // 
            // checkBoxTue
            // 
            this.checkBoxTue.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxTue.FormattingEnabled = true;
            this.checkBoxTue.Location = new System.Drawing.Point(509, 45);
            this.checkBoxTue.Name = "checkBoxTue";
            this.checkBoxTue.Size = new System.Drawing.Size(206, 236);
            this.checkBoxTue.TabIndex = 29;
            // 
            // btnDeleteWeek
            // 
            this.btnDeleteWeek.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteWeek.Location = new System.Drawing.Point(51, 182);
            this.btnDeleteWeek.Name = "btnDeleteWeek";
            this.btnDeleteWeek.Size = new System.Drawing.Size(157, 76);
            this.btnDeleteWeek.TabIndex = 28;
            this.btnDeleteWeek.Text = "- 刪除";
            this.btnDeleteWeek.UseVisualStyleBackColor = true;
            this.btnDeleteWeek.Click += new System.EventHandler(this.btnDeleteWeek_Click);
            // 
            // btnAddWeek
            // 
            this.btnAddWeek.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddWeek.Location = new System.Drawing.Point(51, 88);
            this.btnAddWeek.Name = "btnAddWeek";
            this.btnAddWeek.Size = new System.Drawing.Size(157, 76);
            this.btnAddWeek.TabIndex = 27;
            this.btnAddWeek.Text = "+ 新增";
            this.btnAddWeek.UseVisualStyleBackColor = true;
            this.btnAddWeek.Click += new System.EventHandler(this.btnAddWeek_Click);
            // 
            // labelSun
            // 
            this.labelSun.BackColor = System.Drawing.Color.SeaShell;
            this.labelSun.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSun.Location = new System.Drawing.Point(740, 305);
            this.labelSun.Margin = new System.Windows.Forms.Padding(3);
            this.labelSun.Name = "labelSun";
            this.labelSun.Size = new System.Drawing.Size(225, 272);
            this.labelSun.TabIndex = 26;
            this.labelSun.Text = "SUNDAY";
            this.labelSun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelThur
            // 
            this.labelThur.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelThur.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelThur.Location = new System.Drawing.Point(18, 305);
            this.labelThur.Margin = new System.Windows.Forms.Padding(3);
            this.labelThur.Name = "labelThur";
            this.labelThur.Size = new System.Drawing.Size(225, 272);
            this.labelThur.TabIndex = 25;
            this.labelThur.Text = "THURSDAY";
            this.labelThur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFri
            // 
            this.labelFri.BackColor = System.Drawing.Color.Bisque;
            this.labelFri.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelFri.Location = new System.Drawing.Point(259, 305);
            this.labelFri.Margin = new System.Windows.Forms.Padding(3);
            this.labelFri.Name = "labelFri";
            this.labelFri.Size = new System.Drawing.Size(225, 272);
            this.labelFri.TabIndex = 24;
            this.labelFri.Text = "FRIDAY";
            this.labelFri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelwed
            // 
            this.labelwed.BackColor = System.Drawing.Color.Bisque;
            this.labelwed.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelwed.Location = new System.Drawing.Point(740, 18);
            this.labelwed.Margin = new System.Windows.Forms.Padding(3);
            this.labelwed.Name = "labelwed";
            this.labelwed.Size = new System.Drawing.Size(225, 272);
            this.labelwed.TabIndex = 23;
            this.labelwed.Text = "WEDNESDAY";
            this.labelwed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTue
            // 
            this.labelTue.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelTue.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTue.Location = new System.Drawing.Point(499, 18);
            this.labelTue.Margin = new System.Windows.Forms.Padding(3);
            this.labelTue.Name = "labelTue";
            this.labelTue.Size = new System.Drawing.Size(225, 272);
            this.labelTue.TabIndex = 22;
            this.labelTue.Text = "TUESDAY";
            this.labelTue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSat
            // 
            this.labelSat.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelSat.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSat.Location = new System.Drawing.Point(499, 305);
            this.labelSat.Margin = new System.Windows.Forms.Padding(3);
            this.labelSat.Name = "labelSat";
            this.labelSat.Size = new System.Drawing.Size(225, 272);
            this.labelSat.TabIndex = 21;
            this.labelSat.Text = "SATURDAY";
            this.labelSat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMon
            // 
            this.labelMon.BackColor = System.Drawing.Color.Linen;
            this.labelMon.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMon.Location = new System.Drawing.Point(259, 18);
            this.labelMon.Margin = new System.Windows.Forms.Padding(3);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(225, 272);
            this.labelMon.TabIndex = 20;
            this.labelMon.Text = "MONDAY";
            this.labelMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 19;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button googleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkBoxMon;
        private System.Windows.Forms.CheckedListBox checkBoxSun;
        private System.Windows.Forms.CheckedListBox checkBoxSat;
        private System.Windows.Forms.CheckedListBox checkBoxFri;
        private System.Windows.Forms.CheckedListBox checkBoxThur;
        private System.Windows.Forms.CheckedListBox checkBoxWed;
        private System.Windows.Forms.CheckedListBox checkBoxTue;
        private System.Windows.Forms.Button btnDeleteWeek;
        private System.Windows.Forms.Button btnAddWeek;
        private System.Windows.Forms.Label labelSun;
        private System.Windows.Forms.Label labelThur;
        private System.Windows.Forms.Label labelFri;
        private System.Windows.Forms.Label labelwed;
        private System.Windows.Forms.Label labelTue;
        private System.Windows.Forms.Label labelSat;
        private System.Windows.Forms.Label labelMon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

