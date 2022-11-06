namespace DropDownMenus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;

    public class DropDownMenu : ContentControl
    {
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(DDMenuItems), typeof(DropDownMenu), new PropertyMetadata(null));

        public DDMenuItems Items
        {
            get { return (DDMenuItems)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        static DropDownMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DropDownMenu), new FrameworkPropertyMetadata(typeof(DropDownMenu)));
        }
    }
}
