using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seasar.Dao.Attrs;

namespace SeasarSimpleSample
{
    [Table("user")]
    class UserDto
    {
        private int id;
        private string name;
        private int age;

        public UserDto () {}

        [Column("id")]

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Column("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Column("age")]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
