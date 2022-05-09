using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malz_Images : BaseEntity {

public int? Malz_Img_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Malz_Id{get;set;}
public string FPath {get;set;}

             
        }
}
