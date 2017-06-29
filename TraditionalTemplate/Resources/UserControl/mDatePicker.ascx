<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mDatePicker.ascx.cs" Inherits="MGas.Resources.UserControl.mDatePicker" %>
<link rel="stylesheet" type="text/css" href="../Styles/bootstrap.css" id="style" runat="server" visible="false" />
<div class="form-inline">
<asp:DropDownList ID="mDay" runat="server" CssClass="form-control form-group-sm" >
    <asp:ListItem Text="01" Value="1" Selected="True"></asp:ListItem>
    <asp:ListItem Text="02" Value="2"></asp:ListItem>
    <asp:ListItem Text="03" Value="3"></asp:ListItem>
    <asp:ListItem Text="04" Value="4"></asp:ListItem>
    <asp:ListItem Text="05" Value="5"></asp:ListItem>
    <asp:ListItem Text="06" Value="6"></asp:ListItem>
    <asp:ListItem Text="07" Value="7"></asp:ListItem>
    <asp:ListItem Text="08" Value="8"></asp:ListItem>
    <asp:ListItem Text="09" Value="9"></asp:ListItem>
    <asp:ListItem Text="10" Value="10"></asp:ListItem>
    <asp:ListItem Text="11" Value="11"></asp:ListItem>
    <asp:ListItem Text="12" Value="12"></asp:ListItem>
    <asp:ListItem Text="13" Value="13"></asp:ListItem>
    <asp:ListItem Text="14" Value="14"></asp:ListItem>
    <asp:ListItem Text="15" Value="15"></asp:ListItem>
    <asp:ListItem Text="16" Value="16"></asp:ListItem>
    <asp:ListItem Text="17" Value="17"></asp:ListItem>
    <asp:ListItem Text="18" Value="18"></asp:ListItem>
    <asp:ListItem Text="19" Value="19"></asp:ListItem>
    <asp:ListItem Text="20" Value="20"></asp:ListItem>
    <asp:ListItem Text="21" Value="21"></asp:ListItem>
    <asp:ListItem Text="22" Value="22"></asp:ListItem>
    <asp:ListItem Text="23" Value="23"></asp:ListItem>
    <asp:ListItem Text="24" Value="24"></asp:ListItem>
    <asp:ListItem Text="25" Value="25"></asp:ListItem>
    <asp:ListItem Text="26" Value="26"></asp:ListItem>
    <asp:ListItem Text="27" Value="27"></asp:ListItem>
    <asp:ListItem Text="28" Value="28"></asp:ListItem>
    <asp:ListItem Text="29" Value="29"></asp:ListItem>
    <asp:ListItem Text="30" Value="30"></asp:ListItem>
    <asp:ListItem Text="31" Value="31"></asp:ListItem>
</asp:DropDownList>

<asp:DropDownList ID="mMonth" runat="server" CssClass="form-control form-group-sm">
    <asp:ListItem Text="Jan" Value="Jan" Selected="True"></asp:ListItem>
    <asp:ListItem Text="Feb" Value="Feb"></asp:ListItem>
    <asp:ListItem Text="Mar" Value="Mar"></asp:ListItem>
    <asp:ListItem Text="Apr" Value="Apr"></asp:ListItem>
    <asp:ListItem Text="May" Value="May"></asp:ListItem>
    <asp:ListItem Text="Jun" Value="Jun"></asp:ListItem>
    <asp:ListItem Text="Jul" Value="Jul"></asp:ListItem>
    <asp:ListItem Text="Aug" Value="Aug"></asp:ListItem>
    <asp:ListItem Text="Sep" Value="Sep"></asp:ListItem>
    <asp:ListItem Text="Oct" Value="Oct"></asp:ListItem>
    <asp:ListItem Text="Nov" Value="Nov"></asp:ListItem>
    <asp:ListItem Text="Dec" Value="Dec"></asp:ListItem>
</asp:DropDownList>

<asp:TextBox ID="mYear" runat="server" MaxLength="4" CssClass="form-control form-group-sm"  Width="60px" ></asp:TextBox>
    </div>