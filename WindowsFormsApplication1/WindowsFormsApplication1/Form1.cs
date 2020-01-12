using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//using System;
using System.Threading; 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Calculation> allTextDisplays = new List<Calculation>();

        public Button ButtonCalculate{ get{return buttonCalculate;}}

        public Form1()
        {
            InitializeComponent();

            allTextDisplays.Add(new Calculation(textDisplay1));
            allTextDisplays.Add(new Calculation(textDisplay2));
            allTextDisplays.Add(new Calculation(textDisplay3));
            allTextDisplays.Add(new Calculation(textDisplay4));
            allTextDisplays.Add(new Calculation(textDisplay5));
            allTextDisplays.Add(new Calculation(textDisplay6));
            allTextDisplays.Add(new Calculation(textDisplay7));
            allTextDisplays.Add(new Calculation(textDisplay8));
            allTextDisplays.Add(new Calculation(textDisplay9));
            Calculation.calculationFinished += EnableButton;
        }

        public void EnableButton()
        {
            buttonCalculate.Invoke((Action)delegate
            {
                buttonCalculate.Enabled = true;
            }
);
            
            //buttonCalculate.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //allTextDisplays[0].CalculatePrimeNumbers();
            foreach(Calculation textDisplay in allTextDisplays)
            {
                if(textDisplay.InUse == false)
                {
                    textDisplay.CalculatePrimeNumbers();
                    break;
                    //return;
                }
            }
            bool allButtonsInUse = true;
            foreach (Calculation textDisplay in allTextDisplays)
            {
                if (textDisplay.InUse == false) { allButtonsInUse = false; }
            }
            if(allButtonsInUse)
            {
                buttonCalculate.Enabled = false;
            }
            
        }
    }


    class Calculation
    {
        public delegate void CalculationEvent();

        public static event CalculationEvent calculationFinished;

        public System.Windows.Forms.TextBox textDisplay;
        private bool inUse = false;
        public bool InUse { get { return inUse; } }

        public Calculation(System.Windows.Forms.TextBox textDisplay)
        {
            this.textDisplay = textDisplay;
            
        }

        public void CalculatePrimeNumbers()
        {
            inUse = true;
            Thread thread = new Thread(test)
            {
                Name = "testThread"
            };
            thread.Start();
            /*
            inUse = true;
            for (int i = 1; i <= 150; i++)
            {
                //Thread.Sleep(10);
                //Console.WriteLine(i);
                textDisplay.Text = i.ToString();
            }
            inUse = false;*/
        }
        private void test()
        {
            for (int i = 2; i <= 150; i++) //go through numbers 2 - 150
            {
                bool isPrime = true;
                for (int y = 2; y < i;y++) //go through all numbers preceeding the current number 
                {
                    if(i % y == 0) //if this happens (numbers evenly divide), it is not a prime number
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Thread.Sleep(1000);

                    //Console.WriteLine(i);
                    textDisplay.Invoke((Action)delegate
                    {
                        textDisplay.Text = i.ToString();
                    }
                    );
                }
                    /*
                    if (true) //Calculation to determine if prime number
                    {
                        Thread.Sleep(1000);

                        //Console.WriteLine(i);
                        textDisplay.Invoke((Action)delegate
                        {
                            textDisplay.Text = i.ToString();
                        }
                        );

                    }*/
                
                /*
                Thread.Sleep(100);
                
                //Console.WriteLine(i);
                textDisplay.Invoke((Action)delegate
                {
                    textDisplay.Text = i.ToString();
                }
                );
                //textDisplay.Text = i.ToString();
                //inUse = false;*/
            }
            inUse = false;
            //calculationFinished?.invoke();
            calculationFinished.Invoke(); //used to reenable the button

            

        }


    }


}
