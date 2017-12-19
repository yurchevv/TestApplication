using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class Triangle
    {
        #region Fields
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private double halfPerimeter;
        #endregion

        public double FirstSide
        {
            set
            {
                _firstSide = value;
            }
            
            get
            {
                return _firstSide;
            }
        }

        public double SecondSide
        {
            set
            {
                _secondSide = value;
            }

            get
            {
                return _secondSide;
            }
        }

        public double ThirdSide
        {
            set
            {
                _thirdSide = value;
            }

            get
            {
                return _thirdSide;
            }
        }

        //Method calculating triangle's area
        public double? GetTriangleArea()
        {
            double halfPerimeter = GetHalfPerimeter();

            if (halfPerimeter != 0)
            {
                double area = Math.Sqrt((halfPerimeter) * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) * (halfPerimeter - _thirdSide));
            }

            return null;
        }

        //Method calculating triangle's half-perimeter
        public double GetHalfPerimeter()
        {
            if ((_firstSide < 0) | (_secondSide < 0) | (_thirdSide < 0))
            {
                return 0;
            }

            halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

            return halfPerimeter;
        }
    }
}
