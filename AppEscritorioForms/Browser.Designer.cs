﻿namespace AppEscritorioForms
{
  partial class Browser
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
      this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
      this.SuspendLayout();
      // 
      // webView21
      // 
      this.webView21.AllowExternalDrop = true;
      this.webView21.CreationProperties = null;
      this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webView21.Location = new System.Drawing.Point(12, 48);
      this.webView21.Name = "webView21";
      this.webView21.Size = new System.Drawing.Size(776, 379);
      this.webView21.TabIndex = 9;
      this.webView21.ZoomFactor = 1D;
      this.webView21.Click += new System.EventHandler(this.webView21_Click);
      // 
      // Browser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.webView21);
      this.Name = "Browser";
      this.Text = "Browser";
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}