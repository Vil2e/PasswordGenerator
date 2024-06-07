using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int minLength = 5;
        int maxLength = 20;
        string allCharacters = "qwertyuiopasdfghjklzxcvbnm1234567890-=]\'`/.,<>?:}{+_)(*&^%$#@!";
        int currentLength;

        Random character;


        public Form1()
        {
            InitializeComponent();
            passwordLengthBar.Minimum = minLength;
            passwordLengthBar.Maximum = maxLength;
            character = new Random();

            GetPassWord(minLength);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordLengthBar_Scroll(object sender, EventArgs e)
        {
            passwordLength.Text = "Password Length : " + passwordLengthBar.Value;
            currentLength = passwordLengthBar.Value;

            GetPassWord(currentLength);
            
        }

        void GetPassWord(int currentLength)
        {   
            string password = ""; // 這個變數要放裡面 才可以每次都歸零

            // 依照password的設定字數就跑幾次loop
            for (int i = 0; i < currentLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                password += allCharacters[randomNum];
            }

            passwordLabel.Text = password;
        }

        private void copyPassBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }
    }
}
