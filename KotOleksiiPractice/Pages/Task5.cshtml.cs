using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace KotOleksiiPractice.Pages.Shared
{
    public class Task5Model : PageModel
    {
        public string Text { get; set; }
        public void OnGet()
        {
            List<string> quotes = new List<string> {
             "Прагніть не до успіху, а до цінностей, які він дає. Альберт Айнштайн",
             "Своїм успіхом я зобов’язана тому, що ніколи не виправдовувалася і не приймала виправдань від інших. Флоренс Найтінгейл",
             "Найскладніше почати діяти, все інше залежить тільки від наполегливості. Амелія Ергарт"
            };

            Random rnd = new Random();
            int index = rnd.Next(quotes.Count);

            Text = quotes[index];
        }
    }
}
