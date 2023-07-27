using TypeGen.Core.TypeAnnotations;

namespace TypeGen.TestWebApp.CustomBaseInterfaces;

[ExportTsClass]
[TsCustomBase(null, null, null, false,
    "IFoo", null, null, false, "IBar", "./my/path", "IOrig", false, "IBaz", "./my/path/baz", null, true)]
public class Foo : ITest
{
    
}