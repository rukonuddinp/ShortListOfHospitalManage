﻿namespace ShortListOfHospitalManagement.Models
{
    public class NCD_Detail
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int NCDID { get; set; }
        public NCD NCD { get; set; }
    }
}
