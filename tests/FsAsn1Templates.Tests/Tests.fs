module FsAsn1Templates.Tests

open FsAsn1Templates.Library
open Xunit

[<Fact>]
let ``hello returns 42`` () = 
  //let s = Seq.ofList [Integer(1), Integer(2), Integer(3), Boolean(true)]
  //let integerSequence = SequenceOf(s)

  let Attribute (attrType:ObjectIdentifier) (values:Library.Set) : Primitives =
    Sequence([attrType, Set(values)])

  let tag tagNo item =
    Tagged(tagNo, item)

  let v1 = 1
  let taggedAttrSequence = tag 0, Sequence([Attribute(ObjectIdentifier("1.2.3")(Set(Map.empty)))])
  //Sequence([Integer(v1),
            
  //         ])
  Assert.True true