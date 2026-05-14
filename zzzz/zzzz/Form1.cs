namespace zzzz
{
    public partial class Form1 : Form
    {
        int beans = 100;
        int water = 100;
        int milk = 1000;
        int caramel = 500;
        int chocolate = 500;
        int totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
            ShowIngredients();
        }

        private void ShowIngredients()
        {
            txtBeans.Text = beans.ToString();
            txtWater.Text = water.ToString();
            txtMilk.Text = milk.ToString();
            txtCaramel.Text = caramel.ToString();
            txtChocolate.Text = chocolate.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCoffeeSmall_Click(object sender, EventArgs e)
        {
            if (beans >= 5 && water >= 10 && milk >= 50)
            {
                beans -= 5;
                water -= 10;
                milk -= 50;

                totalPrice = 150;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCoffeeMedium_Click(object sender, EventArgs e)
        {
            if (beans >= 8 && water >= 20 && milk >= 100)
            {
                beans -= 8;
                water -= 20;
                milk -= 100;

                totalPrice = 165;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCoffeeLarge_Click(object sender, EventArgs e)
        {
            if (beans >= 10 && water >= 30 && milk >= 150)
            {
                beans -= 10;
                water -= 30;
                milk -= 150;

                totalPrice = 180;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnMochaSmall_Click(object sender, EventArgs e)
        {
            if (beans >= 5 && water >= 10 && milk >= 50 && chocolate >= 10)
            {
                beans -= 5;
                water -= 10;
                milk -= 50;
                chocolate -= 10;

                totalPrice = 150;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnMochaMedium_Click(object sender, EventArgs e)
        {
            if (beans >= 8 && water >= 20 && milk >= 100 && chocolate >= 15)
            {
                beans -= 8;
                water -= 20;
                milk -= 100;
                chocolate -= 15;

                totalPrice = 165;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnMochaLarge_Click(object sender, EventArgs e)
        {
            if (beans >= 10 && water >= 30 && milk >= 150 && chocolate >= 20)
            {
                beans -= 10;
                water -= 30;
                milk -= 150;
                chocolate -= 20;

                totalPrice = 180;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCarameloSmall_Click(object sender, EventArgs e)
        {
            if (beans >= 5 && water >= 10 && milk >= 50 && caramel >= 10)
            {
                beans -= 5;
                water -= 10;
                milk -= 50;
                caramel -= 10;

                totalPrice = 150;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCarameloMedium_Click(object sender, EventArgs e)
        {
            if (beans >= 8 && water >= 20 && milk >= 100 && caramel >= 15)
            {
                beans -= 8;
                water -= 20;
                milk -= 100;
                caramel -= 15;

                totalPrice = 165;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCarameloLarge_Click(object sender, EventArgs e)
        {
            if (beans >= 10 && water >= 30 && milk >= 150 && caramel >= 20)
            {
                beans -= 10;
                water -= 30;
                milk -= 150;
                caramel -= 20;

                totalPrice = 180;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCappuccinoSmall_Click(object sender, EventArgs e)
        {
            if (beans >= 5 && water >= 10 && milk >= 40)
            {
                beans -= 5;
                water -= 10;
                milk -= 40;

                totalPrice = 135;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCappuccinoMedium_Click(object sender, EventArgs e)
        {
            if (beans >= 8 && water >= 20 && milk >= 80)
            {
                beans -= 8;
                water -= 20;
                milk -= 80;

                totalPrice = 150;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void btnCappuccinoLarge_Click(object sender, EventArgs e)
        {
            if (beans >= 10 && water >= 30 && milk >= 120)
            {
                beans -= 10;
                water -= 30;
                milk -= 120;

                totalPrice = 165;
                txtTotalPrice.Text = totalPrice.ToString();

                ShowIngredients();
            }
            else
            {
                MessageBox.Show("Not enough ingredients");
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmountReceived.Text, out int amount))
            {
                if (amount < totalPrice)
                {
                    MessageBox.Show("Insufficient Payment");
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Do you want to continue?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        int change = amount - totalPrice;
                        txtChange.Text = change.ToString();
                        MessageBox.Show("Payment Successful");
                    }
                    else
                    {
                        MessageBox.Show("Transaction Cancelled");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers only");
            }
        }

        private void txtBeans_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWater_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMilk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaramel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChocolate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
