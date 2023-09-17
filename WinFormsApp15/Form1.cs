namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total_item, discount;
            string book_name;
            double total_price, net_price, num1_d, num1_int;

            total_item = Convert.ToInt16(comboBox2.Text);
            total_price = total_item * 10;
            label5.Text = total_price.ToString("0.00") + "$";

            if (total_item > 0 && total_item <= 20)
            {
                num1_d = 0.1;
                num1_int = num1_d * 100;

                label4.Text = num1_int + " %";
                label8.Text = num1_d + "";
                net_price = total_price - (total_price * num1_d);
                label7.Text = net_price.ToString("0.00") + "$";

                listBox1.Items.Add(comboBox1.Text + " " + "\n" + " - " + total_item + " Adet " + " Net Price: " + net_price + " $ ");
            }
           else if (total_item > 20 && total_item <= 50)
            {
                num1_d = 0.2;
                num1_int = num1_d * 100;

                label4.Text = num1_int + " %";
                label8.Text = num1_d + "";
                net_price = total_price - (total_price * num1_d);
                label7.Text = net_price.ToString("0.00") + "$";

                listBox1.Items.Add(comboBox1.Text + " " + "\n" + " - " + total_item + " Adet " + " Net Price: " + net_price + " $ ");


            }
           else if (total_item > 50 && total_item <= 100)
            {
                num1_d = 0.3;
                num1_int = num1_d * 100;

                label4.Text = num1_int + " %";
                label8.Text = num1_d + "";
                net_price = total_price - (total_price * num1_d);
                label7.Text = net_price.ToString("0.00") + "$";

                listBox1.Items.Add(comboBox1.Text + " " + "\n" + " - " + total_item + " Adet " + " Net Price: " + net_price + " $ ");
            }

            else
            {
                num1_d = 0.5;
                num1_int = num1_d * 100;

                label4.Text = num1_int + " %";
                label8.Text = num1_d + "";
                net_price = total_price - (total_price * num1_d);
                label7.Text = net_price.ToString("0.00") + "$";

                listBox1.Items.Add(comboBox1.Text + " " + "\n" + " - " + total_item + " Adet " + " Net Price: " + net_price + " $ ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            label5.Text = "0.00 $";
            label4.Text = "0 %";
            label7.Text = "0.00 $";
            label8.Text = "0.00";
            listBox1.Text=("");
            comboBox1.Focus();
   


        }
    }
}