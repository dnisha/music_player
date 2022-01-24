namespace MyPlayer1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_track_end = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_preview.Location = new System.Drawing.Point(17, 439);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(144, 41);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_play.Location = new System.Drawing.Point(320, 439);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(144, 41);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pause.Location = new System.Drawing.Point(472, 439);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(144, 41);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_stop.Location = new System.Drawing.Point(624, 439);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(144, 41);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_open.Location = new System.Drawing.Point(776, 439);
            this.btn_open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(155, 41);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(17, 396);
            this.p_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(913, 16);
            this.p_bar.TabIndex = 6;
            this.p_bar.Click += new System.EventHandler(this.p_bar_Click);
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(369, 22);
            this.track_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(445, 256);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.Black;
            this.pic_art.Image = global::MyPlayer1.Properties.Resources.download;
            this.pic_art.Location = new System.Drawing.Point(20, 17);
            this.pic_art.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(293, 271);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // track_volume
            // 
            this.track_volume.BackColor = System.Drawing.Color.RosyBrown;
            this.track_volume.Location = new System.Drawing.Point(856, 126);
            this.track_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 218);
            this.track_volume.TabIndex = 9;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.Color.RosyBrown;
            this.Volume.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.ForeColor = System.Drawing.Color.White;
            this.Volume.Location = new System.Drawing.Point(829, 346);
            this.Volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(81, 27);
            this.Volume.TabIndex = 10;
            this.Volume.Text = "Volume";
            this.Volume.Click += new System.EventHandler(this.Volume_Click);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_volume.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.White;
            this.lbl_volume.Location = new System.Drawing.Point(856, 95);
            this.lbl_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(56, 27);
            this.lbl_volume.TabIndex = 11;
            this.lbl_volume.Text = "100%";
            this.lbl_volume.Click += new System.EventHandler(this.lbl_volume_Click);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Dubai", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_track_start.Location = new System.Drawing.Point(16, 11);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(115, 63);
            this.lbl_track_start.TabIndex = 12;
            this.lbl_track_start.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pic_art);
            this.panel1.Controls.Add(this.track_list);
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 313);
            this.panel1.TabIndex = 14;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(856, 38);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(33, 14);
            this.player.TabIndex = 15;
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_next.Location = new System.Drawing.Point(169, 439);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(144, 41);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Dubai", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_track_end.Location = new System.Drawing.Point(815, 11);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(115, 63);
            this.lbl_track_end.TabIndex = 17;
            this.lbl_track_end.Text = "00:00";
            this.lbl_track_end.Click += new System.EventHandler(this.lbl_track_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(945, 501);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_track_end;
    }
}

