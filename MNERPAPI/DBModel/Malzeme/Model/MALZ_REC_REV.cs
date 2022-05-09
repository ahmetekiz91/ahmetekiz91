using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_REC_REV : BaseEntity {

public int? REV_ID{get;set;}
public int? RECID{get;set;}
public int? MALZID{get;set;}
public DateTime? CDATE{get;set;}
public DateTime? TARIH{get;set;}
public int? CUSRID{get;set;}
public string REVNO {get;set;}
public decimal? URMIKTAR { get;set;}
public int? BRM{get;set;}
public decimal? FIRE_MIKTAR { get;set;}
public int? FIRE_BRM{get;set;}
public int? ACTIVE{get;set;}

             
        }
}
