using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP1_Scheduling_Application
{
    public partial class AddAppointmentForm : Form
    {
        MainForm mainForm = new MainForm();
        public static string myConnectionString = "server=3.227.166.251;database=U05lUM;user=U05lUM;pwd=53688540322";
        MySqlDataReader mdr;
        MySqlConnection Conn = new MySqlConnection(myConnectionString);
        public static int ind = 0;
        DataTable OverlapTable = new DataTable();
       
        public AddAppointmentForm()
        {
            InitializeComponent();
            string query = "SELECT start, end FROM appointment;";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            Conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(OverlapTable);
            Conn.Close();
        }
        public bool IsOverlap(DateTime ST, DateTime ET, DateTime AST, DateTime AET)
        {
            return (ST < AST) ? (ET < AST) ? false : true : (ST > AET) ? false : true; 
        }
        public Boolean CheckForOverlap()
        {

            for (ind = 0; ind < OverlapTable.Rows.Count; ind++)
            {
                String ID = TimeZoneInfo.Local.Id;
                if (ID == "Central Standard Time")
                {
                    DateTime Astart = (DateTime)OverlapTable.Rows[ind]["start"];
                    DateTime Aend = (DateTime)OverlapTable.Rows[ind]["end"];
                    DateTime Start = StartDate.Value.ToLocalTime().AddHours(5);
                    DateTime End = EndTime.Value.ToLocalTime().AddHours(5);

                    if (IsOverlap(Start, End, Astart, Aend))
                    {
                        return true;

                    }
                }
                else
                {
                    if (ID == "Eastern Standard Time")
                    {
                        DateTime Astart = (DateTime)OverlapTable.Rows[ind]["start"];
                        DateTime Aend = (DateTime)OverlapTable.Rows[ind]["end"];
                        DateTime Start = StartDate.Value.ToLocalTime().AddHours(4);
                        DateTime End = EndTime.Value.ToLocalTime().AddHours(4);

                        if (IsOverlap(Start, End, Astart, Aend))
                        {
                            return true;

                        }
                    }
                    else
                    {
                        if (ID == "Mountain Standard Time")
                        {
                            DateTime Astart = (DateTime)OverlapTable.Rows[ind]["start"];
                            DateTime Aend = (DateTime)OverlapTable.Rows[ind]["end"];
                            DateTime Start = StartDate.Value.ToLocalTime().AddHours(6);
                            DateTime End = EndTime.Value.ToLocalTime().AddHours(6);

                            if (IsOverlap(Start, End, Astart, Aend))
                            {
                                return true;

                            }
                        }
                        else
                        {
                            if (ID == "Pacific Standard Time")
                            {
                                DateTime Astart = (DateTime)OverlapTable.Rows[ind]["start"];
                                DateTime Aend = (DateTime)OverlapTable.Rows[ind]["end"];
                                DateTime Start = StartDate.Value.ToLocalTime().AddHours(7);
                                DateTime End = EndTime.Value.ToLocalTime().AddHours(7);

                                if (IsOverlap(Start, End, Astart, Aend))
                                {
                                    return true;

                                }
                            }
                        }
                    }
                }

            }
            return false;
        }
        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            AppointmentIDTxtBox.Text = Convert.ToString(SQL.AppointmentIDList.Count + 1);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            isDayLight();
            SQL sql = new SQL();
            try
            {
                if (StartDate.Value.TimeOfDay < SQL.Open.TimeOfDay || StartDate.Value.TimeOfDay > SQL.Close.TimeOfDay || EndTime.Value.TimeOfDay > SQL.Close.TimeOfDay || EndTime.Value.TimeOfDay < SQL.Open.TimeOfDay)
                {
                    sql.HandleOustideBusinessHours();
                }
                else  
                if (CheckForOverlap())
                {
                    MessageBox.Show("The Appointment you have tried to schedule overlaps a currently scheduled appointment please try again.", "Appointment Overlap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                  
                    int Increment = 1;
                    int ApptID = Convert.ToInt32(AppointmentIDTxtBox.Text);
                    int CustID = Convert.ToInt32(CustomerIDTxtBox.Text);
                    int userID = 1;
                    string nn = "Not Needed";
                    string Title = nn;
                    string description = nn;
                    string location = nn;
                    string contact = nn;
                    string Type = TypeTxtBox.Text;
                    string url = nn;
                    DateTime startDate = StartDate.Value;
                    DateTime EndDate = EndTime.Value;
                    DateTime Now = DateTime.Now.ToLocalTime();
                    DateTime CreateDate = Now;
                    string Test = "Test";
                    string CreatedBy = Test;
                    DateTime LastUpdated = Now;
                    string LastUpdatedBy = Test;
                    SQL.AppointmentIDList.Add(Increment);
                    sql.AddAppointment(new Appointment(ApptID, CustID, userID, Title, description, location, contact, Type, url, startDate,
                        EndDate, CreateDate, CreatedBy, LastUpdated, LastUpdatedBy));

                    mainForm.Show();
                    this.Hide();
                }
            } catch(FormatException)
            {
                MessageBox.Show("A field did not recieve the correct data type", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void isDayLight()
        {
            TimeZoneInfo LocalTZ = TimeZoneInfo.Local;
            DateTime now = DateTime.SpecifyKind(StartDate.Value, DateTimeKind.Utc);

            if (LocalTZ.IsDaylightSavingTime(TimeZoneInfo.ConvertTimeFromUtc(now, TimeZoneInfo.Local)))
            {
                StartDate.Value.AddHours(1);
                EndTime.Value.AddHours(1);
            }
        }
    }
}
