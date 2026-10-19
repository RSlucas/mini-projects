namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tx1 = new TextBox();
            txoperator = new TextBox();
            tx2 = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 68);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tx1
            // 
            tx1.Font = new Font("Segoe UI", 15F);
            tx1.Location = new Point(90, 71);
            tx1.Name = "tx1";
            tx1.PlaceholderText = "Enter number 1";
            tx1.Size = new Size(203, 34);
            tx1.TabIndex = 1;
            tx1.TextAlign = HorizontalAlignment.Center;
            // 
            // txoperator
            // 
            txoperator.Font = new Font("Segoe UI", 15F);
            txoperator.Location = new Point(90, 196);
            txoperator.Name = "txoperator";
            txoperator.PlaceholderText = "(+, -, *, /)";
            txoperator.Size = new Size(203, 34);
            txoperator.TabIndex = 2;
            txoperator.TextAlign = HorizontalAlignment.Center;
            // 
            // tx2
            // 
            tx2.Font = new Font("Segoe UI", 15F);
            tx2.Location = new Point(90, 132);
            tx2.Name = "tx2";
            tx2.PlaceholderText = "Enter number 2";
            tx2.Size = new Size(203, 34);
            tx2.TabIndex = 3;
            tx2.TextAlign = HorizontalAlignment.Center;
            tx2.TextChanged += textBox2_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 15F);
            btnCalculate.Location = new Point(90, 259);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(203, 59);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 14F);
            lblResult.Location = new Point(90, 337);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(203, 23);
            lblResult.TabIndex = 5;
            lblResult.Text = "0";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 401);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(tx2);
            Controls.Add(txoperator);
            Controls.Add(tx1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx1;
        private TextBox txoperator;
        private TextBox tx2;
        private Button btnCalculate;
        private Label lblResult;
    }
}
