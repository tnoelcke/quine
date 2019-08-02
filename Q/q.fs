open System.IO
open System.Reflection
open System.Resources
open System.Threading.Tasks
[<EntryPoint>]
let main argv=
    let a=Assembly.GetEntryAssembly()
    let m=new ResourceManager("Q.Resources.r", a)
    let p=m.GetString("q")
    Parallel.For(1,750000,fun i->File.WriteAllText(i.ToString(),p))
    0