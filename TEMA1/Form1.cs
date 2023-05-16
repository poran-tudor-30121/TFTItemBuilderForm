using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEMA1
{

    public partial class Form1 : Form
    {
        
        private string[,] completedItems = new string[9, 9];
        private string[,] completedItemsFiles = new string[9, 9];
        string[] itemComponents = File.ReadAllLines(@"D:\Facultate stuff\II\Laburi\TEMA1\TEMA1\TEMA1\TextFile1.txt");

        string[] itemNames = File.ReadAllLines(@"D:\Facultate stuff\II\Laburi\TEMA1\TEMA1\TEMA1\TextFile2.txt");

        string[] files = File.ReadAllLines(@"D:\Facultate stuff\II\Laburi\TEMA1\TEMA1\TEMA1\TextFile3.txt");

        string[] itemComponentsFiles = File.ReadAllLines(@"D:\Facultate stuff\II\Laburi\TEMA1\TEMA1\TEMA1\TextFile4.txt");




        public Form1()
        {

            InitializeComponent();

            int i = 0;
            int j = 0;
            int index;
            int count = 0;
            while (i < 9)
            {
                while (j < 9)
                {

                    index = count;
                    completedItems[i, j] = itemNames[index];
                    completedItems[j, i] = itemNames[index];
                    completedItemsFiles[i, j] = files[index];
                    completedItemsFiles[j, i] = files[index];
                    count++;
                    j++;

                }
                j = i + 1;
                i++;
            }
         
                    Console.Write(completedItems[3, 4] + "\t");
            Console.Write(completedItemsFiles[3, 4] + "\t");

            Console.WriteLine();
         



            using (StreamReader sr = new StreamReader(@"D:\Facultate stuff\II\Laburi\TEMA1\TEMA1\TEMA1\TextFile1.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                    listBox2.Items.Add(line);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex != -1) 
            {
                int selectedIndex = listBox1.SelectedIndex;
               // if(pictureBox1.Image == null)
                pictureBox1.Image = Image.FromFile(itemComponentsFiles[selectedIndex]);
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) 
            {
                int selectedIndex = listBox2.SelectedIndex;
                // if(pictureBox1.Image == null)
                pictureBox2.Image = Image.FromFile(itemComponentsFiles[selectedIndex]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            label1.Text = null;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                label1.Text = completedItems[listBox1.SelectedIndex, listBox2.SelectedIndex];
                pictureBox3.Image = Image.FromFile(completedItemsFiles[listBox1.SelectedIndex, listBox2.SelectedIndex]);
            }
            
            

            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
        }


       
        
    } }
