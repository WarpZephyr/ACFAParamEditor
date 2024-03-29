﻿using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RowDGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyRowRowConMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteRowRowConMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRowRowConMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamDGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenParamsParamConMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveParamParamConMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReaderStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainFormStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenParamsFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveParamFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearParamFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveSeparatorMS = new System.Windows.Forms.ToolStripSeparator();
            this.ExportFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertDefXmlEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertParamCsvEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertCsvParamEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertParamTsvEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertTsvParamEFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMS = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateRowEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRowEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteRowEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRowEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMS = new System.Windows.Forms.ToolStripMenuItem();
            this.VerifySaveFileOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.VerifyParamRemovalOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.VerifyDeleteRowOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RecurseOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupParamOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveEmptyParamOMS = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMS = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutHMS = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainerA = new System.Windows.Forms.SplitContainer();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.paramname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainerB = new System.Windows.Forms.SplitContainer();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.celltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowDGVContextMenu.SuspendLayout();
            this.ParamDGVContextMenu.SuspendLayout();
            this.ReaderStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerA)).BeginInit();
            this.SplitContainerA.Panel1.SuspendLayout();
            this.SplitContainerA.Panel2.SuspendLayout();
            this.SplitContainerA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerB)).BeginInit();
            this.SplitContainerB.Panel1.SuspendLayout();
            this.SplitContainerB.Panel2.SuspendLayout();
            this.SplitContainerB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RowDGVContextMenu
            // 
            this.RowDGVContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.RowDGVContextMenu.DropShadowEnabled = false;
            this.RowDGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyRowRowConMenu,
            this.PasteRowRowConMenu,
            this.DeleteRowRowConMenu});
            this.RowDGVContextMenu.Name = "RowDGVContextMenu";
            this.RowDGVContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.RowDGVContextMenu.Size = new System.Drawing.Size(134, 70);
            // 
            // CopyRowRowConMenu
            // 
            this.CopyRowRowConMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyRowRowConMenu.Name = "CopyRowRowConMenu";
            this.CopyRowRowConMenu.Size = new System.Drawing.Size(133, 22);
            this.CopyRowRowConMenu.Text = "Clone Row";
            this.CopyRowRowConMenu.Click += new System.EventHandler(this.CopyRowEMS_Click);
            // 
            // PasteRowRowConMenu
            // 
            this.PasteRowRowConMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.PasteRowRowConMenu.Name = "PasteRowRowConMenu";
            this.PasteRowRowConMenu.Size = new System.Drawing.Size(133, 22);
            this.PasteRowRowConMenu.Text = "Paste Row";
            this.PasteRowRowConMenu.Click += new System.EventHandler(this.PasteRowEMS_Click);
            // 
            // DeleteRowRowConMenu
            // 
            this.DeleteRowRowConMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteRowRowConMenu.Name = "DeleteRowRowConMenu";
            this.DeleteRowRowConMenu.Size = new System.Drawing.Size(133, 22);
            this.DeleteRowRowConMenu.Text = "Delete Row";
            this.DeleteRowRowConMenu.Click += new System.EventHandler(this.DeleteRowEMS_Click);
            // 
            // ParamDGVContextMenu
            // 
            this.ParamDGVContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ParamDGVContextMenu.DropShadowEnabled = false;
            this.ParamDGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenParamsParamConMenu,
            this.RemoveParamParamConMenu});
            this.ParamDGVContextMenu.Name = "RowDGVContextMenu";
            this.ParamDGVContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ParamDGVContextMenu.Size = new System.Drawing.Size(155, 48);
            // 
            // OpenParamsParamConMenu
            // 
            this.OpenParamsParamConMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenParamsParamConMenu.Name = "OpenParamsParamConMenu";
            this.OpenParamsParamConMenu.Size = new System.Drawing.Size(154, 22);
            this.OpenParamsParamConMenu.Text = "Open Params";
            this.OpenParamsParamConMenu.Click += new System.EventHandler(this.OpenParamsFMS_click);
            // 
            // RemoveParamParamConMenu
            // 
            this.RemoveParamParamConMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveParamParamConMenu.Name = "RemoveParamParamConMenu";
            this.RemoveParamParamConMenu.Size = new System.Drawing.Size(154, 22);
            this.RemoveParamParamConMenu.Text = "Remove Param";
            this.RemoveParamParamConMenu.Click += new System.EventHandler(this.RemoveParamFMS_Click);
            // 
            // ReaderStatusStrip
            // 
            this.ReaderStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ReaderStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormStatus,
            this.CountLabel});
            this.ReaderStatusStrip.Location = new System.Drawing.Point(0, 629);
            this.ReaderStatusStrip.Name = "ReaderStatusStrip";
            this.ReaderStatusStrip.Size = new System.Drawing.Size(1118, 22);
            this.ReaderStatusStrip.TabIndex = 1;
            // 
            // MainFormStatus
            // 
            this.MainFormStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.MainFormStatus.Name = "MainFormStatus";
            this.MainFormStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMS,
            this.EditMS,
            this.OptionsMS,
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
            this.RemoveParamFMS,
            this.ClearParamFMS,
            this.SaveFMS,
            this.SaveAllFMS,
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
            this.OpenParamsFMS.Size = new System.Drawing.Size(154, 22);
            this.OpenParamsFMS.Text = "Open Params";
            this.OpenParamsFMS.ToolTipText = "Adds all found params in a folder";
            this.OpenParamsFMS.Click += new System.EventHandler(this.OpenParamsFMS_click);
            // 
            // RemoveParamFMS
            // 
            this.RemoveParamFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.RemoveParamFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveParamFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveParamFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveParamFMS.Name = "RemoveParamFMS";
            this.RemoveParamFMS.Size = new System.Drawing.Size(154, 22);
            this.RemoveParamFMS.Text = "Remove Param";
            this.RemoveParamFMS.ToolTipText = "Removes the currently selected param";
            this.RemoveParamFMS.Click += new System.EventHandler(this.RemoveParamFMS_Click);
            // 
            // ClearParamFMS
            // 
            this.ClearParamFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClearParamFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearParamFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearParamFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearParamFMS.Name = "ClearParamFMS";
            this.ClearParamFMS.Size = new System.Drawing.Size(154, 22);
            this.ClearParamFMS.Text = "Clear Params";
            this.ClearParamFMS.ToolTipText = "Unloads all params without saving";
            this.ClearParamFMS.Click += new System.EventHandler(this.ClearParamFMS_Click);
            // 
            // SaveFMS
            // 
            this.SaveFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SaveFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveFMS.Name = "SaveFMS";
            this.SaveFMS.Size = new System.Drawing.Size(154, 22);
            this.SaveFMS.Text = "Save";
            this.SaveFMS.ToolTipText = "Saves the currently selected param back to the original file";
            this.SaveFMS.Click += new System.EventHandler(this.SaveFMS_Click);
            // 
            // SaveAllFMS
            // 
            this.SaveAllFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SaveAllFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveAllFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveAllFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveAllFMS.Name = "SaveAllFMS";
            this.SaveAllFMS.Size = new System.Drawing.Size(154, 22);
            this.SaveAllFMS.Text = "Save All";
            this.SaveAllFMS.ToolTipText = "Saves all loaded params back to the original files";
            this.SaveAllFMS.Click += new System.EventHandler(this.SaveAllFMS_Click);
            // 
            // FileSaveSeparatorMS
            // 
            this.FileSaveSeparatorMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.FileSaveSeparatorMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.FileSaveSeparatorMS.Name = "FileSaveSeparatorMS";
            this.FileSaveSeparatorMS.Size = new System.Drawing.Size(151, 6);
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
            this.ExportFMS.Size = new System.Drawing.Size(154, 22);
            this.ExportFMS.Text = "Export";
            this.ExportFMS.ToolTipText = "Export files to different types";
            // 
            // ConvertDefXmlEFMS
            // 
            this.ConvertDefXmlEFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertDefXmlEFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertDefXmlEFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertDefXmlEFMS.Name = "ConvertDefXmlEFMS";
            this.ConvertDefXmlEFMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertDefXmlEFMS.Text = "Convert Defs to Xml Defs";
            this.ConvertDefXmlEFMS.ToolTipText = "Converts def to readable Xml, currently a bit broken";
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
            this.ConvertParamCsvEFMS.ToolTipText = "Not Implemented";
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
            this.ConvertCsvParamEFMS.ToolTipText = "Not Implemented";
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
            this.ConvertParamTsvEFMS.ToolTipText = "Not Implemented";
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
            this.ConvertTsvParamEFMS.ToolTipText = "Not Implemented";
            this.ConvertTsvParamEFMS.Click += new System.EventHandler(this.ConvertTsvParamEFMS_Click);
            // 
            // EditMS
            // 
            this.EditMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoEMS,
            this.RedoEMS,
            this.DuplicateRowEMS,
            this.CopyRowEMS,
            this.PasteRowEMS,
            this.DeleteRowEMS});
            this.EditMS.ForeColor = System.Drawing.SystemColors.Control;
            this.EditMS.Name = "EditMS";
            this.EditMS.Size = new System.Drawing.Size(39, 20);
            this.EditMS.Text = "Edit";
            // 
            // UndoEMS
            // 
            this.UndoEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.UndoEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UndoEMS.Enabled = false;
            this.UndoEMS.ForeColor = System.Drawing.SystemColors.Control;
            this.UndoEMS.Name = "UndoEMS";
            this.UndoEMS.Size = new System.Drawing.Size(150, 22);
            this.UndoEMS.Text = "Undo";
            this.UndoEMS.Click += new System.EventHandler(this.UndoEMS_Click);
            // 
            // RedoEMS
            // 
            this.RedoEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.RedoEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RedoEMS.Enabled = false;
            this.RedoEMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RedoEMS.Name = "RedoEMS";
            this.RedoEMS.Size = new System.Drawing.Size(150, 22);
            this.RedoEMS.Text = "Redo";
            this.RedoEMS.Click += new System.EventHandler(this.RedoEMS_Click);
            // 
            // DuplicateRowEMS
            // 
            this.DuplicateRowEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DuplicateRowEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DuplicateRowEMS.ForeColor = System.Drawing.SystemColors.Control;
            this.DuplicateRowEMS.Name = "DuplicateRowEMS";
            this.DuplicateRowEMS.Size = new System.Drawing.Size(150, 22);
            this.DuplicateRowEMS.Text = "Duplicate Row";
            this.DuplicateRowEMS.Click += new System.EventHandler(this.DuplicateRowEMS_Click);
            // 
            // CopyRowEMS
            // 
            this.CopyRowEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.CopyRowEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CopyRowEMS.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyRowEMS.Name = "CopyRowEMS";
            this.CopyRowEMS.Size = new System.Drawing.Size(150, 22);
            this.CopyRowEMS.Text = "Clone Row";
            this.CopyRowEMS.Click += new System.EventHandler(this.CopyRowEMS_Click);
            // 
            // PasteRowEMS
            // 
            this.PasteRowEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PasteRowEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasteRowEMS.ForeColor = System.Drawing.SystemColors.Control;
            this.PasteRowEMS.Name = "PasteRowEMS";
            this.PasteRowEMS.Size = new System.Drawing.Size(150, 22);
            this.PasteRowEMS.Text = "Paste Row";
            this.PasteRowEMS.Click += new System.EventHandler(this.PasteRowEMS_Click);
            // 
            // DeleteRowEMS
            // 
            this.DeleteRowEMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DeleteRowEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteRowEMS.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteRowEMS.Name = "DeleteRowEMS";
            this.DeleteRowEMS.Size = new System.Drawing.Size(150, 22);
            this.DeleteRowEMS.Text = "Delete Row";
            this.DeleteRowEMS.Click += new System.EventHandler(this.DeleteRowEMS_Click);
            // 
            // OptionsMS
            // 
            this.OptionsMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.OptionsMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OptionsMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerifySaveFileOMS,
            this.VerifyParamRemovalOMS,
            this.VerifyDeleteRowOMS,
            this.RecurseOMS,
            this.BackupParamOMS,
            this.RemoveEmptyParamOMS});
            this.OptionsMS.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionsMS.Name = "OptionsMS";
            this.OptionsMS.Size = new System.Drawing.Size(61, 20);
            this.OptionsMS.Text = "Options";
            // 
            // VerifySaveFileOMS
            // 
            this.VerifySaveFileOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.VerifySaveFileOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VerifySaveFileOMS.Checked = true;
            this.VerifySaveFileOMS.CheckOnClick = true;
            this.VerifySaveFileOMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VerifySaveFileOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VerifySaveFileOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.VerifySaveFileOMS.Name = "VerifySaveFileOMS";
            this.VerifySaveFileOMS.Size = new System.Drawing.Size(191, 22);
            this.VerifySaveFileOMS.Text = "Verify Saving";
            this.VerifySaveFileOMS.ToolTipText = "Ask you before saving params if checked";
            // 
            // VerifyParamRemovalOMS
            // 
            this.VerifyParamRemovalOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.VerifyParamRemovalOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VerifyParamRemovalOMS.Checked = true;
            this.VerifyParamRemovalOMS.CheckOnClick = true;
            this.VerifyParamRemovalOMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VerifyParamRemovalOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VerifyParamRemovalOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.VerifyParamRemovalOMS.Name = "VerifyParamRemovalOMS";
            this.VerifyParamRemovalOMS.Size = new System.Drawing.Size(191, 22);
            this.VerifyParamRemovalOMS.Text = "Verify Param Removal";
            this.VerifyParamRemovalOMS.ToolTipText = "Ask you before removing params if checked";
            // 
            // VerifyDeleteRowOMS
            // 
            this.VerifyDeleteRowOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.VerifyDeleteRowOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VerifyDeleteRowOMS.Checked = true;
            this.VerifyDeleteRowOMS.CheckOnClick = true;
            this.VerifyDeleteRowOMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VerifyDeleteRowOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VerifyDeleteRowOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.VerifyDeleteRowOMS.Name = "VerifyDeleteRowOMS";
            this.VerifyDeleteRowOMS.Size = new System.Drawing.Size(191, 22);
            this.VerifyDeleteRowOMS.Text = "Verify Row Deletion";
            this.VerifyDeleteRowOMS.ToolTipText = "Ask you before deleting rows if checked";
            // 
            // RecurseOMS
            // 
            this.RecurseOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.RecurseOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RecurseOMS.Checked = true;
            this.RecurseOMS.CheckOnClick = true;
            this.RecurseOMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecurseOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RecurseOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RecurseOMS.Name = "RecurseOMS";
            this.RecurseOMS.Size = new System.Drawing.Size(191, 22);
            this.RecurseOMS.Text = "Use Recursion";
            this.RecurseOMS.ToolTipText = "Use recursion to find all params in nested BND files, keep this checked if you do" +
    " not know what you are doing.";
            // 
            // BackupParamOMS
            // 
            this.BackupParamOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BackupParamOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackupParamOMS.Checked = true;
            this.BackupParamOMS.CheckOnClick = true;
            this.BackupParamOMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackupParamOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackupParamOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.BackupParamOMS.Name = "BackupParamOMS";
            this.BackupParamOMS.Size = new System.Drawing.Size(191, 22);
            this.BackupParamOMS.Text = "Backup Params";
            this.BackupParamOMS.ToolTipText = "Backup param files before overwriting them if checked";
            // 
            // RemoveEmptyParamOMS
            // 
            this.RemoveEmptyParamOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.RemoveEmptyParamOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveEmptyParamOMS.CheckOnClick = true;
            this.RemoveEmptyParamOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveEmptyParamOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveEmptyParamOMS.Name = "RemoveEmptyParamOMS";
            this.RemoveEmptyParamOMS.Size = new System.Drawing.Size(191, 22);
            this.RemoveEmptyParamOMS.Text = "Remove Empty Param";
            this.RemoveEmptyParamOMS.ToolTipText = "Remove params from the loaded list when there are no rows left in them";
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
            this.AboutHMS.ToolTipText = "About this program - Not yet implemented";
            this.AboutHMS.Click += new System.EventHandler(this.AboutHMS_Click);
            // 
            // SplitContainerA
            // 
            this.SplitContainerA.AllowDrop = true;
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
            this.SplitContainerA.SplitterDistance = 366;
            this.SplitContainerA.TabIndex = 4;
            this.SplitContainerA.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitContainerA_DragDrop);
            this.SplitContainerA.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitContainerA_DragEnter);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ParamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramname,
            this.paramtype});
            this.ParamDGV.ContextMenuStrip = this.ParamDGVContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = "null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParamDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ParamDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamDGV.EnableHeadersVisualStyles = false;
            this.ParamDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ParamDGV.Location = new System.Drawing.Point(0, 0);
            this.ParamDGV.Name = "ParamDGV";
            this.ParamDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ParamDGV.Size = new System.Drawing.Size(366, 605);
            this.ParamDGV.TabIndex = 0;
            this.ParamDGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ParamDGV_RowsAdded);
            this.ParamDGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ParamDGV_RowsRemoved);
            this.ParamDGV.SelectionChanged += new System.EventHandler(this.ParamDGV_SelectionChanged);
            this.ParamDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParamDGV_KeyDown);
            // 
            // paramname
            // 
            this.paramname.HeaderText = "Param Name";
            this.paramname.Name = "paramname";
            this.paramname.ReadOnly = true;
            this.paramname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paramtype
            // 
            this.paramtype.HeaderText = "Param Type";
            this.paramtype.Name = "paramtype";
            this.paramtype.ReadOnly = true;
            this.paramtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.SplitContainerB.Size = new System.Drawing.Size(748, 605);
            this.SplitContainerB.SplitterDistance = 369;
            this.SplitContainerB.TabIndex = 1;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.NullValue = "null";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RowDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowid,
            this.rowname});
            this.RowDGV.ContextMenuStrip = this.RowDGVContextMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.NullValue = "null";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RowDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.RowDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowDGV.EnableHeadersVisualStyles = false;
            this.RowDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.RowDGV.Location = new System.Drawing.Point(0, 0);
            this.RowDGV.Name = "RowDGV";
            this.RowDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.RowDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RowDGV.Size = new System.Drawing.Size(369, 605);
            this.RowDGV.TabIndex = 1;
            this.RowDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowDGV_CellValueChanged);
            this.RowDGV.SelectionChanged += new System.EventHandler(this.RowDGV_SelectionChanged);
            this.RowDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RowDGV_KeyDown);
            // 
            // rowid
            // 
            this.rowid.FillWeight = 48.63222F;
            this.rowid.HeaderText = "Row ID";
            this.rowid.Name = "rowid";
            this.rowid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rowname
            // 
            this.rowname.FillWeight = 151.3678F;
            this.rowname.HeaderText = "Row Name";
            this.rowname.Name = "rowname";
            this.rowname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.CellDGV.Size = new System.Drawing.Size(375, 605);
            this.CellDGV.TabIndex = 2;
            this.CellDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDGV_CellValueChanged);
            this.CellDGV.SelectionChanged += new System.EventHandler(this.CellDGV_SelectionChanged);
            this.CellDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CellDGV_KeyDown);
            // 
            // celltype
            // 
            this.celltype.HeaderText = "Cell Type";
            this.celltype.Name = "celltype";
            this.celltype.ReadOnly = true;
            this.celltype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cellname
            // 
            this.cellname.HeaderText = "Cell Name";
            this.cellname.Name = "cellname";
            this.cellname.ReadOnly = true;
            this.cellname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cellvalue
            // 
            this.cellvalue.HeaderText = "Cell Value";
            this.cellvalue.Name = "cellvalue";
            this.cellvalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CountLabel
            // 
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1118, 651);
            this.Controls.Add(this.SplitContainerA);
            this.Controls.Add(this.ReaderStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Armored Core For Answer Param Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.RowDGVContextMenu.ResumeLayout(false);
            this.ParamDGVContextMenu.ResumeLayout(false);
            this.ReaderStatusStrip.ResumeLayout(false);
            this.ReaderStatusStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.SplitContainerA.Panel1.ResumeLayout(false);
            this.SplitContainerA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerA)).EndInit();
            this.SplitContainerA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).EndInit();
            this.SplitContainerB.Panel1.ResumeLayout(false);
            this.SplitContainerB.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerB)).EndInit();
            this.SplitContainerB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatus;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMS;
        private System.Windows.Forms.ToolStripMenuItem OpenParamsFMS;
        private System.Windows.Forms.ToolStripMenuItem SaveAllFMS;
        private System.Windows.Forms.ToolStripMenuItem EditMS;
        private System.Windows.Forms.ToolStripMenuItem DeleteRowEMS;
        private System.Windows.Forms.ToolStripMenuItem HelpMS;
        private System.Windows.Forms.ToolStripMenuItem AboutHMS;
        private System.Windows.Forms.ToolStripMenuItem CopyRowEMS;
        private System.Windows.Forms.ToolStripMenuItem ExportFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertDefXmlEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertParamCsvEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertCsvParamEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertParamTsvEFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertTsvParamEFMS;
        private System.Windows.Forms.ToolStripSeparator FileSaveSeparatorMS;
        private System.Windows.Forms.ToolStripMenuItem DuplicateRowEMS;
        private System.Windows.Forms.ToolStripMenuItem PasteRowEMS;
        private System.Windows.Forms.ContextMenuStrip RowDGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem PasteRowRowConMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyRowRowConMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveFMS;
        private System.Windows.Forms.ToolStripMenuItem DeleteRowRowConMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsMS;
        private System.Windows.Forms.ToolStripMenuItem VerifyDeleteRowOMS;
        private System.Windows.Forms.ToolStripMenuItem RemoveParamFMS;
        private System.Windows.Forms.ToolStripMenuItem ClearParamFMS;
        private System.Windows.Forms.ToolStripMenuItem VerifySaveFileOMS;
        private System.Windows.Forms.ToolStripMenuItem BackupParamOMS;
        private System.Windows.Forms.ToolStripMenuItem VerifyParamRemovalOMS;
        private System.Windows.Forms.ContextMenuStrip ParamDGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenParamsParamConMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveParamParamConMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoEMS;
        private System.Windows.Forms.ToolStripMenuItem RedoEMS;
        private System.Windows.Forms.ToolStripMenuItem RemoveEmptyParamOMS;
        private System.Windows.Forms.ToolStripMenuItem RecurseOMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramname;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowname;
        private System.Windows.Forms.DataGridViewTextBoxColumn celltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellvalue;
        private System.Windows.Forms.ToolStripStatusLabel CountLabel;
    }
}

