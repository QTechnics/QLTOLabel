namespace QLTOLabel
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listboxLabel = new DevExpress.XtraEditors.ListBoxControl();
            this.txtLabel = new DevExpress.XtraEditors.TextEdit();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRemove = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spWidth = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spHeight = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxLabel
            // 
            this.listboxLabel.Location = new System.Drawing.Point(13, 66);
            this.listboxLabel.Name = "listboxLabel";
            this.listboxLabel.Size = new System.Drawing.Size(243, 281);
            this.listboxLabel.TabIndex = 0;
            this.listboxLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listboxLabel_KeyDown);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(13, 12);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(126, 20);
            this.txtLabel.TabIndex = 1;
            this.txtLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLabel_KeyDown);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
            this.cmdAdd.Location = new System.Drawing.Point(201, 12);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(25, 20);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Image = ((System.Drawing.Image)(resources.GetObject("cmdRemove.Image")));
            this.cmdRemove.Location = new System.Drawing.Point(231, 12);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(25, 20);
            this.cmdRemove.TabIndex = 3;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.Location = new System.Drawing.Point(231, 40);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(25, 20);
            this.cmdPrint.TabIndex = 4;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cbType
            // 
            this.cbType.Location = new System.Drawing.Point(148, 12);
            this.cbType.Name = "cbType";
            this.cbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbType.Properties.Items.AddRange(new object[] {
            "CU - Universal Cleaning Cartridge",
            "C1 - Generation 1 Cleaning Cartridge",
            "C2 - Generation 2 Cleaning Cartridge",
            "C3 - Generation 3 Cleaning Cartridge",
            "C4 - Generation 4 Cleaning Cartridge",
            "C5 - Generation 5 Cleaning Cartridge",
            "L1 - Generation 1 Type A - 100 GB",
            "LA - Generation 1 Type B - 50 GB",
            "LB - Generation 1 Type C - 30 GB",
            "LC - Generation 1 Type D - 10 GB",
            "L2 - Generation 2 Type A - 200 GB",
            "L3 - Generation 3 Type A - 400 GB",
            "L4 - Generation 4 Type A - 800 GB",
            "L5 - Generation 5 Type A - 1500 GB",
            "L6 - Generation 6 Type A - 2500 GB",
            "L7 - Generation 7 Type A - Future definition",
            "L8 - Generation 8 Type A - Future definition",
            "L9 - Generation 9 Type A - Future definition",
            "LD - Future definition",
            "LE - Future definition",
            "LF - Future definition",
            "LG - Future definition",
            "LH - Future definition",
            "LI - Not used",
            "LJ - Future definition",
            "LK - Future definition",
            "LL - Future definition",
            "LM - Future definition",
            "LN - Future definition",
            "LO - Not used",
            "LP - Future definition",
            "LQ - Not used",
            "LR - Generation 1 Worm - 100 GB",
            "LS - Generation 2 Worm - 200 GB",
            "LT - Generation 3 Worm - 400 GB",
            "LU - Generation 4 Worm - 800 GB",
            "LV - Generation 5 Worm - 1500 GB",
            "LW - Generation 6 Worm - 2500 GB",
            "LX - Generation 7 Worm - Future definition",
            "LY - Generation 8 Worm - Future definition",
            "LZ - Generation 9 Worm - Future definition"});
            this.cbType.Size = new System.Drawing.Size(47, 20);
            this.cbType.TabIndex = 5;
            // 
            // spWidth
            // 
            this.spWidth.EditValue = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.spWidth.Location = new System.Drawing.Point(36, 40);
            this.spWidth.Name = "spWidth";
            this.spWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spWidth.Size = new System.Drawing.Size(77, 20);
            this.spWidth.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "W :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(125, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "H :";
            // 
            // spHeight
            // 
            this.spHeight.EditValue = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.spHeight.Location = new System.Drawing.Point(148, 40);
            this.spHeight.Name = "spHeight";
            this.spHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeight.Properties.DisplayFormat.FormatString = "n0";
            this.spHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spHeight.Properties.EditFormat.FormatString = "n0";
            this.spHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spHeight.Size = new System.Drawing.Size(77, 20);
            this.spHeight.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 361);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spHeight);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.spWidth);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.listboxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTOLabel - IBM LTO Barcode Label Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.listboxLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeight.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listboxLabel;
        private DevExpress.XtraEditors.TextEdit txtLabel;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.SimpleButton cmdRemove;
        private DevExpress.XtraEditors.SimpleButton cmdPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cbType;
        private DevExpress.XtraEditors.SpinEdit spWidth;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spHeight;
    }
}