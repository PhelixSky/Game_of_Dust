using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Game_of_Dust.Model;
using Game_of_Dust.Model.Particles;

namespace Game_of_Dust
{
    public partial class MainForm : Form
    {
        private Sandbox sb;
        private Tools tools;
        private int physCounter = 0;
        private Sandbox Sandbox { get; set; }
        
       
        public MainForm()
        {
            InitializeComponent();

            //создаем песочницу
            sb = new Sandbox();
            //создаем инструмент рсования
            tools = new Tools(){Sandbox = sb};

            cbTool.SelectedIndex = 0;
            pnSandbox.Sandbox = sb;

            //запускаем моделирование физики в отдельном потоке
            ThreadPool.QueueUserWorkItem((_) =>
            {
                var sw = new Stopwatch();
                //цикл моделирования физики
                const float dt = 0.25f;
                while (true)
                {
                    sw.Restart();
                    sb.Update((float)dt);
                    physCounter++;
                    var el = (int)sw.ElapsedMilliseconds;
                    if (el < 20)
                        Thread.Sleep(20 - el);//ограничиваем FPS
                }
            });

            //запускаем таймер обновления интерфейса
            new System.Windows.Forms.Timer { Enabled = true, Interval = 15 }.Tick += delegate { UpdateCreator(); pnSandbox.Invalidate(); };
            //запускаем таймер FPS
            new System.Windows.Forms.Timer { Enabled = true, Interval = 1000 }.Tick += CalcFPS;
        
        }

        private int oldPhysCounter;
        private int oldPaintCounter;

        private void CalcFPS(object sender, EventArgs e)
        {
            var fps1 = physCounter - oldPhysCounter;
            oldPhysCounter = physCounter;
            var fps2 = pnSandbox.FrameCounter - oldPaintCounter;
            oldPaintCounter = pnSandbox.FrameCounter;

            label1.Text = string.Format("Phys: {0} fps, Draw: {1} fps, Particles: {2}", fps1, fps2, sb.Particles.Count);
        }
        public void SoPen_ValueChanged(object sender, EventArgs e)
        {
            
            SoPen.Maximum = 100;
            SoPen.Minimum = 1;
            if (SoPen.Value > SoPen.Maximum)
                SoPen.Value = SoPen.Maximum;
            else if (SoPen.Value < SoPen.Minimum)
                SoPen.Value = SoPen.Minimum;

        }

        private void UpdateCreator()
        {
            int ValRadius = Convert.ToInt32(SoPen.Value);
            if (pnSandbox.Focused)
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    var radius = ValRadius;
                    var pos = pnSandbox.PointToClient(Control.MousePosition);

                    //создаем частицы
                    /*switch (cbTool.Text)
                    {
                        case "Sand": tools.CreateParticles<SandParticle>(pos, radius); break;
                        case "Solid": tools.CreateParticles<SolidParticle>(pos, radius); break;
                        case "Water": tools.CreateParticles<WaterParticle>(pos, radius); break;
                    }*/
                
                if (SandBut.Checked)
                {
                    tools.CreateParticles<SandParticle>(pos, radius);
                }
                if (WaterBut.Checked)
                {
                    tools.CreateParticles<WaterParticle>(pos, radius);
                }
                if (WallBut.Checked)
                {
                    tools.CreateParticles<SolidParticle>(pos, radius);
                }
                if (CmntBut.Checked)
                {
                    tools.CreateParticles<FoamParticle>(pos, radius);
                }
              /*  if (EraserBut.Checked)
                {
                    tools.CreateParticles(pos, radius, "Eraser");
                }
                if(AsidBut.Checked)
                {
                    tools.CreateParticles(pos, radius, "ASID");
                }
                */
                
                    

            }
           
        }

        private void pnSandbox_Load(object sender, EventArgs e)
        {

        }

        private void cbTool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void DustsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DustTypeLabel_MouseHover(object sender, EventArgs e)
        {
            SandBut.Visible = true;
            CmntBut.Visible = true;
            WallBut.Visible = false;
            WaterBut.Visible = false;
        }

        private void LiquidTypeLabel_MouseHover(object sender, EventArgs e)
        {

            SandBut.Visible = false;
            CmntBut.Visible = false;
            WallBut.Visible = false;
            WaterBut.Visible = true;
        }

        private void SolidTypeLabel_MouseHover(object sender, EventArgs e)
        {
            SandBut.Visible = false;
            CmntBut.Visible = false;
            WallBut.Visible = true;
            WaterBut.Visible = false;
        }

        private void SandBut_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnSandbox_Scroll(object sender, ScrollEventArgs e)
        {
            //сделать скроллинг по экрану
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void All_MouseHover(object sender, EventArgs e)
        {
            SandBut.Visible = true;
            CmntBut.Visible = true;
            WallBut.Visible = true;
            WaterBut.Visible = true;
        }

      


    

        

    }
}
