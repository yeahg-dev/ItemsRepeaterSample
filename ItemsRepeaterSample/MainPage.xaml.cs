using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Windows.UI.Core;

namespace ItemsRepeaterSample;

public sealed partial class MainPage : Page
{
    private ObservableCollection<string> items = new ObservableCollection<string>{"Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape", "Honeydew", "Kiwi", "Lemon", "Mango", "Nectarine"};
    private int newItemIndex = 0;
    private int oldItemIndex = 0;


    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = items;
        this.items.CollectionChanged += OnCollectinChanged;
    }

    private async void OnCollectinChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
        {
            this.ScrollViewer.ChangeView(null, int.MaxValue, null, true);
        });
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        items.Add("New Item " + newItemIndex.ToString());
        newItemIndex++;
    }

     private void LoadMore_Click(object sender, RoutedEventArgs e)
    {
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        items.Insert(0, "Old Message " + oldItemIndex.ToString());
        oldItemIndex++;
    }
}
