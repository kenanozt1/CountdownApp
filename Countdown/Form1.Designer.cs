namespace Countdown
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            labelSecond = new Label();
            labelMinute = new Label();
            labelHours = new Label();
            labelDay = new Label();
            labelMounth = new Label();
            labelYear = new Label();
            labelNow = new Label();
            label1 = new Label();
            buttonTimeEdit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            labelForward = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelSecond);
            groupBox1.Controls.Add(labelMinute);
            groupBox1.Controls.Add(labelHours);
            groupBox1.Controls.Add(labelDay);
            groupBox1.Controls.Add(labelMounth);
            groupBox1.Controls.Add(labelYear);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remaining Time";
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Font = new Font("Segoe UI", 14.25F);
            labelSecond.Location = new Point(19, 242);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(115, 25);
            labelSecond.TabIndex = 0;
            labelSecond.Text = "labelSecond";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Segoe UI", 14.25F);
            labelMinute.Location = new Point(19, 202);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(113, 25);
            labelMinute.TabIndex = 0;
            labelMinute.Text = "labelMinute";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Segoe UI", 14.25F);
            labelHours.Location = new Point(19, 162);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(103, 25);
            labelHours.TabIndex = 0;
            labelHours.Text = "labelHours";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Segoe UI", 14.25F);
            labelDay.Location = new Point(19, 122);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(85, 25);
            labelDay.TabIndex = 0;
            labelDay.Text = "labelDay";
            // 
            // labelMounth
            // 
            labelMounth.AutoSize = true;
            labelMounth.Font = new Font("Segoe UI", 14.25F);
            labelMounth.Location = new Point(19, 82);
            labelMounth.Name = "labelMounth";
            labelMounth.Size = new Size(120, 25);
            labelMounth.TabIndex = 0;
            labelMounth.Text = "labelMounth";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelYear.Location = new Point(19, 42);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(89, 25);
            labelYear.TabIndex = 0;
            labelYear.Text = "labelYear";
            // 
            // labelNow
            // 
            labelNow.AutoSize = true;
            labelNow.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelNow.Location = new Point(355, 65);
            labelNow.Name = "labelNow";
            labelNow.Size = new Size(100, 30);
            labelNow.TabIndex = 1;
            labelNow.Text = "labelNow";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(355, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 2;
            label1.Text = "Time Now";
            // 
            // buttonTimeEdit
            // 
            buttonTimeEdit.Location = new Point(355, 245);
            buttonTimeEdit.Name = "buttonTimeEdit";
            buttonTimeEdit.Size = new Size(174, 52);
            buttonTimeEdit.TabIndex = 3;
            buttonTimeEdit.Text = "Edit Time";
            buttonTimeEdit.UseVisualStyleBackColor = true;
            buttonTimeEdit.Click += buttonTimeEdit_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelForward
            // 
            labelForward.AutoSize = true;
            labelForward.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelForward.Location = new Point(355, 159);
            labelForward.Name = "labelForward";
            labelForward.Size = new Size(131, 30);
            labelForward.TabIndex = 1;
            labelForward.Text = "labelForward";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(355, 134);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 2;
            label3.Text = "Time Forward";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 311);
            Controls.Add(buttonTimeEdit);
            Controls.Add(label3);
            Controls.Add(labelForward);
            Controls.Add(label1);
            Controls.Add(labelNow);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CountDown";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelNow;
        private Label label1;
        private Button buttonTimeEdit;
        private Label labelMinute;
        private Label labelHours;
        private Label labelDay;
        private Label labelMounth;
        private Label labelYear;
        private System.Windows.Forms.Timer timer1;
        private Label labelSecond;
        private Label labelForward;
        private Label label3;
    }
}
