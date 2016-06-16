using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain
{
    /// <summary>
    /// Association between a Show and a Genre
    /// </summary>
    public class ShowGenre
    {
        #region Fields

        private int _id;
        private int _showId;
        private int _genreId;

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set {_id = value; }
        }

        public int ShowId
        {
            get { return _showId; }
            set { _showId = value; }
        }

        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        #endregion
    }
}