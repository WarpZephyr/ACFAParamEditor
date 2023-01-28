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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditParamsBtn = new System.Windows.Forms.Button();
            this.ConvertDefsBtn = new System.Windows.Forms.Button();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.ConvertParamsTSVBtn = new System.Windows.Forms.Button();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.SplitContainerA = new System.Windows.Forms.SplitContainer();
            this.SplitContainerB = new System.Windows.Forms.SplitContainer();
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.NullValue = "Null";
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.RowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.NullValue = "Null";
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RowDGV.DefaultCellStyle = dataGridViewCellStyle20;
            this.RowDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowDGV.Location = new System.Drawing.Point(0, 0);
            this.RowDGV.Name = "RowDGV";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.RowDGV.Size = new System.Drawing.Size(370, 606);
            this.RowDGV.TabIndex = 1;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.NullValue = "Null";
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.ParamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.NullValue = "Null";
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParamDGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.ParamDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamDGV.Location = new System.Drawing.Point(0, 0);
            this.ParamDGV.Name = "ParamDGV";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.ParamDGV.Size = new System.Drawing.Size(370, 606);
            this.ParamDGV.TabIndex = 0;
            this.ParamDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParamDGV_CellDoubleClick);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.NullValue = "Null";
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.CellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.NullValue = "Null";
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CellDGV.DefaultCellStyle = dataGridViewCellStyle26;
            this.CellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellDGV.Location = new System.Drawing.Point(0, 0);
            this.CellDGV.Name = "CellDGV";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.CellDGV.Size = new System.Drawing.Size(370, 606);
            this.CellDGV.TabIndex = 2;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1118, 651);
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
            this.ResumeLayout(false);

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
    }
}

