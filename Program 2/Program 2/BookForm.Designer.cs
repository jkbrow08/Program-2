namespace LibraryItems
{
    partial class BookForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.callnumberLbl = new System.Windows.Forms.Label();
            this.copyRightYearLbl = new System.Windows.Forms.Label();
            this.loanPeriodLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.publisherTxt = new System.Windows.Forms.TextBox();
            this.copyrghyrTxt = new System.Windows.Forms.TextBox();
            this.loanPeTxt = new System.Windows.Forms.TextBox();
            this.callNumTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.bookOkBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bookError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookError)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(12, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(27, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(12, 62);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(50, 13);
            this.publisherLbl.TabIndex = 1;
            this.publisherLbl.Text = "Publisher";
            // 
            // callnumberLbl
            // 
            this.callnumberLbl.AutoSize = true;
            this.callnumberLbl.Location = new System.Drawing.Point(12, 188);
            this.callnumberLbl.Name = "callnumberLbl";
            this.callnumberLbl.Size = new System.Drawing.Size(61, 13);
            this.callnumberLbl.TabIndex = 2;
            this.callnumberLbl.Text = "CallNumber";
            // 
            // copyRightYearLbl
            // 
            this.copyRightYearLbl.AutoSize = true;
            this.copyRightYearLbl.Location = new System.Drawing.Point(12, 104);
            this.copyRightYearLbl.Name = "copyRightYearLbl";
            this.copyRightYearLbl.Size = new System.Drawing.Size(76, 13);
            this.copyRightYearLbl.TabIndex = 3;
            this.copyRightYearLbl.Text = "Copyright Year";
            // 
            // loanPeriodLbl
            // 
            this.loanPeriodLbl.AutoSize = true;
            this.loanPeriodLbl.Location = new System.Drawing.Point(12, 146);
            this.loanPeriodLbl.Name = "loanPeriodLbl";
            this.loanPeriodLbl.Size = new System.Drawing.Size(64, 13);
            this.loanPeriodLbl.TabIndex = 4;
            this.loanPeriodLbl.Text = "Loan Period";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(12, 230);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(38, 13);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(99, 17);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(122, 20);
            this.titleTxt.TabIndex = 6;
            this.titleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.titleTxt_Validating);
            this.titleTxt.Validated += new System.EventHandler(this.titleTxt_Validated);
            // 
            // publisherTxt
            // 
            this.publisherTxt.Location = new System.Drawing.Point(99, 59);
            this.publisherTxt.Name = "publisherTxt";
            this.publisherTxt.Size = new System.Drawing.Size(122, 20);
            this.publisherTxt.TabIndex = 7;
            this.publisherTxt.Validating += new System.ComponentModel.CancelEventHandler(this.publisherTxt_Validating);
            this.publisherTxt.Validated += new System.EventHandler(this.publisherTxt_Validated);
            // 
            // copyrghyrTxt
            // 
            this.copyrghyrTxt.Location = new System.Drawing.Point(99, 101);
            this.copyrghyrTxt.Name = "copyrghyrTxt";
            this.copyrghyrTxt.Size = new System.Drawing.Size(122, 20);
            this.copyrghyrTxt.TabIndex = 8;
            this.copyrghyrTxt.Validating += new System.ComponentModel.CancelEventHandler(this.copyrghyrTxt_Validating);
            this.copyrghyrTxt.Validated += new System.EventHandler(this.copyrghyrTxt_Validated);
            // 
            // loanPeTxt
            // 
            this.loanPeTxt.Location = new System.Drawing.Point(99, 143);
            this.loanPeTxt.Name = "loanPeTxt";
            this.loanPeTxt.Size = new System.Drawing.Size(122, 20);
            this.loanPeTxt.TabIndex = 9;
            this.loanPeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeTxt_Validating);
            this.loanPeTxt.Validated += new System.EventHandler(this.loanPeTxt_Validated);
            // 
            // callNumTxt
            // 
            this.callNumTxt.Location = new System.Drawing.Point(99, 185);
            this.callNumTxt.Name = "callNumTxt";
            this.callNumTxt.Size = new System.Drawing.Size(122, 20);
            this.callNumTxt.TabIndex = 10;
            this.callNumTxt.Validating += new System.ComponentModel.CancelEventHandler(this.callNumTxt_Validating);
            this.callNumTxt.Validated += new System.EventHandler(this.callNumTxt_Validated);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(99, 227);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(122, 20);
            this.authorTxt.TabIndex = 11;
            this.authorTxt.Validating += new System.ComponentModel.CancelEventHandler(this.authorTxt_Validating);
            this.authorTxt.Validated += new System.EventHandler(this.authorTxt_Validated);
            // 
            // bookOkBtn
            // 
            this.bookOkBtn.Location = new System.Drawing.Point(12, 277);
            this.bookOkBtn.Name = "bookOkBtn";
            this.bookOkBtn.Size = new System.Drawing.Size(75, 23);
            this.bookOkBtn.TabIndex = 12;
            this.bookOkBtn.Text = "Ok";
            this.bookOkBtn.UseVisualStyleBackColor = true;
            this.bookOkBtn.Click += new System.EventHandler(this.bookOkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(146, 277);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // bookError
            // 
            this.bookError.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 325);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bookOkBtn);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.callNumTxt);
            this.Controls.Add(this.loanPeTxt);
            this.Controls.Add(this.copyrghyrTxt);
            this.Controls.Add(this.publisherTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.loanPeriodLbl);
            this.Controls.Add(this.copyRightYearLbl);
            this.Controls.Add(this.callnumberLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label callnumberLbl;
        private System.Windows.Forms.Label copyRightYearLbl;
        private System.Windows.Forms.Label loanPeriodLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox publisherTxt;
        private System.Windows.Forms.TextBox copyrghyrTxt;
        private System.Windows.Forms.TextBox loanPeTxt;
        private System.Windows.Forms.TextBox callNumTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Button bookOkBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider bookError;
    }
}