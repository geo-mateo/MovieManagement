﻿using MovieManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string UserName { get; set; }

        public string DomainName { get; set; }

        public static Email For(string email)
        {
            var emailObj = new Email();

            try
            {
                var index = email.IndexOf("@", StringComparison.Ordinal);
                emailObj.UserName = email.Substring(0, index);
                emailObj.DomainName = email.Substring(index + 1);
            }
            catch (Exception ex){
                throw;
            }
            return emailObj;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }

}
