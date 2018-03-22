using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public struct data
    {
        public String ID;
        public String gender;
        public String tel;
        public String ad;
    }
    public partial class Form1 : Form
    {
        int point = 0;
        data[] all_data = new data[40];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //搜尋
            String target = text_ID.Text;
            for(int i = 0; i < point; i++)
            {
                if (target == all_data[i].ID)
                {
                    label9.Visible = false;
                    text_gender.Visible = true;
                    text_ad.Visible = true;
                    text_tel.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    text_gender.Text = all_data[i].gender;
                    text_ad.Text = all_data[i].ad;
                    text_tel.Text = all_data[i].tel;
                    break;
                }
                else if (i == (point - 1))
                {
                    label9.Visible = true;
                    text_gender.Visible = false;
                    text_ad.Visible = false;
                    text_tel.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label9.Text = "無此筆資料";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //確認刪除
            String target = text_ID.Text;
            for (int i = 0; i < point; i++)
            {
                if (target == all_data[i].ID)
                {
                    label9.Visible = true;
                    label9.Text = "刪除成功!!";
                    all_data[i].gender = all_data[point-1].gender;
                    all_data[i].ad = all_data[point-1].ad;
                    all_data[i].tel = all_data[point-1].tel;
                    point--;
                    break;
                }
                else if (i == (point - 1))
                {
                    label9.Visible = true;
                    label9.Text = "查無此筆資料";
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //確認新增
            string ID = text_ID.Text;
            string gender = text_gender.Text;
            string tel = text_tel.Text;
            string ad = text_ad.Text;
            if(ID == "" || gender == "" || tel == "" || ad == "")
            {
                label7.Text = "各欄位不能為空,請重新輸入";
                label7.Visible = true;
            }
            else
            {
                all_data[point].ID = text_ID.Text;
                all_data[point].tel = text_tel.Text;
                all_data[point].ad = text_ad.Text;
                all_data[point].gender = text_gender.Text;
                text_ID.Text = "";
                text_tel.Text = "";
                text_ad.Text = "";
                text_gender.Text = "";
                point++;
                label7.Text = "資料已存入";
                label8.Visible = true;
                label8.Text = "目前已有"+point+"筆資料!!";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //新增
            text_ID.Visible = true;
            text_gender.Visible = true;
            text_tel.Visible = true;
            text_ad.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btn_yes.Visible = true;
            btn_check.Visible = false;
            btn_find.Visible = false;
            text_ID.Text = "";
            text_tel.Text = "";
            text_ad.Text = "";
            text_gender.Text = "";
        }
        private void label5_Click(object sender, EventArgs e)
        {
            //查詢
            text_ID.Visible = true;
            text_gender.Visible = false;
            text_tel.Visible = false;
            text_ad.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btn_yes.Visible = false;
            btn_find.Visible = true;
            btn_check.Visible = false;
            text_ID.Text = "";
        }
        private void label6_Click(object sender, EventArgs e)
        {
            //刪除
            text_ID.Visible = true;
            text_gender.Visible = false;
            text_tel.Visible = false;
            text_ad.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btn_yes.Visible = false;
            btn_check.Visible = true;
            btn_find.Visible = false;
            text_ID.Text = "";
        }
        private void label7_Click(object sender, EventArgs e)
        {
            //登出
            label1.Visible = true;
            label2.Visible = true;
            text_account.Visible = true;
            text_password.Visible = true;
            text_ID.Visible = false;
            text_gender.Visible = false;
            text_tel.Visible = false;
            text_ad.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btn_yes.Visible = false;
            btn_out.Visible = false;
            btn_del.Visible = false;
            btn_lookup.Visible = false;
            btn_check.Visible = false;
            btn_add.Visible = false;
            btn_in.Visible = true;
            text_account.Text = "";
            text_password.Text = "";
        }
        private void label8_Click(object sender, EventArgs e)
        {
            //登入
            string acount = text_account.Text;
            string password = text_password.Text;
            if (password == "0000" && acount == "0000")
            {
                label1.Visible = false;
                label2.Visible = false;
                text_account.Visible = false;
                text_password.Visible = false;
                text_ID.Visible = false;
                text_gender.Visible = false;
                text_tel.Visible = false;
                text_ad.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                btn_yes.Visible = false;
                btn_out.Visible = true;
                btn_del.Visible = true;
                btn_lookup.Visible = true;
                btn_add.Visible = true;
                btn_in.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
