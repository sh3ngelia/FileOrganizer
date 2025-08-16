ქართულად Georgian 
File Organizer Tool არის კონსოლური აპლიკაცია, რომელიც ავტომატურად გადაანაწილებს ფაილებს საქაღალდეში მათი გაფართოების მიხედვით. პროგრამა ასკანირებს კონკრეტულ დირექტორიას, ფილტრავს ფაილებს მოცემული გაფართოებით და მოათავსებს შესაბამის კატეგორიებში: Images, Audio, Videos, Documents, Others.

ძირითადი ფუნქციები:

Stream-ებით ფაილების ოპერაციები - ყველა ფაილის კოპირება და გადატანა ხდება FileStream-ით.

Custom Path ფუნქციები - ფუნქციები, როგორიცაა Combine, GetExtension და GetFileNameWithoutExtension, დაწერილია ხელით, არ არის გამოყენებული .NET-ის ჩაშენებული Path მეთოდები(გამოყენებულია string-ის მეთოდები).

Recursive დირექტორიის სკანირება - დირექტორიაში არსებულ ყველა ფოლდერს ავტომატურად ასკანირებს.

ლოგირება - ყველა ოპერაცია იწერება კონსოლში და ასევე შესაძლებელი ლოგ ფაილში (logs/actions.log).

გამოყენებული ტექნოლოგიები:

C# (.NET 8) - კონსოლური აპლიკაციის შექმნა

System.IO - დირექტორიების სკანირება და ფაილური ოპერაციები

FileStream / Stream - ფაილების კითხვისა და ჩაწერის ოპერაციები

Custom Path Utilities - ფაილის სახელისა და გაფართოების ამოღების საკუთარი ფუნქციები

Logging - Stream-ებით ლოგირება

ვისთვისაა ეს პროგრამა?
ეს პროგრამა გამოიყენება დეველოპერების, სტუდენტების ან ნებისმიერი ადამიანის მიერ, ვისაც სურს დიდი რაოდენობის ფაილების სწრაფი და ეფექტური ორგანიზება.

English ინგლისურად 
File Organizer Tool is a console application that automatically arranges files in a folder by their extension. The program scans a specific directory, filters files with a given extension and places them in the appropriate categories: Images, Audio, Videos, Documents, Others.

Main features:

File operations with streams - all files are copied and moved using FileStream.

Custom Path functions - functions such as Combine, GetExtension and GetFileNameWithoutExtension are written manually, the built-in .NET Path methods are not used (string methods are used).

Recursive directory scanning - automatically scans all folders in a directory.

Logging - all operations are logged to the console and also available in a log file (logs/actions.log).

Technologies used:

C# (.NET 8) - Creating a console application

System.IO - Directory scanning and file operations

FileStream / Stream - File reading and writing operations

Custom Path Utilities - Custom functions for extracting file names and extensions

Logging - Logging with streams

Who is this program for?
This program is used by developers, students, or anyone who wants to quickly and efficiently organize a large number of files.
