using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class Login : System.Web.UI.Page
    {
        //DB 연결
        SqlConnection sConn = new SqlConnection(); //sql 사용하기 위한 class
        SqlCommand sCmd = new SqlCommand();
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\MyTable.mdf;Integrated Security=True;Connect Timeout=30";

        //RunDBdata(string field_name,string table_name)
        public string GetDBdata(string table, string field, string kField, string kValue)
        {
            sCmd.CommandText = $"Select {field} from {table} where {kField}='{kValue}'";
            if ((string)sCmd.ExecuteScalar() != null)
                return (string)sCmd.ExecuteScalar(); //무조건 첫번째 레코드의 값
            else return "";
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
        string sID = "";
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            sID = tbUserName.Text;
            string sPwd = tbPassword.Text;

            //DB에서 사용자명 및 암호 조회해서 OK면 진행, 아니면 회원가입 메시지
            string str = GetDBdata("mtLogin", "PWD", "ID", sID).Trim();
            //tbSql.Text += $"MyConfig test [{textBox1.Text}]: '{str.Trim()}'\r\n"; //trim -> 공백 제거

            if (sPwd == str && str != "")
            {
                lblCong.Text = $"{sID}님. 반갑습니다.";
                btnMove.Visible = true;
            }
            else lblCong.Text = "회원가입 정보가 없습니다. 먼저 가입해 주세요.";
        }

    }
}