using System.Collections.Generic;

namespace Application.CompiledBindings
{
    public class CompiledBindingsModel
    {
        public CompiledBindingsModel()
        {
            A = "Value A";
            B = "Value B";
            C = "Value C";
            D = "Value D";
            E = "Value E";
            F = "Value F";
            Arr = new[]
            {
                new ArrayMember
                {
                    Property = "a[0]",
                },
                new ArrayMember
                {
                    Property = "a[1]",
                },
                new ArrayMember
                {
                    Property = "a[2]",
                },
            };
        }

        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public IEnumerable<ArrayMember> Arr { get; set; }
    }

    public class ArrayMember
    {
        public string Property { get; set; }
    }
}