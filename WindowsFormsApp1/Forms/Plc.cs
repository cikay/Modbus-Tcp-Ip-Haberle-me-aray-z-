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

        
        Thread Th_UpdateCoilsValue;
       

        System.Timers.Timer timer_UpdateCoilsValue = new System.Timers.Timer();
       
        #endregion

        public Plc()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            #region İşlem1 için timer1 ve thread1 İşlem2 için timer2 ve thread2 aynı şekilde işlem arttıkça bunları çoğaly
            
            timer_UpdateCoilsValue.Enabled = true;
            timer_UpdateCoilsValue.Interval = 500;
            timer_UpdateCoilsValue.Elapsed += timer_UpdateCoilsValue_Elapsed;
            timer_UpdateCoilsValue.Start();
            #endregion


        }

        private void timer_UpdateCoilsValue_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Th_UpdateCoilsValue = new Thread(new ThreadStart(UptadeCoilsValue));
            Th_UpdateCoilsValue.Start();

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


            int StartingAdress = 0;
            int row = 0;
            int column = 0;

            Label lb_Adress = new Label();
            lb_Adress.Text = "Adres";
            lb_Adress.Name = lb_Adress.Text;
            lb_Adress.Location = new Point(10, 6);
            tLp_PlcMemory.Controls.Add(lb_Adress, column, row);
           
            column++;

            for (int i = 0; i < 11; i++)
            {
                Label lb_AdressInfo = new Label();
                lb_AdressInfo.Text = (i ).ToString();
                lb_AdressInfo.TextAlign = ContentAlignment.MiddleCenter;
                lb_AdressInfo.Name = lb_AdressInfo.Text;
                lb_AdressInfo.Location = new Point(10, 6);
                tLp_PlcMemory.Controls.Add(lb_AdressInfo, column, row);
              
                column++;
            }

            row=1;


            while (true)
            {
                column = 0;
                lb_Adress lb_Coil = new lb_Adress();
                lb_Coil.Text = (StartingAdress).ToString() + "-" + (StartingAdress + 9).ToString();
                lb_Coil.Name = lb_Coil.Text;
                lb_Coil.Location = new Point(10, 6);

                tLp_PlcMemory.Controls.Add(lb_Coil, column, row);

                for (int i = 0; i < 11; i++)
                {
                    column++;
                    CoilControl Coil = new CoilControl();
                    Coil.Text = "-";
                    Coil.Adress = StartingAdress;
                    Coil.Value = false;
                    Coil.Size = new Size(60, 18);
                    Coil.Location = new Point(10, 6);
                    Coil.Visible = true;
                    Coil.BackColor = Color.DimGray;
                    Coil.AutoSize = false;
                    Coil.TextAlign = ContentAlignment.MiddleCenter;
                    tLp_PlcMemory.Controls.Add(Coil, column, row);
                    StartingAdress++;

                }

                if (column == 11 && row == 11) break;
                row++;
                
            }
        }

       
        private void UptadeCoilsValue()
        {

            bool[] CoilsValue = new bool[100];
            CoilsValue = Modbus.modbusClient.ReadCoils(0, 121);

            int column=1, row = 1, index=0;
            string text;
          

            while (true)
            {

                CoilControl Coil= new CoilControl();
                column = 1;



                for (int i = 0; i < 11; i++)
                {
                    Coil = (CoilControl)tLp_PlcMemory.GetControlFromPosition(column, row);
                    
                    text = CoilsValue[index].ToString();

                    Coil.Text = text;
                    if (String.Compare(Coil.Text, "True") == 0) Coil.BackColor = Color.DeepSkyBlue;
                    else if (String.Compare(Coil.Text, "False") == 0) Coil.BackColor = Color.DimGray;
                    
                    column++;
                    index++;
                }
              
                if (column == 12 && row == 11) break;

                row++;
            }
        }
        public delegate void ProcessInvoker();

        

        void TestProcess()
        {
           
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
