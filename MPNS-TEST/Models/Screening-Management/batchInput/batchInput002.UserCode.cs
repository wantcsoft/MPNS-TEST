﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MPNS_TEST.Models.Screening_Management.batchInput
{
    public partial class batchInput002
    {
    	
    	private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SM51UF2\\MOZZIE;Initial Catalog=Mozzie;Integrated Security=True");
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void createTable()
        {
			string querySql = "select * From sys.objects where name='Batchadding';";
        	
//        	string connUrl = "Data Source=DESKTOP-SM51UF2\\MOZZIE;Initial Catalog=Mozzie;Integrated Security=True";       //连接数据库所需要的字符串，即为刚才复制的连接字符串
//            SqlConnection conn = new SqlConnection(connUrl);      //创建连接对象
			
			string createSql = "create table Batchadding(IDCard varchar(50) ,SocialNo varchar(50) ,PatientID nchar(10),FirstName nchar(10),BirthDate datetime,CheckNo nchar(10),Diabetes nchar(10),SmokeHistory nchar(10),DownsHistory nchar(10),IVF nchar(10),GravidNumber nchar(10),BornNumber nchar(10),FetalNumber nchar(10),RegisterDate datetime,SolutionID nchar(10),BarCode nchar(10),SampleID nchar(10),TestDate datetime,SamplingDate datetime,Weight nchar(10),GestationWeek nchar(10),GestationDay nchar(10),GestationType nchar(10),OriginPlace nchar(10),Sdoctor nchar(10),SampleRemark nchar(10),LMPDate datetime,BPDDate datetime,BPDValue nchar(10),CRLDate datetime,CRLValue nchar(10),IVFDate datetime,OPUDate datetime,RaceType nchar(10),ExtendType nchar(10),SolutionTypeID nchar(10),Period nchar(10));";  //创建查询语句，根据个人所需数据库做相应修改
            conn.Open();   //打开数据库连接
//            查看该表是否存在
            SqlCommand queryComm = new SqlCommand(querySql, conn);
            SqlDataReader reader = queryComm.ExecuteReader();
         
//            如果存在则删除该表
            if (reader.Read())
		    {
            	reader.Close();
				string deleteSql = "drop table Batchadding;";
				SqlCommand deleteComm = new SqlCommand(deleteSql, conn);
				deleteComm.ExecuteNonQuery();
            }
            reader.Close();
//            执行创建表语句
			SqlCommand createComm = new SqlCommand(createSql, conn);
			createComm.ExecuteNonQuery();
			
			conn.Close();
        }
        
        public void insertData()
        {
        	string insertSql = "INSERT INTO Batchadding VALUES ('310105198609292856','310105198609292856','00001','张孕妇','1999-01-01','00001','0','0','0','0','1','0','1','2018-10-11','3','00001','00001','2018-10-11','2018-10-11','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','2','0'),('310105198609292856','310105198609292856','00002','刘孕妇','1999-01-01','00002','0','0','0','0','1','0','1','2018-10-12','4','00002','00002','2018-10-12','2018-10-12','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','2','0'),('310105198609292856','310105198609292856','00003','赵孕妇','1999-01-01','00003','0','0','0','0','1','0','1','2018-10-12','10','00003','00003','2018-10-12','2018-10-12','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','1','1'),('310105198609292856','310105198609292856','00004','钱孕妇','1999-01-01','00004','0','0','0','0','1','0','1','2018-10-12','13','00004','00004','2018-10-12','2018-10-12','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','1','1'),('310105198609292856','310105198609292856','00005','孙孕妇','1999-01-01','00005','0','0','0','0','1','0','1','2018-10-12','16','00005','00005','2018-10-12','2018-10-12','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','3','0'),('310105198609292856','310105198609292856','00006','李孕妇','1999-01-01','00006','0','0','0','0','1','0','1','2018-10-12','17','00006','00006','2018-10-12','2018-10-12','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','3','0'),('310105198609292856','310105198609292856','00007','周孕妇','1999-01-01','00007','0','0','0','0','1','0','1','2018-10-12','20','00007','00007','2018-10-12','2018-10-12','55','15','0','5','新华医院','李医生','备注','','','','','','','','1','0','3','0')";
			
			conn.Open();
			SqlCommand insertComm = new SqlCommand(insertSql, conn);
			insertComm.ExecuteNonQuery();	

			conn.Close();			
									
        }

    }
}
