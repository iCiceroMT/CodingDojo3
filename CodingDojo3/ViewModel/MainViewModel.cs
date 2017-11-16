using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace CodingDojo3.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<ItemVM> Data { get; set; }

        public MainViewModel()
        {
            Data = new ObservableCollection<ItemVM>();
           // Data.Add(new ItemVM());
        }
    }
}