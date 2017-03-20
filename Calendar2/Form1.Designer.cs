namespace TestHarness
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.calendar1 = new WindowsFormsCalendar.MonthView();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // calendar1
            // 
            this.calendar1.ArrowsColor = System.Drawing.Color.Silver;
            this.calendar1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.calendar1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.calendar1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.calendar1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.calendar1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.calendar1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.Margin = new System.Windows.Forms.Padding(4);
            this.calendar1.MonthTitleColor = System.Drawing.Color.Silver;
            this.calendar1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.calendar1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendar1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendar1.Name = "calendar1";
            this.calendar1.SelectionMode = WindowsFormsCalendar.MonthViewSelection.Week;
            this.calendar1.Size = new System.Drawing.Size(1132, 604);
            this.calendar1.TabIndex = 1;
            this.calendar1.Text = "monthView1";
            this.calendar1.TodayBorderColor = System.Drawing.Color.Orange;
            this.calendar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calendar1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 604);
            this.Controls.Add(this.calendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6 month calendar [N-P to navigate]";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private WindowsFormsCalendar.MonthView calendar1;
    }
}

