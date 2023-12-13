namespace KFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Menu m = new Menu();
        Form3 form3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] Name = { "Chicken", "Big Mac Menu", "King Menu",
            "Heart Pizza", "two pizzas and sweat",
            "Big Chicken Burger", "Hamburger and drink",
            "Big Mac Menu ","King Chicken burger", "Coffee"};
            decimal[] price = { 3.20m, 10.90m, 7.20m, 12.40m, 15.50m, 10.30m, 9.20m,
            10.00m, 15.20m, 6.10m};
            decimal total = 0;

            if (numericUpDown1.Value > 0)
            {
                m.Name = Name[0];
                m.price = price[0];
                total = total + m.price * numericUpDown1.Value;
                form3.label45.Text = Name[0];
                form3.label5.Text = price[0].ToString() + " " + "azn";
                form3.label6.Text = numericUpDown1.Value.ToString() + " " + "eded";
                form3.label7.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown3.Value > 0)
            {
                m.Name = Name[1];
                m.price = price[1];
                total = total + m.price * numericUpDown3.Value;
                form3.label44.Text = Name[1];
                form3.label10.Text = price[1].ToString() + " " + "azn";
                form3.label9.Text = numericUpDown3.Value.ToString() + " " + "eded";
                form3.label8.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown4.Value > 0)
            {
                m.Name = Name[2];
                m.price = price[2];
                total = total + m.price * numericUpDown4.Value;
                form3.label43.Text = Name[2];
                form3.label13.Text = price[2].ToString() + " " + "azn";
                form3.label12.Text = numericUpDown4.Value.ToString() + " " + "eded";
                form3.label11.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown5.Value > 0)
            {
                m.Name = Name[3];
                m.price = price[3];
                total = total + m.price * numericUpDown5.Value;
                form3.label42.Text = Name[3];
                form3.label16.Text = price[3].ToString() + " " + "azn";
                form3.label15.Text = numericUpDown5.Value.ToString() + " " + "eded";
                form3.label14.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown6.Value > 0)
            {
                m.Name = Name[4];
                m.price = price[4];
                total = total + m.price * numericUpDown6.Value;
                form3.label41.Text = Name[4];
                form3.label28.Text = price[4].ToString() + " " + "azn";
                form3.label27.Text = numericUpDown6.Value.ToString() + " " + "eded";
                form3.label26.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown10.Value > 0)
            {
                m.Name = Name[5];
                m.price = price[5];
                total = total + m.price * numericUpDown10.Value;
                form3.label40.Text = Name[5];
                form3.label25.Text = price[5].ToString() + " " + "azn";
                form3.label24.Text = numericUpDown10.Value.ToString() + " " + "eded";
                form3.label23.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown9.Value > 0)
            {
                m.Name = Name[6];
                m.price = price[6];
                total = total + m.price * numericUpDown9.Value;
                form3.label39.Text = Name[6];
                form3.label22.Text = price[6].ToString() + " " + "azn";
                form3.label21.Text = numericUpDown9.Value.ToString() + " " + "eded";
                form3.label20.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown8.Value > 0)
            {
                m.Name = Name[7];
                m.price = price[7];
                total = total + m.price * numericUpDown8.Value;
                form3.label38.Text = Name[7];
                form3.label19.Text = price[7].ToString() + " " + "azn";
                form3.label18.Text = numericUpDown8.Value.ToString() + " " + "eded";
                form3.label17.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown7.Value > 0)
            {
                m.Name = Name[8];
                m.price = price[8];
                total = total + m.price * numericUpDown7.Value;
                form3.label37.Text = Name[8];
                form3.label30.Text = price[8].ToString() + " " + "azn";
                form3.label29.Text = numericUpDown7.Value.ToString() + " " + "eded";
                form3.label31.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown11.Value > 0)
            {
                m.Name = Name[9];
                m.price = price[9];
                total = total + m.price * numericUpDown11.Value;
                form3.label36.Text = Name[9];
                form3.label33.Text = price[9].ToString() + " " + "azn";
                form3.label32.Text = numericUpDown11.Value.ToString() + " " + "eded";
                form3.label34.Text = total.ToString() + " " + "azn";
            }

            if (numericUpDown1.Value > 0 || numericUpDown3.Value > 0
            || numericUpDown4.Value > 0 || numericUpDown5.Value > 0
            || numericUpDown6.Value > 0 || numericUpDown10.Value > 0
            || numericUpDown9.Value > 0 || numericUpDown8.Value > 0
            || numericUpDown7.Value > 0 || numericUpDown11.Value > 0)

            {

                form3.Show();
            }

            if (numericUpDown1.Value == 0 && numericUpDown3.Value == 0
               && numericUpDown4.Value == 0 && numericUpDown5.Value == 0
               && numericUpDown6.Value == 0 && numericUpDown10.Value == 0
               && numericUpDown9.Value == 0 && numericUpDown8.Value == 0
               && numericUpDown7.Value == 0 && numericUpDown11.Value == 0)

            {
                MessageBox.Show("Zehmet olmasa sifarisinizi secin");
            }
            form3.label35.Text = total.ToString();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}