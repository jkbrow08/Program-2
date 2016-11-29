namespace LibraryItems
{
    partial class CheckoutForm
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
            this.components = new System.ComponentModel.Container();
            this.patronBoxCbo = new System.Windows.Forms.ComboBox();
            this.itemsAvaCbo = new System.Windows.Forms.ComboBox();
            this.checkOutOkBtn = new System.Windows.Forms.Button();
            this.checkoutCancelBtn = new System.Windows.Forms.Button();
            this.CheckOutError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutError)).BeginInit();
            this.SuspendLayout();
            // 
            // patronBoxCbo
            // 
            this.patronBoxCbo.DropDownHeight = 180;
            this.patronBoxCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronBoxCbo.FormattingEnabled = true;
            this.patronBoxCbo.IntegralHeight = false;
            this.patronBoxCbo.Location = new System.Drawing.Point(12, 133);
            this.patronBoxCbo.Name = "patronBoxCbo";
            this.patronBoxCbo.Size = new System.Drawing.Size(139, 21);
            this.patronBoxCbo.TabIndex = 1;
            this.patronBoxCbo.Validating += new System.ComponentModel.CancelEventHandler(this.patronBoxCbo_Validating);
            this.patronBoxCbo.Validated += new System.EventHandler(this.patronBoxCbo_Validated);
            // 
            // itemsAvaCbo
            // 
            this.itemsAvaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsAvaCbo.FormattingEnabled = true;
            this.itemsAvaCbo.Location = new System.Drawing.Point(12, 36);
            this.itemsAvaCbo.Name = "itemsAvaCbo";
            this.itemsAvaCbo.Size = new System.Drawing.Size(266, 21);
            this.itemsAvaCbo.TabIndex = 0;
            this.itemsAvaCbo.Validating += new System.ComponentModel.CancelEventHandler(this.itemsAvaCbo_Validating);
            this.itemsAvaCbo.Validated += new System.EventHandler(this.itemsAvaCbo_Validated);
            // 
            // checkOutOkBtn
            // 
            this.checkOutOkBtn.Location = new System.Drawing.Point(42, 214);
            this.checkOutOkBtn.Name = "checkOutOkBtn";
            this.checkOutOkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkOutOkBtn.TabIndex = 2;
            this.checkOutOkBtn.Text = "Ok";
            this.checkOutOkBtn.UseVisualStyleBackColor = true;
            this.checkOutOkBtn.Click += new System.EventHandler(this.checkOutOkBtn_Click);
            // 
            // checkoutCancelBtn
            // 
            this.checkoutCancelBtn.Location = new System.Drawing.Point(190, 213);
            this.checkoutCancelBtn.Name = "checkoutCancelBtn";
            this.checkoutCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.checkoutCancelBtn.TabIndex = 3;
            this.checkoutCancelBtn.Text = "Cancel";
            this.checkoutCancelBtn.UseVisualStyleBackColor = true;
            this.checkoutCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkoutCancelBtn_MouseDown);
            // 
            // CheckOutError
            // 
            this.CheckOutError.ContainerControl = this;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 264);
            this.Controls.Add(this.checkoutCancelBtn);
            this.Controls.Add(this.checkOutOkBtn);
            this.Controls.Add(this.itemsAvaCbo);
            this.Controls.Add(this.patronBoxCbo);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox patronBoxCbo;
        private System.Windows.Forms.ComboBox itemsAvaCbo;
        private System.Windows.Forms.Button checkOutOkBtn;
        private System.Windows.Forms.Button checkoutCancelBtn;
        private System.Windows.Forms.ErrorProvider CheckOutError;

    }
}