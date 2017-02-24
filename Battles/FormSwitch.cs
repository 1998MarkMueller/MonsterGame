using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battles
{
    public partial class FormSwitch : Form
    {
        public FormSwitch()
        {
            InitializeComponent();
            initalize();
        }

        public void initalize()
        {
            int intParyMembers = Party.yourParty.Length;

            Label[] _LabelsName = new Label [6];
            _LabelsName[0] = lblPokemonName1;
            _LabelsName[1] = lblPokemonName2;
            _LabelsName[2] = lblPokemonName3;
            _LabelsName[3] = lblPokemonName4;
            _LabelsName[4] = lblPokemonName5;
            _LabelsName[5] = lblPokemonName6;

            Label[] _LabelsLvl = new Label[6];
            _LabelsLvl[0] = lblPokemonLvl1;
            _LabelsLvl[1] = lblPokemonLvl2;
            _LabelsLvl[2] = lblPokemonLvl3;
            _LabelsLvl[3] = lblPokemonLvl4;
            _LabelsLvl[4] = lblPokemonLvl5;
            _LabelsLvl[5] = lblPokemonLvl6;

            Label[] _LabelsHP = new Label[6];
            _LabelsHP[0] = lblPokemonHP1;
            _LabelsHP[1] = lblPokemonHP2;
            _LabelsHP[2] = lblPokemonHP3;
            _LabelsHP[3] = lblPokemonHP4;
            _LabelsHP[4] = lblPokemonHP5;
            _LabelsHP[5] = lblPokemonHP6;

            PictureBox[] _PictureBoxes = new PictureBox[6];
            _PictureBoxes[0] = picPokemon1;
            _PictureBoxes[1] = picPokemon2;
            _PictureBoxes[2] = picPokemon3;
            _PictureBoxes[3] = picPokemon4;
            _PictureBoxes[4] = picPokemon5;
            _PictureBoxes[5] = picPokemon6;

            Button[] _Buttons = new Button[6];
            _Buttons[0] = btnPokemon1;
            _Buttons[1] = btnPokemon2;
            _Buttons[2] = btnPokemon3;
            _Buttons[3] = btnPokemon4;
            _Buttons[4] = btnPokemon5;
            _Buttons[5] = btnPokemon6;

            ProgressBar[] _ProgressBars = new ProgressBar[6];
            _ProgressBars[0] = proPokemon1;
            _ProgressBars[1] = proPokemon2;
            _ProgressBars[2] = proPokemon3;
            _ProgressBars[3] = proPokemon4;
            _ProgressBars[4] = proPokemon5;
            _ProgressBars[5] = proPokemon6;

            for (int i=0; i< intParyMembers; i++)
            {
                _LabelsName[i].Text = Party.yourParty[i].name;
                _LabelsLvl[i].Text = "Lvl: " + Party.yourParty[i].lvl.ToString();
                _LabelsHP[i].Text = "HP: " + Party.yourParty[i].currHP.ToString() + "/" + Party.yourParty[i].maxHP.ToString();
                _PictureBoxes[i].Image = Party.yourParty[i].imgF;
                double de = Party.yourParty[i].maxHP;
                double dr = Party.yourParty[i].currHP;
                double yourHealthPercent = (dr / de) * 100;
                int yourHealthInt = Convert.ToInt32(yourHealthPercent);
                _ProgressBars[i].Value = yourHealthInt;
            }

            for (int i = 0; i < intParyMembers; i++)
            {
                if (_LabelsName[i].Text == Party.yourParty[Battle.yourPartyPokemonSelected].name)
                {
                    _Buttons[i].BackColor = Color.PaleVioletRed;
                    _Buttons[i].Enabled = false;
                }
            }
        }
        public void healthChange()
        {
            ///////////////////////////////////////////////////////
   
            ///////////////////////////////////////////////////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button[] _Buttons = new Button[6];
            _Buttons[0] = btnPokemon1;
            _Buttons[1] = btnPokemon2;
            _Buttons[2] = btnPokemon3;
            _Buttons[3] = btnPokemon4;
            _Buttons[4] = btnPokemon5;
            _Buttons[5] = btnPokemon6;

            Battle.yourPartyPokemonSelected = 0;
            Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
            BattleWindow battleScreen = new BattleWindow();
            battleScreen.initialize();
            this.Close();
        }

        private void btnPokemon2_Click(object sender, EventArgs e)
        {
            try
            {
                Button[] _Buttons = new Button[6];
            _Buttons[0] = btnPokemon1;
            _Buttons[1] = btnPokemon2;
            _Buttons[2] = btnPokemon3;
            _Buttons[3] = btnPokemon4;
            _Buttons[4] = btnPokemon5;
            _Buttons[5] = btnPokemon6;

            Battle.yourPartyPokemonSelected = 1;
            Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
            BattleWindow battleScreen = new BattleWindow();
            battleScreen.initialize();
            this.Close();
        }
            catch { }
        }

        //In honor of dalton
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPokemon3_Click(object sender, EventArgs e)
        {
        try
        {
            Button[] _Buttons = new Button[6];
            _Buttons[0] = btnPokemon1;
            _Buttons[1] = btnPokemon2;
            _Buttons[2] = btnPokemon3;
            _Buttons[3] = btnPokemon4;
            _Buttons[4] = btnPokemon5;
            _Buttons[5] = btnPokemon6;

            Battle.yourPartyPokemonSelected = 2;
            Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
            BattleWindow battleScreen = new BattleWindow();
            battleScreen.initialize();
            this.Close();
        }
            catch { }
        }

        private void btnPokemon4_Click(object sender, EventArgs e)
        {
            try
            {
                Button[] _Buttons = new Button[6];
                _Buttons[0] = btnPokemon1;
                _Buttons[1] = btnPokemon2;
                _Buttons[2] = btnPokemon3;
                _Buttons[3] = btnPokemon4;
                _Buttons[4] = btnPokemon5;
                _Buttons[5] = btnPokemon6;

                Battle.yourPartyPokemonSelected = 3;
                Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
                BattleWindow battleScreen = new BattleWindow();
                battleScreen.initialize();
                this.Close();
            }
            catch { }
        }

        private void btnPokemon5_Click(object sender, EventArgs e)
        {
            try
            {
                Button[] _Buttons = new Button[6];
            _Buttons[0] = btnPokemon1;
            _Buttons[1] = btnPokemon2;
            _Buttons[2] = btnPokemon3;
            _Buttons[3] = btnPokemon4;
            _Buttons[4] = btnPokemon5;
            _Buttons[5] = btnPokemon6;

            Battle.yourPartyPokemonSelected = 4;
            Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
            BattleWindow battleScreen = new BattleWindow();
            battleScreen.initialize();
            this.Close();
        }
            catch { }
        }

        private void btnPokemon6_Click(object sender, EventArgs e)
        {
            try
            {
                Button[] _Buttons = new Button[6];
            _Buttons[0] = btnPokemon1;
            _Buttons[1] = btnPokemon2;
            _Buttons[2] = btnPokemon3;
            _Buttons[3] = btnPokemon4;
            _Buttons[4] = btnPokemon5;
            _Buttons[5] = btnPokemon6;

            Battle.yourPartyPokemonSelected = 5;
            Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
            BattleWindow battleScreen = new BattleWindow();
            battleScreen.initialize();
            this.Close();
    }
            catch { }
        }
    }
}
