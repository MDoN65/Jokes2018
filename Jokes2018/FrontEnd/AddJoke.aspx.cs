using Jokes2018;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AddJoke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategory.DataTextField = "categoryName";
                ddlCategory.DataValueField = "categoryID";
                bindDropDownList();
            }
        }

        private void bindDropDownList()
        {
            List<CategoryLookup> jokeCat = CategoriesFactory.Create();
            ddlCategory.DataSource = jokeCat;
            ddlCategory.DataBind();
        }
    }
}