namespace Countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DateTime forwardTime;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            forwardTimeFunc();
            calculateTime();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            calculateTime();
        }
        private void forwardTimeFunc()
        {
            string sqlValue = Database.getDateTime();
            string date = sqlValue.Split(' ')[0];

            int day = Convert.ToInt32(date.Split(".")[0]);
            int mounth = Convert.ToInt32(date.Split(".")[1]);
            int year = Convert.ToInt32(date.Split(".")[2]);

            string time = sqlValue.Split(' ')[1];
            int hour = Convert.ToInt32(time.Split(":")[0]);
            int minute = Convert.ToInt32(time.Split(":")[1]);
            int second = Convert.ToInt32(time.Split(":")[2]);

            forwardTime = new DateTime(year, mounth, day, hour, minute, second);

            labelForward.Text = Database.getDateTime();
        }
        private void calculateTime()
        {
            DateTime timeNow = DateTime.Now;
            labelNow.Text = timeNow.ToString();

            TimeSpan differanceTime = forwardTime - timeNow;

            labelYear.Text = (differanceTime.Days / 365).ToString() + " Year";

            int months = forwardTime.Month - timeNow.Month;
            if (forwardTime.Day < timeNow.Day)
                months--;
            labelMounth.Text = months.ToString() + " Mounth";

            DateTime previousTimeDay = timeNow.AddYears(differanceTime.Days / 365).AddMonths(months);
            labelDay.Text = (forwardTime - previousTimeDay).Days.ToString() + " Day";
            labelHours.Text = differanceTime.Hours.ToString() + " Hour";
            labelMinute.Text = differanceTime.Minutes.ToString() + " Minute";
            labelSecond.Text = differanceTime.Seconds.ToString() + " Second";
        }
        private void buttonTimeEdit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form2 form = new Form2();
            form.Show();
        }
        public void refresh()
        {
            forwardTimeFunc();
            calculateTime();
            timer1.Enabled = true;
        }
    }
}
