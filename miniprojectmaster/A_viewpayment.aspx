<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="A_viewpayment.aspx.cs" Inherits="miniprojectmaster.WebForm10" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="fee_id" HeaderText="fee_id" />
        <asp:BoundField DataField="f_name" HeaderText="f_name" />
        <asp:BoundField DataField="Date" HeaderText="Date" />
        <asp:BoundField DataField="h_id" HeaderText="h_id" />
        <asp:BoundField DataField="Amount" HeaderText="Amount" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" CommandArgument='<%#Eval("fee_id") %>' runat="server">Delete</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField></asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
    <RowStyle BackColor="White" ForeColor="#003399" />
    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <SortedAscendingCellStyle BackColor="#EDF6F6" />
    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
    <SortedDescendingCellStyle BackColor="#D6DFDF" />
    <SortedDescendingHeaderStyle BackColor="#002876" />
</asp:GridView>
       

</form>
</asp:Content>
