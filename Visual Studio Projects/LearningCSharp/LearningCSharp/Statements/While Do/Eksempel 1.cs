using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Statements.While_Do
{
    class Eksempel_1
    {
        private void main()
        {
            // While Do er en looping statement
            // Den kører KUN hvis dens variabel er true.
            Boolean MyBooleanTrue = true;
            Boolean MyBooleanFalse = false;
            while (MyBooleanTrue)
            {
                //Den her looper indtil MyBooleanTrue bliver sat til false
            }
            while (MyBooleanFalse)
            {
                //Den her Looper IKKE, fordi mybooleanfalse er false.
            }
            //Samme regler med operatorer gælder, som med IF's Eksempelvis:
            while (!MyBooleanTrue)
            {
                //Den her Looper IKKE, fordi mybooleanfalse er false.
            }
            while (!MyBooleanFalse)
            {
                //Den her looper indtil MyBooleanTrue bliver sat til false    
            }
        }
    }
}
