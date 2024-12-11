// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"


// let x = 10
// let text = "Jan"
// let y = 10.3
// printfn "Wartość x =%d" x
// printfn "Wartość x =%.2f" y
// printfn "Tekst = %s" text
open System

// printfn "Podaj imie"
// let name = Console.ReadLine()

// printfn "Witaj, %s" name

// let powitanie = "Witaj" + "Jan"



// let pi = 3.14159
// let liczba = pi * 2.0

// let x = 5

// if x < 0 then
//     printfn "Liczba dodatnia"
// else
//     printfn "Liczba ujemna"


// let lista = [1;2;3]
// let nowaLista = 0 :: lista

// for i = 1 to 5 do
//     printfn "WartośC %d" i


// for i = 5 downto 1 do
//     printfn "Wartość %d" i


// let mutable x = 5
// while x<5 do
//     printfn "Wartość%d" x
//     x <- x+1


// type Osoba = 
//     {
//         Imie: string
//         Wiek: int
//     }
// type Student = 
//     {
//         Imie: string
//         Wiek: int
//     }

// let osoba1 = {Imie = "Jan"; Wiek = 24}
// let Student = {Imie = "Janina"; Wiek = 24}
// printfn "Imie: %s, Wiek: %d" osoba1.Imie osoba1.Wiek
// printfn "Imie: %s, Wiek: %d" Student.Imie Student.Wiek



// let str = "3.14"
// let liczba = System.Double.TryParse(str)

// printfn "Podaj liczbe całkowitą "
// let input = Console.ReadLine() //34
// let liczba1 = Int32.Parse(input)


// let x = 3
// match x with 
//     1 -> "Jeden"
//     2 -> "Dwa"
//     3 -> "trzy"
//     _-> "inna"



// let age = 20
// match age with
//     | x when x<18 -> printfn "osoba niepełnoletnia"
//     |x when x<18 -> "osoba pełnoletnia"
//     |_-> printfn "inna"


// let rec suma n=
//     if n<=0 then 0
//     else n + suma(n-1)

// printfn "Suma liczb od 1 do 5 = %s" (suma 5)



// let tablica = [|10;20;30|]
// for i = 0  to tablica.Length - 1 do    
//     printfn " element %d: %d"  i tablica.[i]
    





// let rec suma n=
//     if n<=0 then 0
//     else n + suma(n-1)

// //rekurencja ogonowa n = 5 acc -> suma = suma + n
// let sumRekTail n =
//     let rec loop n acc =
//         if n <=0 then acc
//         else loop (n-1) (acc+n)
//     loop n 0




// let funkcja = 
//     printfn "cos tam "

// let funkcja2 = 
//     printfn "cos tam "

// let funkcja3 = 
//     printfn "cos tam "

// [<EntryPoint>]
// let main arvg
//     //cialo
//     funkcja
//     funkcja2
//     //....

// Rekord do przechowywania danych użytkownika
type UserData = { Weight: float; Height: float }

// Funkcja do obliczania BMI
let calculateBMI weight height =
    let heightInMeters = height / 100.0 // Przekształcanie wzrostu z cm na metry
    weight / (heightInMeters * heightInMeters)

// Funkcja do określania kategorii BMI
let getCategory bmi =
    if bmi < 18.5 then "Niedowaga"
    elif bmi >= 18.5 && bmi < 24.9 then "Waga prawidłowa"
    elif bmi >= 25.0 && bmi < 29.9 then "Nadwaga"
    else "Otyłość"

// Funkcja główna
[<EntryPoint>]
let main argv =
    // Komunikacja z użytkownikiem i pobieranie danych
    printfn "Wprowadź swoją wagę w kilogramach (kg): "
    let weight = System.Double.Parse(System.Console.ReadLine()) // Zmieniono na System.Double.Parse, aby zapewnić zgodność z float (double)

    printfn "Wprowadź swój wzrost w centymetrach (cm): "
    let height = System.Double.Parse(System.Console.ReadLine()) // Zmieniono na System.Double.Parse

    // Tworzenie rekordu z danymi użytkownika
    let user = { Weight = weight; Height = height }

    // Obliczanie BMI
    let bmi = calculateBMI user.Weight user.Height
    printfn "Twoje BMI wynosi: %.2f" bmi

    // Określenie kategorii BMI
    let category = getCategory bmi
    printfn "Kategoria: %s" category

    // Czekanie na naciśnięcie klawisza, aby zakończyć program
    printfn "\nNaciśnij dowolny klawisz, aby zakończyć."
    System.Console.ReadKey() |> ignore
    0 // Zwracamy 0, aby zakończyć program
