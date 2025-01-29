using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateTimePicker.MinDate = now.AddDays(1);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            string time = maskedTextBox.Text;

            string hour = Convert.ToString(time.Split(":")[0]);
            string minute = Convert.ToString(time.Split(":")[1]);
            string second = Convert.ToString(time.Split(":")[2]);

            if (second == "")
                second = "00";

            time = hour.Replace(" ", "0") + ":"+ minute.Replace(" ", "0") + ":"+second;
            Database.updateDateTime(date, time);
        }
        
        
    }
}
