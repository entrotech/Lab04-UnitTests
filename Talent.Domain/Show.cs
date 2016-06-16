using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain
{
    public class Show : IDisplayable
    {
        #region Constructor

        #endregion

        #region Fields

        private int _id;
        private string _title;
        private int? _lengthInMinutes;
        private DateTime? _releaseDate;
        private int? _mpaaRatingId;
        private List<ShowGenre> _showGenres = new List<ShowGenre>();
        private List<Credit> _credits = new List<Credit>();

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int? LengthInMinutes
        {
            get { return _lengthInMinutes; }
            set { _lengthInMinutes = value; }
        }

        public DateTime? ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        public int? MpaaRatingId
        {
            get { return _mpaaRatingId; }
            set { _mpaaRatingId = value; }
        }

        public List<ShowGenre> ShowGenres
        {
            get { return _showGenres; }
        }

        public List<Credit> Credits
        {
            get { return _credits; }
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return Title;
        }



        #endregion

        #region IDisplayable

        public string Display()
        {
            string msg = Title ?? "";
            if(ReleaseDate.HasValue)
            {
                msg += "(" + ReleaseDate.Value.Year + ")";
            }
            return msg;
        }

        #endregion
    }

}
