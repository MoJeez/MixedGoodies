using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Statements.Do_While
{
    class Eksempel_1
    {
        private void main()
        {
            //Do-While er en looping statement.
            //Den kører koden 1 gang, og hvis dens VARIABEL er TRUE derefter, vil den loope
            Boolean MyBoolean = true;
            do
            {
                //Den her vil loope indtil MyBoolean bliver sat til False - Denne kan ske via en if statement?
            } 
            while (MyBoolean); // Samme regler mht. operatorer gælder her, som med IF.
        }
    }
}
