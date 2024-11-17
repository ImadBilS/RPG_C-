namespace RPG_C_
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
            components = new System.ComponentModel.Container();
            lblPlayerPvMax = new Label();
            lblPlayerMaxDefense = new Label();
            lblPlayerCurrentPv = new Label();
            lblPlayerDefense = new Label();
            lblPlayerAttack = new Label();
            lblEnnemyAttack = new Label();
            lblEnnemyDefense = new Label();
            lblEnnemyCurrentPv = new Label();
            lblEnnemyMaxDefense = new Label();
            lblEnnemyPvMax = new Label();
            btnEnnemyAttack = new Button();
            btnPlayerAttack = new Button();
            btnHealPlayer = new Button();
            btnHealEnnemy = new Button();
            pictureBox1 = new PictureBox();
            playerAttackTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            PbArena = new PictureBox();
            ennemyAttackTimer = new System.Windows.Forms.Timer(components);
            playerHealTimer = new System.Windows.Forms.Timer(components);
            lblPlayerPotion = new Label();
            btnMapOpen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbArena).BeginInit();
            SuspendLayout();
            // 
            // lblPlayerPvMax
            // 
            lblPlayerPvMax.AutoSize = true;
            lblPlayerPvMax.Location = new Point(95, 34);
            lblPlayerPvMax.Name = "lblPlayerPvMax";
            lblPlayerPvMax.Size = new Size(75, 15);
            lblPlayerPvMax.TabIndex = 0;
            lblPlayerPvMax.Text = "PlayerPvMax";
            // 
            // lblPlayerMaxDefense
            // 
            lblPlayerMaxDefense.AutoSize = true;
            lblPlayerMaxDefense.Location = new Point(95, 81);
            lblPlayerMaxDefense.Name = "lblPlayerMaxDefense";
            lblPlayerMaxDefense.Size = new Size(104, 15);
            lblPlayerMaxDefense.TabIndex = 1;
            lblPlayerMaxDefense.Text = "PlayerMaxDefense";
            // 
            // lblPlayerCurrentPv
            // 
            lblPlayerCurrentPv.AutoSize = true;
            lblPlayerCurrentPv.Location = new Point(95, 57);
            lblPlayerCurrentPv.Name = "lblPlayerCurrentPv";
            lblPlayerCurrentPv.Size = new Size(92, 15);
            lblPlayerCurrentPv.TabIndex = 2;
            lblPlayerCurrentPv.Text = "PlayerCurrentPv";
            // 
            // lblPlayerDefense
            // 
            lblPlayerDefense.AutoSize = true;
            lblPlayerDefense.Location = new Point(95, 104);
            lblPlayerDefense.Name = "lblPlayerDefense";
            lblPlayerDefense.Size = new Size(81, 15);
            lblPlayerDefense.TabIndex = 3;
            lblPlayerDefense.Text = "PlayerDefense";
            // 
            // lblPlayerAttack
            // 
            lblPlayerAttack.AutoSize = true;
            lblPlayerAttack.Location = new Point(95, 128);
            lblPlayerAttack.Name = "lblPlayerAttack";
            lblPlayerAttack.Size = new Size(73, 15);
            lblPlayerAttack.TabIndex = 4;
            lblPlayerAttack.Text = "PlayerAttack";
            // 
            // lblEnnemyAttack
            // 
            lblEnnemyAttack.AutoSize = true;
            lblEnnemyAttack.Location = new Point(523, 128);
            lblEnnemyAttack.Name = "lblEnnemyAttack";
            lblEnnemyAttack.Size = new Size(84, 15);
            lblEnnemyAttack.TabIndex = 14;
            lblEnnemyAttack.Text = "EnnemyAttack";
            // 
            // lblEnnemyDefense
            // 
            lblEnnemyDefense.AutoSize = true;
            lblEnnemyDefense.Location = new Point(523, 104);
            lblEnnemyDefense.Name = "lblEnnemyDefense";
            lblEnnemyDefense.Size = new Size(92, 15);
            lblEnnemyDefense.TabIndex = 13;
            lblEnnemyDefense.Text = "EnnemyDefense";
            // 
            // lblEnnemyCurrentPv
            // 
            lblEnnemyCurrentPv.AutoSize = true;
            lblEnnemyCurrentPv.Location = new Point(523, 57);
            lblEnnemyCurrentPv.Name = "lblEnnemyCurrentPv";
            lblEnnemyCurrentPv.Size = new Size(103, 15);
            lblEnnemyCurrentPv.TabIndex = 12;
            lblEnnemyCurrentPv.Text = "EnnemyCurrentPv";
            // 
            // lblEnnemyMaxDefense
            // 
            lblEnnemyMaxDefense.AutoSize = true;
            lblEnnemyMaxDefense.Location = new Point(523, 81);
            lblEnnemyMaxDefense.Name = "lblEnnemyMaxDefense";
            lblEnnemyMaxDefense.Size = new Size(115, 15);
            lblEnnemyMaxDefense.TabIndex = 11;
            lblEnnemyMaxDefense.Text = "EnnemyMaxDefense";
            // 
            // lblEnnemyPvMax
            // 
            lblEnnemyPvMax.AutoSize = true;
            lblEnnemyPvMax.Location = new Point(523, 34);
            lblEnnemyPvMax.Name = "lblEnnemyPvMax";
            lblEnnemyPvMax.Size = new Size(86, 15);
            lblEnnemyPvMax.TabIndex = 10;
            lblEnnemyPvMax.Text = "EnnemyPvMax";
            // 
            // btnEnnemyAttack
            // 
            btnEnnemyAttack.AutoSize = true;
            btnEnnemyAttack.Location = new Point(523, 167);
            btnEnnemyAttack.Margin = new Padding(3, 2, 3, 2);
            btnEnnemyAttack.Name = "btnEnnemyAttack";
            btnEnnemyAttack.Size = new Size(82, 25);
            btnEnnemyAttack.TabIndex = 15;
            btnEnnemyAttack.Text = "Attack";
            btnEnnemyAttack.UseVisualStyleBackColor = true;
            btnEnnemyAttack.Click += btnEnnemyAttack_Click_1;
            // 
            // btnPlayerAttack
            // 
            btnPlayerAttack.AutoSize = true;
            btnPlayerAttack.Location = new Point(95, 167);
            btnPlayerAttack.Margin = new Padding(3, 2, 3, 2);
            btnPlayerAttack.Name = "btnPlayerAttack";
            btnPlayerAttack.Size = new Size(82, 25);
            btnPlayerAttack.TabIndex = 16;
            btnPlayerAttack.Text = "Attack";
            btnPlayerAttack.UseVisualStyleBackColor = true;
            btnPlayerAttack.Click += btnPlayerAttack_Click_1;
            // 
            // btnHealPlayer
            // 
            btnHealPlayer.AutoSize = true;
            btnHealPlayer.Location = new Point(95, 202);
            btnHealPlayer.Margin = new Padding(3, 2, 3, 2);
            btnHealPlayer.Name = "btnHealPlayer";
            btnHealPlayer.Size = new Size(82, 25);
            btnHealPlayer.TabIndex = 17;
            btnHealPlayer.Text = "Heal";
            btnHealPlayer.UseVisualStyleBackColor = true;
            btnHealPlayer.Click += btnHealPlayer_Click;
            // 
            // btnHealEnnemy
            // 
            btnHealEnnemy.AutoSize = true;
            btnHealEnnemy.Location = new Point(523, 202);
            btnHealEnnemy.Margin = new Padding(3, 2, 3, 2);
            btnHealEnnemy.Name = "btnHealEnnemy";
            btnHealEnnemy.Size = new Size(82, 25);
            btnHealEnnemy.TabIndex = 18;
            btnHealEnnemy.Text = "Heal";
            btnHealEnnemy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(320, 222);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // playerAttackTimer
            // 
            playerAttackTimer.Interval = 1000;
            playerAttackTimer.Tick += playerAttackTimer_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(333, 81);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // PbArena
            // 
            PbArena.BackColor = Color.Transparent;
            PbArena.Location = new Point(253, 34);
            PbArena.Margin = new Padding(3, 2, 3, 2);
            PbArena.Name = "PbArena";
            PbArena.Size = new Size(217, 156);
            PbArena.SizeMode = PictureBoxSizeMode.StretchImage;
            PbArena.TabIndex = 21;
            PbArena.TabStop = false;
            // 
            // ennemyAttackTimer
            // 
            ennemyAttackTimer.Interval = 1000;
            ennemyAttackTimer.Tick += ennemyAttackTimer_Tick;
            // 
            // playerHealTimer
            // 
            playerHealTimer.Interval = 1000;
            playerHealTimer.Tick += playerHealTimer_Tick;
            // 
            // lblPlayerPotion
            // 
            lblPlayerPotion.AutoSize = true;
            lblPlayerPotion.Location = new Point(96, 235);
            lblPlayerPotion.Name = "lblPlayerPotion";
            lblPlayerPotion.Size = new Size(74, 15);
            lblPlayerPotion.TabIndex = 22;
            lblPlayerPotion.Text = "PlayerPotion";
            // 
            // btnMapOpen
            // 
            btnMapOpen.Location = new Point(616, 285);
            btnMapOpen.Name = "btnMapOpen";
            btnMapOpen.Size = new Size(72, 41);
            btnMapOpen.TabIndex = 23;
            btnMapOpen.Text = "Afficher la map";
            btnMapOpen.UseVisualStyleBackColor = true;
            btnMapOpen.Click += btnMapOpen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnMapOpen);
            Controls.Add(lblPlayerPotion);
            Controls.Add(PbArena);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnHealEnnemy);
            Controls.Add(btnHealPlayer);
            Controls.Add(btnPlayerAttack);
            Controls.Add(btnEnnemyAttack);
            Controls.Add(lblEnnemyAttack);
            Controls.Add(lblEnnemyDefense);
            Controls.Add(lblEnnemyCurrentPv);
            Controls.Add(lblEnnemyMaxDefense);
            Controls.Add(lblEnnemyPvMax);
            Controls.Add(lblPlayerAttack);
            Controls.Add(lblPlayerDefense);
            Controls.Add(lblPlayerCurrentPv);
            Controls.Add(lblPlayerMaxDefense);
            Controls.Add(lblPlayerPvMax);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbArena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerPvMax;
        private Label lblPlayerMaxDefense;
        private Label lblPlayerCurrentPv;
        private Label lblPlayerDefense;
        private Label lblPlayerAttack;
        private Label lblEnnemyAttack;
        private Label lblEnnemyDefense;
        private Label lblEnnemyCurrentPv;
        private Label lblEnnemyMaxDefense;
        private Label lblEnnemyPvMax;
        private Button btnEnnemyAttack;
        private Button btnPlayerAttack;
        private Button btnHealPlayer;
        private Button btnHealEnnemy;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer playerAttackTimer;
        private PictureBox pictureBox2;
        private PictureBox PbArena;
        private System.Windows.Forms.Timer ennemyAttackTimer;
        private System.Windows.Forms.Timer playerHealTimer;
        private Label lblPlayerPotion;
        private Button btnMapOpen;
    }
}
