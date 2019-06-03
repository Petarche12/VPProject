﻿using ClumsyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClumsyBird
{
    public partial class Form1 : Form
    {

        private bool startMenu { set; get; }
        private bool inPlayMode { get; set; }
        private bool inHighScoreMode { set; get; }

        private Image backgroundImage;
        private Image gameNameImage;

        public Form1()
        {
            InitializeComponent();
            InitializeImages();
            setMainMenuMode();   
        }

        private void InitializeImages()
        {
            backgroundImage = Resources.cloud_example;
            gameNameImage = Resources.Untitled;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            if (startMenu)
            {
                paintMainMenu(e.Graphics);
            }
            else if(inPlayMode)
            {
                paintPlayMode(e.Graphics);
            }
            else if(inHighScoreMode)
            {

            }

        }

        private void paintPlayMode(Graphics g)
        {
            Brush b = new SolidBrush(Color.Brown);
            g.DrawImageUnscaled(backgroundImage, new Point(0, 0));
            g.FillRectangle(b, new Rectangle(new Point(0, 0), new Size(Width, 10)));
            g.FillRectangle(b, new Rectangle(new Point(0, Height - 48), new Size(Width, 10)));
            b.Dispose();
        }

        private void paintMainMenu(Graphics g)
        {
            g.DrawImageUnscaled(backgroundImage, new Point(0, 0));
            g.DrawImageUnscaled(gameNameImage, new Point(200, 150));
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void enableButtons()
        {
            btnPlay.Enabled = true;
            btnPlay.Visible = true;
            btnHighScore.Enabled = true;
            btnHighScore.Visible = true;
            btnExit.Enabled = true;
            btnExit.Visible = true;
        }

        private void disableButtons()
        {
            btnPlay.Enabled = false;
            btnPlay.Visible = false;
            btnHighScore.Enabled = false;
            btnHighScore.Visible = false;
            btnExit.Enabled = false;
            btnExit.Visible = false;
        }

        private void setPlayMode()
        {
            startMenu = false;
            inPlayMode = true;
            inHighScoreMode = false;
        }


        private void setMainMenuMode()
        {
            startMenu = true;
            inPlayMode = false;
            inHighScoreMode = false;
        }

        
        private void setHighScoreMode()
        {
            startMenu = false;
            inPlayMode = false;
            inHighScoreMode = true;
        }


        private void btnPlayClick(object sender, EventArgs e)
        {
            disableButtons();
            setPlayMode();
            Invalidate(true);
        }
    }
}