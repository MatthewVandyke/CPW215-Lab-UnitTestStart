using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>

        private string _courseName;

        public string CourseName
        {
            get
            {
                return _courseName;
            }
            set 
            { 
                if( value == null)
				{
                    throw new ArgumentNullException();
				}
                _courseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        /// 

        private byte _numberOfCredits;

        public byte NumberOfCredits { 
            get
			{
                return _numberOfCredits;
			}
            set 
            {
                if (value > 0 && value < 30)
				{
                    _numberOfCredits = value;
				}
                else
				{
                    throw new ArgumentException();
				}
            } 
        }

    }
}
