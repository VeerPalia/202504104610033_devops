using System.ComponentModel.DataAnnotations;

namespace BMICalculator.Models
{
    public class BMIModel
    {
        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public double HeightCm { get; set; }

        [Required]
        public double WeightKg { get; set; }

        public double BMI => WeightKg / Math.Pow(HeightCm / 100, 2);

        public string Classification
        {
            get
            {
                if (BMI < 16) return "Severe Thinness";
                if (BMI < 17) return "Moderate Thinness";
                if (BMI < 18.5) return "Mild Thinness";
                if (BMI < 25) return "Normal";
                if (BMI < 30) return "Overweight";
                if (BMI < 35) return "Obese Class I";
                if (BMI < 40) return "Obese Class II";
                return "Obese Class III";
            }
        }
    }
}
