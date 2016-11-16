using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MealRestaurant
{
    public partial class RestaurantBackenedLogin : Form
    {
        public RestaurantBackenedLogin()
        {
            InitializeComponent();
        }
        public RestaurantBackenedManager backened { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GetEncryptedText(tboAccount.Text).Equals(GetEncryptedText("backened")) && GetEncryptedText(tboPassword.Text).Equals(GetEncryptedText("taiwan")))
            {
                backened = SingletonForm<RestaurantBackenedManager>.FormSingleton();
            }
            else
                MessageBox.Show("密碼或帳號錯誤");
        }

        /// <summary>
        /// 執行MD5加密法
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string GetEncryptedText(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] encryptedByte = Encoding.Default.GetBytes(text);
            byte[] newText = md5.ComputeHash(encryptedByte);
            string result = "";
            for (int i = 0; i < newText.Length; i++)
            {
                result += newText[i];
            }
            return result;
        }
    }
}
