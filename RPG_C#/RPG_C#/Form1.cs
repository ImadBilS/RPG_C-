using System.Windows.Forms;
using test_diminution;

namespace RPG_C_
{
    public partial class Form1 : Form
    {

        //Chemin de l'image pour le sprite du joueur 
        private string playerFight = @"img\player\fight.gif";
        private string playerAttack = @"img\player\attack.gif";
        private string ennemyFight = @"img\ennemy\king_slime.png";
        //private string playerAttack = @"img\player\fight.gif";
        private string forestArena = @"img\arena\land_small.png";
        private string ennemyAttackGif = @"img\effect\ennemy_attack.gif";
        private string playerHitted = @"img\player\hitted.png";
        private string playerHeal = @"img\player\healed.png";
        private string healEffect = @"img\effect\heal.gif";


        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(playerFight);

            //-----------------------------------------
            int rnd = Global.rnd.Next(1, 4);
            switch (rnd)
            {
                case 1:
                    ennemyFight = @"img\ennemy\Taurus.png";
                    break;
                case 2:
                    ennemyFight = @"img\ennemy\axeDragon.png";
                    break;
                case 3:
                    ennemyFight = @"img\ennemy\bat.png";
                    break;
                case 4:
                    ennemyFight = @"img\ennemy\zombie.png";
                    break;
                default:
                    ennemyFight = @"img\ennemy\king_slime.png";
                    break;
            }



            //-----------------------------------------

            if (File.Exists(ennemyFight))
            {
                pictureBox2.BackgroundImage = Image.FromFile(ennemyFight);
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Le fichier de l'image ennemyFight n'a pas été trouvé !");
            }

            if (File.Exists(forestArena))
            {
                PbArena.BackgroundImage = Image.FromFile(forestArena);
            }
            else
            {
                MessageBox.Show("Le fichier de l'image forestArena n'a pas été trouvé !");
            }

            // Définir la position et la taille de pictureBox2
            pictureBox2.Location = new Point(150, 50); // Ajustez selon vos besoins
            pictureBox2.Size = new Size(100, 100);    // Ajustez selon vos besoins

            // Définir pictureBox2 comme enfant de pbArena
            pictureBox2.Parent = PbArena;

            // Mettre pictureBox2 au premier plan
            pictureBox2.BringToFront();

            // Assurez-vous que la couleur de fond est transparente
            pictureBox2.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayerPv.Text += " : " + Global.player.GetCurrentHp() + " / " + Global.player.GetMaxHp();
            lblPlayerDefense.Text = "PlayerDefense : " + Global.player.GetDefense();
            lblPlayerShield.Text = "PlayerShield. : " + Global.player.GetShield();
            lblPlayerAttack.Text += " : " + Global.player.GetAttackPower();

            lblEnnemyCurrentPv.Text += " : " + Global.ennemy.GetCurrentHp() + " / " + Global.ennemy.GetMaxHp();
            lblEnnemyDef.Text = "EnnemyDefense : " + Global.ennemy.GetDefense();
            lblEnnemyShield.Text = "EnnemyShield : " + Global.ennemy.GetShield();
            lblEnnemyAttack.Text += " : " + Global.ennemy.GetAttackPower();

            btnSmallLifePotion.Image = Image.FromFile(@"img\items\heal_potion_small.png");
            btnMediumLifePotion.Image = Image.FromFile(@"img\items\heal_potion_medium.png");
            btnHighLifePotion.Image = Image.FromFile(@"img\items\heal_potion_high.png");
            btnSword1.Image = Image.FromFile(@"img\items\sword_lvl1.png");
            btnSword2.Image = Image.FromFile(@"img\items\sword_lvl2.png");
            btnSword3.Image = Image.FromFile(@"img\items\sword_lvl3.png");
            btnArmor1.Image = Image.FromFile(@"img\items\armor_lvl1.png");
            btnArmor2.Image = Image.FromFile(@"img\items\armor_lvl2.png");
            btnArmor3.Image = Image.FromFile(@"img\items\armor_lvl3.png");
            btnCocaSmall.Image = Image.FromFile(@"img\items\coca_shield_small.png");
            btnCocaMedium.Image = Image.FromFile(@"img\items\coca_shield_medium.png");
            btnCocaBig.Image = Image.FromFile(@"img\items\coca_shield_big.png");
            btnGourde.Image = Image.FromFile(@"img\items\gourde.png");

            btnSword1.Enabled = !Global.swordLv1.getIsEquipped();
            btnSword2.Enabled = !Global.swordLv2.getIsEquipped();
            //btnSword3.Enabled = !Global.swordLv3.getIsEquipped();

        }

