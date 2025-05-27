    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.txthoten = new System.Windows.Forms.TextBox();
        this.txtsdt = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblHoten = new System.Windows.Forms.Label();
        this.lblSdt = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.btnluu = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txthoten
        // 
        this.txthoten.Location = new System.Drawing.Point(128, 32);
        this.txthoten.Name = "txthoten";
        this.txthoten.Size = new System.Drawing.Size(200, 22);
        this.txthoten.TabIndex = 0;
        this.txthoten.Text = "";
        this.txthoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // txtsdt
        // 
        this.txtsdt.Location = new System.Drawing.Point(128, 97);
        this.txtsdt.Name = "txtsdt";
        this.txtsdt.Size = new System.Drawing.Size(200, 22);
        this.txtsdt.TabIndex = 1;
        this.txtsdt.Text = "";
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(128, 162);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(200, 22);
        this.txtEmail.TabIndex = 2;
        this.txtEmail.Text = "";
        // 
        // lblHoten
        // 
        this.lblHoten.AutoSize = true;
        this.lblHoten.Location = new System.Drawing.Point(28, 32);
        this.lblHoten.Name = "lblHoten";
        this.lblHoten.Size = new System.Drawing.Size(50, 16);
        this.lblHoten.TabIndex = 3;
        this.lblHoten.Text = "Họ tên:";
        // 
        // lblSdt
        // 
        this.lblSdt.AutoSize = true;
        this.lblSdt.Location = new System.Drawing.Point(28, 97);
        this.lblSdt.Name = "lblSdt";
        this.lblSdt.Size = new System.Drawing.Size(80, 16);
        this.lblSdt.TabIndex = 4;
        this.lblSdt.Text = "Số điện thoại:";
        // 
        // lblEmail
        // 
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(28, 162);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(50, 16);
        this.lblEmail.TabIndex = 5;
        this.lblEmail.Text = "Email:";
        // 
        // btnluu
        // 
        this.btnluu.Location = new System.Drawing.Point(128, 227);
        this.btnluu.Name = "btnluu";
        this.btnluu.Size = new System.Drawing.Size(75, 23);
        this.btnluu.TabIndex = 6;
        this.btnluu.Text = "Lưu";
        this.btnluu.UseVisualStyleBackColor = true;
        // 
        // AddContactForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.Controls.Add(this.btnluu);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblSdt);
        this.Controls.Add(this.lblHoten);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtsdt);
        this.Controls.Add(this.txthoten);
        this.Name = "AddContactForm";
        this.Text = "Thêm Liên Hệ";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txthoten;
    private System.Windows.Forms.TextBox txtsdt;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblHoten;
    private System.Windows.Forms.Label lblSdt;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Button btnluu;
}