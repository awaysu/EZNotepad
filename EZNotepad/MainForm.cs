/*
 * 由SharpDevelop创建。
 * 用户： jason_su
 * 日期: 11/20/2023
 * 时间: PM 02:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;  
using System.Threading;  
using System.IO;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.IO.Compression;

namespace EZNotepad
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		/* ========================= 參數 ========================= */
		public const string NEW_FILE_NAME = "newfile";
		public const string PARA_TOP_PATH_NAME = "TOP_PATH";
		public const string PARA_FONT_SIZE_NAME = "FONT_SIZE";
		public const string PARA_SEARCH_NAME = "SEARCH";
		public const char SPLIT_STR= '|';
		public const string NAME_NOTEPAD_PATH = "\\Notepad\\";
		public const string NAME_BACKUP_PATH = "\\Backup\\";
		public const string  WINRAR = @"C:\Program Files\WinRAR\WinRAR.exe";
		
		string gGlobalTopPath = @"d:\123";
		string gGlobalBackupPath;
		string gCurrentFile = "";
		int globalFontSize = 14;
		bool editMode = false;
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/* ========================= 起始 ========================= */
		
		void MainFormLoad(object sender, EventArgs e)
		{
			treeViewFile.ImageList = imageList;
			
			init();
			reWindowSize();
			loadHistoryTocombSearch();
			paintTreeView(treeViewFile, gGlobalTopPath);
			changeFontSize();
			refreshBtnEditSave();
			treeViewFile.Focus();		
		}
		
		void init()
		{
			string ProcessName = Process.GetCurrentProcess().ProcessName;
			Process[] p = Process.GetProcessesByName(ProcessName);
			if (p.Length > 1)
			{
				// Add Code
				MessageBox.Show(ProcessName + "程式重複執行！");
				Environment.Exit(1);
			}

			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

			this.Text = "EZNotepad v" + fvi.FileVersion + " by Awaysu";
			
			globalFontSize = Convert.ToInt16(GetConfig(PARA_FONT_SIZE_NAME));
			
			if (globalFontSize == 0)
				globalFontSize = 14;

			/* -------------------------------------------- */
			/*
			gGlobalTopPath = GetConfig(PARA_TOP_PATH_NAME);
			if (gGlobalTopPath == null || Directory.Exists(gGlobalTopPath) == false)
			{
				MessageBox.Show("找不到資料夾設定,請先設定路徑!");
			    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			    {
			        gGlobalTopPath = folderBrowserDialog1.SelectedPath;
			        SaveConfig(PARA_TOP_PATH_NAME, gGlobalTopPath);
			    }
			    else
			    	this.Close();
			}*/
			
			gGlobalTopPath = System.Windows.Forms.Application.StartupPath + NAME_NOTEPAD_PATH;
			if (gGlobalTopPath == null || Directory.Exists(gGlobalTopPath) == false)
			{
				System.IO.Directory.CreateDirectory(gGlobalTopPath);
			}
			
			gGlobalBackupPath = System.Windows.Forms.Application.StartupPath + NAME_BACKUP_PATH;
			if (gGlobalBackupPath == null || Directory.Exists(gGlobalBackupPath) == false)
			{
				System.IO.Directory.CreateDirectory(gGlobalBackupPath);
			}
			
			if (Directory.Exists(gGlobalTopPath) == false)
			{
				MessageBox.Show("錯誤:建立" + gGlobalTopPath + "資料夾失敗!!");
				return;
			}
			
			statusStrip.Items.Add("初始化:確認[" + gGlobalTopPath + "]資料夾成功!!");
		}
		
		void reWindowSize()
		{
			this.WindowState = FormWindowState.Maximized;  // 設定表單最大化   
			
			int w = this.Width;
			int h = this.Height;
		}
		
	    void loadHistoryTocombSearch()
	    {
	    	combSearch.Items.Clear();
	    	string oldstr = GetConfig(PARA_SEARCH_NAME);
	    	
	    	if (oldstr != null)
	    	{
		    	string[] history = oldstr.Split(SPLIT_STR);
		    	
		    	for (int i=0; i!= history.Length; i++)
		    	{
		    		if (history[i].ToString().Length > 0)
		    			combSearch.Items.Add(history[i].ToString());
		    	}
	    	}
	    }
		
		private void paintTreeView(TreeView treeView, string fullPath)
		{
		    try
		    {
		        treeView.Nodes.Clear(); // 清空TreeView
		
		        DirectoryInfo dirs = new DirectoryInfo(fullPath); // 获得程序所在路径的目录对象
		        DirectoryInfo[] dir = dirs.GetDirectories();      // 获得目录下文件夹对象
		        FileInfo[] file = dirs.GetFiles();               // 获得目录下文件对象
		        int dircount = dir.Length;                        // 获得文件夹对象数量
		        int filecount = file.Length;                      // 获得文件对象数量
		
		        // 循环文件夹
		        for (int i = 0; i < dircount; i++)
		        {
		            TreeNode folderNode = new TreeNode(dir[i].Name, 0, 0); // 使用第一個 icon（文件夾 icon）
		            string pathNode = fullPath + "\\" + dir[i].Name;
		            GetMultiNode(folderNode, pathNode);
		            treeView.Nodes.Add(folderNode);
		        }
		
		        // 循环文件
		        for (int j = 0; j < filecount; j++)
		        {
		            treeView.Nodes.Add(file[j].Name, file[j].Name,1, 1); // 使用第二個 icon（文件 icon）
		        }
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show(ex.Message + "\r\n出错的位置为：Form1.paintTreeView()");
		        return;
		    }
		    
		    statusStrip.Items.Add(";讀取文件成功!!");
		    timer1.Interval = 3000;
		    timer1.Start();
		}
		
		private bool GetMultiNode(TreeNode treeNode, string path)
		{
		    if (Directory.Exists(path) == false)
		    { return false; }
		
		    DirectoryInfo dirs = new DirectoryInfo(path);     // 获得程序所在路径的目录对象
		    DirectoryInfo[] dir = dirs.GetDirectories();      // 获得目录下文件夹对象
		    FileInfo[] file = dirs.GetFiles();               // 获得目录下文件对象
		    int dircount = dir.Length;                        // 获得文件夹对象数量
		    int filecount = file.Length;                      // 获得文件对象数量
		    int sumcount = dircount + filecount;
		
		    if (sumcount == 0)
		    { return false; }
		
		    // 循环文件夹
		    for (int j = 0; j < dircount; j++)
		    {
		        TreeNode folderNode = new TreeNode(dir[j].Name, 0, 0); // 使用第一個 icon（文件夾 icon）
		        string pathNodeB = path + "\\" + dir[j].Name;
		        GetMultiNode(folderNode, pathNodeB);
		        treeNode.Nodes.Add(folderNode);
		    }
		
		    // 循环文件
		    for (int j = 0; j < filecount; j++)
		    {
		        treeNode.Nodes.Add(file[j].Name,file[j].Name, 1, 1); // 使用第二個 icon（文件 icon）
		    }
		    return true;
		}
		
		void changeFontSize()
		{
			if (globalFontSize < 6)
				globalFontSize = 6;
			
			if (globalFontSize > 30)
				globalFontSize = 30;
			
			Content.Font = new Font(Content.Font.FontFamily, globalFontSize);
			SaveConfig(PARA_FONT_SIZE_NAME, globalFontSize.ToString());
		}
		
		void refreshBtnEditSave()
		{
			if (editMode == true)
			{
				BtnEdit.Enabled = false;
				BtnSave.Enabled = true;
				Content.ReadOnly = false;
				BtnLine1.Enabled = true;
				BtnLine2.Enabled = true;
				btnUTF8.Enabled = true;
				btnCancel.Enabled = true;
				Content.BackColor = SystemColors.Window;				
			}
			else
			{
				BtnEdit.Enabled = true;
				BtnSave.Enabled = false;
				Content.ReadOnly = true;
				BtnLine1.Enabled = false;
				BtnLine2.Enabled = false;		
				btnUTF8.Enabled = false;
				btnCancel.Enabled = false;
				Content.BackColor = SystemColors.ButtonFace;
			}
			
		}
		
		/* ========================= 常用function ========================= */
		
		String GetConfig(String name)
		{
			String aa= ConfigurationManager.AppSettings[name];			
			return ConfigurationManager.AppSettings[name];
		}
		
		void SaveConfig(String name, String para)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings.Remove(name);			
			config.AppSettings.Settings.Add(name, para);
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings"); 
		}
		
		int createFolder(string path)
		{
            if (Directory.Exists(path))
            {
                //Console.WriteLine("That path exists already.");
                return -1;
            }
            
            Directory.CreateDirectory(path);
            
            if (! Directory.Exists(path))
            {
                //Console.WriteLine("That path exists already.");
                return -2;
            }
            
            return 0;
		}

		 int getLineNumber()
	    {
	        int LineNumber;
	        LineNumber = Content.Lines.Length;
	        return LineNumber;
	    }
		 
		/* ========================= 功能鍵 ========================= */
		
		void BtnEditClick(object sender, EventArgs e)
		{			
			if (File.Exists(gCurrentFile) == true)
			{
				editMode = true;
				refreshBtnEditSave();
			}
			else
				MessageBox.Show("請先選一個檔案!");
			
			Content.Focus();
		}
 		
		void BtnSaveClick(object sender, EventArgs e)
		{
			File.WriteAllText(gCurrentFile, Content.Text, System.Text.Encoding.Default);
			
			editMode = false;
		
			paintTreeView(treeViewFile, gGlobalTopPath);
			refreshBtnEditSave();
			
			Content.Focus();
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			editMode = false;
			refreshBtnEditSave();
			
			Content.Focus();
		}
		
		void LstNewTypeClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("Explorer.exe", "/e, " + gGlobalTopPath);
			Content.Focus();
		}
		
		void BtnNewContentClick(object sender, EventArgs e)
		{
			editMode = true;
			Content.Text = "";
			string newfile = Interaction.InputBox("請輸入檔名", "新建", NEW_FILE_NAME, 200, 200);
			if (newfile == null || newfile.Length == 0)
				newfile = NEW_FILE_NAME;
			
			gCurrentFile = gGlobalTopPath + "\\" + newfile + ".txt";	
			this.Text = gCurrentFile;
			
			refreshBtnEditSave();
	
			Content.Focus();
		}
		
		void BtnLine1Click(object sender, EventArgs e)
		{
			string insertText = "--------------------------------";
			var selectionIndex = Content.SelectionStart;
			Content.Text = Content.Text.Insert(selectionIndex, insertText);
			Content.SelectionStart = selectionIndex + insertText.Length;
			Content.Focus();
		}
		
		void BtnLine2Click(object sender, EventArgs e)
		{
			string insertText = "================================";
			var selectionIndex = Content.SelectionStart;
			Content.Text = Content.Text.Insert(selectionIndex, insertText);
			Content.SelectionStart = selectionIndex + insertText.Length;
			Content.Focus();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			globalFontSize = globalFontSize + 2;			
			changeFontSize();
			
			Content.Focus();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			globalFontSize = globalFontSize - 2;
			changeFontSize();
			
			Content.Focus();
		}
		
		void BtnNewLineClick(object sender, EventArgs e)
		{
			Content.WordWrap = !Content.WordWrap;
			Content.Focus();
		}
		
		void BtnUTF8Click(object sender, EventArgs e)
		{
			if (File.Exists(gCurrentFile) == true)
			{
				Content.Text = File.ReadAllText(gCurrentFile, System.Text.Encoding.UTF8);
				this.Text = gCurrentFile;
			}
			
			Content.Focus();
		}
		
		/* ========================= 事件 ========================= */

		void TreeViewFileDoubleClick(object sender, EventArgs e)
		{
			combSearch.Text ="";
			lstBoxSearch.Items.Clear();
			
			try
			{
				string file = treeViewFile.SelectedNode.FullPath;
				string path = gGlobalTopPath + "\\" + file;
				if(File.Exists(path))
				{				
				    //Content.Text = File.ReadAllText(path,System.Text.Encoding.UTF8);
				    // 指定 Encoding 為 System.Text.Encoding.Default (作業系統目前 ANSI 字碼頁的編碼方式)
				    Content.Text = File.ReadAllText(path ,System.Text.Encoding.Default);
				    gCurrentFile = path;
				    this.Text = file;
				    editMode = false;
				    refreshBtnEditSave();
				    statusStrip.Items.Add("開啟" + gCurrentFile + "成功!");
				}
			}
			catch(Exception)
			{
				statusStrip.Items.Add("開啟" + gCurrentFile + "失敗");
			}
			
			timer1.Start();
		}
		
		void ContentChange()
		{
			string tmp = Content.Text.Substring(0, Content.SelectionStart);
			int line = tmp.Split('\n').Length - 1;
			toolStripStatusLabel1.Text = "Line:" + line.ToString();

		}

		void ContentMouseDown(object sender, MouseEventArgs e)
		{						
			ContentChange();
		}
		
		void ContentKeyDown(object sender, KeyEventArgs e)
		{
			ContentChange();
		}
		
		void LstBoxSearchClick(object sender, EventArgs e)
		{
			if (lstBoxSearch.SelectedIndex >=0)
				toolStripStatusLabel1.Text = lstBoxSearch.Items[lstBoxSearch.SelectedIndex].ToString();
		}
		
		/* ========================= 搜尋 ========================= */

		int searchFileFromString(string file)
		{
	        
	        string temp = File.ReadAllText(file ,System.Text.Encoding.Default);
	        int start = 0;
	        int find = 0;
	        
	        while(true)
	        {
	        	if (chkNoCase.Checked == true)
	        		find = temp.IndexOf(combSearch.Text, start, StringComparison.OrdinalIgnoreCase);
	        	else
	        		find = temp.IndexOf(combSearch.Text, start);
	        	
	        	if (find >= 0)
	        	{
	        		string shorttxt = temp.Substring(0, find);
					int line = shorttxt.Split('\n').Length - 1;
					string show = line.ToString() + " ; " + find.ToString() + " ; " + file;
                	lstBoxSearch.Items.Add(show);	  
                	start = find + 1;
	        	}
	        	else
	        		break;	        	        	
	        }

	        return 0;
		}

		void BtnSearchFolderClick(object sender, EventArgs e)
		{
            lstBoxSearch.Items.Clear();
            
			if (combSearch.Text.Length == 0)
				return;
			
            addNewSearchToHistory(combSearch.Text);
            
			List<string> files = GetAllFiles(gGlobalTopPath);
            foreach (string file in files)
            {
                searchFileFromString(file);
            }
            
            Content.Focus();
		}
		
	    static List<string> GetAllFiles(string directory)
	    {
	        List<string> files = new List<string>(Directory.GetFiles(directory));
	        string[] subdirectories = Directory.GetDirectories(directory);
	        foreach (string subdirectory in subdirectories)
	        {
	            files.AddRange(GetAllFiles(subdirectory));
	        }
	        return files;
	    }
		
	    void addNewSearchToHistory(string newstr)
	    {
	    	string newhistory = newstr + "|";
	    	string oldstr = GetConfig(PARA_SEARCH_NAME);
	    	
	    	if (oldstr != null)
	    	{
		    	string[] history = oldstr.Split(SPLIT_STR);
		    	int len = history.Length;
		    	
		    	if (len > 9)
		    		len = 9;
		    	
		    	for (int i=0; i!= len; i++)
		    	{
		    		if (history[i].Length > 0)
		    			newhistory = newhistory + "|" + history[i];
		    	}
	    	}
	    	
	    	SaveConfig(PARA_SEARCH_NAME, newhistory);
	    	
	    	loadHistoryTocombSearch();
	    	
	    }
	    
		void BtnSearchFileClick(object sender, EventArgs e)
		{
			if (combSearch.Text.Length == 0)
				return;
			
			lstBoxSearch.Items.Clear();
			
			addNewSearchToHistory(combSearch.Text);
			
			if (File.Exists(gCurrentFile))						
				searchFileFromString(gCurrentFile);
			else
				MessageBox.Show("請先開啟檔案!");
			
			Content.Focus();
		}
		
		void LstBoxSearchDoubleClick(object sender, EventArgs e)
		{
			int num = 0;
			string file = "";
			
			if (lstBoxSearch.SelectedIndex >= 0 )
			{
				try
				{
					string[] words = lstBoxSearch.Text.Split(';');
					num = Int32.Parse(words[1].Trim());
					file = words[2].Trim();
					Content.Text = File.ReadAllText(file ,System.Text.Encoding.Default);
					gCurrentFile = file;
					this.Text = gCurrentFile;
					
					Content.Focus();
					Content.SelectionStart = num;
					Content.SelectionLength = combSearch.Text.Length;
					Content.ScrollToCaret();

				}
				catch(Exception)
				{
				}
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			statusStrip.Items.Clear();
		}

		void BtnRefreshClick(object sender, EventArgs e)
		{
			paintTreeView(treeViewFile, gGlobalTopPath);
			Content.Focus();
		}
		
		void BtnBackupClick(object sender, EventArgs e)
		{
			if (File.Exists(WINRAR))	
			{				
				DateTime d1= DateTime.Now;
				string str = d1.ToString("yyyyMMddhh");
				
				System.Diagnostics.Process.Start(WINRAR, " a  " + "backup\\Notepad_" + str + ".rar Notepad");
				System.Diagnostics.Process.Start("Explorer.exe", "/e, " + "backup");
			}
			else
				MessageBox.Show("無法備份,請先安裝WinRAR!");

		}


	}
}
