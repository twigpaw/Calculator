
namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OperationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEval = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonUnaryMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonBackSpace = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.CalculatorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelInput = new System.Windows.Forms.Label();
            this.PanelHistory = new System.Windows.Forms.Label();
            this.OperationPanel.SuspendLayout();
            this.CalculatorPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationPanel
            // 
            resources.ApplyResources(this.OperationPanel, "OperationPanel");
            this.OperationPanel.Controls.Add(this.ButtonEval, 3, 4);
            this.OperationPanel.Controls.Add(this.ButtonDot, 2, 4);
            this.OperationPanel.Controls.Add(this.Button0, 1, 4);
            this.OperationPanel.Controls.Add(this.ButtonUnaryMinus, 0, 4);
            this.OperationPanel.Controls.Add(this.ButtonPlus, 3, 3);
            this.OperationPanel.Controls.Add(this.Button3, 2, 3);
            this.OperationPanel.Controls.Add(this.Button2, 1, 3);
            this.OperationPanel.Controls.Add(this.Button1, 0, 3);
            this.OperationPanel.Controls.Add(this.ButtonMinus, 3, 2);
            this.OperationPanel.Controls.Add(this.Button6, 2, 2);
            this.OperationPanel.Controls.Add(this.Button5, 1, 2);
            this.OperationPanel.Controls.Add(this.Button4, 0, 2);
            this.OperationPanel.Controls.Add(this.ButtonMultiply, 3, 1);
            this.OperationPanel.Controls.Add(this.Button9, 2, 1);
            this.OperationPanel.Controls.Add(this.Button8, 1, 1);
            this.OperationPanel.Controls.Add(this.Button7, 0, 1);
            this.OperationPanel.Controls.Add(this.ButtonDivide, 3, 0);
            this.OperationPanel.Controls.Add(this.ButtonBackSpace, 2, 0);
            this.OperationPanel.Controls.Add(this.ButtonC, 1, 0);
            this.OperationPanel.Controls.Add(this.ButtonCE, 0, 0);
            this.OperationPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OperationPanel.Name = "OperationPanel";
            // 
            // ButtonEval
            // 
            this.ButtonEval.BackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.ButtonEval, "ButtonEval");
            this.ButtonEval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonEval.Name = "ButtonEval";
            this.ButtonEval.UseVisualStyleBackColor = false;
            this.ButtonEval.Click += new System.EventHandler(this.ButtonEval_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonDot, "ButtonDot");
            this.ButtonDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button0, "Button0");
            this.Button0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button0.Name = "Button0";
            this.Button0.Tag = "Number";
            this.Button0.UseVisualStyleBackColor = false;
            // 
            // ButtonUnaryMinus
            // 
            this.ButtonUnaryMinus.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonUnaryMinus, "ButtonUnaryMinus");
            this.ButtonUnaryMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonUnaryMinus.Name = "ButtonUnaryMinus";
            this.ButtonUnaryMinus.UseVisualStyleBackColor = false;
            this.ButtonUnaryMinus.Click += new System.EventHandler(this.ButtonUnaryMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonPlus, "ButtonPlus");
            this.ButtonPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Tag = "BinaryOperation";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button3, "Button3");
            this.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button3.Name = "Button3";
            this.Button3.Tag = "Number";
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button2, "Button2");
            this.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button2.Name = "Button2";
            this.Button2.Tag = "Number";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button1, "Button1");
            this.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button1.Name = "Button1";
            this.Button1.Tag = "Number";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonMinus, "ButtonMinus");
            this.ButtonMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Tag = "BinaryOperation";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button6, "Button6");
            this.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button6.Name = "Button6";
            this.Button6.Tag = "Number";
            this.Button6.UseVisualStyleBackColor = false;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button5, "Button5");
            this.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button5.Name = "Button5";
            this.Button5.Tag = "Number";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button4, "Button4");
            this.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button4.Name = "Button4";
            this.Button4.Tag = "Number";
            this.Button4.UseVisualStyleBackColor = false;
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonMultiply, "ButtonMultiply");
            this.ButtonMultiply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Tag = "BinaryOperation";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button9, "Button9");
            this.Button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button9.Name = "Button9";
            this.Button9.Tag = "Number";
            this.Button9.UseVisualStyleBackColor = false;
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button8, "Button8");
            this.Button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button8.Name = "Button8";
            this.Button8.Tag = "Number";
            this.Button8.UseVisualStyleBackColor = false;
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Button7, "Button7");
            this.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button7.Name = "Button7";
            this.Button7.Tag = "Number";
            this.Button7.UseVisualStyleBackColor = false;
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonDivide, "ButtonDivide");
            this.ButtonDivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Tag = "BinaryOperation";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            // 
            // ButtonBackSpace
            // 
            this.ButtonBackSpace.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonBackSpace, "ButtonBackSpace");
            this.ButtonBackSpace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBackSpace.Name = "ButtonBackSpace";
            this.ButtonBackSpace.UseVisualStyleBackColor = false;
            this.ButtonBackSpace.Click += new System.EventHandler(this.ButtonBackSpace_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonC, "ButtonC");
            this.ButtonC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ButtonCE, "ButtonCE");
            this.ButtonCE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.UseVisualStyleBackColor = false;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // CalculatorPanel
            // 
            this.CalculatorPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.CalculatorPanel, "CalculatorPanel");
            this.CalculatorPanel.Controls.Add(this.OperationPanel, 0, 1);
            this.CalculatorPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.CalculatorPanel.Name = "CalculatorPanel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.PanelInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PanelHistory, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // PanelInput
            // 
            resources.ApplyResources(this.PanelInput, "PanelInput");
            this.PanelInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelInput.Name = "PanelInput";
            // 
            // PanelHistory
            // 
            resources.ApplyResources(this.PanelHistory, "PanelHistory");
            this.PanelHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelHistory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PanelHistory.Name = "PanelHistory";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.CalculatorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.OperationPanel.ResumeLayout(false);
            this.CalculatorPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OperationPanel;
        private System.Windows.Forms.Button ButtonEval;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonUnaryMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonBackSpace;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.TableLayoutPanel CalculatorPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PanelInput;
        private System.Windows.Forms.Label PanelHistory;
    }
}

