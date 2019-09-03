using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace wednesday
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableData();
        }

        public void TableData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Date of Construction", typeof(string));
            dt.Columns.Add("Builders", typeof(string));
            dt.Columns.Add("Date of Destruction", typeof(string));
            dt.Columns.Add("Cause of Destruction", typeof(string));
            dt.Columns.Add("Modern Location", typeof(string));

            dt.Rows.Add("Great Pyramid of Giza",
                        "2584–2561 BC",
                        "Egyptians",
                        "-",
                        "-",
                        "Giza Necropolis, Egypt");

            dt.Rows.Add("Hanging Gardens of Babylon",
                        "c. 600 BC (evident)",
                        "Babylonians or Assyrians",
                        "After 1st century AD",
                        "Unknown",
                        "Hillah or Nineveh, Iraq");

            dt.Rows.Add("Temple of Artemis at Ephesus",
                        "c. 550 BC; and again at 323 BC",
                        "Greeks, Lydians",
                        "356 BC (by Herostratus),AD 262 (by the Goths)",
                        "Arson by Herostratus, plundering",
                        "Near Selçuk, Turkey");

            dt.Rows.Add("Statue of Zeus at Olympia",
                        "466–456 BC (temple),435 BC (statue)",
                        "Greeks",
                        "5th–6th centuries AD",
                        "Disassembled and reassembled at Constantinople; later destroyed by fire",
                        "Olympia, Greece");

            dt.Rows.Add("Mausoleum at Halicarnassus",
                        "351 BC",
                        "Greeks, Persians, Carians",
                        "12th–15th century AD",
                        "Earthquakes",
                        "Bodrum, Turkey");

            dt.Rows.Add("Colossus of Rhodes",
                        "292–280 BC",
                        "Greeks",
                        "226 BC	226 BC Rhodes",
                        "earthquake",
                        "Rhodes, Greece");

            dt.Rows.Add("Lighthouse of Alexandria",
                        "c. 280 BC",
                        "Greeks, Ptolemaic Egyptians",
                        "AD 1303–1480",
                        "1303 Crete earthquake",
                        "Alexandria, Egypt");

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}