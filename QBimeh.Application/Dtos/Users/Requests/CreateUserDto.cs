﻿namespace QBimeh.Application.Dtos.Users.Requests
{
    public class CreateUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string RoleName { get; set; }
    }
}
