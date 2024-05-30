using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Products.Queries.GetProducts;
using MediatR;

namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    public partial class SelectProductForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 17;
        private List<ProductEntity> _products;
        private ProductEntity _selectedProduct;
        public ProductEntity SelectedProduct => _selectedProduct;



        public SelectProductForm(IMediator mediator)
        {
            InitializeComponent();

            _mediator = mediator;
            LoadData();
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
            DialogResult = DialogResult.Cancel;
        }


        private void LoadData()
        {
            ProductsList.Items.Clear();


            _products = _mediator.Send(new GetProductsQuery
            {
                From = _pageNumber * _productsOnPage,
                To = _productsOnPage,
            }).Result;

            foreach (var product in _products)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    product.Id + "",
                    product.Name,
                    product.Description
                });

                if (product.Id == _selectedProduct?.Id)
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

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsList.SelectedItems.Count > 0)
            {
                _selectedProduct = _products[ProductsList.SelectedItems[0].Index];
            }
        }
    }
}
