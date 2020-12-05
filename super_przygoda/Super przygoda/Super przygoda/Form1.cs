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
        private Monster _currentMonster;
        public Przygoda()
        {
            InitializeComponent();

            _player = new Player(100, 100, 100, 100, 10, 0, 1);
            MoveTo(World.LocationById(World.LOCATION_ID_DOK));
            _player.Inventory.Add(new InvertoryItem(World.ItemByID(World.ITEM_ID_PODSTAWOWE_DZIAŁO), 1));
            _player.Inventory.Add(new InvertoryItem(World.ItemByID(World.ITEM_ID_SUN_SAILS), 1));

            // dane początkowe Gracza
            // _player.CurrentHitPoints = 100;
            // _player.MaximumHitPoints = 100;
            // _player.CurrentBatteries = 100;
            // _player.MaximumBatteries = 100;
            // _player.Platinum = 20;
            // _player.ExperiencePoints = 0;
            // _player.Level = 1;
            // _paler.CurrentLocation = Doki;
            // _player.Item = Podstawowe Działo;

            lblżycie.Text = _player.CurrentHitPoints.ToString();
            lblbaterie.Text = _player.CurrentBatteries.ToString();
            lblplatinium.Text = _player.Platinum.ToString();
            lbldoświadczenie.Text = _player.ExperiencePoints.ToString();
            lblpoziom.Text = _player.Level.ToString();
        }
        private void rtbLocation_TextChanged(object sender, EventArgs e)
        {

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

        private void btnProsto_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationPrzod);

        }

        private void btenLewo_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationLewo);
        }

        private void btnPrawo_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationPrawo);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationTył);
        }
        private void MoveTo(Location newlocation)
        {
            if (newlocation.ItemRequiredToEnter != null)
            {
                bool playerHasRequiredItem = false;
                foreach (InvertoryItem ii in _player.Inventory)
                {
                    if (ii.Details.ID == newlocation.ItemRequiredToEnter.ID)
                    {
                        playerHasRequiredItem = true;
                        break;
                    }
                }
                if (!playerHasRequiredItem)
                {
                    if (!playerHasRequiredItem)
                    {
                        rtbMessages.Text += "Musisz posiadać" +
                            newlocation.ItemRequiredToEnter.Name + "by tu wlecieć" + Environment.NewLine;
                        return;
                    }
                }
                _player.CurrentLocation = newlocation;
                btnProsto.Visible = (newlocation.LocationPrzod != null);
                btnBack.Visible = (newlocation.LocationTył != null);
                btnPrawo.Visible = (newlocation.LocationPrawo != null);
                btnLewo.Visible = (newlocation.LocationLewo != null);

                rtbLocation.Text = newlocation.Name + Environment.NewLine;
                rtbLocation.Text += newlocation.Description + Environment.NewLine;

                _player.CurrentHitPoints = _player.MaximumHitPoints;
                _player.CurrentBatteries = _player.CurrentBatteries - 5;

                lblżycie.Text = _player.CurrentHitPoints.ToString();
                lblbaterie.Text = _player.CurrentBatteries.ToString();

                if (newlocation.QuestAvailableHere != null)
                {
                    bool playerAlreadyHasQuest = false;
                    bool playerAlreadyCopletedQuest = false;
                    foreach (PlayerQuest playerQuest in _player.Quests)
                    {
                        if (playerQuest.Details.ID == newlocation.QuestAvailableHere.ID)
                        {
                            playerAlreadyHasQuest = true;
                            if (playerQuest.IsCompleted)
                            {
                                playerAlreadyCopletedQuest = true;
                            }
                        }
                    }
                    if (playerAlreadyHasQuest)
                    {
                        if (!playerAlreadyCopletedQuest)
                        {
                            bool playerHasAllItemsToCompleteQuest = true;
                            foreach (QuestCompletionItem qci in newlocation.QuestAvailableHere.QuestCompletionItem)
                            {
                                bool foundItemInPlayersInventory = false;
                                foreach (InvertoryItem ii in _player.Inventory)
                                {
                                    if (ii.Details.ID == qci.Details.ID)
                                    {
                                        foundItemInPlayersInventory = true;

                                        if (ii.Quantity < qci.Quantity)
                                        {
                                            playerHasAllItemsToCompleteQuest = false;
                                            break;
                                        }
                                        break;
                                    }
                                }
                                if (!foundItemInPlayersInventory)
                                {
                                    playerHasAllItemsToCompleteQuest = false;
                                    break;
                                }
                            }
                            if (playerHasAllItemsToCompleteQuest)
                            {
                                rtbMessages.Text += Environment.NewLine;
                                rtbMessages.Text += "Ukończyłeś misję:"
                                    + newlocation.QuestAvailableHere.Name + Environment.NewLine;
                                foreach (QuestCompletionItem qci in newlocation.QuestAvailableHere.QuestCompletionItem)
                                {
                                    foreach (InvertoryItem ii in _player.Inventory)
                                    {
                                        if (ii.Details.ID == qci.Details.ID)
                                        {
                                            ii.Quantity -= qci.Quantity;
                                            break;
                                        }
                                    }
                                }
                                rtbMessages.Text += "Otrzymujesz:" + Environment.NewLine;
                                rtbMessages.Text += newlocation.QuestAvailableHere.RewardExperience.ToString() +
                                    " Punktów doświadczenia" + Environment.NewLine;
                                rtbMessages.Text += newlocation.QuestAvailableHere.RewardPlatinum.ToString() +
                                    " Platinum" + Environment.NewLine;
                                rtbMessages.Text += newlocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                                rtbMessages.Text += Environment.NewLine;

                                _player.ExperiencePoints += newlocation.QuestAvailableHere.RewardExperience;
                                _player.Platinum += newlocation.QuestAvailableHere.RewardPlatinum;

                                bool addedItemToPlayerInventory = false;

                                foreach (InvertoryItem ii in _player.Inventory)
                                {
                                    if (ii.Details.ID == newlocation.QuestAvailableHere.RewardItem.ID)
                                    {
                                        ii.Quantity++;
                                        addedItemToPlayerInventory = true;
                                        break;
                                    }
                                }
                                if (!addedItemToPlayerInventory)
                                {
                                    _player.Inventory.Add(new InvertoryItem(newlocation.QuestAvailableHere.RewardItem, 1));
                                }
                                foreach (PlayerQuest pq in _player.Quests)
                                {
                                    if (pq.Details.ID == newlocation.QuestAvailableHere.ID)
                                    {
                                        pq.IsCompleted = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        rtbMessages.Text += "Otrzymujesz misję" + newlocation.QuestAvailableHere.Name + Environment.NewLine;
                        rtbMessages.Text += newlocation.QuestAvailableHere.Description + Environment.NewLine;
                        rtbMessages.Text += "Aby ją zakończyć powróć z:" + Environment.NewLine;
                        foreach (QuestCompletionItem qci in newlocation.QuestAvailableHere.QuestCompletionItem)
                        {
                            if (qci.Quantity == 1)
                            {
                                rtbMessages.Text += qci.Quantity.ToString() + " " +
                                    qci.Details.Name + Environment.NewLine;
                            }
                            else
                            {
                                rtbMessages.Text += qci.Quantity.ToString() + " " +
                                    qci.Details.Name + Environment.NewLine;
                            }
                        }
                        rtbMessages.Text += Environment.NewLine;
                        _player.Quests.Add(new PlayerQuest(newlocation.QuestAvailableHere));
                    }
                }
                if (newlocation.MonsterLivinHere != null)
                {
                    rtbMessages.Text += "Widzisz" + newlocation.MonsterLivinHere.Name + Environment.NewLine;
                    Monster standardMonster = World.MonsterByID(newlocation.MonsterLivinHere.ID);

                    _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage,
                        standardMonster.RewardExpiriencePoints, standardMonster.RewardPlatinium,
                        standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);
                    foreach (LootItem lootItem in standardMonster.LootTable)
                    {
                        _currentMonster.LootTable.Add(lootItem);
                    }
                    cboWeapons.Visible = true;
                    cboRepairKits.Visible = true;
                    btnUseWeapon.Visible = true;
                    btnUseRepairKit.Visible = true;
                    btnUseSunSails.Visible = true;
                }
                else
                {
                    _currentMonster = null;

                    cboWeapons.Visible = true;
                    cboRepairKits.Visible = true;
                    btnUseWeapon.Visible = true;
                    btnUseSunSails.Visible = true;
                    btnUseRepairKit.Visible = true;
                }
                dgvInventory.RowHeadersVisible = false;
                dgvInventory.ColumnCount = 2;
                dgvInventory.Columns[0].Name = "Nazwa";
                dgvInventory.Columns[0].Width = 210;
                dgvInventory.Columns[1].Name = "Ilość";
                dgvInventory.Rows.Clear();

                foreach (InvertoryItem inventoryItem in _player.Inventory)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                    }
                }

                {
                    _currentMonster = null;
                    cboWeapons.Visible = false;
                    cboRepairKits.Visible = false;
                    cboSunSails.Visible = true;
                    btnUseWeapon.Visible = false;
                    btnUseRepairKit.Visible = false;
                    btnUseSunSails.Visible = true;
                }
                dgvInventory.RowHeadersVisible = false;
                dgvInventory.ColumnCount = 2;
                dgvInventory.Columns[0].Name = "Nazwa";
                dgvInventory.Columns[0].Width = 197;
                dgvInventory.Columns[1].Name = "Ilość";

                dgvInventory.Rows.Clear();

                foreach (InvertoryItem invertoryItem in _player.Inventory)
                {
                    dgvInventory.Rows.Add(new[] { invertoryItem.Details.Name, invertoryItem.Quantity.ToString() });
                }
            }
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Nazwa";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Ukończone?";

            dgvQuests.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }
            List<Weapon> weapons = new List<Weapon>();
            foreach(InvertoryItem invertoryItem in _player.Inventory)
            {
                if (invertoryItem.Details is Weapon)
                {
                    if(invertoryItem.Quantity>0)
                            {
                        weapons.Add((Weapon)invertoryItem.Details);
                    }
                }
            }
            if (weapons.Count==0)
            {
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Nazwa";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
            List<SunSails> sunSails = new List<SunSails>();

            foreach (InvertoryItem invertoryItem in _player.Inventory)
            {
                if(invertoryItem.Details is SunSails)
                {
                    if(invertoryItem.Quantity>0)
                    {
                        sunSails.Add((SunSails)invertoryItem.Details);
                    }
                }
            }
            if(sunSails.Count==0)
            {
                cboSunSails.Visible = false;
                btnUseSunSails.Visible = false;
            }
            else
            {
                cboSunSails.DataSource = sunSails;
                cboSunSails.DisplayMember = "Nazwa";
                cboSunSails.ValueMember = "ID";

                cboSunSails.SelectedIndex = 0;
            }
            List<RepairKit> repairKits = new List<RepairKit>();
            foreach (InvertoryItem invertoryItem in _player.Inventory)
            {
                if(invertoryItem.Details is RepairKit)
                {
                    if (invertoryItem.Quantity>0)
                    {
                        repairKits.Add((RepairKit)invertoryItem.Details);
                    }
                }
            }
            if (repairKits.Count==0)
            {
                cboRepairKits.Visible = false;
                btnUseRepairKit.Visible = false;
            }
            else
            {
                cboRepairKits.DataSource = repairKits;
                cboRepairKits.DisplayMember = "Nazwa";
                cboRepairKits.ValueMember = "ID";

                cboRepairKits.SelectedIndex = 0;
            }
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUseRepairKit_Click(object sender, EventArgs e)
        {

        }

        private void btnUseSunSails_Click(object sender, EventArgs e)
        {

        }
    }
}


