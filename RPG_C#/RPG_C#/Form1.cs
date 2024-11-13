namespace RPG_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
    }
}
