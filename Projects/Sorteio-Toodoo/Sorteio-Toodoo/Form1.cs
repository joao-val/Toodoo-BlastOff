using OfficeOpenXml;
using Sorteio_Toodoo.entities;
using Sorteio_Toodoo.services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Sorteio_Toodoo
{
    
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            EmployeeList = new List<Employee>();
            SaveWinners = new SaveWinners();
            player.URL = Music("Crash_Bandicoot_1_Theme_(Extended).mp3");
        }

        private List<Employee> EmployeeList { get; set; }

        public SaveWinners SaveWinners { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            HomePage();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage();
        }

        public void HomePage()
        {
            congratulations.Hide();
            repeated.Hide();
            countdown.Hide();
            timer1.Stop();
            winnersGif.Hide();
            listBoxWinners.Hide();
            homePage.Show();
            textWinners.Hide();
            Raffle_Button.Show();
        }

        public string Music(string fileName)
        {
            string path = Path.GetFullPath(fileName);
            return path;
        }

        private void Raffle_Button_Click(object sender, EventArgs e)
        {
            Drawing();
        }

        private void Drawing()
        {
            var drawing = new Drawing();
            EmployeeList = drawing.EmployeeList;
            repeated.Hide();
            winnersGif.Hide();
            homePage.Hide();
            congratulations.Hide();
            listBoxWinners.Items.Clear();
            listBoxWinners.Show();
            timer1.Start();
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            homePage.Hide();
            Raffle_Button.Hide();
            winnersGif.Show();
            listBoxWinners.Show();
            textWinners.Show();
            repeated.Hide();
            congratulations.Hide();

            foreach (var winner in SaveWinners.WinnersList)
            {
                listBoxWinners.Items.Add(winner.Name);
            }
        }

        private void Gift_Click(object sender, EventArgs e)
        {
        }

        private void listBoxWinners_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textWinners_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {   
            count++;
            Random random = new Random();

            int value = random.Next(0, EmployeeList.Count() - 1);
            countdown.Show();
            if (count == 6)
            {
                count = 0;
                countdown.Hide();
                timer1.Stop();
                listBoxWinners.Items.Add(Convert.ToString(EmployeeList[value].Name));
                if (SaveWinners.Compare(EmployeeList[value].Name) == true)
                {
                    congratulations.Show();
                    ExcelControl.Save(EmployeeList[value], "Winners_List.xlsx");
                    SaveWinners.WinnersList.Add(EmployeeList[value]);
                }
                else
                {
                    repeated.Show();
                }
            }
        }

        private void winnersGif_Click(object sender, EventArgs e)
        {

        }

        private void congratulations_Click(object sender, EventArgs e)
        {

        }

        private void repeated_Click(object sender, EventArgs e)
        {

        }

        private void homePage_Click(object sender, EventArgs e)
        {

        }

        private void countdown_Click(object sender, EventArgs e)
        {

        }
    }
}
