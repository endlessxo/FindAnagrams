<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Find Anagrams </title>
</head>
<body>


    <form id="form1" runat="server">
    <div style="background-color: #C0C0C0; border-style: solid; border-width: 1px; margin: auto; width: 800px; padding: 10px">
    <h1 style="text-align: center">Find Anagrams</h1>
    <br />
        Enter a character string:&nbsp;
        <asp:TextBox ID="inputString" name="inputString" type="text" style="width:147px;" runat="server"></asp:TextBox>
            &nbsp; &nbsp;
       
        <asp:CheckBox ID="duplicate" runat="server" />
            <asp:Label ID="duplicate_label" runat="server" Text="Eliminate Duplicates"></asp:Label>
        <br /><br />
        <asp:ListBox ID="outputList" runat="server" size="4" name="outputList" style="height:85px;width:150px;"></asp:ListBox>
        <br /><br />
        <asp:Button ID="submit" runat="server" Text="Find Anagrams" OnClick="find" />
        <br /><br />
        <asp:Label ID="error_msg" name="error_msg" runat="server" Text=""></asp:Label>
        <asp:Label ID="anagram_count" name="anagram_count" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
