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

        private void Clear()
        {
            txtTitle.Text = "";
            txtTeaser.Text = "";
            txtJokeText.Text = "";
            lblMessage.Text = "";
            ddlCategory.SelectedIndex = 0;
            chkFeatured.Checked = false;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Joke joke = JokeFactory.Create();
                joke.Title = txtTitle.Text;
                joke.Teaser = txtTeaser.Text;
                joke.JokeText = txtJokeText.Text;
                joke.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue);
                if (chkFeatured.Checked == true)
                {
                    joke.IsFeatured = true;
                }
                else
                {
                    joke.IsFeatured = false;
                }

                Clear();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}