using MaterialSkin;
using System.Drawing;
using System.Drawing.Text;

namespace DataArray
{
    partial class Form1
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialButtonSortHighNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonClearAllNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCopyAllNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDeleteNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSortLowNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonReplaceNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonInsertNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonFindNumber = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonAddNumber = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialListBoxTemp = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialListBoxNumber = new MaterialSkin.Controls.MaterialListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.materialButtonClearAllText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCopyAllText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDeleteText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSortText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonReplaceText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonInsertText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonFindText = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonAddText = new MaterialSkin.Controls.MaterialButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxText = new MaterialSkin.Controls.MaterialTextBox();
            this.materialListBoxTempText = new MaterialSkin.Controls.MaterialListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialListBoxText = new MaterialSkin.Controls.MaterialListBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTabControl1.Location = new System.Drawing.Point(6, 118);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.ShowToolTips = true;
            this.materialTabControl1.Size = new System.Drawing.Size(761, 502);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Number";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox4.Controls.Add(this.materialButtonSortHighNumber);
            this.groupBox4.Controls.Add(this.materialButtonClearAllNumber);
            this.groupBox4.Controls.Add(this.materialButtonCopyAllNumber);
            this.groupBox4.Controls.Add(this.materialButtonDeleteNumber);
            this.groupBox4.Controls.Add(this.materialButtonSortLowNumber);
            this.groupBox4.Controls.Add(this.materialButtonReplaceNumber);
            this.groupBox4.Controls.Add(this.materialButtonInsertNumber);
            this.groupBox4.Controls.Add(this.materialButtonFindNumber);
            this.groupBox4.Controls.Add(this.materialButtonAddNumber);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(502, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 457);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // materialButtonSortHighNumber
            // 
            this.materialButtonSortHighNumber.AutoSize = false;
            this.materialButtonSortHighNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSortHighNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonSortHighNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSortHighNumber.Depth = 0;
            this.materialButtonSortHighNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonSortHighNumber.HighEmphasis = true;
            this.materialButtonSortHighNumber.Icon = null;
            this.materialButtonSortHighNumber.Location = new System.Drawing.Point(130, 258);
            this.materialButtonSortHighNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSortHighNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSortHighNumber.Name = "materialButtonSortHighNumber";
            this.materialButtonSortHighNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSortHighNumber.Size = new System.Drawing.Size(76, 36);
            this.materialButtonSortHighNumber.TabIndex = 8;
            this.materialButtonSortHighNumber.Text = "Sort >";
            this.materialButtonSortHighNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSortHighNumber.UseAccentColor = false;
            this.materialButtonSortHighNumber.UseVisualStyleBackColor = false;
            this.materialButtonSortHighNumber.Click += new System.EventHandler(this.materialButtonSortHighNumber_Click);
            // 
            // materialButtonClearAllNumber
            // 
            this.materialButtonClearAllNumber.AutoSize = false;
            this.materialButtonClearAllNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonClearAllNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonClearAllNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonClearAllNumber.Depth = 0;
            this.materialButtonClearAllNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonClearAllNumber.HighEmphasis = true;
            this.materialButtonClearAllNumber.Icon = null;
            this.materialButtonClearAllNumber.Location = new System.Drawing.Point(48, 402);
            this.materialButtonClearAllNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonClearAllNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonClearAllNumber.Name = "materialButtonClearAllNumber";
            this.materialButtonClearAllNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonClearAllNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonClearAllNumber.TabIndex = 7;
            this.materialButtonClearAllNumber.Text = "Clear All";
            this.materialButtonClearAllNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonClearAllNumber.UseAccentColor = false;
            this.materialButtonClearAllNumber.UseVisualStyleBackColor = false;
            this.materialButtonClearAllNumber.Click += new System.EventHandler(this.materialButtonClearAllNumber_Click);
            // 
            // materialButtonCopyAllNumber
            // 
            this.materialButtonCopyAllNumber.AutoSize = false;
            this.materialButtonCopyAllNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCopyAllNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonCopyAllNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCopyAllNumber.Depth = 0;
            this.materialButtonCopyAllNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonCopyAllNumber.HighEmphasis = true;
            this.materialButtonCopyAllNumber.Icon = null;
            this.materialButtonCopyAllNumber.Location = new System.Drawing.Point(48, 354);
            this.materialButtonCopyAllNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCopyAllNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCopyAllNumber.Name = "materialButtonCopyAllNumber";
            this.materialButtonCopyAllNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCopyAllNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonCopyAllNumber.TabIndex = 6;
            this.materialButtonCopyAllNumber.Text = "Copy All";
            this.materialButtonCopyAllNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCopyAllNumber.UseAccentColor = false;
            this.materialButtonCopyAllNumber.UseVisualStyleBackColor = false;
            this.materialButtonCopyAllNumber.Click += new System.EventHandler(this.materialButtonCopyAllNumber_Click);
            // 
            // materialButtonDeleteNumber
            // 
            this.materialButtonDeleteNumber.AutoSize = false;
            this.materialButtonDeleteNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDeleteNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonDeleteNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDeleteNumber.Depth = 0;
            this.materialButtonDeleteNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonDeleteNumber.HighEmphasis = true;
            this.materialButtonDeleteNumber.Icon = null;
            this.materialButtonDeleteNumber.Location = new System.Drawing.Point(48, 306);
            this.materialButtonDeleteNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDeleteNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDeleteNumber.Name = "materialButtonDeleteNumber";
            this.materialButtonDeleteNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDeleteNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonDeleteNumber.TabIndex = 5;
            this.materialButtonDeleteNumber.Text = "Delete";
            this.materialButtonDeleteNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDeleteNumber.UseAccentColor = false;
            this.materialButtonDeleteNumber.UseVisualStyleBackColor = false;
            this.materialButtonDeleteNumber.Click += new System.EventHandler(this.materialButtonDeleteNumber_Click);
            // 
            // materialButtonSortLowNumber
            // 
            this.materialButtonSortLowNumber.AutoSize = false;
            this.materialButtonSortLowNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSortLowNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonSortLowNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSortLowNumber.Depth = 0;
            this.materialButtonSortLowNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonSortLowNumber.HighEmphasis = true;
            this.materialButtonSortLowNumber.Icon = null;
            this.materialButtonSortLowNumber.Location = new System.Drawing.Point(48, 258);
            this.materialButtonSortLowNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSortLowNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSortLowNumber.Name = "materialButtonSortLowNumber";
            this.materialButtonSortLowNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSortLowNumber.Size = new System.Drawing.Size(76, 36);
            this.materialButtonSortLowNumber.TabIndex = 4;
            this.materialButtonSortLowNumber.Text = "Sort <";
            this.materialButtonSortLowNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSortLowNumber.UseAccentColor = false;
            this.materialButtonSortLowNumber.UseVisualStyleBackColor = false;
            this.materialButtonSortLowNumber.Click += new System.EventHandler(this.materialButtonSortLowNumber_Click);
            // 
            // materialButtonReplaceNumber
            // 
            this.materialButtonReplaceNumber.AutoSize = false;
            this.materialButtonReplaceNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonReplaceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonReplaceNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonReplaceNumber.Depth = 0;
            this.materialButtonReplaceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonReplaceNumber.HighEmphasis = true;
            this.materialButtonReplaceNumber.Icon = null;
            this.materialButtonReplaceNumber.Location = new System.Drawing.Point(48, 188);
            this.materialButtonReplaceNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonReplaceNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonReplaceNumber.Name = "materialButtonReplaceNumber";
            this.materialButtonReplaceNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonReplaceNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonReplaceNumber.TabIndex = 3;
            this.materialButtonReplaceNumber.Text = "Replace";
            this.materialButtonReplaceNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonReplaceNumber.UseAccentColor = false;
            this.materialButtonReplaceNumber.UseVisualStyleBackColor = false;
            this.materialButtonReplaceNumber.Click += new System.EventHandler(this.materialButtonReplaceNumber_Click);
            // 
            // materialButtonInsertNumber
            // 
            this.materialButtonInsertNumber.AutoSize = false;
            this.materialButtonInsertNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonInsertNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonInsertNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonInsertNumber.Depth = 0;
            this.materialButtonInsertNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonInsertNumber.HighEmphasis = true;
            this.materialButtonInsertNumber.Icon = null;
            this.materialButtonInsertNumber.Location = new System.Drawing.Point(48, 140);
            this.materialButtonInsertNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonInsertNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonInsertNumber.Name = "materialButtonInsertNumber";
            this.materialButtonInsertNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonInsertNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonInsertNumber.TabIndex = 2;
            this.materialButtonInsertNumber.Text = "Insert";
            this.materialButtonInsertNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonInsertNumber.UseAccentColor = false;
            this.materialButtonInsertNumber.UseVisualStyleBackColor = false;
            this.materialButtonInsertNumber.Click += new System.EventHandler(this.materialButtonInsertNumber_Click);
            // 
            // materialButtonFindNumber
            // 
            this.materialButtonFindNumber.AutoSize = false;
            this.materialButtonFindNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonFindNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonFindNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonFindNumber.Depth = 0;
            this.materialButtonFindNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonFindNumber.HighEmphasis = true;
            this.materialButtonFindNumber.Icon = null;
            this.materialButtonFindNumber.Location = new System.Drawing.Point(48, 92);
            this.materialButtonFindNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFindNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFindNumber.Name = "materialButtonFindNumber";
            this.materialButtonFindNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFindNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonFindNumber.TabIndex = 1;
            this.materialButtonFindNumber.Text = "Find";
            this.materialButtonFindNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFindNumber.UseAccentColor = false;
            this.materialButtonFindNumber.UseVisualStyleBackColor = false;
            this.materialButtonFindNumber.Click += new System.EventHandler(this.materialButtonFindNumber_Click);
            // 
            // materialButtonAddNumber
            // 
            this.materialButtonAddNumber.AutoSize = false;
            this.materialButtonAddNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonAddNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddNumber.Depth = 0;
            this.materialButtonAddNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonAddNumber.HighEmphasis = true;
            this.materialButtonAddNumber.Icon = null;
            this.materialButtonAddNumber.Location = new System.Drawing.Point(48, 44);
            this.materialButtonAddNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddNumber.Name = "materialButtonAddNumber";
            this.materialButtonAddNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddNumber.Size = new System.Drawing.Size(158, 36);
            this.materialButtonAddNumber.TabIndex = 0;
            this.materialButtonAddNumber.Text = "Add";
            this.materialButtonAddNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddNumber.UseAccentColor = false;
            this.materialButtonAddNumber.UseVisualStyleBackColor = false;
            this.materialButtonAddNumber.Click += new System.EventHandler(this.materialButtonAddNumber_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox3.Controls.Add(this.materialListBoxTemp);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.materialTextBoxNumber);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(254, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 457);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temp";
            // 
            // materialListBoxTemp
            // 
            this.materialListBoxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialListBoxTemp.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxTemp.Depth = 0;
            this.materialListBoxTemp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxTemp.Location = new System.Drawing.Point(7, 100);
            this.materialListBoxTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxTemp.Name = "materialListBoxTemp";
            this.materialListBoxTemp.SelectedIndex = -1;
            this.materialListBoxTemp.SelectedItem = null;
            this.materialListBoxTemp.ShowScrollBar = true;
            this.materialListBoxTemp.Size = new System.Drawing.Size(229, 351);
            this.materialListBoxTemp.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Enter your number:";
            // 
            // materialTextBoxNumber
            // 
            this.materialTextBoxNumber.AnimateReadOnly = false;
            this.materialTextBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialTextBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxNumber.Depth = 0;
            this.materialTextBoxNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBoxNumber.LeadingIcon = null;
            this.materialTextBoxNumber.Location = new System.Drawing.Point(38, 44);
            this.materialTextBoxNumber.MaxLength = 13;
            this.materialTextBoxNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxNumber.Multiline = false;
            this.materialTextBoxNumber.Name = "materialTextBoxNumber";
            this.materialTextBoxNumber.Size = new System.Drawing.Size(160, 50);
            this.materialTextBoxNumber.TabIndex = 1;
            this.materialTextBoxNumber.Text = "";
            this.materialTextBoxNumber.TrailingIcon = null;
            this.materialTextBoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialTextBoxNumber_KeyDown);
            this.materialTextBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxNumber_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.materialListBoxNumber);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number Array";
            // 
            // materialListBoxNumber
            // 
            this.materialListBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialListBoxNumber.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxNumber.Depth = 0;
            this.materialListBoxNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxNumber.Location = new System.Drawing.Point(7, 26);
            this.materialListBoxNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxNumber.Name = "materialListBoxNumber";
            this.materialListBoxNumber.SelectedIndex = -1;
            this.materialListBoxNumber.SelectedItem = null;
            this.materialListBoxNumber.ShowScrollBar = true;
            this.materialListBoxNumber.Size = new System.Drawing.Size(229, 425);
            this.materialListBoxNumber.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox6.Controls.Add(this.materialButtonClearAllText);
            this.groupBox6.Controls.Add(this.materialButtonCopyAllText);
            this.groupBox6.Controls.Add(this.materialButtonDeleteText);
            this.groupBox6.Controls.Add(this.materialButtonSortText);
            this.groupBox6.Controls.Add(this.materialButtonReplaceText);
            this.groupBox6.Controls.Add(this.materialButtonInsertText);
            this.groupBox6.Controls.Add(this.materialButtonFindText);
            this.groupBox6.Controls.Add(this.materialButtonAddText);
            this.groupBox6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox6.Location = new System.Drawing.Point(502, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 457);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // materialButtonClearAllText
            // 
            this.materialButtonClearAllText.AutoSize = false;
            this.materialButtonClearAllText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonClearAllText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonClearAllText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonClearAllText.Depth = 0;
            this.materialButtonClearAllText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonClearAllText.HighEmphasis = true;
            this.materialButtonClearAllText.Icon = null;
            this.materialButtonClearAllText.Location = new System.Drawing.Point(48, 402);
            this.materialButtonClearAllText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonClearAllText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonClearAllText.Name = "materialButtonClearAllText";
            this.materialButtonClearAllText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonClearAllText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonClearAllText.TabIndex = 16;
            this.materialButtonClearAllText.Text = "Clear All";
            this.materialButtonClearAllText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonClearAllText.UseAccentColor = false;
            this.materialButtonClearAllText.UseVisualStyleBackColor = false;
            this.materialButtonClearAllText.Click += new System.EventHandler(this.materialButtonClearAllText_Click);
            // 
            // materialButtonCopyAllText
            // 
            this.materialButtonCopyAllText.AutoSize = false;
            this.materialButtonCopyAllText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCopyAllText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonCopyAllText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCopyAllText.Depth = 0;
            this.materialButtonCopyAllText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonCopyAllText.HighEmphasis = true;
            this.materialButtonCopyAllText.Icon = null;
            this.materialButtonCopyAllText.Location = new System.Drawing.Point(48, 354);
            this.materialButtonCopyAllText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCopyAllText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCopyAllText.Name = "materialButtonCopyAllText";
            this.materialButtonCopyAllText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCopyAllText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonCopyAllText.TabIndex = 15;
            this.materialButtonCopyAllText.Text = "Copy All";
            this.materialButtonCopyAllText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCopyAllText.UseAccentColor = false;
            this.materialButtonCopyAllText.UseVisualStyleBackColor = false;
            this.materialButtonCopyAllText.Click += new System.EventHandler(this.materialButtonCopyAllText_Click);
            // 
            // materialButtonDeleteText
            // 
            this.materialButtonDeleteText.AutoSize = false;
            this.materialButtonDeleteText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDeleteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonDeleteText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDeleteText.Depth = 0;
            this.materialButtonDeleteText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonDeleteText.HighEmphasis = true;
            this.materialButtonDeleteText.Icon = null;
            this.materialButtonDeleteText.Location = new System.Drawing.Point(48, 306);
            this.materialButtonDeleteText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDeleteText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDeleteText.Name = "materialButtonDeleteText";
            this.materialButtonDeleteText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDeleteText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonDeleteText.TabIndex = 14;
            this.materialButtonDeleteText.Text = "Delete";
            this.materialButtonDeleteText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDeleteText.UseAccentColor = false;
            this.materialButtonDeleteText.UseVisualStyleBackColor = false;
            this.materialButtonDeleteText.Click += new System.EventHandler(this.materialButtonDeleteText_Click);
            // 
            // materialButtonSortText
            // 
            this.materialButtonSortText.AutoSize = false;
            this.materialButtonSortText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSortText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonSortText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSortText.Depth = 0;
            this.materialButtonSortText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonSortText.HighEmphasis = true;
            this.materialButtonSortText.Icon = null;
            this.materialButtonSortText.Location = new System.Drawing.Point(48, 258);
            this.materialButtonSortText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSortText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSortText.Name = "materialButtonSortText";
            this.materialButtonSortText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSortText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonSortText.TabIndex = 13;
            this.materialButtonSortText.Text = "Sort";
            this.materialButtonSortText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSortText.UseAccentColor = false;
            this.materialButtonSortText.UseVisualStyleBackColor = false;
            this.materialButtonSortText.Click += new System.EventHandler(this.materialButtonSortText_Click);
            // 
            // materialButtonReplaceText
            // 
            this.materialButtonReplaceText.AutoSize = false;
            this.materialButtonReplaceText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonReplaceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonReplaceText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonReplaceText.Depth = 0;
            this.materialButtonReplaceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonReplaceText.HighEmphasis = true;
            this.materialButtonReplaceText.Icon = null;
            this.materialButtonReplaceText.Location = new System.Drawing.Point(48, 188);
            this.materialButtonReplaceText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonReplaceText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonReplaceText.Name = "materialButtonReplaceText";
            this.materialButtonReplaceText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonReplaceText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonReplaceText.TabIndex = 12;
            this.materialButtonReplaceText.Text = "Replace";
            this.materialButtonReplaceText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonReplaceText.UseAccentColor = false;
            this.materialButtonReplaceText.UseVisualStyleBackColor = false;
            this.materialButtonReplaceText.Click += new System.EventHandler(this.materialButtonReplaceText_Click);
            // 
            // materialButtonInsertText
            // 
            this.materialButtonInsertText.AutoSize = false;
            this.materialButtonInsertText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonInsertText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonInsertText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonInsertText.Depth = 0;
            this.materialButtonInsertText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonInsertText.HighEmphasis = true;
            this.materialButtonInsertText.Icon = null;
            this.materialButtonInsertText.Location = new System.Drawing.Point(48, 140);
            this.materialButtonInsertText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonInsertText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonInsertText.Name = "materialButtonInsertText";
            this.materialButtonInsertText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonInsertText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonInsertText.TabIndex = 11;
            this.materialButtonInsertText.Text = "Insert";
            this.materialButtonInsertText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonInsertText.UseAccentColor = false;
            this.materialButtonInsertText.UseVisualStyleBackColor = false;
            this.materialButtonInsertText.Click += new System.EventHandler(this.materialButtonInsertText_Click);
            // 
            // materialButtonFindText
            // 
            this.materialButtonFindText.AutoSize = false;
            this.materialButtonFindText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonFindText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonFindText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonFindText.Depth = 0;
            this.materialButtonFindText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonFindText.HighEmphasis = true;
            this.materialButtonFindText.Icon = null;
            this.materialButtonFindText.Location = new System.Drawing.Point(48, 92);
            this.materialButtonFindText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFindText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFindText.Name = "materialButtonFindText";
            this.materialButtonFindText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFindText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonFindText.TabIndex = 10;
            this.materialButtonFindText.Text = "Find";
            this.materialButtonFindText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFindText.UseAccentColor = false;
            this.materialButtonFindText.UseVisualStyleBackColor = false;
            this.materialButtonFindText.Click += new System.EventHandler(this.materialButtonFindText_Click);
            // 
            // materialButtonAddText
            // 
            this.materialButtonAddText.AutoSize = false;
            this.materialButtonAddText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButtonAddText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddText.Depth = 0;
            this.materialButtonAddText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButtonAddText.HighEmphasis = true;
            this.materialButtonAddText.Icon = null;
            this.materialButtonAddText.Location = new System.Drawing.Point(48, 44);
            this.materialButtonAddText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddText.Name = "materialButtonAddText";
            this.materialButtonAddText.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddText.Size = new System.Drawing.Size(158, 36);
            this.materialButtonAddText.TabIndex = 9;
            this.materialButtonAddText.Text = "Add";
            this.materialButtonAddText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddText.UseAccentColor = false;
            this.materialButtonAddText.UseVisualStyleBackColor = false;
            this.materialButtonAddText.Click += new System.EventHandler(this.materialButtonAddText_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox5.Controls.Add(this.materialLabel2);
            this.groupBox5.Controls.Add(this.materialTextBoxText);
            this.groupBox5.Controls.Add(this.materialListBoxTempText);
            this.groupBox5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(254, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 457);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Temp";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(62, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Enter your text:";
            // 
            // materialTextBoxText
            // 
            this.materialTextBoxText.AnimateReadOnly = false;
            this.materialTextBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialTextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxText.Depth = 0;
            this.materialTextBoxText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBoxText.LeadingIcon = null;
            this.materialTextBoxText.Location = new System.Drawing.Point(48, 44);
            this.materialTextBoxText.MaxLength = 13;
            this.materialTextBoxText.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxText.Multiline = false;
            this.materialTextBoxText.Name = "materialTextBoxText";
            this.materialTextBoxText.Size = new System.Drawing.Size(138, 50);
            this.materialTextBoxText.TabIndex = 1;
            this.materialTextBoxText.Text = "";
            this.materialTextBoxText.TrailingIcon = null;
            this.materialTextBoxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialTextBoxText_KeyDown);
            this.materialTextBoxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxText_KeyPress);
            // 
            // materialListBoxTempText
            // 
            this.materialListBoxTempText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialListBoxTempText.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxTempText.Depth = 0;
            this.materialListBoxTempText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxTempText.Location = new System.Drawing.Point(7, 100);
            this.materialListBoxTempText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxTempText.Name = "materialListBoxTempText";
            this.materialListBoxTempText.SelectedIndex = -1;
            this.materialListBoxTempText.SelectedItem = null;
            this.materialListBoxTempText.Size = new System.Drawing.Size(229, 351);
            this.materialListBoxTempText.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.materialListBoxText);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 457);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Array";
            // 
            // materialListBoxText
            // 
            this.materialListBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialListBoxText.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxText.Depth = 0;
            this.materialListBoxText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxText.Location = new System.Drawing.Point(7, 26);
            this.materialListBoxText.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxText.Name = "materialListBoxText";
            this.materialListBoxText.SelectedIndex = -1;
            this.materialListBoxText.SelectedItem = null;
            this.materialListBoxText.Size = new System.Drawing.Size(229, 425);
            this.materialListBoxText.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(988, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 621);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 69, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Array";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButtonClearAllNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonCopyAllNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonSortLowNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonReplaceNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonInsertNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonFindNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonAddNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListBox materialListBoxNumber;
        private MaterialSkin.Controls.MaterialButton materialButtonSortHighNumber;
        private MaterialSkin.Controls.MaterialListBox materialListBoxTemp;
        private MaterialSkin.Controls.MaterialListBox materialListBoxText;
        private MaterialSkin.Controls.MaterialButton materialButtonClearAllText;
        private MaterialSkin.Controls.MaterialButton materialButtonCopyAllText;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteText;
        private MaterialSkin.Controls.MaterialButton materialButtonSortText;
        private MaterialSkin.Controls.MaterialButton materialButtonReplaceText;
        private MaterialSkin.Controls.MaterialButton materialButtonInsertText;
        private MaterialSkin.Controls.MaterialButton materialButtonFindText;
        private MaterialSkin.Controls.MaterialButton materialButtonAddText;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxText;
        private MaterialSkin.Controls.MaterialListBox materialListBoxTempText;
    }
}

