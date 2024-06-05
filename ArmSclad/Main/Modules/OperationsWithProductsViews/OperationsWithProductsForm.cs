using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByProduct;
using ArmSclad.UI.Main.Modules.ProductsViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OperationsWithProductsViews
{
    public partial class OperationsWithProductsForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 20;
        private List<OperationWithProductEntity> _products;
        private static ProductEntity _selectedProduct;

        public OperationsWithProductsForm(IMediator mediator)
        {
            InitializeComponent();
            TopLevel = false;

            _mediator = mediator;
        }

        private void LoadData()
        {
            ProductsList.Items.Clear();

            _products = _mediator.Send(new GetOperationsByProductQuery
            {
                ProductId = _selectedProduct.Id,
                From = _pageNumber * _productsOnPage,
                To = _productsOnPage,
            }).Result;

            foreach (var product in _products)
            {
                ProductsList.Items.Add(new ListViewItem(new string[] {
                    product.Id + "",
                    product.Name,
                    product.Description,
                    product.OperationType.ToString(),
                    product.StringTarget,
                    product.TargetId.ToString(),
                    product.Amount.ToString()
                }));
            }
        }


        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
                return;
            
            _pageNumber++;
            LoadData();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
                return;
            if (_pageNumber > 0)
            {
                _pageNumber--;
                LoadData();
            }
        }

        private void UpdatePageButton_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
                return;
            LoadData();
        }

        private void SelectProduct_Click(object sender, EventArgs e)
        {
            SelectProductForm selectProductForm = new SelectProductForm(_mediator);
            var res = selectProductForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                _selectedProduct = selectProductForm.SelectedProduct;
                NameProduct.Text = _selectedProduct.Name;
                LoadData();
            }
        }
    }
}
