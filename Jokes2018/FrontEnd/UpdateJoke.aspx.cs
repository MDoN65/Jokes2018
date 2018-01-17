using Jokes2018;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class UpdateJoke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategory.DataTextField = "categoryName";
                ddlCategory.DataValueField = "categoryID";
              
                string jokeId = Request.QueryString["jID"];

                if (!String.IsNullOrEmpty(jokeId))
                {
                    
                    Joke joke = JokeFactory.Create(Convert.ToInt32(jokeId));
                    Session["timestamp"] = joke.TimeStamp;
                    bindJokeInformation(joke);
                    bindDropDownList(joke);
                } else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private void bindDropDownList(Joke joke)
        {
            List<CategoryLookup> jokeCat = CategoriesFactory.Create();
            ddlCategory.DataSource = jokeCat;
            ddlCategory.DataBind();
        }

        private void bindJokeInformation(Joke joke)
        {
            ddlCategory.SelectedValue = joke.CategoryId.ToString();
            txtJokeText.Text = joke.JokeText;
            txtTitle.Text = joke.Title;
            txtTeaser.Text = joke.Teaser;
            chkFeatured.Checked = joke.IsFeatured;


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
                joke.JokeId = Convert.ToInt16(Request.QueryString["jID"]);
                joke.TimeStamp = Session["timestamp"];
                if (chkFeatured.Checked == true)
                {
                    joke.IsFeatured = true;
                }
                else
                {
                    joke.IsFeatured = false;
                }


                CUDMethods.Update(joke);
                lblMessage.Text = "Joke has been updated!";
                Session["timestamp"] = joke.TimeStamp;
                //Clear();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }

        }
    }
}