
namespace WinTestCoreSignalR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CRUDdata = new System.Windows.Forms.TabControl();
            this.Mahine = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Select_Machine_Update = new System.Windows.Forms.ComboBox();
            this.Btn_Update_Machine = new System.Windows.Forms.Button();
            this.Select_Machine_State = new System.Windows.Forms.ComboBox();
            this.Input_Machine_Name = new System.Windows.Forms.TextBox();
            this.Select_Machine_Type = new System.Windows.Forms.ComboBox();
            this.Btn_Create_Machine = new System.Windows.Forms.Button();
            this.Btn_Read_Machine = new System.Windows.Forms.Button();
            this.Machine_Data = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Machine_Data_Add = new System.Windows.Forms.Button();
            this.Select_Machine_Data = new System.Windows.Forms.ComboBox();
            this.Machine_Data_Temperature = new System.Windows.Forms.TextBox();
            this.Error_Log = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Add_Error_Log = new System.Windows.Forms.Button();
            this.Select_Error_Id = new System.Windows.Forms.ComboBox();
            this.Select_Error_Machine = new System.Windows.Forms.ComboBox();
            this.Btn_Machine_Refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_LinkHub = new System.Windows.Forms.Button();
            this.Btn_StartSqlDependency = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn_testSendSinalR = new System.Windows.Forms.Button();
            this.Lbl_hub_connect = new System.Windows.Forms.Label();
            this.Btn_TestSendEach = new System.Windows.Forms.Button();
            this.Tmr_TestData = new System.Windows.Forms.Timer(this.components);
            this.Panel_MachineData = new System.Windows.Forms.Panel();
            this.Btn_MakeScroll = new System.Windows.Forms.Button();
            this.Btn_AutoData = new System.Windows.Forms.Button();
            this.Btn_HubConnect = new System.Windows.Forms.Button();
            this.CRUDdata.SuspendLayout();
            this.Mahine.SuspendLayout();
            this.Machine_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Error_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUDdata
            // 
            this.CRUDdata.Controls.Add(this.Mahine);
            this.CRUDdata.Controls.Add(this.Machine_Data);
            this.CRUDdata.Controls.Add(this.Error_Log);
            this.CRUDdata.Location = new System.Drawing.Point(793, 12);
            this.CRUDdata.Name = "CRUDdata";
            this.CRUDdata.SelectedIndex = 0;
            this.CRUDdata.Size = new System.Drawing.Size(478, 527);
            this.CRUDdata.TabIndex = 3;
            // 
            // Mahine
            // 
            this.Mahine.Controls.Add(this.label8);
            this.Mahine.Controls.Add(this.label7);
            this.Mahine.Controls.Add(this.label6);
            this.Mahine.Controls.Add(this.label5);
            this.Mahine.Controls.Add(this.Select_Machine_Update);
            this.Mahine.Controls.Add(this.Btn_Update_Machine);
            this.Mahine.Controls.Add(this.Select_Machine_State);
            this.Mahine.Controls.Add(this.Input_Machine_Name);
            this.Mahine.Controls.Add(this.Select_Machine_Type);
            this.Mahine.Controls.Add(this.Btn_Create_Machine);
            this.Mahine.Controls.Add(this.Btn_Read_Machine);
            this.Mahine.Location = new System.Drawing.Point(4, 32);
            this.Mahine.Name = "Mahine";
            this.Mahine.Padding = new System.Windows.Forms.Padding(3);
            this.Mahine.Size = new System.Drawing.Size(470, 491);
            this.Mahine.TabIndex = 0;
            this.Mahine.Text = "Machine";
            this.Mahine.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "UpdateMachineId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "MachineState";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "MachineType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "AddMachineName";
            // 
            // Select_Machine_Update
            // 
            this.Select_Machine_Update.FormattingEnabled = true;
            this.Select_Machine_Update.Location = new System.Drawing.Point(26, 378);
            this.Select_Machine_Update.Name = "Select_Machine_Update";
            this.Select_Machine_Update.Size = new System.Drawing.Size(256, 31);
            this.Select_Machine_Update.TabIndex = 9;
            // 
            // Btn_Update_Machine
            // 
            this.Btn_Update_Machine.Location = new System.Drawing.Point(324, 375);
            this.Btn_Update_Machine.Name = "Btn_Update_Machine";
            this.Btn_Update_Machine.Size = new System.Drawing.Size(112, 34);
            this.Btn_Update_Machine.TabIndex = 5;
            this.Btn_Update_Machine.Text = "Update";
            this.Btn_Update_Machine.UseVisualStyleBackColor = true;
            this.Btn_Update_Machine.Click += new System.EventHandler(this.Btn_Update_Machine_Click);
            // 
            // Select_Machine_State
            // 
            this.Select_Machine_State.FormattingEnabled = true;
            this.Select_Machine_State.Location = new System.Drawing.Point(26, 295);
            this.Select_Machine_State.Name = "Select_Machine_State";
            this.Select_Machine_State.Size = new System.Drawing.Size(256, 31);
            this.Select_Machine_State.TabIndex = 4;
            // 
            // Input_Machine_Name
            // 
            this.Input_Machine_Name.Location = new System.Drawing.Point(26, 129);
            this.Input_Machine_Name.Name = "Input_Machine_Name";
            this.Input_Machine_Name.Size = new System.Drawing.Size(256, 30);
            this.Input_Machine_Name.TabIndex = 3;
            // 
            // Select_Machine_Type
            // 
            this.Select_Machine_Type.FormattingEnabled = true;
            this.Select_Machine_Type.Location = new System.Drawing.Point(26, 212);
            this.Select_Machine_Type.Name = "Select_Machine_Type";
            this.Select_Machine_Type.Size = new System.Drawing.Size(256, 31);
            this.Select_Machine_Type.TabIndex = 2;
            // 
            // Btn_Create_Machine
            // 
            this.Btn_Create_Machine.Location = new System.Drawing.Point(324, 289);
            this.Btn_Create_Machine.Name = "Btn_Create_Machine";
            this.Btn_Create_Machine.Size = new System.Drawing.Size(112, 40);
            this.Btn_Create_Machine.TabIndex = 1;
            this.Btn_Create_Machine.Text = "Create";
            this.Btn_Create_Machine.UseVisualStyleBackColor = true;
            this.Btn_Create_Machine.Click += new System.EventHandler(this.Btn_Create_Machine_Click);
            // 
            // Btn_Read_Machine
            // 
            this.Btn_Read_Machine.Location = new System.Drawing.Point(324, 39);
            this.Btn_Read_Machine.Name = "Btn_Read_Machine";
            this.Btn_Read_Machine.Size = new System.Drawing.Size(112, 34);
            this.Btn_Read_Machine.TabIndex = 0;
            this.Btn_Read_Machine.Text = "Read";
            this.Btn_Read_Machine.UseVisualStyleBackColor = true;
            this.Btn_Read_Machine.Click += new System.EventHandler(this.Btn_Read_Machine_Click);
            // 
            // Machine_Data
            // 
            this.Machine_Data.Controls.Add(this.numericUpDown1);
            this.Machine_Data.Controls.Add(this.label9);
            this.Machine_Data.Controls.Add(this.label4);
            this.Machine_Data.Controls.Add(this.Machine_Data_Add);
            this.Machine_Data.Controls.Add(this.Select_Machine_Data);
            this.Machine_Data.Controls.Add(this.Machine_Data_Temperature);
            this.Machine_Data.Location = new System.Drawing.Point(4, 32);
            this.Machine_Data.Name = "Machine_Data";
            this.Machine_Data.Padding = new System.Windows.Forms.Padding(3);
            this.Machine_Data.Size = new System.Drawing.Size(470, 491);
            this.Machine_Data.TabIndex = 1;
            this.Machine_Data.Text = "Machine_Data";
            this.Machine_Data.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(51, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 30);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            305,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "MachineId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperature";
            // 
            // Machine_Data_Add
            // 
            this.Machine_Data_Add.Location = new System.Drawing.Point(324, 57);
            this.Machine_Data_Add.Name = "Machine_Data_Add";
            this.Machine_Data_Add.Size = new System.Drawing.Size(112, 48);
            this.Machine_Data_Add.TabIndex = 6;
            this.Machine_Data_Add.Text = "AddData";
            this.Machine_Data_Add.UseVisualStyleBackColor = true;
            this.Machine_Data_Add.Click += new System.EventHandler(this.Machine_Data_Add_Click);
            // 
            // Select_Machine_Data
            // 
            this.Select_Machine_Data.FormattingEnabled = true;
            this.Select_Machine_Data.Location = new System.Drawing.Point(51, 151);
            this.Select_Machine_Data.Name = "Select_Machine_Data";
            this.Select_Machine_Data.Size = new System.Drawing.Size(227, 31);
            this.Select_Machine_Data.TabIndex = 5;
            // 
            // Machine_Data_Temperature
            // 
            this.Machine_Data_Temperature.Location = new System.Drawing.Point(51, 266);
            this.Machine_Data_Temperature.Name = "Machine_Data_Temperature";
            this.Machine_Data_Temperature.Size = new System.Drawing.Size(227, 30);
            this.Machine_Data_Temperature.TabIndex = 4;
            // 
            // Error_Log
            // 
            this.Error_Log.Controls.Add(this.label3);
            this.Error_Log.Controls.Add(this.label2);
            this.Error_Log.Controls.Add(this.Btn_Add_Error_Log);
            this.Error_Log.Controls.Add(this.Select_Error_Id);
            this.Error_Log.Controls.Add(this.Select_Error_Machine);
            this.Error_Log.Location = new System.Drawing.Point(4, 32);
            this.Error_Log.Name = "Error_Log";
            this.Error_Log.Size = new System.Drawing.Size(470, 491);
            this.Error_Log.TabIndex = 2;
            this.Error_Log.Text = "Error_Log";
            this.Error_Log.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "MachineId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ErrorId";
            // 
            // Btn_Add_Error_Log
            // 
            this.Btn_Add_Error_Log.Location = new System.Drawing.Point(326, 69);
            this.Btn_Add_Error_Log.Name = "Btn_Add_Error_Log";
            this.Btn_Add_Error_Log.Size = new System.Drawing.Size(112, 48);
            this.Btn_Add_Error_Log.TabIndex = 2;
            this.Btn_Add_Error_Log.Text = "AddErrLog";
            this.Btn_Add_Error_Log.UseVisualStyleBackColor = true;
            // 
            // Select_Error_Id
            // 
            this.Select_Error_Id.FormattingEnabled = true;
            this.Select_Error_Id.Location = new System.Drawing.Point(84, 203);
            this.Select_Error_Id.Name = "Select_Error_Id";
            this.Select_Error_Id.Size = new System.Drawing.Size(182, 31);
            this.Select_Error_Id.TabIndex = 1;
            // 
            // Select_Error_Machine
            // 
            this.Select_Error_Machine.FormattingEnabled = true;
            this.Select_Error_Machine.Location = new System.Drawing.Point(84, 109);
            this.Select_Error_Machine.Name = "Select_Error_Machine";
            this.Select_Error_Machine.Size = new System.Drawing.Size(182, 31);
            this.Select_Error_Machine.TabIndex = 0;
            // 
            // Btn_Machine_Refresh
            // 
            this.Btn_Machine_Refresh.Location = new System.Drawing.Point(676, 288);
            this.Btn_Machine_Refresh.Name = "Btn_Machine_Refresh";
            this.Btn_Machine_Refresh.Size = new System.Drawing.Size(101, 73);
            this.Btn_Machine_Refresh.TabIndex = 10;
            this.Btn_Machine_Refresh.Text = "Refresh";
            this.Btn_Machine_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Machine_Refresh.Click += new System.EventHandler(this.Btn_Machine_Refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(658, 314);
            this.dataGridView1.TabIndex = 4;
            // 
            // Btn_LinkHub
            // 
            this.Btn_LinkHub.Location = new System.Drawing.Point(416, 86);
            this.Btn_LinkHub.Name = "Btn_LinkHub";
            this.Btn_LinkHub.Size = new System.Drawing.Size(112, 51);
            this.Btn_LinkHub.TabIndex = 5;
            this.Btn_LinkHub.Text = "LinkHub";
            this.Btn_LinkHub.UseVisualStyleBackColor = true;
            this.Btn_LinkHub.Click += new System.EventHandler(this.Btn_LinkHub_Click);
            // 
            // Btn_StartSqlDependency
            // 
            this.Btn_StartSqlDependency.Location = new System.Drawing.Point(578, 86);
            this.Btn_StartSqlDependency.Name = "Btn_StartSqlDependency";
            this.Btn_StartSqlDependency.Size = new System.Drawing.Size(199, 51);
            this.Btn_StartSqlDependency.TabIndex = 6;
            this.Btn_StartSqlDependency.Text = "StartSqlDependency";
            this.Btn_StartSqlDependency.UseVisualStyleBackColor = true;
            this.Btn_StartSqlDependency.Click += new System.EventHandler(this.Btn_StartSqlDependency_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 127);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Btn_testSendSinalR
            // 
            this.Btn_testSendSinalR.Location = new System.Drawing.Point(416, 13);
            this.Btn_testSendSinalR.Name = "Btn_testSendSinalR";
            this.Btn_testSendSinalR.Size = new System.Drawing.Size(172, 53);
            this.Btn_testSendSinalR.TabIndex = 12;
            this.Btn_testSendSinalR.Text = "TestSend";
            this.Btn_testSendSinalR.UseVisualStyleBackColor = true;
            // 
            // Lbl_hub_connect
            // 
            this.Lbl_hub_connect.AutoSize = true;
            this.Lbl_hub_connect.Location = new System.Drawing.Point(61, 28);
            this.Lbl_hub_connect.Name = "Lbl_hub_connect";
            this.Lbl_hub_connect.Size = new System.Drawing.Size(117, 23);
            this.Lbl_hub_connect.TabIndex = 13;
            this.Lbl_hub_connect.Text = "HubConnect";
            // 
            // Btn_TestSendEach
            // 
            this.Btn_TestSendEach.Location = new System.Drawing.Point(622, 16);
            this.Btn_TestSendEach.Name = "Btn_TestSendEach";
            this.Btn_TestSendEach.Size = new System.Drawing.Size(155, 50);
            this.Btn_TestSendEach.TabIndex = 14;
            this.Btn_TestSendEach.Text = "TestSendEach";
            this.Btn_TestSendEach.UseVisualStyleBackColor = true;
            // 
            // Tmr_TestData
            // 
            this.Tmr_TestData.Interval = 1000;
            this.Tmr_TestData.Tick += new System.EventHandler(this.Tmr_TestData_Tick);
            // 
            // Panel_MachineData
            // 
            this.Panel_MachineData.AutoScroll = true;
            this.Panel_MachineData.BackColor = System.Drawing.SystemColors.Window;
            this.Panel_MachineData.Location = new System.Drawing.Point(27, 579);
            this.Panel_MachineData.Name = "Panel_MachineData";
            this.Panel_MachineData.Size = new System.Drawing.Size(585, 208);
            this.Panel_MachineData.TabIndex = 15;
            // 
            // Btn_MakeScroll
            // 
            this.Btn_MakeScroll.Location = new System.Drawing.Point(644, 727);
            this.Btn_MakeScroll.Name = "Btn_MakeScroll";
            this.Btn_MakeScroll.Size = new System.Drawing.Size(115, 60);
            this.Btn_MakeScroll.TabIndex = 16;
            this.Btn_MakeScroll.Text = "MakeScroll";
            this.Btn_MakeScroll.UseVisualStyleBackColor = true;
            this.Btn_MakeScroll.Click += new System.EventHandler(this.Btn_MakeScroll_Click);
            // 
            // Btn_AutoData
            // 
            this.Btn_AutoData.Location = new System.Drawing.Point(644, 579);
            this.Btn_AutoData.Name = "Btn_AutoData";
            this.Btn_AutoData.Size = new System.Drawing.Size(115, 60);
            this.Btn_AutoData.TabIndex = 17;
            this.Btn_AutoData.Text = "AutoData";
            this.Btn_AutoData.UseVisualStyleBackColor = true;
            this.Btn_AutoData.Click += new System.EventHandler(this.Btn_AutoData_Click);
            // 
            // Btn_HubConnect
            // 
            this.Btn_HubConnect.Location = new System.Drawing.Point(255, 16);
            this.Btn_HubConnect.Name = "Btn_HubConnect";
            this.Btn_HubConnect.Size = new System.Drawing.Size(112, 34);
            this.Btn_HubConnect.TabIndex = 18;
            this.Btn_HubConnect.Text = "ReConnect";
            this.Btn_HubConnect.UseVisualStyleBackColor = true;
            this.Btn_HubConnect.Click += new System.EventHandler(this.Btn_HubConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 881);
            this.Controls.Add(this.Btn_HubConnect);
            this.Controls.Add(this.Btn_AutoData);
            this.Controls.Add(this.Btn_MakeScroll);
            this.Controls.Add(this.Panel_MachineData);
            this.Controls.Add(this.Btn_TestSendEach);
            this.Controls.Add(this.Lbl_hub_connect);
            this.Controls.Add(this.Btn_testSendSinalR);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_Machine_Refresh);
            this.Controls.Add(this.Btn_StartSqlDependency);
            this.Controls.Add(this.Btn_LinkHub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CRUDdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CRUDdata.ResumeLayout(false);
            this.Mahine.ResumeLayout(false);
            this.Mahine.PerformLayout();
            this.Machine_Data.ResumeLayout(false);
            this.Machine_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Error_Log.ResumeLayout(false);
            this.Error_Log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl CRUDdata;
        private System.Windows.Forms.TabPage Mahine;
        private System.Windows.Forms.Button Btn_Read_Machine;
        private System.Windows.Forms.TabPage Machine_Data;
        private System.Windows.Forms.TabPage Error_Log;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Update_Machine;
        private System.Windows.Forms.ComboBox Select_Machine_State;
        private System.Windows.Forms.TextBox Input_Machine_Name;
        private System.Windows.Forms.ComboBox Select_Machine_Type;
        private System.Windows.Forms.Button Btn_Create_Machine;
        private System.Windows.Forms.ComboBox Select_Machine_Update;
        private System.Windows.Forms.Button Btn_Machine_Refresh;
        private System.Windows.Forms.Button Machine_Data_Add;
        private System.Windows.Forms.ComboBox Select_Machine_Data;
        private System.Windows.Forms.TextBox Machine_Data_Temperature;
        private System.Windows.Forms.Button Btn_Add_Error_Log;
        private System.Windows.Forms.ComboBox Select_Error_Id;
        private System.Windows.Forms.ComboBox Select_Error_Machine;
        private System.Windows.Forms.Button Btn_LinkHub;
        private System.Windows.Forms.Button Btn_StartSqlDependency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btn_testSendSinalR;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Lbl_hub_connect;
        private System.Windows.Forms.Button Btn_TestSendEach;
        private System.Windows.Forms.Timer Tmr_TestData;
        private System.Windows.Forms.Panel Panel_MachineData;
        private System.Windows.Forms.Button Btn_MakeScroll;
        private System.Windows.Forms.Button Btn_AutoData;
        private System.Windows.Forms.Button Btn_HubConnect;
    }
}

