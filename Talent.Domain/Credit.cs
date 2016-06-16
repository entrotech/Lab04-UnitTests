using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain
{
    /// <summary>
    /// Represent an association between a Person and a Show, giving them credit for 
    /// their role in the Show.
    /// </summary>
    /// <remarks>
    /// Character is only really applicable for the Actor CreditType.
    /// </remarks>
    public class Credit
    {
        #region Fields

        private int _id;
        private int _showId;
        private int _personId;
        private int _creditTypeId;
        private string _character = String.Empty;

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ShowId
        {
            get { return _showId; }
            set { _showId = value; }
        }

        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        public int CreditTypeId
        {
            get { return _creditTypeId; }
            set { _creditTypeId = value; }
        }

        public string Character
        {
            get { return _character; }
            set { _character = value ?? String.Empty; }
        }
        
        #endregion
    }
}