        private void btnPlayerAttack_Click_1(object sender, EventArgs e)
        {
            Global.player.attackEnnemy(Global.ennemy);
            /*
            lblPlayerPvMax.Text = "PlayerPvMax : " + Global.player.GetMaxHp();
            
            lblPlayerCurrentPv.Text = "PlayerCurrentPv : " + Global.player.GetCurrentHp();
            
            lblPlayerDefense.Text = "PlayerDefense : " + Global.player.GetDefense();
            lblPlayerDefense.Text = "PlayerDefense : " + Global.player.GetShield();
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();
            */



            //lblEnnemyPvMax.Text = "EnnemyPvMax : " + Global.ennemy.GetMaxHp();
            lblEnnemyCurrentPv.Text = "EnnemyCurrentPv : " + Global.ennemy.GetCurrentHp();
            /*
            lblEnnemyDefense.Text = "EnnemyDefense : " + Global.ennemy.GetDefense();
            lblEnnemyDefense.Text = "EnnemyDefense : " + Global.ennemy.GetShield();
            lblEnnemyAttack.Text = "EnnemyAttack : " + Global.ennemy.GetAttackPower();
            */

            if (Global.ennemy.hasDied())
            {
                MessageBox.Show("You win");
            }

            pictureBox2.Image = Image.FromFile(playerAttack);
            playerAttackTimer.Start();
        }

        private void btnEnnemyAttack_Click_1(object sender, EventArgs e)
        {
            Global.ennemy.attackPlayer(Global.player);

            lblPlayerPv.Text = "PlayerCurrentPv : " + Global.player.GetCurrentHp() + "/" + Global.player.GetMaxHp();
            lblPlayerDefense.Text = "PlayerDefense : " + Global.player.GetDefense();
            lblPlayerShield.Text = "PlayerShield. : " + Global.player.GetShield();
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();



            lblEnnemyCurrentPv.Text = "EnnemyCurrentPv : " + Global.ennemy.GetCurrentHp() + "/" + Global.ennemy.GetMaxHp();
            lblEnnemyDef.Text = "EnnemyDefense : " + Global.ennemy.GetDefense();
            lblEnnemyShield.Text = "EnnemyShield : " + Global.ennemy.GetShield();
            lblEnnemyAttack.Text = "EnnemyAttack : " + Global.ennemy.GetAttackPower();
            if (Global.player.hasDied())
            {
                MessageBox.Show("You lose");
            }

            //ennemyAttack.Image = Image.FromFile(ennemyAttackGif);
            pictureBox1.BackgroundImage = Image.FromFile(playerHitted);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Image.FromFile(ennemyAttackGif);
            ennemyAttackTimer.Start();
        }

        private void btnHealPlayer_Click(object sender, EventArgs e)
        {

            if (Global.player.GetCurrentHp() < Global.player.GetMaxHp())
            {

                if (Global.player.GetCurrentHp() + 20 > Global.player.GetMaxHp())
                {
                    Global.player.SetCurrentHp(Global.player.GetMaxHp());
                }
                else
                {

                }

                lblPlayerPv.Text = "PlayerCurrentPv : " + Global.player.GetCurrentHp();

                pictureBox1.BackgroundImage = Image.FromFile(playerHeal);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Image.FromFile(healEffect);
                playerHealTimer.Start();
            }
            else
            {
                MessageBox.Show("You are full life");
            }


            /*
        if (Global.player.GetCurrentHp() > Global.player.GetMaxHp())
        {
            Global.player.SetCurrentHp(Global.player.GetMaxHp());
            MessageBox.Show("You are full life");
        }

            
            if (Global.player.getNbLifePotion() == 0)
            {
                btnHealPlayer.Enabled = false;
                MessageBox.Show("You don't have any more life potion");
            }
            */




        }

        private void playerAttackTimer_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            playerAttackTimer.Stop();
        }

        private void ennemyAttackTimer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(playerFight);
            pictureBox1.BackgroundImage = null;
            ennemyAttackTimer.Stop();
        }

        private void playerHealTimer_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile(playerFight);
            pictureBox1.BackgroundImage = null;
            ennemyAttackTimer.Stop();
        }

        private void btnMapOpen_Click(object sender, EventArgs e)
        {
            Map laNouvelleFenetreMap = new Map();
            laNouvelleFenetreMap.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FormInventoryTest formInventoryTest = new FormInventoryTest();
            formInventoryTest.Show();

        }

        private void btnSword1_Click(object sender, EventArgs e)
        {
            Global.player.equipNewSword(Global.swordLv1);
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();
            Global.swordLv1.setIsEquipped(true);
            btnSword1.Enabled = false;
            btnSword2.Enabled = true;
            btnSword3.Enabled = true;

        }

        private void btnSword2_Click(object sender, EventArgs e)
        {
            Global.player.equipNewSword(Global.swordLv2);
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();
            Global.swordLv2.setIsEquipped(true);
            btnSword2.Enabled = false;
            btnSword1.Enabled = true;
            btnSword3.Enabled = true;
        }

        private void btnSword3_Click(object sender, EventArgs e)
        {
            Global.player.equipNewSword(Global.swordLv3);
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();
            Global.swordLv2.setIsEquipped(true);
            btnSword3.Enabled = false;
            btnSword1.Enabled = true;
            btnSword2.Enabled = true;

        }
    }
}
