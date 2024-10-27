namespace CS311_Project_2_JFV
{
    partial class frmMain
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
            lblDie1 = new Label();
            lblDie2 = new Label();
            lblBank = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblDie1
            // 
            lblDie1.AutoSize = true;
            lblDie1.Location = new Point(402, 43);
            lblDie1.Name = "lblDie1";
            lblDie1.Size = new Size(40, 20);
            lblDie1.TabIndex = 0;
            lblDie1.Text = "Die I";
            // 
            // lblDie2
            // 
            lblDie2.AutoSize = true;
            lblDie2.Location = new Point(402, 124);
            lblDie2.Name = "lblDie2";
            lblDie2.Size = new Size(44, 20);
            lblDie2.TabIndex = 1;
            lblDie2.Text = "Die II";
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Location = new Point(41, 217);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(48, 20);
            lblBank.TabIndex = 2;
            currentBank = initialBank;
            lblBank.Text = "Bank: " + currentBank;
            // 
            // txtBet
            // 
            txtBet.Location = new Point(49, 80);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter your bet ";
            txtBet.Size = new Size(304, 27);
            txtBet.TabIndex = 3;
            txtBet.TextChanged += txtBet_TextChanged;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(657, 327);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(94, 76);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(402, 255);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(109, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "How'd you do?";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBank);
            Controls.Add(lblDie2);
            Controls.Add(lblDie1);
            Name = "frmMain";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Label lblBank;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblResult;
    }
}
