namespace Hanoi_Tower
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.moves_done_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pucks_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.done_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.moves_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hanoi_groupbox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(29, 278);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(149, 45);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.moves_done_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reset_btn);
            this.groupBox1.Controls.Add(this.start_btn);
            this.groupBox1.Controls.Add(this.exit_btn);
            this.groupBox1.Location = new System.Drawing.Point(819, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Timer interval:";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(29, 145);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(149, 56);
            this.trackBar1.SmallChange = 100;
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // moves_done_label
            // 
            this.moves_done_label.AutoSize = true;
            this.moves_done_label.Location = new System.Drawing.Point(128, 85);
            this.moves_done_label.Name = "moves_done_label";
            this.moves_done_label.Size = new System.Drawing.Size(17, 20);
            this.moves_done_label.TabIndex = 6;
            this.moves_done_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moves done:";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(29, 216);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(149, 45);
            this.reset_btn.TabIndex = 4;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(29, 26);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(149, 45);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of pucks:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pucks_combobox
            // 
            this.pucks_combobox.FormattingEnabled = true;
            this.pucks_combobox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.pucks_combobox.Location = new System.Drawing.Point(137, 23);
            this.pucks_combobox.Name = "pucks_combobox";
            this.pucks_combobox.Size = new System.Drawing.Size(52, 28);
            this.pucks_combobox.TabIndex = 1;
            this.pucks_combobox.SelectedIndexChanged += new System.EventHandler(this.pucks_combobox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.done_label);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.pucks_combobox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(819, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 234);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // done_label
            // 
            this.done_label.AutoSize = true;
            this.done_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.done_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.done_label.Location = new System.Drawing.Point(123, 200);
            this.done_label.Name = "done_label";
            this.done_label.Size = new System.Drawing.Size(69, 28);
            this.done_label.TabIndex = 3;
            this.done_label.Text = "DONE";
            this.done_label.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.moves_label);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 148);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // moves_label
            // 
            this.moves_label.AutoSize = true;
            this.moves_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moves_label.Location = new System.Drawing.Point(23, 103);
            this.moves_label.Name = "moves_label";
            this.moves_label.Size = new System.Drawing.Size(23, 28);
            this.moves_label.TabIndex = 1;
            this.moves_label.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minimum amount of moves";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hanoi_groupbox
            // 
            this.hanoi_groupbox.Location = new System.Drawing.Point(12, 12);
            this.hanoi_groupbox.Name = "hanoi_groupbox";
            this.hanoi_groupbox.Size = new System.Drawing.Size(792, 569);
            this.hanoi_groupbox.TabIndex = 4;
            this.hanoi_groupbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 593);
            this.Controls.Add(this.hanoi_groupbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button exit_btn;
        private GroupBox groupBox1;
        private Button start_btn;
        private Label label1;
        private ComboBox pucks_combobox;
        private GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private Button reset_btn;
        private GroupBox hanoi_groupbox;
        private GroupBox groupBox3;
        private Label moves_label;
        private Label label2;
        private Label moves_done_label;
        private Label label3;
        private Label label4;
        private TrackBar trackBar1;
        private Label done_label;
    }
}