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
                Btn.Text = "";
                Occupied = false;
                foreach(PlayField field in b.PlayFields)
                {
                    field.Btn.Enabled = true;
                    field.Btn.BackColor = Color.Green;
                }
                Btn.Enabled = false;
                Btn.BackColor = Color.Red;
            }
            else
            {
                Played(b);
            }
        }
    }
}
