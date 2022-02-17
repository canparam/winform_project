using Microsoft.Extensions.DependencyInjection;
using projectcore.Database;
using projectcore.models;
using projectcore.Services;
using projectcore.Services.AllBookService;
using projectcore.Services.AllIssuesService;
using projectcore.Services.AuthorService;
using projectcore.Services.BookService;
using projectcore.Services.IssueService;
using projectcore.Services.IssuesListService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectcore
{
    internal static class Program
    {
        private static void ConfigureServices(ServiceCollection service)
        {
            service.AddDbContext<LibaryContext>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IPublisher, PublisherService>();
            service.AddScoped<IAdminService, AdminService>();
            service.AddScoped<IGenreService, GenreService>();
            service.AddScoped<IAuthorService, AuthorService>();
            service.AddScoped<IBookService, BookService>();
            service.AddScoped<IAllBookService, AllBookService>();
            service.AddScoped<IissueService, IssueService>();
            service.AddScoped<IissuesListService, IssuesListService>();
            service.AddScoped<IAllIssuesService, AllIssuesService>();

            // add form 
            service.AddScoped<Form1>();
            service.AddScoped<FormControls.pages.dashboard>();
            service.AddScoped<FormControls.pages.user.add>();
            service.AddScoped<FormControls.pages.user.list>();
            service.AddScoped<FormControls.pages.user.edit>();
            service.AddScoped<FormControls.pages.book.publisher>();
            service.AddScoped<FormControls.pages.book.genre>();
            service.AddScoped<FormControls.pages.book.author>();
            service.AddScoped<FormControls.pages.addbook>();
            service.AddScoped<FormControls.pages.allbook>();
            service.AddScoped<FormControls.pages.issued.add>();
            service.AddScoped<FormControls.pages.issued.list>();
            //service.AddScoped<FormControls.pages.issued.detail.Edit>();
            
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            ConfigureServices(services);

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}
