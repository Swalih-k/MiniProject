<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="S_complaint_write.aspx.cs" Inherits="miniprojectmaster.WebForm6" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Register - SB Admin</title>
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    </head>
    <body class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-7">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Complaint Register</h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        <%--<input class="form-control" id="inputFirstName" type="text" placeholder="Enter your first name" />--%>
                                                        <asp:TextBox ID="TextBox1" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                        
                                                        <label for="inputComplaint">Complaint</label>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-floating">
                                                        <%--<input class="form-control" id="inputLastName" type="text" placeholder="Enter your last name" />--%>
                                                        <asp:DropDownList ID="DropDownList1" class="form-control" runat="server" Visible="false" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                                                       
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-floating mb-3">
                                                <%--<input class="form-control" id="inputEmail" type="email" placeholder="name@example.com" />--%>
                                                <asp:DropDownList ID="DropDownList2"  runat="server"></asp:DropDownList>
                                                
                                                <asp:DropDownList ID="DropDownList3"  runat="server"></asp:DropDownList>
                                                
                                                <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
                                                
                                                <label for="inputDate"></label>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        <%--<input class="form-control" id="inputPassword" type="password" placeholder="Create a password" />--%>
                                                        
<%--                                                        <label for="inputPassword">Password</label>--%>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        <%--<input class="form-control" id="inputPasswordConfirm" type="password" placeholder="Confirm password" />--%>
                                                        <asp:DropDownList ID="DropDownList5" class="form-control" runat="server"></asp:DropDownList>
                                                        <label for="inputh_id">h_id</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="mt-4 mb-0">
                                                <%--<div class="d-grid"><a class="btn btn-primary btn-block" href="login.html">Create Account</a></div>--%>
                                                <asp:Button ID="Button1" class="form-control bg-danger"  runat="server" Text="complaint" OnClick="Button1_Click" /><br />
                                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                                <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="c_id" HeaderText="c_id" />
        <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
        <asp:BoundField DataField="r_id" HeaderText="r_id" />
        <asp:BoundField DataField="Date" HeaderText="Date" />
        <asp:BoundField DataField="Replay" HeaderText="Replay" />
        <asp:BoundField DataField="h_id" HeaderText="h_id" />
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
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                       <%-- <div class="small"><a href="login.html">Have an account? Go to login</a></div>--%>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2023</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>
</html>
</asp:Content>
