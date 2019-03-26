namespace FightingEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationRenderer1 = new FightingEditor.AnimationRenderer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeCollisions = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.HitPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HurtboxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chkProjectileImmune = new System.Windows.Forms.CheckBox();
            this.chkLowImmune = new System.Windows.Forms.CheckBox();
            this.chkThrowImmune = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHitResult = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericHitStop = new System.Windows.Forms.NumericUpDown();
            this.numericHitStun = new System.Windows.Forms.NumericUpDown();
            this.numericBlockStun = new System.Windows.Forms.NumericUpDown();
            this.numericDamage = new System.Windows.Forms.NumericUpDown();
            this.cmbHitType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbJuggleProperties = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelfCancel = new System.Windows.Forms.CheckBox();
            this.chkACancel = new System.Windows.Forms.CheckBox();
            this.chkBCancel = new System.Windows.Forms.CheckBox();
            this.chkCCancel = new System.Windows.Forms.CheckBox();
            this.chkSpecialCancel = new System.Windows.Forms.CheckBox();
            this.chkJumpCancel = new System.Windows.Forms.CheckBox();
            this.chkDashCancel = new System.Windows.Forms.CheckBox();
            this.chkUniqueActionCancel = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericLeft = new System.Windows.Forms.NumericUpDown();
            this.numericRight = new System.Windows.Forms.NumericUpDown();
            this.numericTop = new System.Windows.Forms.NumericUpDown();
            this.numericBottom = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.animScrub = new System.Windows.Forms.TrackBar();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.lStartupFrames = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lActiveFrames = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lOnHitFrames = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lOnBlockFrames = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lTotalFrames = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.HitPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.HurtboxPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHitStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHitStun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockStun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBottom)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animScrub)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.loadAnimationToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "New";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Open";
            // 
            // loadAnimationToolStripMenuItem
            // 
            this.loadAnimationToolStripMenuItem.Name = "loadAnimationToolStripMenuItem";
            this.loadAnimationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadAnimationToolStripMenuItem.Text = "Load Animation";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save / Export";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // animationRenderer1
            // 
            this.animationRenderer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationRenderer1.Location = new System.Drawing.Point(3, 3);
            this.animationRenderer1.Name = "animationRenderer1";
            this.animationRenderer1.Size = new System.Drawing.Size(1182, 621);
            this.animationRenderer1.TabIndex = 0;
            this.animationRenderer1.Text = "animationRenderer1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.animationRenderer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1584, 837);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.treeCollisions);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1191, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(390, 621);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collision Boxes";
            // 
            // treeCollisions
            // 
            this.treeCollisions.Location = new System.Drawing.Point(3, 16);
            this.treeCollisions.Name = "treeCollisions";
            this.treeCollisions.Size = new System.Drawing.Size(387, 365);
            this.treeCollisions.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Controls.Add(this.HitPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.HurtboxPanel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1191, 630);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(390, 204);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // HitPanel
            // 
            this.HitPanel.Controls.Add(this.label2);
            this.HitPanel.Controls.Add(this.tabControl1);
            this.HitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HitPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.HitPanel.Location = new System.Drawing.Point(3, 3);
            this.HitPanel.Name = "HitPanel";
            this.HitPanel.Size = new System.Drawing.Size(247, 198);
            this.HitPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hit Properties";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 179);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(236, 153);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hit Data 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HurtboxPanel
            // 
            this.HurtboxPanel.Controls.Add(this.label3);
            this.HurtboxPanel.Controls.Add(this.tableLayoutPanel5);
            this.HurtboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HurtboxPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.HurtboxPanel.Location = new System.Drawing.Point(256, 3);
            this.HurtboxPanel.Name = "HurtboxPanel";
            this.HurtboxPanel.Size = new System.Drawing.Size(131, 198);
            this.HurtboxPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hurtbox Properties";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chkProjectileImmune, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.chkLowImmune, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.chkThrowImmune, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(128, 179);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // chkProjectileImmune
            // 
            this.chkProjectileImmune.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkProjectileImmune.AutoSize = true;
            this.chkProjectileImmune.Location = new System.Drawing.Point(3, 6);
            this.chkProjectileImmune.Name = "chkProjectileImmune";
            this.chkProjectileImmune.Size = new System.Drawing.Size(113, 17);
            this.chkProjectileImmune.TabIndex = 1;
            this.chkProjectileImmune.Text = "Projectile Immunity";
            this.chkProjectileImmune.UseVisualStyleBackColor = true;
            // 
            // chkLowImmune
            // 
            this.chkLowImmune.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLowImmune.AutoSize = true;
            this.chkLowImmune.Location = new System.Drawing.Point(3, 35);
            this.chkLowImmune.Name = "chkLowImmune";
            this.chkLowImmune.Size = new System.Drawing.Size(90, 17);
            this.chkLowImmune.TabIndex = 2;
            this.chkLowImmune.Text = "Low Immunity";
            this.chkLowImmune.UseVisualStyleBackColor = true;
            // 
            // chkThrowImmune
            // 
            this.chkThrowImmune.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkThrowImmune.AutoSize = true;
            this.chkThrowImmune.Location = new System.Drawing.Point(3, 64);
            this.chkThrowImmune.Name = "chkThrowImmune";
            this.chkThrowImmune.Size = new System.Drawing.Size(100, 17);
            this.chkThrowImmune.TabIndex = 3;
            this.chkThrowImmune.Text = "Throw Immunity";
            this.chkThrowImmune.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmbHitResult, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.cmbJuggleProperties, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(230, 147);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hit Result";
            // 
            // cmbHitResult
            // 
            this.cmbHitResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHitResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHitResult.FormattingEnabled = true;
            this.cmbHitResult.Items.AddRange(new object[] {
            "Normal",
            "Knockdown",
            "Launch Low",
            "Launch Mid",
            "Launch High",
            "Wall Bounce",
            "Ground Bounce"});
            this.cmbHitResult.Location = new System.Drawing.Point(100, 4);
            this.cmbHitResult.Name = "cmbHitResult";
            this.cmbHitResult.Size = new System.Drawing.Size(121, 21);
            this.cmbHitResult.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hit Data 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.numericHitStop, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.numericHitStun, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.numericBlockStun, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.numericDamage, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.cmbHitType, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(230, 147);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hit Stop";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hit Stun";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Block Stun";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Damage";
            // 
            // numericHitStop
            // 
            this.numericHitStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericHitStop.Location = new System.Drawing.Point(103, 33);
            this.numericHitStop.Name = "numericHitStop";
            this.numericHitStop.Size = new System.Drawing.Size(116, 20);
            this.numericHitStop.TabIndex = 9;
            // 
            // numericHitStun
            // 
            this.numericHitStun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericHitStun.Location = new System.Drawing.Point(103, 62);
            this.numericHitStun.Name = "numericHitStun";
            this.numericHitStun.Size = new System.Drawing.Size(116, 20);
            this.numericHitStun.TabIndex = 10;
            // 
            // numericBlockStun
            // 
            this.numericBlockStun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericBlockStun.Location = new System.Drawing.Point(103, 91);
            this.numericBlockStun.Name = "numericBlockStun";
            this.numericBlockStun.Size = new System.Drawing.Size(116, 20);
            this.numericBlockStun.TabIndex = 11;
            // 
            // numericDamage
            // 
            this.numericDamage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericDamage.Location = new System.Drawing.Point(103, 121);
            this.numericDamage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericDamage.Name = "numericDamage";
            this.numericDamage.Size = new System.Drawing.Size(116, 20);
            this.numericDamage.TabIndex = 12;
            // 
            // cmbHitType
            // 
            this.cmbHitType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHitType.FormattingEnabled = true;
            this.cmbHitType.Items.AddRange(new object[] {
            "High",
            "Mid",
            "Low",
            "Throw",
            "Projectile",
            "Unblockable"});
            this.cmbHitType.Location = new System.Drawing.Point(103, 4);
            this.cmbHitType.Name = "cmbHitType";
            this.cmbHitType.Size = new System.Drawing.Size(116, 21);
            this.cmbHitType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hit Type";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Juggle\r\n";
            // 
            // cmbJuggleProperties
            // 
            this.cmbJuggleProperties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbJuggleProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuggleProperties.FormattingEnabled = true;
            this.cmbJuggleProperties.Items.AddRange(new object[] {
            "No Juggle",
            "Resets",
            "Can Juggle"});
            this.cmbJuggleProperties.Location = new System.Drawing.Point(100, 33);
            this.cmbJuggleProperties.Name = "cmbJuggleProperties";
            this.cmbJuggleProperties.Size = new System.Drawing.Size(121, 21);
            this.cmbJuggleProperties.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 153);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Cancels";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.chkSelfCancel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.chkACancel, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.chkBCancel, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.chkCCancel, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.chkSpecialCancel, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.chkJumpCancel, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.chkDashCancel, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.chkUniqueActionCancel, 1, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(230, 147);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // chkSelfCancel
            // 
            this.chkSelfCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkSelfCancel.AutoSize = true;
            this.chkSelfCancel.Location = new System.Drawing.Point(17, 9);
            this.chkSelfCancel.Name = "chkSelfCancel";
            this.chkSelfCancel.Size = new System.Drawing.Size(80, 17);
            this.chkSelfCancel.TabIndex = 0;
            this.chkSelfCancel.Text = "Self Cancel";
            this.chkSelfCancel.UseVisualStyleBackColor = true;
            // 
            // chkACancel
            // 
            this.chkACancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkACancel.AutoSize = true;
            this.chkACancel.Location = new System.Drawing.Point(23, 45);
            this.chkACancel.Name = "chkACancel";
            this.chkACancel.Size = new System.Drawing.Size(69, 17);
            this.chkACancel.TabIndex = 1;
            this.chkACancel.Text = "A Cancel";
            this.chkACancel.UseVisualStyleBackColor = true;
            // 
            // chkBCancel
            // 
            this.chkBCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBCancel.AutoSize = true;
            this.chkBCancel.Location = new System.Drawing.Point(23, 81);
            this.chkBCancel.Name = "chkBCancel";
            this.chkBCancel.Size = new System.Drawing.Size(69, 17);
            this.chkBCancel.TabIndex = 2;
            this.chkBCancel.Text = "B Cancel";
            this.chkBCancel.UseVisualStyleBackColor = true;
            // 
            // chkCCancel
            // 
            this.chkCCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkCCancel.AutoSize = true;
            this.chkCCancel.Location = new System.Drawing.Point(23, 119);
            this.chkCCancel.Name = "chkCCancel";
            this.chkCCancel.Size = new System.Drawing.Size(69, 17);
            this.chkCCancel.TabIndex = 3;
            this.chkCCancel.Text = "C Cancel";
            this.chkCCancel.UseVisualStyleBackColor = true;
            // 
            // chkSpecialCancel
            // 
            this.chkSpecialCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkSpecialCancel.AutoSize = true;
            this.chkSpecialCancel.Location = new System.Drawing.Point(124, 9);
            this.chkSpecialCancel.Name = "chkSpecialCancel";
            this.chkSpecialCancel.Size = new System.Drawing.Size(97, 17);
            this.chkSpecialCancel.TabIndex = 4;
            this.chkSpecialCancel.Text = "Special Cancel";
            this.chkSpecialCancel.UseVisualStyleBackColor = true;
            // 
            // chkJumpCancel
            // 
            this.chkJumpCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkJumpCancel.AutoSize = true;
            this.chkJumpCancel.Location = new System.Drawing.Point(129, 45);
            this.chkJumpCancel.Name = "chkJumpCancel";
            this.chkJumpCancel.Size = new System.Drawing.Size(87, 17);
            this.chkJumpCancel.TabIndex = 5;
            this.chkJumpCancel.Text = "Jump Cancel";
            this.chkJumpCancel.UseVisualStyleBackColor = true;
            // 
            // chkDashCancel
            // 
            this.chkDashCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkDashCancel.AutoSize = true;
            this.chkDashCancel.Location = new System.Drawing.Point(129, 81);
            this.chkDashCancel.Name = "chkDashCancel";
            this.chkDashCancel.Size = new System.Drawing.Size(87, 17);
            this.chkDashCancel.TabIndex = 6;
            this.chkDashCancel.Text = "Dash Cancel";
            this.chkDashCancel.UseVisualStyleBackColor = true;
            // 
            // chkUniqueActionCancel
            // 
            this.chkUniqueActionCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkUniqueActionCancel.AutoSize = true;
            this.chkUniqueActionCancel.Location = new System.Drawing.Point(119, 119);
            this.chkUniqueActionCancel.Name = "chkUniqueActionCancel";
            this.chkUniqueActionCancel.Size = new System.Drawing.Size(107, 17);
            this.chkUniqueActionCancel.TabIndex = 7;
            this.chkUniqueActionCancel.Text = "Unq Actn Cancel";
            this.chkUniqueActionCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Location = new System.Drawing.Point(3, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 234);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.numericLeft, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.numericRight, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.numericTop, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.numericBottom, 2, 4);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(387, 231);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(3, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Root Hitbox";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(131, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Hitbox";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(260, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Hitbox";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(3, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Root Hurtbox";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(131, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Hurtbox";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(260, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete Hurtbox";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Top Left";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Bottom Right";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "X";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Y";
            // 
            // numericLeft
            // 
            this.numericLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericLeft.Location = new System.Drawing.Point(132, 151);
            this.numericLeft.Name = "numericLeft";
            this.numericLeft.Size = new System.Drawing.Size(120, 20);
            this.numericLeft.TabIndex = 10;
            // 
            // numericRight
            // 
            this.numericRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericRight.Location = new System.Drawing.Point(132, 197);
            this.numericRight.Name = "numericRight";
            this.numericRight.Size = new System.Drawing.Size(120, 20);
            this.numericRight.TabIndex = 11;
            // 
            // numericTop
            // 
            this.numericTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTop.Location = new System.Drawing.Point(262, 151);
            this.numericTop.Name = "numericTop";
            this.numericTop.Size = new System.Drawing.Size(120, 20);
            this.numericTop.TabIndex = 12;
            // 
            // numericBottom
            // 
            this.numericBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericBottom.Location = new System.Drawing.Point(262, 197);
            this.numericBottom.Name = "numericBottom";
            this.numericBottom.Size = new System.Drawing.Size(120, 20);
            this.numericBottom.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFirst);
            this.flowLayoutPanel1.Controls.Add(this.btnPrevious);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnLast);
            this.flowLayoutPanel1.Controls.Add(this.btnPlayPause);
            this.flowLayoutPanel1.Controls.Add(this.animScrub);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1176, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // animScrub
            // 
            this.animScrub.Location = new System.Drawing.Point(417, 3);
            this.animScrub.Name = "animScrub";
            this.animScrub.Size = new System.Drawing.Size(755, 45);
            this.animScrub.TabIndex = 5;
            this.animScrub.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(327, 3);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(84, 28);
            this.btnPlayPause.TabIndex = 4;
            this.btnPlayPause.Text = "Play / Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(246, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 28);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(165, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(84, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 28);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 28);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 630);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1182, 204);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.62925F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.98299F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30272F));
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel3, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1176, 147);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label15);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel10);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(951, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(222, 141);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Frame Data";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.lTotalFrames, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.lOnBlockFrames, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.lOnHitFrames, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.lActiveFrames, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.lStartupFrames, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 5;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(218, 121);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Start Up";
            // 
            // lStartupFrames
            // 
            this.lStartupFrames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lStartupFrames.AutoSize = true;
            this.lStartupFrames.Location = new System.Drawing.Point(112, 5);
            this.lStartupFrames.Name = "lStartupFrames";
            this.lStartupFrames.Size = new System.Drawing.Size(25, 13);
            this.lStartupFrames.TabIndex = 1;
            this.lStartupFrames.Text = "???";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Active";
            // 
            // lActiveFrames
            // 
            this.lActiveFrames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lActiveFrames.AutoSize = true;
            this.lActiveFrames.Location = new System.Drawing.Point(112, 29);
            this.lActiveFrames.Name = "lActiveFrames";
            this.lActiveFrames.Size = new System.Drawing.Size(25, 13);
            this.lActiveFrames.TabIndex = 3;
            this.lActiveFrames.Text = "???";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "On Hit";
            // 
            // lOnHitFrames
            // 
            this.lOnHitFrames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lOnHitFrames.AutoSize = true;
            this.lOnHitFrames.Location = new System.Drawing.Point(112, 53);
            this.lOnHitFrames.Name = "lOnHitFrames";
            this.lOnHitFrames.Size = new System.Drawing.Size(25, 13);
            this.lOnHitFrames.TabIndex = 5;
            this.lOnHitFrames.Text = "???";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "On Block";
            // 
            // lOnBlockFrames
            // 
            this.lOnBlockFrames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lOnBlockFrames.AutoSize = true;
            this.lOnBlockFrames.Location = new System.Drawing.Point(112, 77);
            this.lOnBlockFrames.Name = "lOnBlockFrames";
            this.lOnBlockFrames.Size = new System.Drawing.Size(25, 13);
            this.lOnBlockFrames.TabIndex = 7;
            this.lOnBlockFrames.Text = "???";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 102);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Total Frames";
            // 
            // lTotalFrames
            // 
            this.lTotalFrames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lTotalFrames.AutoSize = true;
            this.lTotalFrames.Location = new System.Drawing.Point(112, 102);
            this.lTotalFrames.Name = "lTotalFrames";
            this.lTotalFrames.Size = new System.Drawing.Size(25, 13);
            this.lTotalFrames.TabIndex = 9;
            this.lTotalFrames.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fighting Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.HitPanel.ResumeLayout(false);
            this.HitPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.HurtboxPanel.ResumeLayout(false);
            this.HurtboxPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHitStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHitStun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockStun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBottom)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animScrub)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnimationToolStripMenuItem;
        private AnimationRenderer animationRenderer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeCollisions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel HitPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel HurtboxPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkProjectileImmune;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox chkLowImmune;
        private System.Windows.Forms.CheckBox chkThrowImmune;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericHitStop;
        private System.Windows.Forms.NumericUpDown numericHitStun;
        private System.Windows.Forms.NumericUpDown numericBlockStun;
        private System.Windows.Forms.NumericUpDown numericDamage;
        private System.Windows.Forms.ComboBox cmbHitType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHitResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbJuggleProperties;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.CheckBox chkSelfCancel;
        private System.Windows.Forms.CheckBox chkACancel;
        private System.Windows.Forms.CheckBox chkBCancel;
        private System.Windows.Forms.CheckBox chkCCancel;
        private System.Windows.Forms.CheckBox chkSpecialCancel;
        private System.Windows.Forms.CheckBox chkJumpCancel;
        private System.Windows.Forms.CheckBox chkDashCancel;
        private System.Windows.Forms.CheckBox chkUniqueActionCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericLeft;
        private System.Windows.Forms.NumericUpDown numericRight;
        private System.Windows.Forms.NumericUpDown numericTop;
        private System.Windows.Forms.NumericUpDown numericBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar animScrub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lTotalFrames;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lOnBlockFrames;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lOnHitFrames;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lActiveFrames;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lStartupFrames;
        private System.Windows.Forms.Label label16;
    }
}

