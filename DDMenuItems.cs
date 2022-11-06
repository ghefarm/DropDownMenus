namespace DropDownMenus
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DDMenuItems : ObservableCollection<DDMenuItem>
    {
        public DDMenuItems()
        {

        }

        public DDMenuItems(IEnumerable<DDMenuItem> items)
        :base(items)
        {

        }
    }
}
