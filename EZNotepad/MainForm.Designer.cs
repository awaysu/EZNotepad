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
		private System.Windows.Forms.Button LstNewType;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.ListBox lstBoxSearch;
		private System.Windows.Forms.Button btnSearchFile;
		private System.Windows.Forms.ComboBox combSearch;
		private System.Windows.Forms.TreeView treeViewFile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnSearchFolder;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNewLine;
		private System.Windows.Forms.Button btnUTF8;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnBackup;
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
			this.LstNewType = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.lstBoxSearch = new System.Windows.Forms.ListBox();
			this.btnSearchFile = new System.Windows.Forms.Button();
			this.combSearch = new System.Windows.Forms.ComboBox();
			this.treeViewFile = new System.Windows.Forms.TreeView();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnSearchFolder = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnNewLine = new System.Windows.Forms.Button();
			this.btnUTF8 = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnBackup = new System.Windows.Forms.Button();
			this.chkNoCase = new System.Windows.Forms.CheckBox();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Content.Location = new System.Drawing.Point(341, 142);
			this.Content.Multiline = true;
			this.Content.Name = "Content";
			this.Content.ReadOnly = true;
			this.Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Content.Size = new System.Drawing.Size(1206, 783);
			this.Content.TabIndex = 1;
			this.Content.Text = "\r\n\r\n\r\n   Welcome!\r\n";
			this.Content.WordWrap = false;
			this.Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentMouseDown);
			// 
			// BtnEdit
			// 
			this.BtnEdit.Font = new System.Drawing.Font("新細明體", 14F);
			this.BtnEdit.Location = new System.Drawing.Point(447, 22);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(100, 100);
			this.BtnEdit.TabIndex = 3;
			this.BtnEdit.Text = "編輯";
			this.BtnEdit.UseVisualStyleBackColor = true;
			this.BtnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// BtnNewContent
			// 
			this.BtnNewContent.Font = new System.Drawing.Font("新細明體", 14F);
			this.BtnNewContent.Location = new System.Drawing.Point(341, 22);
			this.BtnNewContent.Name = "BtnNewContent";
			this.BtnNewContent.Size = new System.Drawing.Size(100, 100);
			this.BtnNewContent.TabIndex = 4;
			this.BtnNewContent.Text = "新建";
			this.BtnNewContent.UseVisualStyleBackColor = true;
			this.BtnNewContent.Click += new System.EventHandler(this.BtnNewContentClick);
			// 
			// BtnLine2
			// 
			this.BtnLine2.Font = new System.Drawing.Font("新細明體", 14F);
			this.BtnLine2.Location = new System.Drawing.Point(977, 22);
			this.BtnLine2.Name = "BtnLine2";
			this.BtnLine2.Size = new System.Drawing.Size(100, 100);
			this.BtnLine2.TabIndex = 6;
			this.BtnLine2.Text = "===";
			this.BtnLine2.UseVisualStyleBackColor = true;
			this.BtnLine2.Click += new System.EventHandler(this.BtnLine2Click);
			// 
			// BtnLine1
			// 
			this.BtnLine1.Font = new System.Drawing.Font("新細明體", 14F);
			this.BtnLine1.Location = new System.Drawing.Point(871, 22);
			this.BtnLine1.Name = "BtnLine1";
			this.BtnLine1.Size = new System.Drawing.Size(100, 100);
			this.BtnLine1.TabIndex = 5;
			this.BtnLine1.Text = "----";
			this.BtnLine1.UseVisualStyleBackColor = true;
			this.BtnLine1.Click += new System.EventHandler(this.BtnLine1Click);
			// 
			// LstNewType
			// 
			this.LstNewType.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LstNewType.Location = new System.Drawing.Point(12, 25);
			this.LstNewType.Name = "LstNewType";
			this.LstNewType.Size = new System.Drawing.Size(303, 48);
			this.LstNewType.TabIndex = 8;
			this.LstNewType.Text = "檔案總管";
			this.LstNewType.UseVisualStyleBackColor = true;
			this.LstNewType.Click += new System.EventHandler(this.LstNewTypeClick);
			// 
			// BtnSave
			// 
			this.BtnSave.Font = new System.Drawing.Font("新細明體", 14F);
			this.BtnSave.Location = new System.Drawing.Point(553, 22);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(100, 100);
			this.BtnSave.TabIndex = 9;
			this.BtnSave.Text = "存檔";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// lstBoxSearch
			// 
			this.lstBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstBoxSearch.FormattingEnabled = true;
			this.lstBoxSearch.HorizontalScrollbar = true;
			this.lstBoxSearch.ItemHeight = 33;
			this.lstBoxSearch.Location = new System.Drawing.Point(1572, 360);
			this.lstBoxSearch.Name = "lstBoxSearch";
			this.lstBoxSearch.Size = new System.Drawing.Size(303, 565);
			this.lstBoxSearch.TabIndex = 10;
			this.lstBoxSearch.Click += new System.EventHandler(this.LstBoxSearchClick);
			this.lstBoxSearch.DoubleClick += new System.EventHandler(this.LstBoxSearchDoubleClick);
			// 
			// btnSearchFile
			// 
			this.btnSearchFile.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearchFile.Location = new System.Drawing.Point(1572, 241);
			this.btnSearchFile.Name = "btnSearchFile";
			this.btnSearchFile.Size = new System.Drawing.Size(303, 48);
			this.btnSearchFile.TabIndex = 12;
			this.btnSearchFile.Text = "搜尋目前檔案";
			this.btnSearchFile.UseVisualStyleBackColor = true;
			this.btnSearchFile.Click += new System.EventHandler(this.BtnSearchFileClick);
			// 
			// combSearch
			// 
			this.combSearch.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.combSearch.FormattingEnabled = true;
			this.combSearch.Location = new System.Drawing.Point(1572, 138);
			this.combSearch.Name = "combSearch";
			this.combSearch.Size = new System.Drawing.Size(303, 41);
			this.combSearch.TabIndex = 11;
			// 
			// treeViewFile
			// 
			this.treeViewFile.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeViewFile.Location = new System.Drawing.Point(12, 142);
			this.treeViewFile.Name = "treeViewFile";
			this.treeViewFile.Size = new System.Drawing.Size(303, 783);
			this.treeViewFile.TabIndex = 13;
			this.treeViewFile.DoubleClick += new System.EventHandler(this.TreeViewFileDoubleClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("新細明體", 14F);
			this.button2.Location = new System.Drawing.Point(1189, 22);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 100);
			this.button2.TabIndex = 15;
			this.button2.Text = "字體縮小";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("新細明體", 14F);
			this.button3.Location = new System.Drawing.Point(1083, 22);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 100);
			this.button3.TabIndex = 14;
			this.button3.Text = "字體放大";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// btnSearchFolder
			// 
			this.btnSearchFolder.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearchFolder.Location = new System.Drawing.Point(1572, 295);
			this.btnSearchFolder.Name = "btnSearchFolder";
			this.btnSearchFolder.Size = new System.Drawing.Size(303, 48);
			this.btnSearchFolder.TabIndex = 16;
			this.btnSearchFolder.Text = "搜尋全部檔案";
			this.btnSearchFolder.UseVisualStyleBackColor = true;
			this.btnSearchFolder.Click += new System.EventHandler(this.BtnSearchFolderClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("新細明體", 14F);
			this.btnCancel.Location = new System.Drawing.Point(765, 22);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 100);
			this.btnCancel.TabIndex = 17;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnNewLine
			// 
			this.btnNewLine.Font = new System.Drawing.Font("新細明體", 14F);
			this.btnNewLine.Location = new System.Drawing.Point(1295, 22);
			this.btnNewLine.Name = "btnNewLine";
			this.btnNewLine.Size = new System.Drawing.Size(100, 100);
			this.btnNewLine.TabIndex = 18;
			this.btnNewLine.Text = "自動換行";
			this.btnNewLine.UseVisualStyleBackColor = true;
			this.btnNewLine.Click += new System.EventHandler(this.BtnNewLineClick);
			// 
			// btnUTF8
			// 
			this.btnUTF8.Font = new System.Drawing.Font("新細明體", 14F);
			this.btnUTF8.Location = new System.Drawing.Point(659, 22);
			this.btnUTF8.Name = "btnUTF8";
			this.btnUTF8.Size = new System.Drawing.Size(100, 100);
			this.btnUTF8.TabIndex = 19;
			this.btnUTF8.Text = "編碼";
			this.btnUTF8.UseVisualStyleBackColor = true;
			this.btnUTF8.Click += new System.EventHandler(this.BtnUTF8Click);
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
			this.statusStrip.Location = new System.Drawing.Point(0, 937);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1898, 22);
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
			// btnRefresh
			// 
			this.btnRefresh.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRefresh.Location = new System.Drawing.Point(12, 79);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(303, 48);
			this.btnRefresh.TabIndex = 23;
			this.btnRefresh.Text = "重新整理";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// btnBackup
			// 
			this.btnBackup.Font = new System.Drawing.Font("新細明體", 14F);
			this.btnBackup.Location = new System.Drawing.Point(1401, 22);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(100, 100);
			this.btnBackup.TabIndex = 24;
			this.btnBackup.Text = "備份";
			this.btnBackup.UseVisualStyleBackColor = true;
			this.btnBackup.Click += new System.EventHandler(this.BtnBackupClick);
			// 
			// chkNoCase
			// 
			this.chkNoCase.Checked = true;
			this.chkNoCase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNoCase.Location = new System.Drawing.Point(1572, 211);
			this.chkNoCase.Name = "chkNoCase";
			this.chkNoCase.Size = new System.Drawing.Size(161, 24);
			this.chkNoCase.TabIndex = 26;
			this.chkNoCase.Text = "不分大小寫";
			this.chkNoCase.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1898, 959);
			this.Controls.Add(this.chkNoCase);
			this.Controls.Add(this.btnBackup);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.btnUTF8);
			this.Controls.Add(this.btnNewLine);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSearchFolder);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.treeViewFile);
			this.Controls.Add(this.btnSearchFile);
			this.Controls.Add(this.combSearch);
			this.Controls.Add(this.lstBoxSearch);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.LstNewType);
			this.Controls.Add(this.BtnLine2);
			this.Controls.Add(this.BtnLine1);
			this.Controls.Add(this.BtnNewContent);
			this.Controls.Add(this.BtnEdit);
			this.Controls.Add(this.Content);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "EZNotepad";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			this.Controls.Add(this.BtnLine1);
			this.Controls.Add(this.BtnNewContent);
			this.Controls.Add(this.BtnEdit);
			this.Controls.Add(this.Content);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "EZNotepad";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
