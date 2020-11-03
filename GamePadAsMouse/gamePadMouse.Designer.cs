namespace GamePadAsMouse
{
    partial class gamePadMouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamePadMouse));
            this.mouseTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftStickTrackbar = new System.Windows.Forms.TrackBar();
            this.leftStickValue = new System.Windows.Forms.Label();
            this.rightStickValue = new System.Windows.Forms.Label();
            this.rightStickTrackbar = new System.Windows.Forms.TrackBar();
            this.panelGuider = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJoystick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stopOrStart = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.runAtStartUp = new System.Windows.Forms.CheckBox();
            this.joystickHook = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftStickTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightStickTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mouseTimer
            // 
            this.mouseTimer.Interval = 10;
            this.mouseTimer.Tick += new System.EventHandler(this.mouseTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Gouse";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Interval = 120;
            this.buttonTimer.Tick += new System.EventHandler(this.buttonTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Left Stick Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Right Stick Speed:";
            // 
            // leftStickTrackbar
            // 
            this.leftStickTrackbar.Location = new System.Drawing.Point(210, 89);
            this.leftStickTrackbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftStickTrackbar.Minimum = 1;
            this.leftStickTrackbar.Name = "leftStickTrackbar";
            this.leftStickTrackbar.Size = new System.Drawing.Size(150, 45);
            this.leftStickTrackbar.TabIndex = 11;
            this.leftStickTrackbar.Value = 1;
            this.leftStickTrackbar.Scroll += new System.EventHandler(this.leftStickTrackbar_Scroll);
            // 
            // leftStickValue
            // 
            this.leftStickValue.AutoSize = true;
            this.leftStickValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftStickValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.leftStickValue.Location = new System.Drawing.Point(168, 89);
            this.leftStickValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftStickValue.Name = "leftStickValue";
            this.leftStickValue.Size = new System.Drawing.Size(0, 26);
            this.leftStickValue.TabIndex = 12;
            // 
            // rightStickValue
            // 
            this.rightStickValue.AutoSize = true;
            this.rightStickValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightStickValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rightStickValue.Location = new System.Drawing.Point(168, 146);
            this.rightStickValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightStickValue.Name = "rightStickValue";
            this.rightStickValue.Size = new System.Drawing.Size(0, 26);
            this.rightStickValue.TabIndex = 13;
            // 
            // rightStickTrackbar
            // 
            this.rightStickTrackbar.Location = new System.Drawing.Point(210, 146);
            this.rightStickTrackbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightStickTrackbar.Minimum = 1;
            this.rightStickTrackbar.Name = "rightStickTrackbar";
            this.rightStickTrackbar.Size = new System.Drawing.Size(150, 45);
            this.rightStickTrackbar.TabIndex = 11;
            this.rightStickTrackbar.Value = 1;
            this.rightStickTrackbar.Scroll += new System.EventHandler(this.rightStickTrackbar_Scroll);
            // 
            // panelGuider
            // 
            this.panelGuider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.panelGuider.Location = new System.Drawing.Point(0, 0);
            this.panelGuider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGuider.Name = "panelGuider";
            this.panelGuider.Size = new System.Drawing.Size(600, 41);
            this.panelGuider.TabIndex = 14;
            this.panelGuider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGuider_MouseDown);
            this.panelGuider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGuider_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(283, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "x";
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbJoystick.Location = new System.Drawing.Point(39, 223);
            this.lbJoystick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(26, 32);
            this.lbJoystick.TabIndex = 15;
            this.lbJoystick.Text = "x";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(476, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "HIDE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopOrStart
            // 
            this.stopOrStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.stopOrStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopOrStart.Location = new System.Drawing.Point(476, 84);
            this.stopOrStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopOrStart.Name = "stopOrStart";
            this.stopOrStart.Size = new System.Drawing.Size(56, 26);
            this.stopOrStart.TabIndex = 18;
            this.stopOrStart.Text = "STOP";
            this.stopOrStart.UseVisualStyleBackColor = false;
            this.stopOrStart.Click += new System.EventHandler(this.stopOrStart_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(476, 158);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 33);
            this.save.TabIndex = 18;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // runAtStartUp
            // 
            this.runAtStartUp.AutoSize = true;
            this.runAtStartUp.Location = new System.Drawing.Point(464, 326);
            this.runAtStartUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runAtStartUp.Name = "runAtStartUp";
            this.runAtStartUp.Size = new System.Drawing.Size(101, 17);
            this.runAtStartUp.TabIndex = 19;
            this.runAtStartUp.Text = "Run At Start Up";
            this.runAtStartUp.UseVisualStyleBackColor = true;
            this.runAtStartUp.CheckedChanged += new System.EventHandler(this.runAtStartUp_CheckedChanged);
            // 
            // joystickHook
            // 
            this.joystickHook.Tick += new System.EventHandler(this.joystickHook_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GamePadAsMouse.Properties.Resources.arrows_fw;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(476, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // gamePadMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(159)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.runAtStartUp);
            this.Controls.Add(this.stopOrStart);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbJoystick);
            this.Controls.Add(this.panelGuider);
            this.Controls.Add(this.rightStickValue);
            this.Controls.Add(this.leftStickValue);
            this.Controls.Add(this.rightStickTrackbar);
            this.Controls.Add(this.leftStickTrackbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gamePadMouse";
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.gamePadMouse_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftStickTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightStickTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mouseTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer buttonTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar leftStickTrackbar;
        private System.Windows.Forms.Label leftStickValue;
        private System.Windows.Forms.Label rightStickValue;
        private System.Windows.Forms.TrackBar rightStickTrackbar;
        private System.Windows.Forms.Panel panelGuider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stopOrStart;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox runAtStartUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer joystickHook;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

