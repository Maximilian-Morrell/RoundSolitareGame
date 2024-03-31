using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundSolitareGame.Classes
{
    internal class Board
    {
        #region Variables
        private string _Name, _Description;
        private int _Size, _SideRows, _SideLines, _UpDownLines, _UpDownRows, _MiddleSize, _Seconds;
        private bool _Started;
        private List<PlayField> _PlayFields;

        public bool Started
        {
            get
            {
                return _Started;
            }
            set
            {
                _Started = value;
            }
        }

        public List<PlayField> PlayFields
        {
            get
            {
                return _PlayFields;
            }
            set
            {
                _PlayFields = value;
            }
        }

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
        public Board(int SizeMultiplicator)
        {
            this.Size = 7 * SizeMultiplicator;
            this.SideRows = 2 * SizeMultiplicator;
            this.UpDownLines = 2 * SizeMultiplicator;
            this.MiddleSize = 3 * SizeMultiplicator;
            this.UpDownRows = 3 * SizeMultiplicator;
            this.SideLines = 3 * SizeMultiplicator;
            this.PlayFields = new List<PlayField>();
        }
        #endregion
        #region Methods
        public static TableLayoutPanel GeneratePlayField(Board b)
        {

            TableLayoutPanel parent = new TableLayoutPanel();
            parent.RowCount = b.Size;
            parent.ColumnCount = b.Size;
            for(int i = 0; i <= b.Size; i++)
            {
                if(i < b.UpDownLines)
                {
                    for (int y = 0; y <= b.Size; y++)
                    {
                        if(y >= b.SideRows && y < b.SideRows + b.UpDownRows)
                        {
                            // Top Buttons
                            parent.Controls.Add(CreateButton(b, "" + y + i, true, false), y, i);
                        }
                    }
                }
                else if(i > b.UpDownLines && i <= b.UpDownLines +  b.SideLines)
                {
                    for(int y = 0; y < b.Size; y++)
                    {
                        if(y < b.SideRows)
                        {
                            // Left Buttons
                            parent.Controls.Add(CreateButton(b, "" + y + i, true, false), y, i);

                        }
                        else if(y >= b.SideRows && y < b.SideRows + b.UpDownRows) 
                        {
                            if(y == (b.Size - 1) / 2 && i == (b.Size + 1) / 2)
                            {
                                // Center Center Button
                                parent.Controls.Add(CreateButton(b, "" + y + i, false, false), y, i);
                            }
                            else
                            {
                                // Middle Buttons
                                parent.Controls.Add(CreateButton(b, "" + y + i, true, false), y, i);
                            }

                        }
                        else if(y <= b.SideRows + b.UpDownRows + b.SideRows && y >= b.SideRows + b.UpDownRows)
                        {
                            // Right Buttons
                            parent.Controls.Add(CreateButton(b, "" + y + i, true, false), y, i);
                        }
                    }
                }
                else if(i >= b.UpDownLines + b.SideLines)
                {
                    for (int y = 0; y < b.Size; y++)
                    {
                        if (y >= b.SideRows && y < b.SideRows + b.UpDownRows)
                        {
                            // Bottom Buttons
                            parent.Controls.Add(CreateButton(b, "" + y + i, true, false), y, i);
                        }
                    }
                }
            }
            parent.Dock = DockStyle.Fill;
            return parent;
        }

        public static Button CreateButton(Board b, string ID, bool IsNormal, bool IsOutside)
        {
            Button btn = new Button();
            btn.Width = 100;
            btn.Height = 100;
            btn.Text = "O";
            // Checking if the generated Button is Normal
            if (IsNormal)
            {
                NormalPlayField playField = new NormalPlayField(ID);
                b.PlayFields.Add(playField);
                btn.Click += (e, a) => playField.PlayFieldAction();
            }
            else if(IsOutside)
            {
                // Code for Outside Playfield
            }
            else
            {
                CenterPlayField playField = new CenterPlayField(ID);
                b.PlayFields.Add(playField);
                btn.BackColor = Color.Yellow;
                btn.Click += (e, a) => playField.PlayFieldAction();
            }
            return btn;
        }
        #endregion
    }
}
