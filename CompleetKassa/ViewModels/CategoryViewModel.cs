using CompleetKassa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CompleetKassa.ViewModels
{
    public class CategoryViewModel : ViewModelBase<Category>
    {
        public override Category Model { get; set; }
        public CategoryViewModel(Category category)
        {
            this.Model = category;
        }
        public CategoryViewModel()
        {
            var rand = new Random();
            Model = new Category
            {
                Name = "Test",
                Color = Color.FromRgb((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256))
            };
        }
        public Color Color { get => Model.Color; set { Model.Color = value; OnPropertyChanged(); } }
        public string Name { get => Model.Name; set { Model.Name = value; OnPropertyChanged(); } }
    }
}
