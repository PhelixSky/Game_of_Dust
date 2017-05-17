namespace Game_of_Dust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbTool = new System.Windows.Forms.ComboBox();
            this.WaterBut = new System.Windows.Forms.RadioButton();
            this.WallBut = new System.Windows.Forms.RadioButton();
            this.SandBut = new System.Windows.Forms.RadioButton();
            this.DustTypeLabel = new System.Windows.Forms.Label();
            this.LiquidTypeLabel = new System.Windows.Forms.Label();
            this.SolidTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SoPen = new System.Windows.Forms.NumericUpDown();
            this.EraserBut = new System.Windows.Forms.RadioButton();
            this.AsidBut = new System.Windows.Forms.RadioButton();
            this.CmntBut = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Label();
            this.pnSandbox = new Game_of_Dust.SandboxPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SoPen)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTool
            // 
            this.cbTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTool.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTool.FormattingEnabled = true;
            this.cbTool.Items.AddRange(new object[] {
            "Sand",
            "Solid",
            "Water"});
            this.cbTool.Location = new System.Drawing.Point(608, 428);
            this.cbTool.Name = "cbTool";
            this.cbTool.Size = new System.Drawing.Size(38, 21);
            this.cbTool.TabIndex = 1;
            this.cbTool.Visible = false;
            this.cbTool.SelectedIndexChanged += new System.EventHandler(this.cbTool_SelectedIndexChanged);
            // 
            // WaterBut
            // 
            this.WaterBut.AutoSize = true;
            this.WaterBut.BackColor = System.Drawing.Color.Blue;
            this.WaterBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WaterBut.Location = new System.Drawing.Point(71, 469);
            this.WaterBut.Name = "WaterBut";
            this.WaterBut.Size = new System.Drawing.Size(62, 19);
            this.WaterBut.TabIndex = 0;
            this.WaterBut.TabStop = true;
            this.WaterBut.Text = "WATER";
            this.WaterBut.UseVisualStyleBackColor = false;
            this.WaterBut.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SandBut_ControlAdded);
            // 
            // WallBut
            // 
            this.WallBut.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.WallBut.AutoSize = true;
            this.WallBut.BackColor = System.Drawing.Color.Gray;
            this.WallBut.Location = new System.Drawing.Point(139, 469);
            this.WallBut.Name = "WallBut";
            this.WallBut.Size = new System.Drawing.Size(43, 19);
            this.WallBut.TabIndex = 0;
            this.WallBut.TabStop = true;
            this.WallBut.Text = "Wall";
            this.WallBut.UseVisualStyleBackColor = false;
            this.WallBut.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SandBut_ControlAdded);
            // 
            // SandBut
            // 
            this.SandBut.AutoSize = true;
            this.SandBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SandBut.Location = new System.Drawing.Point(12, 469);
            this.SandBut.Name = "SandBut";
            this.SandBut.Size = new System.Drawing.Size(53, 19);
            this.SandBut.TabIndex = 0;
            this.SandBut.TabStop = true;
            this.SandBut.Text = "SAND";
            this.SandBut.UseVisualStyleBackColor = false;
            this.SandBut.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SandBut_ControlAdded);
            // 
            // DustTypeLabel
            // 
            this.DustTypeLabel.AutoSize = true;
            this.DustTypeLabel.ForeColor = System.Drawing.Color.Coral;
            this.DustTypeLabel.Location = new System.Drawing.Point(608, 41);
            this.DustTypeLabel.Name = "DustTypeLabel";
            this.DustTypeLabel.Size = new System.Drawing.Size(31, 15);
            this.DustTypeLabel.TabIndex = 4;
            this.DustTypeLabel.Text = "Dust";
            this.DustTypeLabel.MouseHover += new System.EventHandler(this.DustTypeLabel_MouseHover);
            // 
            // LiquidTypeLabel
            // 
            this.LiquidTypeLabel.AutoSize = true;
            this.LiquidTypeLabel.ForeColor = System.Drawing.Color.Coral;
            this.LiquidTypeLabel.Location = new System.Drawing.Point(608, 65);
            this.LiquidTypeLabel.Name = "LiquidTypeLabel";
            this.LiquidTypeLabel.Size = new System.Drawing.Size(37, 15);
            this.LiquidTypeLabel.TabIndex = 5;
            this.LiquidTypeLabel.Text = "Liquids";
            this.LiquidTypeLabel.MouseHover += new System.EventHandler(this.LiquidTypeLabel_MouseHover);
            // 
            // SolidTypeLabel
            // 
            this.SolidTypeLabel.AutoSize = true;
            this.SolidTypeLabel.ForeColor = System.Drawing.Color.Coral;
            this.SolidTypeLabel.Location = new System.Drawing.Point(608, 92);
            this.SolidTypeLabel.Name = "SolidTypeLabel";
            this.SolidTypeLabel.Size = new System.Drawing.Size(27, 15);
            this.SolidTypeLabel.TabIndex = 6;
            this.SolidTypeLabel.Text = "Solid";
            this.SolidTypeLabel.MouseHover += new System.EventHandler(this.SolidTypeLabel_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "FPS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SoPen
            // 
            this.SoPen.Location = new System.Drawing.Point(595, 469);
            this.SoPen.Name = "SoPen";
            this.SoPen.Size = new System.Drawing.Size(51, 23);
            this.SoPen.TabIndex = 8;
            this.SoPen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SoPen.ValueChanged += new System.EventHandler(this.SoPen_ValueChanged);
            // 
            // EraserBut
            // 
            this.EraserBut.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.EraserBut.AutoSize = true;
            this.EraserBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EraserBut.Location = new System.Drawing.Point(580, 525);
            this.EraserBut.Name = "EraserBut";
            this.EraserBut.Size = new System.Drawing.Size(58, 19);
            this.EraserBut.TabIndex = 0;
            this.EraserBut.TabStop = true;
            this.EraserBut.Text = "Eraser";
            this.EraserBut.UseVisualStyleBackColor = false;
            this.EraserBut.Visible = false;
            this.EraserBut.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SandBut_ControlAdded);
            // 
            // AsidBut
            // 
            this.AsidBut.AutoSize = true;
            this.AsidBut.BackColor = System.Drawing.Color.GreenYellow;
            this.AsidBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AsidBut.Location = new System.Drawing.Point(71, 494);
            this.AsidBut.Name = "AsidBut";
            this.AsidBut.Size = new System.Drawing.Size(52, 19);
            this.AsidBut.TabIndex = 0;
            this.AsidBut.TabStop = true;
            this.AsidBut.Text = "ASID";
            this.AsidBut.UseVisualStyleBackColor = false;
            this.AsidBut.Visible = false;
            this.AsidBut.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SandBut_ControlAdded);
            // 
            // CmntBut
            // 
            this.CmntBut.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.CmntBut.AutoSize = true;
            this.CmntBut.BackColor = System.Drawing.Color.Silver;
            this.CmntBut.Location = new System.Drawing.Point(12, 494);
            this.CmntBut.Name = "CmntBut";
            this.CmntBut.Size = new System.Drawing.Size(51, 19);
            this.CmntBut.TabIndex = 0;
            this.CmntBut.TabStop = true;
            this.CmntBut.Text = "Foam";
            this.CmntBut.UseVisualStyleBackColor = false;
            this.CmntBut.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SandBut_ControlAdded);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CLS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.ForeColor = System.Drawing.Color.Coral;
            this.All.Location = new System.Drawing.Point(605, 122);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(37, 15);
            this.All.TabIndex = 6;
            this.All.Text = "See All";
            this.All.MouseHover += new System.EventHandler(this.All_MouseHover);
            // 
            // pnSandbox
            // 
            this.pnSandbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSandbox.BackColor = System.Drawing.Color.Black;
            this.pnSandbox.FrameCounter = 0;
            this.pnSandbox.Location = new System.Drawing.Point(2, 1);
            this.pnSandbox.MaximumSize = new System.Drawing.Size(600, 462);
            this.pnSandbox.MinimumSize = new System.Drawing.Size(600, 462);
            this.pnSandbox.Name = "pnSandbox";
            this.pnSandbox.Sandbox = null;
            this.pnSandbox.Size = new System.Drawing.Size(600, 462);
            this.pnSandbox.TabIndex = 0;
            this.pnSandbox.Load += new System.EventHandler(this.pnSandbox_Load);
            this.pnSandbox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnSandbox_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(650, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SoPen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EraserBut);
            this.Controls.Add(this.CmntBut);
            this.Controls.Add(this.WallBut);
            this.Controls.Add(this.AsidBut);
            this.Controls.Add(this.WaterBut);
            this.Controls.Add(this.SandBut);
            this.Controls.Add(this.All);
            this.Controls.Add(this.SolidTypeLabel);
            this.Controls.Add(this.LiquidTypeLabel);
            this.Controls.Add(this.DustTypeLabel);
            this.Controls.Add(this.cbTool);
            this.Controls.Add(this.pnSandbox);
            this.Font = new System.Drawing.Font("Lindsey", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Game of Dust";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SandboxPanel pnSandbox;
        private System.Windows.Forms.ComboBox cbTool;
        private System.Windows.Forms.Label DustTypeLabel;
        private System.Windows.Forms.Label LiquidTypeLabel;
        private System.Windows.Forms.Label SolidTypeLabel;
        private System.Windows.Forms.RadioButton WaterBut;
        private System.Windows.Forms.RadioButton WallBut;
        private System.Windows.Forms.RadioButton SandBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SoPen;
        private System.Windows.Forms.RadioButton EraserBut;
        private System.Windows.Forms.RadioButton AsidBut;
        private System.Windows.Forms.RadioButton CmntBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label All;





    }
}

