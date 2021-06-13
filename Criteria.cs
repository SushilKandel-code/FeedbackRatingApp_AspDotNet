using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackRatingApplicaiton
{
    class Criteria
    {
        public string CriteriaType { get; set; }

        public Criteria (string criteriaType)
        {
           CriteriaType = criteriaType;
        }


        // converts customer info into CSV formatted String
        public string ToCSVString()
        {
            string CSV = string.Format("{0}\n", CriteriaType);
            return CSV;
        }

       // override tostring method and customize it according to our needs
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
