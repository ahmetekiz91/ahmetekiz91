using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sevkiyatlar : BaseEntity {

public int? Sevk_ID{get;set;}
public DateTime? CDate{get;set;}
public string GUID1 {get;set;}
public string GUID2 {get;set;}
public int? Sevk_Fis_ID{get;set;}
public DateTime? Sevk_Tarihi{get;set;}

             
        }
}
