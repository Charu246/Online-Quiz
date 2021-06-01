<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label4" runat="server" Text="00:05:00"></asp:Label>
            
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    
                   
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("ques") %>' />
                    <br />
                    
                    
                    <asp:RadioButton ID="RadioButton1" runat="server" Text='<%# Eval("opt1") %>' GroupName="quizz" ></asp:RadioButton>

                    <br />
                    
                    
                    

                     <asp:RadioButton ID="RadioButton2" runat="server" Text='<%# Eval("opt2") %>' GroupName="quizz" ></asp:RadioButton>

                    <br />
                    
                    
                    <asp:RadioButton ID="RadioButton3" runat="server" Text='<%# Eval("opt3") %>' GroupName="quizz" />
                    <br />
                    
                    
                    <asp:RadioButton ID="RadioButton4" runat="server" Text='<%# Eval("opt4") %>'  GroupName="quizz"/>
                    <br />
                    
                    
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("crtans") %>' Visible="false" />
                    <br />
<br />
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </ItemTemplate>
                </asp:DataList>
           
            <asp:Button ID="Button1" runat="server" Text="Check"  />
            <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click1"  />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:quizConnectionString %>" SelectCommand="SELECT [ques], [opt1], [opt2], [opt3], [opt4], [crtans] FROM [choose]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
