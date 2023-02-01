namespace ACFAParamEditor
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.paramname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.celltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainerA = new System.Windows.Forms.SplitContainer();
            this.SplitContainerB = new System.Windows.Forms.SplitContainer();
            this.ReaderStatusStrip = new System.Windows.Forms.StatusStrip();
            this.TSSLParamReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLRowReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLCellReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLDefReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenParamsFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveSeparatorMS = new System.Windows.Forms.ToolStripSeparator();
            this.ExportFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertDefXmlEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertParamCsvEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertCsvParamEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertParamTsvEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertTsvParamEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RowMS = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRowRMS = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRowRMS = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMS = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutHMS = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerA)).BeginInit();
            this.SplitContainerA.Panel1.SuspendLayout();
            this.SplitContainerA.Panel2.SuspendLayout();
            this.SplitContainerA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerB)).BeginInit();
            this.SplitContainerB.Panel1.SuspendLayout();
            this.SplitContainerB.Panel2.SuspendLayout();
            this.SplitContainerB.SuspendLayout();
            this.ReaderStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RowDGV
            // 
            this.RowDGV.AllowUserToAddRows = false;
            this.RowDGV.AllowUserToDeleteRows = false;
            this.RowDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RowDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.RowDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RowDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RowDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RowDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowid,
            this.rowname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = "null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RowDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.RowDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowDGV.EnableHeadersVisualStyles = false;
            this.RowDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.RowDGV.Location = new System.Drawing.Point(0, 0);
            this.RowDGV.Name = "RowDGV";
            this.RowDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RowDGV.Size = new System.Drawing.Size(370, 605);
            this.RowDGV.TabIndex = 1;
            this.RowDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowDGV_CellValueChanged);
            this.RowDGV.SelectionChanged += new System.EventHandler(this.RowDGV_SelectionChanged);
            // 
            // rowid
            // 
            this.rowid.FillWeight = 48.63222F;
            this.rowid.HeaderText = "Row ID";
            this.rowid.Name = "rowid";
            // 
            // rowname
            // 
            this.rowname.FillWeight = 151.3678F;
            this.rowname.HeaderText = "Row Name";
            this.rowname.Name = "rowname";
            // 
            // ParamDGV
            // 
            this.ParamDGV.AllowUserToAddRows = false;
            this.ParamDGV.AllowUserToDeleteRows = false;
            this.ParamDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ParamDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ParamDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ParamDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParamDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.NullValue = "null";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ParamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramname,
            this.paramtype});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.NullValue = "null";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParamDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ParamDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamDGV.EnableHeadersVisualStyles = false;
            this.ParamDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ParamDGV.Location = new System.Drawing.Point(0, 0);
            this.ParamDGV.Name = "ParamDGV";
            this.ParamDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ParamDGV.Size = new System.Drawing.Size(370, 605);
            this.ParamDGV.TabIndex = 0;
            this.ParamDGV.SelectionChanged += new System.EventHandler(this.ParamDGV_SelectionChanged);
            // 
            // paramname
            // 
            this.paramname.HeaderText = "Param Name";
            this.paramname.Name = "paramname";
            this.paramname.ReadOnly = true;
            // 
            // paramtype
            // 
            this.paramtype.HeaderText = "Param Type";
            this.paramtype.Name = "paramtype";
            this.paramtype.ReadOnly = true;
            // 
            // CellDGV
            // 
            this.CellDGV.AllowUserToAddRows = false;
            this.CellDGV.AllowUserToDeleteRows = false;
            this.CellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CellDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.CellDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.NullValue = "null";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CellDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.celltype,
            this.cellname,
            this.cellvalue});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.NullValue = "null";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CellDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.CellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellDGV.EnableHeadersVisualStyles = false;
            this.CellDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.CellDGV.Location = new System.Drawing.Point(0, 0);
            this.CellDGV.Name = "CellDGV";
            this.CellDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CellDGV.Size = new System.Drawing.Size(370, 605);
            this.CellDGV.TabIndex = 2;
            this.CellDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDGV_CellValueChanged);
            // 
            // celltype
            // 
            this.celltype.HeaderText = "Cell Type";
            this.celltype.Name = "celltype";
            this.celltype.ReadOnly = true;
            // 
            // cellname
            // 
            this.cellname.HeaderText = "Cell Name";
            this.cellname.Name = "cellname";
            this.cellname.ReadOnly = true;
            // 
            // cellvalue
            // 
            this.cellvalue.HeaderText = "Cell Value";
            this.cellvalue.Name = "cellvalue";
            // 
            // SplitContainerA
            // 
            this.SplitContainerA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerA.ForeColor = System.Drawing.SystemColors.Control;
            this.SplitContainerA.Location = new System.Drawing.Point(0, 24);
            this.SplitContainerA.Name = "SplitContainerA";
            // 
            // SplitContainerA.Panel1
            // 
            this.SplitContainerA.Panel1.Controls.Add(this.ParamDGV);
            this.SplitContainerA.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // SplitContainerA.Panel2
            // 
            this.SplitContainerA.Panel2.Controls.Add(this.SplitContainerB);
            this.SplitContainerA.Panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.SplitContainerA.Size = new System.Drawing.Size(1118, 605);
            this.SplitContainerA.SplitterDistance = 370;
            this.SplitContainerA.TabIndex = 4;
            // 
            // SplitContainerB
            // 
            this.SplitContainerB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerB.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerB.Name = "SplitContainerB";
            // 
            // SplitContainerB.Panel1
            // 
            this.SplitContainerB.Panel1.Controls.Add(this.RowDGV);
            this.SplitContainerB.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // SplitContainerB.Panel2
            // 
            this.SplitContainerB.Panel2.Controls.Add(this.CellDGV);
            this.SplitContainerB.Size = new System.Drawing.Size(744, 605);
            this.SplitContainerB.SplitterDistance = 370;
            this.SplitContainerB.TabIndex = 1;
            // 
            // ReaderStatusStrip
            // 
            this.ReaderStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ReaderStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLParamReading,
            this.TSSLRowReading,
            this.TSSLCellReading,
            this.TSSLDefReading});
            this.ReaderStatusStrip.Location = new System.Drawing.Point(0, 629);
            this.ReaderStatusStrip.Name = "ReaderStatusStrip";
            this.ReaderStatusStrip.Size = new System.Drawing.Size(1118, 22);
            this.ReaderStatusStrip.TabIndex = 1;
            // 
            // TSSLParamReading
            // 
            this.TSSLParamReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLParamReading.Name = "TSSLParamReading";
            this.TSSLParamReading.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSLRowReading
            // 
            this.TSSLRowReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLRowReading.Name = "TSSLRowReading";
            this.TSSLRowReading.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSLCellReading
            // 
            this.TSSLCellReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLCellReading.Name = "TSSLCellReading";
            this.TSSLCellReading.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSLDefReading
            // 
            this.TSSLDefReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLDefReading.Name = "TSSLDefReading";
            this.TSSLDefReading.Size = new System.Drawing.Size(0, 17);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMS,
            this.RowMS,
            this.HelpMS});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1118, 24);
            this.MainFormMenuStrip.TabIndex = 1;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // FileMS
            // 
            this.FileMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FileMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FileMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenParamsFMS,
            this.SaveFMS,
            this.FileSaveSeparatorMS,
            this.ExportFMS});
            this.FileMS.ForeColor = System.Drawing.SystemColors.Control;
            this.FileMS.Name = "FileMS";
            this.FileMS.Size = new System.Drawing.Size(37, 20);
            this.FileMS.Text = "File";
            // 
            // OpenParamsFMS
            // 
            this.OpenParamsFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.OpenParamsFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenParamsFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenParamsFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenParamsFMS.Name = "OpenParamsFMS";
            this.OpenParamsFMS.Size = new System.Drawing.Size(145, 22);
            this.OpenParamsFMS.Text = "Open Params";
            this.OpenParamsFMS.Click += new System.EventHandler(this.OpenParamsFMS_click);
            // 
            // SaveFMS
            // 
            this.SaveFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SaveFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveFMS.Name = "SaveFMS";
            this.SaveFMS.Size = new System.Drawing.Size(145, 22);
            this.SaveFMS.Text = "Save";
            this.SaveFMS.Click += new System.EventHandler(this.SaveFMS_Click);
            // 
            // FileSaveSeparatorMS
            // 
            this.FileSaveSeparatorMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.FileSaveSeparatorMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.FileSaveSeparatorMS.Name = "FileSaveSeparatorMS";
            this.FileSaveSeparatorMS.Size = new System.Drawing.Size(142, 6);
            // 
            // ExportFMS
            // 
            this.ExportFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExportFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExportFMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertDefXmlEFMS,
            this.ConvertParamCsvEFMS,
            this.ConvertCsvParamEFMS,
            this.ConvertParamTsvEFMS,
            this.ConvertTsvParamEFMS});
            this.ExportFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ExportFMS.Name = "ExportFMS";
            this.ExportFMS.Size = new System.Drawing.Size(145, 22);
            this.ExportFMS.Text = "Export";
            // 
            // ConvertDefXmlEFMS
            // 
            this.ConvertDefXmlEFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertDefXmlEFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertDefXmlEFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertDefXmlEFMS.Name = "ConvertDefXmlEFMS";
            this.ConvertDefXmlEFMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertDefXmlEFMS.Text = "Convert Defs to Xml Defs";
            this.ConvertDefXmlEFMS.Click += new System.EventHandler(this.ConvertDefXmlEFMS_Click);
            // 
            // ConvertParamCsvEFMS
            // 
            this.ConvertParamCsvEFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertParamCsvEFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertParamCsvEFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertParamCsvEFMS.Name = "ConvertParamCsvEFMS";
            this.ConvertParamCsvEFMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertParamCsvEFMS.Text = "Convert Params to CSV";
            this.ConvertParamCsvEFMS.Click += new System.EventHandler(this.ConvertParamCsvEFMS_Click);
            // 
            // ConvertCsvParamEFMS
            // 
            this.ConvertCsvParamEFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertCsvParamEFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertCsvParamEFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertCsvParamEFMS.Name = "ConvertCsvParamEFMS";
            this.ConvertCsvParamEFMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertCsvParamEFMS.Text = "Convert CSV to Params";
            this.ConvertCsvParamEFMS.Click += new System.EventHandler(this.ConvertCsvParamEFMS_Click);
            // 
            // ConvertParamTsvEFMS
            // 
            this.ConvertParamTsvEFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertParamTsvEFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertParamTsvEFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertParamTsvEFMS.Name = "ConvertParamTsvEFMS";
            this.ConvertParamTsvEFMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertParamTsvEFMS.Text = "Convert Params to TSV";
            this.ConvertParamTsvEFMS.Click += new System.EventHandler(this.ConvertParamTsvEFMS_Click);
            // 
            // ConvertTsvParamEFMS
            // 
            this.ConvertTsvParamEFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertTsvParamEFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertTsvParamEFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertTsvParamEFMS.Name = "ConvertTsvParamEFMS";
            this.ConvertTsvParamEFMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertTsvParamEFMS.Text = "Convert TSV to Params";
            this.ConvertTsvParamEFMS.Click += new System.EventHandler(this.ConvertTsvParamEFMS_Click);
            // 
            // RowMS
            // 
            this.RowMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RowMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RowMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyRowRMS,
            this.DeleteRowRMS});
            this.RowMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RowMS.Name = "RowMS";
            this.RowMS.Size = new System.Drawing.Size(47, 20);
            this.RowMS.Text = "Rows";
            // 
            // CopyRowRMS
            // 
            this.CopyRowRMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.CopyRowRMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CopyRowRMS.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyRowRMS.Name = "CopyRowRMS";
            this.CopyRowRMS.Size = new System.Drawing.Size(133, 22);
            this.CopyRowRMS.Text = "Copy Row";
            this.CopyRowRMS.Click += new System.EventHandler(this.CopyRowRMS_Click);
            // 
            // DeleteRowRMS
            // 
            this.DeleteRowRMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DeleteRowRMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteRowRMS.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteRowRMS.Name = "DeleteRowRMS";
            this.DeleteRowRMS.Size = new System.Drawing.Size(133, 22);
            this.DeleteRowRMS.Text = "Delete Row";
            this.DeleteRowRMS.Click += new System.EventHandler(this.DeleteRowRMS_Click);
            // 
            // HelpMS
            // 
            this.HelpMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.HelpMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HelpMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutHMS});
            this.HelpMS.ForeColor = System.Drawing.SystemColors.Control;
            this.HelpMS.Name = "HelpMS";
            this.HelpMS.Size = new System.Drawing.Size(44, 20);
            this.HelpMS.Text = "Help";
            // 
            // AboutHMS
            // 
            this.AboutHMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.AboutHMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutHMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutHMS.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutHMS.Name = "AboutHMS";
            this.AboutHMS.Size = new System.Drawing.Size(107, 22);
            this.AboutHMS.Text = "About";
            this.AboutHMS.Click += new System.EventHandler(this.AboutHMS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1118, 651);
            this.Controls.Add(this.SplitContainerA);
            this.Controls.Add(this.ReaderStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Armored Core For Answer Param Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).EndInit();
            this.SplitContainerA.Panel1.ResumeLayout(false);
            this.SplitContainerA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerA)).EndInit();
            this.SplitContainerA.ResumeLayout(false);
            this.SplitContainerB.Panel1.ResumeLayout(false);
            this.SplitContainerB.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerB)).EndInit();
            this.SplitContainerB.ResumeLayout(false);
            this.ReaderStatusStrip.ResumeLayout(false);
            this.ReaderStatusStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CellDGV;
        private System.Windows.Forms.DataGridView RowDGV;
        private System.Windows.Forms.DataGridView ParamDGV;
        private System.Windows.Forms.SplitContainer SplitContainerA;
        private System.Windows.Forms.SplitContainer SplitContainerB;
        private System.Windows.Forms.StatusStrip ReaderStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TSSLParamReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLRowReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLCellReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLDefReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramname;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn celltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowname;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMS;
        private System.Windows.Forms.ToolStripMenuItem OpenParamsFMS;
        private System.Windows.Forms.ToolStripMenuItem SaveFMS;
        private System.Windows.Forms.ToolStripMenuItem RowMS;
        private System.Windows.Forms.ToolStripMenuItem DeleteRowRMS;
        private System.Windows.Forms.ToolStripMenuItem HelpMS;
        private System.Windows.Forms.ToolStripMenuItem AboutHMS;
        private System.Windows.Forms.ToolStripMenuItem CopyRowRMS;
        private System.Windows.Forms.ToolStripMenuItem ExportFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertDefXmlEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertParamCsvEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertCsvParamEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertParamTsvEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertTsvParamEFMS;
        private System.Windows.Forms.ToolStripSeparator FileSaveSeparatorMS;
    }
}

