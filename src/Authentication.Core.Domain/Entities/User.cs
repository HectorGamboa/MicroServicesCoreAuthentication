﻿using Shared.Core.Commons.Bases;

namespace Authentication.Core.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; init; } = null!;
        public string PaternalLastName { get; init; } = null!;
        public string MaternalLastName { get; init; } = null!;
        public DateTime? DateOfBirth { get; set; } // Puede ser opcional
        public bool IsLocked { get; set; } = false;
        public string? ProfilePictureUrl { get; set; }
        public string Email { get; init; } = null!;
        public string Password { get; set; } = null!;
    }
}
