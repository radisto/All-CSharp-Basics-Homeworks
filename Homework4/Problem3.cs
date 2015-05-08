using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string company_name = Console.ReadLine();
        Console.WriteLine("Company address:");
        string company_address = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phone_number = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string fax_number = Console.ReadLine();
        if (fax_number == "")
        {
            fax_number = "(no fax)";
        }
        Console.WriteLine("Web site:");
        string web_site = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string manager_first_name = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string manager_last_name = Console.ReadLine();
        Console.WriteLine("Manager age:");
        string manager_age = Console.ReadLine();
        Console.WriteLine("Manager phone:");
        string manager_phone = Console.ReadLine();

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", company_name, company_address, phone_number, fax_number, web_site, manager_first_name, manager_last_name, manager_age, manager_phone);
    }
}
