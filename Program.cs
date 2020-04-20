using System;

namespace HomeWork18._04
{
    class programm
    {
        static T Pluss<T>(T firstEl,T secondEl)
        {
            T result = (dynamic)firstEl + (dynamic)secondEl;
            return result;
        }
        static T Minuss<T>(T firstEl,T secondEl)
        {
            T result = (dynamic)firstEl - (dynamic)secondEl;
            return result;
        }
        static T Multiple<T>(T firstEl, T secondEl)
        {
            T result = (dynamic)firstEl * (dynamic)secondEl;
            return result;
        }
        static T Delete<T>(T firstEl, T secondEl)
        {
            T result;
            if(secondEl == (dynamic)0)
            {
                result = (dynamic)0;
                return result;
            }
            else
            {
                result = (dynamic)firstEl / (dynamic)secondEl;
                return result;
            }
        }
        static void Main()
        {

        }
    }
}