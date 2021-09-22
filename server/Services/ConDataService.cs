using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using NovorfayProductCatalogue.Data;

namespace NovorfayProductCatalogue
{
    public partial class ConDataService
    {
        ConDataContext Context
        {
           get
           {
             return this.context;
           }
        }

        private readonly ConDataContext context;
        private readonly NavigationManager navigationManager;

        public ConDataService(ConDataContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public void Reset() => Context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);

        public async Task ExportProductsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportProductsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnProductsRead(ref IQueryable<Models.ConData.Product> items);

        public async Task<IQueryable<Models.ConData.Product>> GetProducts(Query query = null)
        {
            var items = Context.Products.AsQueryable();

            items = items.Include(i => i.ProductCategory);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnProductsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnProductCreated(Models.ConData.Product item);
        partial void OnAfterProductCreated(Models.ConData.Product item);

        public async Task<Models.ConData.Product> CreateProduct(Models.ConData.Product product)
        {
            OnProductCreated(product);

            Context.Products.Add(product);
            Context.SaveChanges();

            OnAfterProductCreated(product);

            return product;
        }
        public async Task ExportProductCategoriesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/productcategories/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/productcategories/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportProductCategoriesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/productcategories/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/productcategories/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnProductCategoriesRead(ref IQueryable<Models.ConData.ProductCategory> items);

        public async Task<IQueryable<Models.ConData.ProductCategory>> GetProductCategories(Query query = null)
        {
            var items = Context.ProductCategories.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnProductCategoriesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnProductCategoryCreated(Models.ConData.ProductCategory item);
        partial void OnAfterProductCategoryCreated(Models.ConData.ProductCategory item);

        public async Task<Models.ConData.ProductCategory> CreateProductCategory(Models.ConData.ProductCategory productCategory)
        {
            OnProductCategoryCreated(productCategory);

            Context.ProductCategories.Add(productCategory);
            Context.SaveChanges();

            OnAfterProductCategoryCreated(productCategory);

            return productCategory;
        }

        partial void OnProductDeleted(Models.ConData.Product item);
        partial void OnAfterProductDeleted(Models.ConData.Product item);

        public async Task<Models.ConData.Product> DeleteProduct(Int64? productId)
        {
            var itemToDelete = Context.Products
                              .Where(i => i.ProductID == productId)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnProductDeleted(itemToDelete);

            Context.Products.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterProductDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnProductGet(Models.ConData.Product item);

        public async Task<Models.ConData.Product> GetProductByProductId(Int64? productId)
        {
            var items = Context.Products
                              .AsNoTracking()
                              .Where(i => i.ProductID == productId);

            items = items.Include(i => i.ProductCategory);

            var itemToReturn = items.FirstOrDefault();

            OnProductGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.ConData.Product> CancelProductChanges(Models.ConData.Product item)
        {
            var entityToCancel = Context.Entry(item);
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;

            return item;
        }

        partial void OnProductUpdated(Models.ConData.Product item);
        partial void OnAfterProductUpdated(Models.ConData.Product item);

        public async Task<Models.ConData.Product> UpdateProduct(Int64? productId, Models.ConData.Product product)
        {
            OnProductUpdated(product);

            var itemToUpdate = Context.Products
                              .Where(i => i.ProductID == productId)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(product);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterProductUpdated(product);

            return product;
        }

        partial void OnProductCategoryDeleted(Models.ConData.ProductCategory item);
        partial void OnAfterProductCategoryDeleted(Models.ConData.ProductCategory item);

        public async Task<Models.ConData.ProductCategory> DeleteProductCategory(int? categoryId)
        {
            var itemToDelete = Context.ProductCategories
                              .Where(i => i.CategoryID == categoryId)
                              .Include(i => i.Products)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnProductCategoryDeleted(itemToDelete);

            Context.ProductCategories.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterProductCategoryDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnProductCategoryGet(Models.ConData.ProductCategory item);

        public async Task<Models.ConData.ProductCategory> GetProductCategoryByCategoryId(int? categoryId)
        {
            var items = Context.ProductCategories
                              .AsNoTracking()
                              .Where(i => i.CategoryID == categoryId);

            var itemToReturn = items.FirstOrDefault();

            OnProductCategoryGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.ConData.ProductCategory> CancelProductCategoryChanges(Models.ConData.ProductCategory item)
        {
            var entityToCancel = Context.Entry(item);
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;

            return item;
        }

        partial void OnProductCategoryUpdated(Models.ConData.ProductCategory item);
        partial void OnAfterProductCategoryUpdated(Models.ConData.ProductCategory item);

        public async Task<Models.ConData.ProductCategory> UpdateProductCategory(int? categoryId, Models.ConData.ProductCategory productCategory)
        {
            OnProductCategoryUpdated(productCategory);

            var itemToUpdate = Context.ProductCategories
                              .Where(i => i.CategoryID == categoryId)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(productCategory);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterProductCategoryUpdated(productCategory);

            return productCategory;
        }
    }
}
