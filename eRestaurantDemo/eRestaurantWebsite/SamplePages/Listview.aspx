<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Listview.aspx.cs" Inherits="SamplePages_Listview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Listview Query Display</h1>
    <table align="center" style="width: 70%">
        <tr>
            <td align="right">Special Event Code:&nbsp;</td>
            <td>
                <asp:DropDownList ID="SpecialEventList" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="z">Select an event</asp:ListItem>
                </asp:DropDownList>&nbsp;&nbsp;
                <asp:LinkButton ID="FetchReservations" runat="server">Fetch Reservations</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:ListView ID="ReservationList" runat="server">
                </asp:ListView>
            </td>
        </tr>
    </table>
    <br />
    <asp:ObjectDataSource ID="ODSSpecialEvents" runat="server"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ODSReservations" runat="server"></asp:ObjectDataSource>

</asp:Content>

