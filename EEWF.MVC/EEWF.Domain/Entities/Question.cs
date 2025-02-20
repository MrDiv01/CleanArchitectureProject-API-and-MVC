using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.Entities
{
    public class Question:BaseEntity
    {
        public string Query { get; set; }
        public double Point { get; set; }
        public ICollection<Variant> Variants { get; set; }
        //Level
        public int LevelId { get; set; }
        public Level Level { get; set; }
    }
}
