using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain
{
    public class EyeColor
    {
        #region Constructor

        #endregion

        #region Fields

        private int _eyeColorId;
        private string _name = String.Empty;
        private string _code = String.Empty;
        private bool _isInactive;
        private int _displayOrder = 10;

        #endregion

        #region Properties

        public int Id
        {
            get { return _eyeColorId; }
            set { _eyeColorId = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value ?? String.Empty; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value ?? String.Empty; }
        }

        public bool IsInactive
        {
            get { return _isInactive; }
            set { _isInactive = value; }
        }

        public int DisplayOrder
        {
            get { return _displayOrder; }
            set { _displayOrder = value; }
        }


        #endregion

        #region Overrides

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}

