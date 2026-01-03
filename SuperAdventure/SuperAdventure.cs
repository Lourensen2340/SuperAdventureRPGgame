using Enginer;
namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Enginer.Location(1, "Home", "This is your house.");

            Location test1 = new Location(1, "Your House", "This is your house");

            Location test2 = new Location(1, "Your House", "This is your house", null, null, null);



        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {
            InitializeComponent();




            _player = new Player(10, 10, 20, 0, 1);

            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExpirencePoints = 0;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExpirencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

       

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
