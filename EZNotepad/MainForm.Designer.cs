/*
 * 由SharpDevelop创建。
 * 用户： jason_su
 * 日期: 11/20/2023
 * 时间: PM 02:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace EZNotepad
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox Content;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.Button BtnNewContent;
		private System.Windows.Forms.Button BtnLine2;
		private System.Windows.Forms.Button BtnLine1;
		private System.Windows.Forms.Button BtnFileManager;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.ListBox lstBoxSearch;
		private System.Windows.Forms.Button BtnSearchFile;
		private System.Windows.Forms.ComboBox combSearch;
		private System.Windows.Forms.TreeView treeViewFile;
		private System.Windows.Forms.Button BtnSmall;
		private System.Windows.Forms.Button BtnBig;
		private System.Windows.Forms.Button BtnSearchFolder;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNewLine;
		private System.Windows.Forms.Button BtnUTF8;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.Button BtnBackup;
		private System.Windows.Forms.CheckBox chkNoCase;


	
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Content = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNewContent = new System.Windows.Forms.Button();
            this.BtnLine2 = new System.Windows.Forms.Button();
            this.BtnLine1 = new System.Windows.Forms.Button();
            this.BtnFileManager = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lstBoxSearch = new System.Windows.Forms.ListBox();
            this.BtnSearchFile = new System.Windows.Forms.Button();
            this.combSearch = new System.Windows.Forms.ComboBox();
            this.treeViewFile = new System.Windows.Forms.TreeView();
            this.BtnSmall = new System.Windows.Forms.Button();
            this.BtnBig = new System.Windows.Forms.Button();
            this.BtnSearchFolder = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnNewLine = new System.Windows.Forms.Button();
            this.BtnUTF8 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.chkNoCase = new System.Windows.Forms.CheckBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(227, 103);
            this.Content.Margin = new System.Windows.Forms.Padding(2);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Content.Size = new System.Drawing.Size(805, 521);
            this.Content.TabIndex = 1;
            this.Content.Text = "\r\n\r\n\r\n   Welcome!\r\n";
            this.Content.WordWrap = false;
            this.Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentMouseDown);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(298, 16);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(67, 73);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "編輯";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEditClick);
            // 
            // BtnNewContent
            // 
            this.BtnNewContent.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewContent.Location = new System.Drawing.Point(227, 16);
            this.BtnNewContent.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewContent.Name = "BtnNewContent";
            this.BtnNewContent.Size = new System.Drawing.Size(67, 73);
            this.BtnNewContent.TabIndex = 4;
            this.BtnNewContent.Text = "新建";
            this.BtnNewContent.UseVisualStyleBackColor = true;
            this.BtnNewContent.Click += new System.EventHandler(this.BtnNewContentClick);
            // 
            // BtnLine2
            // 
            this.BtnLine2.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLine2.Location = new System.Drawing.Point(651, 16);
            this.BtnLine2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine2.Name = "BtnLine2";
            this.BtnLine2.Size = new System.Drawing.Size(67, 73);
            this.BtnLine2.TabIndex = 6;
            this.BtnLine2.Text = "===";
            this.BtnLine2.UseVisualStyleBackColor = true;
            this.BtnLine2.Click += new System.EventHandler(this.BtnLine2Click);
            // 
            // BtnLine1
            // 
            this.BtnLine1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLine1.Location = new System.Drawing.Point(581, 16);
            this.BtnLine1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine1.Name = "BtnLine1";
            this.BtnLine1.Size = new System.Drawing.Size(67, 73);
            this.BtnLine1.TabIndex = 5;
            this.BtnLine1.Text = "----";
            this.BtnLine1.UseVisualStyleBackColor = true;
            this.BtnLine1.Click += new System.EventHandler(this.BtnLine1Click);
            // 
            // BtnFileManager
            // 
            this.BtnFileManager.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnFileManager.Location = new System.Drawing.Point(8, 18);
            this.BtnFileManager.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFileManager.Name = "BtnFileManager";
            this.BtnFileManager.Size = new System.Drawing.Size(202, 35);
            this.BtnFileManager.TabIndex = 8;
            this.BtnFileManager.Text = "檔案總管";
            this.BtnFileManager.UseVisualStyleBackColor = true;
            this.BtnFileManager.Click += new System.EventHandler(this.BtnFileManagerClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(369, 16);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(67, 73);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "存檔";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // lstBoxSearch
            // 
            this.lstBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxSearch.FormattingEnabled = true;
            this.lstBoxSearch.HorizontalScrollbar = true;
            this.lstBoxSearch.ItemHeight = 24;
            this.lstBoxSearch.Location = new System.Drawing.Point(1046, 260);
            this.lstBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxSearch.Name = "lstBoxSearch";
            this.lstBoxSearch.Size = new System.Drawing.Size(203, 364);
            this.lstBoxSearch.TabIndex = 10;
            this.lstBoxSearch.Click += new System.EventHandler(this.LstBoxSearchClick);
            this.lstBoxSearch.DoubleClick += new System.EventHandler(this.LstBoxSearchDoubleClick);
            // 
            // BtnSearchFile
            // 
            this.BtnSearchFile.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSearchFile.Location = new System.Drawing.Point(1046, 169);
            this.BtnSearchFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearchFile.Name = "BtnSearchFile";
            this.BtnSearchFile.Size = new System.Drawing.Size(202, 35);
            this.BtnSearchFile.TabIndex = 12;
            this.BtnSearchFile.Text = "搜尋目前檔案";
            this.BtnSearchFile.UseVisualStyleBackColor = true;
            this.BtnSearchFile.Click += new System.EventHandler(this.BtnSearchFileClick);
            // 
            // combSearch
            // 
            this.combSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSearch.FormattingEnabled = true;
            this.combSearch.Location = new System.Drawing.Point(1046, 103);
            this.combSearch.Margin = new System.Windows.Forms.Padding(2);
            this.combSearch.Name = "combSearch";
            this.combSearch.Size = new System.Drawing.Size(203, 32);
            this.combSearch.TabIndex = 11;
            // 
            // treeViewFile
            // 
            this.treeViewFile.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFile.Location = new System.Drawing.Point(7, 103);
            this.treeViewFile.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewFile.Name = "treeViewFile";
            this.treeViewFile.Size = new System.Drawing.Size(203, 521);
            this.treeViewFile.TabIndex = 13;
            this.treeViewFile.DoubleClick += new System.EventHandler(this.TreeViewFileDoubleClick);
            // 
            // BtnSmall
            // 
            this.BtnSmall.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSmall.Location = new System.Drawing.Point(793, 16);
            this.BtnSmall.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSmall.Name = "BtnSmall";
            this.BtnSmall.Size = new System.Drawing.Size(67, 73);
            this.BtnSmall.TabIndex = 15;
            this.BtnSmall.Text = "字體縮小";
            this.BtnSmall.UseVisualStyleBackColor = true;
            this.BtnSmall.Click += new System.EventHandler(this.Button2Click);
            // 
            // BtnBig
            // 
            this.BtnBig.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBig.Location = new System.Drawing.Point(722, 16);
            this.BtnBig.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBig.Name = "BtnBig";
            this.BtnBig.Size = new System.Drawing.Size(67, 73);
            this.BtnBig.TabIndex = 14;
            this.BtnBig.Text = "字體放大";
            this.BtnBig.UseVisualStyleBackColor = true;
            this.BtnBig.Click += new System.EventHandler(this.Button3Click);
            // 
            // BtnSearchFolder
            // 
            this.BtnSearchFolder.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSearchFolder.Location = new System.Drawing.Point(1046, 208);
            this.BtnSearchFolder.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearchFolder.Name = "BtnSearchFolder";
            this.BtnSearchFolder.Size = new System.Drawing.Size(202, 35);
            this.BtnSearchFolder.TabIndex = 16;
            this.BtnSearchFolder.Text = "搜尋全部檔案";
            this.BtnSearchFolder.UseVisualStyleBackColor = true;
            this.BtnSearchFolder.Click += new System.EventHandler(this.BtnSearchFolderClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(510, 16);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(67, 73);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // BtnNewLine
            // 
            this.BtnNewLine.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewLine.Location = new System.Drawing.Point(863, 16);
            this.BtnNewLine.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewLine.Name = "BtnNewLine";
            this.BtnNewLine.Size = new System.Drawing.Size(67, 73);
            this.BtnNewLine.TabIndex = 18;
            this.BtnNewLine.Text = "自動換行";
            this.BtnNewLine.UseVisualStyleBackColor = true;
            this.BtnNewLine.Click += new System.EventHandler(this.BtnNewLineClick);
            // 
            // BtnUTF8
            // 
            this.BtnUTF8.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUTF8.Location = new System.Drawing.Point(439, 16);
            this.BtnUTF8.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUTF8.Name = "BtnUTF8";
            this.BtnUTF8.Size = new System.Drawing.Size(67, 73);
            this.BtnUTF8.TabIndex = 19;
            this.BtnUTF8.Text = "編碼";
            this.BtnUTF8.UseVisualStyleBackColor = true;
            this.BtnUTF8.Click += new System.EventHandler(this.BtnUTF8Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder.ico");
            this.imageList.Images.SetKeyName(1, "file.ico");
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 659);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRefresh.Location = new System.Drawing.Point(8, 57);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(202, 35);
            this.BtnRefresh.TabIndex = 23;
            this.BtnRefresh.Text = "重新整理";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // BtnBackup
            // 
            this.BtnBackup.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackup.Location = new System.Drawing.Point(934, 16);
            this.BtnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(67, 73);
            this.BtnBackup.TabIndex = 24;
            this.BtnBackup.Text = "備份";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackupClick);
            // 
            // chkNoCase
            // 
            this.chkNoCase.Checked = true;
            this.chkNoCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoCase.Location = new System.Drawing.Point(1048, 148);
            this.chkNoCase.Margin = new System.Windows.Forms.Padding(2);
            this.chkNoCase.Name = "chkNoCase";
            this.chkNoCase.Size = new System.Drawing.Size(107, 17);
            this.chkNoCase.TabIndex = 26;
            this.chkNoCase.Text = "不分大小寫";
            this.chkNoCase.UseVisualStyleBackColor = true;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Location = new System.Drawing.Point(1005, 16);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(67, 73);
            this.BtnAbout.TabIndex = 27;
            this.BtnAbout.Text = "關於";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.chkNoCase);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.BtnUTF8);
            this.Controls.Add(this.BtnNewLine);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSearchFolder);
            this.Controls.Add(this.BtnSmall);
            this.Controls.Add(this.BtnBig);
            this.Controls.Add(this.treeViewFile);
            this.Controls.Add(this.BtnSearchFile);
            this.Controls.Add(this.combSearch);
            this.Controls.Add(this.lstBoxSearch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnFileManager);
            this.Controls.Add(this.BtnLine2);
            this.Controls.Add(this.BtnLine1);
            this.Controls.Add(this.BtnNewContent);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.Content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EZNotepad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button BtnAbout;
    }
}
