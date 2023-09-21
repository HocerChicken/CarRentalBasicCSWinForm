using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab2_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //PictureBox1.Image = GetBanner(pbBanner.Width, pbBanner.Height, " Welcome");
        }

        private void btnGetQuotes_Click(object sender, EventArgs e)
        {
            Dictionary<String, double> map = new Dictionary<String, double>();
            //Services
            map["Economy"] = (double)59.99;
            map["Midsize"] = (double)65.98;
            map["Premium"] = (double)84.98;
            map["SUV"] = (double)106.99;
            //Extras
            map["checkBox1"] = (double)5.99;
            map["checkBox2"] = (double)10.99;

            //getRentayDays
            int rentalDays;
            if (txtRentalDays.Text == string.Empty)
            {
                rentalDays = 0;
            }
            else
            {
                rentalDays = int.Parse(txtRentalDays.Text);
            }

            //Get Value oF listBox
            double total = 0.00;
            if (checkBox1.Checked == true)
            {
                total += map[checkBox1.Name];
                lbSateRatio.Text = formatMoney(map[checkBox1.Name]);
            }
            if (checkBox2.Checked == true)
            {
                total += map[checkBox2.Name];
                lbGPS.Text = formatMoney(map[checkBox2.Name]);
            }

            //getBaseRental
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an type car");
            }
            else
            {
                if (listBox.SelectedIndex == 0)
                {
                    lbBaseRental.Text = formatMoney((rentalDays * map["Economy"]));
                    total += rentalDays * map["Economy"];
                }
                else if (listBox.SelectedIndex == 1)
                {
                    lbBaseRental.Text = formatMoney((rentalDays * map["Midsize"]));
                    total += rentalDays * map["Midsize"];
                }
                else if (listBox.SelectedIndex == 2)
                {
                    lbBaseRental.Text = formatMoney(rentalDays * map["Premium"]);
                    total += rentalDays * map["Premium"];
                }
                else if (listBox.SelectedIndex == 3)
                {
                    lbBaseRental.Text = formatMoney(rentalDays * map["SUV"]);
                    total += rentalDays * map["SUV"];
                }
            }
            double tax = total * 0.06;
            lbTax.Text = formatMoney(tax);
            total += tax;
            lbTotal.Text = formatMoney(total);
        }

        public string formatMoney(double money)
        {
            return Math.Round(money, 2).ToString() + " $s";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txtRentalDays.Text = String.Empty;
            lbBaseRental.Text= "0.00";
            lbSateRatio.Text = "0.00";    
            lbGPS.Text = "0.00";
            lbTax.Text= "0.00";
            lbTotal.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public Func GetBanner(int width, int  height, string bannerText)
        //{
        //    Bitmap bmp = new Bitmap(width, height);
        //    Graphics gImage = Graphics.FromImage(bmp);
        //    Rectangle rect = new Rectangle(0, 0, width, height);
        //    LinearGradientBrush myBrush = new LinearGradientBrush(rect, Color.DodgerBlue, Color.White, LinearGradientMode.Vertical);
        //    myBrush.SetSigmaBellShape((float) 0.5, 1);
        //}
    }
}