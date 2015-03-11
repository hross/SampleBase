using Sample.Common;
using System.Collections.Generic;

namespace Sample.Web
{
    public class WidgetViewModel
    {
        public List<Widget> Widgets { get; private set; }

        public WidgetViewModel(List<Widget> widgets)
        {
            this.Widgets = widgets;
        }
    }
}