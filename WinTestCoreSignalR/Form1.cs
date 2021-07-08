using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestCoreSignalR
{
    public partial class Form1 : Form
    {
        private HubConnection hubConnection;
        public static string connStr = @"Data Source=LAPTOP-0GJ6OIKS;Initial Catalog=machine_monitor;
                            Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignalRConnection();
            GetMachineList();
        }
        // connect to signalR hub
        public async void SignalRConnection()
        {
            hubConnection = new HubConnectionBuilder()
                  .WithUrl("https://localhost:44312/MonitorHub")
                  .Build();
            hubConnection.On<string>("ReceiveMachineData", (message) =>
            {
                this.Invoke(new Action(() =>
                {
                    //this.textBox2.Text = message;
                }));
            });
            //回復請求來源
            hubConnection.On<string>("GetRequestMachineData", (userId) =>
            {
                DataTable allMachine = new DataTable();
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    string sql = "SELECT * FROM Machine";
                    connection.Open();
                    using (SqlDataAdapter dr = new SqlDataAdapter(sql, connection))
                    {
                        dr.Fill(allMachine);

                        Invoke(new Action(() => { dataGridView1.DataSource = allMachine; }));
                    }
                }
                hubConnection.InvokeAsync("SendUserMachine", userId, JsonConvert.SerializeObject(allMachine));
            });
            try
            {
                await hubConnection.StartAsync();
                await hubConnection.InvokeAsync("AddToDataSource");
                Lbl_hub_connect.BackColor = Color.Green;
            }
            catch
            {
                Lbl_hub_connect.BackColor = Color.Red;
            }

            hubConnection.Closed += async (error) =>
            {
                Lbl_hub_connect.BackColor = Color.Red;
                //await Task.Delay(new Random().Next(0, 5) * 1000);
                //await connection.StartAsync();
            };
        }
       
        // select Machine table, add to List<machine>
        public void GetMachineList()
        {
            machineList.Clear();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                //refresh select state
                string sql = "SELECT * FROM Machine";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Machine eachMachine = new Machine();
                        eachMachine.Id = Convert.ToInt32(dr["Id"]);
                        eachMachine.Name = Convert.ToString(dr["Name"]);
                        eachMachine.Type = Convert.ToInt32(dr["Type"]);
                        eachMachine.State = Convert.ToInt32(dr["State"]);
                        machineList.Add(eachMachine);
                    }
                }

            }
        }
        
        // Machine Class
        public class Machine
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Type { get; set; }
            public int State { get; set; }
        }
        public static List<Machine> machineList = new List<Machine>();

        //抓 MachineType
        public void GetTypeList()
        {
            typeList.Clear();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                //refresh select state
                string sql = "SELECT * FROM Machine_Type";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MachineType eachType = new MachineType();
                        eachType.Id = Convert.ToInt32(dr["Id"]);
                        eachType.Type_Name = Convert.ToString(dr["Type_Name"]);
                        
                        typeList.Add(eachType);
                    }
                }

            }
        }
        // Machine Class
        public class MachineType
        {
            public int Id { get; set; }
            
            public string Type_Name { get; set; }
           
        }
        public static List<MachineType> typeList = new List<MachineType>();


        public void GetStateList()
        {
            stateList.Clear();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                //refresh select state
                string sql = "SELECT * FROM Machine_Type";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MachineState eachState = new MachineState();
                        eachState.Id = Convert.ToInt32(dr["Id"]);
                        eachState.State_Name = Convert.ToString(dr["Type_Name"]);

                        stateList.Add(eachState);
                    }
                }

            }
        }
        public class MachineState
        {
            public int Id { get; set; }
            public string State_Name { get; set; }
            
        }
        public static List<MachineState> stateList = new List<MachineState>();
        //不明
        private async void Btn_LinkHub_Click(object sender, EventArgs e)
        {
            DataTable allMachine = new DataTable();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Machine";
                connection.Open();
                using (SqlDataAdapter dr = new SqlDataAdapter(sql, connection))
                {
                    dr.Fill(allMachine);

                    Invoke(new Action(() => { dataGridView1.DataSource = allMachine; }));
                }
            }
            await hubConnection.InvokeAsync("SendMachine", JsonConvert.SerializeObject(allMachine));
        }


        private void Btn_Read_Machine_Click(object sender, EventArgs e)
        {
            UpdatDataGridView();
        }
        public void UpdatDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Machine";
                DataTable datatable = new DataTable();
                connection.Open();

                using (SqlDataAdapter dr = new SqlDataAdapter(sql, connection))
                {
                    dr.Fill(datatable);
                    List<Machine> newMachineList = new List<Machine>();
                    foreach(DataRow row in datatable.Rows)
                    {
                        Machine addMch = new Machine();
                        addMch.Id = row.Field<int>(columnName: "Id");
                        addMch.Name = row.Field<string>(columnName: "Name");
                        addMch.Type = row.Field<int>(columnName: "Type");
                        addMch.State = row.Field<int>(columnName: "Type");
                        newMachineList.Add(addMch);
                    }
                    machineList.Clear();
                    machineList = newMachineList;
                    //this.Invoke((EventHandler)(delegate
                    //{
                    //    dataGridView1.DataSource = datatable;
                    //}));
                    Invoke(new Action(() => { dataGridView1.DataSource = datatable; }));
                }
            }
        }
        
        private void Btn_Machine_Refresh_Click(object sender, EventArgs e)
        {
            Select_Machine_State.Items.Clear();
            Select_Machine_Type.Items.Clear();
            Select_Machine_Data.Items.Clear();
            Select_Machine_Update.Items.Clear();
            Select_Error_Machine.Items.Clear();
            Select_Error_Id.Items.Clear();
            GetMachineList();
            GetTypeList();
            GetStateList();
            machineList.ForEach((machine) =>
            {
                
                
                Select_Machine_Update.Items.Add(machine.Id);
                Select_Machine_Data.Items.Add(machine.Id);
                Select_Error_Machine.Items.Add(machine.Id);
            });
            typeList.ForEach((type) =>
            {
                Select_Machine_Type.Items.Add(type.Id);
            });
            stateList.ForEach((state) =>
            {
                Select_Machine_State.Items.Add(state.Id);
            });
        }
        private void Btn_Refresh_Machine_Data_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Machine";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Select_Machine_Data.Items
                            .Add(dr["Id"]);
                    }
                }
            }
        }
        // 把Id, temper , now 加到 資料庫
        public void AddData(int id, decimal temper)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = @"INSERT Machine_Data(Id,Machine_Id,Temperature, Time)
                        VALUES(@guid, @machineId, @temper, @time )";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SqlParameter("@guid", SqlDbType.UniqueIdentifier));
                    cmd.Parameters.Add(new SqlParameter("@machineId", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@temper", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@time", SqlDbType.DateTime));
                    cmd.Parameters["@guid"].Value = Guid.NewGuid();
                    cmd.Parameters["@machineId"].Value = id;
                    //cmd.Parameters["@temper"].Value = decimal.Parse(Machine_Data_Temperature.Text);
                    cmd.Parameters["@temper"].Value = temper;
                    cmd.Parameters["@time"].Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void Machine_Data_Add_Click(object sender, EventArgs e)
        {
            int addId = int.Parse(Select_Machine_Data.SelectedItem.ToString());
            decimal addTemper = numericUpDown1.Value;
            AddData(addId, addTemper);
        }
        // 新增加 Machine
        private void Btn_Create_Machine_Click(object sender, EventArgs e)
        {
            AddMachine();
        }
        // 把UI上的數值新增Machine
        public void AddMachine()
        {
            //dynamic a = new object();
            //a.a.a = "rgaage";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = $@"INSERT INTO Machine( Name, Type, State)
                        VALUES('{Input_Machine_Name.Text}', {Select_Machine_Type.SelectedItem},
                {Select_Machine_State.SelectedItem} )";
                //string sql = $@"INSERT INTO Machine( Name, Type, State)
                //        VALUES( 'test', 1,
                //1)";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {

                    cmd.ExecuteNonQuery();
                }
            }
        }
        // 更新加 Machine
        private void Btn_Update_Machine_Click(object sender, EventArgs e)
        {
            UpdataMachine();
        }
        // 把UI上的數值更新Machine
        public void UpdataMachine()
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = $@"UPDATE Machine Set Name = '{Input_Machine_Name.Text}', 
                            Type={Select_Machine_Type.SelectedItem},
                            State=  {Select_Machine_State.SelectedItem}  
                            WHERE Id={Select_Machine_Update.SelectedItem}   ";

                //string sql = $@"INSERT INTO Machine( Name, Type, State)
                //        VALUES( 'test', 1,
                //1)";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #region "SqlDependency"
        // 資料庫監看
        private void Btn_StartSqlDependency_Click(object sender, EventArgs e)
        {

            SqlDependency.Start(connStr);
            //建立SqlDependency OnChangeEventHandler
            SqlDependencyWatch();
            DataWatch();
        }
        // 監看 Machine 資料表
        private void SqlDependencyWatch()
        {
            //這邊用的查詢欄位不能式PK，資料表也必須是完整的像dbo.TableName
            string sSQL = "select Id, Name, Type, State from [dbo].[Machine]";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand(sSQL, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDependency dependency = new SqlDependency(command);
                    //這間加入監聽事件SQLTableOnChange
                    dependency.OnChange += new OnChangeEventHandler(SQLTableOnChange);
                    command.ExecuteReader();

                }
            }
            //MessageBox.Show("dependency start");
        }
        // 資料表有變化的事件
        // 送出 MachineList
        async void SQLTableOnChange(object sender, SqlNotificationEventArgs e)
        {
            //觸發後再開啟一次監聽事件    
            SqlDependencyWatch();
            //執行我自己要執行的邏輯處理
            //RefreshTable();
            //Btn_LinkHub_Click(sender, e);
            DataTable allMachine = new DataTable();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Machine";
                connection.Open();
                using (SqlDataAdapter dr = new SqlDataAdapter(sql, connection))
                {
                    dr.Fill(allMachine);

                    Invoke(new Action(() => { dataGridView1.DataSource = allMachine; }));
                }
            }
            await hubConnection.InvokeAsync("SendMachine", JsonConvert.SerializeObject(allMachine));
        }
        // 資料表有變化的事件
        // 送出 Machine_Data
        private void DataWatch()
        {
            string sSQL = " SELECT Id FROM [dbo].[Machine_Data]";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand(sSQL, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDependency dependency = new SqlDependency(command);
                    //這間加入監聽事件SQLTableOnChange
                    dependency.OnChange += new OnChangeEventHandler(DataOnChange);
                    command.ExecuteReader();

                }
            }
        }
        void DataOnChange(object sender, SqlNotificationEventArgs e)
        {
            //觸發後再開啟一次監聽事件    
            DataWatch();
            //執行我自己要執行的邏輯處理
            
            SendEachMachineData();
        }
        // 查詢資料庫, 送出資料
        public void SendEachMachineData()
        {
            DataSet ds = new DataSet();
            DataTable machineData = new DataTable();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = $@"SELECT * FROM Machine_Data ";
                //ORDER BY CONVERT(DateTime, Time, 120) DESC LIMIT 10";
                connection.Open();
                using (SqlDataAdapter dr = new SqlDataAdapter(sql, connection))
                {
                    dr.Fill(ds, "allMachineData");
                    machineList.ForEach((each) => {
                        int id = each.Id;
                        var eachData = (from p in ds.Tables["allMachineData"].AsEnumerable()
                                        where p.Field<int>("Machine_Id") == id
                                        orderby p.Field<DateTime>("Time") descending
                                        select new
                                        {
                                            Id = p.Field<Guid>("Id"),
                                            Machine_Id = p.Field<int>("Machine_Id"),
                                            Temperature = p.Field<decimal>("Temperature"),
                                            Time = p.Field<DateTime>("Time")
                                        }).Take(10);

                        hubConnection.InvokeAsync("SendMachineData", id.ToString(), JsonConvert.SerializeObject(eachData.ToList()));
                    });

                    //Invoke(new Action(() => { dataGridView1.DataSource = eachData.ToList(); }));
                }
            }
        }
        #endregion

        #region "Auto Fake Data"
        //刻元件MachineTrack, track 數值會顯示在 label
        public class MachineTrack
        {
            public Label lbl;
            public TrackBar trackBar;
            public MachineTrack()
            {
                lbl = new Label();
                lbl.BackColor = Color.Gray;
                trackBar = new TrackBar();
                lbl.Text = trackBar.Value.ToString();
                trackBar.ValueChanged += TrackBar_ValueChanged;
            }

            private void TrackBar_ValueChanged(object sender, EventArgs e)
            {
                lbl.Text = trackBar.Value.ToString();
            }
        }
        
        Dictionary<string, MachineTrack> MachineTrackList = new Dictionary<string, MachineTrack>();
        //把machineList 產生{ machine.Id : MachineTrack } 的MachineTrackList
        public void MakeMachineTrackBar()
        {
            int i = 0;
            int gap = 80;
            machineList.ForEach((machine) =>
            {
                i += 1;
                // scroll template
                MachineTrack add = new MachineTrack();
                add.lbl.Name = "MachineLbl" + machine.Id.ToString();
                add.lbl.Size = new Size(100, 30);
                add.lbl.Location = new Point(10, gap * i);
                Panel_MachineData.Controls.Add(add.lbl);
                add.trackBar.Name = "MachineTrack" + machine.Id.ToString();
                add.trackBar.Maximum = 50;
                add.trackBar.Minimum = 0;
                add.trackBar.Size = new Size(100, 100);
                add.trackBar.Location = new Point(110, gap * i);
                Panel_MachineData.Controls.Add(add.trackBar);
                MachineTrackList.Add(machine.Id.ToString(), add);
            });
            
            
        }
        private void Btn_MakeScroll_Click(object sender, EventArgs e)
        {
            MakeMachineTrackBar();
        }

        // 模擬資料產生
        private void Tmr_TestData_Tick(object sender, EventArgs e)
        {
            machineList.ForEach((machine) =>
            {
                //MachineList 的Id 在 MachineTrackList 對應到的 MachineTrack
                if (MachineTrackList.ContainsKey(machine.Id.ToString()) == true)
                {
                    // Insert Value to db
                    AddData(machine.Id, MachineTrackList[machine.Id.ToString()].trackBar.Value);
                }
                
            });
        }
        //start or stop AutoDataTimer
        private void Btn_AutoData_Click(object sender, EventArgs e)
        {
            if (Tmr_TestData.Enabled == false)
            {
                Btn_AutoData.BackColor = Color.Green;
                Tmr_TestData.Start();
            }else if(Tmr_TestData.Enabled == true)
            {
                Btn_AutoData.BackColor = Color.Yellow;
                Tmr_TestData.Stop();
            }
            
        }
        #endregion
        //重新連結
        private void Btn_HubConnect_Click(object sender, EventArgs e)
        {
            SignalRConnection();
        }

        
        /* For Test

//For Test
private void button1_Click(object sender, EventArgs e)
{
   string machineId = "3";
   //string machineData = "";
   DataTable machineData = new DataTable();
   using (SqlConnection connection = new SqlConnection(connStr))
   {
       string sql = $@"SELECT TOP 10 * FROM Machine_Data WHERE Machine_Id = {machineId} 
                   ORDER BY CONVERT(DateTime, Time, 120) DESC ";
       //ORDER BY CONVERT(DateTime, Time, 120) DESC LIMIT 10";
       connection.Open();
       using (SqlDataAdapter dr = new SqlDataAdapter(sql, connection))
       {
           dr.Fill(machineData);

           Invoke(new Action(() => { dataGridView1.DataSource = machineData; }));
       }
   }
   hubConnection.InvokeAsync("SendMachineData", machineId, JsonConvert.SerializeObject(machineData));
}

private void button2_Click(object sender, EventArgs e)
{
   SendEachMachineData();

}
// For test
private void A_Click(object sender, EventArgs e)
{
   MessageBox.Show("newBtn");
}

*/





        //private void button3_Click(object sender, EventArgs e)
        //{
        //    button3.BackColor = Color.Red;
        //    new Task(new Action(() => { Task.Delay(9999).Wait(); button3.BackColor = Color.Green; })).Start();
        //    //button3.BackColor = Color.Green;
        //    //Task.Delay(99999);

        //}
    }
}
