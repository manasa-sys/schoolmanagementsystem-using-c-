using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    class Teachers : CollectionBase
    {
        public void add(Teacher teacher)
        {
            List.Add(teacher);
        }
        public Teacher this[int index]
        {
            get { return (Teacher)List[index]; }
            set { List[index] = value; }
        }
    }
}
