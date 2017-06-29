<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/LoginMaster.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="MGas.Admin.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login - Traditional Template</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-group">

        <div class="row" style="margin-top:7%; width:100%">

            <div class="col-lg-4 col-md-offset-4">
                <div class="well well-lg">

                    <div class="row">

                        <div class="col-md-12" style="text-align:center">
                            <asp:Image ID="imgLoginLogo" runat="server" ImageUrl="~/Resources/logo.jpg" Width="150px" />
                        </div>

                    </div>

                    <br />
                    
                    <div class="row">

                        <div class="col-md-8 col-md-offset-2">
                            <label>Username</label>
                            <asp:TextBox ID="txtLoginEmail" runat="server" placeholder="johnsmith" CssClass="form-control"></asp:TextBox>
                        </div>

                    </div>

                    <br />

                    <div class="row">

                        <div class="col-md-8 col-md-offset-2">
                            <label>Password</label>
                            <asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password" placeholder="******" CssClass="form-control"></asp:TextBox>
                        </div>

                    </div>

                    <br />

                    <div class="row">

                        <div class="col-md-8 col-md-offset-2">
                            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-success" Width="100%" Text="Login" OnClick="btnLogin_Click" />
                        </div>

                    </div>
                </div>
                
                <asp:Panel ID="pnlAlert" runat="server" CssClass="alert alert-warning alert-dismissable" Visible="false">
                    <asp:LinkButton ID="lbtn" runat="server" CssClass="close" OnClick="lbtn_Click">
                        <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                    </asp:LinkButton> 
                    <strong>Login Failed!</strong> Username or password is incorrect.  
                </asp:Panel>
            </div>

        </div>
    </div>

</asp:Content>
