namespace Demo.GdMap.WindowsForms
{
   partial class UseMethodForm
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
                        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
                        this.close = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // richTextBox1
                        // 
                        this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.richTextBox1.Location = new System.Drawing.Point(4, 4);
                        this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
                        this.richTextBox1.Name = "richTextBox1";
                        this.richTextBox1.ReadOnly = true;
                        this.richTextBox1.Size = new System.Drawing.Size(456, 268);
                        this.richTextBox1.TabIndex = 3;
                        this.richTextBox1.Text = "1. 下载地图\n     按住 Alt + 右键 移动鼠标选择区域， 点击下载地图即可";
                        // 
                        // close
                        // 
                        this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.close.Location = new System.Drawing.Point(4, 277);
                        this.close.Name = "close";
                        this.close.Size = new System.Drawing.Size(456, 31);
                        this.close.TabIndex = 4;
                        this.close.Text = "关闭";
                        this.close.UseVisualStyleBackColor = true;
                        this.close.Click += new System.EventHandler(this.close_Click);
                        // 
                        // UseMethodForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.Gray;
                        this.ClientSize = new System.Drawing.Size(464, 315);
                        this.Controls.Add(this.close);
                        this.Controls.Add(this.richTextBox1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        this.Margin = new System.Windows.Forms.Padding(2);
                        this.MaximizeBox = false;
                        this.MinimizeBox = false;
                        this.Name = "UseMethodForm";
                        this.Padding = new System.Windows.Forms.Padding(4);
                        this.ShowIcon = false;
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "<< WARNING >>";
                        this.ResumeLayout(false);

      }

      #endregion
      internal System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.Button close;
   }
}