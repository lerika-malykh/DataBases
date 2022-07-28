string result = string.Empty;
string[] marks = {"трус", "балбес", "бывалый"};
for (int i = 0; i < 10; i++)
{
    string fname = $"Имя_{i}";
    string lname = $"Имя_{i}";
    int id = i;
    string mark = marks[new Random().Next(marks.Length)];

    result += $"{id};t{fname};t{lname};t{mark};/n";
}
//Console.WriteLine($"{result}");
File.WriteAllText("db.csv", result, System.Text.Encoding.UTF32);

/* Псевдокод:
   Model-ученики
    id
    firstName
    lastName
    mark */