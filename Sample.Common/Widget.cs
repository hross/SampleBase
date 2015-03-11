using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Common
{
    public class Widget
    {
        public Widget()
        {
            this.CreatedOnUTC = DateTime.UtcNow;
        }

        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public string Text { get; set; }

        public DateTime CreatedOnUTC { get; set; }
    }
}
