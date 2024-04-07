namespace pryProyectoNave
{

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;


    public partial class Form1 : Form
    {

        public static Form1 Instance { get; private set; }

        private List<NaveEnemiga> navesEnemigas;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
    
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            
            this.KeyPreview = true;


            
            ///Naves Enemigas
            

            Instance = this;

            
            InicializarNavesEnemigas();

            
            timer = new Timer();
            timer.Interval = 10; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                
                if (pctNavePrincipal.Left > 0) 
                    pctNavePrincipal.Left -= 10; 
            }
            else if (e.KeyCode == Keys.Right)
            {
                
                if (pctNavePrincipal.Right < this.ClientSize.Width) 
                    pctNavePrincipal.Left += 10; 
            }
        }

        private void InicializarNavesEnemigas()
        {
            navesEnemigas = new List<NaveEnemiga>();
            for (int i = 0; i < 8; i++)
            {
                int x = 100 + i * 100; 
                int y = 50; 
                int width = 50;
                int height = 50;
                Image imagen = Properties.Resources.naveEnemiga1; 

                NaveEnemiga naveEnemiga = new NaveEnemiga(x, y, width, height, imagen);
                navesEnemigas.Add(naveEnemiga);
                Controls.Add(naveEnemiga.PictureBox); 
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            foreach (var nave in navesEnemigas)
            {
                nave.Mover();
            }
        }
    }
}

