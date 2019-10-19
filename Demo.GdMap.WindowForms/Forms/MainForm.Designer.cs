namespace Demo.GdMap.WindowForms
{
   partial class MainForm
   {
      /// <summary>
      /// 必需的设计器变量。
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 清理所有正在使用的资源。
      /// </summary>
      /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows 窗体设计器生成的代码

      /// <summary>
      /// 设计器支持所需的方法 - 不要修改
      /// 使用代码编辑器修改此方法的内容。
      /// </summary>
      private void InitializeComponent()
      {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                        this.topPanel = new System.Windows.Forms.Panel();
                        this.groupBox2 = new System.Windows.Forms.GroupBox();
                        this.btnSelFile = new System.Windows.Forms.Button();
                        this.tbDecodeFile = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.btnGoto = new System.Windows.Forms.Button();
                        this.tbLatLong = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.groupBox1 = new System.Windows.Forms.GroupBox();
                        this.button1 = new System.Windows.Forms.Button();
                        this.btnDownSelMap = new System.Windows.Forms.Button();
                        this.mapPanel = new System.Windows.Forms.Panel();
                        this.MainMap = new Demo.GdMap.WindowsForms.Map();
                        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
                        this.statusLabelLng = new System.Windows.Forms.ToolStripStatusLabel();
                        this.statusLabelLat = new System.Windows.Forms.ToolStripStatusLabel();
                        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                        this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.menuItemUseMethod = new System.Windows.Forms.ToolStripMenuItem();
                        this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
                        this.topPanel.SuspendLayout();
                        this.groupBox2.SuspendLayout();
                        this.groupBox1.SuspendLayout();
                        this.mapPanel.SuspendLayout();
                        this.statusStrip1.SuspendLayout();
                        this.menuStrip1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // topPanel
                        // 
                        this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.topPanel.Controls.Add(this.groupBox2);
                        this.topPanel.Controls.Add(this.groupBox1);
                        this.topPanel.Location = new System.Drawing.Point(5, 27);
                        this.topPanel.Name = "topPanel";
                        this.topPanel.Size = new System.Drawing.Size(1008, 145);
                        this.topPanel.TabIndex = 0;
                        // 
                        // groupBox2
                        // 
                        this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.groupBox2.Controls.Add(this.btnSelFile);
                        this.groupBox2.Controls.Add(this.tbDecodeFile);
                        this.groupBox2.Controls.Add(this.label2);
                        this.groupBox2.Controls.Add(this.btnGoto);
                        this.groupBox2.Controls.Add(this.tbLatLong);
                        this.groupBox2.Controls.Add(this.label1);
                        this.groupBox2.Location = new System.Drawing.Point(13, 12);
                        this.groupBox2.Name = "groupBox2";
                        this.groupBox2.Size = new System.Drawing.Size(869, 128);
                        this.groupBox2.TabIndex = 7;
                        this.groupBox2.TabStop = false;
                        // 
                        // btnSelFile
                        // 
                        this.btnSelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.btnSelFile.Location = new System.Drawing.Point(778, 50);
                        this.btnSelFile.Name = "btnSelFile";
                        this.btnSelFile.Size = new System.Drawing.Size(85, 22);
                        this.btnSelFile.TabIndex = 8;
                        this.btnSelFile.Text = "......";
                        this.btnSelFile.UseVisualStyleBackColor = true;
                        this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
                        // 
                        // tbDecodeFile
                        // 
                        this.tbDecodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.tbDecodeFile.Enabled = false;
                        this.tbDecodeFile.Location = new System.Drawing.Point(70, 50);
                        this.tbDecodeFile.Name = "tbDecodeFile";
                        this.tbDecodeFile.Size = new System.Drawing.Size(702, 21);
                        this.tbDecodeFile.TabIndex = 7;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(6, 59);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(53, 12);
                        this.label2.TabIndex = 6;
                        this.label2.Text = "解码文件";
                        // 
                        // btnGoto
                        // 
                        this.btnGoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.btnGoto.Location = new System.Drawing.Point(778, 16);
                        this.btnGoto.Name = "btnGoto";
                        this.btnGoto.Size = new System.Drawing.Size(85, 22);
                        this.btnGoto.TabIndex = 5;
                        this.btnGoto.Text = "前往";
                        this.btnGoto.UseVisualStyleBackColor = true;
                        this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
                        // 
                        // tbLatLong
                        // 
                        this.tbLatLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.tbLatLong.Location = new System.Drawing.Point(70, 17);
                        this.tbLatLong.Name = "tbLatLong";
                        this.tbLatLong.Size = new System.Drawing.Size(702, 21);
                        this.tbLatLong.TabIndex = 4;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(6, 22);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(41, 12);
                        this.label1.TabIndex = 3;
                        this.label1.Text = "经纬度";
                        // 
                        // groupBox1
                        // 
                        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.groupBox1.Controls.Add(this.button1);
                        this.groupBox1.Controls.Add(this.btnDownSelMap);
                        this.groupBox1.Location = new System.Drawing.Point(888, 12);
                        this.groupBox1.Name = "groupBox1";
                        this.groupBox1.Size = new System.Drawing.Size(109, 128);
                        this.groupBox1.TabIndex = 6;
                        this.groupBox1.TabStop = false;
                        // 
                        // button1
                        // 
                        this.button1.Location = new System.Drawing.Point(6, 15);
                        this.button1.Name = "button1";
                        this.button1.Size = new System.Drawing.Size(93, 22);
                        this.button1.TabIndex = 0;
                        this.button1.Text = "模拟绘制轨迹";
                        this.button1.UseVisualStyleBackColor = true;
                        this.button1.Click += new System.EventHandler(this.button1_Click);
                        // 
                        // btnDownSelMap
                        // 
                        this.btnDownSelMap.Location = new System.Drawing.Point(6, 43);
                        this.btnDownSelMap.Name = "btnDownSelMap";
                        this.btnDownSelMap.Size = new System.Drawing.Size(93, 21);
                        this.btnDownSelMap.TabIndex = 2;
                        this.btnDownSelMap.Text = "下载选中地图";
                        this.btnDownSelMap.UseVisualStyleBackColor = true;
                        this.btnDownSelMap.Click += new System.EventHandler(this.btnDownSelMap_Click);
                        // 
                        // mapPanel
                        // 
                        this.mapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.mapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.mapPanel.Controls.Add(this.MainMap);
                        this.mapPanel.Location = new System.Drawing.Point(5, 178);
                        this.mapPanel.Name = "mapPanel";
                        this.mapPanel.Size = new System.Drawing.Size(1008, 537);
                        this.mapPanel.TabIndex = 1;
                        // 
                        // MainMap
                        // 
                        this.MainMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.MainMap.Bearing = 0F;
                        this.MainMap.CanDragMap = true;
                        this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
                        this.MainMap.GrayScaleMode = false;
                        this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
                        this.MainMap.LevelsKeepInMemmory = 5;
                        this.MainMap.Location = new System.Drawing.Point(3, 2);
                        this.MainMap.MarkersEnabled = true;
                        this.MainMap.MaxZoom = 2;
                        this.MainMap.MinZoom = 2;
                        this.MainMap.MouseWheelZoomEnabled = true;
                        this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
                        this.MainMap.Name = "MainMap";
                        this.MainMap.NegativeMode = false;
                        this.MainMap.PolygonsEnabled = true;
                        this.MainMap.RetryLoadTile = 0;
                        this.MainMap.RoutesEnabled = true;
                        this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
                        this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
                        this.MainMap.ShowTileGridLines = false;
                        this.MainMap.Size = new System.Drawing.Size(1000, 533);
                        this.MainMap.TabIndex = 0;
                        this.MainMap.Zoom = 0D;
                        // 
                        // statusStrip1
                        // 
                        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelLng,
            this.statusLabelLat});
                        this.statusStrip1.Location = new System.Drawing.Point(0, 718);
                        this.statusStrip1.Name = "statusStrip1";
                        this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
                        this.statusStrip1.TabIndex = 2;
                        this.statusStrip1.Text = "statusStrip1";
                        // 
                        // statusLabelLng
                        // 
                        this.statusLabelLng.Name = "statusLabelLng";
                        this.statusLabelLng.Size = new System.Drawing.Size(29, 17);
                        this.statusLabelLng.Text = "lng:";
                        // 
                        // statusLabelLat
                        // 
                        this.statusLabelLat.Name = "statusLabelLat";
                        this.statusLabelLat.Size = new System.Drawing.Size(25, 17);
                        this.statusLabelLat.Text = "lat:";
                        // 
                        // menuStrip1
                        // 
                        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem});
                        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                        this.menuStrip1.Name = "menuStrip1";
                        this.menuStrip1.Size = new System.Drawing.Size(1016, 25);
                        this.menuStrip1.TabIndex = 3;
                        this.menuStrip1.Text = "menuStrip1";
                        // 
                        // 帮助ToolStripMenuItem
                        // 
                        this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUseMethod,
            this.menuItemAbout});
                        this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
                        this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
                        this.帮助ToolStripMenuItem.Text = "帮助";
                        // 
                        // menuItemUseMethod
                        // 
                        this.menuItemUseMethod.Name = "menuItemUseMethod";
                        this.menuItemUseMethod.Size = new System.Drawing.Size(124, 22);
                        this.menuItemUseMethod.Text = "使用方法";
                        this.menuItemUseMethod.Click += new System.EventHandler(this.menuItemUseMethod_Click);
                        // 
                        // menuItemAbout
                        // 
                        this.menuItemAbout.Name = "menuItemAbout";
                        this.menuItemAbout.Size = new System.Drawing.Size(124, 22);
                        this.menuItemAbout.Text = "关于我们";
                        this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
                        // 
                        // MainForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1016, 740);
                        this.Controls.Add(this.statusStrip1);
                        this.Controls.Add(this.menuStrip1);
                        this.Controls.Add(this.mapPanel);
                        this.Controls.Add(this.topPanel);
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "MainForm";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "轨迹演示";
                        this.Load += new System.EventHandler(this.MainForm_Load);
                        this.topPanel.ResumeLayout(false);
                        this.groupBox2.ResumeLayout(false);
                        this.groupBox2.PerformLayout();
                        this.groupBox1.ResumeLayout(false);
                        this.mapPanel.ResumeLayout(false);
                        this.statusStrip1.ResumeLayout(false);
                        this.statusStrip1.PerformLayout();
                        this.menuStrip1.ResumeLayout(false);
                        this.menuStrip1.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel topPanel;
      private System.Windows.Forms.Panel mapPanel;
      private WindowsForms.Map MainMap;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button btnDownSelMap;
      private System.Windows.Forms.Button btnGoto;
      private System.Windows.Forms.TextBox tbLatLong;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel statusLabelLng;
      private System.Windows.Forms.ToolStripStatusLabel statusLabelLat;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnSelFile;
      private System.Windows.Forms.TextBox tbDecodeFile;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem menuItemUseMethod;
      private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
   }
}

