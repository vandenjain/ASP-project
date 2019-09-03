<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="wednesday._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h2>ANCIENT SEVEN WONDERS OF THE WORLD</h2>
        <img src="Images\SevenWondersOfTheWorld.png" />
    </div>

    <div>
        <div>
            <h4>The Ancient Seven wonders of the World are: </h4>
            <ul>
                <li>Great Pyramid of Giza</li>
                <li>Hanging Gardens of Babylon</li>
                <li>Temple of Artemis at Ephesus</li>
                <li>Statue of Zeus at Olympia</li>
                <li>Mausoleum at Halicarnassus</li>
                <li>Colossus of Rhodes</li>
                <li>Lighthouse of Alexandria</li>
            </ul>
        </div>
        <p>The Seven Wonders of the World or the Seven Wonders of the Ancient World is a list of remarkable constructions of classical antiquity given by various authors in guidebooks or poems popular among ancient Hellenic tourists. Although the list, in its current form, did not stabilise until the Renaissance, the first such lists of seven wonders date from the 1st–2nd century BC. The original list inspired innumerable versions through the ages, often listing seven entries. Of the original Seven Wonders, only one—the Great Pyramid of Giza (also called the Pyramid of Khufu, after the pharaoh who built it), the oldest of the ancient wonders—remains relatively intact. The Colossus of Rhodes, the Lighthouse of Alexandria, the Mausoleum at Halicarnassus, the Temple of Artemis and the Statue of Zeus were all destroyed. The location and ultimate fate of the Hanging Gardens are unknown, and there is speculation that they may not have existed at all.</p>
    </div>

    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>

</asp:Content>

