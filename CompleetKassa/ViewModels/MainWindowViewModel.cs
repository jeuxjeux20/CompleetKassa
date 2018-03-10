using CompleetKassa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CompleetKassa.ViewModels
{
    public class MainWindowViewModel
    {
        private List<Category> categories = new List<Category>
        {
            new Category
            {
                Color = Colors.AliceBlue,
                Name = "Socks"
            },
            new Category
            {
                Color = Colors.MediumVioletRed,
                Name = "Milk"
            },
            new Category
            {
                Color = Colors.MediumSlateBlue,
                Name = "Planes"
            }
        };
        public ObservableViewModelCollection<CategoryViewModel, Category> CategoryViewModels { get; }
        public MainWindowViewModel()
        {
            CategoryViewModels = new ObservableViewModelCollection<CategoryViewModel, Category>(categories, c => new CategoryViewModel(c));
        }
    }
}
