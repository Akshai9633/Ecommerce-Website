<%@ Page Title="" Language="C#" MasterPageFile="~/Mastpage.Master" AutoEventWireup="true" CodeBehind="Productt.aspx.cs" Inherits="Akshaipro.Productt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 255px;
        }
        .auto-style3 {
            width: 149px;
        }
        .auto-style4 {
            width: 149px;
            height: 26px;
        }
        .auto-style6 {
            width: 255px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            margin-bottom: 16;
        }
        .auto-style9 {
            width: 93px;
        }
        .auto-style10 {
            height: 26px;
            width: 93px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="ADD PRODUCT"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label2" runat="server" Text="Category Id"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label4" runat="server" Text="Image"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style8" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style10">
                <asp:Label ID="Label7" runat="server" Text="Status"></asp:Label>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style7">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Standard</asp:ListItem>
                    <asp:ListItem>Premium</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label8" runat="server" Text="Stock"></asp:Label>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Available</asp:ListItem>
                    <asp:ListItem>UnAvailable</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style10"></td>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">
                <asp:GridView ID="GridView1" runat="server" DataKeyNames="Product_Id" OnRowCancelingEdit="GridView1_RowCancelingEdit1" OnRowDeleting="GridView1_RowDeleting1" OnRowEditing="GridView1_RowEditing1" OnRowUpdating="GridView1_RowUpdating1">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:ImageField DataImageUrlField="Image" HeaderText="Image">
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
