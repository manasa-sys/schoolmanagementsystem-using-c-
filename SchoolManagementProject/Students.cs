using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    class Students : CollectionBase
    {
        public void add(Student student)
        {
            List.Add(student);
        }

        internal void RemoveAt(Student student)
        {
            throw new NotImplementedException();
        }

        public Student this[int index]
        {
            get { return (Student)List[index]; }
            set { List[index] = value; }
        }
    }
}
