using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Python_Model_Demonstration.Models
{
    public class FetalHealthInput
    {
        public int bpm { get; set; }
        public double acceleration { get; set; }
        public double fetal_movement { get; set; }
        public double uterine_contractors { get; set; }
        public double light_decelerations { get; set; }
        public double severe_decelerations { get; set; }
        public double prolonged_decelerations { get; set; }
        public int abnormal_st_variability { get; set; }
        public double mean_st_variability { get; set; }
        public int percent_lt_variability { get; set; }
        public double mean_lt_variability { get; set; }
        public int histo_width { get; set; }
        public int histo_min { get; set; }
        public int histo_max { get; set; }
        public int histo_peaks { get; set; }
        public int no_of_zeroes { get; set; }
        public int histo_mode { get; set; }
        public int histo_mean { get; set; }
        public int histo_median { get; set; }
        public int histo_variance { get; set; }
        public int histo_tendency { get; set; }

        public override string ToString()
        {
            return $"{bpm}+{acceleration}+{fetal_movement}+{uterine_contractors}+{light_decelerations}" +
                $"+{severe_decelerations}+{prolonged_decelerations}+{abnormal_st_variability}+{mean_st_variability}" +
                $"+{percent_lt_variability}+{mean_lt_variability}+{histo_width}+{histo_min}+{histo_max}+{histo_peaks}" +
                $"+{no_of_zeroes}+{histo_mode}+{histo_mean}+{histo_median}+{histo_variance}+{histo_tendency}";
        }

    }
}
