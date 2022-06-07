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
             "������� �� �� �����, � �� ���������, �� �� ��. ������� ��������",
             "���� ������ � ���������� ����, �� ����� �� ���������������� � �� �������� ���������� �� �����. ������� ���������",
             "����������� ������ ����, ��� ���� �������� ����� �� �������������. ����� ������"
            };

            Random rnd = new Random();
            int index = rnd.Next(quotes.Count);

            Text = quotes[index];
        }
    }
}
