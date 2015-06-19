namespace FSharp

type FSharpDerived() =
    inherit CxxCLI.Base()

    override __.GetLong() = 5
    override __.GetInt()  = 6
