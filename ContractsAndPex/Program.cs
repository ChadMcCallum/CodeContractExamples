using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ContractsAndPex
{
    class Program
    {
        static void Main(string[] args)
        {
            var utility = new StringUtility("asdf");
            utility.SubString("asdf", 0, 3);

            utility.SubStringOnTarget(0, 3);

            utility.Target = string.Empty;
        }
    }

    //if you run Pex on this class, it will auto-generate a bunch of unit tests
    //for you based on the contact methods and reasonable defaults for each parameter
    //refer to ContractsAndPex.Tests.StringUtilityTest for an example
    //generated unit test file from Pex
    public class StringUtility
    {
        public string Target { get; set; }

        public string SubStringOnTarget(int start, int end)
        {
            return SubString(Target, start, end);
        }

        public StringUtility(string target)
        {
            Target = target;
        }

        //this creates a method that is executed every time a
        //StringUtility class is created or modified
        //it will throw compiler errors if this condition is broken
        [ContractInvariantMethod]
        private void ClassInvariants()
        {
            Contract.Invariant(!string.IsNullOrEmpty(Target));
        }

        //examples of validation before executing the method
        public string SubString(string target, int start, int end)
        {
            //old way
            //if (start < 0)
            //    throw new ArgumentException("Start must be greater than 0");
            //if (string.IsNullOrEmpty(target))
            //    throw new ArgumentException("Target string must have one or more characters");
            //if (end > target.Length)
            //    throw new ArgumentException("End must be less than or equal to length of string");
            //if (start > end)
            //    throw new ArgumentException("End must be greater than Start");

            //code contract way
            //breaking any of these will throw an exception both at compile and run time
            Contract.Requires(!string.IsNullOrEmpty(target));
            Contract.Requires(start >= 0 && start < end);
            Contract.Requires(end < target.Length && end > 0 && end > start);
            Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));

            return target.Substring(start, end - start);
        }
    }
}
