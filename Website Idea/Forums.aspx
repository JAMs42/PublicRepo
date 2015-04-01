<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forums.aspx.cs" Inherits="Forums" MasterPageFile="~/MasterPages/Main.master"%>
<%@ Register TagPrefix="user" TagName="RandomImage" Src="~/UserControls/RandomImage.ascx" %>
<%@ Register TagPrefix="user" TagName="RandomQuotation" Src="~/UserControls/RandomQuotation.ascx" %>

<asp:Content id="head" ContentPlaceHolderID="CPHhead" runat="server">
    
</asp:Content>


<asp:Content ID="title" ContentPlaceHolderID="CPHtitle" runat="server">
    Wolf Pack Games
</asp:Content>


<asp:Content ID="leftSidebar" ContentPlaceHolderID="CPHleftSidebar" runat="server">
    <div id="divLeftSidebar">
        <table id="memberSignUp">
            <tr>
                <td>
                    Member Sign Up
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


<asp:Content ID="main" ContentPlaceHolderID="CPHmain" runat="server">
    <table id="tblForum">
        <tr>
            <th>
                Forums
            </th>
        </tr>
        <tr>
            <td>
                FORUM POSTS YAY
            </td>
        </tr>
        <tr>
            <td>
                YAY FORUM POSTS
            </td>
        </tr>
        <tr>
            <td>
                POSTS
            </td>
        </tr>
    </table>
</asp:Content>


<asp:Content ID="rightSidebar" ContentPlaceHolderID="CPHrightSidebar" runat="server">
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