<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboartorio_16._1_DSIV.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    .cal
    {
        position:absolute;
        top:81px;
        left:156px;
        right:568px;
        height:600px;
        bottom:134px;
        background-color: dodgerblue;
    }
    .button
    {
        padding-right: 5px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cal">
            <asp:Label ID="l" Text="CALCULADORA BASICA" runat="server" Style="margin-left: 50px" 
                Font-Bold="true" Font-Italic="false" ForeColor="White" Font-Size="25px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="t" runat="server" Style="margin-left: 50px; margin-top:24px; margin-bottom:10px" 
                Width="335px" Height="41px"></asp:TextBox>
            <br />
            <asp:Button ID="b1" runat="server" Text="1" Height="37px" Style="margin-left: 0px"
                 Width="57px" OnClick="b1_Click"/>
            <asp:Button ID="b2" runat="server" Text="2"  Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b2_Click"/>
            <asp:Button ID="b3" runat="server" Text="3"  Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b3_Click"/>
            <asp:Button ID="b4" runat="server" Text="4"  Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b4_Click"/>
            <asp:Button ID="add" runat="server" Text="+"  Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="add_Click"/>
            <asp:Button ID="b5" runat="server" Text="5"  Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b5_Click"/>
            <asp:Button ID="b6" runat="server" Text="6"  Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b6_Click"/>
            <br />
            <asp:Button ID="sub" runat="server" Text="-" Height="37px" Style="margin-left: 0px"
                 Width="57px" OnClick="sub_Click"/>
            <asp:Button ID="b7" runat="server" Text="7" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b7_Click"/>
            <asp:Button ID="b8" runat="server" Text="8" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b8_Click"/>
            <asp:Button ID="b9" runat="server" Text="9" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b9_Click"/>
            <asp:Button ID="mul" runat="server" Text="*" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="mul_Click"/>
            <asp:Button ID="b0" runat="server" Text="0" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="b0_Click"/>
            <asp:Button ID="clr" runat="server" Text="CLR" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="clr_Click"/>
            <br />
            <asp:Button ID="eql" runat="server" Text="=" Height="37px" Style="margin-left: 0px"
                 Width="57px" OnClick="eql_Click"/>
            <asp:Button ID="div" runat="server" Text="/" Height="37px" Style="margin-left: 5px"
                 Width="57px" OnClick="div_Click"/>
        </div>
    </form>
</body>
</html>
