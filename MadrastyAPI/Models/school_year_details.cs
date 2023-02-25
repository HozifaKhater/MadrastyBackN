﻿using  MadrastyAPI.Models;
using  System;
using  System.Collections.Generic;
using  System.ComponentModel.DataAnnotations;
using  System.Data;
using  Microsoft.Data.SqlClient;
using  System.Linq;
using  System.Threading.Tasks;

namespace MadrastyAPI.Models
{
    public class school_year_details
    {
        [Key]

        public int year_details_id { get; set; }
        public int year_data_id { get; set; }
        public string? term_date_from { get; set; }
        public string? term_date_to { get; set; }



        public CLS_connection con_db = new CLS_connection();
        public List<department> listdepartment = new List<department>();

        public int save_in_school_year_details()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [save_in_school_year_details]  
         

 '" + year_data_id + @"',
 '" + term_date_from + @"',
 '" + term_date_to + @"'



            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public DataSet get_school_year_details_with_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_school_year_details_with_id] '" + year_details_id + @"'", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }

        public DataSet get_school_year_details_with_year_data_id()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_school_year_details_with_year_data_id] '" + year_details_id + @"'", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public DataSet get_school_year_details()
        {
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter("Exec [get_school_year_details] ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            //department dep = new department();
            //dep_id = (int)myDS.Tables[0].Rows[0]["dep_id"];
            //dep.dep_name = (string)myDS.Tables[0].Rows[0]["dep_name"];
            //dep.listdepartment.Add(dep);
            con_db.myCN.Close();
            return myDS;

        }
        public int update_school_year_details()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [update_school_year_details]  
           '" + year_details_id + @"',
 '" + year_data_id + @"',
 '" + term_date_from + @"',
 '" + term_date_to + @"'

            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;
        }
        public int delete_from_school_year_details()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_school_year_details]  
            '" + year_details_id + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;

        }

        public int delete_from_school_year_details_with_year_data_id()
        {
            int success_flag = 0;
            con_db.OpenDB_general();
            con_db.myDA = new SqlDataAdapter(@"Exec [delete_from_school_year_details_with_year_data_id]  
            '" + year_details_id + @"'
            ", con_db.myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(con_db.myDA);
            con_db.myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            con_db.myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            con_db.myCN.Close();
            return success_flag;

        }

    }
}
