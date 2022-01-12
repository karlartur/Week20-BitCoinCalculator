﻿namespace BitCoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBtn = new System.Windows.Forms.Button();
            this.amountOfBTC = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyMenu.Location = new System.Drawing.Point(457, 38);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 23);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            // 
            // getRatesBtn
            // 
            this.getRatesBtn.Location = new System.Drawing.Point(595, 38);
            this.getRatesBtn.Name = "getRatesBtn";
            this.getRatesBtn.Size = new System.Drawing.Size(75, 23);
            this.getRatesBtn.TabIndex = 1;
            this.getRatesBtn.Text = "Get Rates";
            this.getRatesBtn.UseVisualStyleBackColor = true;
            this.getRatesBtn.Click += new System.EventHandler(this.getRatesBtn_Click);
            // 
            // amountOfBTC
            // 
            this.amountOfBTC.Location = new System.Drawing.Point(457, 87);
            this.amountOfBTC.Name = "amountOfBTC";
            this.amountOfBTC.PlaceholderText = "Amount of BitCoins";
            this.amountOfBTC.Size = new System.Drawing.Size(147, 23);
            this.amountOfBTC.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(457, 183);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(457, 127);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(36, 15);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "result";
            this.resultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBTC);
            this.Controls.Add(this.getRatesBtn);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBtn;
        private System.Windows.Forms.TextBox amountOfBTC;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLbl;
    }
}

