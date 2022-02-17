using projectcore.Services;
using projectcore.Services.BookService;
using projectcore.Services.IssueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectcore.FormControls.pages
{
    public partial class dashboard : Form
    {
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        private readonly IissueService _iissueService;
        public dashboard(IUserService userService, IBookService bookService, IissueService iissueService)
        {
            _userService = userService;
            _bookService = bookService;
            _iissueService = iissueService;
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            int user = _userService.getAll().Count();
            int book = _bookService.getAll().Count();
            int iuss = _iissueService.getAll().Count();
            label4.Text = book.ToString();
            tt_iss.Text = iuss.ToString();
            tt_u.Text = user.ToString();
        }

        private void dashboard_VisibleChanged(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
