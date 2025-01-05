<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="s_review_write.aspx.cs" Inherits="miniprojectmaster.WebForm22" %>

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
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Review</h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                                                        <label for="inputFirstName">Review</label>
                                                    </div>
                                                </div><br />
                                                <div class="col-md-6">
                                                    <div class="form-floating">
                                                        <asp:DropDownList ID="DropDownList1" class="form-control" runat="server" ></asp:DropDownList>
                                                        <label for="inputLastName">r_id</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-floating mb-3"><label for="inputEmail">Date</label><br /><br />
                                                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
                                                
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        <asp:DropDownList ID="DropDownList5" class="form-control"  runat="server"></asp:DropDownList>
                                                        <label for="inputPassword">h_id</label>
                                                    </div>
                                                </div>
                                              
                                            </div>
                                            <div class="mt-4 mb-0">
                                                <asp:Button ID="Button1"  class="form-control bg-danger" runat="server" Text="Review" OnClick="Button1_Click" />
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="login.html">Have an account? Go to login</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
         <%--   <div id="layoutAuthentication_footer">
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
            </div>--%>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>
</html>

</asp:Content>
