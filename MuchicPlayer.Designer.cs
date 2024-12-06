using System.Drawing;

namespace MuchicPlayer
{
    partial class MuchicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuchicPlayer));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.volumeScroll = new System.Windows.Forms.TrackBar();
            this.Ltb_Musics = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxShuffle = new System.Windows.Forms.PictureBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxHighVolume = new System.Windows.Forms.PictureBox();
            this.pictureBoxLowVolume = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenMusic = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirstSong = new System.Windows.Forms.PictureBox();
            this.pictureBoxLastSong = new System.Windows.Forms.PictureBox();
            this.pictureBoxAscending = new System.Windows.Forms.PictureBox();
            this.pictureBoxDescending = new System.Windows.Forms.PictureBox();
            this.pictureBoxFastForward = new System.Windows.Forms.PictureBox();
            this.pictureBoxResume = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHighVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLowVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAscending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDescending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFastForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(80, 190);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(240, 45);
            this.Player.TabIndex = 0;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(40, 187);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(34, 13);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "00:00";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Location = new System.Drawing.Point(326, 187);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(34, 13);
            this.lblduration.TabIndex = 13;
            this.lblduration.Text = "00:00";
            // 
            // volumeScroll
            // 
            this.volumeScroll.BackColor = System.Drawing.Color.Black;
            this.volumeScroll.Location = new System.Drawing.Point(155, 128);
            this.volumeScroll.Maximum = 100;
            this.volumeScroll.Name = "volumeScroll";
            this.volumeScroll.Size = new System.Drawing.Size(90, 45);
            this.volumeScroll.TabIndex = 17;
            this.volumeScroll.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Ltb_Musics
            // 
            this.Ltb_Musics.BackColor = System.Drawing.Color.Black;
            this.Ltb_Musics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ltb_Musics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.Ltb_Musics.FormattingEnabled = true;
            this.Ltb_Musics.Location = new System.Drawing.Point(37, 215);
            this.Ltb_Musics.Name = "Ltb_Musics";
            this.Ltb_Musics.Size = new System.Drawing.Size(329, 52);
            this.Ltb_Musics.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(80, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 50);
            this.panel1.TabIndex = 21;
            // 
            // pictureBoxShuffle
            // 
            this.pictureBoxShuffle.BackColor = System.Drawing.Color.Black;
            this.pictureBoxShuffle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShuffle.Image")));
            this.pictureBoxShuffle.Location = new System.Drawing.Point(191, 61);
            this.pictureBoxShuffle.Name = "pictureBoxShuffle";
            this.pictureBoxShuffle.Size = new System.Drawing.Size(17, 17);
            this.pictureBoxShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShuffle.TabIndex = 35;
            this.pictureBoxShuffle.TabStop = false;
            this.pictureBoxShuffle.Click += new System.EventHandler(this.pictureBoxShuffle_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 5.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(125, 79);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(150, 17);
            this.searchtxt.TabIndex = 27;
            this.searchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(400, 25);
            this.bindingNavigator1.TabIndex = 29;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlay.Image")));
            this.pictureBoxPlay.Location = new System.Drawing.Point(185, 9);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlay.TabIndex = 30;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPause.Image")));
            this.pictureBoxPause.Location = new System.Drawing.Point(120, 9);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPause.TabIndex = 31;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.BackColor = System.Drawing.Color.Black;
            this.pictureBoxStop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStop.Image")));
            this.pictureBoxStop.Location = new System.Drawing.Point(250, 9);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop.TabIndex = 32;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click);
            // 
            // pictureBoxHighVolume
            // 
            this.pictureBoxHighVolume.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHighVolume.Image")));
            this.pictureBoxHighVolume.Location = new System.Drawing.Point(276, 126);
            this.pictureBoxHighVolume.Name = "pictureBoxHighVolume";
            this.pictureBoxHighVolume.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHighVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHighVolume.TabIndex = 33;
            this.pictureBoxHighVolume.TabStop = false;
            // 
            // pictureBoxLowVolume
            // 
            this.pictureBoxLowVolume.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLowVolume.Image")));
            this.pictureBoxLowVolume.Location = new System.Drawing.Point(95, 126);
            this.pictureBoxLowVolume.Name = "pictureBoxLowVolume";
            this.pictureBoxLowVolume.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxLowVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLowVolume.TabIndex = 34;
            this.pictureBoxLowVolume.TabStop = false;
            // 
            // pictureBoxOpenMusic
            // 
            this.pictureBoxOpenMusic.BackColor = System.Drawing.Color.Black;
            this.pictureBoxOpenMusic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenMusic.Image")));
            this.pictureBoxOpenMusic.Location = new System.Drawing.Point(20, 30);
            this.pictureBoxOpenMusic.Name = "pictureBoxOpenMusic";
            this.pictureBoxOpenMusic.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOpenMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpenMusic.TabIndex = 36;
            this.pictureBoxOpenMusic.TabStop = false;
            this.pictureBoxOpenMusic.Click += new System.EventHandler(this.pictureBoxOpenMusic_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Black;
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(215, 60);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNext.TabIndex = 37;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPrevious.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrevious.Image")));
            this.pictureBoxPrevious.Location = new System.Drawing.Point(165, 60);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrevious.TabIndex = 38;
            this.pictureBoxPrevious.TabStop = false;
            this.pictureBoxPrevious.Click += new System.EventHandler(this.pictureBoxPrevious_Click);
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.BackColor = System.Drawing.Color.Black;
            this.pictureBoxNew.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNew.Image")));
            this.pictureBoxNew.Location = new System.Drawing.Point(350, 30);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNew.TabIndex = 39;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.Click += new System.EventHandler(this.pictureBoxNew_Click);
            // 
            // pictureBoxFirstSong
            // 
            this.pictureBoxFirstSong.BackColor = System.Drawing.Color.Black;
            this.pictureBoxFirstSong.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFirstSong.Image")));
            this.pictureBoxFirstSong.Location = new System.Drawing.Point(140, 60);
            this.pictureBoxFirstSong.Name = "pictureBoxFirstSong";
            this.pictureBoxFirstSong.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxFirstSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirstSong.TabIndex = 40;
            this.pictureBoxFirstSong.TabStop = false;
            this.pictureBoxFirstSong.Click += new System.EventHandler(this.pictureBoxFirstSong_Click);
            // 
            // pictureBoxLastSong
            // 
            this.pictureBoxLastSong.BackColor = System.Drawing.Color.Black;
            this.pictureBoxLastSong.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLastSong.Image")));
            this.pictureBoxLastSong.Location = new System.Drawing.Point(240, 60);
            this.pictureBoxLastSong.Name = "pictureBoxLastSong";
            this.pictureBoxLastSong.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxLastSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLastSong.TabIndex = 41;
            this.pictureBoxLastSong.TabStop = false;
            this.pictureBoxLastSong.Click += new System.EventHandler(this.pictureBoxLastSong_Click);
            // 
            // pictureBoxAscending
            // 
            this.pictureBoxAscending.BackColor = System.Drawing.Color.Black;
            this.pictureBoxAscending.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAscending.Image")));
            this.pictureBoxAscending.Location = new System.Drawing.Point(372, 219);
            this.pictureBoxAscending.Name = "pictureBoxAscending";
            this.pictureBoxAscending.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxAscending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAscending.TabIndex = 42;
            this.pictureBoxAscending.TabStop = false;
            this.pictureBoxAscending.Click += new System.EventHandler(this.pictureBoxAscending_Click);
            // 
            // pictureBoxDescending
            // 
            this.pictureBoxDescending.BackColor = System.Drawing.Color.Black;
            this.pictureBoxDescending.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDescending.Image")));
            this.pictureBoxDescending.Location = new System.Drawing.Point(372, 244);
            this.pictureBoxDescending.Name = "pictureBoxDescending";
            this.pictureBoxDescending.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxDescending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDescending.TabIndex = 43;
            this.pictureBoxDescending.TabStop = false;
            this.pictureBoxDescending.Click += new System.EventHandler(this.pictureBoxDescending_Click);
            // 
            // pictureBoxFastForward
            // 
            this.pictureBoxFastForward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFastForward.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFastForward.Image")));
            this.pictureBoxFastForward.Location = new System.Drawing.Point(298, 191);
            this.pictureBoxFastForward.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFastForward.Name = "pictureBoxFastForward";
            this.pictureBoxFastForward.Size = new System.Drawing.Size(12, 12);
            this.pictureBoxFastForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFastForward.TabIndex = 44;
            this.pictureBoxFastForward.TabStop = false;
            this.pictureBoxFastForward.Click += new System.EventHandler(this.pictureBoxFastForward_Click);
            // 
            // pictureBoxResume
            // 
            this.pictureBoxResume.BackColor = System.Drawing.Color.White;
            this.pictureBoxResume.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxResume.Image")));
            this.pictureBoxResume.Location = new System.Drawing.Point(92, 192);
            this.pictureBoxResume.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxResume.Name = "pictureBoxResume";
            this.pictureBoxResume.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxResume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResume.TabIndex = 45;
            this.pictureBoxResume.TabStop = false;
            this.pictureBoxResume.Click += new System.EventHandler(this.pictureBoxResume_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(292, 191);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 12);
            this.panel2.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // MuchicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxFastForward);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxResume);
            this.Controls.Add(this.pictureBoxDescending);
            this.Controls.Add(this.pictureBoxAscending);
            this.Controls.Add(this.pictureBoxLastSong);
            this.Controls.Add(this.pictureBoxFirstSong);
            this.Controls.Add(this.pictureBoxNew);
            this.Controls.Add(this.pictureBoxPrevious);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxShuffle);
            this.Controls.Add(this.pictureBoxOpenMusic);
            this.Controls.Add(this.pictureBoxLowVolume);
            this.Controls.Add(this.pictureBoxHighVolume);
            this.Controls.Add(this.pictureBoxStop);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.Ltb_Musics);
            this.Controls.Add(this.volumeScroll);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "MuchicPlayer";
            this.Size = new System.Drawing.Size(400, 282);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHighVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLowVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAscending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDescending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFastForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.TrackBar volumeScroll;
        private System.Windows.Forms.ListBox Ltb_Musics;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxHighVolume;
        private System.Windows.Forms.PictureBox pictureBoxLowVolume;
        private System.Windows.Forms.PictureBox pictureBoxShuffle;
        private System.Windows.Forms.PictureBox pictureBoxOpenMusic;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.PictureBox pictureBoxFirstSong;
        private System.Windows.Forms.PictureBox pictureBoxLastSong;
        private System.Windows.Forms.PictureBox pictureBoxAscending;
        private System.Windows.Forms.PictureBox pictureBoxDescending;
        private System.Windows.Forms.PictureBox pictureBoxFastForward;
        private System.Windows.Forms.PictureBox pictureBoxResume;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

