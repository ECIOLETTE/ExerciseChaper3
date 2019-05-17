using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseChapter03
{
    public class frmMain : Form
    {
        private Label label2;
        private TextBox txtOperand1;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btnCalc;
        private Button btnExit;
        private Label label1;
        #region Windows Code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Integer Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Second Integer Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(186, 45);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(128, 20);
            this.txtOperand1.TabIndex = 0;
            this.txtOperand1.TextChanged += new System.EventHandler(this.TxtOperand1_TextChanged);
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(187, 78);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(128, 20);
            this.txtOperand2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(30, 116);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(285, 20);
            this.txtResult.TabIndex = 10;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextChanged += new System.EventHandler(this.TxtResult_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(30, 157);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(340, 199);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interger Division";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        [STAThread]
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtOperand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            float operand1;
            float operand2;
            float answer;
            // First step is input validation value 1
            flag = float.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("The first value you entered is not a number: " + txtOperand1.Text);
                txtOperand1.Focus();
                // Stop the execution of the remaining code
                return;
            }
            // Second step is input validation for value 2
            flag = float.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("The second value you entered is not number: " + txtOperand2.Text);
                txtOperand2.Focus();
                // Stop the execution of the remaining code
                return;
            }
            // PROCESS STEP (of your Five Step Plan)
            answer = operand1 / operand2;
            // DISPLAY STEP (of your Five Step Plan)
            txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString()
                + " equals " + answer.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
