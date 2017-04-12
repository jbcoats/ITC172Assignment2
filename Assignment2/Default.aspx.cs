using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] CalendarEvents = new string[6, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
        CalendarEvents[0, 0] = "4/30/2017";
        CalendarEvents[0, 1] = "Jessie's Birthday";
        CalendarEvents[1, 0] = "5/5/2017";
        CalendarEvents[1, 1] = "Joshua's Birthday";
        CalendarEvents[2, 0] = "5/5/2017";
        CalendarEvents[2, 1] = "Cinco de Mayo";
        CalendarEvents[3, 0] = "7/4/2017";
        CalendarEvents[3, 1] = "Independance Day";
        CalendarEvents[4, 0] = "12/25/2017";
        CalendarEvents[4, 1] = "Christmas";
        CalendarEvents[5, 0] = "1/1/2017";
        CalendarEvents[5, 1] = "New Year's Day";
    }

    protected void CalendarOfEvents_SelectionChanged(object sender, EventArgs e)
    {
        string eventDate = CalendarOfEvents.SelectedDate.ToShortDateString();

        EventLabel.Text = "";

        for (int i = 0; i < 6; i++)
        {
            if (eventDate.Equals(CalendarEvents[i, 0]))
            {
                EventLabel.Text += "<br />" + CalendarEvents[i, 1];
            }
        }

    }
}