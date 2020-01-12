using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<TextBox> _displayList = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            _displayList.Add(textDisplay1);
            _displayList.Add(textDisplay2);
            _displayList.Add(textDisplay3);
            _displayList.Add(textDisplay4);
            _displayList.Add(textDisplay5);
            _displayList.Add(textDisplay5);
            _displayList.Add(textDisplay6);
            _displayList.Add(textDisplay7);
            _displayList.Add(textDisplay8);
            _displayList.Add(textDisplay9);
        }

        ~Form1()
        {

        }

        public void EnableButton()
        {
            if (InvokeRequired)
                Invoke((Action)(() => { EnableButton(); }));

            buttonCalculate.Enabled = _displayList.Where(tx => tx.Tag == null).Count() > 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox t = _displayList.Where(tx => tx.Tag == null).FirstOrDefault();

                if (t == null) MessageBox.Show("All in use!!");

                t.Tag = new Calculation();
                ((Calculation)t.Tag).CalculatePrimeNumbers();

                ((Calculation)t.Tag).CalculationFinished += () =>
                {
                    t.Tag = null;
                    EnableButton();
                };

                ((Calculation)t.Tag).NewNumber += (int number) =>
                {
                    Invoke((Action)(() => { t.Text = number.ToString(); }));
                };

                EnableButton();
            }
            catch (ObjectDisposedException)
            { 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TextBox tx in _displayList)
            {
                tx.Tag = null;
            }
        }
    }
}
