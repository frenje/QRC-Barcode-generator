namespace QR_Code_Maker
{
    partial class frmQRCodeMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQRCodeMaker));
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.imgDisplayCodes = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(16, 472);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(69, 20);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Location = new System.Drawing.Point(16, 542);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(75, 20);
            this.lblQRCode.TabIndex = 1;
            this.lblQRCode.Text = "QR Code";
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(360, 468);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(100, 32);
            this.btnBarcode.TabIndex = 2;
            this.btnBarcode.Text = "Bar Code";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.Location = new System.Drawing.Point(360, 539);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(100, 34);
            this.btnQRCode.TabIndex = 3;
            this.btnQRCode.Text = "QR Code";
            this.btnQRCode.UseVisualStyleBackColor = true;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(104, 466);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(223, 26);
            this.txtBarcode.TabIndex = 4;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(104, 539);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(223, 26);
            this.txtQRCode.TabIndex = 5;
            // 
            // imgDisplayCodes
            // 
            this.imgDisplayCodes.BackColor = System.Drawing.SystemColors.Window;
            this.imgDisplayCodes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgDisplayCodes.Location = new System.Drawing.Point(20, 24);
            this.imgDisplayCodes.Name = "imgDisplayCodes";
            this.imgDisplayCodes.Size = new System.Drawing.Size(528, 402);
            this.imgDisplayCodes.TabIndex = 6;
            this.imgDisplayCodes.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(452, 346);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 45);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmQRCodeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 585);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.imgDisplayCodes);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.lblQRCode);
            this.Controls.Add(this.lblBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQRCodeMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR CodeMaker";
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.PictureBox imgDisplayCodes;
        private System.Windows.Forms.Button btnPrint;
    }
}

