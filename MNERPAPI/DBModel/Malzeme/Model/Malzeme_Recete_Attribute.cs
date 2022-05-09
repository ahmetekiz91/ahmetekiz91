using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malzeme_Recete_Attribute : BaseEntity {

public int? Malz_Recete_Att_ID{get;set;}
public int? Malzeme_Recete_ID{get;set;}
public int? Param_ID{get;set;}
public string Att_Name {get;set;}
public string Tipi {get;set;}
public string Value {get;set;}
public string Formul {get;set;}

             
        }
}
