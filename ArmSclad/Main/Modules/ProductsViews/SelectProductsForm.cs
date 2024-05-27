using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Products.Queries.GetProducts;
using ArmSclad.Domain.UseCases.Products.Queries.GetProductsByStorage;
using MediatR;

namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    public partial class SelectProductsForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 17;
        private int? _storageId;
        private List<ProductEntity> _products;
        private List<ProductEntity> _selectedProducts;
        private List<ProductEntity> _selectedProductsOnPage = new List<ProductEntity>();

        public SelectProductsForm(IMediator mediator, ref List<ProductEntity> selectedProducts, int? storageId = null)
        {
            InitializeComponent();

            _mediator = mediator;
            _selectedProducts = selectedProducts;
            _storageId = storageId;

            ProductsList.SelectedIndexChanged += ProductsList_SelectedIndexChanged;

            LoadData();
        }

        private void ProductsList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            foreach (ListViewItem item in ProductsList.SelectedItems)
            {
                if (!_selectedProductsOnPage.Contains(_products[item.Index]))
                    _selectedProductsOnPage.Add(_products[item.Index]);
            }
            foreach (var item in _selectedProductsOnPage)
            {
                if (!ProductsList.SelectedItems.Contains(ProductsList.Items[_products.IndexOf(item)]))
                    _selectedProductsOnPage.Remove(item);
            }
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber--;
            LoadData();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SaveData()
        {
            foreach (var item in _selectedProductsOnPage)
            {
                if (!_selectedProducts.Contains(item))
                    _selectedProducts.Add(item);
            }
            foreach (var item in _selectedProducts)
            {
                if (!_selectedProductsOnPage.Contains(item))
                    _selectedProducts.Remove(item);
            }
        }

        private void LoadData()
        {
            if (_storageId == null)
            {
                _products = _mediator.Send(new GetProductsQuery
                {
                    From = _pageNumber * _productsOnPage,
                    To = _productsOnPage
                }).Result;
            }
            else
            {
                _products = _mediator.Send(new GetProductsByStorageQuery
                {
                    From = _pageNumber * _productsOnPage,
                    To = _productsOnPage,
                    StorageId = _storageId.Value
                }).Result;
            }

            SaveData();

            foreach (var product in _products)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    product.Id + "",
                    product.Name,
                    product.Description,
                    product.NumberPiecesInPackage + "",
                    product.Price + "",
                    product.SpaceOccupied + "",
                    product.PricePackage + ""
                });


                if (_selectedProducts.Select(p => p.Id).Contains(product.Id))
                {
                    item.Selected = true;
                }

                ProductsList.Items.Add(item);
            }
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
