using MVP.Presenters;
using MVP.Views;
using System.Windows.Forms;
using MVP.Models;
using System;

namespace WinForm
{
    public partial class PersonForm : Form, IPersonView
    {
        PersonPresenter _presenter;

        public PersonForm()
        {
            InitializeComponent();
            if (_presenter == null)
                _presenter = new PersonPresenter(this);

            _presenter.Init();
        }

        public void Show(Person person)
        {
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtLastUpdated.Text = person.LastUpdated.ToString();
        }
    }
}
