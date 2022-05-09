using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class HIZMETLER : BaseEntity {

public int? HZMT_ID{get;set;}
public string HZMT_KODU {get;set;}
public DateTime? CDATE{get;set;}
public string ACIKLAMA {get;set;}
public int? ACTIVE{get;set;}
public string SPECODE {get;set;}
public string SPECODE2 {get;set;}
public string SPECODE3 {get;set;}
public string SPECODE4 {get;set;}
public decimal? KDV { get;set;}
public decimal? OTV { get;set;}
public string GTIP {get;set;}

             
        }
}
