namespace FsAsn1Templates

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
    type Tag =
       Value of int

    type Primitives =
        | Null
        | Boolean of bool
        | Integer of int
        | Real of decimal
        | ObjectIdentifier of string
        | OctetString of byte array
        | BitString of byte array
        | IA5String of string
        | Utf8String of string
        | Sequence of Primitives list
        //| SequenceOf of Primitives list
        | Set of Map<Tag, Primitives>
        | Tagged of int * Primitives

    //type SequenceOf<'T>(ts:'T seq) =
    //    let xs = Seq.toArray ts
    //    member x.Elements with get() = xs

    //type SetOf<'T>(ts:Map<Tag, 'T>) =
    //    let xs = ts
    //    member x.Elements with get() = xs
