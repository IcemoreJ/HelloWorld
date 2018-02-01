using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Model
{
    [Serializable]
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Passwd { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Order { set; get; }
    }
}
