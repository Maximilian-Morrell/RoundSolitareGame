using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundSolitareGame.Classes
{
    internal class CenterPlayField : PlayField
    {
        public CenterPlayField(string ID) : base(ID, PlayFieldTypes.Center, true)
        {

        }

        public override void PlayFieldAction()
        {
            MessageBox.Show("Center Action");
        }
    }
}
