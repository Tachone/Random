using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 随机数生成器
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
            lbl1.Text = "";
        }
        public void getRandnum()
        {
                Random rd = new Random();
                int maxnum = int.Parse(rTb.Text);
                int num = rd.Next(1, maxnum + 1);
                lbl1.Text = num.ToString();
                Delay(10);

        }
        private void Delay(int Millisecond) //延迟系统时间，但系统又能同时能执行其它任务；
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(Millisecond) > DateTime.Now)
            {
                Application.DoEvents();//转让控制权            
            }
            return;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (rTb.Text == "")
            {
                MessageBox.Show("您还没有输入总的人数!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            int maxnum = int.Parse(rTb.Text);
            flag = !flag;
            if ((btn.Text).Equals("开始") == true)
            {
                btn.Text = "暂停";
                while (flag == true)
                {
                    getRandnum();
                }
            }
            if ((btn.Text).Equals("暂停") == true)
              {
                 btn.Text = "开始";
              }

        } 
    }
}
