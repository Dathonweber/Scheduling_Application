﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP1_Scheduling_Application
{
    public class Appointment
    {

       
        public int AppointmentID { get; set; }

        public int CustomerID { get; set; }

        public int UserID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Contact { get; set; }

        public string Type { get; set; }

        public string URL { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; }

        public Appointment(int appointmentID, int customerID, int userID, string title, string description, string location, string contact, 
            string type, string url, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            AppointmentID = appointmentID;
            CustomerID = customerID;
            UserID = userID;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            URL = url;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }

        public Appointment(int ApptID, int customerID, string type, DateTime start, DateTime end, DateTime lastUpdate, string lastUpdateBy )
        {
            AppointmentID = ApptID;
            CustomerID = customerID;
            Type = type;
            Start = start;
            End = end;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdateBy;
        }

    }
}
