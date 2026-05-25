using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Testing commit and push");
            Console.WriteLine("Changing in Github");
            Console.WriteLine("Changing in Github.Testing Fetch and Pull");
        }

        public static void Test_Fn()
        {
            Console.WriteLine("Local Commit and Sync Test");
        }

        public static void Branch_2()
        {
            Console.WriteLine("Branch_2 Test");
        }

        public static void Branch_2(int a)
        {
            Console.WriteLine("Branch_2 Test commit and push");
        }
        public static void Branch_2(int a,int b)
        {
            Console.WriteLine("Branch_2 Test push without commit");
        }

        public static void Branch_3(int a, int b)
        {
            Console.WriteLine("Branch_2 Test push with commit");
        }

    }
}
