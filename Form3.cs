using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Fantasy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void SelectMealBtn_Click(object sender, EventArgs e)
        {
            SelectMealPanel.Visible = true;
        }
        private int CostBurger = 300, CostFriesReg = 100, CostFries = 200, CostShake = 120, CostDrink = 50;
        public int a = 0, b = 0, c = 0, d = 0, f = 0, g = 0, h = 0, i = 0, j = 0, k = 0, l = 0, m = 0, n = 0, o = 0;

        private int Inc(int y, RichTextBox txt)     //increment button 
        {
            y++;
            txt.Text = y.ToString();
            return y++;
        }
        public int Dec(int z, RichTextBox txt)               //decrement button
        {
            if (z > 0)
                z--;
            txt.Text = z.ToString();
            return z--;
        }
        private void aBtn_Click(object sender, EventArgs e)
        {
            a = Inc(a, BurgerBox1);
        }
        private void aaBtn_Click(object sender, EventArgs e)
        { a = Dec(a, BurgerBox1); }
        private void bBtn_Click(object sender, EventArgs e)
        { b = Inc(b, BurgerBox2); }
        private void bbBtn_Click(object sender, EventArgs e)
        { b = Dec(b, BurgerBox2); }
        private void cBtn_Click(object sender, EventArgs e)
        { c = Inc(c, BurgerBox3); }
        private void ccBtn_Click(object sender, EventArgs e)
        { c = Dec(c, BurgerBox3); }
        private void dBtn_Click(object sender, EventArgs e)
        { d = Inc(d, BurgerBox4); }
        private void ddBtn_Click(object sender, EventArgs e)
        { d = Dec(d, BurgerBox4); }
        private void fBtn_Click(object sender, EventArgs e)
        { f = Inc(f, BurgerBox5); }
        private void ffBtn_Click(object sender, EventArgs e)
        { f = Dec(f, BurgerBox5); }
        private void gBtn_Click(object sender, EventArgs e)
        { g = Inc(g, BurgerBox6); }
        private void ggBtn_Click(object sender, EventArgs e)
        { g = Dec(g, BurgerBox6); }
        private void hBtn_Click(object sender, EventArgs e)
        { h = Inc(h, BurgerBox7); }
        private void hhBtn_Click(object sender, EventArgs e)
        { h = Dec(h, BurgerBox7); }
        private void iBtn_Click(object sender, EventArgs e)
        { i = Inc(i, FriesBox1); }
        private void iiBtn_Click(object sender, EventArgs e)
        { i = Dec(i, FriesBox1); }
        private void jBtn_Click(object sender, EventArgs e)
        { j = Inc(j, FriesBox2); }
        private void jjBtn_Click(object sender, EventArgs e)
        { j = Dec(j, FriesBox2); }
        private void kBtn_Click(object sender, EventArgs e)
        { k = Inc(k, FriesBox3); }
        private void kkBtn_Click(object sender, EventArgs e)
        { k = Dec(k, FriesBox3); }
        private void lBtn_Click(object sender, EventArgs e)
        { l = Inc(l, FriesBox4); }
        private void llBtn_Click(object sender, EventArgs e)
        { l = Dec(l, FriesBox4); }
        private void mBtn_Click(object sender, EventArgs e)
        { m = Inc(m, ShakeBox1); }
        private void mmBtn_Click(object sender, EventArgs e)
        { m = Dec(m, ShakeBox1); }
        private void nBtn_Click(object sender, EventArgs e)
        { n = Inc(n, ShakeBox2); }
        private void nnBtn_Click(object sender, EventArgs e)
        { n = Dec(n, ShakeBox2); }
        private void oBtn_Click(object sender, EventArgs e)
        { o = Inc(o, DrinkBox); }
        private void ooBtn_Click(object sender, EventArgs e)
        { o = Dec(o, DrinkBox); }

        private void BurgerBox1_KeyPress(object sender, KeyPressEventArgs e)    //to restrict to only digits
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void BurgerBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void BurgerBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void BurgerBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void BurgerBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void BurgerBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void BurgerBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void FriesBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void FriesBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void FriesBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void FriesBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void ShakeBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void ShakeBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void DrinkBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void SaveValue(RichTextBox txt, int x) //to save quantities given in text boxes to variables for further calculations
        {
            if (txt.Text != string.Empty)
                x = int.Parse(txt.Text);
        }
        private void BurgerBox1_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox1, a);
        }
        private void BurgerBox2_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox2, b);
        }
        private void BurgerBox3_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox3, c);
        }
        private void BurgerBox4_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox4, d);
        }
        private void BurgerBox5_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox5, f);
        }
        private void BurgerBox6_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox6, g);
        }
        private void BurgerBox7_TextChanged(object sender, EventArgs e)
        {
            SaveValue(BurgerBox7, h);
        }
        private void FriesBox1_TextChanged(object sender, EventArgs e)
        {
            SaveValue(FriesBox1, i);
        }
        private void FriesBox2_TextChanged(object sender, EventArgs e)
        {
            SaveValue(FriesBox2, j);
        }
        private void FriesBox3_TextChanged(object sender, EventArgs e)
        {
            SaveValue(FriesBox3, k);
        }
        private void FriesBox4_TextChanged(object sender, EventArgs e)
        {
            SaveValue(FriesBox4, l);
        }
        private void ShakeBox1_TextChanged(object sender, EventArgs e)
        {
            SaveValue(ShakeBox1, m);
        }
        private void ShakeBox2_TextChanged(object sender, EventArgs e)
        {
            SaveValue(ShakeBox2, n);
        }
        private void DrinkBox_TextChanged(object sender, EventArgs e)
        {
            SaveValue(DrinkBox, o);
        }
        private void ExtBtn_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to exit?";
            const string closing = "Closing Program";
            var result = MessageBox.Show(message, closing, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private void clr()
        {
            BurgerBox1.Clear(); a = 0;
            BurgerBox2.Clear(); b = 0;
            BurgerBox3.Clear(); c = 0;
            BurgerBox4.Clear(); d = 0;
            BurgerBox5.Clear(); f = 0;
            BurgerBox6.Clear(); g = 0;
            BurgerBox7.Clear(); h = 0;
            FriesBox1.Clear(); i = 0;
            FriesBox2.Clear(); j = 0;
            FriesBox3.Clear(); k = 0;
            FriesBox4.Clear(); l = 0;
            ShakeBox1.Clear(); m = 0;
            ShakeBox2.Clear(); n = 0;
            DrinkBox.Clear(); o = 0;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clr();
        }
        private void TotalBtn_Click(object sender, EventArgs e)
        {
            TotalPanel.Visible = true;
            double amount = 0, tax = 0, totalamount = 0;
            double coburgers = Convert.ToDouble((a + b + c + d + f + g + h) * CostBurger);
            double cofries = (j + k + l) * CostFries;
            double cofriesreg = i * CostFriesReg;
            double coshakes = (m + n) * CostShake;
            double codrinks = o * CostDrink;
            amount = (coburgers + cofries + cofriesreg + coshakes + codrinks);
            SubTotalbox.Text = "Rs. " + amount.ToString();
            tax = (amount * 0.13);
            totalamount = tax + amount;
            TaxBox.Text = "Rs." + tax.ToString();
            TotalBox.Text = "Rs." + totalamount.ToString();

            labelTime.Text = DateTime.Now.ToLongTimeString();   //RECEIPT
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelsub.Text = "Rs." + amount.ToString();
            labeltax.Text = "Rs." + tax.ToString();
            labelam.Text = "Rs." + totalamount.ToString();

            label28.Text = label29.Text = label30.Text = label31.Text = label32.Text = label38.Text = label39.Text = label40.Text = label41.Text = "...";
            label42.Text = label43.Text = label44.Text = label45.Text = label46.Text = label47.Text = label50.Text = label51.Text = label52.Text = "...";
            label53.Text = label54.Text = label55.Text = label56.Text = label57.Text = label58.Text = "...";

            if (a != 0)
            {
                label32.Text = a + "  CHICKEN BURGER"; label52.Text = "Rs." + (a * CostBurger).ToString();
            }
            if (b != 0)
            {
                label31.Text = b + "  CHEESE BURGER"; label53.Text = "Rs." + (b * CostBurger).ToString();
            }
            if (c != 0)
            {
                label30.Text = c + "  PIZZA BURGER"; label54.Text = "Rs." + (c * CostBurger).ToString();
            }
            if (d != 0)
            {
                label29.Text = d + "  ZINGER BURGER"; label55.Text = "Rs." + (d * CostBurger).ToString();
            }
            if (f != 0)
            {
                label28.Text = f + "  BEEF BURGER"; label56.Text = "Rs." + (f * CostBurger).ToString();
            }
            if (g != 0)
            {
                label38.Text = g + "  FIREHOUSE"; label47.Text = "Rs." + (g * CostBurger).ToString();
            }
            if (h != 0)
            {
                label39.Text = h + "  CRISPY BURGER"; label48.Text = "Rs." + (h * CostBurger).ToString();
            }
            if (i != 0)
            {
                label40.Text = i + "  REGULAR FRIES"; label49.Text = "Rs." + (i * CostFriesReg).ToString();
            }
            if (j != 0)
            {
                label41.Text = j + "  WILD FRIES"; label50.Text = "Rs." + (j * CostFries).ToString();
            }
            if (k != 0)
            {
                label42.Text = k + "  MAYO GARLIC FRIES"; label51.Text = "Rs." + (k * CostFries).ToString();
            }
            if (l != 0)
            {
                label45.Text = l + "  PIZZA FRIES"; label43.Text = "Rs." + (l * CostFries).ToString();
            }
            if (m != 0 || n != 0)
            {
                label46.Text = (m + n) + "  SHAKE"; label44.Text = "Rs." + ((m + n) * CostShake).ToString();
            }
            if (o != 0)
            {
                label58.Text = o + "  SOFT DRINK"; label57.Text = "Rs." + (o * CostDrink).ToString();
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            TotalBox.Clear();
            SubTotalbox.Clear();
            TaxBox.Clear();
            TotalPanel.Hide();
            receipttt.Hide();
        }
        private void ReceiptBtn_Click(object sender, EventArgs e)
        {
            receipttt.Show();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            clr();
            SelectMealPanel.Hide();
            TotalPanel.Hide();
            receipttt.Hide();
        }
        private void WaiterBtn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void ChefBtn_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }}}