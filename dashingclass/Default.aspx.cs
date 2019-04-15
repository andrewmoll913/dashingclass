using dashingclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dashingclass
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts()
        {
            var _db = new ProductContext();
            IQueryable<Product> query = _db.Products;
            return query;
        }
    }
}