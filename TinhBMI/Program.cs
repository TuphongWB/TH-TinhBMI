using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chiều cao (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cân nặng (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            Console.WriteLine("Chỉ số BMI của bạn là: {0}", bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("Bạn đang gầy");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Bạn có trọng lượng bình thường");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Bạn đang bị thừa cân");
            }
            else
            {
                Console.WriteLine("Bạn đang bị béo phì");
            }

            Console.ReadLine();
        }
    }
}
