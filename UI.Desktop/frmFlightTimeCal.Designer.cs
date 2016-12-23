namespace UI.Desktop
{
    partial class frmFlightTimeCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlightTimeCal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.numWindDirection = new System.Windows.Forms.NumericUpDown();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.lblUnitFD = new System.Windows.Forms.Label();
            this.lblUnitWS = new System.Windows.Forms.Label();
            this.lblUnitWD = new System.Windows.Forms.Label();
            this.lblTAS = new System.Windows.Forms.Label();
            this.lblUnitTAS = new System.Windows.Forms.Label();
            this.lblTimeComp = new System.Windows.Forms.Label();
            this.lblUnitTime = new System.Windows.Forms.Label();
            this.txtTimeComp = new System.Windows.Forms.TextBox();
            this.txtTAS = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lnkEditTAS = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblWindDirection, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDistance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDistance, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numWindDirection, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWindSpeed, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtWindSpeed, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitFD, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitWS, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitWD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTAS, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitTAS, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTimeComp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitTime, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTimeComp, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTAS, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lnkEditTAS, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWindDirection.AutoSize = true;
            this.lblWindDirection.Location = new System.Drawing.Point(51, 43);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(75, 13);
            this.lblWindDirection.TabIndex = 2;
            this.lblWindDirection.Text = "Wind direction";
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(51, 13);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(75, 13);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Flight distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistance.Location = new System.Drawing.Point(132, 8);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(95, 20);
            this.txtDistance.TabIndex = 1;
            // 
            // numWindDirection
            // 
            this.numWindDirection.Location = new System.Drawing.Point(132, 38);
            this.numWindDirection.Name = "numWindDirection";
            this.numWindDirection.Size = new System.Drawing.Size(94, 20);
            this.numWindDirection.TabIndex = 4;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(62, 73);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(64, 13);
            this.lblWindSpeed.TabIndex = 5;
            this.lblWindSpeed.Text = "Wind speed";
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWindSpeed.Location = new System.Drawing.Point(132, 68);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(95, 20);
            this.txtWindSpeed.TabIndex = 8;
            // 
            // lblUnitFD
            // 
            this.lblUnitFD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnitFD.AutoSize = true;
            this.lblUnitFD.Location = new System.Drawing.Point(233, 13);
            this.lblUnitFD.Name = "lblUnitFD";
            this.lblUnitFD.Size = new System.Drawing.Size(24, 13);
            this.lblUnitFD.TabIndex = 12;
            this.lblUnitFD.Text = "nm.";
            // 
            // lblUnitWS
            // 
            this.lblUnitWS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnitWS.AutoSize = true;
            this.lblUnitWS.Location = new System.Drawing.Point(233, 73);
            this.lblUnitWS.Name = "lblUnitWS";
            this.lblUnitWS.Size = new System.Drawing.Size(24, 13);
            this.lblUnitWS.TabIndex = 13;
            this.lblUnitWS.Text = "kts.";
            // 
            // lblUnitWD
            // 
            this.lblUnitWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnitWD.AutoSize = true;
            this.lblUnitWD.Location = new System.Drawing.Point(233, 43);
            this.lblUnitWD.Name = "lblUnitWD";
            this.lblUnitWD.Size = new System.Drawing.Size(28, 13);
            this.lblUnitWD.TabIndex = 14;
            this.lblUnitWD.Text = "deg.";
            // 
            // lblTAS
            // 
            this.lblTAS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTAS.AutoSize = true;
            this.lblTAS.Location = new System.Drawing.Point(98, 131);
            this.lblTAS.Name = "lblTAS";
            this.lblTAS.Size = new System.Drawing.Size(28, 13);
            this.lblTAS.TabIndex = 7;
            this.lblTAS.Text = "TAS";
            // 
            // lblUnitTAS
            // 
            this.lblUnitTAS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnitTAS.AutoSize = true;
            this.lblUnitTAS.Location = new System.Drawing.Point(233, 131);
            this.lblUnitTAS.Name = "lblUnitTAS";
            this.lblUnitTAS.Size = new System.Drawing.Size(24, 13);
            this.lblUnitTAS.TabIndex = 15;
            this.lblUnitTAS.Text = "kts.";
            // 
            // lblTimeComp
            // 
            this.lblTimeComp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTimeComp.AutoSize = true;
            this.lblTimeComp.Location = new System.Drawing.Point(27, 103);
            this.lblTimeComp.Name = "lblTimeComp";
            this.lblTimeComp.Size = new System.Drawing.Size(99, 13);
            this.lblTimeComp.TabIndex = 16;
            this.lblTimeComp.Text = "Time compensation";
            // 
            // lblUnitTime
            // 
            this.lblUnitTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnitTime.AutoSize = true;
            this.lblUnitTime.Location = new System.Drawing.Point(233, 103);
            this.lblUnitTime.Name = "lblUnitTime";
            this.lblUnitTime.Size = new System.Drawing.Size(26, 13);
            this.lblUnitTime.TabIndex = 18;
            this.lblUnitTime.Text = "min.";
            // 
            // txtTimeComp
            // 
            this.txtTimeComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeComp.Location = new System.Drawing.Point(132, 98);
            this.txtTimeComp.Name = "txtTimeComp";
            this.txtTimeComp.Size = new System.Drawing.Size(95, 20);
            this.txtTimeComp.TabIndex = 9;
            // 
            // txtTAS
            // 
            this.txtTAS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTAS.Location = new System.Drawing.Point(132, 128);
            this.txtTAS.Name = "txtTAS";
            this.txtTAS.Size = new System.Drawing.Size(95, 20);
            this.txtTAS.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(152, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Accept";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lnkEditTAS
            // 
            this.lnkEditTAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditTAS.AutoSize = true;
            this.lnkEditTAS.Location = new System.Drawing.Point(178, 150);
            this.lnkEditTAS.Name = "lnkEditTAS";
            this.lnkEditTAS.Size = new System.Drawing.Size(49, 13);
            this.lnkEditTAS.TabIndex = 19;
            this.lnkEditTAS.TabStop = true;
            this.lnkEditTAS.Text = "Edit TAS";
            this.lnkEditTAS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditTAS_LinkClicked);
            // 
            // frmFlightTimeCal
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFlightTimeCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculate flight time";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindDirection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.NumericUpDown numWindDirection;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblTAS;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.TextBox txtTimeComp;
        private System.Windows.Forms.Label lblUnitFD;
        private System.Windows.Forms.Label lblUnitWS;
        private System.Windows.Forms.Label lblUnitWD;
        private System.Windows.Forms.Label lblUnitTAS;
        private System.Windows.Forms.Label lblTimeComp;
        private System.Windows.Forms.TextBox txtTAS;
        private System.Windows.Forms.Label lblUnitTime;
        private System.Windows.Forms.LinkLabel lnkEditTAS;
        private System.Windows.Forms.Button btnAceptar;
    }
}