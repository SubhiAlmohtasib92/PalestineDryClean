using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PalestineDryClean.Models;
using System.Collections.ObjectModel;

namespace PalestineDryClean.ViewModels
{
    public partial class CustomOrdersPageViewModel :ObservableObject
    {
        public ObservableCollection<CustomOrderItem> CustomOrderList { get; set; } = new();

        public Task SetCustomOrderList()
        {
            CustomOrderList.Clear();
            CustomOrderList.Add(new CustomOrderItem{
               Name =  "ملابس رجال" ,
               ImageName = "menclothes.jpg"
            }
            );
            CustomOrderList.Add(new CustomOrderItem
            {
                Name = "ملابس نساء",
                ImageName = "womenclothes.jpg"
            }
            );
            CustomOrderList.Add(new CustomOrderItem
            {
                Name = "ملابس اطفال",
                ImageName = "childrenclothes.jpg"
            }
            );

            CustomOrderList.Add(new CustomOrderItem
            {
                Name = "مفروشات",
                ImageName = "furniture.jpg"
            }
            );

            CustomOrderList.Add(new CustomOrderItem
            {
                Name = "حرامات",
                ImageName = "balnkets.jpg"
            }
            );

            CustomOrderList.Add(new CustomOrderItem
            {
                Name = "برادي",
                ImageName = "curtains.jpg"
            }
            );

            CustomOrderList.Add(new CustomOrderItem
            {
                Name = "اخرى",
                ImageName = "others.jpg"
            }
            );
            //CustomOrderList.Add("");
            //CustomOrderList.Add("ملابس أطفال");
            //CustomOrderList.Add("مفروشات");
            //CustomOrderList.Add("مفروشات");
            //CustomOrderList.Add("اخرى");

            return Task.CompletedTask;
        }
    }
}
