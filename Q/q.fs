open System.IO
open System.Reflection
open System.Resources
open System.Threading.Tasks
[<EntryPoint>]
let main argv=
    let m=new ResourceManager("Q.Resources.r",Assembly.GetExecutingAssembly())
    Parallel.For(1,750000,fun i->File.WriteAllText(i.ToString(),m.GetString("q")))
    0