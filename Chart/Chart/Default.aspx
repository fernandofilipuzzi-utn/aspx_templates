
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication18._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

        <h1>Chart.js Integration in Web Forms</h1>
        <asp:Button ID="btn" OnClick="btn_Click" Text="actualizar" runat="server"/>

        <canvas id="myChart" width="400" height="200"></canvas>

        <script>
            const chartData = <%= ChartDataJson %>;

            
            const config = {
                type: 'line',
                data: chartData,
                options: {
                    plugins: {
                        title: {
                            display: true,
                            text: 'Chart.js Stacked Line/Bar Chart'
                        }
                    },
                    scales: {
                        y: {
                            stacked: true
                        }
                    }
                }
            };

            const myChart = new Chart(
                document.getElementById('myChart'),
                config
            );
        </script>

</asp:Content>