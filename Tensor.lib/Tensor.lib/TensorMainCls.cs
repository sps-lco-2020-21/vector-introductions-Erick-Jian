using System;
using System.Collections.Generic;   // IEnumerable is there
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TensorUnitTest;

namespace Tensor.lib
{
    #region Some Notes on Tensor
    // https://www.kdnuggets.com/2018/05/wtf-tensor.html
    // Bond: https://drive.google.com/file/d/1_5lmXQSlsJWrPigZJ-NwxCUrYf2axTyL/view

    // IEquatable: same type for each component other wise can't used -- all key in dictionary must be key type ??
    // IEnumerable: (implicit) pass in a list, not actively taking in a list -- taking value only; UNI-Directional
    //      e.g. vector object take in a list, can't run foreach " item in vector object"
    //      e.g. I can loop over the content

    // IEnumerator: (more explicit) yield -- going through collection each time, return value
    //                  next time come back to the last returned position, get next one
    //              allow   BI-Dir
    public IEnumerartor<T> GetEnumerartor()
        {
            foreach (T item in _collection)
               yield return item;
        }
    #endregion

    abstract public class Tensor
    {

    }
    abstract public class Matrix : Tensor
    {

    }
    public class Vector : Matrix        // aka. Vectors, 1D martices, etc.
    {
        readonly List<double> _vectorlist;             // only change within constructor
        public Vector(IEnumerable<double> VECTOR)      // Defensive programming: pass in IEnumerable<T> NOT List<T>
        {
            _vectorlist = VECTOR.ToList();
            throw new Exception("InputTypeException");
        }

        protected List<double> GetVectorItself
            { get { return _vectorlist; } }

        public double ComputeMagnitude()
        {
            double _magnitude = 0;
            foreach (double item in _vectorlist)
            {
                _magnitude += Math.Pow(item, 2);
            }
            return _magnitude;
        }

        public double ComputeScalarProduct(Vector other)
        {
            double _DotProduct = 0;
            
            if (this.GetVectorItself.Count != other.GetVectorItself.Count)
            {
                Console.WriteLine("bruh");
                throw new Exception("VectorMultiplicationException - press [1]:stop [0]:add 0s for the short vector");
                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        
                    }
                    if (Console.ReadKey().Key == ConsoleKey.D0)
                    {
                        
                    }
            }
            for (double count = 0; count < o )
            {
                _DotProduct += other.GetVectorItself * 
            }
            return _DotProduct;
        }

        public double ComputeAngle()        // to the POSITIVE x axis
        {
            // angle between the vector and 
        }

        public double ComputeVectorProduct(Vector vII)
        {

        }
        
        public string CompareMagnitude(Vector vII)  // take the object property straightaway
        {

        }

        public bool CompareDimension(Vector vII)
        {

        }
    }
}
