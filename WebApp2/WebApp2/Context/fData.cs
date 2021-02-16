using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp2.Models;

namespace WebApp2.Context
{
    // : DbContext는 상속한다는 의미
    public class fData : DbContext
    {
        //: base(주소): 기본적으로 DB와 연결 = 아래같은 로컬주소뿐만 아니라 MySQL 등 DB서버가 들어감
        public fData() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\MyTable.mdf;Integrated Security=True;Connect Timeout=30") 
        { }

        //List 되돌려주는 함수: 즉, data 조회해서 되돌려주는 함수
        public DbSet<Facility> Facilities { get; set; } //<>에 모델에서 정의한 Class명
        //get - object array
    }
}