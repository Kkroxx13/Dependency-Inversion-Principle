using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
   
        public interface IEmployeeSearchable
        {
            IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
        }
    
}
