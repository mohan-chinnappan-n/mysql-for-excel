﻿// Copyright (c) 2012, 2015, Oracle and/or its affiliates. All rights reserved.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License as
// published by the Free Software Foundation; version 2 of the
// License.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
// 02110-1301  USA

namespace MySQL.ForExcel.Forms
{
  partial class AppendAdvancedOptionsDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing"><c>true</c> if managed resources should be disposed; otherwise, <c>false</c>.</param>
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendAdvancedOptionsDialog));
      this.DialogAcceptButton = new System.Windows.Forms.Button();
      this.DialogCancelButton = new System.Windows.Forms.Button();
      this.UseFormattedValuesCheckBox = new System.Windows.Forms.CheckBox();
      this.FieldDataOptionsLabel = new System.Windows.Forms.Label();
      this.ReloadColumnMappingCheckBox = new System.Windows.Forms.CheckBox();
      this.AutoStoreColumnMappingCheckBox = new System.Windows.Forms.CheckBox();
      this.DoNotPerformAutoMapCheckBox = new System.Windows.Forms.CheckBox();
      this.MappingOptionsLabel = new System.Windows.Forms.Label();
      this.AdvancedExportOptionsLabel = new System.Windows.Forms.Label();
      this.StoredColumnMappingsLabel = new System.Windows.Forms.Label();
      this.RenameMappingButton = new System.Windows.Forms.Button();
      this.DeleteMappingButton = new System.Windows.Forms.Button();
      this.MappingsListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PreviewRowsQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.PreviewRowsQuantity2Label = new System.Windows.Forms.Label();
      this.PreviewRowsQuantity1Label = new System.Windows.Forms.Label();
      this.SqlQueriesLabel = new System.Windows.Forms.Label();
      this.DisableTableIndexesCheckBox = new System.Windows.Forms.CheckBox();
      this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.ShowDataTypesCheckBox = new System.Windows.Forms.CheckBox();
      this.ConfirmMappingOverwritingCheckBox = new System.Windows.Forms.CheckBox();
      this.GenerateMultipleInsertsCheckBox = new System.Windows.Forms.CheckBox();
      this.ResetToDefaultsButton = new System.Windows.Forms.Button();
      this.ContentAreaPanel.SuspendLayout();
      this.CommandAreaPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PreviewRowsQuantityNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // FootnoteAreaPanel
      // 
      this.FootnoteAreaPanel.Location = new System.Drawing.Point(0, 292);
      this.FootnoteAreaPanel.Size = new System.Drawing.Size(634, 0);
      // 
      // ContentAreaPanel
      // 
      this.ContentAreaPanel.Controls.Add(this.GenerateMultipleInsertsCheckBox);
      this.ContentAreaPanel.Controls.Add(this.ConfirmMappingOverwritingCheckBox);
      this.ContentAreaPanel.Controls.Add(this.ShowDataTypesCheckBox);
      this.ContentAreaPanel.Controls.Add(this.DisableTableIndexesCheckBox);
      this.ContentAreaPanel.Controls.Add(this.SqlQueriesLabel);
      this.ContentAreaPanel.Controls.Add(this.PreviewRowsQuantityNumericUpDown);
      this.ContentAreaPanel.Controls.Add(this.PreviewRowsQuantity2Label);
      this.ContentAreaPanel.Controls.Add(this.PreviewRowsQuantity1Label);
      this.ContentAreaPanel.Controls.Add(this.MappingsListView);
      this.ContentAreaPanel.Controls.Add(this.DeleteMappingButton);
      this.ContentAreaPanel.Controls.Add(this.RenameMappingButton);
      this.ContentAreaPanel.Controls.Add(this.StoredColumnMappingsLabel);
      this.ContentAreaPanel.Controls.Add(this.AdvancedExportOptionsLabel);
      this.ContentAreaPanel.Controls.Add(this.UseFormattedValuesCheckBox);
      this.ContentAreaPanel.Controls.Add(this.FieldDataOptionsLabel);
      this.ContentAreaPanel.Controls.Add(this.ReloadColumnMappingCheckBox);
      this.ContentAreaPanel.Controls.Add(this.AutoStoreColumnMappingCheckBox);
      this.ContentAreaPanel.Controls.Add(this.DoNotPerformAutoMapCheckBox);
      this.ContentAreaPanel.Controls.Add(this.MappingOptionsLabel);
      this.ContentAreaPanel.Size = new System.Drawing.Size(484, 646);
      // 
      // CommandAreaPanel
      // 
      this.CommandAreaPanel.Controls.Add(this.ResetToDefaultsButton);
      this.CommandAreaPanel.Controls.Add(this.DialogAcceptButton);
      this.CommandAreaPanel.Controls.Add(this.DialogCancelButton);
      this.CommandAreaPanel.Location = new System.Drawing.Point(0, 601);
      this.CommandAreaPanel.Size = new System.Drawing.Size(484, 45);
      // 
      // DialogAcceptButton
      // 
      this.DialogAcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.DialogAcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.DialogAcceptButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DialogAcceptButton.Location = new System.Drawing.Point(316, 11);
      this.DialogAcceptButton.Name = "DialogAcceptButton";
      this.DialogAcceptButton.Size = new System.Drawing.Size(75, 23);
      this.DialogAcceptButton.TabIndex = 0;
      this.DialogAcceptButton.Text = "Accept";
      this.DialogAcceptButton.UseVisualStyleBackColor = true;
      // 
      // DialogCancelButton
      // 
      this.DialogCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.DialogCancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DialogCancelButton.Location = new System.Drawing.Point(397, 11);
      this.DialogCancelButton.Name = "DialogCancelButton";
      this.DialogCancelButton.Size = new System.Drawing.Size(75, 23);
      this.DialogCancelButton.TabIndex = 1;
      this.DialogCancelButton.Text = "Cancel";
      this.DialogCancelButton.UseVisualStyleBackColor = true;
      // 
      // UseFormattedValuesCheckBox
      // 
      this.UseFormattedValuesCheckBox.AutoSize = true;
      this.UseFormattedValuesCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.UseFormattedValuesCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.UseFormattedValuesCheckBox.Location = new System.Drawing.Point(53, 249);
      this.UseFormattedValuesCheckBox.Name = "UseFormattedValuesCheckBox";
      this.UseFormattedValuesCheckBox.Size = new System.Drawing.Size(137, 19);
      this.UseFormattedValuesCheckBox.TabIndex = 10;
      this.UseFormattedValuesCheckBox.Text = "Use formatted values";
      this.HelpToolTip.SetToolTip(this.UseFormattedValuesCheckBox, "If checked it treats dates in Excel as such, otherwise it treats them as numbers." +
        "");
      this.UseFormattedValuesCheckBox.UseVisualStyleBackColor = false;
      // 
      // FieldDataOptionsLabel
      // 
      this.FieldDataOptionsLabel.AutoSize = true;
      this.FieldDataOptionsLabel.BackColor = System.Drawing.Color.Transparent;
      this.FieldDataOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FieldDataOptionsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FieldDataOptionsLabel.Location = new System.Drawing.Point(24, 197);
      this.FieldDataOptionsLabel.Name = "FieldDataOptionsLabel";
      this.FieldDataOptionsLabel.Size = new System.Drawing.Size(116, 17);
      this.FieldDataOptionsLabel.TabIndex = 6;
      this.FieldDataOptionsLabel.Text = "Field Data Options";
      // 
      // ReloadColumnMappingCheckBox
      // 
      this.ReloadColumnMappingCheckBox.AutoSize = true;
      this.ReloadColumnMappingCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.ReloadColumnMappingCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.ReloadColumnMappingCheckBox.Location = new System.Drawing.Point(53, 131);
      this.ReloadColumnMappingCheckBox.Name = "ReloadColumnMappingCheckBox";
      this.ReloadColumnMappingCheckBox.Size = new System.Drawing.Size(381, 19);
      this.ReloadColumnMappingCheckBox.TabIndex = 4;
      this.ReloadColumnMappingCheckBox.Text = "Reload stored column mapping for the selected table automatically";
      this.HelpToolTip.SetToolTip(this.ReloadColumnMappingCheckBox, "When checked if there is a stored mapping saved for the selected MySQL table, the" +
        " mapping will be applied automatically next time data is appended to that table." +
        "");
      this.ReloadColumnMappingCheckBox.UseVisualStyleBackColor = false;
      // 
      // AutoStoreColumnMappingCheckBox
      // 
      this.AutoStoreColumnMappingCheckBox.AutoSize = true;
      this.AutoStoreColumnMappingCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.AutoStoreColumnMappingCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.AutoStoreColumnMappingCheckBox.Location = new System.Drawing.Point(53, 108);
      this.AutoStoreColumnMappingCheckBox.Name = "AutoStoreColumnMappingCheckBox";
      this.AutoStoreColumnMappingCheckBox.Size = new System.Drawing.Size(343, 19);
      this.AutoStoreColumnMappingCheckBox.TabIndex = 3;
      this.AutoStoreColumnMappingCheckBox.Text = "Automatically store the column mapping for the given table";
      this.HelpToolTip.SetToolTip(this.AutoStoreColumnMappingCheckBox, "When checked a column mapping is automatically saved for the selected MySQL table" +
        ".");
      this.AutoStoreColumnMappingCheckBox.UseVisualStyleBackColor = false;
      // 
      // DoNotPerformAutoMapCheckBox
      // 
      this.DoNotPerformAutoMapCheckBox.AutoSize = true;
      this.DoNotPerformAutoMapCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.DoNotPerformAutoMapCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DoNotPerformAutoMapCheckBox.Location = new System.Drawing.Point(53, 85);
      this.DoNotPerformAutoMapCheckBox.Name = "DoNotPerformAutoMapCheckBox";
      this.DoNotPerformAutoMapCheckBox.Size = new System.Drawing.Size(296, 19);
      this.DoNotPerformAutoMapCheckBox.TabIndex = 2;
      this.DoNotPerformAutoMapCheckBox.Text = "Perform an automatic mapping when dialog opens";
      this.HelpToolTip.SetToolTip(this.DoNotPerformAutoMapCheckBox, resources.GetString("DoNotPerformAutoMapCheckBox.ToolTip"));
      this.DoNotPerformAutoMapCheckBox.UseVisualStyleBackColor = false;
      // 
      // MappingOptionsLabel
      // 
      this.MappingOptionsLabel.AutoSize = true;
      this.MappingOptionsLabel.BackColor = System.Drawing.Color.Transparent;
      this.MappingOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MappingOptionsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.MappingOptionsLabel.Location = new System.Drawing.Point(24, 56);
      this.MappingOptionsLabel.Name = "MappingOptionsLabel";
      this.MappingOptionsLabel.Size = new System.Drawing.Size(111, 17);
      this.MappingOptionsLabel.TabIndex = 1;
      this.MappingOptionsLabel.Text = "Mapping Options";
      // 
      // AdvancedExportOptionsLabel
      // 
      this.AdvancedExportOptionsLabel.AutoSize = true;
      this.AdvancedExportOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AdvancedExportOptionsLabel.ForeColor = System.Drawing.Color.Navy;
      this.AdvancedExportOptionsLabel.Location = new System.Drawing.Point(17, 17);
      this.AdvancedExportOptionsLabel.Name = "AdvancedExportOptionsLabel";
      this.AdvancedExportOptionsLabel.Size = new System.Drawing.Size(224, 20);
      this.AdvancedExportOptionsLabel.TabIndex = 0;
      this.AdvancedExportOptionsLabel.Text = "Advanced Append Data Options";
      // 
      // StoredColumnMappingsLabel
      // 
      this.StoredColumnMappingsLabel.AutoSize = true;
      this.StoredColumnMappingsLabel.BackColor = System.Drawing.Color.Transparent;
      this.StoredColumnMappingsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StoredColumnMappingsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.StoredColumnMappingsLabel.Location = new System.Drawing.Point(24, 413);
      this.StoredColumnMappingsLabel.Name = "StoredColumnMappingsLabel";
      this.StoredColumnMappingsLabel.Size = new System.Drawing.Size(158, 17);
      this.StoredColumnMappingsLabel.TabIndex = 15;
      this.StoredColumnMappingsLabel.Text = "Stored Column Mappings";
      // 
      // RenameMappingButton
      // 
      this.RenameMappingButton.Enabled = false;
      this.RenameMappingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.RenameMappingButton.Location = new System.Drawing.Point(387, 443);
      this.RenameMappingButton.Name = "RenameMappingButton";
      this.RenameMappingButton.Size = new System.Drawing.Size(75, 23);
      this.RenameMappingButton.TabIndex = 17;
      this.RenameMappingButton.Text = "Rename";
      this.RenameMappingButton.UseVisualStyleBackColor = true;
      this.RenameMappingButton.Click += new System.EventHandler(this.RenameMappingButton_Click);
      // 
      // DeleteMappingButton
      // 
      this.DeleteMappingButton.Enabled = false;
      this.DeleteMappingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.DeleteMappingButton.Location = new System.Drawing.Point(387, 472);
      this.DeleteMappingButton.Name = "DeleteMappingButton";
      this.DeleteMappingButton.Size = new System.Drawing.Size(75, 23);
      this.DeleteMappingButton.TabIndex = 18;
      this.DeleteMappingButton.Text = "Delete";
      this.DeleteMappingButton.UseVisualStyleBackColor = true;
      this.DeleteMappingButton.Click += new System.EventHandler(this.DeleteMappingButton_Click);
      // 
      // MappingsListView
      // 
      this.MappingsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.MappingsListView.FullRowSelect = true;
      this.MappingsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.MappingsListView.Location = new System.Drawing.Point(53, 443);
      this.MappingsListView.MultiSelect = false;
      this.MappingsListView.Name = "MappingsListView";
      this.MappingsListView.Size = new System.Drawing.Size(328, 127);
      this.MappingsListView.TabIndex = 16;
      this.MappingsListView.UseCompatibleStateImageBehavior = false;
      this.MappingsListView.View = System.Windows.Forms.View.Details;
      this.MappingsListView.SelectedIndexChanged += new System.EventHandler(this.MappingsListView_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "";
      this.columnHeader1.Width = 265;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "";
      this.columnHeader2.Width = 0;
      // 
      // PreviewRowsQuantityNumericUpDown
      // 
      this.PreviewRowsQuantityNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.PreviewRowsQuantityNumericUpDown.Location = new System.Drawing.Point(127, 224);
      this.PreviewRowsQuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.PreviewRowsQuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.PreviewRowsQuantityNumericUpDown.Name = "PreviewRowsQuantityNumericUpDown";
      this.PreviewRowsQuantityNumericUpDown.Size = new System.Drawing.Size(52, 23);
      this.PreviewRowsQuantityNumericUpDown.TabIndex = 8;
      this.HelpToolTip.SetToolTip(this.PreviewRowsQuantityNumericUpDown, "Limits the data preview and data type automatic detection to the given number of " +
        "Excel data rows.");
      this.PreviewRowsQuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // PreviewRowsQuantity2Label
      // 
      this.PreviewRowsQuantity2Label.AutoSize = true;
      this.PreviewRowsQuantity2Label.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.PreviewRowsQuantity2Label.Location = new System.Drawing.Point(185, 226);
      this.PreviewRowsQuantity2Label.Name = "PreviewRowsQuantity2Label";
      this.PreviewRowsQuantity2Label.Size = new System.Drawing.Size(275, 15);
      this.PreviewRowsQuantity2Label.TabIndex = 9;
      this.PreviewRowsQuantity2Label.Text = "Excel data rows to preview and calculate datatypes.";
      // 
      // PreviewRowsQuantity1Label
      // 
      this.PreviewRowsQuantity1Label.AutoSize = true;
      this.PreviewRowsQuantity1Label.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.PreviewRowsQuantity1Label.Location = new System.Drawing.Point(50, 226);
      this.PreviewRowsQuantity1Label.Name = "PreviewRowsQuantity1Label";
      this.PreviewRowsQuantity1Label.Size = new System.Drawing.Size(69, 15);
      this.PreviewRowsQuantity1Label.TabIndex = 7;
      this.PreviewRowsQuantity1Label.Text = "Use the first";
      // 
      // SqlQueriesLabel
      // 
      this.SqlQueriesLabel.AutoSize = true;
      this.SqlQueriesLabel.BackColor = System.Drawing.Color.Transparent;
      this.SqlQueriesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SqlQueriesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.SqlQueriesLabel.Location = new System.Drawing.Point(24, 315);
      this.SqlQueriesLabel.Name = "SqlQueriesLabel";
      this.SqlQueriesLabel.Size = new System.Drawing.Size(130, 17);
      this.SqlQueriesLabel.TabIndex = 12;
      this.SqlQueriesLabel.Text = "SQL Queries Options";
      // 
      // DisableTableIndexesCheckBox
      // 
      this.DisableTableIndexesCheckBox.AutoSize = true;
      this.DisableTableIndexesCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.DisableTableIndexesCheckBox.Location = new System.Drawing.Point(73, 369);
      this.DisableTableIndexesCheckBox.Name = "DisableTableIndexesCheckBox";
      this.DisableTableIndexesCheckBox.Size = new System.Drawing.Size(279, 19);
      this.DisableTableIndexesCheckBox.TabIndex = 14;
      this.DisableTableIndexesCheckBox.Text = "Disable table indexes to speed-up rows insertion";
      this.HelpToolTip.SetToolTip(this.DisableTableIndexesCheckBox, resources.GetString("DisableTableIndexesCheckBox.ToolTip"));
      this.DisableTableIndexesCheckBox.UseVisualStyleBackColor = true;
      // 
      // HelpToolTip
      // 
      this.HelpToolTip.AutoPopDelay = 5000;
      this.HelpToolTip.InitialDelay = 1000;
      this.HelpToolTip.ReshowDelay = 100;
      // 
      // ShowDataTypesCheckBox
      // 
      this.ShowDataTypesCheckBox.AutoSize = true;
      this.ShowDataTypesCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.ShowDataTypesCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.ShowDataTypesCheckBox.Location = new System.Drawing.Point(53, 274);
      this.ShowDataTypesCheckBox.Name = "ShowDataTypesCheckBox";
      this.ShowDataTypesCheckBox.Size = new System.Drawing.Size(273, 19);
      this.ShowDataTypesCheckBox.TabIndex = 11;
      this.ShowDataTypesCheckBox.Text = "Show column data types above column names";
      this.HelpToolTip.SetToolTip(this.ShowDataTypesCheckBox, "If checked the data types of the source data and target MySQL table are shown abo" +
        "ve column names.\r\nWhen unchecked, data types are shown as tooltips on column nam" +
        "es.");
      this.ShowDataTypesCheckBox.UseVisualStyleBackColor = false;
      // 
      // ConfirmMappingOverwritingCheckBox
      // 
      this.ConfirmMappingOverwritingCheckBox.AutoSize = true;
      this.ConfirmMappingOverwritingCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.ConfirmMappingOverwritingCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.ConfirmMappingOverwritingCheckBox.Location = new System.Drawing.Point(53, 156);
      this.ConfirmMappingOverwritingCheckBox.Name = "ConfirmMappingOverwritingCheckBox";
      this.ConfirmMappingOverwritingCheckBox.Size = new System.Drawing.Size(228, 19);
      this.ConfirmMappingOverwritingCheckBox.TabIndex = 5;
      this.ConfirmMappingOverwritingCheckBox.Text = "Confirm column mapping overwriting";
      this.HelpToolTip.SetToolTip(this.ConfirmMappingOverwritingCheckBox, resources.GetString("ConfirmMappingOverwritingCheckBox.ToolTip"));
      this.ConfirmMappingOverwritingCheckBox.UseVisualStyleBackColor = false;
      // 
      // GenerateMultipleInsertsCheckBox
      // 
      this.GenerateMultipleInsertsCheckBox.AutoSize = true;
      this.GenerateMultipleInsertsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.GenerateMultipleInsertsCheckBox.Location = new System.Drawing.Point(53, 344);
      this.GenerateMultipleInsertsCheckBox.Name = "GenerateMultipleInsertsCheckBox";
      this.GenerateMultipleInsertsCheckBox.Size = new System.Drawing.Size(281, 19);
      this.GenerateMultipleInsertsCheckBox.TabIndex = 13;
      this.GenerateMultipleInsertsCheckBox.Text = "Generate an INSERT statement for each data row";
      this.HelpToolTip.SetToolTip(this.GenerateMultipleInsertsCheckBox, resources.GetString("GenerateMultipleInsertsCheckBox.ToolTip"));
      this.GenerateMultipleInsertsCheckBox.UseVisualStyleBackColor = true;
      this.GenerateMultipleInsertsCheckBox.CheckedChanged += new System.EventHandler(this.GenerateMultipleInsertsCheckBox_CheckedChanged);
      // 
      // ResetToDefaultsButton
      // 
      this.ResetToDefaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.ResetToDefaultsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ResetToDefaultsButton.Location = new System.Drawing.Point(12, 11);
      this.ResetToDefaultsButton.Name = "ResetToDefaultsButton";
      this.ResetToDefaultsButton.Size = new System.Drawing.Size(128, 23);
      this.ResetToDefaultsButton.TabIndex = 2;
      this.ResetToDefaultsButton.Text = "Reset to Defaults";
      this.ResetToDefaultsButton.UseVisualStyleBackColor = true;
      this.ResetToDefaultsButton.Click += new System.EventHandler(this.ResetToDefaultsButton_Click);
      // 
      // AppendAdvancedOptionsDialog
      // 
      this.AcceptButton = this.DialogAcceptButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.DialogCancelButton;
      this.ClientSize = new System.Drawing.Size(484, 646);
      this.CommandAreaVisible = true;
      this.FootnoteAreaHeight = 0;
      this.MainInstructionLocation = new System.Drawing.Point(13, 21);
      this.Name = "AppendAdvancedOptionsDialog";
      this.Text = "Advanced Options";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppendAdvancedOptionsDialog_FormClosing);
      this.ContentAreaPanel.ResumeLayout(false);
      this.ContentAreaPanel.PerformLayout();
      this.CommandAreaPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PreviewRowsQuantityNumericUpDown)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button DialogAcceptButton;
    private System.Windows.Forms.Button DialogCancelButton;
    private System.Windows.Forms.CheckBox UseFormattedValuesCheckBox;
    private System.Windows.Forms.Label FieldDataOptionsLabel;
    private System.Windows.Forms.CheckBox ReloadColumnMappingCheckBox;
    private System.Windows.Forms.CheckBox AutoStoreColumnMappingCheckBox;
    private System.Windows.Forms.CheckBox DoNotPerformAutoMapCheckBox;
    private System.Windows.Forms.Label MappingOptionsLabel;
    private System.Windows.Forms.Label AdvancedExportOptionsLabel;
    private System.Windows.Forms.Button DeleteMappingButton;
    private System.Windows.Forms.Button RenameMappingButton;
    private System.Windows.Forms.Label StoredColumnMappingsLabel;
    private System.Windows.Forms.ListView MappingsListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.NumericUpDown PreviewRowsQuantityNumericUpDown;
    private System.Windows.Forms.Label PreviewRowsQuantity2Label;
    private System.Windows.Forms.Label PreviewRowsQuantity1Label;
    private System.Windows.Forms.Label SqlQueriesLabel;
    private System.Windows.Forms.CheckBox DisableTableIndexesCheckBox;
    private System.Windows.Forms.ToolTip HelpToolTip;
    private System.Windows.Forms.Button ResetToDefaultsButton;
    private System.Windows.Forms.CheckBox ShowDataTypesCheckBox;
    private System.Windows.Forms.CheckBox ConfirmMappingOverwritingCheckBox;
    private System.Windows.Forms.CheckBox GenerateMultipleInsertsCheckBox;
  }
}