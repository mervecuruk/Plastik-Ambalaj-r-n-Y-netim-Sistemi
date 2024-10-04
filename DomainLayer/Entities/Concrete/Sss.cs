using DomainLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.Concrete
{
    public class Sss : IEntity
    {
        public int Id { get; set; }

        public string AskTitle { get; set; }

        public string Content { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool IsActive { get; set; } = true;

        public bool AdminAccept { get; set; } = false;

    }
}
