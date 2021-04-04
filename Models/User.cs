using System;
using System.ComponentModel.DataAnnotations;

namespace TestApi.Models {

    public class User {

        public int Id { get; set; }
        [StringLength(30), Required]
        public string Username { get; set; }

        public User() {
        }
    }
}
