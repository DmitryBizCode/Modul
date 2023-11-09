using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ModulWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShapeContainer shape = new ShapeContainer();
            dataGridView1.Rows.Clear();
            Random rand = new Random();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for(int i = 1; i <= Convert.ToInt32(textBox1.Text);  i++)
            {
                shape.AddShape(new Rhombus(rand.Next(1, 16)));
                dataGridView1.Rows.Add(shape.GetShapeNames(), shape.GetShapeData(), shape.GetShapeCalculations());
                shape.ClearShapes();
                shape.AddShape(new IsoscelesTriangle(rand.Next(1, 16), rand.Next(1, 16)));
                dataGridView1.Rows.Add(shape.GetShapeNames(), shape.GetShapeData(), shape.GetShapeCalculations());
                shape.ClearShapes();
                shape.AddShape(new Trapezoid(rand.Next(1, 16), rand.Next(1, 16), rand.Next(1, 16)));
                dataGridView1.Rows.Add(shape.GetShapeNames(), shape.GetShapeData(), shape.GetShapeCalculations());
                shape.ClearShapes();
                shape.AddShape(new PentagonalPyramid(rand.Next(1, 16), rand.Next(1, 16)));
                dataGridView1.Rows.Add(shape.GetShapeNames(), shape.GetShapeData(), shape.GetShapeCalculations());
                shape.ClearShapes();

            }
        }
    }
}
