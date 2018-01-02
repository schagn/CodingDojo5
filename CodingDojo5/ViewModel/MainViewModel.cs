using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo5.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemVM> Items { get; set; }

        public ObservableCollection<ItemVM> ShoppingCart { get; set; }

        private ItemVM currentItem;

        private ItemVM selectedItem;

        public ItemVM CurrentItem {
            get { return currentItem; }
            set { currentItem = value; RaisePropertyChanged(); }
            }

        public ItemVM SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            Items = new ObservableCollection<ItemVM>();
            ShoppingCart = new ObservableCollection<ItemVM>();

            GenerateDemoData();
        }


        public void AddItemToCart()
        {
            ShoppingCart.Add(CurrentItem);
        }

        private void GenerateDemoData()
        {
            Items.Add(new ItemVM("MY Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "-"));
            Items.Add(new ItemVM("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "-"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
        }
    }
}