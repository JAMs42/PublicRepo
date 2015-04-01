<%@ Control Language="C#" ClassName="RandomQuotation" %>
<%@ Import Namespace="System.Collections.Generic" %>

<script runat="server">
    void Page_Load()
    {
        List<string> quotes = new List<string>();
        quotes.Add("Stay awhile and listen.<br/> -Diablo");
        quotes.Add("Thank you Mario!<br/>But the princess is in another castle.<br/> -Super Mario Bros.");
        quotes.Add("You have died of Dysentry.<br/> -Oregon Trail");
        quotes.Add("Boomshakalaka!<br/> -NBA Jam");
        quotes.Add("In the year 200x a super robot named Mega Man was created.<br/> -Mega Man 2");
        Random rnd = new Random();
        lblQuote.Text = quotes[rnd.Next(quotes.Count)];
    }
</script>

<asp:ScriptManager ID="smRQ" runat="server" />
<asp:Timer ID="Timer1" Interval="5000" runat="server" />

<asp:UpdatePanel ID="upRQ" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Timer1" />
    </Triggers>
    <ContentTemplate>
            <div class="quote">
                <asp:Label ID="lblQuote" runat="server" />
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
