using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Calisma_Saati : BaseEntity {

public int? Calis_Saati_Id{get;set;}
public int? Calis_Saati{get;set;}
public DateTime? CDate{get;set;}
public int? Gun{get;set;}
public string Per_ID {get;set;}
public decimal? Maas { get;set;}
public string Aylik_Calisma_Saati {get;set;}

             
        }
}
