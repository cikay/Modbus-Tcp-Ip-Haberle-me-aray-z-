using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Plc : Form
    {
        #region Timer,Thread

        
        Thread thread1;
        Thread thread2;

        System.Timers.Timer timer1 = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();
        #endregion

        public Plc()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            #region İşlem1 için timer1 ve thread1 İşlem2 için timer2 ve thread2 aynı şekilde işlem arttıkça bunları çoğaly
            
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Interval = 100;
            timer2.Interval = 500;
            timer1.Elapsed += Timer1_Elapsed;
            timer2.Elapsed += Timer2_Elapsed;

            timer1.Start();
            timer2.Start();
            #endregion


        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            thread1 = new Thread(new ThreadStart(WriteCoils));
            thread1.Start();
        }
        private void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            thread2 = new Thread(new ThreadStart(TestProcess));
            thread2.Start();
        }

        private void Plc_Load(object sender, EventArgs e)
        {
            try
            {
                Modbus.modbusClient.Connect();
                CreateCoil();
            }
            catch
            {
                MessageBox.Show("bağlanamadı");
            }

        }



        private void CreateCoil()
        {


            int StartingAdress = 1;
            int row = 0;
            int column = 0;

            Label lb_Adress = new Label();
            lb_Adress.Text = "Adres";
            lb_Adress.Name = lb_Adress.Text;
            lb_Adress.Location = new Point(10, 6);
            tLp_PlcMemory.Controls.Add(lb_Adress, column, row);
            column++;

            for (int i = 0; i < 10; i++)
            {
                Label lb_AdressInfo = new Label();
                lb_AdressInfo.Text = (i + 1).ToString();
                lb_AdressInfo.TextAlign = ContentAlignment.MiddleCenter;
                lb_AdressInfo.Name = lb_AdressInfo.Text;
                lb_AdressInfo.Location = new Point(10, 6);
                tLp_PlcMemory.Controls.Add(lb_AdressInfo, column, row);
                column++;
            }

            row++;


            while (true)
            {
                column = 0;
                lb_Adress lb_Coil = new lb_Adress();
                lb_Coil.Text = (StartingAdress).ToString() + "-" + (StartingAdress + 9).ToString();
                lb_Coil.Name = lb_Coil.Text;
                lb_Coil.Location = new Point(10, 6);

                tLp_PlcMemory.Controls.Add(lb_Coil, column, row);

                for (int i = 0; i < 10; i++)
                {
                    column++;
                    CoilControl Coil = new CoilControl();
                    Coil.Text = "0";
                    Coil.Adress = StartingAdress;
                    Coil.Value = false;
                    Coil.Size = new Size(70, 18);
                    Coil.Location = new Point(10, 6);
                    Coil.Visible = true;
                    Coil.BackColor = Color.DimGray;
                    Coil.AutoSize = false;
                    Coil.TextAlign = ContentAlignment.MiddleCenter;
                    tLp_PlcMemory.Controls.Add(Coil, column, row);
                    StartingAdress++;

                }

                if (column == 10 && row == 10) break;
                row++;
            }
        }

       
        private void WriteCoils()
        {

            bool[] CoilsValue = new bool[100];
            CoilsValue = Modbus.modbusClient.ReadCoils(1, 100);

            int column=1, row = 1, index=0;
            string text;
          

            while (true)
            {

                CoilControl Coil= new CoilControl();
                column = 1;



                for (int i = 0; i < 9; i++)
                {
                    Coil = (CoilControl)tLp_PlcMemory.GetControlFromPosition(column, row);
                    
                    text = CoilsValue[index].ToString();
                  

                    //Coil.BackColor = Color.Lime;
                    Coil.Text = text;

                    //if (String.Compare(Coil.Text, "false") == 0) Coil.BackColor = Color.DeepSkyBlue;
                    //else if (String.Compare(Coil.Text, "true") == 0) Coil.BackColor = Color.DimGray;

                    column++;
                    index++;
                }

                if (column == 10 && row == 10) break;

                row++;
            }
        }
        public delegate void ProcessInvoker();

        int i=0;

        void TestProcess()
        {
            
            textBox1.Text = i.ToString();
            i++;
        }

        private void btn_Connect_Click_1(object sender, EventArgs e)
        {
            Modbus.Connect(lb_ConnectionStatus);
        }

        private void btn_DisConnect_Click_1(object sender, EventArgs e)
        {
            Modbus.DisConnect(lb_ConnectionStatus);
        }

      

        private void btn_Write_Click(object sender, EventArgs e)
        {
            int column = 1, row = 1, Adress;
            string text;
            bool[] writingCoilsData = Modbus.modbusClient.ReadCoils(0, 100);
            int[] changedCoilStatus = new int[100];


            while (true)
            {

                CoilControl Coil;
                column = 1;



                for (int i = 0; i < 9; i++)
                {
                    Coil = (CoilControl)tLp_PlcMemory.GetControlFromPosition(column, row);
                    Adress = (row - 1) * 10 + column;
                    text = Convert.ToInt32(writingCoilsData[Adress]).ToString();
                    if (String.Compare(Coil.Text, text) == 1)
                    {
                        Coil.BackColor = Color.Lime;
                        Coil.Text = text;

                        if (String.Compare(Coil.Text, "0") == 0) Coil.BackColor = Color.DeepSkyBlue;
                        else if (String.Compare(Coil.Text, "1") == 0) Coil.BackColor = Color.DimGray;
                    }

                    column++;

                }

                if (column == 10 && row == 10) break;

                row++;
            }
        }
    }
}
