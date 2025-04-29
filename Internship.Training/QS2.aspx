<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="QS2.aspx.cs" Inherits="Internship.Training.QS2" %>
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

            
        </div>
    </div>
</div>
</asp:Content>
