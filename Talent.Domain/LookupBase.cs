using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain
{
    /// <summary>
    /// Base class for various "lookup table" type classes.
    /// </summary>
    public abstract class LookupBase : IDisplayable
    {

        #region Fields

        private int _id;
        private string _name;
        private string _code;
        private bool _isInactive;
        private int _displayOrder = 10;

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
                

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
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

        #region IDisplayable

        public virtual string Display()
        {
            return (Code ?? "") + " - " 
                + (Name ?? "");
        }

        #endregion

    }
}
