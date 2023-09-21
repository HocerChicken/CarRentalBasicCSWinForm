namespace Lab2_Bai02
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            listBox = new ListBox();
            txtRentalDays = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            btnGetQuotes = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lbBaseRental = new Label();
            lbSateRatio = new Label();
            lbGPS = new Label();
            lbTax = new Label();
            lbTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Car Rental System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 106);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 2;
            label2.Text = "Rental Days";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(459, 110);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 5;
            label5.Text = "Quote Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 142);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Base Rental";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 174);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 7;
            label7.Text = "Satellite Ratio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 209);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 8;
            label8.Text = "GPS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(459, 243);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 9;
            label9.Text = "Tax";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(459, 277);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 10;
            label10.Text = "Total";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Items.AddRange(new object[] { "Economy", "Midsize", "Premeium", "SUV" });
            listBox.Location = new Point(93, 174);
            listBox.Name = "listBox";
            listBox.Size = new Size(198, 94);
            listBox.TabIndex = 11;
            // 
            // txtRentalDays
            // 
            txtRentalDays.Location = new Point(93, 134);
            txtRentalDays.Name = "txtRentalDays";
            txtRentalDays.Size = new Size(198, 23);
            txtRentalDays.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(93, 289);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Satellite Ratio";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(93, 314);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(47, 19);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "GPS";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnGetQuotes
            // 
            btnGetQuotes.Location = new Point(143, 349);
            btnGetQuotes.Name = "btnGetQuotes";
            btnGetQuotes.Size = new Size(120, 43);
            btnGetQuotes.TabIndex = 15;
            btnGetQuotes.Text = "Get Quotes";
            btnGetQuotes.UseVisualStyleBackColor = true;
            btnGetQuotes.Click += btnGetQuotes_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(328, 349);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 43);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(501, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 43);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbBaseRental
            // 
            lbBaseRental.AutoSize = true;
            lbBaseRental.Location = new Point(635, 141);
            lbBaseRental.Name = "lbBaseRental";
            lbBaseRental.Size = new Size(28, 15);
            lbBaseRental.TabIndex = 18;
            lbBaseRental.Text = "0.00";
            // 
            // lbSateRatio
            // 
            lbSateRatio.AutoSize = true;
            lbSateRatio.Location = new Point(635, 174);
            lbSateRatio.Name = "lbSateRatio";
            lbSateRatio.Size = new Size(28, 15);
            lbSateRatio.TabIndex = 19;
            lbSateRatio.Text = "0.00";
            // 
            // lbGPS
            // 
            lbGPS.AutoSize = true;
            lbGPS.Location = new Point(635, 209);
            lbGPS.Name = "lbGPS";
            lbGPS.Size = new Size(28, 15);
            lbGPS.TabIndex = 20;
            lbGPS.Text = "0.00";
            // 
            // lbTax
            // 
            lbTax.AutoSize = true;
            lbTax.Location = new Point(635, 243);
            lbTax.Name = "lbTax";
            lbTax.Size = new Size(28, 15);
            lbTax.TabIndex = 21;
            lbTax.Text = "0.00";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(635, 277);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(31, 15);
            lbTotal.TabIndex = 22;
            lbTotal.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTotal);
            Controls.Add(lbTax);
            Controls.Add(lbGPS);
            Controls.Add(lbSateRatio);
            Controls.Add(lbBaseRental);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnGetQuotes);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(txtRentalDays);
            Controls.Add(listBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox listBox;
        private TextBox txtRentalDays;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button btnGetQuotes;
        private Button btnReset;
        private Button btnExit;
        private Label lbBaseRental;
        private Label lbSateRatio;
        private Label lbGPS;
        private Label lbTax;
        private Label lbTotal;
    }
}