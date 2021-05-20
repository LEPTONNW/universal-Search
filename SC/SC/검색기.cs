using System;
using System.Text;
using System.Windows.Forms;

namespace SC
{
    public partial class 검색기 : Form
    {
        public 검색기()
        {
            InitializeComponent();
        }

        public static string str;

        protected override void WndProc(ref Message m) //FormboardStyle = None 일 경우 마우스 제어 함수
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "네이버";
            comboBox2.Text = "크롬";
            comboBox3.Text = "off";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 검색_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            char[] strArray = temp.ToCharArray();


            for (int w = 0; w < strArray.Length; w++)
            {
                if (strArray[w] == ' ')
                {
                    str += "+";
                }
                else
                {
                    str += strArray[w];
                }
            }


            if (comboBox3.Text == "on")

            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("검색어를 먼저 입력해주세요");
                }

                else
                {
                    if (comboBox2.Text == "크롬")
                    {
                        if (comboBox1.Text == "구글")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                        }
                        else if (textBox1.Text == "개드립")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://www.dogdrip.net/");
                        }
                        else if (textBox1.Text == "네이버")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://www.naver.com/");
                        }
                        else if (textBox1.Text == "구글")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "https://www.google.co.kr/");
                        }
                        else if (textBox1.Text == "다음")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://www.daum.net/");
                        }

                        else if (textBox1.Text == "KPU")
                        {
                            System.Diagnostics.Process.Start("chrome.exe","http://kpu.kdual.net/");
                        }

                        else if (textBox1.Text == "HRD")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://www.hrd.go.kr/");
                        }

                        else if (comboBox1.Text == "네이버")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                        }
                        else if (comboBox1.Text == "다음")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                        }
                        else if (comboBox1.Text == "네이트")
                        {
                            System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                        }
                    }
                    else if (comboBox2.Text == "IE")
                    {
                        if (comboBox1.Text == "구글")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                        }
                        else if (textBox1.Text == "개드립")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://www.dogdrip.net/");
                        }
                        else if (textBox1.Text == "네이버")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://www.naver.com/");
                        }
                        else if (textBox1.Text == "구글")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "https://www.google.co.kr/");
                        }
                        else if (textBox1.Text == "다음")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://www.daum.net/");
                        }

                        else if (textBox1.Text == "HRD")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://www.hrd.go.kr/");
                        }

                        else if (textBox1.Text == "KPU")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://kpu.kdual.net/");
                        }

                        else if (comboBox1.Text == "네이버")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                        }
                        else if (comboBox1.Text == "다음")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                        }
                        else if (comboBox1.Text == "네이트")
                        {
                            System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                        }
                    }
                }
            }

            else if (comboBox3.Text == "off")
            {
                if (comboBox2.Text == "크롬")
                {
                    if (comboBox1.Text == "구글")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                    }
                    else if (textBox1.Text == "개드립")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://www.dogdrip.net/");
                    }
                    else if (textBox1.Text == "네이버")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://www.naver.com/");
                    }
                    else if (textBox1.Text == "구글")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "https://www.google.co.kr/");
                    }
                    else if (textBox1.Text == "다음")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://www.daum.net/");
                    }

                    else if (textBox1.Text == "KPU")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://kpu.kdual.net/");
                    }

                    else if (textBox1.Text == "HRD")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://www.hrd.go.kr/");
                    }

                    else if (comboBox1.Text == "네이버")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                    }
                    else if (comboBox1.Text == "다음")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                    }
                    else if (comboBox1.Text == "네이트")
                    {
                        System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                    }
                }
                else if (comboBox2.Text == "IE")
                {
                    if (comboBox1.Text == "구글")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                    }
                    else if (textBox1.Text == "개드립")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://www.dogdrip.net/");
                    }
                    else if (textBox1.Text == "네이버")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://www.naver.com/");
                    }
                    else if (textBox1.Text == "구글")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "https://www.google.co.kr/");
                    }
                    else if (textBox1.Text == "다음")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://www.daum.net/");
                    }

                    else if (textBox1.Text == "KPU")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://kpu.kdual.net/");
                    }

                    else if (textBox1.Text == "HRD")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://www.hrd.go.kr/");
                    }

                    else if (comboBox1.Text == "네이버")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                    }
                    else if (comboBox1.Text == "다음")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                    }
                    else if (comboBox1.Text == "네이트")
                    {
                        System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                    }
                }
            }

            temp = "";
            str = "";


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Enter))
                {

                    string temp = textBox1.Text;
                    char[] strArray = temp.ToCharArray();


                    for (int w = 0; w < strArray.Length; w++)
                    {
                        if (strArray[w] == ' ')
                        {
                            str += "+";
                        }
                        else
                        {
                            str += strArray[w];
                        }
                    }

                    if (comboBox3.Text == "on")
                    {
                        if (string.IsNullOrEmpty(textBox1.Text))
                        {
                            MessageBox.Show("검색어를 먼저 입력해주세요");
                        }

                        else
                        {
                            if (comboBox2.Text == "크롬")
                            {
                                if (comboBox1.Text == "구글")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                                }
                                else if (textBox1.Text == "개드립")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://www.dogdrip.net/");
                                }
                                else if (textBox1.Text == "네이버")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://www.naver.com/");
                                }
                                else if (textBox1.Text == "구글")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "https://www.google.co.kr/");
                                }
                                else if (textBox1.Text == "다음")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://www.daum.net/");
                                }

                                else if (textBox1.Text == "KPU")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://kpu.kdual.net/");
                                }

                                else if (textBox1.Text == "HRD")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://www.hrd.go.kr/");
                                }

                                else if (comboBox1.Text == "네이버")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                                }
                                else if (comboBox1.Text == "다음")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                                }
                                else if (comboBox1.Text == "네이트")
                                {
                                    System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                                }
                            }
                            else if (comboBox2.Text == "IE")
                            {
                                if (comboBox1.Text == "구글")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                                }
                                else if (textBox1.Text == "개드립")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://www.dogdrip.net/");
                                }
                                else if (textBox1.Text == "네이버")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://www.naver.com/");
                                }
                                else if (textBox1.Text == "구글")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "https://www.google.co.kr/");
                                }
                                else if (textBox1.Text == "다음")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://www.daum.net/");
                                }

                                else if (textBox1.Text == "KPU")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://kpu.kdual.net/");
                                }

                                else if (textBox1.Text == "HRD")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://www.hrd.go.kr/");
                                }

                                else if (comboBox1.Text == "네이버")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                                }
                                else if (comboBox1.Text == "다음")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                                }
                                else if (comboBox1.Text == "네이트")
                                {
                                    System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                                }
                            }
                        }
                    }

                    else if (comboBox3.Text == "off")
                    {
                        if (comboBox2.Text == "크롬")
                        {
                            if (comboBox1.Text == "구글")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                            }
                            else if (textBox1.Text == "개드립")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://www.dogdrip.net/");
                            }
                            else if (textBox1.Text == "네이버")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://www.naver.com/");
                            }
                            else if (textBox1.Text == "구글")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "https://www.google.co.kr/");
                            }
                            else if (textBox1.Text == "다음")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://www.daum.net/");
                            }

                            else if (textBox1.Text == "KPU")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://kpu.kdual.net/");
                            }

                            else if (textBox1.Text == "HRD")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://www.hrd.go.kr/");
                            }


                            else if (comboBox1.Text == "네이버")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                            }
                            else if (comboBox1.Text == "다음")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                            }
                            else if (comboBox1.Text == "네이트")
                            {
                                System.Diagnostics.Process.Start("chrome.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                            }
                        }
                        else if (comboBox2.Text == "IE")
                        {
                            if (comboBox1.Text == "구글")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://www.google.co.kr/search?complete=1&hl=ko&q=" + str.ToString());
                            }
                            else if (textBox1.Text == "개드립")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://www.dogdrip.net/");
                            }
                            else if (textBox1.Text == "네이버")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://www.naver.com/");
                            }
                            else if (textBox1.Text == "구글")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "https://www.google.co.kr/");
                            }
                            else if (textBox1.Text == "다음")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://www.daum.net/");
                            }

                            else if (textBox1.Text == "KPU")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://kpu.kdual.net/");
                            }

                            else if (textBox1.Text == "HRD")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://www.hrd.go.kr/");
                            }

                            else if (comboBox1.Text == "네이버")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + str.ToString() + "&lr=&aq=f");
                            }
                            else if (comboBox1.Text == "다음")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/search?nil_suggest=btn&nil_ch=&rtupcoll=&w=tot&m=&lpp=&q=" + str.ToString());
                            }
                            else if (comboBox1.Text == "네이트")
                            {
                                System.Diagnostics.Process.Start("iexplore.exe", "http://search.daum.net/nate?thr=sbma&w=tot&q=" + str.ToString());
                            }
                        }
                    }

                    temp = "";
                    str = "";


                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by_MONG_"+Environment.NewLine+"on 상태는 검색어 입력을 하지않았을때 경고표시"+Environment.NewLine+"off 상태는 검색어 입력을 하지 않아도 경고를 표시하지 않음");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}