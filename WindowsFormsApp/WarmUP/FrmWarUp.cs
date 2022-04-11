using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FrmWarUp : Form
    {
        public FrmWarUp()
        {
            InitializeComponent();
            button3.Click += (button3_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! " + textBoxName.Text, "Hello!您好");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi! " + textBoxName.Text, "Hi!您好");
        }

        bool click = true;
        private void button3_Click(object sender, EventArgs e)
        {
            if (click == true)
            {
                Image myimage = new Bitmap(@"C:\iii\ADO.NET\Exercise\WindowsFormsApp\image\radShiba2.png");
                this.BackgroundImage = myimage;
                label1.Text = "改變了啦!";
                label1.BackColor = Color.Navy;
                label1.ForeColor = Color.Ivory;
                label1.BorderStyle = BorderStyle.Fixed3D;
                this.BackgroundImageLayout = ImageLayout.Zoom;
                button3.BackColor = Color.DarkRed;
                button1.Visible = false;
                button2.Visible = false;
                textBoxName.Text = "一人一把對開!";
                textBoxName.Size = new Size(200, 100);
            }
            else
            {
                Image myimage = new Bitmap(@"C:\iii\ADO.NET\Exercise\WindowsFormsApp\image\radShiba.jpg");
                this.BackgroundImage = myimage;
                label1.Text = "Name";
                label1.BackColor = SystemColors.Control;
                button3.BackColor = SystemColors.Control;
                label1.ForeColor = Color.Black;
                label1.BorderStyle = BorderStyle.None;
                button1.Visible = true;
                button2.Visible = true;
                textBoxName.Text = "";
                textBoxName.Size = new Size(100, 29);

            }
            click = !click;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Click += Button4_Click;
            button4.Click += aaa;
            button4.Text = "事件已經註冊";
            button4.BackColor = Color.Chocolate;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button4_Click!");
            button4.Click -= Button4_Click;
            button4.Text = "取消註冊";
            button4.BackColor = Color.Azure;
        }
        private void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("aaa!");
            button4.Click -= aaa;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmWarUp f = new FrmWarUp();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /////////////static property 共享的實體
            MessageBox.Show(SystemInformation.ComputerName);


//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 其為唯讀 WindowsFormsApp C:\iii\ADO.NET\Exercise\WindowsFormsApp\WindowsFormsApp\Form1.cs    106 作用中

//            SystemInformation.ComputerName = "xxxx";////set propety 唯讀

            string CN = SystemInformation.ComputerName;/////get


            ////////// instance propety 用之前必須new
            button1.Text = "xxx";
            button2.Text = "yyy";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //static method
            File.Copy("a.txt","aaa.txt", true);

            //instance method
            FileInfo f = new FileInfo("b.txt");
            MessageBox.Show(string.Format("{0}\n{1}\n{2}", f.FullName, f.Extension, f.CreationTime));

            f.CopyTo("bbb.txt", true);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ////demo 1
//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0120 需要有物件參考，才可使用非靜態欄位、方法或屬性 'Form.Text' WindowsFormsApp C:\iii\ADO.NET\Exercise\WindowsFormsApp\WindowsFormsApp\Form1.cs    137 作用中

//            Form1.Text = "HELLO"+textBoxName.Text;

            //demo2 
            FrmWarUp f = new FrmWarUp();
            f.Text = textBoxName.Text;

            this.Text = "Hello"+this.textBoxName.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
