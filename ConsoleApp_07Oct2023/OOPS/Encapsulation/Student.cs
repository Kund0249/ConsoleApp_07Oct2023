using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Encapsulation
{
    class Student
    {
        private int _StudentId;
        private string _StudentName;
        private string _Gender;
       
        public int StudentId
        {
            set
            {
                if (value > 0)
                    _StudentId = value;
                else
                    throw new Exception("Student Id must be greater than 0.");
            }
            get { return _StudentId; }
        }
        public String StudentName
        {
            get { return _StudentName; }
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                    _StudentName = value;
                else
                    throw new Exception("Student Name is not valid.");

            }
        }

        public string Gender
        {
            get { return _Gender; }
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                {
                    if (value == "M" || value == "F")
                        _Gender = value;
                    else
                        throw new Exception("Gender is not valid.");
                }
                else
                    throw new Exception("Gender is not valid.");
            }
        }

        public override string ToString()
        {
            return string.Format($"Roll No : {StudentId}, Name : {StudentName} , Gender : {Gender}");
        }
        //public void SetId(int Id)
        //{
        //    if (Id > 0)
        //        _StudentId = Id;
        //    else
        //        throw new Exception("Student Id must be greater than 0.");
        //}

        //public int GetId()
        //{
        //    return _StudentId;
        //}
    }

    class Books
    {
        private int _BookId;
        private string _BookName;
        private float _Price;
        private int _Qty;

        public int BookId
        {
            set
            {
                if (value > 0)
                    _BookId = value;
                else
                    throw new Exception("Student Id must be greater than 0.");
            }
            get { return _BookId; }
        }
        public String BookName
        {
            get { return _BookName; }
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                    _BookName = value;
                else
                    throw new Exception("Book Name is not valid.");

            }
        }

        public float Price
        {
            set {
                if (value > 0)
                    _Price = value;
                else
                    throw new Exception("Price must be greater than 0.");
            }
            get { return _Price; }
        }
        public int Qty
        {
            set
            {
                if (value > 0)
                    _Qty = value;
                else
                    throw new Exception("Student Id must be greater than 0.");
            }
            get { return _Qty; }
        }

    }
}
