using MVP.Presenters;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVP.Models;

namespace WebForm
{
    public partial class Person : System.Web.UI.Page, IPersonView
    {
        PersonPresenter _presenter;

        public void Show(MVP.Models.Person person)
        {
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtLastUpdated.Text = person.LastUpdated.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (_presenter == null)
                _presenter = new PersonPresenter(this);

            if (!IsPostBack)
                _presenter.Init();
        }
    }
}