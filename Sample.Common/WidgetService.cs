using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Common.Framework;
using System.Linq.Expressions;

namespace Sample.Common
{
    public class WidgetService : ServiceBase<Widget, long>
    {
        public WidgetService(DatabaseContext context) : base(context) { }

        protected override Expression<Func<Widget, bool>> DefaultSelector(long id)
        {
            return item => item.Id == id;
        }
    }
}
