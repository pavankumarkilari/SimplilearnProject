<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FeedbackForm.aspx.cs" Inherits="VMonAzurePro.FeedbackForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 214px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td colspan="3"><h1>Feedback Form</h1></td>
        </tr>
        <tr>
            <td class="auto-style1">Name:</td>
            <td>
                <asp:TextBox ID="TxtName" runat="server" Width="177px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Email:</td>
            <td>
                <asp:TextBox ID="TxtEmail" runat="server" Width="177px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Ratings:</td>
            <td>
                <asp:TextBox ID="TxtRatings" runat="server" Width="178px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Message:</td>
            <td>
                <asp:TextBox ID="TxtMessage" runat="server" TextMode="MultiLine" Width="176px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>