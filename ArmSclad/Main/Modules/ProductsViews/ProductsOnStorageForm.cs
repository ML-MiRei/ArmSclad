using ArmSclad.Domain.UseCases.Products.Queries.GetProductsByStorage;
using MediatR;

namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    public partial class ProductsOnStorageForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 15;
        private int _storageId;


        public ProductsOnStorageForm(IMediator mediator, int storageId)
        {
            InitializeComponent();

            _mediator = mediator;
            _storageId = storageId;

            LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            if (_pageNumber > 0)
            {
                _pageNumber--;
                LoadData();
            }
        }

        private void UpdatePageButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
        }

        private void LoadData()
        {
            var products = _mediator.Send(new GetProductsByStorageQuery
            {
                From = _pageNumber * _productsOnPage,
                To = _productsOnPage,
                StorageId = _storageId
            }).Result;

            foreach (var product in products)
            {
                ProductsList.Items.Add(new ListViewItem(new string[] {
                    product.Id + "",
                    product.Name,
                    product.Description,
                    product.NumberPackages + "",
                    product.AllPrice + "",
                    product.AllSpaceOccupied + ""
                }));
            }
        }

    }
}
