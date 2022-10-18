using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Little_Crane_Shuangpin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            TipText.Text = StartVerdict();
            AddButton.Text = "添加小鹤双拼";
        }

        // 检测是否存在
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

        // 添加小鹤双拼 || 设置小鹤双拼为默认
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TipText.Text == "已存在小鹤双拼方案" || TipText.Text == "未检测到小鹤双拼方案")
            {
                Add();
                TipText.Text = AddVerdict();
                AddButton.Text = "设置小鹤为默认";
                OpenButton.Text = "打开微软拼音设置";
                OpenButton.Visible = true;
            }
            else if (TipText.Text == @"添加成功,设置小鹤为默认

或者打开微软拼音自行设置")
            {
                SettingXiaohe();
                TipText.Text = SettingXiaoheVerdict();
            }
        }

        // 添加小鹤双拼
        private static void Add()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            myKey.SetValue("UserDefinedDoublePinyinScheme0", "小鹤双拼*2*^*iuvdjhcwfg^xmlnpbksqszxkrltvyovt", RegistryValueKind.String);
            myKey.Close();
        }

        // 检测添加小鹤双拼是否成功
        private static string AddVerdict()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            string text = Convert.ToString(myKey.GetValue("UserDefinedDoublePinyinScheme0"));
            if (text == "小鹤双拼*2*^*iuvdjhcwfg^xmlnpbksqszxkrltvyovt")
            {
                text = @"添加成功,设置小鹤为默认

或者打开微软拼音自行设置";
            }
            else
            {
                text = "添加失败,右键以管理员身份运行";
            }
            return text;
        }

        // 打开微软拼音输入法设置
        private void OpenButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:regionlanguage-chsime-pinyin");
        }

        // 拼音设置为双拼 默认输入方案设置为小鹤双拼
        private void SettingXiaohe()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            myKey.SetValue("EnableExtraDomainType", "00000001", RegistryValueKind.DWord);
            myKey.SetValue("Enable Double Pinyin", "00000001", RegistryValueKind.DWord);
            myKey.SetValue("DoublePinyinScheme", "10", RegistryValueKind.DWord);
            myKey.Close();
        }

        // 检测默认输入方案是否为小鹤双拼
        private string SettingXiaoheVerdict()
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\InputMethod\Settings\CHS");
            string EnableExtraDomainType = Convert.ToString(myKey.GetValue("EnableExtraDomainType"));
            string Enable_Double_Pinyin = Convert.ToString(myKey.GetValue("Enable Double Pinyin"));
            string DoublePinyinScheme = Convert.ToString(myKey.GetValue("DoublePinyinScheme"));

            if (EnableExtraDomainType == "00000001" || Enable_Double_Pinyin == "00000001" || DoublePinyinScheme == "10")
            {
                //LinkTipText.Text = "微软拼音推荐设置方案";
                //LinkTipText.Visible = true;
                return "成功,小鹤双拼现在为默认";
            }
            else
            {
                return "添加失败,右键以管理员身份运行";
            }
        }

        // 打开微软拼音推荐设置方案
        private void LinkTipText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("url");
        }
    }
}
