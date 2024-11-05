<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17_DSIV._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">
            
            <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
                AllowSorting="true" AllowPaging="true"
                DataKeyNames="ProductID" 
                AutoGenerateEditButton="true" 
                runat="server"
                GridLines="Both">
            </asp:GridView>
            
            <asp:SqlDataSource ID="MyDataSource1" runat="server"
                 ConnectionString="data source=Cesar-Castillo44;initial catalog=Northwind;persist security info=True;Integrated Security=SSPI;"
                 ProviderName="System.Data.SqlClient"
                 SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"
                 UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductId]=@ProductId">
            </asp:SqlDataSource>
        </div>
    </main>

</asp:Content>
