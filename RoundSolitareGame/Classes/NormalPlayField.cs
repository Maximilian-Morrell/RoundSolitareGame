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
        public NormalPlayField(string ID) : base(ID, PlayFieldTypes.Normal, true)
        {

        }

        public override void PlayFieldAction()
        {
            MessageBox.Show("Normal Action");
        }
    }
}
