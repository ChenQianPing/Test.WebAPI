using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WebAPI
{
    public class CreateObjectiveQuestionsInput
    {
        public string QuestionsId { get; set; }
        public string ExamCourseId { get; set; }
        public string QuestionsName { get; set; }
        public string FrameId { get; set; }
        public int SerialNo { get; set; }
        public int PageNo { get; set; }
        public int MarkType { get; set; }
        public string Answers { get; set; }
        public decimal FullScore { get; set; }
        public int IsFrame { get; set; }
        public int ValueType { get; set; }
    }
}
