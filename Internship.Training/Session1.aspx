<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Session1.aspx.cs" Inherits="Internship.Training.Session1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-4">
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Name:</label>
                <asp:TextBox runat="server" CssClass="form-control my-2" ID="txtName"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Contact:</label>
                <asp:TextBox runat="server" CssClass="form-control my-2" ID="txtContact"></asp:TextBox>
            </div>

            <asp:Button runat="server" OnClick="btnSubmit_Click" ID="btnSubmit" Text="Submit" CssClass="btn btn-primary" />
        </div>
    </div>
</div>
</asp:Content>
