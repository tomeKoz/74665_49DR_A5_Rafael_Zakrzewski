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

            _player = new Player(100,100,100,100,100,0,1);
            MoveTo(World.LocationById(World.LOCATION_ID_DOK));
            _player.Inventory.Add(new InvertoryItem(World.ItemByID(World.ITEM_ID_PODSTAWOWE_DZIAŁO), 1));
            _player.Inventory.Add(new InvertoryItem(World.ItemByID(World.ITEM_ID_SUN_SAILS), 1));

            lblżycie.Text = _player.CurrentHitPoints.ToString();
            lblbaterie.Text = _player.CurrentBatteries.ToString();
            lblplatinium.Text = _player.Platinum.ToString();
            lbldoświadczenie.Text = _player.ExperiencePoints.ToString();
            lblpoziom.Text = _player.Level.ToString();
        }
        private void Przygoda_Load(object sender, EventArgs e)
        {

        }
        private void rtbLocation_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
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
            if (!_player.HasRequiredItemToEnterThisLocation(newlocation))
            {
                rtbMessages.Text += "Musisz posiadać" + newlocation.ItemRequiredToEnter.Name +
                    "Aby wlecieć w ten kwadrant" + Environment.NewLine;
                return;
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
                bool playerAlreadyHasQuest = _player.HasThisQuest(newlocation.QuestAvailableHere);
                bool playerAlreadyCompletQuest = _player.CompletedThisQuest(newlocation.QuestAvailableHere);
                if (playerAlreadyHasQuest)
                {
                    if (!playerAlreadyCompletQuest)
                    {
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItem(newlocation.QuestAvailableHere);
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "Ukończyłeś misję:"
                                + newlocation.QuestAvailableHere.Name + Environment.NewLine;
                            _player.RemoveQuestCompletionItems(newlocation.QuestAvailableHere);
                            rtbMessages.Text += "Otrzymujesz:" + Environment.NewLine;
                            rtbMessages.Text += newlocation.QuestAvailableHere.RewardExperience.ToString() +
                                " Punktów doświadczenia" + Environment.NewLine;
                            rtbMessages.Text += newlocation.QuestAvailableHere.RewardPlatinum.ToString() +
                                " Platinum" + Environment.NewLine;
                            rtbMessages.Text += newlocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;

                            _player.ExperiencePoints += newlocation.QuestAvailableHere.RewardExperience;
                            _player.Platinum += newlocation.QuestAvailableHere.RewardPlatinum;
                            _player.AddItemToInvetory(newlocation.QuestAvailableHere.RewardItem);
                            _player.MarkQuestCompleted(newlocation.QuestAvailableHere);
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
            UpdateInventoryListInUI();
            UpdateQuestListInUI();
            UpdateWeaponListInUI();
            UpdateRepaiKitsListInUI();
        }
        private void UpdateInventoryListInUI()
            { 
            
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Nazwa";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Ilość";

            dgvInventory.Rows.Clear();

            foreach (InvertoryItem invertoryItem in _player.Inventory)
            {
                    if (invertoryItem.Quantity > 0)
                    {
                        dgvInventory.Rows.Add(new[]
                        {
                        invertoryItem.Details.Name,
                        invertoryItem.Quantity.ToString() });
                    }
                }
            }
        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Nazwa";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Ukończone?";

            dgvQuests.Rows.Clear();
            foreach(PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[]
                {
                    playerQuest.Details.Name,
                    playerQuest.IsCompleted.ToString() });
            }
        }
        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();
            foreach(InvertoryItem invertoryItem in _player.Inventory)
            {
                if (invertoryItem.Details is Weapon)
                {
                    if (invertoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)invertoryItem.Details);
                    }
                }
            }
            if (weapons.Count ==0)
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
        }
        private void UpdateRepaiKitsListInUI()
        {
            List<RepairKit> repairKits = new List<RepairKit>();
            foreach(InvertoryItem invertoryItem in _player.Inventory)
            {
                if (invertoryItem.Details is RepairKit)
                {
                    if (invertoryItem.Quantity > 0)
                    {
                        repairKits.Add((RepairKit)invertoryItem.Details);
                    }
                }
            }
            if (repairKits.Count == 0)
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
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
                int damageToMonster = RandomNumberGenerator.NumberBetween(
                        currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            _currentMonster.CurrentHitPoints -= damageToMonster;

            rtbMessages.Text += "Zatakowałeś " + _currentMonster.Name + "zadając " + damageToMonster.ToString() + " pkt obrażeń" + Environment.NewLine;

            if (_currentMonster.CurrentHitPoints<=0)
            {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "Pokonałeś" + _currentMonster.Name + Environment.NewLine;

                _player.Platinum += _currentMonster.RewardPlatinium;
                rtbMessages.Text += "Otrzymujesz" +
                    _currentMonster.RewardPlatinium.ToString() + "Platinium" + Environment.NewLine;

                List<InvertoryItem> lootedItems = new List<InvertoryItem>();
                foreach(LootItem lootItem in _currentMonster.LootTable)
                {
                    if(RandomNumberGenerator.NumberBetween(1,100)<= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InvertoryItem(lootItem.Details, 1));
                    }
                }
                if(lootedItems.Count ==0)
                {
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if(lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InvertoryItem(lootItem.Details, 1));
                        }
                    }
                }
                foreach(InvertoryItem invertoryItem in lootedItems)
                {
                    _player.AddItemToInvetory(invertoryItem.Details);
                    if(invertoryItem.Quantity ==1)
                    {
                        rtbMessages.Text += "Zdobywasz" + invertoryItem.Quantity.ToString() + " " + invertoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "Zdobywasz" + invertoryItem.Quantity.ToString() + " " + invertoryItem.Details.NamePlural + Environment.NewLine;
                    }
                }
                lblżycie.Text = _player.CurrentHitPoints.ToString();
                lblplatinium.Text = _player.Platinum.ToString();
                lbldoświadczenie.Text = _player.ExperiencePoints.ToString();
                lblpoziom.Text = _player.Level.ToString();
                lblbaterie.Text = _player.CurrentBatteries.ToString();

                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdateRepaiKitsListInUI();

                rtbMessages.Text += Environment.NewLine;
                MoveTo(_player.CurrentLocation);
            }
            else
            {
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                rtbMessages.Text += _currentMonster.Name + "zadaje Ci" + damageToPlayer.ToString() + "Punktów obrażenia" + Environment.NewLine;

                _player.CurrentHitPoints -= damageToPlayer;
                lblżycie.Text = _player.CurrentHitPoints.ToString();
                if (_player.CurrentHitPoints<=0)
                {
                    rtbMessages.Text += "Ten przebrzydły" + _currentMonster.Name + "zabija Cię" + Environment.NewLine;

                    MoveTo(World.LocationById(World.LOCATION_ID_DOK));
                }
            }
        }

        private void btnUseRepairKit_Click(object sender, EventArgs e)
        {
            RepairKit repairKit = (RepairKit)cboRepairKits.SelectedItem;

            _player.CurrentHitPoints = (_player.CurrentHitPoints + repairKit.AmountToHeal);

            if(_player.CurrentHitPoints> _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
            }
            foreach (InvertoryItem ii in _player.Inventory)
            {
                if(ii.Details.ID == repairKit.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }
            rtbMessages.Text += "Użyłeś" + repairKit.Name + Environment.NewLine;

            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);
            rtbMessages.Text += _currentMonster.Name + "zadaje Ci" + damageToPlayer.ToString() + "obrażeń" + Environment.NewLine;
            _player.CurrentHitPoints -= damageToPlayer;
            if(_player.CurrentHitPoints <=0)
            {
                rtbMessages.Text += "Przebrzydły" + _currentMonster.Name + "Zabija Cię" + Environment.NewLine;
                MoveTo(World.LocationById(World.LOCATION_ID_DOK));
            }
            lblżycie.Text = _player.CurrentHitPoints.ToString();
            UpdateInventoryListInUI();
            UpdateRepaiKitsListInUI();
        }

        private void btnUseSunSails_Click(object sender, EventArgs e)
        {
            SunSails sunSails = (SunSails)cboSunSails.SelectedItem;
            _player.CurrentBatteries = (_player.CurrentBatteries + sunSails.AmountToCharge);
            if(_player.CurrentBatteries>_player.MaximumBatteries)
            {
                _player.CurrentBatteries = _player.MaximumBatteries;
            }
            rtbMessages.Text = "Naładowałeś baterie przy pomocy:" + sunSails.Name + Environment.NewLine;
            lblbaterie.Text = _player.CurrentBatteries.ToString();
        }
    }
}


