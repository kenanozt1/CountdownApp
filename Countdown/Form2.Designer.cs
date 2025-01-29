namespace Countdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            buttonSave = new Button();
            dateTimePicker = new DateTimePicker();
            maskedTextBox = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 90);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(266, 74);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd.MMMM.yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(67, 11);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(211, 23);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.Value = new DateTime(2025, 1, 30, 0, 0, 0, 0);
            // 
            // maskedTextBox
            // 
            maskedTextBox.Location = new Point(66, 49);
            maskedTextBox.Mask = "00:00:00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(211, 23);
            maskedTextBox.TabIndex = 2;
            maskedTextBox.Tag = "";
            maskedTextBox.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Hours";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 176);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox);
            Controls.Add(dateTimePicker);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Time";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private DateTimePicker dateTimePicker;
        private MaskedTextBox maskedTextBox;
        private Label label1;
        private Label label2;
    }
}