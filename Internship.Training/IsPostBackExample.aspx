<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="IsPostBackExample.aspx.cs" Inherits="Internship.Training.IsPostBackExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-4">
        <div class="row">
            <div class="form-group">
                <label>Cities</label>
                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCity">

                </asp:DropDownList>
                <hr />
                <asp:Button ID="btnSubmit" CssClass="btn btn-success" OnClick="btnSubmit_Click" Text="Submit" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
