<%@ Control Language="C#" ClassName="RandomImage"  %>
<%@ Import Namespace="System.IO" %>

<script runat="server">
    void Page_Load()
    {
        string imageToDisplay = GetRandomImage();
        imgRandom.ImageUrl = Path.Combine("~/Images/Boxart", imageToDisplay);
    }

    private string GetRandomImage()
    {
        Random rnd = new Random();
        string[] images = Directory.GetFiles(MapPath("~/Images/Boxart"), "*.jpg");
        string imageToDisplay = images[rnd.Next(images.Length)];
        return Path.GetFileName(imageToDisplay);
    }
</script>

<asp:Timer ID="randomImageTimer" Interval="5001" runat="server" />

<asp:UpdatePanel ID="upRI" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="randomImageTimer" />
    </Triggers>
    <ContentTemplate>
            <div class="divRandomImage">
                <asp:Image id="imgRandom" class="randomImg" runat="server" />
            </div>
    </ContentTemplate>
</asp:UpdatePanel>


