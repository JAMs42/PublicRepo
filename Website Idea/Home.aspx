<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" MasterPageFile="~/MasterPages/Home.master"%>
<%@ Register TagPrefix="user" TagName="RandomImage" Src="~/UserControls/RandomImage.ascx" %>
<%@ Register TagPrefix="user" TagName="RandomQuotation" Src="~/UserControls/RandomQuotation.ascx" %>

<asp:Content id="head" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>


<asp:Content ID="title" ContentPlaceHolderID="cphTitle" runat="server">
    Dreamer Games
</asp:Content>


<asp:Content ID="leftSidebar" ContentPlaceHolderID="cphLeftSidebar" runat="server">
    <div id="divLeftSidebar">
        <table id="memberSignUp">
            <tr>
                <td>
                    Newsletter sign up
                </td>
            </tr>
        </table>
        <table id="news">
            <tr>
                <td>
                    News
                </td>
            </tr>
        </table>
        <table id="poll">
            <tr>
                <td>
                    Poll
                </td>
            </tr>
        </table>
    </div>
</asp:Content>


<asp:Content ID="main" ContentPlaceHolderID="upcoming1" runat="server">
    <img src="Images/Boxart/BoF2box.jpg" class="boxart"/>
</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="upcoming2" runat="server">
    <img src="Images/Boxart/Lunar2box.jpg"  class="boxart"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="newReleases1" runat="server">
    <img src="Images/Boxart/BoFbox.jpg"  class="boxart"/>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="newReleases2" runat="server">
    <img src="Images/Boxart/Lunar1box.jpg"  class="boxart"/>
</asp:Content>


<asp:Content ID="rightSidebar" ContentPlaceHolderID="cphRIghtSidebar" runat="server">
    <div id="divRightSidebar">
        <table id="funstuff">
            <tr>
                <td>
                    <user:RandomQuotation ID="RandomQuotation2" runat="server" />
                </td>
            </tr>
            <tr>
                <td id="lineRule">
                    <hr />
                </td>
            </tr>
            <tr>
                <td>
                    <user:RandomImage id="RandomImage2" runat="server" />
                </td>
            </tr>
        </table>
        <table id="tblSupport">
            <tr>
                <td>
                    Support
                </td>
            </tr>
        </table>
    </div>
</asp:Content>