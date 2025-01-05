<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="s_studentupdate.aspx.cs" Inherits="miniprojectmaster.WebForm21" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="r_id" HeaderText="r_id" />
                <asp:BoundField DataField="f_name" HeaderText="f_name" />
                <asp:BoundField DataField="l_name" HeaderText="l_name" />
                <asp:BoundField DataField="email" HeaderText="email" />
                <asp:BoundField HeaderText="status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click1" CommandArgument='<%#Eval("r_id") %>' runat="server">delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <div class="form-floating">
    <asp:TextBox ID="TextBox5" class="form-control" runat="server"></asp:TextBox>
    
    <label for="inputLastName"> r_id</label>
</div><br />
          <div class="col-md-6">
      <div class="form-floating">
          <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
          
          <label for="inputLastName">First name</label>
      </div>
  </div>    <br />    <div class="col-md-6">
    <div class="form-floating">
        <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
        
        <label for="inputLastName">Last name</label>
    </div>
</div><br />
                <div class="col-md-6">
    <div class="form-floating">
        <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
        
        <label for="inputLastName">Email</label>
    </div>
</div>
           
               <br /> <div class="mt-4 mb-0">
                    <asp:Button ID="Button1" class="form-control bg-danger" runat="server" Text="Update" OnClick="Button1_Click" />
      </div>
    </form>
</asp:Content>
