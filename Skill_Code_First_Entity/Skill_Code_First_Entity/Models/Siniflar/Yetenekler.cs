using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_Code_First_Entity.Models.Siniflar
{
    public class Yetenekler
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public byte Seviye { get; set; }
    }
}