using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Statements.IF_Statements
{
    class Eksempel_1
    {
        static void Main()
        {
            //IF Statements tjekker efter TRUE
            //Dette kan angives ved 'Operators'

            //Eksempel 1;
            //<Operator> <Variable Navn> = <Value>
            Boolean MyBoolean = true;
            if (MyBoolean)
            {
                //Denne sektion vil altid blive ramt
                //Medmindre at MyBoolen bliver sat til false, før IF statementen bliver ramt.
            }
            else if (!MyBoolean)
            {
                //Denne sektion tjekker efter det modsatte af true. Læg mærke til '!' ude foran MyBoolean
                //! betyder mere eller mindre, "modsat".. Så !MyBoolean = Er denne false? .. Istedet for standarden som er.. Er denne true?
            }
            else
            {
                //Denne sektion bliver ramt, Hvis INGEN af de andre sektioner rammes. DVS. Hvis MyBoolean hverken er true, eller false.
            }
        }
    }
}
