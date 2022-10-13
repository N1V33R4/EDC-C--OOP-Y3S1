using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDC
{
    public partial class Form1 : Form
    {
        EDC obj = new EDC();

        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            meterNumTb.Clear();
            newReadTb.Clear();
            oldReadTb.Clear();
            consumeTb.Clear();
            rateTb.Clear();
            totalTb.Clear();

            obj.Clear();
        }

        private void calcConsumeBtn_Click(object sender, EventArgs e)
        {
            SetData();
            consumeTb.Text = obj.CalcConsume();
        }

        private void SetData()
        {
            try
            {
                obj.MeterNum = int.Parse(meterNumTb.Text);
                obj.OldReading = int.Parse(oldReadTb.Text);
                obj.NewReading = int.Parse(newReadTb.Text);
                obj.Rate = int.Parse(rateTb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter data to all textboxes, except Consuming Wat and Total Amount.", "User Error");
            }
        }

        private void calcTotalBtn_Click(object sender, EventArgs e)
        {
            if (consumeTb.Text == "")
            {
                MessageBox.Show("Please calculate comsumed watts first.", "Caution");
                return;
            }
            SetData();
            totalTb.Text = obj.CalcTotal();
        }

        private void meterNumTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void oldReadTb_TextChanged(object sender, EventArgs e)
        {
            consumeTb.Text = "";
            totalTb.Text = "";
        }

        private void newReadTb_TextChanged(object sender, EventArgs e)
        {
            consumeTb.Text = "";
            totalTb.Text = "";
        }

        private void rateTb_TextChanged(object sender, EventArgs e)
        {
            totalTb.Text = "";
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            if (consumeTb.Text == "" || totalTb.Text == "")
            {
                MessageBox.Show("Please calculate the Consuming Wat and Total Amount.");
            }
            else
            {
                var frm = new frmPrint(obj);
                frm.Show();
            }
        }
    }
}
