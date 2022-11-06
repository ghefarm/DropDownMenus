namespace DropDownMenus
{
    using System.Windows.Controls;
    using System.Windows.Input;

    public class DDMenuItem
    {
        public Image? Icon { get; set; }
        public string? Title { get; set; }
        public ICommand? Command { get; set; }

        public DDMenuItems? SubItems { get; set; }
        
        public DDMenuItem()
        {
            
        }

        public DDMenuItem( Image icon, string title, ICommand command)
        {
            Icon = icon;
            Title = title;
            Command = command;
        }
    }
}
