namespace LibraryItems
{
    partial class ReturnForm
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
            this.returnItemCbo = new System.Windows.Forms.ComboBox();
            this.returnOkBtn = new System.Windows.Forms.Button();
            this.returnCancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnItemCbo
            // 
            this.returnItemCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.returnItemCbo.FormattingEnabled = true;
            this.returnItemCbo.Location = new System.Drawing.Point(25, 34);
            this.returnItemCbo.Name = "returnItemCbo";
            this.returnItemCbo.Size = new System.Drawing.Size(225, 21);
            this.returnItemCbo.TabIndex = 0;
            this.returnItemCbo.Validating += new System.ComponentModel.CancelEventHandler(this.returnItemCbo_Validating);
            this.returnItemCbo.Validated += new System.EventHandler(this.returnItemCbo_Validated);
            // 
            // returnOkBtn
            // 
            this.returnOkBtn.Location = new System.Drawing.Point(25, 112);
            this.returnOkBtn.Name = "returnOkBtn";
            this.returnOkBtn.Size = new System.Drawing.Size(75, 23);
            this.returnOkBtn.TabIndex = 2;
            this.returnOkBtn.Text = "Ok";
            this.returnOkBtn.UseVisualStyleBackColor = true;
            this.returnOkBtn.Click += new System.EventHandler(this.returnOkBtn_Click);
            // 
            // returnCancelBtn
            // 
            this.returnCancelBtn.Location = new System.Drawing.Point(175, 112);
            this.returnCancelBtn.Name = "returnCancelBtn";
            this.returnCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.returnCancelBtn.TabIndex = 3;
            this.returnCancelBtn.Text = "Cancel";
            this.returnCancelBtn.UseVisualStyleBackColor = true;
            this.returnCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.returnCancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.returnCancelBtn);
            this.Controls.Add(this.returnOkBtn);
            this.Controls.Add(this.returnItemCbo);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox returnItemCbo;
        private System.Windows.Forms.Button returnOkBtn;
        private System.Windows.Forms.Button returnCancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}