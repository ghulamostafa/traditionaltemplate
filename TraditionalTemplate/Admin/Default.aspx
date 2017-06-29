<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MGas.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Welcome</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="m-container" style="overflow:hidden">

        <div class="form-group-sm">
            <div class="row">
                <div class="col-md-4">
                    <h2>Welcome</h2>
                    <p>Traditional Template Web Console</p>
                </div>
            </div>
        </div>

        <hr />
        
        
        <div class="row" style="text-align:center">
            <div class="col-md-3">
                <asp:ImageButton ID="imgbtnReports" runat="server" CssClass="image-button-big" ImageUrl="~/Resources/Icons/00_Reports.png" ToolTip="Reports" OnClick="imgbtnReports_Click" />
            </div>
            <div class="col-md-3">
                <asp:ImageButton ID="imgbtnFeedbacks" runat="server" CssClass="image-button-big" ImageUrl="~/Resources/Icons/00_feedback.png" ToolTip="Feedbacks" OnClick="imgbtnFeedbacks_Click" />
            </div>
            <div class="col-md-3">
                <asp:ImageButton ID="imgbtnUserManagement" runat="server" CssClass="image-button-big" ImageUrl="~/Resources/Icons/00_users.png" ToolTip="User Management" OnClick="imgbtnUserManagement_Click" />
            </div>
            <div class="col-md-3">
                <asp:ImageButton ID="imgbtnPrimaryDistributors" runat="server" CssClass="image-button-big" ImageUrl="~/Resources/Icons/00_primary_distributors.png" ToolTip="Primary Distributors" OnClick="imgbtnPrimaryDistributors_Click" />
            </div>
        </div>

        <div class="row" style="text-align:center">
            <div class="col-md-3">
                <asp:Label ID="lblReports" runat="server" Text="Reports"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblFeedbacks" runat="server" Text="Feedbacks"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblUserManagement" runat="server" Text="User Management"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblPrimaryDistributors" runat="server" Text="Primary Distributors"></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
