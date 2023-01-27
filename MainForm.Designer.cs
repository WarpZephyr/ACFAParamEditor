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
            this.RowSelectorPanel = new System.Windows.Forms.Panel();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.ParamSelectorPanel = new System.Windows.Forms.Panel();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.CellEditorPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
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
            this.RowDGV.Size = new System.Drawing.Size(370, 607);
            this.RowDGV.TabIndex = 1;
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
    }
}

