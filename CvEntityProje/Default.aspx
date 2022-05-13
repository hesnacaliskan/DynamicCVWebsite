<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CvEntityProje.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cv Sitesi</title>
    <link rel="stylesheet" href="/web/style.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">
    <script src="https://kit.fontawesome.com/cac50dd956.js" crossorigin="anonymous"></script>
</head>
<body>
    <div id="wrapper">
        <nav>
            <img src="/web/hesna.png" alt="">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <h1><%# Eval("Adsoyad") %></h1>
                </ItemTemplate>
            </asp:Repeater>     
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <h2><%# Eval("Unvan") %></h2>
                </ItemTemplate>
            </asp:Repeater>
            
            <div id="social-media">
                <a href="https://www.instagram.com/hesnaclskn/"><i class="fa-brands fa-instagram"></i></a>                
                <a href="https://www.linkedin.com/in/hatice-hesna-caliskan/"><i class="fa-brands fa-linkedin-in"></i></a>
                <a href="https://github.com/hesnacaliskan"><i class="fa-brands fa-github"></i></a>
                <a href="https://drive.google.com/drive/folders/1rLCinHzpJT8JXDtzLh2qGcyIK8HKCovQ?usp=sharing"><i class="fa-brands fa-google-drive"></i></a>

            </div>
            <a href="#about">Hakkımda</a>
            <a href="#education">Eğitim</a>
            <a href="#skills">Yetenekler</a>
            <a href="#experiments">Deneyimler</a>
            <a href="#certificate">Sertifikalar</a>
            <a href="#language">Yabancı Dil</a>
            <a href="#contact">İletişim</a>
        </nav>
        <div id="content">
            <section id="about">
                <div class="container">
                    <h3>Hakkımda</h3>
                    <p>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <%# Eval("Hakkimda") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </p>
                </div>
            </section>
            <section id="education">
                <div class="container">
                    <h3>Eğitim</h3>
                    <dl>
                        <dt>
                            <asp:Repeater ID="Repeater4" runat="server">
                                <ItemTemplate>
                                    <i class="fa-solid fa-building-columns"></i> <%# Eval("Egitimokul") %></i> 
                                    <dd>- <%# Eval("Egitimayrinti") %></dd>
                                </ItemTemplate>
                            </asp:Repeater>

                        </dt>
<%--                        <dt>
                            <i class="fa-solid fa-building-columns"></i> Vahit Tuna Anadolu Lisesi
                            <dd>- Matematik Fen (2013-2017)</dd>
                        </dt>--%>
                    </dl>
                </div>
            </section>
            <section id="skills">
                <div class="container">
                    <h3>Yetenekler</h3>
                    <ul>                        
                            <asp:Repeater ID="Repeater5" runat="server">
                                <ItemTemplate>
                                    <li><%# Eval("Yetenek") %></li>   
                                </ItemTemplate>
                            </asp:Repeater>                                             
                    </ul>
                </div>
            </section>
            <section id="experiments">
                <div class="container">
                    <h3>Deneyimler</h3>
                    <dl>
                        <dt>
                            <asp:Repeater ID="Repeater6" runat="server">
                                <ItemTemplate>
                                    <i class="fa-solid fa-briefcase"></i> <%# Eval("Deneyim") %></i>
                                    <dd>- <%# Eval("Deneyimayrinti") %></dd>
                                </ItemTemplate>
                            </asp:Repeater>
                        </dt>
                    </dl>
                </div>
            </section>
            <section id="certificate">
                <div class="container">
                    <h3>Sertifikalar</h3>
                    <dl>
                        <dt>
                            <asp:Repeater ID="Repeater7" runat="server">
                                <ItemTemplate>
                                    <i class="fa-solid fa-certificate"></i> <%# Eval("Sertifika") %></i> 
                                    <dd>- <%# Eval("Sertifikaayrinti") %></dd>
                                </ItemTemplate>
                            </asp:Repeater>
                        </dt>
                    </dl>
                </div>
            </section>
            <section id="language">
                <div class="container">
                    <h3>Yabancı Dil</h3>
                    <dl>
                        <dt>
                            <asp:Repeater ID="Repeater8" runat="server">
                                <ItemTemplate>
                                     <li><%# Eval("Yabancidil") %></li>
                                </ItemTemplate>
                            </asp:Repeater> 
                        </dt>

                         
                    </dl>
                </div>
            </section>
            <section id="contact">
                <div class="container">
                    <h3>İletişim</h3>        
                    <form action="#" method="post" runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="İsim"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Soyisim"></asp:TextBox>                        
                        <br><br>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Email" Width="528.4"></asp:TextBox>
                        <br><br>
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" Width="528.4"></asp:TextBox>
                        <br><br>
                        <asp:TextBox ID="TextBox5" runat="server" placeholder=" Mesaj" TextMode="MultiLine" Height="326" Width="528.4"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Gönder" BackColor="#8D90E4" ForeColor="White" Font-Bold="True"  Height="40" Width="80" OnClick="Button1_Click1" />                        
                    </form>                    
                </div>
            </section>
        </div>
    </div>
</body>
</html>
