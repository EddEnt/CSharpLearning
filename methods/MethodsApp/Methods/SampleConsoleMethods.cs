using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    //Public - May be accessed by any other code in the same assembly or another assembly that references it.
    //         The accessibility level of public members of a type is controlled by the accessibility level of the type itself
    //         In other words, available from within the project and other projects that reference the prior project.

    //Private - The type or member can be accessed only by code in the same class or struct. Only available from inside the class.

    //Protected - The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
    //            Accessible from containting classes and derived classes. Not accessible from outside the class hierarchy, even in the same assembly.

    //Internal - Types or members can be accessed from code that is part of the same compilation (Available only within the project).

    //Protected Internal - Combination of Protected and Internal. The type or member can be accessed by any code in the assembly in which it's declared,
    //                     or from within a derived class in another assembly.

    //Private Internal - Combination of Private and Internal. Can be accessed by types derived from the class that are declared within its containing assembly.
    //                   A way to provide access to a member onlt to specific derived classes within that same assembly.

    //Static Class - Can not be instantiated. In other words, cannot use the "new" operator to create a variable of the class type.
    //               Must call a method from within the class. Can be used as a convenient container for sets of methods that just operate on input parameters,
    //               and do not have to get or set any internal instance fields.
    
    //Void - Return type is null. Method will not return a value. 

    public static class SampleConsoleMethods //Always PascalCase when naming methods and classes (Captial letters at the start and for new words)
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello from SampleConsoleMethods.cs");
        }

        public static void SayGoodbye() 
        {
            Console.WriteLine("Goodbye from SampleConsoleMethods.cs");
        }
    }
}
