using Jokes2018;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlJokeCategories.DataTextField = "categoryName";
                ddlJokeCategories.DataValueField = "categoryID";
                bindDropDownList();
                string jokeId = Request.QueryString["jId"];

                if (!String.IsNullOrEmpty(jokeId))
                {
                    lblHeader.Visible = false;
                    bindJokeRepeater(jokeId);
                    rptJokes.Visible = true;
                }
            }
        }

        private void bindJokeRepeater(string jokeId)
        {
            //throw new NotImplementedException();
        }

        private void bindDropDownList()
        {
            //throw new NotImplementedException();
            List<CategoryLookup> jokeCat = CategoriesFactory.Create();
            ddlJokeCategories.DataSource = jokeCat;
            ddlJokeCategories.DataBind();
        }

        protected void ddlJokeCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}