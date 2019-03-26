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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextCharacterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumericJumpBX = new System.Windows.Forms.NumericUpDown();
            this.NumericJumpBY = new System.Windows.Forms.NumericUpDown();
            this.NumericJumpFY = new System.Windows.Forms.NumericUpDown();
            this.NumericJumpUY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NumericJumpFX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericJumpUX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericWalkBackward = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericWalkForward = new System.Windows.Forms.NumericUpDown();
            this.NumericHP = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.TreeAnimData = new System.Windows.Forms.TreeView();
            this.MonoRender = new FightingEditor.AnimationRenderer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.TreeBoxes = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpFY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpUY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpUX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWalkBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWalkForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHP)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openToolStripMenuItem.Text = "New";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.closeToolStripMenuItem.Text = "Open";
            // 
            // loadAnimationToolStripMenuItem
            // 
            this.loadAnimationToolStripMenuItem.Name = "loadAnimationToolStripMenuItem";
            this.loadAnimationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadAnimationToolStripMenuItem.Text = "Load Animation";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveToolStripMenuItem.Text = "Save / Export";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1584, 837);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1576, 811);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.TextCharacterName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.NumericJumpBX, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.NumericJumpBY, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.NumericJumpFY, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.NumericJumpUY, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.NumericJumpFX, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.NumericJumpUX, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.NumericWalkBackward, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NumericWalkForward, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NumericHP, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1576, 811);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextCharacterName
            // 
            this.TextCharacterName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextCharacterName.Location = new System.Drawing.Point(160, 10);
            this.TextCharacterName.MaxLength = 35;
            this.TextCharacterName.Name = "TextCharacterName";
            this.TextCharacterName.Size = new System.Drawing.Size(151, 20);
            this.TextCharacterName.TabIndex = 0;
            this.TextCharacterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "HP";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jump Backward";
            // 
            // NumericJumpBX
            // 
            this.NumericJumpBX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericJumpBX.Location = new System.Drawing.Point(160, 330);
            this.NumericJumpBX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericJumpBX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NumericJumpBX.Name = "NumericJumpBX";
            this.NumericJumpBX.Size = new System.Drawing.Size(120, 20);
            this.NumericJumpBX.TabIndex = 13;
            // 
            // NumericJumpBY
            // 
            this.NumericJumpBY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericJumpBY.Location = new System.Drawing.Point(317, 330);
            this.NumericJumpBY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericJumpBY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericJumpBY.Name = "NumericJumpBY";
            this.NumericJumpBY.Size = new System.Drawing.Size(120, 20);
            this.NumericJumpBY.TabIndex = 16;
            this.NumericJumpBY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericJumpFY
            // 
            this.NumericJumpFY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericJumpFY.Location = new System.Drawing.Point(317, 290);
            this.NumericJumpFY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericJumpFY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericJumpFY.Name = "NumericJumpFY";
            this.NumericJumpFY.Size = new System.Drawing.Size(120, 20);
            this.NumericJumpFY.TabIndex = 15;
            this.NumericJumpFY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericJumpUY
            // 
            this.NumericJumpUY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericJumpUY.Location = new System.Drawing.Point(317, 250);
            this.NumericJumpUY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericJumpUY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericJumpUY.Name = "NumericJumpUY";
            this.NumericJumpUY.Size = new System.Drawing.Size(120, 20);
            this.NumericJumpUY.TabIndex = 14;
            this.NumericJumpUY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y";
            // 
            // NumericJumpFX
            // 
            this.NumericJumpFX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericJumpFX.Location = new System.Drawing.Point(160, 290);
            this.NumericJumpFX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericJumpFX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NumericJumpFX.Name = "NumericJumpFX";
            this.NumericJumpFX.Size = new System.Drawing.Size(120, 20);
            this.NumericJumpFX.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jump Forward";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jump Up";
            // 
            // NumericJumpUX
            // 
            this.NumericJumpUX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericJumpUX.Location = new System.Drawing.Point(160, 250);
            this.NumericJumpUX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericJumpUX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NumericJumpUX.Name = "NumericJumpUX";
            this.NumericJumpUX.Size = new System.Drawing.Size(120, 20);
            this.NumericJumpUX.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "X";
            // 
            // NumericWalkBackward
            // 
            this.NumericWalkBackward.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericWalkBackward.Location = new System.Drawing.Point(160, 170);
            this.NumericWalkBackward.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericWalkBackward.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericWalkBackward.Name = "NumericWalkBackward";
            this.NumericWalkBackward.Size = new System.Drawing.Size(120, 20);
            this.NumericWalkBackward.TabIndex = 10;
            this.NumericWalkBackward.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericWalkBackward.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Walk Backward Speed";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Walk Forward Speed";
            // 
            // NumericWalkForward
            // 
            this.NumericWalkForward.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericWalkForward.Location = new System.Drawing.Point(160, 130);
            this.NumericWalkForward.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericWalkForward.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericWalkForward.Name = "NumericWalkForward";
            this.NumericWalkForward.Size = new System.Drawing.Size(120, 20);
            this.NumericWalkForward.TabIndex = 9;
            this.NumericWalkForward.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericHP
            // 
            this.NumericHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumericHP.Location = new System.Drawing.Point(160, 50);
            this.NumericHP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericHP.Name = "NumericHP";
            this.NumericHP.Size = new System.Drawing.Size(120, 20);
            this.NumericHP.TabIndex = 18;
            this.NumericHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1576, 811);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animation Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MonoRender, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1576, 811);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 534);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.TreeAnimData);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(309, 534);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "AnimationTree";
            // 
            // TreeAnimData
            // 
            this.TreeAnimData.Location = new System.Drawing.Point(3, 16);
            this.TreeAnimData.Name = "TreeAnimData";
            this.TreeAnimData.Size = new System.Drawing.Size(303, 515);
            this.TreeAnimData.TabIndex = 1;
            // 
            // MonoRender
            // 
            this.MonoRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonoRender.Location = new System.Drawing.Point(318, 3);
            this.MonoRender.Name = "MonoRender";
            this.MonoRender.Size = new System.Drawing.Size(1018, 534);
            this.MonoRender.TabIndex = 1;
            this.MonoRender.Text = "animationRenderer1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.TreeBoxes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1342, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 534);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Collision Box Tree";
            // 
            // TreeBoxes
            // 
            this.TreeBoxes.Location = new System.Drawing.Point(3, 16);
            this.TreeBoxes.Name = "TreeBoxes";
            this.TreeBoxes.Size = new System.Drawing.Size(223, 515);
            this.TreeBoxes.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1342, 543);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(231, 265);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Box Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fighting Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpFY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpUY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJumpUX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWalkBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWalkForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextCharacterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loadAnimationToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericWalkForward;
        private System.Windows.Forms.NumericUpDown NumericWalkBackward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericJumpBX;
        private System.Windows.Forms.NumericUpDown NumericJumpBY;
        private System.Windows.Forms.NumericUpDown NumericJumpFY;
        private System.Windows.Forms.NumericUpDown NumericJumpUY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumericJumpFX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericJumpUX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumericHP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView TreeAnimData;
        private AnimationRenderer MonoRender;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView TreeBoxes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label12;
    }
}

