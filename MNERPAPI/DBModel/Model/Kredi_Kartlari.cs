using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Kredi_Kartlari : BaseEntity {

public int? Kart_ID{get;set;}
public string Kartno {get;set;}
public string Kart_Sahibi {get;set;}
public string Banka_Adi {get;set;}
public int? Banka_ID{get;set;}
public string P1 {get;set;}
public string P2 {get;set;}
public string P3 {get;set;}
public string P4 {get;set;}
public string P5 {get;set;}

             
        }
}
