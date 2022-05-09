using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class FISLER : BaseEntity
    {


        public int? FIS_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CUSR_ID { get; set; }
        public DateTime? FISTARIHI { get; set; }
        public int? CARIID { get; set; }
        public int? FISTURID { get; set; }
        public int? TEKREFID { get; set; }
        public string GUID1 { get; set; }
        public string GUID2 { get; set; }
        public int? DOVIZID { get; set; }
        public string FICHENO { get; set; }
        public int? ISTID { get; set; }
        public string ACIKLAMA { get; set; }
        public int? FISREFID { get; set; }
        public DateTime? VADETARIHI { get; set; }
        public int? KASAID { get; set; }
        public decimal? TOPLAM { get; set; }
        public string BORDRONO { get; set; }
        public DateTime? BORDTAR { get; set; }
        public string STATUS { get; set; }
        public DateTime? UDATE { get; set; }
        public int? UUSR_ID { get; set; }
        public string CARIMUHKODU { get; set; }
        public string TRANSACTION_ID { get; set; }

        public static implicit operator FISLER(List<FISLER> v)
        {
            throw new NotImplementedException();
        }
    }
}
