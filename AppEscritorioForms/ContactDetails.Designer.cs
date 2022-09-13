namespace AppEscritorioForms
{
  partial class ContactDetails
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(386, 322);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 29;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(270, 322);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 28;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(270, 242);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(191, 20);
      this.txtAddress.TabIndex = 27;
      this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(151, 237);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 24);
      this.label4.TabIndex = 26;
      this.label4.Text = "Address";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(270, 198);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(191, 20);
      this.txtPhone.TabIndex = 25;
      this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(151, 193);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 24);
      this.label3.TabIndex = 24;
      this.label3.Text = "Phone";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(270, 154);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(191, 20);
      this.txtLastName.TabIndex = 23;
      this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged_1);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(151, 149);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 24);
      this.label2.TabIndex = 22;
      this.label2.Text = "Last Name";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // txtFirstName
      // 
      this.txtFirstName.Location = new System.Drawing.Point(270, 110);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(191, 20);
      this.txtFirstName.TabIndex = 21;
      this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(151, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 24);
      this.label1.TabIndex = 20;
      this.label1.Text = "First Name";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // ContactDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(613, 450);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtFirstName);
      this.Controls.Add(this.label1);
      this.Name = "ContactDetails";
      this.Text = "ContactDetails";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
    }
}