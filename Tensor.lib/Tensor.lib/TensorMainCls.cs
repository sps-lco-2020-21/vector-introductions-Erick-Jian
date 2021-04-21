using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tensor.lib
{
    #region Some Notes on Tensor
    // https://www.kdnuggets.com/2018/05/wtf-tensor.html
    // Bond: https://drive.google.com/file/d/1_5lmXQSlsJWrPigZJ-NwxCUrYf2axTyL/view
    abstract public class Tensor
    {

    }
    abstract public class Matrix : Tensor
    {

    }
    public class Vector : Matrix        // aka. Vectors, 1D martices, etc.
    {
        protected List<double> _vector;
        public Vector(List<double> VECTOR)
        {
            _vector = VECTOR;
            throw new Exception("InputTypeException");
        }

        protected List<double> GetVectorItself
            { get { return _vector; } }

        public double ComputeMagnitude()
        {

            }

        public double ComputeAngle()        // to the POSITIVE x axis
        {

        }
        
        public string CompareMagnitude(Vector v2)
        {

        }

        public bool AreEqual(Vector vII)
        {

        }


    }
}
