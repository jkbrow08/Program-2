namespace LibraryItems
{
    partial class PatronForm
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
            this.ptrnNameLbl = new System.Windows.Forms.Label();
            this.ptrnIdLbl = new System.Windows.Forms.Label();
            this.patronOkBtn = new System.Windows.Forms.Button();
            this.patronCancelBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrnNameLbl
            // 
            this.ptrnNameLbl.AutoSize = true;
            this.ptrnNameLbl.Location = new System.Drawing.Point(12, 9);
            this.ptrnNameLbl.Name = "ptrnNameLbl";
            this.ptrnNameLbl.Size = new System.Drawing.Size(38, 13);
            this.ptrnNameLbl.TabIndex = 0;
            this.ptrnNameLbl.Text = "Name:";
            // 
            // ptrnIdLbl
            // 
            this.ptrnIdLbl.AutoSize = true;
            this.ptrnIdLbl.Location = new System.Drawing.Point(13, 50);
            this.ptrnIdLbl.Name = "ptrnIdLbl";
            this.ptrnIdLbl.Size = new System.Drawing.Size(21, 13);
            this.ptrnIdLbl.TabIndex = 1;
            this.ptrnIdLbl.Text = "ID:";
            // 
            // patronOkBtn
            // 
            this.patronOkBtn.Location = new System.Drawing.Point(16, 96);
            this.patronOkBtn.Name = "patronOkBtn";
            this.patronOkBtn.Size = new System.Drawing.Size(75, 23);
            this.patronOkBtn.TabIndex = 2;
            this.patronOkBtn.Text = "OK";
            this.patronOkBtn.UseVisualStyleBackColor = true;
            this.patronOkBtn.Click += new System.EventHandler(this.patronOkBtn_Click);
            // 
            // patronCancelBtn
            // 
            this.patronCancelBtn.Location = new System.Drawing.Point(111, 96);
            this.patronCancelBtn.Name = "patronCancelBtn";
            this.patronCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.patronCancelBtn.TabIndex = 3;
            this.patronCancelBtn.Text = "Cancel";
            this.patronCancelBtn.UseVisualStyleBackColor = true;
            this.patronCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patronCancelBtn_MouseDown);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(67, 6);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxt_Validating);
            this.nameTxt.Validated += new System.EventHandler(this.nameTxt_Validated);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(67, 50);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 5;
            this.idTxt.Validating += new System.ComponentModel.CancelEventHandler(this.idTxt_Validating);
            this.idTxt.Validated += new System.EventHandler(this.idTxt_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 147);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.patronCancelBtn);
            this.Controls.Add(this.patronOkBtn);
            this.Controls.Add(this.ptrnIdLbl);
            this.Controls.Add(this.ptrnNameLbl);
            this.Name = "PatronForm";
            this.Text = "Patron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ptrnNameLbl;
        private System.Windows.Forms.Label ptrnIdLbl;
        private System.Windows.Forms.Button patronOkBtn;
        private System.Windows.Forms.Button patronCancelBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}