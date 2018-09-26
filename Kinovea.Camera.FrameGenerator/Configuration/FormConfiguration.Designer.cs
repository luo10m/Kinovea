﻿#region License
/*
Copyright © Joan Charmant 2013.
jcharmant@gmail.com 
 
This file is part of Kinovea.

Kinovea is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

Kinovea is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Kinovea. If not, see http://www.gnu.org/licenses/.
*/
#endregion
namespace Kinovea.Camera.FrameGenerator
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.cmbFrameSize = new System.Windows.Forms.ComboBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFramerate = new System.Windows.Forms.ComboBox();
            this.lblFramerate = new System.Windows.Forms.Label();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(119, 179);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(99, 24);
            this.btnApply.TabIndex = 78;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(224, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 24);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblImageSize
            // 
            this.lblImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageSize.BackColor = System.Drawing.Color.Transparent;
            this.lblImageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageSize.ForeColor = System.Drawing.Color.Black;
            this.lblImageSize.Location = new System.Drawing.Point(24, 73);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(93, 23);
            this.lblImageSize.TabIndex = 80;
            this.lblImageSize.Text = "Frame size :";
            this.lblImageSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFrameSize
            // 
            this.cmbFrameSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrameSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameSize.FormattingEnabled = true;
            this.cmbFrameSize.Location = new System.Drawing.Point(123, 75);
            this.cmbFrameSize.Name = "cmbFrameSize";
            this.cmbFrameSize.Size = new System.Drawing.Size(173, 21);
            this.cmbFrameSize.TabIndex = 81;
            this.cmbFrameSize.SelectedIndexChanged += new System.EventHandler(this.SpecificInfo_Changed);
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(24, 26);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(16, 16);
            this.btnIcon.TabIndex = 83;
            this.btnIcon.UseVisualStyleBackColor = false;
            this.btnIcon.Click += new System.EventHandler(this.BtnIconClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbFramerate);
            this.groupBox1.Controls.Add(this.lblFramerate);
            this.groupBox1.Controls.Add(this.tbAlias);
            this.groupBox1.Controls.Add(this.lblSystemName);
            this.groupBox1.Controls.Add(this.btnIcon);
            this.groupBox1.Controls.Add(this.cmbFrameSize);
            this.groupBox1.Controls.Add(this.lblImageSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 150);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // cmbFramerate
            // 
            this.cmbFramerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFramerate.FormattingEnabled = true;
            this.cmbFramerate.Location = new System.Drawing.Point(123, 109);
            this.cmbFramerate.Name = "cmbFramerate";
            this.cmbFramerate.Size = new System.Drawing.Size(173, 21);
            this.cmbFramerate.TabIndex = 88;
            this.cmbFramerate.SelectedIndexChanged += new System.EventHandler(this.SpecificInfo_Changed);
            // 
            // lblFramerate
            // 
            this.lblFramerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFramerate.BackColor = System.Drawing.Color.Transparent;
            this.lblFramerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFramerate.ForeColor = System.Drawing.Color.Black;
            this.lblFramerate.Location = new System.Drawing.Point(24, 107);
            this.lblFramerate.Name = "lblFramerate";
            this.lblFramerate.Size = new System.Drawing.Size(93, 23);
            this.lblFramerate.TabIndex = 87;
            this.lblFramerate.Text = "Frame rate :";
            this.lblFramerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAlias
            // 
            this.tbAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlias.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbAlias.Location = new System.Drawing.Point(73, 26);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(223, 15);
            this.tbAlias.TabIndex = 86;
            this.tbAlias.Text = "Alias";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.Black;
            this.lblSystemName.Location = new System.Drawing.Point(68, 45);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(70, 13);
            this.lblSystemName.TabIndex = 85;
            this.lblSystemName.Text = "System name";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfiguration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.ComboBox cmbFrameSize;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbFramerate;
        private System.Windows.Forms.Label lblFramerate;
    }
}