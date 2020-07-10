using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace assignment4
{
    class YuHsuanHuangJson
    {
        private string json;

        public YuHsuanHuangJson(string originalString)
        {
            json = originalString;
        }

        public Student JSONDeserialization()
        {
            Student student = new Student();

            student = JsonConvert.DeserializeObject<Student>(json);

            return student;
        }
    }
}
