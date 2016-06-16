using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Talent.Domain
{
    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            int returnValue = 0;
            if(p1.DateOfBirth.HasValue && p2.DateOfBirth.HasValue)
            {
                returnValue =  -1 * 
                    DateTime.Compare(p1.DateOfBirth.Value, 
                        p2.DateOfBirth.Value);
                if( returnValue != 0)
                {
                    return returnValue;
                }
            }
            if(p1.DateOfBirth.HasValue ^ p2.DateOfBirth.HasValue)
            {
                // If only one has a DateOfBirth, it appears
                // after the one with null DateOfBirth.
                return p1.DateOfBirth.HasValue ? 1 : -1;
            }
            // If both have same DateOfBirth or both are
            // missing, fall back to default sort order by name
            return p1.CompareTo(p2);
        }

    }
}
