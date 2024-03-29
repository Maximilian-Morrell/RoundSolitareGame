using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundSolitareGame.Classes
{
    internal abstract class PlayField
    {
        #region Variables
        private string _ID, _Type;
        private bool _Occupied;
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
        public PlayField(string ID, string Type, bool Occupied)
        {
            this.ID = ID;
            this.Type = Type;
            this.Occupied= Occupied;
        }
        #endregion
        #region Methods
        public abstract void PlayFieldAction();
        #endregion
    }
}
