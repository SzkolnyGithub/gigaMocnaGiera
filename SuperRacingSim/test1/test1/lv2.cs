﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class lv2 : Form
    {
        int x = 710;
        int y = 370;
        bool shown = false;
        public lv2()
        {
            InitializeComponent();
            okno_glowne.Width = 820;
            okno_glowne.Height = 500;
            MaximizeBox = false;
            MinimizeBox = false;
            samochod.Location = new Point(x, y);
        }
        private void Ustaw()
        {
            System.Timers.Timer licznik = new System.Timers.Timer(1); // moze 10
            licznik.Elapsed += sprawdz;
            licznik.AutoReset = true;
            licznik.Enabled = true;
        }
        private void sprawdz(object sender, EventArgs e)
        {
            int width = okno_glowne.Width / 5;
            int height = okno_glowne.Height / 3;
            if(x < width*4 && y+samochod.Height > height*2 || x+samochod.Width > width && y < height)
            {
                kraksa();
            }
            if(x < 0 || x+samochod.Width > okno_glowne.Width || y+samochod.Height > okno_glowne.Height)
            {
                kraksa();
            }
            if(x > 0 && x < width && y <= 55)
            {
                PokazMessage();
            }
           
        }

        private void PokazMessage()
        {
            if (!shown)
            {
                shown = true;
                MessageBox.Show("Udało ci się wygrać!");
                Application.Restart();
            }
        }

        private void kraksa()
        {
            x = 710;
            y = 370;
            MessageBox.Show("Wyjechałeś poza drogę!");
        }
        private void okno_glowne_Paint(object sender, PaintEventArgs e)
        {
            Graphics gdi = e.Graphics;
            int width = okno_glowne.Width / 5;
            int height = okno_glowne.Height / 3;
            Pen pen = new Pen(Brushes.Black, 2);
            Pen pen2 = new Pen(Brushes.Gray, 2);
            Pen white2 = new Pen(Color.WhiteSmoke);
            SolidBrush Gray = new SolidBrush(Color.Gray);
            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.WhiteSmoke);
            Rectangle droga1 = new Rectangle(width * 4, height, width, height*2);
            Rectangle droga2 = new Rectangle(0, height, okno_glowne.Width, height);
            Rectangle droga3 = new Rectangle(0, 0, width, height);
            Rectangle koniecB = new Rectangle(0, 25, width, 30);
            Rectangle koniecC = new Rectangle(0, 55, width, 30);
           
            gdi.FillRectangle(Gray, droga1);
            gdi.FillRectangle(Gray, droga2);
            gdi.FillRectangle(Gray, droga3);
            gdi.FillRectangle(white, koniecB);
            gdi.FillRectangle(Black, koniecC);
            //dorobić obramówkę za pomocą drawline tutaj na końcu
        }

        private void okno_glowne_MouseMove(object sender, MouseEventArgs e)
        {
            // l1.Text = "X: " + e.X + " Y: " + e.Y;
        }
        private void lv2_Load(object sender, EventArgs e) { Ustaw(); }
        private void lv2_MouseMove(object sender, MouseEventArgs e) { }

        private void lv2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                x -= 5;
                samochod.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.D)
            {
                x += 5;
                samochod.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.W)
            {
                y -= 5;
                samochod.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.S)
            {
                y += 5;
                samochod.Location = new Point(x, y);
            }
        }
    }
}
