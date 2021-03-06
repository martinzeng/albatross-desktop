﻿namespace albatross_desktop
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新加载RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存XMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存EXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置PToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.编辑RToolStripMenuItem,
            this.配置PToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.dbDToolStripMenuItem,
            this.重新加载RToolStripMenuItem,
            this.保存XMLToolStripMenuItem,
            this.保存EXCELToolStripMenuItem,
            this.uploadDBToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.openToolStripMenuItem.Text = "文件(&F)";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.openToolStripMenuItem1.Text = "打开(&O)...";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToolStripMenuItem.Text = "另存为(&S)...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dbDToolStripMenuItem
            // 
            this.dbDToolStripMenuItem.Name = "dbDToolStripMenuItem";
            this.dbDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.dbDToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dbDToolStripMenuItem.Text = "数据库(&D)";
            // 
            // 重新加载RToolStripMenuItem
            // 
            this.重新加载RToolStripMenuItem.Name = "重新加载RToolStripMenuItem";
            this.重新加载RToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.重新加载RToolStripMenuItem.Text = "重新加载(&R)";
            // 
            // 保存XMLToolStripMenuItem
            // 
            this.保存XMLToolStripMenuItem.Name = "保存XMLToolStripMenuItem";
            this.保存XMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.保存XMLToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.保存XMLToolStripMenuItem.Text = "保存XML";
            this.保存XMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // 保存EXCELToolStripMenuItem
            // 
            this.保存EXCELToolStripMenuItem.Name = "保存EXCELToolStripMenuItem";
            this.保存EXCELToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.保存EXCELToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.保存EXCELToolStripMenuItem.Text = "保存EXCEL";
            this.保存EXCELToolStripMenuItem.Click += new System.EventHandler(this.saveEXCELToolStripMenuItem_Click);
            // 
            // uploadDBToolStripMenuItem
            // 
            this.uploadDBToolStripMenuItem.Name = "uploadDBToolStripMenuItem";
            this.uploadDBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
            this.uploadDBToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.uploadDBToolStripMenuItem.Text = "上传DB";
            // 
            // 编辑RToolStripMenuItem
            // 
            this.编辑RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制CToolStripMenuItem,
            this.粘贴VToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.重做ToolStripMenuItem});
            this.编辑RToolStripMenuItem.Name = "编辑RToolStripMenuItem";
            this.编辑RToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.编辑RToolStripMenuItem.Text = "编辑(&R)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.复制CToolStripMenuItem_Click);
            // 
            // 粘贴VToolStripMenuItem
            // 
            this.粘贴VToolStripMenuItem.Name = "粘贴VToolStripMenuItem";
            this.粘贴VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴VToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.粘贴VToolStripMenuItem.Text = "粘贴(&V)";
            this.粘贴VToolStripMenuItem.Click += new System.EventHandler(this.粘贴VToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.撤销ToolStripMenuItem.Text = "撤销(&Z)";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.重做ToolStripMenuItem.Text = "重做(&U)";
            this.重做ToolStripMenuItem.Click += new System.EventHandler(this.重做ToolStripMenuItem_Click);
            // 
            // 配置PToolStripMenuItem
            // 
            this.配置PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置PToolStripMenuItem1});
            this.配置PToolStripMenuItem.Name = "配置PToolStripMenuItem";
            this.配置PToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.配置PToolStripMenuItem.Text = "工具(&T)";
            // 
            // 配置PToolStripMenuItem1
            // 
            this.配置PToolStripMenuItem1.Name = "配置PToolStripMenuItem1";
            this.配置PToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.配置PToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.配置PToolStripMenuItem1.Text = "配置(&P)";
            this.配置PToolStripMenuItem1.Click += new System.EventHandler(this.ConfigToolStripMenuItem1_Click);
            // 
            // dgview
            // 
            this.dgview.AllowUserToAddRows = false;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.ContextMenuStrip = this.contextMenuStrip1;
            this.dgview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgview.Location = new System.Drawing.Point(0, 25);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 23;
            this.dgview.Size = new System.Drawing.Size(785, 425);
            this.dgview.TabIndex = 4;
            this.dgview.Visible = false;
            this.dgview.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgview_CellBeginEdit);
            this.dgview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellEndEdit);
            this.dgview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加列ToolStripMenuItem,
            this.粘贴列ToolStripMenuItem,
            this.插入列ToolStripMenuItem,
            this.删除列ToolStripMenuItem,
            this.插入行ToolStripMenuItem,
            this.删除行ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 136);
            // 
            // 添加列ToolStripMenuItem
            // 
            this.添加列ToolStripMenuItem.Name = "添加列ToolStripMenuItem";
            this.添加列ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.添加列ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.添加列ToolStripMenuItem.Text = "复制列";
            this.添加列ToolStripMenuItem.Click += new System.EventHandler(this.添加列ToolStripMenuItem_Click);
            // 
            // 粘贴列ToolStripMenuItem
            // 
            this.粘贴列ToolStripMenuItem.Name = "粘贴列ToolStripMenuItem";
            this.粘贴列ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.粘贴列ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.粘贴列ToolStripMenuItem.Text = "粘贴列";
            this.粘贴列ToolStripMenuItem.Click += new System.EventHandler(this.粘贴列ToolStripMenuItem_Click);
            // 
            // 插入列ToolStripMenuItem
            // 
            this.插入列ToolStripMenuItem.Name = "插入列ToolStripMenuItem";
            this.插入列ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.插入列ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.插入列ToolStripMenuItem.Text = "插入列";
            this.插入列ToolStripMenuItem.Click += new System.EventHandler(this.插入列ToolStripMenuItem_Click);
            // 
            // 删除列ToolStripMenuItem
            // 
            this.删除列ToolStripMenuItem.Name = "删除列ToolStripMenuItem";
            this.删除列ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.删除列ToolStripMenuItem.Text = "删除列";
            this.删除列ToolStripMenuItem.Click += new System.EventHandler(this.删除列ToolStripMenuItem_Click);
            // 
            // 插入行ToolStripMenuItem
            // 
            this.插入行ToolStripMenuItem.Name = "插入行ToolStripMenuItem";
            this.插入行ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.插入行ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.插入行ToolStripMenuItem.Text = "插入行";
            this.插入行ToolStripMenuItem.Click += new System.EventHandler(this.插入行ToolStripMenuItem_Click);
            // 
            // 删除行ToolStripMenuItem
            // 
            this.删除行ToolStripMenuItem.Name = "删除行ToolStripMenuItem";
            this.删除行ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.删除行ToolStripMenuItem.Text = "删除行";
            this.删除行ToolStripMenuItem.Click += new System.EventHandler(this.删除行ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusInfo
            // 
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(595, 17);
            this.statusInfo.Spring = true;
            this.statusInfo.Text = "info";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusInfo.Click += new System.EventHandler(this.statusInfo_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "status";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel3.Text = "N/A";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(785, 472);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "data editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置PToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem 重新加载RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存XMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存EXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴VToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadDBToolStripMenuItem;

    }
}

