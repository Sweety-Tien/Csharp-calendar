namespace FinalProject
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRemind = new System.Windows.Forms.Button();
            this.btnParty = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAddPlace = new System.Windows.Forms.TextBox();
            this.txtAddContent = new System.Windows.Forms.TextBox();
            this.labelAddPlace = new System.Windows.Forms.Label();
            this.labelAddContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(476, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAdd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdd.Location = new System.Drawing.Point(54, 60);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(507, 60);
            this.txtAdd.TabIndex = 2;
            this.txtAdd.Text = "新增事項";
            this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
            // 
            // btnActivity
            // 
            this.btnActivity.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnActivity.Location = new System.Drawing.Point(54, 138);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(70, 50);
            this.btnActivity.TabIndex = 3;
            this.btnActivity.Text = "活動";
            this.btnActivity.UseVisualStyleBackColor = true;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnWork
            // 
            this.btnWork.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWork.Location = new System.Drawing.Point(130, 138);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(70, 50);
            this.btnWork.TabIndex = 4;
            this.btnWork.Text = "工作";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnRemind
            // 
            this.btnRemind.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemind.Location = new System.Drawing.Point(206, 138);
            this.btnRemind.Name = "btnRemind";
            this.btnRemind.Size = new System.Drawing.Size(70, 50);
            this.btnRemind.TabIndex = 5;
            this.btnRemind.Text = "提醒";
            this.btnRemind.UseVisualStyleBackColor = true;
            this.btnRemind.Click += new System.EventHandler(this.btnRemind_Click);
            // 
            // btnParty
            // 
            this.btnParty.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnParty.Location = new System.Drawing.Point(282, 138);
            this.btnParty.Name = "btnParty";
            this.btnParty.Size = new System.Drawing.Size(70, 50);
            this.btnParty.TabIndex = 6;
            this.btnParty.Text = "聚會";
            this.btnParty.UseVisualStyleBackColor = true;
            this.btnParty.Click += new System.EventHandler(this.btnParty_Click);
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOther.Location = new System.Drawing.Point(358, 138);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(70, 50);
            this.btnOther.TabIndex = 7;
            this.btnOther.Text = "其他";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(507, 29);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtAddPlace
            // 
            this.txtAddPlace.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddPlace.Location = new System.Drawing.Point(178, 318);
            this.txtAddPlace.Multiline = true;
            this.txtAddPlace.Name = "txtAddPlace";
            this.txtAddPlace.Size = new System.Drawing.Size(383, 50);
            this.txtAddPlace.TabIndex = 13;
            // 
            // txtAddContent
            // 
            this.txtAddContent.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddContent.Location = new System.Drawing.Point(178, 395);
            this.txtAddContent.Multiline = true;
            this.txtAddContent.Name = "txtAddContent";
            this.txtAddContent.Size = new System.Drawing.Size(383, 50);
            this.txtAddContent.TabIndex = 14;
            // 
            // labelAddPlace
            // 
            this.labelAddPlace.AutoSize = true;
            this.labelAddPlace.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAddPlace.Location = new System.Drawing.Point(66, 333);
            this.labelAddPlace.Name = "labelAddPlace";
            this.labelAddPlace.Size = new System.Drawing.Size(110, 24);
            this.labelAddPlace.TabIndex = 15;
            this.labelAddPlace.Text = "新增地點";
            // 
            // labelAddContent
            // 
            this.labelAddContent.AutoSize = true;
            this.labelAddContent.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAddContent.Location = new System.Drawing.Point(66, 410);
            this.labelAddContent.Name = "labelAddContent";
            this.labelAddContent.Size = new System.Drawing.Size(110, 24);
            this.labelAddContent.TabIndex = 16;
            this.labelAddContent.Text = "新增說明";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 563);
            this.Controls.Add(this.labelAddContent);
            this.Controls.Add(this.labelAddPlace);
            this.Controls.Add(this.txtAddContent);
            this.Controls.Add(this.txtAddPlace);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnParty);
            this.Controls.Add(this.btnRemind);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnActivity);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Form2";
            this.Text = "新增事項";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRemind;
        private System.Windows.Forms.Button btnParty;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAddPlace;
        private System.Windows.Forms.TextBox txtAddContent;
        private System.Windows.Forms.Label labelAddPlace;
        private System.Windows.Forms.Label labelAddContent;
    }
}