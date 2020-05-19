using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RiverRide
{
    public partial class Form1 : Form
    {
        string nick;
        int leftBorderSpawn = 175;
        int rightBorderSpawn = 455;
        int movementspeed = 7;
        int[] verticalSpeed = new int[2] { 1, -1 };
        int[] Array1 = new int[2] { 1, -1 };
        int score = 0;
        int petrolAmout = 55;
        int shootNr = 3;
        int GameSpeed = 1;
        int FuelLeft = 25;
        int diff = 40;
        int level = 1;
        Random r = new Random();
        Random rAr = new Random();

        PictureBox[] bullets;
        Image bulletImg = Image.FromFile(@"assets\bullet.png");

        PictureBox[] ship;
        Image enemyImg = Image.FromFile(@"assets\ship.png");

        Image shipImg = Image.FromFile(@"assets\ship.png");

        Image planeImg = Image.FromFile(@"assets\plane_enemy.png");

        Image helicopterImg = Image.FromFile(@"assets\helicopter.png");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            bullets = new PictureBox[3];

            // Bullets initialize
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].Size = new Size(8, 20);
                bullets[i].Image = bulletImg;
                bullets[i].SizeMode = PictureBoxSizeMode.Zoom;
                bullets[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(bullets[i]);
            }

            ship = new PictureBox[2];

            // Ships initialize
            for (int i = 0; i < ship.Length; i++)
            {
                ship[i] = new PictureBox();
                ship[i].Size = new Size(128, 38);
                ship[i].Image = enemyImg;
                ship[i].SizeMode = PictureBoxSizeMode.CenterImage;
                ship[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(ship[i]);
                ship[i].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), -100 -i*100);
                ShipSpawnRotate(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tanks_movement(GameSpeed);
            ship_movement(GameSpeed);
            petrol_movement(GameSpeed);
            Collision();
            PetrolCollision();
        }

        void tanks_movement(int gamespeed)
        {
            //ship[2].Location = new Point(455, 300);
            o1.Top += 2;
            o2.Top += 2;
            o3.Top += 2;
            o4.Top += 2;
            o5.Top += 2;
            o6.Top += 2;
            o7.Top += 2;
            o8.Top += 2;

            //Left side
            if(o1.Top >= 720)
            { o1.Top = 0; o1.Left = r.Next(0, 100);}
            else { o1.Top += gamespeed; }
            if (o2.Top >= 720)
            { o2.Top = 0; o2.Left = r.Next(0, 100); }
            else { o2.Top += gamespeed; }
            if (o3.Top >= 720)
            { o3.Top = 0; o3.Left = r.Next(0, 100); }
            else { o3.Top += gamespeed; }
            if (o4.Top >= 720)
            { o4.Top = 0; o4.Left = r.Next(0, 100); }
            else { o4.Top += gamespeed; }

            //Right side
            if (o5.Top >= 720)
            { o5.Top = 0; o5.Left = r.Next(600, 700); }
            else { o5.Top += gamespeed; }
            if (o6.Top >= 720)
            { o6.Top = 0; o6.Left = r.Next(600, 700); }
            else { o6.Top += gamespeed; }
            if (o7.Top >= 720)
            { o7.Top = 0; o7.Left = r.Next(600, 700); }
            else { o7.Top += gamespeed; }
            if (o8.Top >= 720)
            { o8.Top = 0; o8.Left = r.Next(600, 700); }
            else { o8.Top += gamespeed; }

        }

        void ship_movement(int enemySpeed)
        {
            for (int i = 0; i < ship.Length; i++)
            {
                if (ship[i].Location.X < 175)
                {
                    verticalSpeed[i] *= -1;
                    CheckIfItIsShipOrPlane(i);
                    //Image image = new Bitmap(@"assets\ship.png");
                    //ship[i].Image = (Bitmap)image.Clone();
                    ship[i].Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }

                if(ship[i].Location.X > 455)
                {
                    verticalSpeed[i] *= -1;
                    CheckIfItIsShipOrPlane(i);
                    //Image image = new Bitmap(@"assets\ship.png");
                    //ship[i].Image = (Bitmap)image.Clone();
                    ship[i].Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                }

                ship[i].Left -= verticalSpeed[i];
                ship[i].Top += enemySpeed;

                if (ship[i].Top > 600)
                {
                    ship[i].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150,-100));
                    verticalSpeed[i] = Array1[rAr.Next(Array1.Length)];
                }
            }
        }

        private void petrol_movement(int petrolSpeed)
        {
            petrol.Top += petrolSpeed;
            if(petrol.Top > 600)
            {
                petrol.Location = new Point(r.Next(200, 500), -700);
                petrol.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Left)||(e.KeyCode == Keys.A))
            {LeftTimer.Start();}
            if((e.KeyCode == Keys.Right)|| (e.KeyCode == Keys.D))
            { RightTimer.Start();}
            if((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.W))
            { UpTimer.Start();}
            if((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.S))
            { DownTimer.Start();}

            if(e.KeyCode == Keys.Space)
            {
                int i = shootNr % 3;
                bullets[i].Location = new Point(plane.Location.X + 20, plane.Location.Y - 30);
                bullets[i].Visible = true;
                shootNr++;
                if(shootNr == 6)
                {
                    shootNr = 3;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].Visible == true)
                {
                    bullets[i].Top -= 5;
                    CollisionWithBullet();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            LeftTimer.Stop();
            RightTimer.Stop();
            UpTimer.Stop();
            DownTimer.Stop();
        }

        private void LeftTimer_Tick(object sender, EventArgs e)
        {
            if (plane.Left > 174)
            { plane.Left -= movementspeed; }
            else { plane.Left = 174; }
        }

        private void RightTimer_Tick(object sender, EventArgs e)
        {
            if (plane.Left < 540)
            { plane.Left += movementspeed; }
            else { plane.Left = 540; }
        }

        private void UpTimer_Tick(object sender, EventArgs e)
        {
            if (plane.Top > 5)
            { plane.Top -= movementspeed; }
            else { plane.Top = 5; }
        }

        private void DownTimer_Tick(object sender, EventArgs e)
        {
            if (plane.Top < 485)
            { plane.Top += movementspeed; }
            else { plane.Top = 485; }
        }

        private void Collision()
        {
            for (int i = 0; i < ship.Length; i++)
            {
                if (plane.Bounds.IntersectsWith(ship[i].Bounds))
                {
                    GameOver("GAME OVER\nYou've just\n crashed!");
                }
            }
                
        }

        private void GameOver(string textToShow)
        {
            BgTimer.Stop();
            PetrolUsageTimer.Stop();
            BulletMovementTimer.Stop();
            plane.Visible = false;
            labelGameOver.Text = textToShow;
            labelGameOver.Visible = true;
            button1.Visible = true;
            Save_Score_To_File();
        }

        private void CollisionWithBullet()
        {
            // Bullet -> Ship
            for (int i = 0; i < bullets.Length; i++)
            {
                for (int j = 0; j < ship.Length; j++)
                {
                    if (bullets[i].Bounds.IntersectsWith(ship[j].Bounds))
                    {
                        ship[j].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                        verticalSpeed[j] = Array1[rAr.Next(Array1.Length)];
                        score++;
                        ShipSpawnRotate(j);

                        if (score % 10 == 0)
                        {
                            GameSpeed++;
                        }

                        if (score == 20) level = 2;
                        if (score == 40) level = 3;

                        if (level == 2)
                        {
                            ship[j].Size = new Size(128, 38);
                            ship[j].Image = planeImg;
                            ship[j].SizeMode = PictureBoxSizeMode.StretchImage;
                            verticalSpeed[j] = 2;
                        }
                        if (level == 3)
                        {
                            ship[j].Size = new Size(128, 38);
                            ship[j].Image = helicopterImg;
                            ship[j].SizeMode = PictureBoxSizeMode.StretchImage;
                            verticalSpeed[j] = 3;
                        }

                        scorelabel.Text = "Score: " + score.ToString();
                        bullets[i].Visible = false;
                        bullets[i].Location = new Point(1000, 1000);
                    }
                }
            }

            // Bullet -> Fuel
            for (int s = 0; s < bullets.Length; s++)
            {
                if (bullets[s].Bounds.IntersectsWith(petrol.Bounds))
                {
                    petrol.Location = new Point(r.Next(200, 500), -700);
                    petrol.Visible = true;
                    bullets[s].Visible = false;
                    bullets[s].Location = new Point(1000, 1000);
                }
            }

        }

        private void PetrolCollision()
        {
            if (plane.Bounds.IntersectsWith(petrol.Bounds))
            {
                if(petrolAmout<100)
                {
                    if(FuelLeft>0)
                    {
                        FuelLeft--;
                        petrolAmout++;
                        petrolBar.Value++;
                    }
                    else
                    {
                        petrol.Visible = false;
                        petrol.Location = new Point(1000, 1000);
                        FuelLeft = 25;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f1 = new Form1();
            f1.Show();
        }

        private void ShipCollisionTimer_Tick(object sender, EventArgs e)
        {
            for (int d = 0; d < ship.Length; d++)
            {
                int L = ship.Length;
                // d == 1
                if (d == 1)
                {
                    // y1 < 0, y2 < 0
                    if ((ship[d - 1].Location.Y < 0) && (ship[d].Location.Y < 0))
                    {
                        if (Math.Abs(Math.Abs(ship[d - 1].Location.Y) - Math.Abs(ship[d].Location.Y)) < diff)
                        {
                            if (Math.Abs(ship[d - 1].Location.Y) < Math.Abs(ship[d].Location.Y))
                            {
                                ship[d].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                            }
                            else
                            {
                                ship[d - 1].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                            }
                        }
                    }

                    // y1 < 0, y2 > 0
                    if ((ship[d - 1].Location.Y < 0) && (ship[d].Location.Y > 0))
                    {
                        if (Math.Abs(ship[d - 1].Location.Y) + ship[d].Location.Y < diff)
                        {
                            ship[d - 1].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                        }
                    }

                    // y1 > 0, y2 < 0
                    if ((ship[d - 1].Location.Y > 0) && (ship[d].Location.Y < 0))
                    {
                        if (ship[d - 1].Location.Y + Math.Abs(ship[d].Location.Y) < diff)
                        {
                            ship[d].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                        }
                    }

                    // y1 > 0, y2 > 0
                    if ((ship[d - 1].Location.Y > 0) && (ship[d].Location.Y > 0))
                    {
                        if (Math.Abs(ship[d - 1].Location.Y - ship[d].Location.Y) < diff)
                        {
                            if (ship[d - 1].Location.Y < ship[d].Location.Y)
                            {
                                ship[d - 1].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                            }
                            else
                            {
                                ship[d].Location = new Point(r.Next(leftBorderSpawn, rightBorderSpawn), r.Next(-150, -100));
                            }
                        }
                    }
                }
            }
        }

        private void PetrolUsageTimer_Tick(object sender, EventArgs e)
        {
            if(petrolAmout>0)
            {
                petrolAmout--;
                petrolBar.Value--;
                petrolLabel.Text = "Fuel: " + petrolAmout.ToString() + "%";
            }
            else
            {
                GameOver("GAME OVER\nFuel is empty!");
            }
        }

        private void ShipSpawnRotate(int s)
        {
            LevelChecking(s);

            if (verticalSpeed[s] == -1) // going right
            {
                ship[s].Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else // going left
            {
                ship[s].Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            }
        }

        private void CheckIfItIsShipOrPlane(int nr)
        {
            LevelChecking(nr);
        }

        private void LevelChecking(int a)
        {
            if (level == 1)
            {
                Image image = new Bitmap(@"assets\ship.png");
                ship[a].Image = (Bitmap)image.Clone();
            }
            else if (level == 2)
            {
                Image image = new Bitmap(@"assets\plane_enemy.png");
                ship[a].Image = (Bitmap)image.Clone();
            }
            else if (level == 3)
            {
                Image image = new Bitmap(@"assets\helicopter.png");
                ship[a].Image = (Bitmap)image.Clone();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f1 = new Form1();
            f1.Show();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W/UP Arrow - Move up\nS/Down Arrow - Move down\n" +
                "A/Left Arrow - Move left\nD/Right Arrow - Move right\nSpace - shoot", "Controls");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string Get_Nickname()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("currentNickname.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String CurrNick = sr.ReadToEnd();
                    nick = CurrNick;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return nick;
        }

        void Save_Score_To_File()
        {

            string docPath = Environment.CurrentDirectory;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "High_Score_RiverRaid.txt"), true))
            {
                outputFile.WriteLine(Get_Nickname() + " " + score);
            }
        }
    }
}
