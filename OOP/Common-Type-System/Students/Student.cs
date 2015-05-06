namespace Students
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;

    [Serializable]
    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private Student student;

        public Student(string firstName, string middleName, string lastName, int ssn,
            int streetNumber, string streetName, string town, int zipCode, string mobilePhone, string email,
            string courseName, University universityName, UniversitySpecialty speacialty, Faculty facultyName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.Town = town;
            this.ZipCode = zipCode;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = courseName;
            this.Specialty = speacialty;
            this.UniversityName = universityName;
            this.Faculty = facultyName;
        }
        public string Course { get; set; }
        public University UniversityName { get; set; }
        public UniversitySpecialty Specialty { get; set; }
        public Faculty Faculty { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public int ZipCode { get; set; }
        public string Town { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }

        public int SSN
        {
            get { return ssn; }
            set
            {
                if (value < 100000000 || value > 999999999)
                {
                    throw new ArgumentOutOfRangeException("SSN should be in the range from 100000000 and 999999999");
                }
                ssn = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student names must have value!");
                }
                lastName = value;
            }
        }
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student names must have value!");
                }
                lastName = value;
                middleName = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student names must have value!");
                }
                lastName = value;
                firstName = value;
            }
        }
        public override string ToString()
        {
            var studentBuilder = new StringBuilder();
            studentBuilder.Append('-', 50);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Student Name: {0} {1} {2}, SSN: {3}", this.FirstName, this.MiddleName, this.LastName, this.SSN);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Contact: {0},{1},{2},ZipCode: {3}, mobile: {4}, email: {5}", this.StreetNumber, this.StreetName, this.Town, this.ZipCode, this.MobilePhone, this.Email);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("University Name: {0} Course: {1}", this.UniversityName, this.Course);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Specialty: {0}, Faculty: {1}", this.Specialty, this.Faculty);
            return studentBuilder.ToString();
        }
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(firstStudent, secondStudent))
            {
                return true;
            }
            // If one is null, but not both, return false.
            if (((object)firstStudent == null) || ((object)secondStudent == null))
            {
                return false;
            }
            // Return true if the fields match:
            return firstStudent.FirstName == secondStudent.FirstName && firstStudent.MiddleName == secondStudent.MiddleName
                    && firstStudent.LastName == secondStudent.LastName && firstStudent.SSN == secondStudent.SSN;
        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent == secondStudent);
        }
        public override bool Equals(object firstStudent)
        {
            if (firstStudent == null)
            {
                return false;
            }
            // If parameter cannot be cast to Point return false.
            Student secondStudent = firstStudent as Student;
            if ((System.Object)secondStudent == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (FirstName == secondStudent.FirstName) && (MiddleName == secondStudent.MiddleName) && (LastName == secondStudent.LastName) && (SSN == secondStudent.SSN);
            //return (x == p.x) && (y == p.y);
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() << 17 ^ this.SSN.GetHashCode() >> 17;
        }
        public object Clone()
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, this); // serialize using the stream

            stream.Position = 0;
            Object cloned = formatter.Deserialize(stream); // deserialize into a new object
            stream.Close(); // close stream

            return cloned;
        }
        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.SSN.CompareTo(other.SSN) != 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            return 0;
        }
    }
}