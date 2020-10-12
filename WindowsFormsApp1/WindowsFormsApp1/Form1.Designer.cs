namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.输出盒子 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.区域复制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.全部复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入盒子 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.覆盖全部粘贴并翻译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.区域粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.区域复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 输出盒子
            // 
            this.输出盒子.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.输出盒子.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.输出盒子.ContextMenuStrip = this.contextMenuStrip3;
            this.输出盒子.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.输出盒子.ForeColor = System.Drawing.Color.White;
            this.输出盒子.Location = new System.Drawing.Point(75, 193);
            this.输出盒子.Multiline = true;
            this.输出盒子.Name = "输出盒子";
            this.输出盒子.ReadOnly = true;
            this.输出盒子.Size = new System.Drawing.Size(664, 344);
            this.输出盒子.TabIndex = 0;
            this.输出盒子.DoubleClick += new System.EventHandler(this.输出盒子_DoubleClick);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contextMenuStrip3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.区域复制ToolStripMenuItem1,
            this.全部复制ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip3.Size = new System.Drawing.Size(221, 100);
            // 
            // 区域复制ToolStripMenuItem1
            // 
            this.区域复制ToolStripMenuItem1.Name = "区域复制ToolStripMenuItem1";
            this.区域复制ToolStripMenuItem1.Size = new System.Drawing.Size(220, 48);
            this.区域复制ToolStripMenuItem1.Text = "区域复制";
            this.区域复制ToolStripMenuItem1.Click += new System.EventHandler(this.区域复制ToolStripMenuItem1_Click);
            // 
            // 全部复制ToolStripMenuItem
            // 
            this.全部复制ToolStripMenuItem.Name = "全部复制ToolStripMenuItem";
            this.全部复制ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.全部复制ToolStripMenuItem.Text = "全部复制";
            this.全部复制ToolStripMenuItem.Click += new System.EventHandler(this.全部复制ToolStripMenuItem_Click);
            // 
            // 输入盒子
            // 
            this.输入盒子.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.输入盒子.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.输入盒子.ContextMenuStrip = this.contextMenuStrip2;
            this.输入盒子.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.输入盒子.Location = new System.Drawing.Point(75, 95);
            this.输入盒子.Name = "输入盒子";
            this.输入盒子.Size = new System.Drawing.Size(602, 40);
            this.输入盒子.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.覆盖全部粘贴并翻译ToolStripMenuItem,
            this.复制全部ToolStripMenuItem,
            this.区域粘贴ToolStripMenuItem,
            this.区域复制ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(376, 196);
            // 
            // 覆盖全部粘贴并翻译ToolStripMenuItem
            // 
            this.覆盖全部粘贴并翻译ToolStripMenuItem.Name = "覆盖全部粘贴并翻译ToolStripMenuItem";
            this.覆盖全部粘贴并翻译ToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.覆盖全部粘贴并翻译ToolStripMenuItem.Text = "覆盖全部粘贴并翻译";
            this.覆盖全部粘贴并翻译ToolStripMenuItem.Click += new System.EventHandler(this.覆盖全部粘贴并翻译ToolStripMenuItem_Click);
            // 
            // 复制全部ToolStripMenuItem
            // 
            this.复制全部ToolStripMenuItem.Name = "复制全部ToolStripMenuItem";
            this.复制全部ToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.复制全部ToolStripMenuItem.Text = "复制全部";
            this.复制全部ToolStripMenuItem.Click += new System.EventHandler(this.复制全部ToolStripMenuItem_Click);
            // 
            // 区域粘贴ToolStripMenuItem
            // 
            this.区域粘贴ToolStripMenuItem.Name = "区域粘贴ToolStripMenuItem";
            this.区域粘贴ToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.区域粘贴ToolStripMenuItem.Text = "区域粘贴并翻译";
            this.区域粘贴ToolStripMenuItem.Click += new System.EventHandler(this.区域粘贴并翻译ToolStripMenuItem_Click);
            // 
            // 区域复制ToolStripMenuItem
            // 
            this.区域复制ToolStripMenuItem.Name = "区域复制ToolStripMenuItem";
            this.区域复制ToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.区域复制ToolStripMenuItem.Text = "区域复制";
            this.区域复制ToolStripMenuItem.Click += new System.EventHandler(this.区域复制ToolStripMenuItem_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(186, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(186, 29);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.按钮22;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(186, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(186, 29);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(739, 70);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDoubleClick);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(745, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 52);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.按钮4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(745, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 52);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "screenshot++";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(692, 84);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 58);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(314, 52);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(313, 48);
            this.toolStripMenuItem2.Text = "切换为搜狗翻译";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 592);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.输入盒子);
            this.Controls.Add(this.输出盒子);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox 输入盒子;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.TextBox 输出盒子;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 区域复制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 全部复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 覆盖全部粘贴并翻译ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 区域粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 区域复制ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

