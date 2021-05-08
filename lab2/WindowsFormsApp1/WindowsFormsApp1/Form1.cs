using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureLib;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Graphics g;
        private Color CurrentColor = Color.Red;

        private Pen Pen { get { return new Pen(CurrentColor, 2F); } }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDrawers();

            if (figureListBox.Items.Count > 0)
            {
                figureListBox.SelectedIndex = 0;
            }
        }

        private void InitializeDrawers()
        {
            figureListBox.Items.Add(new FigureList() { Text = "Line", Value = new LineDrawer() });
            figureListBox.Items.Add(new FigureList() { Text = "Elips", Value = new ElipsDrawer() });
            figureListBox.Items.Add(new FigureList() { Text = "Circle", Value = new CirculDrawer() });
            figureListBox.Items.Add(new FigureList() { Text = "Rectangle", Value = new RectangleDrawer() });
            figureListBox.Items.Add(new FigureList() { Text = "Square", Value = new SquareDrawer() });
            figureListBox.Items.Add(new FigureList() { Text = "Triangle", Value = new TriangleDrawer() });
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                g = pictureBox1.CreateGraphics();
                var mouseEventArgs = e as MouseEventArgs;

                if (mouseEventArgs == null) return;

                var selectedDrawer = (figureListBox.SelectedItem as FigureList)?.Value as FigureDrawer;

                selectedDrawer?.Draw(g, Pen, mouseEventArgs.X, mouseEventArgs.Y);
            }
        }
    }

