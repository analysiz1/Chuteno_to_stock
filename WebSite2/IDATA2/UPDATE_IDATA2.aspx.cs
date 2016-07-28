using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IDATA2_UPDATE_IDATA2 : System.Web.UI.Page
{
    string CN = ConfigurationManager.ConnectionStrings["GF_ConString"].ConnectionString;
    SqlConnection objConn;
    SqlCommand cmd;
    SqlCommand cmdupdate;
    SqlDataReader dr;
    string SQLUPDATE;
    public void Page_Load(object sender, EventArgs e)
    {
        objConn = new SqlConnection(CN);
       
    }
    public void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        objConn.Open();

       
            string sql = "SELECT Record_No ,DOCUMENT,CHUTE_NO,BATCH_NO,RTRIM(COMPANY) as COMPANY FROM INPUT_CHUTENO ORDER BY COMPANY,DOCUMENT";
        
            cmd = new SqlCommand(sql, objConn);
         
            dr = cmd.ExecuteReader();
            //int recNo = 1;
            int batch = 1;
            int sorter = 150 ;
            string com = "PKC"; //แก้ไขก่อน Run ให้เป็น ชื่อสาขาลำดับบนสุด
            if (dr.HasRows)
            {
                int ChuteNo = 2;
               
                while (dr.Read())
                {
                   
                    string company = dr["COMPANY"].ToString();                 
                                          
                        if (ChuteNo <= sorter && com == company)
                        {                           
                            SQLUPDATE = "UPDATE INPUT_CHUTENO";
                            SQLUPDATE += " SET CHUTE_NO = '" + ChuteNo.ToString() + "', BATCH_NO = '" + batch.ToString() + "' ";
                            //SQLUPDATE += " WHERE  Record_No='" + recNo + "' ";
                            SQLUPDATE += " WHERE  Record_No='" + dr["Record_No"].ToString() + "' ";

                            ChuteNo++; // เพิ่ม Chute_No
                        }
                        else
                        {
                            com = company;
                            batch++; //เพิ่ม Batch_No
                            ChuteNo = 2;
                            SQLUPDATE = "UPDATE INPUT_CHUTENO";
                            SQLUPDATE += " SET CHUTE_NO = '" + ChuteNo.ToString() + "', BATCH_NO = '" + batch.ToString() + "' ";
                            //SQLUPDATE += " WHERE  Record_No='" + recNo.ToString() + "' ";
                            SQLUPDATE += " WHERE  Record_No='" + dr["Record_No"].ToString() + "' ";
                            ChuteNo++; // เพิ่ม Chute_No
                        }


                        Response.Write(SQLUPDATE.ToString());
                        //Response.Write("  " + company.ToString() +"  "+ com.ToString());                         
                        Response.Write("<BR>");                      
                        //recNo++;                 
                }

            }

           // Response.Write(SQLUPDATE.ToString());
       // cmdupdate = new SqlCommand(SQLUPDATE, objConn);
        //cmdupdate.ExecuteNonQuery();

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}