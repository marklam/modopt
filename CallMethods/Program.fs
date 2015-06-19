[<EntryPoint>]
let main _argv = 
    let cxx = CxxCLI.CxxDerived()
    let cs  = CSharp.CSharpDerived()
    //let fs  = FSharp.FSharpDerived()

    printfn "cxx %d %d" (cxx.GetLong()) (cxx.GetInt()) 
    printfn "cs  %d %d" ( cs.GetLong()) ( cs.GetInt()) 
    //printfn "fs  %d %d" ( fs.GetLong()) ( fs.GetInt()) 
    
    0
