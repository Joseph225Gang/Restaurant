using System;
using System.Windows.Forms;

namespace MealRestaurant
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }
        public Form1 form1 { get; set; }
        public RestaurantBackenedLogin login { get; set; }

        /// <summary>
        /// 開啟customer(fronted side)視窗。使用singleton模式，總共只能有一個customer視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFronted_Click(object sender, EventArgs e)
        {
            form1 = SingletonForm<Form1>.FormSingleton();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 開啟manager(backened side)視窗。使用singleton模式，總共只能有一個manager視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackened_Click(object sender, EventArgs e)
        {
            login = SingletonForm<RestaurantBackenedLogin>.FormSingleton();
        }
    }
}
