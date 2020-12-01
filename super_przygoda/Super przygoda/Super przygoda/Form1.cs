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

            Location lokacja = new Location(1, "Stacja", "To jest twoja stacja dokująca");


            _player = new Player(100,100,100,100,10,0,1);

           // _player.CurrentHitPoints = 100;
           // _player.MaximumHitPoints = 100;
           // _player.CurrentBatteries = 100;
           // _player.MaximumBatteries = 100;
           // _player.Platinum = 20;
           // _player.ExperiencePoints = 0;
           // _player.Level = 1;

            lblżycie.Text = _player.CurrentHitPoints.ToString();
            lblbaterie.Text = _player.CurrentBatteries.ToString();
            lblplatinium.Text = _player.Platinum.ToString();
            lbldoświadczenie.Text = _player.ExperiencePoints.ToString();
            lblpoziom.Text = _player.Level.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Przygoda_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
