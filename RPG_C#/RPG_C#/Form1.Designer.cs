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
            SuspendLayout();
            // 
            // lblPlayerPvMax
            // 
            lblPlayerPvMax.AutoSize = true;
            lblPlayerPvMax.Location = new Point(109, 45);
            lblPlayerPvMax.Name = "lblPlayerPvMax";
            lblPlayerPvMax.Size = new Size(92, 20);
            lblPlayerPvMax.TabIndex = 0;
            lblPlayerPvMax.Text = "PlayerPvMax";
            // 
            // lblPlayerMaxDefense
            // 
            lblPlayerMaxDefense.AutoSize = true;
            lblPlayerMaxDefense.Location = new Point(109, 108);
            lblPlayerMaxDefense.Name = "lblPlayerMaxDefense";
            lblPlayerMaxDefense.Size = new Size(131, 20);
            lblPlayerMaxDefense.TabIndex = 1;
            lblPlayerMaxDefense.Text = "PlayerMaxDefense";
            // 
            // lblPlayerCurrentPv
            // 
            lblPlayerCurrentPv.AutoSize = true;
            lblPlayerCurrentPv.Location = new Point(109, 76);
            lblPlayerCurrentPv.Name = "lblPlayerCurrentPv";
            lblPlayerCurrentPv.Size = new Size(112, 20);
            lblPlayerCurrentPv.TabIndex = 2;
            lblPlayerCurrentPv.Text = "PlayerCurrentPv";
            // 
            // lblPlayerDefense
            // 
            lblPlayerDefense.AutoSize = true;
            lblPlayerDefense.Location = new Point(109, 138);
            lblPlayerDefense.Name = "lblPlayerDefense";
            lblPlayerDefense.Size = new Size(103, 20);
            lblPlayerDefense.TabIndex = 3;
            lblPlayerDefense.Text = "PlayerDefense";
            // 
            // lblPlayerAttack
            // 
            lblPlayerAttack.AutoSize = true;
            lblPlayerAttack.Location = new Point(109, 171);
            lblPlayerAttack.Name = "lblPlayerAttack";
            lblPlayerAttack.Size = new Size(91, 20);
            lblPlayerAttack.TabIndex = 4;
            lblPlayerAttack.Text = "PlayerAttack";
            // 
            // lblEnnemyAttack
            // 
            lblEnnemyAttack.AutoSize = true;
            lblEnnemyAttack.Location = new Point(384, 171);
            lblEnnemyAttack.Name = "lblEnnemyAttack";
            lblEnnemyAttack.Size = new Size(103, 20);
            lblEnnemyAttack.TabIndex = 14;
            lblEnnemyAttack.Text = "EnnemyAttack";
            // 
            // lblEnnemyDefense
            // 
            lblEnnemyDefense.AutoSize = true;
            lblEnnemyDefense.Location = new Point(384, 138);
            lblEnnemyDefense.Name = "lblEnnemyDefense";
            lblEnnemyDefense.Size = new Size(115, 20);
            lblEnnemyDefense.TabIndex = 13;
            lblEnnemyDefense.Text = "EnnemyDefense";
            // 
            // lblEnnemyCurrentPv
            // 
            lblEnnemyCurrentPv.AutoSize = true;
            lblEnnemyCurrentPv.Location = new Point(384, 76);
            lblEnnemyCurrentPv.Name = "lblEnnemyCurrentPv";
            lblEnnemyCurrentPv.Size = new Size(124, 20);
            lblEnnemyCurrentPv.TabIndex = 12;
            lblEnnemyCurrentPv.Text = "EnnemyCurrentPv";
            // 
            // lblEnnemyMaxDefense
            // 
            lblEnnemyMaxDefense.AutoSize = true;
            lblEnnemyMaxDefense.Location = new Point(384, 108);
            lblEnnemyMaxDefense.Name = "lblEnnemyMaxDefense";
            lblEnnemyMaxDefense.Size = new Size(143, 20);
            lblEnnemyMaxDefense.TabIndex = 11;
            lblEnnemyMaxDefense.Text = "EnnemyMaxDefense";
            // 
            // lblEnnemyPvMax
            // 
            lblEnnemyPvMax.AutoSize = true;
            lblEnnemyPvMax.Location = new Point(384, 45);
            lblEnnemyPvMax.Name = "lblEnnemyPvMax";
            lblEnnemyPvMax.Size = new Size(104, 20);
            lblEnnemyPvMax.TabIndex = 10;
            lblEnnemyPvMax.Text = "EnnemyPvMax";
            // 
            // btnEnnemyAttack
            // 
            btnEnnemyAttack.AutoSize = true;
            btnEnnemyAttack.Location = new Point(384, 223);
            btnEnnemyAttack.Name = "btnEnnemyAttack";
            btnEnnemyAttack.Size = new Size(94, 30);
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
            btnPlayerAttack.Size = new Size(94, 30);
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
            btnHealPlayer.Size = new Size(94, 30);
            btnHealPlayer.TabIndex = 17;
            btnHealPlayer.Text = "Heal";
            btnHealPlayer.UseVisualStyleBackColor = true;
            btnHealPlayer.Click += btnHealPlayer_Click;
            // 
            // btnHealEnnemy
            // 
            btnHealEnnemy.AutoSize = true;
            btnHealEnnemy.Location = new Point(384, 269);
            btnHealEnnemy.Name = "btnHealEnnemy";
            btnHealEnnemy.Size = new Size(94, 30);
            btnHealEnnemy.TabIndex = 18;
            btnHealEnnemy.Text = "Heal";
            btnHealEnnemy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
