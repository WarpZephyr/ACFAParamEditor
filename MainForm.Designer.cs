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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditParamsBtn = new System.Windows.Forms.Button();
            this.ConvertDefsBtn = new System.Windows.Forms.Button();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.ConvertParamsTSVBtn = new System.Windows.Forms.Button();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.SplitContainerA = new System.Windows.Forms.SplitContainer();
            this.SplitContainerB = new System.Windows.Forms.SplitContainer();
            this.ReaderStatusStrip = new System.Windows.Forms.StatusStrip();
            this.TSSLParamReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLRowReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLCellReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopBarPanel.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // EditParamsBtn
            // 
            this.EditParamsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.EditParamsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.EditParamsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditParamsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EditParamsBtn.Location = new System.Drawing.Point(13, 13);
            this.EditParamsBtn.Name = "EditParamsBtn";
            this.EditParamsBtn.Size = new System.Drawing.Size(75, 23);
            this.EditParamsBtn.TabIndex = 0;
            this.EditParamsBtn.Text = "Edit Params";
            this.EditParamsBtn.UseVisualStyleBackColor = false;
            this.EditParamsBtn.Click += new System.EventHandler(this.EditParamsBtn_click);
            // 
            // ConvertDefsBtn
            // 
            this.ConvertDefsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConvertDefsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ConvertDefsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertDefsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertDefsBtn.Location = new System.Drawing.Point(94, 13);
            this.ConvertDefsBtn.Name = "ConvertDefsBtn";
            this.ConvertDefsBtn.Size = new System.Drawing.Size(90, 23);
            this.ConvertDefsBtn.TabIndex = 2;
            this.ConvertDefsBtn.Text = "Convert Defs";
            this.ConvertDefsBtn.UseVisualStyleBackColor = false;
            this.ConvertDefsBtn.Click += new System.EventHandler(this.ConvertDefsBtn_Click);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TopBarPanel.Controls.Add(this.ConvertParamsTSVBtn);
            this.TopBarPanel.Controls.Add(this.ConvertDefsBtn);
            this.TopBarPanel.Controls.Add(this.EditParamsBtn);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1118, 45);
            this.TopBarPanel.TabIndex = 3;
            // 
            // ConvertParamsTSVBtn
            // 
            this.ConvertParamsTSVBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConvertParamsTSVBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ConvertParamsTSVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertParamsTSVBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertParamsTSVBtn.Location = new System.Drawing.Point(190, 13);
            this.ConvertParamsTSVBtn.Name = "ConvertParamsTSVBtn";
            this.ConvertParamsTSVBtn.Size = new System.Drawing.Size(134, 23);
            this.ConvertParamsTSVBtn.TabIndex = 3;
            this.ConvertParamsTSVBtn.Text = "Convert Params to TSV";
            this.ConvertParamsTSVBtn.UseVisualStyleBackColor = false;
            this.ConvertParamsTSVBtn.Click += new System.EventHandler(this.ConvertParamsTSVBtn_Click);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.NullValue = "Null";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.RowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.NullValue = "Null";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RowDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.RowDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowDGV.Location = new System.Drawing.Point(0, 0);
            this.RowDGV.Name = "RowDGV";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.RowDGV.Size = new System.Drawing.Size(370, 606);
            this.RowDGV.TabIndex = 1;
            this.RowDGV.SelectionChanged += new System.EventHandler(this.RowDGV_SelectionChanged);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.NullValue = "Null";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.ParamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.NullValue = "Null";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParamDGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.ParamDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamDGV.Location = new System.Drawing.Point(0, 0);
            this.ParamDGV.Name = "ParamDGV";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.ParamDGV.Size = new System.Drawing.Size(370, 606);
            this.ParamDGV.TabIndex = 0;
            this.ParamDGV.SelectionChanged += new System.EventHandler(this.ParamDGV_SelectionChanged);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.NullValue = "Null";
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.CellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.NullValue = "Null";
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CellDGV.DefaultCellStyle = dataGridViewCellStyle17;
            this.CellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellDGV.Location = new System.Drawing.Point(0, 0);
            this.CellDGV.Name = "CellDGV";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.CellDGV.Size = new System.Drawing.Size(370, 606);
            this.CellDGV.TabIndex = 2;
            this.CellDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDGV_CellValueChanged);
            // 
            // SplitContainerA
            // 
            this.SplitContainerA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerA.ForeColor = System.Drawing.SystemColors.Control;
            this.SplitContainerA.Location = new System.Drawing.Point(0, 45);
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
            this.SplitContainerA.Size = new System.Drawing.Size(1118, 606);
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
            this.SplitContainerB.Size = new System.Drawing.Size(744, 606);
            this.SplitContainerB.SplitterDistance = 370;
            this.SplitContainerB.TabIndex = 1;
            // 
            // ReaderStatusStrip
            // 
            this.ReaderStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ReaderStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLParamReading,
            this.TSSLRowReading,
            this.TSSLCellReading});
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1118, 651);
            this.Controls.Add(this.ReaderStatusStrip);
            this.Controls.Add(this.SplitContainerA);
            this.Controls.Add(this.TopBarPanel);
            this.Name = "MainForm";
            this.Text = "Armored Core For Answer Param Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopBarPanel.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditParamsBtn;
        private System.Windows.Forms.Button ConvertDefsBtn;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.DataGridView CellDGV;
        private System.Windows.Forms.DataGridView RowDGV;
        private System.Windows.Forms.DataGridView ParamDGV;
        private System.Windows.Forms.Button ConvertParamsTSVBtn;
        private System.Windows.Forms.SplitContainer SplitContainerA;
        private System.Windows.Forms.SplitContainer SplitContainerB;
        private System.Windows.Forms.StatusStrip ReaderStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TSSLParamReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLRowReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLCellReading;
    }
}

