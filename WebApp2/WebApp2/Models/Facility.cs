using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    //DB설계에 필요한 변수들 설정해줄 클래스를 선언함(데이터 구조-필드 골격 만듦)
    public class Facility
    {
        [Key]
        public int fid { get; set; }
        public string fName { get; set; }
        public string fModel { get; set; }
        public string fDesc { get; set; }
        public int fPrice { get; set; }
    }
}