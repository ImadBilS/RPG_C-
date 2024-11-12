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


            lblHeroPvMax.Text += " : " + Global.heros.GetMaxHp();
            lblHeroCurrentPv.Text += " : " + Global.heros.GetCurrentHp();
            lblHeroMaxDefense.Text += " : " + Global.heros.GetMaxDefense();
            lblHeroDefense.Text += " : " + Global.heros.GetCurrentDefense();
            lblHeroAttack.Text += " : " + Global.heros.GetAttack();

            lblMonsterPvMax.Text += " : " + Global.monster.GetMaxHp();
            lblMonsterCurrentPv.Text += " : " + Global.monster.GetCurrentHp();
            lblMonsterMaxDefense.Text += " : " + Global.monster.GetMaxDefense();
            lblMonsterDefense.Text += " : " + Global.monster.GetCurrentDefense();
            lblMonsterAttack.Text += " : " + Global.monster.GetAttack();


        }

        private void btnMonsterAttack_Click(object sender, EventArgs e)
        {
            Global.monster.attackHero(Global.heros);

            lblHeroPvMax.Text = "HeroPvMax : " + Global.heros.GetMaxHp();
            lblHeroCurrentPv.Text = "HeroCurrentPv : " + Global.heros.GetCurrentHp();
            lblHeroMaxDefense.Text = "HeroMaxDefense : " + Global.heros.GetMaxDefense();
            lblHeroDefense.Text = "HeroDefense : " + Global.heros.GetCurrentDefense();
            lblHeroAttack.Text = "HeroAttack : " + Global.heros.GetAttack();


            lblMonsterPvMax.Text = "MonsterPvMax : " + Global.monster.GetMaxHp();
            lblMonsterCurrentPv.Text = "MonsterCurrentPv : " + Global.monster.GetCurrentHp();
            lblMonsterMaxDefense.Text = "MonsterMaxDefense : " + Global.monster.GetMaxDefense();
            lblMonsterDefense.Text = "MonsterDefense : " + Global.monster.GetCurrentDefense();
            lblMonsterAttack.Text = "MonsterAttack : " + Global.monster.GetAttack();
        }

        private void btnHeroAttack_Click(object sender, EventArgs e)
        {
            Global.heros.attackAMonster(Global.monster);

            lblHeroPvMax.Text = "HeroPvMax : " + Global.heros.GetMaxHp();
            lblHeroCurrentPv.Text = "HeroCurrentPv : " + Global.heros.GetCurrentHp();
            lblHeroMaxDefense.Text = "HeroMaxDefense : " + Global.heros.GetMaxDefense();
            lblHeroDefense.Text = "HeroDefense : " + Global.heros.GetCurrentDefense();
            lblHeroAttack.Text = "HeroAttack : " + Global.heros.GetAttack();


            lblMonsterPvMax.Text = "MonsterPvMax : " + Global.monster.GetMaxHp();
            lblMonsterCurrentPv.Text = "MonsterCurrentPv : " + Global.monster.GetCurrentHp();
            lblMonsterMaxDefense.Text = "MonsterMaxDefense : " + Global.monster.GetMaxDefense();
            lblMonsterDefense.Text = "MonsterDefense : " + Global.monster.GetCurrentDefense();
            lblMonsterAttack.Text = "MonsterAttack : " + Global.monster.GetAttack();
        }

        private void btnHealHero_Click(object sender, EventArgs e)
        {

        }
    }
}
