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

namespace Domaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnExit(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcija = MessageBox.Show("Da li ste sigurni da zelite da izadjete iz programa? ", "Application Exit", MessageBoxButtons.YesNo);
                if(opcija == DialogResult.Yes)
                {
                    Application.Exit();
                   }
                return;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExitApp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    DialogResult opcija = MessageBox.Show("Da li ste sigurni da zelite da izadjete iz programa? ", "Application Exit", MessageBoxButtons.YesNo);
                    switch (opcija)
                    {
                        case DialogResult.Yes:
                            Application.Exit();
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnOpen(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Txt files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.FileName != "")
                    {
                        if (Path.GetExtension(open.FileName) == ".rtf")
                        {
                            rtBox.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            rtBox.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }

        private void fontBoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, FontStyle.Bold);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void fontItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, FontStyle.Italic);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog font = new FontDialog();
                if(font.ShowDialog() == DialogResult.OK)
                {
                    rtBox.SelectionFont = font.Font;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog color = new ColorDialog();
                if(color.ShowDialog() == DialogResult.OK)
                {
                    rtBox.SelectionColor = color.Color;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "RTF Format (*.rtf)|*.rtf";
            bool izvrsi = true;
            try
            {
                while(izvrsi)
                {
                    if (rtBox.Text == "")
                    {
                        MessageBox.Show("Morate uneti neki tekst da bi ste ga sacuvali");
                        break;
                    }
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        string sacuvaj = save.FileName;
                        rtBox.SaveFile(sacuvaj);
                        MessageBox.Show("Faj uspesno sacuvan");
                        rtBox.Text = " ";
                        izvrsi = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            string proveri_rich = rtBox.Text.Trim();
            string proveri_pronadji = txPronadji.Text.Trim();
            string proveri_zameni = txZameni.Text.Trim();
            bool proveri = true;
            while(proveri)
            {
                try
                {
                    if (proveri_rich == "")
                    {
                        MessageBox.Show("RichtextBox mora sadrzati tekst ");
                        rtBox.Focus();
                        break;
                    }
                    else if (proveri_pronadji == "")
                    {
                        MessageBox.Show("Tekst koji se trazi mora imati neku vrednost");
                        txPronadji.Focus();
                        break;
                    }
                    else if (proveri_zameni == "")
                    {
                        MessageBox.Show("Polje za zamenu ne sme biti prazno");
                        txZameni.Focus();
                        break;
                    }
                    string novi = proveri_rich.Replace(proveri_pronadji, proveri_zameni);
                    rtBox.Text = novi;
                    proveri = false;
                     
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }
    }
}
