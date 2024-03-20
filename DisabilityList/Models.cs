﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisabilityList
{
    public class Code
    {
        public string code { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return $"{code} - {name}";
        }
    }
    public class Simple
    {
        public long id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    public class Hospital : Simple
    {
        public string govregnum { get; set; }
        public string address { get; set; }
    }
    public class Doctor : Simple
    {
        public long idhospital { get; set; }
        public long idspeciality { get; set; }
    }
    public class DoctorView 
    {
        public long id { get; set; }
        public string doct_name { get; set; }
        public long idhospital { get; set; }
        public string speciality { get; set; }  
        public override string ToString()
        {
            return doct_name;
        }
    }
    public class Patient : Simple
    {
        public DateTime birth_date { get; set; }
        public string inn { get; set; }
        public string snils { get; set; }
        public string passport { get; set; }
    }
    public class DisabilityList
    {
        public long id { get; set; }
        public DateTime delivery_date { get; set; }
        public string reason_code { get; set; }
        public string add_reason_code { get; set; }
        public long idpatient { get; set; }
        public long idhospital { get; set; }
        public string regnum { get; set; }
        public string code_sub { get; set; }
        public double time_service { get; set; }
        public double salary { get; set; }
    }
    public class DisabilityListWithContent : DisabilityList
    {
        public byte[] list_content { get; set; }
        public string content_type { get; set; }
    }
    public class DisabilityListView
    {
        public long id { get; set; }
        public DateTime delivery_date { get; set; } 
        public DateTime datefrom { get; set; }
        public DateTime dateto { get; set; }
        public string patient { get; set; }
        public string hospital { get; set; }

    }
    public class FreeRecord
    {
        public long idlist { get; set; }
        public string relative_code { get; set; }
        public long idpatient { get; set; }
        public DateTime datefrom { get; set; }
        public DateTime dateto { get; set; }
        public long iddoctor { get; set; }
    }
    public class FreeRecordView : FreeRecord 
    { 
        public string patient { get; set; }
        public string doct_name { get; set; }
        public long idhospital { get; set; }
        public string speciality { get; set; }
    }
}