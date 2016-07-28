<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UPDATE_IDATA2.aspx.cs" Inherits="IDATA2_UPDATE_IDATA2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <br />
    <div>
         <asp:Button ID="BTN_UPDATE" runat="server" OnClick="BTN_UPDATE_Click" Text="UPDATE" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Record_No" HeaderText="Record_No" SortExpression="Record_No" />
                <asp:BoundField DataField="HEADER" HeaderText="HEADER" SortExpression="HEADER" />
                <asp:BoundField DataField="DOCUMENT" HeaderText="DOCUMENT" SortExpression="DOCUMENT" />
                <asp:BoundField DataField="CHUTE_NO" HeaderText="CHUTE_NO" SortExpression="CHUTE_NO" />
                <asp:BoundField DataField="BATCH_NO" HeaderText="BATCH_NO" SortExpression="BATCH_NO" />
                <asp:BoundField DataField="COMPANY" HeaderText="COMPANY" SortExpression="COMPANY" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GF_ConString %>" SelectCommand="SELECT * FROM [INPUT_CHUTENO] ORDER BY [COMPANY], [DOCUMENT]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
        <br />
        <br />
    
    </div>
       
    </form>
</body>
</html>
