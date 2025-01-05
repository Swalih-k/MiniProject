<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="A_complaintview_replay.aspx.cs" Inherits="miniprojectmaster.WebForm7" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" style="width: 1055px; margin-left: 33px; margin-right: 0px">
         
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="233px" Width="1033px">
             <Columns>
    <asp:BoundField DataField="c_id" HeaderText="c_id" />
    <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
    <asp:BoundField DataField="f_name" HeaderText="f_name" />
    <asp:BoundField DataField="Date" HeaderText="Date" />
    <asp:BoundField DataField="Replay" HeaderText="Replay" />
    <asp:BoundField DataField="h_id" HeaderText="h_id" Visible="false" />
                 <asp:TemplateField>
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click1" CommandArgument='<%#Eval("c_id") %>' runat="server">Update</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField>
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click1" CommandArgument='<%#Eval("c_id") %>' runat="server">Delete</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
</Columns>

             <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
             <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
             <RowStyle BackColor="White" ForeColor="#330099" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
             <SortedAscendingCellStyle BackColor="#FEFCEB" />
             <SortedAscendingHeaderStyle BackColor="#AF0101" />
             <SortedDescendingCellStyle BackColor="#F6F0C0" />
             <SortedDescendingHeaderStyle BackColor="#7E0000" />

         </asp:GridView>
         
         <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
         <label for="inputc_id">c_id</label>
         
                  

<asp:TextBox ID="replay" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
<label for="inputReplay">Replay</label>
         <asp:Button ID="Button1" runat="server" class="form-control bg-danger" Text="submit" OnClick="Button1_Click" />
         
         </form>
</asp:Content>
