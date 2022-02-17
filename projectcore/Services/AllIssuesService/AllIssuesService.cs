using projectcore.Database;
using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectcore.Services.AllIssuesService
{
    public class AllIssuesService : Base<AllIssues>, IAllIssuesService
    {
        public AllIssuesService(LibaryContext libary) : base(libary)
        {
           
        }

        [Obsolete]
        public List<AllIssues> GetAllIssues()
        {
            string sql = @"select iss.id,u.fullname,iss.user_id,iss.expiry_date,iss.issue_date,iss.return_date,iss.status,a.username, COUNT(ils.book_id) as count
                      from issues as iss LEFT JOIN users as u ON u.id = iss.user_id 
                      LEFT JOIN admin as a ON a.id = iss.admin_id LEFT JOIN issua_list as ils ON ils.issue_id = iss.id
                      GROUP BY u.fullname, iss.status,iss.admin_id,iss.expiry_date,iss.user_id,iss.issue_date,iss.return_date,
                      a.username,iss.id ";

            var query = QueryRawSql(sql,
                    x => new AllIssues
                    {
                        id = (int)x[0],
                        fullname = (string)x[1],
                        user_id = (int)x[2],
                        expiry_date = (DateTime)x[3],
                        issue_date = (DateTime)x[4],
                        return_date = (DateTime)x[5],
                        status = (int)x[6],
                        username = (string)x[7],
                        count = (int)x[8]
                    }).ToList();
            return query;
        }

        [Obsolete]
        public List<AllIssues> GetIssuaesById(int id)
        {
            string sql = @"select iss.id, ilist.book_id,b.title,u.fullname, u.email, iss.expiry_date,iss.issue_date,iss.return_date,iss.status,a.username
                            from issues as iss 
                            LEFT JOIN issua_list as ilist ON iss.id = ilist.issue_id
                            LEFT JOIN books as b ON b.id = ilist.book_id
                            LEFT JOIN users as u ON u.id = iss.user_id
                            LEFT JOIN admin as a ON a.id = iss.admin_id
                             WHERE iss.id = " + id;
            var query = QueryRawSql(sql,
                    x => new AllIssues
                    {
                        id = (int)x[0],
                        title = (string)x[2],
                        fullname = (string)x[3],
                        email = (string)x[4],
                        expiry_date = (DateTime)x[5],
                        issue_date = (DateTime)x[6],
                        return_date = (DateTime)x[7],
                        status = (int)x[8],
                        username = (string)x[9]
                    }).ToList();
            return query;
        }

        [Obsolete]
        public List<AllIssues> GetIssuaesByUserID(int id)
        {
            string sql = @"select iss.id,iss.issue_date,iss.return_date,iss.expiry_date,iss.status,COUNT(islis.book_id) as count 
                            from issues as iss LEFT JOIN issua_list as islis ON iss.id 
                        = islis.issue_id WHERE iss.user_id = " + id +"GROUP BY iss.id,iss.issue_date,iss.return_date,iss.expiry_date,iss.status";
            var query = QueryRawSql(sql,
                    x => new AllIssues
                    {
                        id = (int)x[0],
                        issue_date = (DateTime?)x[1],
                        return_date = (DateTime?)x[2],
                        expiry_date = (DateTime?)x[3],
                        status = (int)x[4],
                        count = (int)x[5]
                    }).ToList();
            return query;
        }
    }
}
