﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RoundSolitareGame.Classes
{
    internal class Board
    {
        #region Variables
        private string _Name, _Description;
        private int _Size, _SideRows, _SideLines, _UpDownLines, _UpDownRows, _MiddleSize;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }

        public int Size
        {
            get
            {
                return _Size;
            }
            set
            {
                if(value > 0)
                {
                    _Size = value;
                }
            }
        }

        public int SideRows
        {
            get
            {
                return _SideRows;
            }
            set
            {
                if(value > 1) 
                {
                    _SideRows = value;
                }
            }
        }

        public int SideLines
        {
            get
            {
                return _SideLines;
            }
            set
            {
                if(value > 2)
                {
                    _SideLines = value;
                }
            }
        }

        public int UpDownLines
        {
            get
            {
                return _UpDownLines;
            }
            set
            {
                if(value > 1)
                {
                    _UpDownLines = value;
                }
            }
        }

        public int UpDownRows
        {
            get
            {
                return _UpDownRows;
            }
            set
            {
                if(value > 2)
                {
                    _UpDownRows = value;
                }
            }
        }

        public int MiddleSize
        {
            get
            {
                return _MiddleSize;
            }
            set
            {
                if(value > 3)
                {
                    _MiddleSize = value;
                }
            }
        }
        #endregion
        #region Constructors
        // Empty Constructor just to be safe
        public Board()
        {

        }
        // String Int Constructor for basic use
        public Board(string Name, int Size)
        {
            this.Name = Name;
            this.Size = Size;
        }

        // Int Constructor for simple creation
        public Board(int Size)
        {
            this.Size = Size;
        }
        #endregion
        #region Methods
        #endregion
    }
}