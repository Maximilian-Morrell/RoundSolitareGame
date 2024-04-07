using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundSolitareGame.Classes
{
    internal abstract class PlayField
    {
        #region Variables
        private string _ID, _Type;
        private bool _Occupied;
        private Button _Btn;
        public List<PlayField> _AcceptableFields, _NotAccaptableFields, _CheckFields;
        public Button Btn
        {
            get
            {
                return _Btn;
            }
            set
            {
                _Btn = value;
            }
        }
        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                if(value == PlayFieldTypes.Normal || value == PlayFieldTypes.Outside || value == PlayFieldTypes.Center)
                {
                    _Type = value;
                }
            }
        }

        public bool Occupied
        {
            get
            {
                return _Occupied;
            }
            set
            {
                _Occupied = value;
            }
        }
        // Empty Constructor just to be safe
        public PlayField()
        {

        }
        // Creating PlayField with Default Occupied set to true.
        public PlayField(string ID,  string Type)
        {
            this.ID = ID;
            this.Type = Type;
            this.Occupied = true;
        }
        // Completly Customised 
        public PlayField(string ID, string Type, bool Occupied, Button Btn)
        {
            this.ID = ID;
            this.Type = Type;
            this.Occupied= Occupied;
            this.Btn = Btn;
            this._AcceptableFields = new List<PlayField>();
            this._NotAccaptableFields = new List<PlayField>();
            this._CheckFields = new List<PlayField>();
        }

        public void GetSelectableFields(Board b)
        {
            _AcceptableFields.Clear();
            _NotAccaptableFields.Clear();
            _CheckFields.Clear();
            int IDInt = Convert.ToInt32(this.ID);

            int SelectableUpperID = -1;
            int SelectableLowerID = -1;
            int SelectableLeftID = -1;
            int SelectableRightID = -1;
            int UpCheckID = -1;
            int DownCheckID = -1;
            int LeftCheckID = -1;
            int RightCheckID = -1;
            
            switch(IDInt)
            {
                case 0:
                    SelectableLowerID = 8;
                    DownCheckID = 3;
                    SelectableRightID = 2;
                    RightCheckID = 1;
                    break;
                case 1:
                    SelectableLowerID = 9;
                    DownCheckID = 4;
                    break;
                case 2:
                    SelectableLowerID = 10;
                    DownCheckID = 5;
                    SelectableLeftID = 2;
                    LeftCheckID = 1;
                    break;
                case 3:
                    SelectableLowerID = 15;
                    DownCheckID = 8;
                    SelectableRightID = 5;
                    RightCheckID = 5;
                    break;
                case 4:
                    SelectableLowerID = 16;
                    DownCheckID = 9;
                    break;
                case 5:
                    SelectableLowerID = 17;
                    DownCheckID = 10;
                    SelectableLeftID = 3;
                    LeftCheckID = 4;
                    break;
                case 6:
                    SelectableLowerID = 20;
                    DownCheckID = 13;
                    SelectableRightID = 8;
                    RightCheckID = 7;
                    break;
                case 7:
                    SelectableLowerID = 21;
                    DownCheckID = 14;
                    SelectableRightID = 9;
                    RightCheckID = 8;
                    break;
                case 8:
                    SelectableUpperID = 0;
                    UpCheckID = 3;
                    SelectableLowerID = 22;
                    DownCheckID = 15;
                    SelectableLeftID = 6;
                    LeftCheckID = 7;
                    SelectableRightID = 10;
                    RightCheckID = 9;
                    break;
                case 9:
                    SelectableUpperID = 1;
                    UpCheckID = 1;
                    SelectableLowerID = 23;
                    DownCheckID = 16;
                    SelectableLeftID = 7;
                    LeftCheckID = 8;
                    SelectableRightID = 11;
                    RightCheckID = 10;
                    break;
                case 10:
                    SelectableUpperID = 2;
                    UpCheckID = 5;
                    SelectableLowerID = 24;
                    DownCheckID = 17;
                    SelectableLeftID = 8;
                    LeftCheckID = 9;
                    SelectableRightID = 12;
                    RightCheckID = 11;
                    break;
                case 11:
                    SelectableLowerID = 25;
                    DownCheckID = 18;
                    SelectableLeftID = 9;
                    LeftCheckID = 10;
                    break;
                case 12:
                    SelectableLowerID = 26;
                    DownCheckID = 19;
                    SelectableLeftID = 10;
                    LeftCheckID = 11;
                    break;
                case 13:
                    SelectableRightID = 15;
                    RightCheckID = 14;
                    break;
                case 14:
                    SelectableRightID = 16;
                    RightCheckID = 15;
                    break;
                case 15:
                    SelectableUpperID = 3;
                    UpCheckID = 8;
                    SelectableLowerID = 27;
                    DownCheckID = 15;
                    SelectableLeftID = 13;
                    LeftCheckID = 14;
                    SelectableRightID = 17;
                    RightCheckID = 16;
                    break;
                case 16:
                    SelectableUpperID = 4;
                    UpCheckID = 9;
                    SelectableLowerID = 28;
                    DownCheckID = 23;
                    SelectableLeftID = 14;
                    LeftCheckID = 15;
                    SelectableRightID = 18;
                    RightCheckID = 17;
                    break;
                case 17:
                    SelectableUpperID = 5;
                    UpCheckID = 10;
                    SelectableLowerID = 29;
                    DownCheckID = 24;
                    SelectableLeftID = 15;
                    LeftCheckID = 16;
                    SelectableRightID = 19;
                    RightCheckID = 18;
                    break;
                case 18:
                    SelectableLeftID = 16;
                    LeftCheckID = 17;
                    break;
                case 19:
                    SelectableLeftID = 17;
                    LeftCheckID = 18;
                    break;
                case 20:
                    SelectableUpperID = 6;
                    UpCheckID = 13;
                    SelectableRightID = 22;
                    RightCheckID = 21;
                    break;
                case 21:
                    SelectableUpperID = 7;
                    UpCheckID = 14;
                    SelectableRightID = 23;
                    RightCheckID = 22;
                    break;
                case 22:
                    SelectableUpperID = 8;
                    UpCheckID = 15;
                    SelectableLowerID = 30;
                    DownCheckID = 27;
                    SelectableLeftID = 20;
                    LeftCheckID = 21;
                    SelectableRightID = 24;
                    RightCheckID = 23;
                    break;
                case 23:
                    SelectableUpperID = 9;
                    UpCheckID = 16;
                    SelectableLowerID = 31;
                    DownCheckID = 28;
                    SelectableLeftID = 21;
                    LeftCheckID = 22;
                    SelectableRightID = 25;
                    RightCheckID = 24;
                    break;
                case 24:
                    SelectableUpperID = 10;
                    UpCheckID = 10;
                    SelectableLowerID = 32;
                    DownCheckID = 29;
                    SelectableLeftID = 22;
                    LeftCheckID = 25;
                    SelectableRightID = 26;
                    RightCheckID = 25;
                    break;
                case 25:
                    SelectableUpperID = 11;
                    UpCheckID = 18;
                    SelectableLeftID = 23;
                    LeftCheckID = 24;
                    break;
                case 26:
                    SelectableUpperID = 12;
                    UpCheckID = 19;
                    SelectableLeftID = 24;
                    LeftCheckID = 25;
                    break;
                case 27:
                    SelectableUpperID = 15;
                    UpCheckID = 22;
                    SelectableRightID = 29;
                    RightCheckID = 28;
                    break;
                case 28:
                    SelectableUpperID = 16;
                    UpCheckID = 23;
                    break;
                case 29:
                    SelectableUpperID = 17;
                    UpCheckID = 24;
                    SelectableLeftID = 27;
                    LeftCheckID = 28;
                    break;
                case 30:
                    SelectableUpperID = 22;
                    UpCheckID = 27;
                    SelectableRightID = 32;
                    RightCheckID = 31;
                    break;
                case 31:
                    SelectableUpperID = 23;
                    UpCheckID = 28;
                    break;
                case 32:
                    SelectableUpperID = 24;
                    UpCheckID = 29;
                    SelectableLeftID = 30;
                    LeftCheckID = 31;
                    break;
                default:
                    break;
            }
            if(SelectableLeftID != -1 && !b.PlayFields[SelectableLeftID].Occupied && b.PlayFields[LeftCheckID].Occupied)
            {
                this._AcceptableFields.Add(b.PlayFields[SelectableLeftID]);
                this._CheckFields.Add(b.PlayFields[LeftCheckID]);
            }

            if(SelectableRightID != -1 && !b.PlayFields[SelectableRightID].Occupied && b.PlayFields[RightCheckID].Occupied)
            {
                this._AcceptableFields.Add(b.PlayFields[SelectableRightID]);
                this._CheckFields.Add(b.PlayFields[RightCheckID]);
            }
            
            if(SelectableLowerID != -1 && !b.PlayFields[SelectableLowerID].Occupied && b.PlayFields[DownCheckID].Occupied)
            {
                this._AcceptableFields.Add(b.PlayFields[SelectableLowerID]);
                this._CheckFields.Add(b.PlayFields[DownCheckID]);
            }

            if(SelectableUpperID != -1 && !b.PlayFields[SelectableUpperID].Occupied && b.PlayFields[UpCheckID].Occupied)
            {
                this._AcceptableFields.Add(b.PlayFields[SelectableUpperID]);
                this._CheckFields.Add(b.PlayFields[UpCheckID]);
            }

            foreach(PlayField field in b.PlayFields)
            {
                if(!this._AcceptableFields.Contains(field))
                {
                    this._NotAccaptableFields.Add(field);
                }
            }

        }

        public void Played(Board b)
        {
            GetSelectableFields(b);
            if(!this.Occupied && b.SelectedPlayField != null)
            {
                // Case if Player wants to move a marble to a empty field
                this.Btn.Text = "O";
                this.Occupied = true;
                b.SelectedPlayField.Occupied = false;
                b.SelectedPlayField.Btn.Text = "";

                b.Marbels++;

                int IntID = Convert.ToInt32(ID);
                int IntID2 = Convert.ToInt32(b.SelectedPlayField.ID);
                b.PlayFields[IntID2] = b.SelectedPlayField;
                b.SelectedPlayField = null;
                if (IntID2 == IntID - 2)
                {
                    // Marbel moved Right
                    b.PlayFields[IntID -1].Occupied = false;
                    b.PlayFields[IntID - 1].Btn.Text = "";
                }
                else if(IntID2 == IntID + 2)
                {
                    // Marbel moved left
                    b.PlayFields[IntID + 1].Occupied = false;
                    b.PlayFields[IntID + 1].Btn.Text = "";
                }
                else if(IntID2 == IntID - 8)
                {
                    // Marbel moved down
                    b.PlayFields[IntID - 5].Occupied = false;
                    b.PlayFields[IntID - 5].Btn.Text = "";
                }
                else if(IntID2 == IntID + 8)
                {
                    // Marbel moved up
                    b.PlayFields[IntID + 5].Occupied = false;
                    b.PlayFields[IntID + 5].Btn.Text = "";
                }
                else if(IntID2 == IntID - 14)
                {
                    // Marbel moved down
                    b.PlayFields[IntID + 7].Occupied = false;
                    b.PlayFields[IntID + 7].Btn.Text = "";
                }
                else if(IntID2 == IntID + 14)
                {
                    // Marbel moved up
                    b.PlayFields[IntID - 7].Occupied = false;
                    b.PlayFields[IntID - 7].Btn.Text = "";
                }
                else if(IntID2 == IntID - 12)
                {
                    // Marbel moved down
                    b.PlayFields[IntID - 5].Occupied = false;
                    b.PlayFields[IntID - 5].Btn.Text = "";
                }
                else if(IntID2 == IntID + 12)
                {
                    // Marbel moved up
                    b.PlayFields[IntID + 7].Occupied = false;
                    b.PlayFields[IntID + 7].Btn.Text = "";
                }

                foreach(PlayField field in b.PlayFields)
                {
                    if(field.Occupied)
                    {
                        field.GetSelectableFields(b);
                        if(field._AcceptableFields.Count != 0)
                        {
                            field.Btn.Enabled = true;
                            field.Btn.BackColor = Color.Green;
                        }
                        else
                        {
                            field.Btn.Enabled = false;
                            field.Btn.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        field.Btn.Enabled = false;
                        field.Btn.BackColor = Color.Red;
                    }
                }

            } 
            else if(this.Occupied && b.SelectedPlayField == null)
            {
                // Case if Player wants to start to move a marble
                b.SelectedPlayField = this;
                foreach(PlayField field in this._NotAccaptableFields)
                {
                    field.Btn.Enabled = false;
                    field.Btn.BackColor = Color.Red;
                }
                foreach(PlayField field in this._AcceptableFields)
                {
                    field.Btn.Enabled = true;
                    field.Btn.BackColor = Color.Green;
                }

            }
        }

        #endregion
        #region Methods
        public abstract void PlayFieldAction(Board b);
        #endregion
    }
}
