using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber
{
    public class InteractionFactory
    {

        public static IInteractionType CreateInteractionTypeSpecialised( InteractionTypeEnum interactionType)
        {
            IInteractionType rc = null;

            switch( interactionType)
            {
                case InteractionTypeEnum.ConsoleUser:
                    rc = new UserConsoleInteraction();
                    break;
                default:
                    rc = new BaseInteraction();
                    break;
            }

            return rc;
        }
    }
}
