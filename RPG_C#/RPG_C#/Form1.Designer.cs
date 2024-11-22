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
            lblPlayerPv = new Label();
            lblPlayerAttack = new Label();
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
            lblItem = new Label();
            btnSmallLifePotion = new Button();
            btnMediumLifePotion = new Button();
            btnHighLifePotion = new Button();
            btnCocaBig = new Button();
            btnCocaMedium = new Button();
            btnCocaSmall = new Button();
            btnSword3 = new Button();
            btnSword2 = new Button();
            btnSword1 = new Button();
            btnArmor3 = new Button();
            btnArmor2 = new Button();
            btnArmor1 = new Button();
            btnGourde = new Button();
            btnInventory = new Button();
            lblPlayerDefense = new Label();
            lblPlayerShield = new Label();
            lblEnnemyShield = new Label();
            lblEnnemyAttack = new Label();
            lblEnnemyCurrentPv = new Label();
            lblEnnemyDefense = new Label();
            lblEnnemyDef = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbArena).BeginInit();
            SuspendLayout();
            // 
            // lblPlayerPv
            // 
            lblPlayerPv.AutoSize = true;
            lblPlayerPv.Location = new Point(12, 68);
            lblPlayerPv.Name = "lblPlayerPv";
            lblPlayerPv.Size = new Size(64, 20);
            lblPlayerPv.TabIndex = 2;
            lblPlayerPv.Text = "PlayerPv";
            // 
            // lblPlayerAttack
            // 
            lblPlayerAttack.AutoSize = true;
            lblPlayerAttack.Location = new Point(12, 128);
            lblPlayerAttack.Name = "lblPlayerAttack";
            lblPlayerAttack.Size = new Size(91, 20);
            lblPlayerAttack.TabIndex = 4;
            lblPlayerAttack.Text = "PlayerAttack";
            // 
            // btnEnnemyAttack
            // 
            btnEnnemyAttack.AutoSize = true;
            btnEnnemyAttack.Location = new Point(738, 223);
            btnEnnemyAttack.Name = "btnEnnemyAttack";
            btnEnnemyAttack.Size = new Size(94, 33);
            btnEnnemyAttack.TabIndex = 15;
            btnEnnemyAttack.Text = "Attack";
            btnEnnemyAttack.UseVisualStyleBackColor = true;
            btnEnnemyAttack.Click += btnEnnemyAttack_Click_1;
            // 
            // btnPlayerAttack
            // 
            btnPlayerAttack.AutoSize = true;
            btnPlayerAttack.Location = new Point(109, 223);
            btnPlayerAttack.Name = "btnPlayerAttack";
            btnPlayerAttack.Size = new Size(94, 33);
            btnPlayerAttack.TabIndex = 16;
            btnPlayerAttack.Text = "Attack";
            btnPlayerAttack.UseVisualStyleBackColor = true;
            btnPlayerAttack.Click += btnPlayerAttack_Click_1;
            // 
            // btnHealPlayer
            // 
            btnHealPlayer.AutoSize = true;
            btnHealPlayer.Location = new Point(109, 269);
            btnHealPlayer.Name = "btnHealPlayer";
            btnHealPlayer.Size = new Size(94, 33);
            btnHealPlayer.TabIndex = 17;
            btnHealPlayer.Text = "Heal";
            btnHealPlayer.UseVisualStyleBackColor = true;
            btnHealPlayer.Click += btnHealPlayer_Click;
            // 
            // btnHealEnnemy
            // 
            btnHealEnnemy.AutoSize = true;
            btnHealEnnemy.Location = new Point(738, 269);
            btnHealEnnemy.Name = "btnHealEnnemy";
            btnHealEnnemy.Size = new Size(94, 33);
            btnHealEnnemy.TabIndex = 18;
            btnHealEnnemy.Text = "Heal";
            btnHealEnnemy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(413, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 116);
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
            pictureBox2.Location = new Point(381, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // PbArena
            // 
            PbArena.BackColor = Color.Transparent;
            PbArena.Location = new Point(263, 31);
            PbArena.Name = "PbArena";
            PbArena.Size = new Size(384, 160);
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
            lblPlayerPotion.Location = new Point(110, 313);
            lblPlayerPotion.Name = "lblPlayerPotion";
            lblPlayerPotion.Size = new Size(91, 20);
            lblPlayerPotion.TabIndex = 22;
            lblPlayerPotion.Text = "PlayerPotion";
            // 
            // btnMapOpen
            // 
            btnMapOpen.Location = new Point(797, 380);
            btnMapOpen.Margin = new Padding(3, 4, 3, 4);
            btnMapOpen.Name = "btnMapOpen";
            btnMapOpen.Size = new Size(82, 55);
            btnMapOpen.TabIndex = 23;
            btnMapOpen.Text = "Afficher la map";
            btnMapOpen.UseVisualStyleBackColor = true;
            btnMapOpen.Click += btnMapOpen_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 447);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(56, 20);
            lblItem.TabIndex = 24;
            lblItem.Text = "Items : ";
            // 
            // btnSmallLifePotion
            // 
            btnSmallLifePotion.AutoSize = true;
            btnSmallLifePotion.Location = new Point(12, 495);
            btnSmallLifePotion.Name = "btnSmallLifePotion";
            btnSmallLifePotion.Size = new Size(60, 60);
            btnSmallLifePotion.TabIndex = 25;
            btnSmallLifePotion.UseVisualStyleBackColor = true;
            // 
            // btnMediumLifePotion
            // 
            btnMediumLifePotion.AutoSize = true;
            btnMediumLifePotion.Location = new Point(78, 495);
            btnMediumLifePotion.Name = "btnMediumLifePotion";
            btnMediumLifePotion.Size = new Size(60, 60);
            btnMediumLifePotion.TabIndex = 26;
            btnMediumLifePotion.UseVisualStyleBackColor = true;
            // 
            // btnHighLifePotion
            // 
            btnHighLifePotion.AutoSize = true;
            btnHighLifePotion.Location = new Point(144, 495);
            btnHighLifePotion.Name = "btnHighLifePotion";
            btnHighLifePotion.Size = new Size(60, 60);
            btnHighLifePotion.TabIndex = 27;
            btnHighLifePotion.UseVisualStyleBackColor = true;
            // 
            // btnCocaBig
            // 
            btnCocaBig.AutoSize = true;
            btnCocaBig.Location = new Point(144, 561);
            btnCocaBig.Name = "btnCocaBig";
            btnCocaBig.Size = new Size(60, 60);
            btnCocaBig.TabIndex = 30;
            btnCocaBig.UseVisualStyleBackColor = true;
            // 
            // btnCocaMedium
            // 
            btnCocaMedium.AutoSize = true;
            btnCocaMedium.Location = new Point(78, 561);
            btnCocaMedium.Name = "btnCocaMedium";
            btnCocaMedium.Size = new Size(60, 60);
            btnCocaMedium.TabIndex = 29;
            btnCocaMedium.UseVisualStyleBackColor = true;
            // 
            // btnCocaSmall
            // 
            btnCocaSmall.AutoSize = true;
            btnCocaSmall.Location = new Point(12, 561);
            btnCocaSmall.Name = "btnCocaSmall";
            btnCocaSmall.Size = new Size(60, 60);
            btnCocaSmall.TabIndex = 28;
            btnCocaSmall.UseVisualStyleBackColor = true;
            // 
            // btnSword3
            // 
            btnSword3.AutoSize = true;
            btnSword3.Location = new Point(834, 495);
            btnSword3.Name = "btnSword3";
            btnSword3.Size = new Size(60, 60);
            btnSword3.TabIndex = 33;
            btnSword3.UseVisualStyleBackColor = true;
            // 
            // btnSword2
            // 
            btnSword2.AutoSize = true;
            btnSword2.Location = new Point(768, 495);
            btnSword2.Name = "btnSword2";
            btnSword2.Size = new Size(60, 60);
            btnSword2.TabIndex = 32;
            btnSword2.UseVisualStyleBackColor = true;
            btnSword2.Click += btnSword2_Click;
            // 
            // btnSword1
            // 
            btnSword1.AutoSize = true;
            btnSword1.Location = new Point(702, 495);
            btnSword1.Name = "btnSword1";
            btnSword1.Size = new Size(60, 60);
            btnSword1.TabIndex = 31;
            btnSword1.UseVisualStyleBackColor = true;
            btnSword1.Click += btnSword1_Click;
            // 
            // btnArmor3
            // 
            btnArmor3.AutoSize = true;
            btnArmor3.Location = new Point(834, 561);
            btnArmor3.Name = "btnArmor3";
            btnArmor3.Size = new Size(60, 60);
            btnArmor3.TabIndex = 36;
            btnArmor3.UseVisualStyleBackColor = true;
            // 
            // btnArmor2
            // 
            btnArmor2.AutoSize = true;
            btnArmor2.Location = new Point(768, 561);
            btnArmor2.Name = "btnArmor2";
            btnArmor2.Size = new Size(60, 60);
            btnArmor2.TabIndex = 35;
            btnArmor2.UseVisualStyleBackColor = true;
            // 
            // btnArmor1
            // 
            btnArmor1.AutoSize = true;
            btnArmor1.Location = new Point(702, 561);
            btnArmor1.Name = "btnArmor1";
            btnArmor1.Size = new Size(60, 60);
            btnArmor1.TabIndex = 34;
            btnArmor1.UseVisualStyleBackColor = true;
            // 
            // btnGourde
            // 
            btnGourde.AutoSize = true;
            btnGourde.Location = new Point(210, 561);
            btnGourde.Name = "btnGourde";
            btnGourde.Size = new Size(60, 60);
            btnGourde.TabIndex = 37;
            btnGourde.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.AutoSize = true;
            btnInventory.Location = new Point(701, 375);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(84, 60);
            btnInventory.TabIndex = 38;
            btnInventory.Text = "Inventaire";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // lblPlayerDefense
            // 
            lblPlayerDefense.AutoSize = true;
            lblPlayerDefense.Location = new Point(12, 88);
            lblPlayerDefense.Name = "lblPlayerDefense";
            lblPlayerDefense.Size = new Size(103, 20);
            lblPlayerDefense.TabIndex = 39;
            lblPlayerDefense.Text = "PlayerDefense";
            // 
            // lblPlayerShield
            // 
            lblPlayerShield.AutoSize = true;
            lblPlayerShield.Location = new Point(12, 108);
            lblPlayerShield.Name = "lblPlayerShield";
            lblPlayerShield.Size = new Size(90, 20);
            lblPlayerShield.TabIndex = 40;
            lblPlayerShield.Text = "PlayerShield";
            // 
            // lblEnnemyShield
            // 
            lblEnnemyShield.AutoSize = true;
            lblEnnemyShield.Location = new Point(701, 108);
            lblEnnemyShield.Name = "lblEnnemyShield";
            lblEnnemyShield.Size = new Size(102, 20);
            lblEnnemyShield.TabIndex = 44;
            lblEnnemyShield.Text = "EnnemyShield";
            // 
            // lblEnnemyAttack
            // 
            lblEnnemyAttack.AutoSize = true;
            lblEnnemyAttack.Location = new Point(701, 128);
            lblEnnemyAttack.Name = "lblEnnemyAttack";
            lblEnnemyAttack.Size = new Size(103, 20);
            lblEnnemyAttack.TabIndex = 42;
            lblEnnemyAttack.Text = "EnnemyAttack";
            // 
            // lblEnnemyCurrentPv
            // 
            lblEnnemyCurrentPv.AutoSize = true;
            lblEnnemyCurrentPv.Location = new Point(701, 68);
            lblEnnemyCurrentPv.Name = "lblEnnemyCurrentPv";
            lblEnnemyCurrentPv.Size = new Size(78, 20);
            lblEnnemyCurrentPv.TabIndex = 41;
            lblEnnemyCurrentPv.Text = "EnnemyPV";
            // 
            // lblEnnemyDefense
            // 
            lblEnnemyDefense.Location = new Point(0, 0);
            lblEnnemyDefense.Name = "lblEnnemyDefense";
            lblEnnemyDefense.Size = new Size(100, 23);
            lblEnnemyDefense.TabIndex = 0;
            // 
            // lblEnnemyDef
            // 
            lblEnnemyDef.AutoSize = true;
            lblEnnemyDef.Location = new Point(702, 88);
            lblEnnemyDef.Name = "lblEnnemyDef";
            lblEnnemyDef.Size = new Size(115, 20);
            lblEnnemyDef.TabIndex = 45;
            lblEnnemyDef.Text = "EnnemyDefense";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 702);
            Controls.Add(lblEnnemyDef);
            Controls.Add(lblEnnemyDefense);
            Controls.Add(lblEnnemyShield);
            Controls.Add(lblEnnemyAttack);
            Controls.Add(lblEnnemyCurrentPv);
            Controls.Add(lblPlayerShield);
            Controls.Add(lblPlayerDefense);
            Controls.Add(btnInventory);
            Controls.Add(btnGourde);
            Controls.Add(btnArmor3);
            Controls.Add(btnArmor2);
            Controls.Add(btnArmor1);
            Controls.Add(btnSword3);
            Controls.Add(btnSword2);
            Controls.Add(btnSword1);
            Controls.Add(btnCocaBig);
            Controls.Add(btnCocaMedium);
            Controls.Add(btnCocaSmall);
            Controls.Add(btnHighLifePotion);
            Controls.Add(btnMediumLifePotion);
            Controls.Add(btnSmallLifePotion);
            Controls.Add(lblItem);
            Controls.Add(btnMapOpen);
            Controls.Add(lblPlayerPotion);
            Controls.Add(PbArena);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnHealEnnemy);
            Controls.Add(btnHealPlayer);
            Controls.Add(btnPlayerAttack);
            Controls.Add(btnEnnemyAttack);
            Controls.Add(lblPlayerAttack);
            Controls.Add(lblPlayerPv);
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
        private Label lblPlayerPv;
        private Label lblPlayerAttack;
        private Label lblEnnemyDefense;
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
        private Label lblItem;
        private Button btnSmallLifePotion;
        private Button btnMediumLifePotion;
        private Button btnHighLifePotion;
        private Button btnCocaBig;
        private Button btnCocaMedium;
        private Button btnCocaSmall;
        private Button btnSword3;
        private Button btnSword2;
        private Button btnSword1;
        private Button btnArmor3;
        private Button btnArmor2;
        private Button btnArmor1;
        private Button btnGourde;
        private Button btnInventory;
        private Label lblPlayerDefense;
        private Label lblPlayerShield;
        private Label lblEnnemyShield;
        private Label lblEnnemyAttack;
        private Label lblEnnemyCurrentPv;
        private Label lblEnnemyDef;
    }
}
