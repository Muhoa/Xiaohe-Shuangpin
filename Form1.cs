using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_Crane_Shuangpin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = StartVerdict();
        }

        private static string StartVerdict()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            string text = Convert.ToString(myKey.GetValue("UserDefinedDoublePinyinScheme0"));
            if (text == "小鹤双拼*2*^*iuvdjhcwfg^xmlnpbksqszxkrltvyovt")
            {
                text = "已存在小鹤双拼方案";
            }
            else
            {
                text = "未检测到小鹤双拼方案";
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            label1.Text = AddVerdict();
        }

        private static void Add()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            myKey.SetValue("UserDefinedDoublePinyinScheme0", "小鹤双拼*2*^*iuvdjhcwfg^xmlnpbksqszxkrltvyovt", RegistryValueKind.String);
            myKey.Close();
        }

        private static string AddVerdict()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            string text = Convert.ToString(myKey.GetValue("UserDefinedDoublePinyinScheme0"));
            if (text == "小鹤双拼*2*^*iuvdjhcwfg^xmlnpbksqszxkrltvyovt")
            {
                text = @"添加成功,请打开微软拼音设置

拼音模式选择双拼,选择小鹤双拼设为默认项";
            }
            else
            {
                text = "添加失败,右键以管理员身份运行";
            }
            return text;
        }
    }
}
