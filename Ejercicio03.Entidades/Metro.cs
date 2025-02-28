﻿namespace Ejercicio03.Entidades
{
    public class Metro
    {
        private float longitud;
        public float GetLongitud => longitud;
        public Metro(float longitud = 5)
        {
            this.longitud = longitud;
        }
        public static implicit operator float(Metro metro)
        {
            return metro.longitud;
        }
        public static bool operator ==(Metro m1, Metro m2)
        {
            return m1.longitud == m2.longitud;
        }
        public static bool operator !=(Metro m1, Metro m2)
        {
            return !(m1 == m2);
        }
        public static explicit operator Metro(Yarda ya)
        {
            //Uso el int porque de otra manera me da error como si fuera double
            return new Metro((int)(ya.GetLongitud / 1.09361));
        }
        public static bool operator ==(Metro m, Yarda y)
        {
            return m == (Metro)y;
        }
        public static bool operator !=(Metro m, Yarda y)
        {
            return !(m == (Metro)y);
        }
        public static Metro operator +(Metro m1, Metro m2)
        {
            return new Metro(m1.longitud + m2.longitud);
        }
        public static Metro operator +(Metro m1, Yarda y)
        {
            return m1 + (Metro)y;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Metro metro)) return false;
            return this.Equals(metro);
        }

        public override int GetHashCode()
        {
            return this.longitud.GetHashCode();
        }
    }
}
