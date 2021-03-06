﻿namespace Visual_TCPRecon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPcap = new System.Windows.Forms.TextBox();
            this.btnBrowsePcap = new System.Windows.Forms.Button();
            this.tv = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extractStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectLikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tHexView = new System.Windows.Forms.TabPage();
            this.he = new Axrhexed.AxHexEd();
            this.tTextView = new System.Windows.Forms.TabPage();
            this.rtf = new System.Windows.Forms.RichTextBox();
            this.tWebView = new System.Windows.Forms.TabPage();
            this.wb = new AxSHDocVw.AxWebBrowser();
            this.tImageView = new System.Windows.Forms.TabPage();
            this.pict = new System.Windows.Forms.PictureBox();
            this.lv = new System.Windows.Forms.ListView();
            this.WebRequests = new System.Windows.Forms.ColumnHeader();
            this.mnuLvPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDNS = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lvIPs = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tHexView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.he)).BeginInit();
            this.tTextView.SuspendLayout();
            this.tWebView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wb)).BeginInit();
            this.tImageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.mnuLvPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCAP File";
            // 
            // txtPcap
            // 
            this.txtPcap.Location = new System.Drawing.Point(76, 32);
            this.txtPcap.Name = "txtPcap";
            this.txtPcap.Size = new System.Drawing.Size(453, 20);
            this.txtPcap.TabIndex = 1;
            // 
            // btnBrowsePcap
            // 
            this.btnBrowsePcap.Location = new System.Drawing.Point(537, 33);
            this.btnBrowsePcap.Name = "btnBrowsePcap";
            this.btnBrowsePcap.Size = new System.Drawing.Size(42, 19);
            this.btnBrowsePcap.TabIndex = 2;
            this.btnBrowsePcap.Text = "...";
            this.btnBrowsePcap.UseVisualStyleBackColor = true;
            this.btnBrowsePcap.Click += new System.EventHandler(this.btnBrowsePcap_Click);
            // 
            // tv
            // 
            this.tv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tv.CheckBoxes = true;
            this.tv.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv.HideSelection = false;
            this.tv.Location = new System.Drawing.Point(12, 69);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(377, 512);
            this.tv.TabIndex = 6;
            this.tv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tv_MouseUp);
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractStreamsToolStripMenuItem,
            this.removeStreamToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectLikeToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.clearSelectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.collapseTreeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 148);
            // 
            // extractStreamsToolStripMenuItem
            // 
            this.extractStreamsToolStripMenuItem.Name = "extractStreamsToolStripMenuItem";
            this.extractStreamsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.extractStreamsToolStripMenuItem.Text = "Extract Checked Data Blocks";
            this.extractStreamsToolStripMenuItem.Click += new System.EventHandler(this.extractStreamsToolStripMenuItem_Click);
            // 
            // removeStreamToolStripMenuItem
            // 
            this.removeStreamToolStripMenuItem.Name = "removeStreamToolStripMenuItem";
            this.removeStreamToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.removeStreamToolStripMenuItem.Text = "Remove Checked Streams";
            this.removeStreamToolStripMenuItem.Click += new System.EventHandler(this.removeStreamToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 6);
            // 
            // selectLikeToolStripMenuItem
            // 
            this.selectLikeToolStripMenuItem.Name = "selectLikeToolStripMenuItem";
            this.selectLikeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.selectLikeToolStripMenuItem.Text = "Select Like";
            this.selectLikeToolStripMenuItem.Click += new System.EventHandler(this.selectLikeToolStripMenuItem_Click_1);
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.invertSelectionToolStripMenuItem.Text = "Invert Selection";
            this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.invertSelectionToolStripMenuItem_Click);
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearSelectionToolStripMenuItem.Text = "Clear Selection";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // collapseTreeToolStripMenuItem
            // 
            this.collapseTreeToolStripMenuItem.Name = "collapseTreeToolStripMenuItem";
            this.collapseTreeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.collapseTreeToolStripMenuItem.Text = "Collapse Tree";
            this.collapseTreeToolStripMenuItem.Click += new System.EventHandler(this.collapseTreeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopyTable});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // mnuCopyTable
            // 
            this.mnuCopyTable.Name = "mnuCopyTable";
            this.mnuCopyTable.Size = new System.Drawing.Size(152, 22);
            this.mnuCopyTable.Text = "Copy Table";
            this.mnuCopyTable.Click += new System.EventHandler(this.mnuCopyTable_Click);
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tabs.Controls.Add(this.tHexView);
            this.tabs.Controls.Add(this.tTextView);
            this.tabs.Controls.Add(this.tWebView);
            this.tabs.Controls.Add(this.tImageView);
            this.tabs.Location = new System.Drawing.Point(395, 69);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(780, 512);
            this.tabs.TabIndex = 9;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tHexView
            // 
            this.tHexView.Controls.Add(this.he);
            this.tHexView.Location = new System.Drawing.Point(4, 4);
            this.tHexView.Name = "tHexView";
            this.tHexView.Padding = new System.Windows.Forms.Padding(3);
            this.tHexView.Size = new System.Drawing.Size(772, 486);
            this.tHexView.TabIndex = 0;
            this.tHexView.Text = "HexView";
            this.tHexView.UseVisualStyleBackColor = true;
            // 
            // he
            // 
            this.he.Enabled = true;
            this.he.Location = new System.Drawing.Point(3, 9);
            this.he.Name = "he";
            this.he.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("he.OcxState")));
            this.he.Size = new System.Drawing.Size(766, 471);
            this.he.TabIndex = 8;
            // 
            // tTextView
            // 
            this.tTextView.Controls.Add(this.rtf);
            this.tTextView.Location = new System.Drawing.Point(4, 4);
            this.tTextView.Name = "tTextView";
            this.tTextView.Padding = new System.Windows.Forms.Padding(3);
            this.tTextView.Size = new System.Drawing.Size(772, 486);
            this.tTextView.TabIndex = 1;
            this.tTextView.Text = "TextView";
            this.tTextView.UseVisualStyleBackColor = true;
            // 
            // rtf
            // 
            this.rtf.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtf.Location = new System.Drawing.Point(3, 6);
            this.rtf.Name = "rtf";
            this.rtf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtf.Size = new System.Drawing.Size(766, 474);
            this.rtf.TabIndex = 0;
            this.rtf.Text = "";
            // 
            // tWebView
            // 
            this.tWebView.Controls.Add(this.wb);
            this.tWebView.Location = new System.Drawing.Point(4, 4);
            this.tWebView.Name = "tWebView";
            this.tWebView.Padding = new System.Windows.Forms.Padding(3);
            this.tWebView.Size = new System.Drawing.Size(772, 486);
            this.tWebView.TabIndex = 2;
            this.tWebView.Text = "WebView";
            this.tWebView.UseVisualStyleBackColor = true;
            // 
            // wb
            // 
            this.wb.Enabled = true;
            this.wb.Location = new System.Drawing.Point(9, 10);
            this.wb.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wb.OcxState")));
            this.wb.Size = new System.Drawing.Size(752, 465);
            this.wb.TabIndex = 0;
            // 
            // tImageView
            // 
            this.tImageView.Controls.Add(this.pict);
            this.tImageView.Location = new System.Drawing.Point(4, 4);
            this.tImageView.Name = "tImageView";
            this.tImageView.Padding = new System.Windows.Forms.Padding(3);
            this.tImageView.Size = new System.Drawing.Size(772, 486);
            this.tImageView.TabIndex = 3;
            this.tImageView.Text = "ImageView";
            this.tImageView.UseVisualStyleBackColor = true;
            // 
            // pict
            // 
            this.pict.Location = new System.Drawing.Point(8, 11);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(754, 463);
            this.pict.TabIndex = 0;
            this.pict.TabStop = false;
            // 
            // lv
            // 
            this.lv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WebRequests});
            this.lv.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv.Location = new System.Drawing.Point(484, 587);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(691, 169);
            this.lv.TabIndex = 10;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // WebRequests
            // 
            this.WebRequests.Text = "Web Requests";
            this.WebRequests.Width = 800;
            // 
            // mnuLvPopup
            // 
            this.mnuLvPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.mnuLvPopup.Name = "mnuLvPopup";
            this.mnuLvPopup.Size = new System.Drawing.Size(155, 70);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copySelectedToolStripMenuItem.Text = "Copy Selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // lvDNS
            // 
            this.lvDNS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvDNS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDNS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDNS.Location = new System.Drawing.Point(12, 587);
            this.lvDNS.Name = "lvDNS";
            this.lvDNS.Size = new System.Drawing.Size(230, 169);
            this.lvDNS.TabIndex = 11;
            this.lvDNS.UseCompatibleStateImageBehavior = false;
            this.lvDNS.View = System.Windows.Forms.View.Details;
            this.lvDNS.SelectedIndexChanged += new System.EventHandler(this.lvDNS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNSRequests";
            this.columnHeader1.Width = 200;
            // 
            // lvIPs
            // 
            this.lvIPs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvIPs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvIPs.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIPs.Location = new System.Drawing.Point(248, 587);
            this.lvIPs.Name = "lvIPs";
            this.lvIPs.Size = new System.Drawing.Size(230, 169);
            this.lvIPs.TabIndex = 12;
            this.lvIPs.UseCompatibleStateImageBehavior = false;
            this.lvIPs.View = System.Windows.Forms.View.Details;
            this.lvIPs.SelectedIndexChanged += new System.EventHandler(this.lvIPs_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unique IP Addresses";
            this.columnHeader2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 761);
            this.Controls.Add(this.lvIPs);
            this.Controls.Add(this.lvDNS);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowsePcap);
            this.Controls.Add(this.txtPcap);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tHexView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.he)).EndInit();
            this.tTextView.ResumeLayout(false);
            this.tWebView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wb)).EndInit();
            this.tImageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.mnuLvPopup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPcap;
        private System.Windows.Forms.Button btnBrowsePcap;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extractStreamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStreamToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fDlg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyTable;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tHexView;
        private System.Windows.Forms.TabPage tTextView;
        private Axrhexed.AxHexEd he;
        private System.Windows.Forms.RichTextBox rtf;
        private System.Windows.Forms.TabPage tWebView;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader WebRequests;
        private System.Windows.Forms.ContextMenuStrip mnuLvPopup;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseTreeToolStripMenuItem;
        private System.Windows.Forms.TabPage tImageView;
        private System.Windows.Forms.PictureBox pict;
        private AxSHDocVw.AxWebBrowser wb;
        private System.Windows.Forms.ListView lvDNS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem selectLikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ListView lvIPs;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

