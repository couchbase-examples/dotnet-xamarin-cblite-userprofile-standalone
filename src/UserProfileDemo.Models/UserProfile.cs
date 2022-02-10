﻿namespace UserProfileDemo.Models
{
    // tag::userprofile[]
    public class UserProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public byte[] ImageData { get; set; }
        public string Description { get; set; }
    }
    // end::userprofile[]
}
