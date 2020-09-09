using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Interfaces
{
    public interface ICommon
    {
        string HashPassword(string password, string salt);

        bool ValidatePassword(string password, string salt, string correctHash);

        string CreateMD5(string input);

        string ToQueryString(object obj);
    }
}
