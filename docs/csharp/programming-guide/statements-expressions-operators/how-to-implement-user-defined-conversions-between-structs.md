---
title: "How to: Implement User-Defined Conversions Between Structs - C# Programming Guide"
ms.custom: seodec18
ms.date: 07/20/2015
helpviewer_keywords: 
  - "user-defined conversions [C#]"
ms.assetid: 97839aef-8fbc-40d5-9769-6b569bc2710b
---
# How to: Implement User-Defined Conversions Between Structs (C# Programming Guide)
This example defines two structs, `RomanNumeral` and `BinaryNumeral`, and demonstrates conversions between them.  
  
## Example  
 [!code-csharp[csProgGuideStatements#13](~/samples/snippets/csharp/VS_Snippets_VBCSharp/csProgGuideStatements/CS/Statements.cs#13)]  
  
## Robust Programming  
  
-   In the previous example, the statement:  
  
     [!code-csharp[csProgGuideStatements#14](~/samples/snippets/csharp/VS_Snippets_VBCSharp/csProgGuideStatements/CS/Statements.cs#14)]  
  
     performs a conversion from a `RomanNumeral` to a `BinaryNumeral`. Because there is no direct conversion from `RomanNumeral` to `BinaryNumeral`, a cast is used to convert from a `RomanNumeral` to an `int`, and another cast to convert from an `int` to a `BinaryNumeral`.  
  
-   Also the statement  
  
     [!code-csharp[csProgGuideStatements#15](~/samples/snippets/csharp/VS_Snippets_VBCSharp/csProgGuideStatements/CS/Statements.cs#15)]  
  
     performs a conversion from a `BinaryNumeral` to a `RomanNumeral`. Because `RomanNumeral` defines an implicit conversion from `BinaryNumeral`, no cast is required.  
  
## See also

- [C# Reference](../../../csharp/language-reference/index.md)
- [C# Programming Guide](../../../csharp/programming-guide/index.md)
- [Conversion Operators](../../../csharp/programming-guide/statements-expressions-operators/conversion-operators.md)
