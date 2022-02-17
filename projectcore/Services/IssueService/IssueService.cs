using projectcore.Database;
using projectcore.models;
using projectcore.models.views;
using projectcore.Services.BookService;
using projectcore.Services.IssuesListService;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services.IssueService
{
    public class IssueService : Base<Issues>, IissueService
    {
        private readonly IissuesListService _issuesListService;
        private readonly IBookService _bookService;
        public enum STATUS
        {
            RETURNED = 0,
            LOST = 1,
            NOT_RETURN = 2
        }
        public IssueService(LibaryContext libary, IissuesListService issuesListService, IBookService bookService) : base(libary)
        {
            _issuesListService = issuesListService;
            _bookService = bookService;
        }
        
        public bool InsertIssue(List<Book> books, Users user, DateTime time)
        {
            string now = DateTime.Now.AddDays(15).ToString("yyyy-MM-dd");
            var issues = new Issues() {
                admin_id = Helper.admin.id,
                status = (int)STATUS.NOT_RETURN,
                user_id = user.id,
                issue_date = time,
                expiry_date = DateTime.Parse(now)
            };
            issues = Insert(issues);
            List<Issues_list> issua_Lists = new List<Issues_list>();
            foreach(Book bk in books)
            {
                var first = _bookService.GetById(bk.id);
                // update quantity

                first.quantity = first.quantity - 1;
                _bookService.Update(first.id, first);

                // insert to list
                Issues_list issue = new Issues_list()
                {
                    book_id = first.id,
                    issue_id = issues.id,
                    status = (int)STATUS.NOT_RETURN
                };
                issua_Lists.Add(issue);

            }
            _issuesListService.InsertMany(issua_Lists);
            return true;
        }

        public bool ReturnBook(int id)
        {
            var issues = GetById(id);
            DateTime now = DateTime.Now;
            // update status 
            issues.status = (int)STATUS.RETURNED;
            issues.return_date = now;
            Update(issues.id, issues);

            // update quantity book
            List<Issues_list> books = _issuesListService.GetBookById(issues.id);
            foreach(Issues_list iss in books)
            {
                Book book = _bookService.GetById(iss.book_id);
                book.quantity = book.quantity + 1;

                _bookService.Update(book.id, book);
            }

            return true;
        }

        public bool NotReturn(int id)
        {
            var issues = GetById(id);

            if (issues.status == (int)STATUS.RETURNED)
            {
                List<Issues_list> books = _issuesListService.GetBookById(issues.id);
                foreach (Issues_list iss in books)
                {
                    Book book = _bookService.GetById(iss.book_id);
                    book.quantity = book.quantity - 1;

                    _bookService.Update(book.id, book);
                }
            }
            // update status 
            issues.status = (int)STATUS.NOT_RETURN;
            Update(issues.id, issues);

            // update quantity book
            

            return true;
        }

        public bool Lost(int id)
        {
            var issues = GetById(id);

            if (issues.status == (int)STATUS.RETURNED)
            {
                List<Issues_list> books = _issuesListService.GetBookById(issues.id);
                foreach (Issues_list iss in books)
                {
                    Book book = _bookService.GetById(iss.book_id);
                    book.quantity = book.quantity - 1;

                    _bookService.Update(book.id, book);
                }
            }
            // update status 
            issues.status = (int)STATUS.LOST;
            Update(issues.id, issues);
            return true;
        }
    }
}
