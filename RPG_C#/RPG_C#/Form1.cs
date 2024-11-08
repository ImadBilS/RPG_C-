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
            Heros heros = new Heros(90, 100, 11, 13, 12);
            Monster monster = new Monster(90, 100, 13, 13, 12);

            lblHeroPvMax.Text += " : "+heros.GetMaxHp();
            lblHeroCurrentPv.Text += " : " + heros.GetCurrentHp();
            lblHeroMaxDefense.Text += " : " + heros.GetMaxDefense();
            lblHeroDefense.Text += " : " + heros.GetCurrentDefense();
            lblHeroAttack.Text += " : " + heros.GetAttack();

            lblMonsterPvMax.Text += " : " + monster.GetMaxHp();
            lblMonsterCurrentPv.Text += " : " + monster.GetCurrentHp();
            lblMonsterMaxDefense.Text += " : " + monster.GetMaxDefense();
            lblMonsterDefense.Text += " : " + monster.GetCurrentDefense();
            lblMonsterAttack.Text += " : " + monster.GetAttack();


        }
    }
}
