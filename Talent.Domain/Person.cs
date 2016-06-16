using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain
{
    /// <summary>
    /// A Person object representing an Actor, Director, etc.
    /// </summary>
    public class Person : IComparable<Person>
    {

        #region Fields

        private int _id;
        private string _salutation;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _suffix;
        private DateTime? _dateOfBirth;
        private double? _height;
        private int _hairColorId;
        private int _eyeColorId;
        private List<Credit> _credits = new List<Credit>();
        private List<PersonAttachment> _personAttachments = new List<PersonAttachment>();

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Suffix
        {
            get { return _suffix; }
            set { _suffix = value; }
        }

        public DateTime? DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public double? Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int HairColorId
        {
            get { return _hairColorId; }
            set { _hairColorId = value; }
        }

        public int EyeColorId
        {
            get { return _eyeColorId; }
            set { _eyeColorId = value; }
        }

        public List<Credit> Credits
        {
            get { return _credits; }
        }

        public List<PersonAttachment> PersonAttachments
        {
            get { return _personAttachments; }
        }

        #endregion

        #region Computed Properties

        public string FirstLastName
        {
            get
            {
                return (
                        (FirstName ?? "")
                        + " " +
                        (LastName ?? "")
                    ).Trim();
            }
        }

        public string LastFirstName
        {
            get
            {
                var sb = new StringBuilder();
                var joinCharacter = "";

                if (!String.IsNullOrWhiteSpace(LastName))
                {
                    sb.Append(joinCharacter + LastName);
                    joinCharacter = ", ";
                }
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    sb.Append(joinCharacter + FirstName);
                }
                return sb.ToString();
            }
        }

        public string FullName
        {
            get
            {
                var sb = new StringBuilder();
                var joinCharacter = "";

                if (!String.IsNullOrWhiteSpace(Salutation))
                {
                    sb.Append(joinCharacter + Salutation);
                    joinCharacter = " ";
                }
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    sb.Append(joinCharacter + FirstName);
                    joinCharacter = " ";
                }
                if (!String.IsNullOrWhiteSpace(MiddleName))
                {
                    sb.Append(joinCharacter + MiddleName);
                    joinCharacter = " ";
                }
                if (!String.IsNullOrWhiteSpace(LastName))
                {
                    sb.Append(joinCharacter + LastName);
                    joinCharacter = " ";
                }
                if (!String.IsNullOrWhiteSpace(Suffix))
                {
                    if (sb.Length > 0) joinCharacter = ", ";
                    sb.Append(joinCharacter + Suffix);
                    joinCharacter = " ";
                }
                return sb.ToString();
            }
        }

        public int? Age
        {
            get
            {
                if (DateOfBirth.HasValue == false) return null;
                var today = DateTime.Today;
                int years = today.Year - DateOfBirth.Value.Year;
                if (
                    (DateOfBirth.Value.Date.Month > today.Month)
                    || (DateOfBirth.Value.Date.Month == today.Month
                        && DateOfBirth.Value.Date.Day > today.Day))
                {
                    years--;
                }
                return years >= 0 ? years : 0;
            }
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return FirstLastName;
        }

        #endregion

        #region  IComparable<Person>

        public int CompareTo(Person other)
        {
            int nameCompare = String.Compare(this.LastFirstName,
                other.LastFirstName, true);
            if (nameCompare != 0)
            {
                return nameCompare;
            }
            int suffixCompare = String.Compare(this.Suffix, other.Suffix, true);
            if (suffixCompare != 0)
            {
                return suffixCompare;
            }
            if (this.DateOfBirth.HasValue && other.DateOfBirth.HasValue)
            {
                return this.DateOfBirth.Value < other.DateOfBirth.Value ? -1 : 1;
            }
            return 0;
        }

        #endregion
    }
}
