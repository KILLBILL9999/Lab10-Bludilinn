// step 1
// string subject = "Программирование";
 
// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }
 
// Console.WriteLine($"Всего букв в слове: {subject.Length}");
 

// step 2
// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;
 
// foreach (int grade in grades) {
//     Console.WriteLine(grade);
//     sum += grade;
// }
 
// Console.WriteLine($"Сумма оценок: {sum}");
// Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");
 
// step 3
// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;
 
// foreach (string student in students) {
//     Console.WriteLine(student);
//     count++;
// }
 
// Console.WriteLine($"Всего учеников: {count}");
 
// step 4
// int[] points = { 10, 20, 15 };
 
// for (int i = 0; i < points.Length; i++) {
//     points[i] = points[i] + 5;
// }
 
// foreach (int point in points) {
//     Console.WriteLine(point);
// }


// step 5
// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;
 
// foreach (string student in students) {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }
 
// A
// int[] numbers = { 7, 12, 3, 20, 8 };
// int sum = 0;
 
// foreach (int n in numbers) {
//     Console.WriteLine(n);
//     sum += n;
// }
 
// Console.WriteLine($"Сумма: {sum}");
 
// G
// int[] grades = { 4, 3, 5, 2, 4, 5, 3 };
// int max = grades[0];
 
// foreach (int grade in grades) {
//     if (grade > max) {
//         max = grade;
//     }
// }
 
// Console.WriteLine($"Наибольшая оценка: {max}");
 


//  Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
 

// var 1
// int[] temperatures = { 12, 14, 11, 9, 13, 15, 10 };
// int sum = 0;
 
// foreach (int t in temperatures) {
//     sum += t;
// }
 
// double average = (double)sum / temperatures.Length;
// Console.WriteLine($"Средняя температура за неделю: {average:F1}");
 

//  var 2
string[] participants = { "Аня", "Борис", "Вика", "Глеб", "Дарья" };
int number = 1;
 
foreach (string name in participants) {
    Console.WriteLine($"{number}. {name}");
    number++;
}
 