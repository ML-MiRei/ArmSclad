using ArmSclad.Core.Entities;

namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews.DataSourseModel
{
    public class SelectedProductModel
    {
        public ProductEntity Product { get; set; }
        public string Name => Product.Name;
        public string ID => Product.Id.ToString();
        public string NumberPackagesOnStorage => Product.NumberPackagesOnStorage.ToString();
        public float Amount { get; set; }
    }
}
