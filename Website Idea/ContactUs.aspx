<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" MasterPageFile="~/MasterPages/Main.master"%>
<%@ Register TagPrefix="user" TagName="RandomImage" Src="~/UserControls/RandomImage.ascx" %>
<%@ Register TagPrefix="user" TagName="RandomQuotation" Src="~/UserControls/RandomQuotation.ascx" %>

<script runat="server">
    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        lblUser.Text = txtUsername.Text;
    }
</script>

<asp:Content id="head" ContentPlaceHolderID="CPHhead" runat="server">
    <style type="text/css">
        .wizard
        {
            border: solid 1px black;
            font: 14px Verdana, Sans-Serif;
            width: 400px;
            height: 300px;
        }

        .header
        {
            color: gray;
            font: bold 18px Verdana, Sans-Serif;
        }

        .sideBar
        {
            background-color: #eeeeee;
            padding: 10px;
            width: 100px;
        }

        .sideBar a
        {
            text-decoration: none;
        }

        .step
        {
            padding: 10px;
        }
    </style>
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
    <table id="tblContacts">
        <tr>
            <th>
                Contact Us
            </th>
        </tr>
        <tr>
            <td id="contactList">
                <ul>
                    <li>E-mail:&nbsp;&nbsp;randomemail@dreamer.com</li>
                    <li>Customer Support Hotline:&nbsp;&nbsp;320-111-6789</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td id="wizardCell">
                <center>
                    <asp:Wizard ID="wizard1" HeaderText="Company Survey" OnFinishButtonClick="Wizard1_FinishButtonClick" CssClass="wizard" HeaderStyle-CssClass="wizardHeader" SideBarStyle-CssClass="sideBar" StepStyle-CssClass="step" DisplaySideBar="false" runat="server">
                        <WizardSteps>
                            <asp:WizardStep ID="wizardStep1" Title="Introduction">
                                Please send us a comment. Positive or negative all opinions are valuable to us.
                            </asp:WizardStep>
                            <asp:WizardStep ID="wizardStep2" Title="Step 1" StepType="Step">
                                <asp:Label ID="lblUsername" Text="Username:" AssociatedControlID="txtUsername" runat="server" />
                                <br />
                                <asp:TextBox ID="txtUsername" runat="server" />
                            </asp:WizardStep>
                            <asp:WizardStep ID="wizardStep3" Title="Step 2" StepType="Step">
                                <asp:Label ID="lblComment" Text="Comment:" AssociatedControlID="txtComment" runat="server" />
                                <br />
                                <asp:TextBox ID="txtComment" runat="server" />
                            </asp:WizardStep>
                            <asp:WizardStep ID="wizardStep4" Title="Thank You" StepType="Complete">
                                <asp:Label ID="lblUser" Text="" runat="server" />
                                <asp:Label ID="lblMessage" Text="Thank you for your thoughts. We really appreciate it." runat="server" />
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>
                </center>
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