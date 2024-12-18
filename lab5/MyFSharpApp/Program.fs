
module ZadanieFunkcyjne =
    let sumaIter n =
        let mutable suma = 0 
        for i in 1..n do    
            suma <-suma + i
        suma

    let wynik = sumaIter 5
    printfn "Suma iteracyjnie: %d\n" wynik



    let rec sumaRek n = 
        if n <= 0 then 0
        else n + sumaRek (n-1)

    let wynik1 = sumaIter 5
    printfn "Suma rekurencyjnie: %d\n" wynik1



    let rec silniaOgonowa n acc =
        if n <=1 then acc
        else silniaOgonowa (n-1) (n*acc)

    let wynik2 = silniaOgonowa 5 1
    printfn "5! = %d\n" wynik2



    let rec sumaRekTral n acc=
        if n <=0 then acc
        else sumaRekTral (n-1) (acc + n)


//zad1 Stwórz aplikację konsolową, która oblicza wskaźnik masy ciała (BMI) użytkownika na
// Rekurencyjne generowanie ciągu Fibonacciego
// Napisz funkcję rekurencyjną, która oblicza n-ty wyraz ciągu Fibonacciego. Następnie zoptymalizuj ją,
// stosując funkcję z ogonową rekurencją.
    let rec fibRek n =
        if n <= 0 then 0 
        elif n = 1 then 1
        else fibRek (n-1) + fibRek (n-2)


    let rec fibRekTrail n a b =
        if n <= 0 then a
        elif n = 1 then b
        else fibRekTrail (n-1) b (a+b)



// Zadanie 2. Wyszukiwanie elementu w drzewie binarnym
// Zaimplementuj funkcję rekurencyjną do wyszukiwania elementu w drzewie binarnym. Napisz też
// iteracyjną wersję tej funkcji z użyciem stosu symulowanego za pomocą listy.

    // Definicja typu drzewa binarnego
    type Tree<'T> =
        | Empty
        | Node of 'T * Tree<'T> * Tree<'T>

    // Rekurencyjna funkcja wyszukiwania w drzewie binarnym
    let rec searchRecursive (tree: Tree<int>) (value: int) : bool =
        match tree with
        | Empty -> false
        | Node (v, left, right) ->
            if v = value then true
            elif value < v then searchRecursive left value
            else searchRecursive right value

    // Iteracyjna funkcja wyszukiwania w drzewie binarnym (z użyciem stosu)
    let searchIterative (tree: Tree<int>) (value: int) : bool =
        let rec loop stack =
            match stack with
            | [] -> false
            | Empty :: rest -> loop rest
            | Node (v, left, right) :: rest ->
                if v = value then true
                else if value < v then loop (left :: rest)
                else loop (right :: rest)
        
        loop [tree]

    // Przykładowe drzewo binarne
    let tree =
        Node(10,
            Node(5, Node(3, Empty, Empty), Node(7, Empty, Empty)),
            Node(15, Node(12, Empty, Empty), Node(20, Empty, Empty)))

//================koniec modułu

// Funkcja główna z wywołaniem obu funkcji wyszukiwania
[<EntryPoint>]
let main argv =
    // Wywołanie funkcji rekurencyjnej
    let result1 = ZadanieFunkcyjne.searchRecursive tree 7
    printfn "Wynik rekurencyjnego wyszukiwania: %b" result1

    // Wywołanie funkcji iteracyjnej
    let result2 = searchIterative tree 7
    printfn "Wynik iteracyjnego wyszukiwania: %b" result2

    // Możesz także sprawdzić dla innych wartości
    let result3 = searchRecursive tree 9
    printfn "Wynik rekurencyjnego wyszukiwania dla 9: %b" result3

    let result4 = searchIterative tree 9
    printfn "Wynik iteracyjnego wyszukiwania dla 9: %b" result4

    0 // Zwracamy 0, aby zakończyć program





// [<EntryPoint>]
// let main arvg = 
//     let wynik = ZadanieFunkcyjne.fibRekTrail 4 1 1
//     printfn "fib = %d " wynik

//     0
