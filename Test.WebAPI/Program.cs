using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test.WebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://192.168.2.100:9001";
            var postUrl = "/api/tpl/CreateObjectiveQuestions";


            var oq1 = new CreateObjectiveQuestionsInput
            {
                QuestionsId = Guid.NewGuid().ToString("N").ToUpper(),
                ExamCourseId = "3208075F3F8A4BD19032B41331A1C133",
                QuestionsName = "QuestionsName",
                FrameId = "A707703EEEA44C7FB4D0059077DFB247",
                SerialNo = 0,
                PageNo = 1,
                MarkType = 1,
                Answers = "A",
                FullScore = (decimal) 1.0,
                IsFrame = 0,
                ValueType = 0
            };

            var oq2 = new CreateObjectiveQuestionsInput
            {
                QuestionsId = Guid.NewGuid().ToString("N").ToUpper(),
                ExamCourseId = "3208075F3F8A4BD19032B41331A1C133",
                QuestionsName = "QuestionsName",
                FrameId = "A707703EEEA44C7FB4D0059077DFB247",
                SerialNo = 0,
                PageNo = 1,
                MarkType = 1,
                Answers = "A",
                FullScore = (decimal) 1.0,
                IsFrame = 0,
                ValueType = 0
            };

            var lstOq = new List<CreateObjectiveQuestionsInput> {oq1, oq2};

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(lstOq), System.Text.Encoding.UTF8, "application/json");

            var accessToken = @"CO_AMMxj63WXlDOLUmo3GRolqryRqN8o_UXP_AQnDk3qsvCWo_CaW1OpVWgqM0y
                EcWNSkRv_9WIfFt_1pDF8AA-Uvlpm1mmKC7DKyWD2t_TVc-80pb8gSG_C1dgq4ExWw-h_L7A-BhXKr7a
                jUfp6Hs6DzZGLC4JqJWWTUH9ELEZkjJhGbH7xcWFzEbQrPH349FN5eiAUxQIFkcmIcWUzmzin2At3_a3
                P__Ttw4jF6g-R8ewpEqgR2JZ6d5FwmIpUxpmcdw8BzTJUmnuu_tH_cuSm2nuSAb3mwQlrLjgifnR0NqO
                rMArOgmYMv3OI9SdR";

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseAddress);

                // 两种写法都支持；
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var result = client.PostAsync(postUrl, httpContent).Result;

                var str = result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result.StatusCode);
                Console.WriteLine(str);
                Console.ReadLine();
            }


        }

    }
}
