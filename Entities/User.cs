namespace WebApi.Entities
{
    /// <summary>
    /// [实体] 代表用户存储在数据库中的数据
    /// [ORM] 如果使用ORM框架，这个实体就会映射到数据库当中
    /// 通过Entity可实现与数据库的CRUD操作
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}