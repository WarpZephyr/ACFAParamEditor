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
            this.RowSelectorPanel = new System.Windows.Forms.Panel();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ParamSelectorPanel = new System.Windows.Forms.Panel();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.CellEditorPanel = new System.Windows.Forms.Panel();
            this.ConvertParamsTSVBtn = new System.Windows.Forms.Button();
            this.TopBarPanel.SuspendLayout();
            this.RowSelectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).BeginInit();
            this.ParamSelectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).BeginInit();
            this.CellEditorPanel.SuspendLayout();
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
            this.TopBarPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopBarPanel.Location = new System.Drawing.Point(0, -1);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1110, 45);
            this.TopBarPanel.TabIndex = 3;
            // 
            // RowSelectorPanel
            // 
            this.RowSelectorPanel.Controls.Add(this.RowDGV);
            this.RowSelectorPanel.Controls.Add(this.menuStrip1);
            this.RowSelectorPanel.Location = new System.Drawing.Point(370, 44);
            this.RowSelectorPanel.Name = "RowSelectorPanel";
            this.RowSelectorPanel.Size = new System.Drawing.Size(370, 607);
            this.RowSelectorPanel.TabIndex = 5;
            // 
            // RowDGV
            // 
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
            this.RowDGV.Size = new System.Drawing.Size(370, 607);
            this.RowDGV.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ParamSelectorPanel
            // 
            this.ParamSelectorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ParamSelectorPanel.Controls.Add(this.ParamDGV);
            this.ParamSelectorPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ParamSelectorPanel.Location = new System.Drawing.Point(0, 44);
            this.ParamSelectorPanel.Name = "ParamSelectorPanel";
            this.ParamSelectorPanel.Size = new System.Drawing.Size(370, 607);
            this.ParamSelectorPanel.TabIndex = 4;
            // 
            // ParamDGV
            // 
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
            this.ParamDGV.Size = new System.Drawing.Size(370, 607);
            this.ParamDGV.TabIndex = 2;
            this.ParamDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParamDGV_CellDoubleClick);
            // 
            // CellDGV
            // 
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
            this.CellDGV.Size = new System.Drawing.Size(370, 607);
            this.CellDGV.TabIndex = 0;
            // 
            // CellEditorPanel
            // 
            this.CellEditorPanel.Controls.Add(this.CellDGV);
            this.CellEditorPanel.Location = new System.Drawing.Point(740, 44);
            this.CellEditorPanel.Name = "CellEditorPanel";
            this.CellEditorPanel.Size = new System.Drawing.Size(370, 607);
            this.CellEditorPanel.TabIndex = 6;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1110, 651);
            this.Controls.Add(this.CellEditorPanel);
            this.Controls.Add(this.RowSelectorPanel);
            this.Controls.Add(this.ParamSelectorPanel);
            this.Controls.Add(this.TopBarPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Armored Core For Answer Param Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.RowSelectorPanel.ResumeLayout(false);
            this.RowSelectorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).EndInit();
            this.ParamSelectorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).EndInit();
            this.CellEditorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditParamsBtn;
        private System.Windows.Forms.Button ConvertDefsBtn;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel ParamSelectorPanel;
        private System.Windows.Forms.Panel RowSelectorPanel;
        private System.Windows.Forms.Panel CellEditorPanel;
        private System.Windows.Forms.DataGridView CellDGV;
        private System.Windows.Forms.DataGridView RowDGV;
        private System.Windows.Forms.DataGridView ParamDGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button ConvertParamsTSVBtn;
    }
}

