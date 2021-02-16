using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class Join : System.Web.UI.Page
    {
        //DB 연결
        SqlConnection sConn = new SqlConnection(); //sql 사용하기 위한 class
        SqlCommand sCmd = new SqlCommand();
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\MyTable.mdf;Integrated Security=True;Connect Timeout=30";

        //RunDBdata(string field_name,string table_name)
        public string GetDBdata(string table, string field, string kField, string kValue)
        {
            sCmd.CommandText = $"Select {field} from {table} where {kField}='{kValue}'";
            if (sCmd.ExecuteScalar() == null) return "";
            else return (string)sCmd.ExecuteScalar(); //무조건 첫번째 레코드의 값
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                sConn.ConnectionString = connString;
                sConn.Open(); //DB 열기(폼 닫을 때 종료한다는 코드 꼭 넣어줘야 함)
                sCmd.Connection = sConn; //sConn은 스키마 정보를 가지고 있음

            }
            catch (Exception e1)
            { }
        }

        protected void btnID_Click(object sender, EventArgs e)
        {
            string sID = tbID.Text;

            //DB에서 사용자명 및 암호 조회해서 OK면 진행, 아니면 회원가입 메시지
            string str = "";
            str = GetDBdata("mtLogin", "ID", "ID", sID).Trim();

            if (sID != str) lblIDcheck.Text = "가입 가능한 아이디 입니다.";
            else lblIDcheck.Text = "이미 사용중인 아이디 입니다.";
        }

        protected void btnJoin_Click(object sender, EventArgs e)
        {
            string sID = tbID.Text, sName = tbName.Text, sPhone = tbPhone.Text, 
                sPWD = tbPWD.Text, sPWD2 = tbPWD2.Text, sMail = tbMail.Text;
            if (sPWD != sPWD2) lblPWDcheck.Text = "입력하신 암호가 일치하지 않습니다.";
            else lblPWDcheck.Text = "";
            if (tbPhone.Text.Contains("-")) lblPhoneCheck2.Text = "- 를 제외하고 입력해주세요.";
            else lblPhoneCheck2.Text = "";
            if (lblPWDcheck.Text == "" && lblPhoneCheck2.Text == "")
            {
                if (sID != "" && sName != "" && sPhone != "" && sPWD != "" && sPWD2 != "")
                {
                    string sInsert = $"insert into mtLogin values ('{sID}','{sName}','{sPWD}','{sPhone}','{sMail}')";
                    sCmd.CommandText = sInsert;
                    sCmd.ExecuteNonQuery();
                    tbID.Text = "";
                    tbName.Text = "";                    
                    tbPhone.Text = "";
                    tbMail.Text = "";
                    lblJoin.Text = "가입이 완료되었습니다. 로그인해주세요.";                    
                }
                else lblJoin.Text = "메일주소를 제외한 모든 정보는 반드시 기입해주세요.";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbPWD.Text = "";
            tbPWD2.Text = "";
            tbPhone.Text = "";
            tbMail.Text = "";
        }
    }
}