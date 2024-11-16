using System.Windows.Forms;

namespace RPG_C_
{
    public partial class Form1 : Form
    {
        //Chemin de l'image pour le sprite du joueur 
        private string playerFight = @"img\player\fight.gif";
        private string playerAttack = @"img\player\attack.gif";
        private string ennemyFight = @"img\ennemy\king_slime.png";
        //private string playerAttack = @"img\player\fight.gif";
        private string forestArena = @"img\arena\forest.png";
        private string ennemyAttackGif = @"img\ennemy\ennemy_attack.gif";


        public Form1()
        {
            InitializeComponent();
            /*
            pictureBox1.Image = Image.FromFile(playerFight);
            //pictureBox2.Image = Image.FromFile(ennemyFight);
            
            pictureBox2.BackgroundImage = Image.FromFile(ennemyFight);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            PbArena.BackgroundImage = Image.FromFile(forestArena);
            pictureBox2.BackColor = Color.Transparent;
            */


            pictureBox1.Image = Image.FromFile(playerFight);

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
            pictureBox2.Location = new Point(75, 50); // Ajustez selon vos besoins
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
            lblPlayerPvMax.Text += " : " + Global.player.GetMaxHp();
            lblPlayerCurrentPv.Text += " : " + Global.player.GetCurrentHp();
            lblPlayerMaxDefense.Text += " : " + Global.player.GetMaxDefense();
            lblPlayerDefense.Text += " : " + Global.player.GetCurrentDefense();
            lblPlayerAttack.Text += " : " + Global.player.GetAttackPower();

            lblEnnemyPvMax.Text += " : " + Global.ennemy.GetMaxHp();
            lblEnnemyCurrentPv.Text += " : " + Global.ennemy.GetCurrentHp();
            lblEnnemyMaxDefense.Text += " : " + Global.ennemy.GetMaxDefense();
            lblEnnemyDefense.Text += " : " + Global.ennemy.GetCurrentDefense();
            lblEnnemyAttack.Text += " : " + Global.ennemy.GetAttackPower();
        }

        private void btnPlayerAttack_Click_1(object sender, EventArgs e)
        {
            Global.player.attackEnnemy(Global.ennemy);

            lblPlayerPvMax.Text = "PlayerPvMax : " + Global.player.GetMaxHp();
            lblPlayerCurrentPv.Text = "PlayerCurrentPv : " + Global.player.GetCurrentHp();
            lblPlayerMaxDefense.Text = "PlayerMaxDefense : " + Global.player.GetMaxDefense();
            lblPlayerDefense.Text = "PlayerDefense : " + Global.player.GetCurrentDefense();
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();


            lblEnnemyPvMax.Text = "EnnemyPvMax : " + Global.ennemy.GetMaxHp();
            lblEnnemyCurrentPv.Text = "EnnemyCurrentPv : " + Global.ennemy.GetCurrentHp();
            lblEnnemyMaxDefense.Text = "EnnemyMaxDefense : " + Global.ennemy.GetMaxDefense();
            lblEnnemyDefense.Text = "EnnemyDefense : " + Global.ennemy.GetCurrentDefense();
            lblEnnemyAttack.Text = "EnnemyAttack : " + Global.ennemy.GetAttackPower();

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

            lblPlayerPvMax.Text = "PlayerPvMax : " + Global.player.GetMaxHp();
            lblPlayerCurrentPv.Text = "PlayerCurrentPv : " + Global.player.GetCurrentHp();
            lblPlayerMaxDefense.Text = "PlayerMaxDefense : " + Global.player.GetMaxDefense();
            lblPlayerDefense.Text = "PlayerDefense : " + Global.player.GetCurrentDefense();
            lblPlayerAttack.Text = "PlayerAttack : " + Global.player.GetAttackPower();


            lblEnnemyPvMax.Text = "EnnemyPvMax : " + Global.ennemy.GetMaxHp();
            lblEnnemyCurrentPv.Text = "EnnemyCurrentPv : " + Global.ennemy.GetCurrentHp();
            lblEnnemyMaxDefense.Text = "EnnemyMaxDefense : " + Global.ennemy.GetMaxDefense();
            lblEnnemyDefense.Text = "EnnemyDefense : " + Global.ennemy.GetCurrentDefense();
            lblEnnemyAttack.Text = "EnnemyAttack : " + Global.ennemy.GetAttackPower();
            /*
            if (Global.player.GetCurrentHp() <= 0)
            {
                MessageBox.Show("You lose");
            }
            else if (Global.ennemy.GetCurrentHp() <= 0)
            {
                MessageBox.Show("You win");
            }
            */
            if (Global.player.hasDied())
            {
                MessageBox.Show("You lose");
            }

            //ennemyAttack.Image = Image.FromFile(ennemyAttackGif);
            pictureBox1.BackgroundImage = Image.FromFile(playerFight);
            pictureBox1.Image = Image.FromFile(ennemyAttackGif);
            ennemyAttackTimer.Start();
        }

        private void btnHealPlayer_Click(object sender, EventArgs e)
        {
            Global.player.heal();
            lblPlayerCurrentPv.Text = "PlayerCurrentPv : " + Global.player.GetCurrentHp();
            if (Global.player.getNbLifePotion() == 0)
            {
                btnHealPlayer.Enabled = false;
                MessageBox.Show("You don't have any more life potion");
            }
        }

        private void playerAttackTimer_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            playerAttackTimer.Stop();
        }

        private void ennemyAttackTimer_Tick(object sender, EventArgs e)
        {
            ennemyAttack.Image = null;
            pictureBox1.Image = Image.FromFile(playerFight);
            pictureBox1.BackgroundImage = null;
            ennemyAttackTimer.Stop();
        }


    }
}
