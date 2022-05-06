using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCalculator
{
    public partial class Form1 : Form
    {
        private const string switchErrorMessage = "Error getting the value for plus, minus, multiply or divide.";

        private List<CalculationHistoryItem> CalculationHistory { get; set; } = new List<CalculationHistoryItem>();
        private double Result { get; set; }
        private bool RememberInput { get; set; } = false;

        public Form1()
        {
            InitializeComponent();

            CalculationHistory = new List<CalculationHistoryItem>();
        }

        //Events
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Get Input
            CalculationOperators operator_ = getCurrentOperator();

            double inputNumber = 0;
            if (!double.TryParse(txtInput.Text, out inputNumber)) {
                ShowError("Please enter a valid number");
                return;
            }

            //Process Input
            if (CalculationHistory.Count == 0)
            {
                //Its the first number so just set the answer to that number
                operator_ = CalculationOperators.none;
                Result = inputNumber;
                ShowLog(inputNumber.ToString());
            }
            else
            {
                //Calculate the result
                Result = Calculate(Result, inputNumber, operator_);
            }

            CalculationHistory.Add(new CalculationHistoryItem() { Value = inputNumber, _Operator = operator_ });

            //Show Output
            txtOutput.Text = Result.ToString();

            //Reset state
            ClearInputField();
            txtInput.Select(); //Give focus to the input field again
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Validation
            if (CalculationHistory.Count < 2)
            {
                ClearState();
            }
            else
            {
                //remove last history item
                CalculationHistory.RemoveAt(CalculationHistory.Count - 1);

                //Clear log
                txtLog.Text = string.Empty;

                //Re-calculate the entire thing
                double result = 0;

                foreach (var historyItem in CalculationHistory)
                {
                    result = Calculate(result, historyItem.Value, historyItem._Operator);
                }

                Result = result; //Store the last calculated result in a global variable.

                //Show output
                txtOutput.Text = result.ToString();

                //Reset state
                txtInput.Select(); //Give focus to the input field again

            }

            
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            ClearInputField();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearState();
        }

        //Helper methods
        private double Calculate(double baseNumber, double inputNumber, CalculationOperators operator_)
        {
            double result = 0;

            switch (operator_)
            {
                default:
                    {
                        result = inputNumber;
                        txtLog.Text = inputNumber.ToString();
                        break;
                    }
                case CalculationOperators.plus:
                    {
                        result = baseNumber + inputNumber;
                        txtLog.Text += " + " + inputNumber;
                        break;
                    }
                case CalculationOperators.minus:
                    {
                        result = baseNumber - inputNumber;
                        txtLog.Text += " - " + inputNumber;
                        break;
                    }
                case CalculationOperators.multiply:
                    {
                        result = baseNumber * inputNumber;
                        txtLog.Text += " * " + inputNumber;
                        break;
                    }
                case CalculationOperators.divide:
                    {
                        result = baseNumber / inputNumber;
                        txtLog.Text += " / " + inputNumber;
                        break;
                    }
            }

            return result;
        }

        private void ShowLog(string message)
        {
            txtLog.ForeColor = Color.Black;
            txtLog.Text = message;
        }

        private CalculationOperators getCurrentOperator()
        {
            if (radioPlus.Checked)
            {
                return CalculationOperators.plus;
            }
            else if (radioMinus.Checked)
            {
                return CalculationOperators.minus;
            }
            else if (radioMultiply.Checked)
            {
                return CalculationOperators.multiply;
            }
            else if (radioDivide.Checked)
            {
                return CalculationOperators.divide;
            }

            throw new ArgumentNullException(switchErrorMessage);
        }

        private void ShowError(string errorMessage)
        {
            //txtError.Enabled = true;
            //txtError.Visible = true;
            //txtError.Text = errorMessage;   

            txtOutput.Text = errorMessage;
        }

        private void RemoveError()
        {
            txtOutput.Text = string.Empty;

            //txtError.Visible = false;
            //txtError.Text = string.Empty;
            //txtError.Enabled = false;
        }

        private void ClearState()
        {
            txtOutput.Text = string.Empty;
            txtInput.Text = string.Empty;
            txtLog.Text = string.Empty;
            checkRememberInput.Checked = false;

            CalculationHistory = new List<CalculationHistoryItem>();
            Result = 0;

            txtInput.Select(); //Give focus to the input field again
        }

        private void ClearInputField()
        {
            if (!RememberInput)
            {
                txtInput.Text = string.Empty;

            }

            txtInput.Select();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            txtInput.Select();
        }

        private void checkRememberInput_CheckedChanged(object sender, EventArgs e)
        {
            RememberInput = checkRememberInput.Checked;
            txtInput.Select();
        }

        private void txtOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }
    }

    public enum CalculationOperators
    {
        none, plus, minus, multiply, divide
    }

    public class CalculationHistoryItem{
        public double Value;
        public CalculationOperators _Operator;
    }

}
