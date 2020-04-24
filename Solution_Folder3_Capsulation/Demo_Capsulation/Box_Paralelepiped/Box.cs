using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Paralelepiped
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }

        //С параметър за намиране на обем
        //public double ObemV(double a, double b, double h)
        //{
        //    return lenght * width * height;

        //}

        //Валидация за дължина
        public double Lenght
        {
            get { return lenght; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }


        public double ObemV()
        {
            return lenght * width * height;

        }

        public double Okolna()
        {
            return 2 * lenght * height + 2 * width * height;
        }

        public double PalnaPovarhnina()
        {
            return 2 * lenght * height + 2 * width * height+2*width*lenght;
            
        }
    }
}
