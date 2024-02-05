using Homework_27;
using System.Xml;

List<string> list= new List<string>();
Dictionary<string, int> Exams=new Dictionary<string, int>();
Exams.Add("Riyaziyyat", 15);
list.Add("math");

string opt;
Student student=new Student();
do
{
    Console.WriteLine("1. Telebe elave et");
    Console.WriteLine("2. Telebeye imtahan elave et");
    Console.WriteLine("3. Telebenin bir imtahan balına bax");
    Console.WriteLine("4. Telebenin butun imtahanlarını goster");
    Console.WriteLine("5. Telebenin imtahan ortalamasını goster");
    Console.WriteLine("6. Telebeden imtahan sil");
    Console.WriteLine("0. Cix");

    Console.WriteLine("Emeliyyati secin: ");
    opt =Console.ReadLine();

    switch(opt)
    {
        case "1":
            Console.WriteLine("FullName daxil edin: ");
           name: string fullname=Console.ReadLine();
            if (fullname == null)
            {
                Console.WriteLine("Ad daxil edin!");
                goto name;
            }

            list.Add(fullname);
            break;
        case "2":
            Console.WriteLine("Telebe nomresini daxil edin: ");
            no:  string noStr=Console.ReadLine();
            int no;
            if(!int.TryParse(noStr, out no))
            {
                Console.WriteLine("No duzgun formatda daxil edin!");
                goto no;
            }
            Console.WriteLine("Imtahan daxil edin: ");
            exam:  string exam=Console.ReadLine();
            if (exam == null)
            {
                Console.WriteLine("Imtahan daxil edin!");
                goto exam;
            }
            Console.WriteLine("Point daxil edin: ");
        point: string pointStr=Console.ReadLine();
            int point;
            if(!int.TryParse(pointStr, out point))
            {
                Console.WriteLine("Point duzgun formatda daxil edin!");
                goto point;
            }
            student.Exams.Add(exam, point);
            break;
        case "3":
            Console.WriteLine("Telebenin nomresini daxil edin: ");
            studentno:  string  studentNoStr=Console.ReadLine();
            int studentNo;
            if (!int.TryParse(studentNoStr, out studentNo))
            {
                Console.WriteLine("No duzgun formatda daxil edin!");
                goto studentno;
            }
            
            

            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
    }



} while(opt!="0");


 bool CheckExamNo(string examNo)
{
    for (int i = 0; i < student.Exams.Count; i++)
    {
        if (student.No.ToString().Contains(examNo))
        {
            Console.WriteLine($"Point: {student.Exams.Values}");
            return true;
        }
    }
    return false;
}





















void GetExamResult(string examName)
{
    for(int i = 0; i < list.Count; i++)
    {
        if (list[i]==examName)
        {
            foreach(var e in Exams)
            {
                Console.WriteLine($"{e.Key}: {e.Value}");
            }
        }
    }
}