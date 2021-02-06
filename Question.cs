using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb
{
    public class Question
    {
        public string subject { get; set; }
        public string question { get; set; }
        public IEnumerable<Answer> answers { get; set; }
    }

    public class Answer
    {
        public string author { get; set; }
        public string answer { get; set; }
    }
}
