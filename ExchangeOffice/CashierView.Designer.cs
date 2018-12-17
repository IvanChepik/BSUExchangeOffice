namespace ExchangeOffice
{
    partial class CashierView
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
            this.ExchangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExchangeButton
            // 
            this.ExchangeButton.Location = new System.Drawing.Point(35, 28);
            this.ExchangeButton.Name = "ExchangeButton";
            this.ExchangeButton.Size = new System.Drawing.Size(115, 63);
            this.ExchangeButton.TabIndex = 0;
            this.ExchangeButton.Text = "Exchange currency";
            this.ExchangeButton.UseVisualStyleBackColor = true;
            this.ExchangeButton.Click += new System.EventHandler(this.ExchangeButton_Click);
            // 
            // CashierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 356);
            this.Controls.Add(this.ExchangeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CashierView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExchangeButton;
    }
}