namespace WebApi.Dtos
{
    /// <summary>
    /// [背景] 你的用户表可能包含了很多字段，而前端不需要这么多
    ///     所以需要一个更细粒度的数据结构来组织部分字段
    /// [DTO] data transform object，数据传输对象，用于传输（接收与发送）的对象
    /// 1. 用于将 部分用户信息 发送到客户端
    /// 2. 用于接收客户端发送过来的 用户信息
    /// </summary>
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        /// <summary>
        /// 这个字段仅在客户端传到服务器的时候使用，例如身份验证、注册
        /// 说明：有些开发人员喜欢再另写一个DTO
        /// 1. 一个包含Password，由前端返回过来的
        /// 2. 一个没有包含Password的，由后端返回给前端的额
        /// 但作者更喜欢两个DTO合成一个（就像这个一样），如此以更少的代码实现可维护性
        /// </summary>
        public string Password { get; set; }
    }
}