using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memori_Game_Blasius
{

  public partial class Form1 : Form
  {
    int randomnumber;
    Random r = new Random();

    List<string> bildern = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "K", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

    Label premierclick, secondclick;

    public Form1()
    {
      InitializeComponent();
      maMethode();
    }


    private void lbl_Click(object sender, EventArgs e)
    {
      if (premierclick != null && secondclick != null)
      {
        return;
      }
        Label bildern = sender as Label;
      if (bildern == null)
      {
        return;
      }
      if (bildern.ForeColor == Color.Black)
      {
        return;
      }
      if (premierclick == null)
      {
        premierclick = bildern;
        premierclick.ForeColor = Color.Black;
      }
      secondclick = bildern;
      timer1.Start();
      //if (premierclick == bildern || secondclick == bildern)
      //{
      //    const string message = "du hast verloren";
      //    const string infos = "Achtung";
      //    var ausgabe = MessageBox.Show(message, infos, MessageBoxButtons.OK, MessageBoxIcon.Error);
       
      //}
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void timer(object sender, EventArgs e)
    {
      timer1.Stop();
      premierclick.ForeColor = premierclick.BackColor;
      secondclick.ForeColor = secondclick.BackColor;
       
      premierclick = null;
      secondclick = null;
    }

        private void maMethode()
        {
            Label label;

            //for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            //{
            //    if (tableLayoutPanel1.Controls[i] is Label)
            //    {
            //        label = (Label)tableLayoutPanel1.Controls[i];
            //    }
            //    else { continue; }
            //    randomnumber = r.Next(0, bildern.Count);
            //    label.Text = bildern[randomnumber];
            //    bildern.RemoveAt(randomnumber);

            //}
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
            }
        }
    }
}