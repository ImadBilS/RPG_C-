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
            lblHeroPvMax = new Label();
            lblHeroMaxDefense = new Label();
            lblHeroCurrentPv = new Label();
            lblHeroDefense = new Label();
            lblHeroAttack = new Label();
            lblMonsterAttack = new Label();
            lblMonsterDefense = new Label();
            lblMonsterCurrentPv = new Label();
            lblMonsterMaxDefense = new Label();
            lblMonsterPvMax = new Label();
            SuspendLayout();
            // 
            // lblHeroPvMax
            // 
            lblHeroPvMax.AutoSize = true;
            lblHeroPvMax.Location = new Point(109, 45);
            lblHeroPvMax.Name = "lblHeroPvMax";
            lblHeroPvMax.Size = new Size(85, 20);
            lblHeroPvMax.TabIndex = 0;
            lblHeroPvMax.Text = "HeroPvMax";
            // 
            // lblHeroMaxDefense
            // 
            lblHeroMaxDefense.AutoSize = true;
            lblHeroMaxDefense.Location = new Point(109, 108);
            lblHeroMaxDefense.Name = "lblHeroMaxDefense";
            lblHeroMaxDefense.Size = new Size(124, 20);
            lblHeroMaxDefense.TabIndex = 1;
            lblHeroMaxDefense.Text = "HeroMaxDefense";
            // 
            // lblHeroCurrentPv
            // 
            lblHeroCurrentPv.AutoSize = true;
            lblHeroCurrentPv.Location = new Point(109, 76);
            lblHeroCurrentPv.Name = "lblHeroCurrentPv";
            lblHeroCurrentPv.Size = new Size(105, 20);
            lblHeroCurrentPv.TabIndex = 2;
            lblHeroCurrentPv.Text = "HeroCurrentPv";
            // 
            // lblHeroDefense
            // 
            lblHeroDefense.AutoSize = true;
            lblHeroDefense.Location = new Point(109, 138);
            lblHeroDefense.Name = "lblHeroDefense";
            lblHeroDefense.Size = new Size(96, 20);
            lblHeroDefense.TabIndex = 3;
            lblHeroDefense.Text = "HeroDefense";
            // 
            // lblHeroAttack
            // 
            lblHeroAttack.AutoSize = true;
            lblHeroAttack.Location = new Point(109, 171);
            lblHeroAttack.Name = "lblHeroAttack";
            lblHeroAttack.Size = new Size(84, 20);
            lblHeroAttack.TabIndex = 4;
            lblHeroAttack.Text = "HeroAttack";
            // 
            // lblMonsterAttack
            // 
            lblMonsterAttack.AutoSize = true;
            lblMonsterAttack.Location = new Point(384, 171);
            lblMonsterAttack.Name = "lblMonsterAttack";
            lblMonsterAttack.Size = new Size(105, 20);
            lblMonsterAttack.TabIndex = 14;
            lblMonsterAttack.Text = "MonsterAttack";
            // 
            // lblMonsterDefense
            // 
            lblMonsterDefense.AutoSize = true;
            lblMonsterDefense.Location = new Point(384, 138);
            lblMonsterDefense.Name = "lblMonsterDefense";
            lblMonsterDefense.Size = new Size(117, 20);
            lblMonsterDefense.TabIndex = 13;
            lblMonsterDefense.Text = "MonsterDefense";
            // 
            // lblMonsterCurrentPv
            // 
            lblMonsterCurrentPv.AutoSize = true;
            lblMonsterCurrentPv.Location = new Point(384, 76);
            lblMonsterCurrentPv.Name = "lblMonsterCurrentPv";
            lblMonsterCurrentPv.Size = new Size(126, 20);
            lblMonsterCurrentPv.TabIndex = 12;
            lblMonsterCurrentPv.Text = "MonsterCurrentPv";
            // 
            // lblMonsterMaxDefense
            // 
            lblMonsterMaxDefense.AutoSize = true;
            lblMonsterMaxDefense.Location = new Point(384, 108);
            lblMonsterMaxDefense.Name = "lblMonsterMaxDefense";
            lblMonsterMaxDefense.Size = new Size(145, 20);
            lblMonsterMaxDefense.TabIndex = 11;
            lblMonsterMaxDefense.Text = "MonsterMaxDefense";
            // 
            // lblMonsterPvMax
            // 
            lblMonsterPvMax.AutoSize = true;
            lblMonsterPvMax.Location = new Point(384, 45);
            lblMonsterPvMax.Name = "lblMonsterPvMax";
            lblMonsterPvMax.Size = new Size(106, 20);
            lblMonsterPvMax.TabIndex = 10;
            lblMonsterPvMax.Text = "MonsterPvMax";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMonsterAttack);
            Controls.Add(lblMonsterDefense);
            Controls.Add(lblMonsterCurrentPv);
            Controls.Add(lblMonsterMaxDefense);
            Controls.Add(lblMonsterPvMax);
            Controls.Add(lblHeroAttack);
            Controls.Add(lblHeroDefense);
            Controls.Add(lblHeroCurrentPv);
            Controls.Add(lblHeroMaxDefense);
            Controls.Add(lblHeroPvMax);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeroPvMax;
        private Label lblHeroMaxDefense;
        private Label lblHeroCurrentPv;
        private Label lblHeroDefense;
        private Label lblHeroAttack;
        private Label lblMonsterAttack;
        private Label lblMonsterDefense;
        private Label lblMonsterCurrentPv;
        private Label lblMonsterMaxDefense;
        private Label lblMonsterPvMax;
    }
}
