using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Statements.IF_Statements
{
    class Eksempel_2
    {
        private void main()
        {
            //IF Operator Eksempel 2
            int myInt = 32;
            int myNewInt = 64;

            if (myInt > 20) // Bliver false, fordi MyInt er IKKE større end 20
            { }
            if (myInt < 20) // Bliver true, fordi MyInt ER større end 20
            {  }
            // X == Y .. X is EQUAL to Y
            // X != Y .. X i NOT EQUAL to Y
            // X > Y .. X is BIGGER then Y
            // X < Y .. X is SMALLER then Y
            // X >= Y .. X is BIGGER or EQUAL to Y
            // X <= Y .. X is SMALLER or EQUAL to Y
            // X == Y & Z == X .. X EQUALS to Y AND Z EQUALS to X
            // X == Y || Z == X .. X EQUALS to Y OR Z EQUALS to X

            if (myInt == 32 & myNewInt == 64) // bliver true, fordi at MyInt er 32 OG MyNewInt er 64.
            { }
        }
    }
}
