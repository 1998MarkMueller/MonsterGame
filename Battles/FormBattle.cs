using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


//TODO keypress event, loading bar color, pokemon screen
namespace Battles
{
    public partial class BattleWindow : Form
    {
        MonsterList pokemonList = new MonsterList();
        Battle battles = new Battle();

        bool clickedFight = false;
        bool clickedBag = false;
        bool clickedPokemon = false;
        bool clickedRun = false;

        bool clickedNothing = true;
        bool isActionKeyUp = false;



        ///////////////////////////////////////////////////////
        //                  Initialization                   //
        ///////////////////////////////////////////////////////
        public BattleWindow()
        {
            InitializeComponent();
            initialize();
        }

        public void initialize()
        {
            healthChange();
            initializeNonChanging();
        }

        public void initializeNonChanging()
        {
            ///////////////////////////////////////////////////////
            picYourPokemon.Image = Battle.yourPokemon.imgB;
            lblYourPokemonName.Text = Battle.yourPokemon.name + " " + Battle.yourPokemonGender;
            lblYourPokemonLvl.Text = "Lv: " + Battle.yourPokemon.lvl.ToString();
            Console.WriteLine(Battle.yourPokemon.lvl.ToString());
            lblYourPokemonExp.Text = "Exp: " + Battle.yourPokemon.exp.ToString();
            ///////////////////////////////////////////////////////
            picEnemyPokemon.Image = Battle.enemyPokemonImage;
            lblEnemyPokemonName.Text = Battle.enemyPokemonName + " " + Battle.enemyPokemonGender;
            lblEnemyPokemonLvl.Text = "Lv: " + Battle.enemyPokemon.lvl.ToString();
            ///////////////////////////////////////////////////////
        }

        public void healthChange()
        {
            ///////////////////////////////////////////////////////
            double de = Battle.yourPokemon.maxHP;
            double dr = Battle.yourPokemon.currHP;

            lblYourPokemonHP.Text = "HP: " + dr + "/" + de;

            double yourHealthPercent = (dr / de)*100;
            int yourHealthInt = Convert.ToInt32(yourHealthPercent);
            proYourHealth.Value = yourHealthInt;
            ///////////////////////////////////////////////////////
            double ee = Battle.enemyPokemon.maxHP;
            double er = Battle.enemyPokemon.currHP;

            lblEnemyPokemonHP.Text = "HP: " + dr + "/" + de;

            double enemyHealthPercent = (er / ee) * 100;
            int enemyHealthInt = Convert.ToInt32(enemyHealthPercent);
            proEnemyHealth.Value = enemyHealthInt;
            ///////////////////////////////////////////////////////
        }



        ///////////////////////////////////////////////////////
        //                Timed, LstBox, Keypress            //
        ///////////////////////////////////////////////////////
        //Timed Function
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
        }

        //Show text in listbox 
        public void showText(string[] s)
        {

        }

        //Keypress function
        private void BattleWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("You pressed enter");
            }
        }



        ///////////////////////////////////////////////////////
        //                  Button Clicks                    //
        ///////////////////////////////////////////////////////
        private void btnOption1_Click(object sender, EventArgs e)
        {
            if (clickedNothing == true)
            {
                clickedFight = true;
                clickedNothing = false;
                btnOption1.Text = Battle.yourPokemon.move[0];
                btnOption2.Text = Battle.yourPokemon.move[1];
                btnOption3.Text = Battle.yourPokemon.move[2];
                btnOption4.Text = Battle.yourPokemon.move[3];
            }
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            if (clickedNothing == true)
            {
                lstDialog.Items.Add("You currenlty can't do that");
                System.Timers.Timer t = new System.Timers.Timer(1000);
                t.AutoReset = false;
                t.Elapsed += OnTimedEvent;
                t.Enabled = true;
            }
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            if (clickedNothing == true)
            {
                lstDialog.Items.Add("You currently can't do that");
            }
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            if (clickedNothing == true)
            {
                lstDialog.Items.Add("You currently can't do that");
     
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Battle.yourPartyPokemonSelected = 1;
            Battle.yourPokemon = Party.yourParty[Battle.yourPartyPokemonSelected];
            initialize();
        }
    }
}
