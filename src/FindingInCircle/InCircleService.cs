using System;

namespace FindingInCircle
{
    public class InCircleService : IInCircleService
    {
        /// <summary>
        /// Определяет нахождение точки в окружности.
        /// </summary>
        /// <param name="x">Координата центра окружности по X</param>
        /// <param name="y">Координата центра окружности по Y</param>
        /// <param name="radius">Радиус</param>
        /// <param name="d">Координата точки по X</param>
        /// <param name="o">Координата точки по Y</param>
        public bool Affiliation (int x, int y, int radius, int d, int o)
        {
            if (Math.Pow(x - d, 2) +
                Math.Pow(y - o, 2) <=
                Math.Pow(radius, 2))
                return true;
            return false;
        }
    }
}
