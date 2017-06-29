<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mSearchPanel.ascx.cs" Inherits="MGas.Resources.UserControl.mSearchPanel" %>
<link rel="stylesheet" type="text/css" href="~/Resources/bootstrap/css/bootstrap.css" id="style" runat="server" visible="false" />
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
                                        <div class="row">
                                        <div class="col-md-6 col-md-offset-6">
                                            <div class="form-inline">
                                                <div class="input-group">
                                                    <span class="input-group-addon">
                                                        Search
                                                    </span>
                                                    <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control"></asp:TextBox>
                                                    <span class="input-group-addon">
                                                        <asp:ImageButton ID="imgbtnSearch" runat="server" CssClass="btn-textbox" ImageUrl="~/Resources/Icons/00_search_icon.png" ToolTip="Search by title" OnClick="imgbtnSearch_Click" />
                                                    </span>
                                                </div>
                                            </div>
                            
                                        </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-md-12">
                                                <asp:GridView ID="gvSearchPanel" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" PageSize="8" OnRowCommand="gvSearchPanel_RowCommand">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="Sr.#" HeaderStyle-Width="50px" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblgvSrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField Visible="false">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblgvIdNo" runat="server" Text='<%# Eval("IdNo") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField HeaderText="Title" HeaderStyle-Width="150px" ItemStyle-Width="150px">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblgvTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField HeaderText="Description" HeaderStyle-Width="300px" ItemStyle-Width="300px">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblgvTitleAR" runat="server" Text='<%# Eval("TitleAR") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField HeaderStyle-Width="100px" ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lnkbtngvSelect" runat="server" CommandName="ItemSelect" Text="Select" CommandArgument='<%# Container.DataItemIndex + 1 %>'></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>

                                                    <EditRowStyle BackColor="#999999" />
                                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Font-Size="Larger" />
                                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" Font-Size="Larger" />
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel-body">
                    
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
