using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using silnik;

namespace Super_przygoda
{
    public partial class Przygoda : Form
   
    {
        private Player _player;
        public Przygoda()
        {
            InitializeComponent();

            Location location = new Location();
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";

            _player = new Player();

            _player.CurrentHitPoints = 100;
            _player.MaximumHitPoints = 100;
            _player.CurrentBatteries = 100;
            _player.MaximumBatteries = 100;
            _player.Platinum = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            lblżycie.Text = _player.CurrentHitPoints.ToString();
            lblbaterie.Text = _player.CurrentBatteries.ToString();
            lblplatinium.Text = _player.Platinum.ToString();
            lbldoświadczenie.Text = _player.ExperiencePoints.ToString();
            lblpoziom.Text = _player.Level.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Przygoda_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
