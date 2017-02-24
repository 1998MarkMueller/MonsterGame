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


//TODO keypress event, loading bar color, showDialog
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
            bool isTimer = false;
            for(var i = 0; i < s.Length; i++)
            {
                timer1.Enabled = true;

                if (timer1.Interval == 1000)
                {
                    isTimer = true;
                }
                else { isTimer = false; Console.Write("Time");  }

                if (isTimer == true)
                {
                    lstDialog.Items.Add(s[i]);
                }
                else {
                    lstDialog.Items.Clear();
                }
            }
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
                btnOption1.Text = Battle.yourPokemon.move[0].moveName;
                btnOption2.Text = Battle.yourPokemon.move[1].moveName;
                btnOption3.Text = Battle.yourPokemon.move[2].moveName;
                btnOption4.Text = Battle.yourPokemon.move[3].moveName;
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
                FormSwitch formSwitch = new FormSwitch();
                formSwitch.Show();
            }
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            if (clickedNothing == true)
            {
                showText(new string[] { "You currently can't do that.", "Or that", "Or That"});
            }
        }

        private void BattleWindow_Activated(object sender, EventArgs e)
        {
            initialize();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (clickedFight == true) {
                clickedFight = false;
                clickedNothing = true;
                btnOption1.Text = "Fight";
                btnOption2.Text = "Battle";
                btnOption3.Text = "Pokemon";
                btnOption4.Text = "Run";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval);
            if (timer1.Interval == 1000)
            {
                Console.Write("Timer went off");
            }
        }
    }
}
