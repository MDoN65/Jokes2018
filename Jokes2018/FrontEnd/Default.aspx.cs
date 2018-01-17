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
            if (!IsPostBack)
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
            Joke joke = JokeFactory.Create(Convert.ToInt32(jokeId));
            List<Joke> lstJoke = new List<Joke>();
            lstJoke.Add(joke);
            rptJokes.DataSource = lstJoke;
            rptJokes.DataBind();
        }

        private void bindDropDownList()
        {
            List<CategoryLookup> jokeCat = CategoriesFactory.Create();
            ddlJokeCategories.DataSource = jokeCat;
            ddlJokeCategories.DataBind();
        }

        protected void ddlJokeCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int catId = Convert.ToInt32(ddlJokeCategories.SelectedValue);

                List<JokesLookup> joke = JokesFactory.Create(catId);
                RptJokeTitles.DataSource = joke;
                RptJokeTitles.DataBind();
                lblMessage.Text = "";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                RptJokeTitles.DataSource = null;
                RptJokeTitles.DataBind();
            }
        }
    }
}