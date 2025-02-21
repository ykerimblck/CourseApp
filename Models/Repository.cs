namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() { 
                    Id = 1, 
                    Title = "Asp.Net Kursu", 
                    Description = "ASP.NET, Microsoft tarafından geliştirilen ve web uygulamaları oluşturmak için kullanılan güçlü bir framework'tür. .NET ekosistemiyle entegrasyonu sayesinde güvenilir ve ölçeklenebilir projeler geliştirmeye olanak tanır.", 
                    Image="1.jpg",
                    Tags = new string[] {"aspnet","web geliştirme","Backend"},
                    isActive = true,
                    isHome = true
                },
                new Course() { 
                    Id = 2, 
                    Title = "Python Kursu", 
                    Description = "Python, basit sözdizimi ve geniş kütüphane desteği sayesinde veri bilimi, yapay zeka ve web geliştirme gibi birçok alanda kullanılan çok yönlü bir programlama dilidir.", 
                    Image="2.jpg",
                    Tags = new string[] {"yapayzeka","veribilimi"},
                    isActive = true,
                    isHome = true
                },
                new Course() { 
                    Id = 3, 
                    Title = "Java Kursu", 
                    Description = "Java, platform bağımsızlığı ve güçlü nesne yönelimli yapısıyla büyük ölçekli yazılım projelerinde yaygın olarak kullanılan bir dildir. Mobil uygulamalar ve kurumsal çözümler için idealdir.",
                    Image="3.jpg",
                    Tags = new string[] {"frontend","web geliştirme","javascript"},
                    isActive = true,
                    isHome = true
                },
                new Course() { 
                    Id = 4, 
                    Title = "Javascript Kursu", 
                    Description = "JavaScript, dinamik web sayfaları oluşturmak için kullanılan, tarayıcı tabanlı ve yaygın bir programlama dilidir. Modern web uygulamalarında interaktif öğeler ve istemci taraflı işlemler için vazgeçilmezdir.", 
                    Image="4.jpg",
                    Tags = new string[] {"OOP","backend","java"},
                    isActive = true,
                    isHome = true
                },
            };
        }

        public static List<Course> Courses 
        {
            get {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}