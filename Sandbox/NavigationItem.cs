using System.Collections.ObjectModel;

namespace Sandbox
{
    public class NavigationItem
    {
        public NavigationItem(string title)
        {
            Children = new ObservableCollection<NavigationItem>();
            Title = title;
        }

        public string Title { get; set; }

        public ObservableCollection<NavigationItem> Children { get; } 
    }
}
