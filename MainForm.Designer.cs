namespace ArmoredCorePDR
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
            this.EditParamsBtn = new System.Windows.Forms.Button();
            this.ConvertDefsBtn = new System.Windows.Forms.Button();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.RowSelectorPanel = new System.Windows.Forms.Panel();
            this.ParamSelectorPanel = new System.Windows.Forms.Panel();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.CellEditorPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.ParamSelectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).BeginInit();
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
            this.TopBarPanel.Size = new System.Drawing.Size(711, 45);
            this.TopBarPanel.TabIndex = 3;
            // 
            // RowSelectorPanel
            // 
            this.RowSelectorPanel.Location = new System.Drawing.Point(237, 44);
            this.RowSelectorPanel.Name = "RowSelectorPanel";
            this.RowSelectorPanel.Size = new System.Drawing.Size(237, 406);
            this.RowSelectorPanel.TabIndex = 5;
            // 
            // ParamSelectorPanel
            // 
            this.ParamSelectorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ParamSelectorPanel.Controls.Add(this.ParamDGV);
            this.ParamSelectorPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ParamSelectorPanel.Location = new System.Drawing.Point(0, 44);
            this.ParamSelectorPanel.Name = "ParamSelectorPanel";
            this.ParamSelectorPanel.Size = new System.Drawing.Size(237, 406);
            this.ParamSelectorPanel.TabIndex = 4;
            // 
            // ParamDGV
            // 
            this.ParamDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ParamDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDGV.Location = new System.Drawing.Point(0, 55);
            this.ParamDGV.Name = "ParamDGV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = "Null - You shouldn\'t be able to see this";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ParamDGV.Size = new System.Drawing.Size(237, 351);
            this.ParamDGV.TabIndex = 0;
            // 
            // CellEditorPanel
            // 
            this.CellEditorPanel.Location = new System.Drawing.Point(474, 44);
            this.CellEditorPanel.Name = "CellEditorPanel";
            this.CellEditorPanel.Size = new System.Drawing.Size(237, 406);
            this.CellEditorPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.CellEditorPanel);
            this.Controls.Add(this.RowSelectorPanel);
            this.Controls.Add(this.ParamSelectorPanel);
            this.Controls.Add(this.TopBarPanel);
            this.Name = "MainForm";
            this.Text = "Armored Core For Answer Param Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.ParamSelectorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditParamsBtn;
        private System.Windows.Forms.Button ConvertDefsBtn;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel ParamSelectorPanel;
        private System.Windows.Forms.Panel RowSelectorPanel;
        private System.Windows.Forms.Panel CellEditorPanel;
        private System.Windows.Forms.DataGridView ParamDGV;
    }
}

