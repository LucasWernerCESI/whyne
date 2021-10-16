using System;

namespace api
{
    public class Account
    {
        public int id { get; set; }

        public string title { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string role { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime? updatedAt { get; set; }

        public bool isVerified { get; set; }

    }
}