namespace Billes_Verden
{
    partial class WinForm
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
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.controlPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.labelRows = new System.Windows.Forms.Label();
            this.NumericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.labelColumns = new System.Windows.Forms.Label();
            this.NumericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.randomPlacementPicker = new System.Windows.Forms.CheckBox();
            this.boardCanvas = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRedName = new System.Windows.Forms.Label();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenName = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueName = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            this.labelYellowName = new System.Windows.Forms.Label();
            this.labelYellowValue = new System.Windows.Forms.Label();
            this.labelGreyName = new System.Windows.Forms.Label();
            this.labelGreyValue = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer.SuspendLayout();
            this.controlPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardCanvas)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContainer.Controls.Add(this.controlPanelContainer, 0, 0);
            this.mainContainer.Controls.Add(this.boardCanvas, 0, 2);
            this.mainContainer.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 3;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainContainer.Size = new System.Drawing.Size(778, 794);
            this.mainContainer.TabIndex = 0;
            // 
            // controlPanelContainer
            // 
            this.controlPanelContainer.AutoSize = true;
            this.controlPanelContainer.Controls.Add(this.startButton);
            this.controlPanelContainer.Controls.Add(this.resetButton);
            this.controlPanelContainer.Controls.Add(this.labelRows);
            this.controlPanelContainer.Controls.Add(this.NumericUpDownRows);
            this.controlPanelContainer.Controls.Add(this.labelColumns);
            this.controlPanelContainer.Controls.Add(this.NumericUpDownColumns);
            this.controlPanelContainer.Controls.Add(this.randomPlacementPicker);
            this.controlPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanelContainer.Location = new System.Drawing.Point(3, 3);
            this.controlPanelContainer.Name = "controlPanelContainer";
            this.controlPanelContainer.Size = new System.Drawing.Size(772, 54);
            this.controlPanelContainer.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(81, 46);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(90, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 46);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // labelRows
            // 
            this.labelRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(189, 0);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(70, 52);
            this.labelRows.TabIndex = 21;
            this.labelRows.Text = "Rækker:";
            this.labelRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDownRows
            // 
            this.NumericUpDownRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericUpDownRows.AutoSize = true;
            this.NumericUpDownRows.Location = new System.Drawing.Point(265, 13);
            this.NumericUpDownRows.Name = "NumericUpDownRows";
            this.NumericUpDownRows.Size = new System.Drawing.Size(60, 26);
            this.NumericUpDownRows.TabIndex = 3;
            this.NumericUpDownRows.ValueChanged += new System.EventHandler(this.NumericUpDownRows_ValueChanged);
            // 
            // labelColumns
            // 
            this.labelColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(331, 0);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(53, 52);
            this.labelColumns.TabIndex = 23;
            this.labelColumns.Text = "Søjler:";
            this.labelColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDownColumns
            // 
            this.NumericUpDownColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericUpDownColumns.AutoSize = true;
            this.NumericUpDownColumns.Location = new System.Drawing.Point(390, 13);
            this.NumericUpDownColumns.Name = "NumericUpDownColumns";
            this.NumericUpDownColumns.Size = new System.Drawing.Size(60, 26);
            this.NumericUpDownColumns.TabIndex = 4;
            this.NumericUpDownColumns.ValueChanged += new System.EventHandler(this.NumericUpDownColumns_ValueChanged);
            // 
            // randomPlacementPicker
            // 
            this.randomPlacementPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.randomPlacementPicker.AutoSize = true;
            this.randomPlacementPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomPlacementPicker.Location = new System.Drawing.Point(456, 14);
            this.randomPlacementPicker.Name = "randomPlacementPicker";
            this.randomPlacementPicker.Size = new System.Drawing.Size(194, 24);
            this.randomPlacementPicker.TabIndex = 5;
            this.randomPlacementPicker.Text = "Tilfældig startplacering";
            this.randomPlacementPicker.UseVisualStyleBackColor = true;
            this.randomPlacementPicker.CheckedChanged += new System.EventHandler(this.RandomPlacementPicker_CheckedChanged);
            // 
            // boardCanvas
            // 
            this.boardCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.boardCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardCanvas.Location = new System.Drawing.Point(3, 103);
            this.boardCanvas.Name = "boardCanvas";
            this.boardCanvas.Size = new System.Drawing.Size(772, 688);
            this.boardCanvas.TabIndex = 18;
            this.boardCanvas.TabStop = false;
            this.boardCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardCanvas_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelRedName);
            this.flowLayoutPanel1.Controls.Add(this.labelRedValue);
            this.flowLayoutPanel1.Controls.Add(this.labelGreenName);
            this.flowLayoutPanel1.Controls.Add(this.labelGreenValue);
            this.flowLayoutPanel1.Controls.Add(this.labelBlueName);
            this.flowLayoutPanel1.Controls.Add(this.labelBlueValue);
            this.flowLayoutPanel1.Controls.Add(this.labelYellowName);
            this.flowLayoutPanel1.Controls.Add(this.labelYellowValue);
            this.flowLayoutPanel1.Controls.Add(this.labelGreyName);
            this.flowLayoutPanel1.Controls.Add(this.labelGreyValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 34);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // labelRedName
            // 
            this.labelRedName.AutoSize = true;
            this.labelRedName.Location = new System.Drawing.Point(3, 0);
            this.labelRedName.Name = "labelRedName";
            this.labelRedName.Size = new System.Drawing.Size(114, 20);
            this.labelRedName.TabIndex = 20;
            this.labelRedName.Text = "Røde knapper:";
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Location = new System.Drawing.Point(123, 0);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(18, 20);
            this.labelRedValue.TabIndex = 21;
            this.labelRedValue.Text = "0";
            // 
            // labelGreenName
            // 
            this.labelGreenName.AutoSize = true;
            this.labelGreenName.Location = new System.Drawing.Point(147, 0);
            this.labelGreenName.Name = "labelGreenName";
            this.labelGreenName.Size = new System.Drawing.Size(129, 20);
            this.labelGreenName.TabIndex = 22;
            this.labelGreenName.Text = "Grønne knapper:";
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Location = new System.Drawing.Point(282, 0);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(18, 20);
            this.labelGreenValue.TabIndex = 23;
            this.labelGreenValue.Text = "0";
            // 
            // labelBlueName
            // 
            this.labelBlueName.AutoSize = true;
            this.labelBlueName.Location = new System.Drawing.Point(306, 0);
            this.labelBlueName.Name = "labelBlueName";
            this.labelBlueName.Size = new System.Drawing.Size(98, 20);
            this.labelBlueName.TabIndex = 24;
            this.labelBlueName.Text = "Blå knapper:";
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Location = new System.Drawing.Point(410, 0);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(18, 20);
            this.labelBlueValue.TabIndex = 25;
            this.labelBlueValue.Text = "0";
            // 
            // labelYellowName
            // 
            this.labelYellowName.AutoSize = true;
            this.labelYellowName.Location = new System.Drawing.Point(434, 0);
            this.labelYellowName.Name = "labelYellowName";
            this.labelYellowName.Size = new System.Drawing.Size(109, 20);
            this.labelYellowName.TabIndex = 26;
            this.labelYellowName.Text = "Gule knapper:";
            // 
            // labelYellowValue
            // 
            this.labelYellowValue.AutoSize = true;
            this.labelYellowValue.Location = new System.Drawing.Point(549, 0);
            this.labelYellowValue.Name = "labelYellowValue";
            this.labelYellowValue.Size = new System.Drawing.Size(18, 20);
            this.labelYellowValue.TabIndex = 27;
            this.labelYellowValue.Text = "0";
            // 
            // labelGreyName
            // 
            this.labelGreyName.AutoSize = true;
            this.labelGreyName.Location = new System.Drawing.Point(573, 0);
            this.labelGreyName.Name = "labelGreyName";
            this.labelGreyName.Size = new System.Drawing.Size(102, 20);
            this.labelGreyName.TabIndex = 28;
            this.labelGreyName.Text = "Grå knapper:";
            // 
            // labelGreyValue
            // 
            this.labelGreyValue.AutoSize = true;
            this.labelGreyValue.Location = new System.Drawing.Point(681, 0);
            this.labelGreyValue.Name = "labelGreyValue";
            this.labelGreyValue.Size = new System.Drawing.Size(18, 20);
            this.labelGreyValue.TabIndex = 29;
            this.labelGreyValue.Text = "0";
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 794);
            this.Controls.Add(this.mainContainer);
            this.Name = "WinForm";
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.controlPanelContainer.ResumeLayout(false);
            this.controlPanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardCanvas)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel controlPanelContainer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox randomPlacementPicker;
        private System.Windows.Forms.PictureBox boardCanvas;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.NumericUpDown NumericUpDownRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.NumericUpDown NumericUpDownColumns;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelRedName;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenName;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueName;
        private System.Windows.Forms.Label labelBlueValue;
        private System.Windows.Forms.Label labelYellowName;
        private System.Windows.Forms.Label labelYellowValue;
        private System.Windows.Forms.Label labelGreyName;
        private System.Windows.Forms.Label labelGreyValue;
    }
}

