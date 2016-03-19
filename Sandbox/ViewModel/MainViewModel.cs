using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Sandbox.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<NavigationItem>();

            MenuItemSelectedCommand = new RelayCommand<NavigationItem>(MenuItemSelectedExecute, t => true);

            Initialize();
        }

        public ObservableCollection<NavigationItem> Items { get; set; }

        private NavigationItem _selectedNavigationItem;

        public NavigationItem SelectedNavigationItem
        {
            get
            {
                return _selectedNavigationItem;
            }
            set { Set(ref _selectedNavigationItem, value); }
        }

        public RelayCommand<NavigationItem> MenuItemSelectedCommand { get; private set; }

        private void MenuItemSelectedExecute(NavigationItem item)
        {
            if(item == null)
                return;

            SelectedNavigationItem = item;
        }

        private void Initialize()
        {
            var campaignsItem = new NavigationItem("Campaigns");
            campaignsItem.Children.Add(new NavigationItem("Campaign"));
            campaignsItem.Children.Add(new NavigationItem("Block Campaign Code"));
            Items.Add(campaignsItem);

            var generalItem = new NavigationItem("General");
            generalItem.Children.Add(new NavigationItem("Users"));
            Items.Add(generalItem);

            var pricesItem = new NavigationItem("Prices");
            pricesItem.Children.Add(new NavigationItem("Price Templates"));
            Items.Add(pricesItem);

            var tpasItem = new NavigationItem("Third Party Arrangements");
            tpasItem.Children.Add(new NavigationItem("Third Party Arrangement"));
            tpasItem.Children.Add(new NavigationItem("Bulk update capacity"));
            Items.Add(tpasItem);

            var productsItem = new NavigationItem("Products");
            productsItem.Children.Add(new NavigationItem("Offer"));
            Items.Add(productsItem);

            //for (int i = 0; i < 6; i++)
            //{
            //    NavigationItem item = new NavigationItem("Item" + i);

            //    for (int j = 0; j < 4; j++)
            //    {
            //        item.Children.Add(new NavigationItem("Child" + j));
            //    }

            //    Items.Add(item);
            //}
        }
    }
}