namespace PPTConverter
{
	partial class PPTConverterForm
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
			this.listBoxFiles = new System.Windows.Forms.ListBox();
			this.textBoxFolder = new System.Windows.Forms.TextBox();
			this.FolderDlgBtn = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnConvertSelected = new System.Windows.Forms.Button();
			this.btnConvertAll = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// listBoxFiles
			// 
			this.listBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxFiles.FormattingEnabled = true;
			this.listBoxFiles.ItemHeight = 16;
			this.listBoxFiles.Location = new System.Drawing.Point(22, 92);
			this.listBoxFiles.Name = "listBoxFiles";
			this.listBoxFiles.Size = new System.Drawing.Size(313, 244);
			this.listBoxFiles.TabIndex = 2;
			// 
			// textBoxFolder
			// 
			this.textBoxFolder.AllowDrop = true;
			this.textBoxFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.textBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFolder.Location = new System.Drawing.Point(22, 30);
			this.textBoxFolder.Name = "textBoxFolder";
			this.textBoxFolder.Size = new System.Drawing.Size(411, 22);
			this.textBoxFolder.TabIndex = 0;
			this.textBoxFolder.TextChanged += new System.EventHandler(this.OnFolderTextChanged);
			this.textBoxFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
			this.textBoxFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFolderDragEnter);
			// 
			// FolderDlgBtn
			// 
			this.FolderDlgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FolderDlgBtn.Location = new System.Drawing.Point(457, 30);
			this.FolderDlgBtn.Name = "FolderDlgBtn";
			this.FolderDlgBtn.Size = new System.Drawing.Size(76, 23);
			this.FolderDlgBtn.TabIndex = 1;
			this.FolderDlgBtn.Text = "Browse...";
			this.FolderDlgBtn.UseVisualStyleBackColor = true;
			this.FolderDlgBtn.Click += new System.EventHandler(this.FolderDlgBtn_Click);
			// 
			// btnConvertSelected
			// 
			this.btnConvertSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertSelected.Location = new System.Drawing.Point(396, 92);
			this.btnConvertSelected.Name = "btnConvertSelected";
			this.btnConvertSelected.Size = new System.Drawing.Size(137, 47);
			this.btnConvertSelected.TabIndex = 3;
			this.btnConvertSelected.Text = "Convert Selected";
			this.btnConvertSelected.UseVisualStyleBackColor = true;
			this.btnConvertSelected.Click += new System.EventHandler(this.btnConvertSelected_Click);
			// 
			// btnConvertAll
			// 
			this.btnConvertAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertAll.Location = new System.Drawing.Point(396, 167);
			this.btnConvertAll.Name = "btnConvertAll";
			this.btnConvertAll.Size = new System.Drawing.Size(137, 47);
			this.btnConvertAll.TabIndex = 4;
			this.btnConvertAll.Text = "Convert All";
			this.btnConvertAll.UseVisualStyleBackColor = true;
			this.btnConvertAll.Click += new System.EventHandler(this.btnConvertAll_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(109, 353);
			this.progressBar1.Maximum = 10000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(378, 23);
			this.progressBar1.Step = 100;
			this.progressBar1.TabIndex = 5;
			// 
			// PPTConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 398);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnConvertAll);
			this.Controls.Add(this.btnConvertSelected);
			this.Controls.Add(this.FolderDlgBtn);
			this.Controls.Add(this.textBoxFolder);
			this.Controls.Add(this.listBoxFiles);
			this.Name = "PPTConverterForm";
			this.Text = "Powerpoint Converter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PPTConverterForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxFiles;
		private System.Windows.Forms.TextBox textBoxFolder;
		private System.Windows.Forms.Button FolderDlgBtn;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnConvertSelected;
		private System.Windows.Forms.Button btnConvertAll;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

