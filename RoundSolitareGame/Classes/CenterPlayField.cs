using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundSolitareGame.Classes
{
    internal class CenterPlayField : PlayField
    {
        public CenterPlayField(string ID, Button Btn) : base(ID, PlayFieldTypes.Center, true, Btn)
        {

        }

        public override void PlayFieldAction(Board b)
        {
            if(!b.Started)
            {
                b.StartRound();
            }
            else
            {

            }
        }
    }
}
