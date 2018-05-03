<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="MyWebsite2.Pages.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <a href="http://172.28.134.91/Reportserver?%2fEquipMaintSys1&rs:Command=ListChildren">Report Server</a>
        <br>
        <br>
        <a href="http://172.28.134.91/ReportServer/Pages/ReportViewer.aspx?%2fEquipMaintSys1%2fComponents&rs:Command=Render">Component</a>
        <br>
        <a href="http://172.28.134.91/ReportServer/Pages/ReportViewer.aspx?%2fEquipMaintSys1%2fFaults&rs:Command=Render">Faults</a>
        <br>
        <a href="http://172.28.134.91/ReportServer/Pages/ReportViewer.aspx?%2fEquipMaintSys1%2fMaintenance&rs:Command=Render">Maintenance</a>
        <br>
        <a href="http://172.28.134.91/ReportServer/Pages/ReportViewer.aspx?%2fEquipMaintSys1%2fSyslog&rs:Command=Render">Syslog</a>
        <br>
    </p>
</asp:Content>
