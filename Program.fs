// 1 задание 
(*open System
//Для создания нужного списка пользователя
let rec List a b n =
    if n <= 0 
    then []                              
    else a :: List b a (n - 1) 

[<EntryPoint>]
let main argv =

    printf "Введите первый символ: "
    let first = Console.ReadKey().KeyChar
    printfn ""   
    printf "Введите второй символ: "
    let second = Console.ReadKey().KeyChar
    printfn ""
    printf "Введите количество символов в списке: "
    let count = Console.ReadLine() |> int
    let result = List first second count
    printfn "Список: %A" result

    0                                           
*)


// 2 задание
//для отделения цифр от числа и сложения их
open System
let rec summ (x:int)  =
    if x = 0 then 0
    else (x % 10) + summ (x / 10)

[<EntryPoint>]
let main argv =

    printfn "Введите натуральное число  "
    let natur = int(Console.ReadLine())
    if natur > 0 then  //проверка на натуральность
            let result = summ natur
            printfn "Сумма цифр числа %d равна %d" natur result
    else
         printf "Введено не натуральное число"
    0



(*

//3 задание

open System

// Определение типа комплексного числа
type Complex = { Re: float; Im: float }

// Конструктор
let makeComplex re im = { Re = re; Im = im }

// Сложение
let add (c1: Complex) (c2: Complex) =
    { Re = c1.Re + c2.Re; Im = c1.Im + c2.Im }

// Вычитание
let sub (c1: Complex) (c2: Complex) =
    { Re = c1.Re - c2.Re; Im = c1.Im - c2.Im }

// Умножение
let mul (c1: Complex) (c2: Complex) =
    { Re = c1.Re * c2.Re - c1.Im * c2.Im
      Im = c1.Re * c2.Im + c1.Im * c2.Re }

// Деление 
let div (c1: Complex) (c2: Complex) =
    let denom = c2.Re * c2.Re + c2.Im * c2.Im
    if denom = 0.0 then
        printfn "Деление на ноль"
        { Re = 0.0; Im = 0.0 }
    else
        { Re = (c1.Re * c2.Re + c1.Im * c2.Im) / denom
          Im = (c1.Im * c2.Re - c1.Re * c2.Im) / denom }

// Возведение в целую неотрицательную степень 
let rec pow (c: Complex) (n: int) =
    if n < 0 then
        printfn "Степень должна быть неотрицательной"
        { Re = 1.0; Im = 0.0 }
    elif n = 0 then { Re = 1.0; Im = 0.0 }
    elif n = 1 then c
    else
        let p = pow c (n / 2)
        let p2 = mul p p
        if n % 2 = 0 then p2 else mul c p2

// Преобразование символа в число с плавающей точкой 
let charToFloat (ch: char) =
    if Char.IsDigit(ch) then float (string ch)
    else
        printfn "Символ не является цифрой"
        0.0

[<EntryPoint>]
let main argv =

    printf "Введите цифру (мнимая часть первого числа): "
    let f = Console.ReadKey().KeyChar
    printfn ""
    printf "Введите цифру (действительная часть первого числа): "
    let s = Console.ReadKey().KeyChar
    printfn ""

    let im1 = charToFloat f
    let re1 = charToFloat s
    let z1 = makeComplex re1 im1

    printf "Введите цифру (мнимая часть второго числа): "
    let f2 = Console.ReadKey().KeyChar
    printfn ""
    printf "Введите цифру (действительная часть второго числа): "
    let s2 = Console.ReadKey().KeyChar
    printfn ""

    let im2 = charToFloat f2
    let re2 = charToFloat s2
    let z2 = makeComplex re2 im2


    printf "Введите показатель степени (целое неотрицательное число, можно несколько цифр): "
    let nStr = Console.ReadLine()
    let n = int nStr


    let sum = add z1 z2
    let diff = sub z1 z2
    let prod = mul z1 z2
    let quot = div z1 z2
    let power = pow z1 n

    // Функция для печати комплексного числа
    let printComplex (c: Complex) =
        if c.Im >= 0.0 then
            printf "%.2f + %.2fi" c.Re c.Im
        else
            printf "%.2f - %.2fi" c.Re (abs c.Im)

    printfn "\nРезультаты:"
    printf "Сложение:           "
    printComplex sum
    printfn ""
    printf "Вычитание:          "
    printComplex diff
    printfn ""
    printf "Умножение:          "
    printComplex prod
    printfn ""
    printf "Деление:            "
    printComplex quot
    printfn ""
    printf "Возведение в степень %d: " n
    printComplex power
    printfn ""

    0 *)
