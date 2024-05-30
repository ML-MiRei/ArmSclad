using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Products.Queries.GetProducts;
using ArmSclad.Domain.UseCases.Products.Queries.GetProductsByStorage;
using ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews;
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
        private Dictionary<ProductEntity, float> _selectedProducts;
        private bool _indicatorDifference;

        public SelectProductsForm(IMediator mediator, ref Dictionary<ProductEntity, float> selectedProducts, int? storageId = null, bool indicatorDifference = true)
        {
            InitializeComponent();

            _mediator = mediator;
            _selectedProducts = selectedProducts;
            _storageId = storageId;
            _indicatorDifference = indicatorDifference;

            SelectMode.CheckedChanged += SelectMode_CheckedChanged;

            LoadData();
        }

        private void SelectMode_CheckedChanged(object? sender, EventArgs e)
        {
            ProductsList.SelectedItems.Clear();

            if (SelectMode.Checked)
            {
                ProductsList.SelectedIndexChanged += ProductsList_SelectedIndexChanged;
            }
            else
            {
                ProductsList.SelectedIndexChanged -= ProductsList_SelectedIndexChanged;
            }
        }

        private void ProductsList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (ProductsList.SelectedItems.Count != 0)
            {
                InputAmount inputAmount = new InputAmount();

                if (inputAmount.ShowDialog() == DialogResult.OK)
                {
                    if (inputAmount.Amount == 0)
                    {
                        ProductsList.SelectedItems[0].SubItems[7].Text = String.Empty;
                        _selectedProducts.Remove(_products[ProductsList.SelectedItems[0].Index]);
                        return;
                    }

                    if (_indicatorDifference && inputAmount.Amount > _products[ProductsList.SelectedItems[0].Index].NumberPackages)
                    {
                        MessageBox.Show("Введённое количество превышает доступное", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _selectedProducts.Add(_products[ProductsList.SelectedItems[0].Index], inputAmount.Amount);
                    ProductsList.SelectedItems[0].SubItems[7].Text = inputAmount.Amount.ToString();

                }
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
            DialogResult = DialogResult.Cancel;
        }


        private void LoadData()
        {
            ProductsList.Items.Clear();

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

            foreach (var product in _products)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    product.Id + "",
                    product.Name,
                    product.Description,
                    product.NumberPiecesInPackage + "",
                    product.SpaceOccupied + "",
                    product.NumberPackages + "",
                    product.PricePackage + "",
                    String.Empty
                });

                var prod = _selectedProducts.Keys.FirstOrDefault(p => p.Id == product.Id);
                if (prod != default)
                {
                    item.Selected = true;
                    item.SubItems[7].Text = _selectedProducts[prod].ToString();
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
