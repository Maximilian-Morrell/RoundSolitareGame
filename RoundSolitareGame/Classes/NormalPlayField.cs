using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundSolitareGame.Classes
{
    internal class NormalPlayField : PlayField
    {
        public NormalPlayField(string ID, Button Btn) : base(ID, PlayFieldTypes.Normal, true, Btn)
        {

        }

        public override void PlayFieldAction(Board b)
        {
            Played(b);
        }
    }
}
