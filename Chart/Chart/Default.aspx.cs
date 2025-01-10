using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace WebApplication18
{
    public partial class _Default : Page
    {
        protected string ChartDataJson;

        protected void Page_Load(object sender, EventArgs e)
        {
            int cantidad = 7;
            int desde = 0;
            int hasta = 100;

            var chartData = new
            {
                labels = new string[] { "January", "February", "March", "April", "May", "June", "July" },  
                datasets = new object[]
                {
                    new {
                        label = "Dataset 1",
                        data = GenerateRandomNumbers(cantidad, desde, hasta),
                        borderColor = "rgba(255, 99, 132, 1)",
                        backgroundColor = "rgba(255, 99, 132, 0.5)",
                        stack = "combined",
                        type = "bar"
                    },
                    new {
                        label = "Dataset 2",
                        data = GenerateRandomNumbers(cantidad, desde, hasta),
                        borderColor = "rgba(54, 162, 235, 1)",
                        backgroundColor = "rgba(54, 162, 235, 0.5)",
                        stack = "combined"
                    }
                }
            };

            var serializer = new JavaScriptSerializer();
            ChartDataJson = serializer.Serialize(chartData);
        }

        private int[] GenerateRandomNumbers(int count, int min, int max)
        {
            var random = new Random();
            var numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }
            return numbers;
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            var chartData = new
            {
                labels = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio" }, 
                datasets = new object[]
                {
                    new {
                        label = "Dataset 1",
                        data = GenerateRandomNumbers(7, 0, 100),
                        borderColor = "rgba(255, 99, 132, 1)",
                        backgroundColor = "rgba(255, 99, 132, 0.5)",
                        stack = "combined",
                        type = "bar"
                    },
                    new {
                        label = "Dataset 2",
                        data = GenerateRandomNumbers(7, 0, 100),
                        borderColor = "rgba(54, 162, 235, 1)",
                        backgroundColor = "rgba(54, 32, 235, 0.5)",
                        stack = "combined"
                    }
                }
            };

            var serializer = new JavaScriptSerializer();
            ChartDataJson = serializer.Serialize(chartData);
        }
    }
}
