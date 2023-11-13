/*
- Author: Lucas Germinari Carreira.
- Date: 08/11/2023, version 1.1.
- Purpose: code for a GUI (Windows Form) scientific calculator.
- Tools: C#, Windows Forms IDE, .NET.
*/

/*
TODOs: 
-> backslash not making display go to zero right after last digit is erased (needs 1 more) -> why?
-> deal DECENTLY with error messages
    -> error messages (problems if attemp to apply math operation on them) -> set timer + temp. change color button
-> post operations with hex
 */

using System;
using System.Numerics;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //CLASS DECLARATIONS
        double firstVal, secondVal;
        string op;
        const string ERROR_DIV_ZERO = "Error: Division by zero", ERROR_FACT = "Factorials only work with positive integers", ERROR_GENERIC = "This operation is not allowed. Reseting to zero...";
        static int resultHandler_counter = 0;

        //FUNCTIONS
        public static int Factorial(int n)
        {
            /////recursive function for calculating the factorial of an integer
            
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }

        /*private void Timer_Tick(object sender, Button btn, System.Windows.Forms.Timer timer, Color originalColor,  EventArgs e)
        {
            // Calculate lerp ratio
            var ratio = (float)timer.ElapsedMilliseconds / 1000;

            // Linearly interpolate between colors 
            btn.BackColor = Color.FromArgb(
                (int)(ratio * originalColor.R +
                (1 - ratio) * btn.BackColor.R),
                (int)(ratio * originalColor.G +
                (1 - ratio) * btn.BackColor.G),
                (int)(ratio * originalColor.B +
                (1 - ratio) * btn.BackColor.B)
            );

            // Stop after 1 second
            if (timer.ElapsedMilliseconds >= 1000)
                timer.Stop();
        }*/

        public void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            /////calculates the factorial of an integer
            Button btn = (Button)sender;
            Color original = btn.BackColor;

            double num = Convert.ToDouble(txtBoxResult.Text);
            //is the double value is "equivalent" to its int version, calculate the factorial
            if (((int)num == num) && (num >= 0))
            {
                txtBoxResult.Text = Convert.ToString(Factorial((int)num));
            }
            else
            {
                txtBoxResult.Text = ERROR_FACT;
                /*btn.BackColor = Color.Red;
                var timer = new System.Windows.Forms.Timer()
                {
                    Interval = 500 //ms
                };
                timer.Start();
                timer.Tick += Timer_Tick;
                timer.Stop();
                btn.BackColor = original;*/
                //txtBoxResult.Text = ERROR_FACT;
            }
        }

        //CLASS METHODS
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNs(object sender, EventArgs e)
        {
            //cast object that triggered event (button) into correct type (Button class)
            Button number = (Button)sender;

            //deal with (.)
            if (txtBoxResult.Text == "0")
                txtBoxResult.Text = "";    
            {
                if(number.Text == ",")
                {
                    if (!txtBoxResult.Text.Contains(","))
                    {
                        //txtBoxResult.Text = txtBoxResult.Text + number.Text;
                        txtBoxResult.Text = txtBoxResult.Text + ",";
                    }
                }
                else
                {
                    txtBoxResult.Text = txtBoxResult.Text + number.Text;
                }
            }
        }

        private void BasicOps(object sender, EventArgs e)
        {
            //get operator chosen
            Button op_bf = (Button)sender;
            op = op_bf.Text; 
            //get first value entered in calculator
            firstVal = Convert.ToDouble(txtBoxResult.Text);
            //reset to allow for next value
            txtBoxResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //get second value entered by user
            secondVal = Convert.ToDouble(txtBoxResult.Text);
            
            //display result based on operation
            switch(op)
            {
                case "+":
                    txtBoxResult.Text = (firstVal+secondVal).ToString();
                    break;
                case "-":
                    txtBoxResult.Text = (firstVal - secondVal).ToString();
                    break; 
                case "*":
                    txtBoxResult.Text = (firstVal * secondVal).ToString();
                    break;
                case "/":
                    double result = firstVal / secondVal;
                    if(secondVal == 0)
                    {
                        txtBoxResult.Text = ERROR_DIV_ZERO;
                    }
                    else
                    {
                        txtBoxResult.Text = result.ToString();
                    }
                    break;
                case "mod":
                    txtBoxResult.Text = (firstVal%secondVal).ToString();
                    break;
                case "x^y":
                    txtBoxResult.Text = (Math.Pow(firstVal, secondVal)).ToString();
                    break;
                case "sqrt":
                    double r = Math.Pow(firstVal, 1.0 / secondVal);
                    //if (r)
                    //{ 
                        txtBoxResult.Text = (r).ToString(); 
                    //}
                    break;
                default:
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //reset result box to 0
            txtBoxResult.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //reset result box to 0
            txtBoxResult.Text = "0";

            //clear 1° and 2° entries
            string first, sec;
            first = Convert.ToString(firstVal);
            sec = Convert.ToString(secondVal);
            first = "";
            sec = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            ////// makes current entry negative of positive 

            //get current number on result box
            double num = Convert.ToDouble(txtBoxResult.Text);
            //make it negative or positive
            txtBoxResult.Text = Convert.ToString(-1 * num); 
        }

        private void btnBackslash_Click(object sender, EventArgs e)
        {
            string cur_num = txtBoxResult.Text;
            /////erases the last digit of the number currently on display
            if (cur_num.Length > 0)
            {
                txtBoxResult.Text = cur_num.Remove(cur_num.Length - 1, 1);
            }
            if (txtBoxResult.Text == "")
            {
                txtBoxResult.Text = "0";
            }
            //txtBoxResult.Text = cur_num;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //macro for number pi
            txtBoxResult.Text = (Math.PI).ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            //macro for Euler number
            txtBoxResult.Text = (Math.E).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //calculate log base 10
            double log = Math.Log10(Convert.ToDouble(txtBoxResult.Text));
            txtBoxResult.Text = log.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            //calculate log base e
            double log = Math.Log(Convert.ToDouble(txtBoxResult.Text));
            txtBoxResult.Text = log.ToString();     
        }



        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(txtBoxResult.Text);
            txtBoxResult.Text = Convert.ToString(val * 100);
        }

        private void btnTrig(object sender, EventArgs e)
        {
            //get button clicked
            Button btn = (Button)sender;
            //get name of the button to use on further selction structure and values to be used
            string btn_name = btn.Name;
            //get angle in degrees and convert to radian (align with Math class`s trig functions)
            double angle = Convert.ToDouble(txtBoxResult.Text)*(Math.PI/180);
            double result=0;
            
            //apply correct operation
            switch(btn_name)
            {
               
                case "btnSin":
                    result = Math.Sin(angle);
                    break;
                case "btnCos":
                    result= Math.Cos(angle);
                    break;
                case "btnTan":
                    result = Math.Tan(angle);
                    break;
                case "btnSinh":
                    result = Math.Sinh(angle);
                    break;
                case "btnCosh":
                    result = Math.Cosh(angle);
                    break;
                case "btnTanh":
                    result = Math.Tanh(angle);
                    break;
            }
            //display result
            txtBoxResult.Text = Convert.ToString(result);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            ////converts decimal to binary
            //get number in base 
            int num = Convert.ToInt32(txtBoxResult.Text);
            string binary = Convert.ToString(num, 2);
            txtBoxResult.Text = binary;
        }

        private void preDefExps(object sender, EventArgs e)
        {
            //get name of the button clicked and related operation
            Button btn = (Button)sender;
            string operation = btn.Name;
            double val = Convert.ToInt32(txtBoxResult.Text);
            double result=0;

            //perform operation
            switch (operation)
            {
                case "btnSquar":
                    result = Math.Pow(val, 2);
                    break;
                case "btnCube":
                    result = Math.Pow(val, 3);
                    break;
                case "btnSqrt":
                    result = Math.Sqrt(val);
                    break;
            }

            txtBoxResult.Text = Convert.ToString(result);
        }

        private void generalExps(object sender, EventArgs e)
        {
            /////compute general radicals and exponentials

            //local declarations
            Button btn = (Button)sender;
            double val1, val2;
            string operation = btn.Name;
            double resutl;

            //get first value
            val1 = Convert.ToDouble(txtBoxResult.Text);
            //reset result box 
            txtBoxResult.Text = "";
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            ////converts decimal to hex

            //get number in base 10
            int num = Convert.ToInt32(txtBoxResult.Text);
            string hex = num.ToString("X");
            txtBoxResult.Text = hex;
        }

        /*private void Form1_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
        }*/

        /*private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxResult.Text = "0";
        }*/

        private void ResultHandler(object sender, EventArgs e)
        {
            if ((txtBoxResult.Text.Contains(ERROR_DIV_ZERO))|| txtBoxResult.Text.Contains(ERROR_FACT) || txtBoxResult.Text.Contains(ERROR_GENERIC)|| txtBoxResult.Text=="NaN")
            {
                labelError.Text = ERROR_GENERIC;
                txtBoxResult.Text = "0";
            }
            else if (txtBoxResult.Text!="0")
            {
                labelError.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
