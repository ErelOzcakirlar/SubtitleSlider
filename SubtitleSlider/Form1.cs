using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SubtitleSlider
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DirectionCB.SelectedIndex = 0;
        }

        private void GetFile_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            FileLocation.Text = FileDialog.FileName;
        }

        private void Slide_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SlideTB.Text))
            {
                MessageBox.Show("Lütfen milisaniye türünde bir kayma miktarı girin");
            }
            else if (String.IsNullOrEmpty(FileLocation.Text))
            {
                MessageBox.Show("Lütfen bir SRT dosyası belirtin");
            }
            else
            {
                try
                {
                    int Slider = int.Parse(SlideTB.Text);
                    if (File.Exists(FileLocation.Text))
                    {
                        String AllFile = File.ReadAllText(FileLocation.Text, Encoding.Default);
                        String[] Nodes = mySplit("\r\n\r\n", AllFile, int.MaxValue, true);
                        List<Node> NodeList = new List<Node>();
                        for (int i = 0; i < Nodes.Length; i++)//Seperate Nodes
                        {
                            String[] CurrentNodeStrings = mySplit("\r\n", Nodes[i], 3, true);
                            Node CurrentNode = new Node();
                            CurrentNode.Pointer = int.Parse(CurrentNodeStrings[0]);
                            String[] CurrentTimeStrings = mySplit(" --> ", CurrentNodeStrings[1], 2, true);
                            CurrentNode.setStart(CurrentTimeStrings[0]);
                            CurrentNode.setEnd(CurrentTimeStrings[1]);
                            CurrentNode.Value = CurrentNodeStrings[2];
                            NodeList.Add(CurrentNode);
                        }
                        if (DirectionCB.SelectedIndex == 0)//Kaydırma yönünü belirle
                        {
                            foreach (Node item in NodeList)
                            {
                                if (!item.decrease(Slider))
                                {
                                    MessageBox.Show("Belirttiğiniz miktar ilk yazının görüntülenme süresinden daha büyük");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            foreach (Node item in NodeList)
                            {
                                if (!item.increase(Slider))
                                {
                                    MessageBox.Show("Belirttiğiniz miktar son yazının görüntülenme süresine eklendiğinde 100 saati aşıyor");
                                    break;
                                }
                            }
                        }
                        AllFile = "";
                        foreach (Node item in NodeList)
                        {
                            AllFile += item.print();
                        }
                        Content.Text = AllFile;
                    }
                    else
                    {
                        MessageBox.Show("Sistem belirtilen dosyayı bulamıyor");
                    }

                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Lütfen milisaniye türünde bir kayma miktarı girin");
                }
                catch (OverflowException oe)
                {
                    MessageBox.Show("100 saatten düşük bir değer girin");
                }
            }
        }

        public static String[] mySplit(String Seperator, String toSeperate, int maxPartCount, bool removeEmpties)
        {
            List<String> Parts = new List<String>();
            String CurrentPart = "";
            for (int i = 0; i < toSeperate.Length; i++)
            {
                if (toSeperate[i] != Seperator[0])
                {
                    CurrentPart += toSeperate[i];
                }
                else
                {
                    if (Parts.Count < maxPartCount - 1)
                    {
                        String toCompare = toSeperate.Substring(i, Seperator.Length);
                        if (Seperator.Equals(toCompare))
                        {
                            Parts.Add(CurrentPart);
                            CurrentPart = "";
                            i += Seperator.Length - 1;
                            if (removeEmpties)
                            {
                                Parts.Remove("");
                            }
                        }
                        else
                        {
                            CurrentPart += toSeperate[i];
                        }
                    }
                    else
                    {
                        CurrentPart += toSeperate[i];
                    }


                }
            }
            Parts.Add(CurrentPart);
            if (removeEmpties)
            {
                Parts.Remove("");
            }
            return Parts.ToArray();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Content.Text))
            {
                MessageBox.Show("Henüz bir işlem yapmadınız");
            }
            else
            {
                if (File.Exists(FileLocation.Text))
                {
                    String[] Lines = mySplit("\n", Content.Text, int.MaxValue, false); 
                    File.WriteAllLines(FileLocation.Text, Lines, Encoding.Default );
                    MessageBox.Show("Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Sistem belirtilen dosyayı bulamıyor");
                }
            }
        }
    }
}
