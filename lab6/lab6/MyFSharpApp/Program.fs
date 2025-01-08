// type Person(name: string, age: int) = 
//     //pola prywatne
//     let mutable privateAge = age
    
//     //walsciwosci
//     member this.Name = name

//     // get i set
//     member this.Age 
//         with get() = privateAge
//         and set(value) =
//             if value > 0 then   
//                 privateAge <- value
//             else    printfn "Wiek musi by liczbą dodatnia"


//     //metoda
//     member this.View() =
//         printfn "Witaj %s masz %d lat." this.Name this.Age



// //klasa pochodna
// type Student(name:string, age:int, nrAlbumu:string) =
//     inherit Person(name,age)

//     //Właściwości
//     member this.NrAlbumu = nrAlbumu

//     override this.View()=
//         printfn "Witaj %s masz %d lat, nr albumu %s" this.Name this.Age this.NrAlbumu
    
// //obiekty klasy
// let person = Person("Jan", 23)
// person.View()



open System

type Book(title:string, author:string, pages:int) = 
    member this.Title = title
    member this.Author = author
    member this.Pages = pages

    //metoda
    member this.GetInfo() =
        sprintf "Tytuł: %s, Autor %s, Liczba stron %d" this.Title this.Author this.Pages

//user
type User(name: string) = 

    //lista ksiazek
    let borrowBooks = System.Collections.Generic.List<Book>()
    member this.Name = name
    member this.Borrow(book) = 
        borrowBooks.Add(book)
        printfn "%s wypozyczył książkę:  \"%s\"" this.Name book.Title  // jan nowak wypozyczył ksiazke : "tytuł"

    member this.ReturnBook(book) = 
        if borrowBooks.Contains(book) then
            borrowBooks.Remove(book)
            printfn "%s zwrócił książkę  \"%s\"" this.Name book.Title
        else
            printfn "%s nie ma ksiazki do zwrocenia \"%s\"" this.Name book.Title

    //metoda do wyswitlenia listy ksiazek wypozyczonych
    member this.ListBorrowBooks() = 
        if borrowBooks.Count > 0 then
            borrowBooks
            |> Seq.map (fun book -> book.GetInfo())
            |> String.concat "\n"
            |> printfn "Książki wypożyczone przez %s: \"n%s\"" this.Name
        else    
            printfn "%s nie ma wypozyczonych ksiazek" this.Name

type Library() =
    let mutable books = System.Collections.Generic.List<Book>()
 
    member this.AddBook(book: Book) =
        books.Add(book)
        printfn "Książka \"%s\" została dodana do biblioteki" book.Title
 
    member this.RemoveBook(book: Book) =
        if books.Contains(book) then
            books.Remove(book)
            printfn "Książka \"%s\" została usunięta z biblioteki" book.Title
        else
            printfn "Nie znaleziono książki"
 
    member this.ListOfBooks() =
        if books.Count > 0 then
            books
            |> Seq.map (fun book -> book.GetInfo())
            |> String.concat "\n"
            |> printfn "Książki w bibliotece: \n%s"
        else 
            printfn "W bibliotece nie ma książek"
 
let main() =
    let library = Library()
    let user = User("Jan")
 
    let book1 = Book("tytuł1", "autor1", 123)
    let book2 = Book("tytuł2", "autor2", 231)    
    let book3 = Book("tytuł3", "autor3", 312)
    let book4 = Book("tytuł4", "autor4", 321)
    library.AddBook(book1)
    library.AddBook(book2)
    library.AddBook(book3)
    library.AddBook(book4)
 
    library.ListOfBooks()
 
    user.BorrowBook(book1)
    user.BorrowBook(book2)
 
    user.ListBorrowBooks()
 
    user.ReturnBook(book1)
    user.ListBorrowBooks()