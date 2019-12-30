using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var students = DataStorage.GetAllStudents();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1> Raport Employee</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                        <th>Class</th>
                                        <th>Score</th>
                                    </tr>");

            foreach (var emp in students)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                  </tr>", emp.Name, emp.Class, emp.Score);
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}