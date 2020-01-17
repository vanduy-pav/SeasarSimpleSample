using System;
using System.Collections.Generic;
using Seasar.Dao.Attrs;

namespace SeasarSimpleSample
{
    [Bean(typeof(UserDto))]
    interface IUserDao
    {
        [Query("order by user.id")]
        IList<UserDto> GetAll();

        [Sql("select * from user where id = /*id*/")]
        UserDto GetData(int id);

        [SqlFile]
        IList <UserDto> GetUsersByNameAndAge(string name, int age);
    }
}
