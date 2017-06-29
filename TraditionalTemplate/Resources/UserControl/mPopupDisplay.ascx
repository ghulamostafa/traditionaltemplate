<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mPopupDisplay.ascx.cs" Inherits="MGas.Resources.UserControl.mPopupDisplay" %>
<link rel="stylesheet" type="text/css" href="~/Resources/bootstrap/css/bootstrap.css" id="style" runat="server" visible="false" />
<link rel="stylesheet" type="text/css" href="~/Resources/styles/mgas-custom.css" id="Link1" runat="server" visible="false" />
<style>
    .searchPanel{
        position: fixed;
        width: 100%;
        left:30%;
        top:30%;
        height:300px;
        z-index:99;
    }

    .modalBack{
        background:rgba(255,255,255,0.5);
        top:0;
        left:0;
        padding:0;
        margin:0;
        width:100%;
        height:100%;
        z-index:200;
        position:fixed;
        
    }
    .modalBody{
        width:40%;
        margin-left:35%;
    }
    .modalTable{
        width:100%;
        height:100%;
        left:0;
        right:0;        
        background-size: cover;
    }

</style>

<div class="modalBack">
    <table class="modalTable">
        <tr>
            <td>
                <div class="modalBody">
                    <div class="form-group-sm searchPanel">
                        <div class="row">
                            <div class="col-md-5">
                                <div class="panel panel-info">
                                    <div class="panel-heading">
                                        <asp:Label ID="lblHeading" runat="server"></asp:Label>    
                                        <asp:LinkButton ID="lbtn" runat="server" CssClass="close" OnClick="lbtn_Click"><span class="glyphicon glyphicon-remove" aria-hidden="true"></span></asp:LinkButton> 
                                    </div>

                                    <div class="panel-body">
                                        <asp:Label ID="lblPopupDisplayMain" runat="server"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</div>