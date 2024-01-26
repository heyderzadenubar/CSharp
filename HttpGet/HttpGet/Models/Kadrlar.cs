using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpGet.Models
{
    public class Kadrlar
    {
        public virtual int Id { get; set; }

        public virtual string Ad { get; set; }

        public virtual string Soyad { get; set; }

        public virtual string VesiqeNo { get; set; }

        public virtual DateTime DogumTarixi { get; set; }

    }
}