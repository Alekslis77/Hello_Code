using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassSample
{
    // Использован модификатор public,
    // чтобы класс был виден за пределами сборки
    public class Vertex3d
    {
        //Поля
        private double _x;
        private double _y;
        private double _z;

        // Свойства
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }
        // Метод
        public void SetToOrigin()
        {
            X = Y = Z = 0.0;
        }
    }
}