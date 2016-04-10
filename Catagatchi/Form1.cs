using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Catagatchi
{
    public partial class Form1 : Form
    {
        const int JOB_ENERGY_COST = -3;
        const int TEETH_BRUSH_DOLLAR_COST = 3;
        const int TEETH_BRUSH_BENEFIT = 30;
        const int EAT_DOLLAR_COST = 2;
        const int EAT_BENEFIT = 15;
        const int ERROR_TIME = 3000;
        const int EGG_POS_X = 421;
        const int EGG_POS_Y = 146;
        const int TURD_POS_X = EGG_POS_X + 27;
        const int TURD_POS_Y = EGG_POS_Y + 51;
        const int ALLOWANCE = 10;
        const int STAGE_TWO_LENGTH = 90000;
        const int STAGE_THREE_LENGTH = 300000;
        const int CREDITS_LENGTH = 1500;
        const double TURD_SCALAR = .63;
        const int CAT_POS_X = EGG_POS_X -4;
        const int CAT_POS_Y = 130;

        Player player_stage3;
        Player player_stage2;
        Player player;
        Egg playerEgg;
        bool isJumped = false;
        Stopwatch[] errorMessagesTimers = new Stopwatch[3];
        int mode;
        Stopwatch stage2Watch = new Stopwatch();
        Stopwatch finalStageStopWactch = new Stopwatch();
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            playerEgg = new Egg("Bowman");
            PlayerName.Text = playerEgg.getName();
            for (int i = 0; i < 3; i++)
            {
                errorMessagesTimers[i] = new Stopwatch();
            }
            m0_HatchProgressBar.Maximum = playerEgg.getTimeToHatch();
            mode = 0;
            Cat.Image = Catagatchi.Properties.Resources.Egg1;
            Cat.Location = new System.Drawing.Point(EGG_POS_X, EGG_POS_Y);
            wplayer.URL = "Resources\\music.mp3";
        }

        private void winGame(Player p)
        {
            VictoryImage.BringToFront();
            if(p.getEnergy() > 2)
            {
                if (p.isLogo)
                {
                    VictoryImage.Image = Catagatchi.Properties.Resources.Win_3;

                }
                else
                {
                    VictoryImage.Image = Catagatchi.Properties.Resources.win_4;

                }
            }
            if (p.getHunger() > p.getHygine())
            {
                if(p.isLogo)
                {
                    VictoryImage.Image = Catagatchi.Properties.Resources.Win_1;
                }
                else
                {
                    VictoryImage.Image = Catagatchi.Properties.Resources.win_5;

                }
            }
            else if (p.getHygine() > p.getHunger())
            {
                if (p.isLogo)
                {
                    VictoryImage.Image = Catagatchi.Properties.Resources.win_2;

                }
                else
                {
                    VictoryImage.Image = Catagatchi.Properties.Resources.win_6;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.isTurd)
            {
                player.updateStatus(TURD_SCALAR);
            }
            else
            {
                player.updateStatus();
                if (player.getEnergy() >= -JOB_ENERGY_COST)
                {
                    ml_ene.Visible = true;
                }
                else
                    ml_ene.Visible = false;

            }
            if(player.getHunger() + player.getHygine() < 125)
            {
                ml_heart.Visible = true;
                Message.Visible = true;
            }
            else
            {
                ml_heart.Visible = false;
                Message.Visible = false; 
            }
            if (player.getWallet() >= EAT_DOLLAR_COST)
            {
                ml_hung.Visible = true;
            }
            else
                ml_hung.Visible = false;

            if (player.getWallet() >= TEETH_BRUSH_DOLLAR_COST)
            {
                ml_hyg.Visible = true;
            }
            else
                ml_hyg.Visible = false;


            if (player.isDead)
            {
                player.death();
                AnimationTimer.Stop();
                StatusCheckTimer.Stop();
                Cat.Image = Catagatchi.Properties.Resources.Tombstone;
                lblDeath.Text = "Your Wildcat lived for " + player.getAge().ToString() + " seconds";
            }
            if(finalStageStopWactch.ElapsedMilliseconds > STAGE_THREE_LENGTH && mode == 2)
            {
                AnimationTimer.Stop();
                StatusCheckTimer.Stop();
                winGame(player);
            }
            checkErrorMessages();
            if (mode == 1)
            {
                updateFields(stage2Watch);

            }
            else if (mode == 2)
            {
                updateFields(finalStageStopWactch);
            }
        }

        private void checkErrorMessages()
        {
            for (int i = 0; i < 3; i++)
            {
                if (errorMessagesTimers[i].ElapsedMilliseconds > ERROR_TIME)
                {
                    errorMessagesTimers[i].Stop();
                    errorMessagesTimers[i].Reset();
                    switch (i)
                    {
                        case 0:
                            m1_lblWorkFail.Visible = false;
                            break;
                        case 1:
                            m1_lblTeethFail.Visible = false;
                            break;
                        case 2:
                            m1_lblEatFail.Visible = false;
                            break;
                    }


                }
            }
        }
        private void updateFields(Stopwatch currentStageWatch)
        {
            m1_HealthBar.Value = player.getHealth();
            m1_HygieneBar.Value = player.getHygine();
            m1_HungerBar.Value = player.getHunger();
            m2_EnergyBar.Value = player.getEnergy();
            m1_WalletCounter.Text = player.getWallet().ToString();
            try
            {
                m1_GrowthBar.Value = (int)currentStageWatch.ElapsedMilliseconds;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (isJumped == false)
            {
                if (player.isTurd)
                {
                    if (player.isLogo)
                    {
                        Cat.Image = Catagatchi.Properties.Resources.turd1;
                    }
                    else
                    {
                        Cat.Image = Catagatchi.Properties.Resources.turd1_w;
                    }

                }
                else
                {
                    if (player.isLogo)
                    {
                        Cat.Image = Catagatchi.Properties.Resources.CatStage1;
                    }
                    else
                    {
                        Cat.Image = Catagatchi.Properties.Resources.CatStage1_b;
                    }
                }
                isJumped = true;
            }
            else
            {
                if (player.isTurd)
                {
                    if (player.isLogo)
                    {
                        Cat.Image = Catagatchi.Properties.Resources.turd2;
                    }
                    else
                    {
                        Cat.Image = Catagatchi.Properties.Resources.turd2_w;
                    }
                }
                else
                {
                    if (player.isLogo)
                    {
                        Cat.Image = Catagatchi.Properties.Resources.CatStage2;
                    }
                    else
                    {
                        Cat.Image = Catagatchi.Properties.Resources.CatStage2_b;
                    }

                }
                isJumped = false;
            }
        }

        private void bttnWork_Click(object sender, EventArgs e)
        {
            if (player.getEnergy() >= -JOB_ENERGY_COST)
            {
                player.putInWallet(new Random().Next(1, 11));
                player.changeEnergy(JOB_ENERGY_COST);
            }
            else
            {
                errorMessagesTimers[0].Start();
                m1_lblWorkFail.Visible = true;

            }

        }

        private void bttnBrushTeeth_Click(object sender, EventArgs e)
        {
            if (!player.takeOutOfWallet(TEETH_BRUSH_DOLLAR_COST))
            {
                m1_lblTeethFail.Visible = true;
                errorMessagesTimers[1].Start();
            }
            else
                player.changeHygine(TEETH_BRUSH_BENEFIT);
        }

        private void bttnEat_Click(object sender, EventArgs e)
        {
            if (!player.takeOutOfWallet(EAT_DOLLAR_COST))
            {
                m1_lblEatFail.Visible = true;
                errorMessagesTimers[2].Start();
            }
            else
                player.changeHunger(EAT_BENEFIT);
        }

        private void moveFromModeZeroToOne()
        {
            mode = 1;
            m0_bttnHatchFaster.Visible = false;
            m0_HatchProgressBar.Visible = false;
            m0_lblTimeUtil.Visible = false;

            m1_bttnBrushTeeth.Visible = true;
            m1_bttnEat.Visible = true;
            m1_HealthBar.Visible = true;
            m1_HealthTitle.Visible = true;
            m1_HungerBar.Visible = true;
            m1_HungerTitle.Visible = true;
            m1_HygieneBar.Visible = true;
            m1_HygieneTitle.Visible = true;
            m1_WalletCounter.Visible = true;
            m1_WalletTitle.Visible = true;
            m1_GrowthBar.Visible = true;
            m1_GrowthBar.Maximum = STAGE_TWO_LENGTH;
            m1_timerLabel.Visible = true;

        }

        private void moveFromModeOneToTwo()
        {
            mode = 2;
            m2_bttnWork.Visible = true;
            m2_EnergyBar.Visible = true;
            m2_EnergyTitle.Visible = true;
            Stage2Checker.Enabled = false;
            player_stage3 = new Player(player);
            player = null;
            player = player_stage3;
            Cat.Location = new System.Drawing.Point(CAT_POS_X, CAT_POS_Y);
            finalStageStopWactch.Start();
            m1_GrowthBar.Maximum = STAGE_THREE_LENGTH;
        }

        private void m0_bttnHatchFaster_Click(object sender, EventArgs e)
        {
            playerEgg.reduceTimeToHatch(1000);
            m0_HatchProgressBar.PerformStep();
        }

        private void m0_BirthTimer_Tick(object sender, EventArgs e)
        {
            playerEgg.reduceTimeToHatch(1000);
            if (playerEgg.getTimeToHatch() == 0)
            {
                player_stage2 = new Player(playerEgg.getName(), true, ALLOWANCE, playerEgg.isLogo);
                hatchPlayer(playerEgg, player_stage2);
            }
            m0_HatchProgressBar.PerformStep();
            double value = m0_HatchProgressBar.Value, max = m0_HatchProgressBar.Maximum;
            if (value / max > .6)
            {
                Cat.Image = Catagatchi.Properties.Resources.Egg3;
            }
            else if (value / max > .3)
            {
                Cat.Image = Catagatchi.Properties.Resources.Egg2;
            }
        }

        private void hatchPlayer(Egg e, Player p)
        {
            moveFromModeZeroToOne();
            Cat.Image = Catagatchi.Properties.Resources.turd1;
            Cat.Location = new System.Drawing.Point(TURD_POS_X, TURD_POS_Y);
            player = player_stage2;
            AnimationTimer.Enabled = true;
            StatusCheckTimer.Enabled = true;
            m0_BirthTimer.Stop();
            stage2Watch.Start();
            Stage2Checker.Enabled = true;
        }

        private void Stage2Checker_Tick(object sender, EventArgs e)
        {
            if (stage2Watch.ElapsedMilliseconds > STAGE_TWO_LENGTH)
            {
                stage2Watch.Stop();
                moveFromModeOneToTwo();
            }
        }


        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            wplayer.controls.play();
        }
    }

    class Player
    {
        const int HUNGER_DECAY_TIME = 4500;
        const int HUNGER_DECAY_AMOUNT = -3;
        const int HYGIENE_DECAY_TIME = 7000;
        const int HYGIENE_DECAY_AMOUNT = -4;
        const int ENERGY_REGEN_TIME = 20000;
        const int ENERGY_REGEN_AMOUNT = 1;
        const int HEALTH_DECAY_TIME = 8500;
        readonly int[] HEALTH_DECAY_AMOUNT = { -1, -2, -3, -5, -7 };


        private string name;
        public bool isLogo;
        public bool isDead;
        private int health;
        private int hunger;
        private int hygine;
        private int energy;
        private int wallet;
        public bool isTurd;
        private Stopwatch hungerClock = new Stopwatch();
        private Stopwatch hygieneClock = new Stopwatch();
        private Stopwatch energyClock = new Stopwatch();
        private Stopwatch healthClock = new Stopwatch();
        private Stopwatch lifeClock = new Stopwatch();

        public Player()
        {
            name = "Player";
            health = 100;
            hunger = 100;
            hygine = 100;
            energy = 0;
            hungerClock.Start();
            hygieneClock.Start();
            energyClock.Start();
            healthClock.Start();
            isDead = false;
            lifeClock.Start();
            wallet = 0;
        }

        public Player(string s, bool b, int money, bool l)
        {
            name = s;
            health = 100;
            hunger = 100;
            hygine = 100;
            energy = 0;
            hungerClock.Start();
            hygieneClock.Start();
            energyClock.Start();
            healthClock.Start();
            isDead = false;
            lifeClock.Start();
            wallet = money;
            isTurd = b;
            isLogo = l;
        }

        public Player(Player p)
        {
            name = p.getName();
            health = p.getHealth();
            hunger = p.getHunger();
            hygine = p.getHygine();
            energy = 5;
            hungerClock.Start();
            hygieneClock.Start();
            energyClock.Start();
            healthClock.Start();
            isDead = false;
            lifeClock.Start();
            wallet = p.getWallet();
            isTurd = false;
            isLogo = p.isLogo;
        }

        public void updateStatus()
        {
            if (hungerClock.ElapsedMilliseconds > HUNGER_DECAY_TIME)
            {
                hungerClock.Stop();
                hungerClock.Reset();
                changeHunger(HUNGER_DECAY_AMOUNT);
                hungerClock.Start();
            }

            if (hygieneClock.ElapsedMilliseconds > HYGIENE_DECAY_TIME)
            {
                hygieneClock.Stop();
                hygieneClock.Reset();
                changeHygine(HYGIENE_DECAY_AMOUNT);
                hygieneClock.Start();
            }

            if (energyClock.ElapsedMilliseconds > ENERGY_REGEN_TIME)
            {
                energyClock.Stop();
                energyClock.Reset();
                changeEnergy(ENERGY_REGEN_AMOUNT);
                energyClock.Start();
            }

            if (hygine + hunger < 25 && healthClock.ElapsedMilliseconds > HEALTH_DECAY_TIME)
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[4]);
                healthClock.Start();
            }
            else if (hygine + hunger < 50 && healthClock.ElapsedMilliseconds > HEALTH_DECAY_TIME)
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[3]);
                healthClock.Start();
            }
            else if (hygine + hunger < 100 && healthClock.ElapsedMilliseconds > HEALTH_DECAY_TIME)
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[2]);
                healthClock.Start();
            }
            else if (hygine + hunger < 125 && healthClock.ElapsedMilliseconds >     HEALTH_DECAY_TIME)
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[1]);
                healthClock.Start();
            }
            else if (hygine + hunger < 150 && healthClock.ElapsedMilliseconds > HEALTH_DECAY_TIME)
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[0]);
                healthClock.Start();
            }

            if (health == 0)
            {
                isDead = true;
            }
        }

        public void updateStatus(double m)
        {
            if (hungerClock.ElapsedMilliseconds > (m*HUNGER_DECAY_TIME))
            {
                hungerClock.Stop();
                hungerClock.Reset();
                changeHunger(HUNGER_DECAY_AMOUNT);
                hungerClock.Start();
            }

            if (hygieneClock.ElapsedMilliseconds > (m*HYGIENE_DECAY_TIME))
            {
                hygieneClock.Stop();
                hygieneClock.Reset();
                changeHygine(HYGIENE_DECAY_AMOUNT);
                hygieneClock.Start();
            }

            if (energyClock.ElapsedMilliseconds > (m*ENERGY_REGEN_TIME))
            {
                energyClock.Stop();
                energyClock.Reset();
                changeEnergy(ENERGY_REGEN_AMOUNT);
                energyClock.Start();
            }

            if (hygine + hunger < 25 && healthClock.ElapsedMilliseconds > (m*HEALTH_DECAY_TIME))
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[4]);
                healthClock.Start();
            }
            else if (hygine + hunger < 50 && healthClock.ElapsedMilliseconds > (m*HEALTH_DECAY_TIME))
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[3]);
                healthClock.Start();
            }
            else if (hygine + hunger < 100 && healthClock.ElapsedMilliseconds > (m*HEALTH_DECAY_TIME))
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[2]);
                healthClock.Start();
            }
            else if (hygine + hunger < 125 && healthClock.ElapsedMilliseconds > (m * HEALTH_DECAY_TIME))
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[1]);
                healthClock.Start();
            }
            else if (hygine + hunger < 150 && healthClock.ElapsedMilliseconds > (m * HEALTH_DECAY_TIME))
            {
                healthClock.Stop();
                healthClock.Reset();
                changeHealth(HEALTH_DECAY_AMOUNT[0]);
                healthClock.Start();
            }

            if (health == 0)
            {
                isDead = true;
            }
        }

        public void death()
        {
            lifeClock.Stop();
            hungerClock.Stop();
            hygieneClock.Stop();
            energyClock.Stop();
            healthClock.Stop();
            
        }

        public int getHealth()
        {
            return health;
        }

        public int getHunger()
        {
            return hunger;
        }

        public int getHygine()
        {
            return hygine;
        }

        public int getEnergy()
        {
            return energy;
        }

        public long getAge()
        {
            return lifeClock.ElapsedMilliseconds / 1000;
        }

        public void putInWallet(int amount)
        {
            wallet += amount;
        }

        public bool takeOutOfWallet(int amount)
        {
            int temp = wallet;
            temp -= amount;
            if (temp < 0)
            {
                return false;
            }
            else
            {
                wallet = temp;
                return true;
            }
        }

        public int getWallet()
        {
            return wallet;
        }

        public void changeHealth(int amount)
        {
            health += amount;

            if (health > 100)
                health = 100;
            if (health < 0)
                health = 0;
        }

        public void changeHygine(int amount)
        {
            hygine += amount;

            if (hygine > 100)
                hygine = 100;
            if (hygine < 0)
                hygine = 0;
        }

        public void changeHunger(int amount)
        {
            hunger += amount;

            if (hunger > 100)
                hunger = 100;
            if (hunger < 0)
                hunger = 0;
        }

        public void changeEnergy(int amount)
        {
            energy += amount;

            if (energy < 0)
                energy = 0;
            if (energy > 5)
                energy = 5;
        }


        public string getName()
        {
            return name;
        }
    }

    class Egg
    {
        private string name;
        private int timeToBirth;
        public bool isLogo;

        public Egg()
        {
            name = "Player 1";
            Random rnd = new Random();
            timeToBirth = rnd.Next(30, 240) * 1000;
            switch (rnd.Next(1, 100) % 2)
            {
                case 0:
                    isLogo = true;
                    break;
                case 1:
                    isLogo = false;
                    break;
            }
        }

        public Egg(string s)
        {
            name = s;
            Random rnd = new Random();
            timeToBirth = rnd.Next(30, 240) * 1000;
            switch (rnd.Next(1, 100) % 2)
            {
                case 0:
                    isLogo = true;
                    break;
                case 1:
                    isLogo = false;
                    break;
            }
        }

        public string getName()
        {
            return name;
        }

        public void reduceTimeToHatch(int amount)
        {
            timeToBirth -= amount;

            if (timeToBirth < 0)
            {
                timeToBirth = 0;
            }
        }

        public int getTimeToHatch()
        {
            return timeToBirth;
        }

    }

    public class ball
    {
        System.Drawing.Point location = new System.Drawing.Point();
        public int speed;
        public ball(int x, int y)
        {
            location.X = x;
            location.Y = y;
            Random rnd = new Random();
            speed = rnd.Next(3, 10);
        }
    }

    public class BasketBallGame
    {
        ball[] shots = new ball[5];
        public int score;

        public BasketBallGame()
        {
            for (int i = 0; i < 5; i++)
            {
                shots[i] = new ball(698 + (150 / 2), 0);
            }
            score = 0;
        }
    }
}
