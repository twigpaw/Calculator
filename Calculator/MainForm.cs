using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OperationHandlers = new Dictionary<String, BinaryOperation> { };


            foreach (var control in OperationPanel.Controls)
            {
                var button = control as Button;
                var tag = button.Tag as String;
                if (tag == "Number") button.Click += OnNumberButtonClick;
                if (tag == "BinaryOperation")
                {
                    button.Click += OnOperatorButtonClick;
                    var operation = new BinaryOperation(button.Text);
                    OperationHandlers.Add(button.Text, operation);
                }
                button.Click += (object sender, EventArgs e) => UpdateLabels();
                Input = new InputHandler();
            }
        }

        private Dictionary<String, BinaryOperation> OperationHandlers;
        private BinaryOperation CurrentOperation;

        private double? left = null;
        private double? right = null;

        private InputHandler Input;
        private string History;
        private void UpdateLabels()
        {
            PanelInput.Text = Input.ToString();
            PanelHistory.Text = History;
        }
        private void OnNumberButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            Input.addSymbol(button.Text[0]);
        }

        private void OnOperatorButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (CurrentOperation is null)
            {
                CurrentOperation = OperationHandlers[button.Text];
                left = Input.ToDouble();
                if (left is null) return;
                History = left.ToString() + CurrentOperation.ToString();
                Input.init(left.GetValueOrDefault());
            }
            else
            {
                var result = Evaluate();
                CurrentOperation = OperationHandlers[button.Text];
                History = result.ToString() + CurrentOperation.ToString();
                Input.init(result);
            }
        }

        private void ButtonEval_Click(object sender, EventArgs e)
        {
            if (!(CurrentOperation is null))
            {
                History = left + " " + CurrentOperation + Input + "=";
                var result = Evaluate();
                Input.init(result);
                left = result;
            }
        }

        private double Evaluate()
        {
            if (!(CurrentOperation is null))
            {
                right = Input.ToDouble();
                if (left.HasValue && right.HasValue)
                {
                    var result = CurrentOperation.Evaluate(left.Value, right.Value);
                    Input.init(result);

                    CurrentOperation = null;
                    left = result;
                    return result;
                }
                else return 0;
            }
            else return 0;
        }
        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            Input.Backspace();
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            Input.addSymbol('.');
        }


        private void ButtonCE_Click(object sender, EventArgs e)
        {
            Input.init(0);
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            Input.init(0);
            History = "";
            left = null;
            right = null;
        }

        private void ButtonUnaryMinus_Click(object sender, EventArgs e)
        {
            Input.InverseSign();
        }
    }
}

