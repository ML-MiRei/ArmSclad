using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Products.Commands.AddProduct;
using ArmSclad.Domain.UseCases.Products.Commands.DeleteProduct;
using ArmSclad.Domain.UseCases.Products.Commands.UpdateProduct;
using ArmSclad.Domain.UseCases.Products.Queries.GetProducts;
using ArmSclad.UI.Common;
using MediatR;

namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    public partial class ProductsForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 17;
        private List<ProductEntity> _products;


        public ProductsForm(IMediator mediator)
        {
            InitializeComponent();
            TopLevel = false;

            _mediator = mediator;

            UpdateMode.CheckedChanged += UpdateMode_CheckedChanged;
            LoadData();
        }

        private void UpdateMode_CheckedChanged(object? sender, EventArgs e)
        {
            ProductsList.SelectedItems.Clear();
            if (UpdateMode.Checked)
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
                ProductEntity productEntity = _products[ProductsList.Items.IndexOf(ProductsList.SelectedItems[0])];
                InfoProductForm infoStorageForm = new InfoProductForm(ref productEntity);
                var result = infoStorageForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TaskManager.AddTask(async () =>
                    {
                        try
                        {
                            await _mediator.Send(new UpdateProductCommand { Product = productEntity });
                            MessageBox.Show("Информации о продукте успешно обновлена");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка сохранения информации о продукте", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                }
            }
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
                ProductsList.Items.Add(new ListViewItem(new string[] {
                    product.Id + "",
                    product.Name,
                    product.Description,
                    product.NumberPiecesInPackage + "",
                    product.Price + "",
                    product.SpaceOccupied + "",
                    product.PricePackage + ""
                }));
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductEntity productEntity = new ProductEntity();
            InfoProductForm infoStorageForm = new InfoProductForm(ref productEntity);
            var result = infoStorageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new AddProductCommand { Product = productEntity });
                        MessageBox.Show("Информации о продукте успешно добавлена");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка сохранения информации о продукте", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            int selectedProductId = _products[ProductsList.SelectedItems[0].Index].Id;
            var result = MessageBox.Show("Вы уверены, что хотите удалить информацию о продукте?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new DeleteProductCommand { ProductId = selectedProductId});
                        MessageBox.Show("Информация о продукте успешно удалена");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка удаления информации о продукте", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }

        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
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

    }
}

