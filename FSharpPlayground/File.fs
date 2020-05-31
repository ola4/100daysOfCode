module File

    let whatever x = x*x
    
    let sampleRange = [0..99]

    let squares (_x:list<int>) = [for el in _x -> (el,el*el)]

    let result = squares sampleRange

   printfn "The table of squares from 0 to 99 is:\n%A" result

