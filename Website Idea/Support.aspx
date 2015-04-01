<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Support.aspx.cs" Inherits="Support" MasterPageFile="~/MasterPages/Main.master"%>
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
    <div id="supportPageContent">
        <table id="supportTable">
            <tr>
                <th>
                    <h3>Support</h3>
                </th>
            </tr>
            <tr>
                <td>
                    <table id="tblVGHS">
                        <tr>
                            <td class="logoCell">
                                <a href="http://www.rocketjump.com/category/vghs"><img src="Images/Logos/rocketJump.png" class="logo"/></a>
                            </td>
                            <td class="spacingCell"></td>
                            <td class="descriptionCell">
                                Video Game High School is a great ultra geeky web show. Make sure you don't make a Brian D. out of yourself and check it out.
                            </td>
                            <td class="spacingCell"></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tblGeekandSundry">
                        <tr>
                            <td class="logoCell">
                                <a href="http://geekandsundry.com/"><img src="Images/Logos/geekAndSundry.png" class="logo"/></a>
                            </td>
                            <td class="spacingCell"></td>
                            <td class="descriptionCell">
                                Geek and Sundry is if you couldn't already guess a geeky, syfy, gamer web channel
                                 run by Wil Wheaton and Felicia Day.
                            </td>
                            <td class="spacingCell"></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tblSmoothMcGroove">
                        <tr>
                            <td class="logoCell">
                                <a href="http://www.patreon.com/smoothmcgroove"><img src="Images/Logos/smoothMcGroove.jpg"  class="logo"/></a>
                            </td>
                            <td class="spacingCell"></td>
                            <td class="descriptionCell">
                                Smooth McGroove has recreated some great gaming tracks into acapella and they are amazing.
                                 Click the logo to check out his support page.
                                 There you will also find links to his youtube page and facebook page.
                            </td>
                            <td class="spacingCell"></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
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