

using FileHandling.Context;
using FileHandling.Models;

namespace FileHandling.Methods
{
    public class FilerService
    {
        
        

        public static string ReadList(string fileName)
        {
            string filePath = $@"C:\Users\hp\Desktop\{fileName}.txt";//file path of the file

            using (var reader = new StreamReader(filePath))//streamResder class was used to read the content of the file
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var fields = line.Split(' ');// i want to split the line with |   or the index should count after every |
                        if (fields.Length >= 2)
                        {
                            string name = fields[0];
                            string email = fields[1];
                            string phoneNumber = fields[2];

                            //var file = new Filer(name, email, phone);
                            var file = new Filer
                            {
                                Name = name,
                                Email = email ,
                                PhoneNumber = phoneNumber

                            };
                            using (var context = new AppDbContext())
                            {
                                var mailExists = context.Files.FirstOrDefault(c => c.Email == email);
                                if (mailExists != null)
                                {
                                    return "Email already exists";
                                }
                                context.Files.Add(file);
                                context.SaveChanges();
                            }

                        }
                    }

                }
            }
            return "Record added successfully";
        }





    }
}
