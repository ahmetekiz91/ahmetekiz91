using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_FIYAT : BaseEntity {

public int? REFID{get;set;}
public int? MALZ_ID{get;set;}
public int? BRM_ID{get;set;}
public DateTime? CDATE{get;set;}
public int? CUSR_ID{get;set;}
public decimal? MIKTAR { get;set;}
public decimal? SATFIYAT { get;set;}
public decimal? ALISFIY { get;set;}
public decimal? ISKONTO1 { get;set;}
public int? ACTIVE{get;set;}
public decimal? ZAM { get;set;}
public decimal? KDV { get;set;}
public decimal? KDVORAN { get;set;}
public decimal? ISKONTO2 { get;set;}
public decimal? ISKONTO3 { get;set;}
public int? DOV_ID{get;set;}

             
        }
}
