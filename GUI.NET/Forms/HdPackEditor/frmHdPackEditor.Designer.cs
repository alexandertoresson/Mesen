namespace Mesen.GUI.Forms.HdPackEditor
{
	partial class frmHdPackEditor
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
			if(disposing && (components != null)) {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.picBankPreview = new System.Windows.Forms.PictureBox();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.lblChrBank = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkIgnoreOverscan = new System.Windows.Forms.CheckBox();
            this.picIgnoreOverscanHelp = new System.Windows.Forms.PictureBox();
            this.lblBankSize = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkGroupBlankTiles = new System.Windows.Forms.CheckBox();
            this.picGroupBlankHelp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSortByFrequency = new System.Windows.Forms.CheckBox();
            this.picFrequencyHelp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkLargeSprites = new System.Windows.Forms.CheckBox();
            this.picLargeSpritesHelp = new System.Windows.Forms.PictureBox();
            this.flpBankSize = new System.Windows.Forms.FlowLayoutPanel();
            this.cboChrBankSize = new System.Windows.Forms.ComboBox();
            this.picBankSizeHelp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboScale = new System.Windows.Forms.ComboBox();
            this.picScaleHelp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSaveFrame = new System.Windows.Forms.CheckBox();
            this.picSaveFrameHelp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboTileType = new System.Windows.Forms.ComboBox();
            this.picTileTypeHelp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBankPreview)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIgnoreOverscanHelp)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGroupBlankHelp)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFrequencyHelp)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLargeSpritesHelp)).BeginInit();
            this.flpBankSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBankSizeHelp)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScaleHelp)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveFrameHelp)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileTypeHelp)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnStopRecording, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnStartRecording, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenFolder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.grpPreview, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpOptions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopRecording.AutoSize = true;
            this.btnStopRecording.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStopRecording.Image = global::Mesen.GUI.Properties.Resources.Stop;
            this.btnStopRecording.Location = new System.Drawing.Point(395, 322);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(104, 20);
            this.btnStopRecording.TabIndex = 12;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartRecording.AutoSize = true;
            this.btnStartRecording.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartRecording.Image = global::Mesen.GUI.Properties.Resources.Record;
            this.btnStartRecording.Location = new System.Drawing.Point(505, 322);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(104, 20);
            this.btnStartRecording.TabIndex = 13;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AutoSize = true;
            this.btnOpenFolder.Image = global::Mesen.GUI.Properties.Resources.FolderOpen;
            this.btnOpenFolder.Location = new System.Drawing.Point(3, 322);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(119, 20);
            this.btnOpenFolder.TabIndex = 11;
            this.btnOpenFolder.Text = "Open Save Folder";
            this.btnOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // grpPreview
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpPreview, 2);
            this.grpPreview.Controls.Add(this.tableLayoutPanel3);
            this.grpPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPreview.Location = new System.Drawing.Point(340, 30);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(269, 286);
            this.grpPreview.TabIndex = 0;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "CHR Bank Preview";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.picBankPreview, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboBank, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblChrBank, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(263, 265);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // picBankPreview
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.picBankPreview, 2);
            this.picBankPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBankPreview.Location = new System.Drawing.Point(3, 29);
            this.picBankPreview.Name = "picBankPreview";
            this.picBankPreview.Size = new System.Drawing.Size(257, 233);
            this.picBankPreview.TabIndex = 0;
            this.picBankPreview.TabStop = false;
            // 
            // cboBank
            // 
            this.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(69, 3);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(121, 20);
            this.cboBank.TabIndex = 10;
            // 
            // lblChrBank
            // 
            this.lblChrBank.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChrBank.AutoSize = true;
            this.lblChrBank.Location = new System.Drawing.Point(3, 7);
            this.lblChrBank.Name = "lblChrBank";
            this.lblChrBank.Size = new System.Drawing.Size(60, 12);
            this.lblChrBank.TabIndex = 3;
            this.lblChrBank.Text = "CHR Bank:";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.tableLayoutPanel2);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 30);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(331, 286);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Recording Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblBankSize, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblScale, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.flpBankSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 265);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.chkIgnoreOverscan);
            this.flowLayoutPanel1.Controls.Add(this.picIgnoreOverscanHelp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 18);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // chkIgnoreOverscan
            // 
            this.chkIgnoreOverscan.AutoSize = true;
            this.chkIgnoreOverscan.Location = new System.Drawing.Point(3, 3);
            this.chkIgnoreOverscan.Name = "chkIgnoreOverscan";
            this.chkIgnoreOverscan.Size = new System.Drawing.Size(247, 16);
            this.chkIgnoreOverscan.TabIndex = 8;
            this.chkIgnoreOverscan.Text = "Ignore tiles at the edges of the screen (overscan)";
            this.chkIgnoreOverscan.UseVisualStyleBackColor = true;
            // 
            // picIgnoreOverscanHelp
            // 
            this.picIgnoreOverscanHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picIgnoreOverscanHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picIgnoreOverscanHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picIgnoreOverscanHelp.Location = new System.Drawing.Point(256, 3);
            this.picIgnoreOverscanHelp.Name = "picIgnoreOverscanHelp";
            this.picIgnoreOverscanHelp.Size = new System.Drawing.Size(16, 16);
            this.picIgnoreOverscanHelp.TabIndex = 18;
            this.picIgnoreOverscanHelp.TabStop = false;
            // 
            // lblBankSize
            // 
            this.lblBankSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBankSize.AutoSize = true;
            this.lblBankSize.Location = new System.Drawing.Point(3, 27);
            this.lblBankSize.Name = "lblBankSize";
            this.lblBankSize.Size = new System.Drawing.Size(82, 12);
            this.lblBankSize.TabIndex = 9;
            this.lblBankSize.Text = "CHR Bank Size:";
            // 
            // lblScale
            // 
            this.lblScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(3, 5);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(59, 12);
            this.lblScale.TabIndex = 4;
            this.lblScale.Text = "Scale/Filter:";
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.chkGroupBlankTiles);
            this.flowLayoutPanel3.Controls.Add(this.picGroupBlankHelp);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(325, 20);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // chkGroupBlankTiles
            // 
            this.chkGroupBlankTiles.AutoSize = true;
            this.chkGroupBlankTiles.Checked = true;
            this.chkGroupBlankTiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroupBlankTiles.Location = new System.Drawing.Point(3, 3);
            this.chkGroupBlankTiles.Name = "chkGroupBlankTiles";
            this.chkGroupBlankTiles.Size = new System.Drawing.Size(104, 16);
            this.chkGroupBlankTiles.TabIndex = 5;
            this.chkGroupBlankTiles.Text = "Group blank tiles";
            this.chkGroupBlankTiles.UseVisualStyleBackColor = true;
            // 
            // picGroupBlankHelp
            // 
            this.picGroupBlankHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picGroupBlankHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picGroupBlankHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picGroupBlankHelp.Location = new System.Drawing.Point(113, 3);
            this.picGroupBlankHelp.Name = "picGroupBlankHelp";
            this.picGroupBlankHelp.Size = new System.Drawing.Size(16, 16);
            this.picGroupBlankHelp.TabIndex = 12;
            this.picGroupBlankHelp.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.chkSortByFrequency);
            this.flowLayoutPanel4.Controls.Add(this.picFrequencyHelp);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 64);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(325, 20);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // chkSortByFrequency
            // 
            this.chkSortByFrequency.AutoSize = true;
            this.chkSortByFrequency.Checked = true;
            this.chkSortByFrequency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortByFrequency.Location = new System.Drawing.Point(3, 3);
            this.chkSortByFrequency.Name = "chkSortByFrequency";
            this.chkSortByFrequency.Size = new System.Drawing.Size(166, 16);
            this.chkSortByFrequency.TabIndex = 6;
            this.chkSortByFrequency.Text = "Sort pages by usage frequency";
            this.chkSortByFrequency.UseVisualStyleBackColor = true;
            // 
            // picFrequencyHelp
            // 
            this.picFrequencyHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picFrequencyHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picFrequencyHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFrequencyHelp.Location = new System.Drawing.Point(175, 3);
            this.picFrequencyHelp.Name = "picFrequencyHelp";
            this.picFrequencyHelp.Size = new System.Drawing.Size(16, 16);
            this.picFrequencyHelp.TabIndex = 12;
            this.picFrequencyHelp.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel5, 2);
            this.flowLayoutPanel5.Controls.Add(this.chkLargeSprites);
            this.flowLayoutPanel5.Controls.Add(this.picLargeSpritesHelp);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 84);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(325, 20);
            this.flowLayoutPanel5.TabIndex = 14;
            // 
            // chkLargeSprites
            // 
            this.chkLargeSprites.AutoSize = true;
            this.chkLargeSprites.Location = new System.Drawing.Point(3, 3);
            this.chkLargeSprites.Name = "chkLargeSprites";
            this.chkLargeSprites.Size = new System.Drawing.Size(161, 16);
            this.chkLargeSprites.TabIndex = 7;
            this.chkLargeSprites.Text = "Use 8x16 sprite display mode";
            this.chkLargeSprites.UseVisualStyleBackColor = true;
            // 
            // picLargeSpritesHelp
            // 
            this.picLargeSpritesHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picLargeSpritesHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picLargeSpritesHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLargeSpritesHelp.Location = new System.Drawing.Point(170, 3);
            this.picLargeSpritesHelp.Name = "picLargeSpritesHelp";
            this.picLargeSpritesHelp.Size = new System.Drawing.Size(16, 16);
            this.picLargeSpritesHelp.TabIndex = 12;
            this.picLargeSpritesHelp.TabStop = false;
            // 
            // flpBankSize
            // 
            this.flpBankSize.Controls.Add(this.cboChrBankSize);
            this.flpBankSize.Controls.Add(this.picBankSizeHelp);
            this.flpBankSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBankSize.Location = new System.Drawing.Point(88, 22);
            this.flpBankSize.Margin = new System.Windows.Forms.Padding(0);
            this.flpBankSize.Name = "flpBankSize";
            this.flpBankSize.Size = new System.Drawing.Size(237, 22);
            this.flpBankSize.TabIndex = 15;
            // 
            // cboChrBankSize
            // 
            this.cboChrBankSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChrBankSize.FormattingEnabled = true;
            this.cboChrBankSize.Items.AddRange(new object[] {
            "1 KB",
            "2 KB",
            "4 KB"});
            this.cboChrBankSize.Location = new System.Drawing.Point(3, 3);
            this.cboChrBankSize.Name = "cboChrBankSize";
            this.cboChrBankSize.Size = new System.Drawing.Size(105, 20);
            this.cboChrBankSize.TabIndex = 4;
            // 
            // picBankSizeHelp
            // 
            this.picBankSizeHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picBankSizeHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picBankSizeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBankSizeHelp.Location = new System.Drawing.Point(114, 6);
            this.picBankSizeHelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.picBankSizeHelp.Name = "picBankSizeHelp";
            this.picBankSizeHelp.Size = new System.Drawing.Size(16, 16);
            this.picBankSizeHelp.TabIndex = 12;
            this.picBankSizeHelp.TabStop = false;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.cboScale);
            this.flowLayoutPanel6.Controls.Add(this.picScaleHelp);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(88, 0);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(237, 22);
            this.flowLayoutPanel6.TabIndex = 16;
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(3, 3);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(105, 20);
            this.cboScale.TabIndex = 3;
            // 
            // picScaleHelp
            // 
            this.picScaleHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picScaleHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picScaleHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picScaleHelp.Location = new System.Drawing.Point(114, 6);
            this.picScaleHelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.picScaleHelp.Name = "picScaleHelp";
            this.picScaleHelp.Size = new System.Drawing.Size(16, 16);
            this.picScaleHelp.TabIndex = 12;
            this.picScaleHelp.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.chkSaveFrame);
            this.flowLayoutPanel2.Controls.Add(this.picSaveFrameHelp);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 122);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 18);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // chkSaveFrame
            // 
            this.chkSaveFrame.AutoSize = true;
            this.chkSaveFrame.Location = new System.Drawing.Point(3, 3);
            this.chkSaveFrame.Name = "chkSaveFrame";
            this.chkSaveFrame.Size = new System.Drawing.Size(220, 16);
            this.chkSaveFrame.TabIndex = 9;
            this.chkSaveFrame.Text = "Save frames which the tiles are first shown";
            this.chkSaveFrame.UseVisualStyleBackColor = true;
            // 
            // picSaveFrameHelp
            // 
            this.picSaveFrameHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picSaveFrameHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picSaveFrameHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSaveFrameHelp.Location = new System.Drawing.Point(229, 3);
            this.picSaveFrameHelp.Name = "picSaveFrameHelp";
            this.picSaveFrameHelp.Size = new System.Drawing.Size(16, 16);
            this.picSaveFrameHelp.TabIndex = 19;
            this.picSaveFrameHelp.TabStop = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.cboTileType);
            this.flowLayoutPanel7.Controls.Add(this.picTileTypeHelp);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(88, 140);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(237, 22);
            this.flowLayoutPanel7.TabIndex = 22;
            // 
            // cboTileType
            // 
            this.cboTileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTileType.DropDownWidth = 105;
            this.cboTileType.FormattingEnabled = true;
            this.cboTileType.Location = new System.Drawing.Point(3, 3);
            this.cboTileType.Name = "cboTileType";
            this.cboTileType.Size = new System.Drawing.Size(105, 20);
            this.cboTileType.TabIndex = 0;
            // 
            // picTileTypeHelp
            // 
            this.picTileTypeHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picTileTypeHelp.BackgroundImage = global::Mesen.GUI.Properties.Resources.Help;
            this.picTileTypeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picTileTypeHelp.Location = new System.Drawing.Point(114, 5);
            this.picTileTypeHelp.Name = "picTileTypeHelp";
            this.picTileTypeHelp.Size = new System.Drawing.Size(16, 16);
            this.picTileTypeHelp.TabIndex = 20;
            this.picTileTypeHelp.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tile Type:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnSelectFolder, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSaveFolder, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFolder, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(502, 27);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSize = true;
            this.btnSelectFolder.Location = new System.Drawing.Point(437, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(62, 21);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Browse...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaveFolder.Location = new System.Drawing.Point(72, 3);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.ReadOnly = true;
            this.txtSaveFolder.Size = new System.Drawing.Size(359, 22);
            this.txtSaveFolder.TabIndex = 1;
            this.txtSaveFolder.TabStop = false;
            // 
            // lblFolder
            // 
            this.lblFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(3, 7);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(63, 12);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Save Folder:";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 200;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // frmHdPackEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 384);
            this.Name = "frmHdPackEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HD Pack Builder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBankPreview)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIgnoreOverscanHelp)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGroupBlankHelp)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFrequencyHelp)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLargeSpritesHelp)).EndInit();
            this.flpBankSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBankSizeHelp)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScaleHelp)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveFrameHelp)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTileTypeHelp)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox grpPreview;
		private System.Windows.Forms.PictureBox picBankPreview;
		private System.Windows.Forms.Timer tmrRefresh;
		private System.Windows.Forms.ComboBox cboBank;
		private System.Windows.Forms.CheckBox chkSortByFrequency;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lblChrBank;
		private System.Windows.Forms.GroupBox grpOptions;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lblScale;
		private System.Windows.Forms.ComboBox cboScale;
		private System.Windows.Forms.Button btnStartRecording;
		private System.Windows.Forms.CheckBox chkLargeSprites;
		private System.Windows.Forms.Label lblFolder;
		private System.Windows.Forms.TextBox txtSaveFolder;
		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.ComboBox cboChrBankSize;
		private System.Windows.Forms.Label lblBankSize;
		private System.Windows.Forms.Button btnStopRecording;
		private System.Windows.Forms.CheckBox chkGroupBlankTiles;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.PictureBox picGroupBlankHelp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.PictureBox picFrequencyHelp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.PictureBox picLargeSpritesHelp;
		private System.Windows.Forms.FlowLayoutPanel flpBankSize;
		private System.Windows.Forms.PictureBox picBankSizeHelp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.PictureBox picScaleHelp;
		private System.Windows.Forms.Button btnOpenFolder;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.CheckBox chkIgnoreOverscan;
		private System.Windows.Forms.PictureBox picIgnoreOverscanHelp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	  private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
	  private System.Windows.Forms.CheckBox chkSaveFrame;
	  private System.Windows.Forms.PictureBox picSaveFrameHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.ComboBox cboTileType;
        private System.Windows.Forms.PictureBox picTileTypeHelp;
        private System.Windows.Forms.Label label1;
    }
}