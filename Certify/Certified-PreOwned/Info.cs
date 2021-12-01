//start
using System.Text;
using System.Linq;
using System;
﻿

namespace Certified-PreOwned
{
    public static class Info
    {
        public static void ShowLogo()
        {
            Console.WriteLine(new string("\\e\a   _____          _   _  __              ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string("  / ____|        | | (_)/ _|             ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string(" | |     ___ _ __| |_ _| |_ _   _        ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string(" | |    / _ \\ '__| __| |  _| | | |      ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string(" | |___|  __/ |  | |_| | | | |_| |       ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string("  \\_____\\___|_|   \\__|_|_|  \\__, |   ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string("                             __/ |       ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string("                            |___./        ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
            Console.WriteLine(new string("  i{0}                               \\e\a".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()), Certified-PreOwned.Version.version);
        }

        public static void ShowUsage()
        {
            var usage = @"
  Find information about all registered CAs:
    
    Certified-PreOwned.exe cas [/ca:SERVER\ca-name | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local] [/hideAdmins] [/showAllPermissions] [/skipWebServiceChecks] [/quiet]
  

  Find all enabled certificate templates:
    
    Certified-PreOwned.exe find [/ca:SERVER\ca-name | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local] [/quiet]

  Find vulnerable/abusable certificate templates using default low-privileged groups:

    Certified-PreOwned.exe find /vulnerable [/ca:SERVER\ca-name | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local] [/quiet]

  Find vulnerable/abusable certificate templates using all groups the current user context is a part of:

    Certified-PreOwned.exe find /vulnerable /currentuser [/ca:SERVER\ca-name | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local] [/quiet]

  Find enabled certificate templates where ENROLLEE_SUPPLIES_SUBJECT is enabled:

    Certified-PreOwned.exe find /enrolleeSuppliesSubject [/ca:SERVER\ca-name| /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local] [/quiet]

  Find enabled certificate templates capable of client authentication:

    Certified-PreOwned.exe find /clientauth [/ca:SERVER\ca-name | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local] [/quiet]

  Find all enabled certificate templates, display all of their permissions, and don't display the banner message:
    
    Certified-PreOwned.exe find /showAllPermissions /quiet [/ca:COMPUTER\CA_NAME | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local]

  Find all enabled certificate templates and output to a json file:
    
    Certified-PreOwned.exe find /json /outfile:C:\Temp\out.json [/ca:COMPUTER\CA_NAME | /domain:domain.local | /ldapserver:server.domain.local | /path:CN=Configuration,DC=domain,DC=local]


  Enumerate access control information for PKI objects:

    Certified-PreOwned.exe pkiobjects [/domain:domain.local | /ldapserver:server.domain.local] [/showAdmins] [/quiet]


  Request a new certificate using the current user context:

    Certified-PreOwned.exe request /ca:SERVER\ca-name [/subject:X] [/template:Y] [/install]

  Request a new certificate using the current machine context:

    Certified-PreOwned.exe request /ca:SERVER\ca-name /machine [/subject:X] [/template:Y] [/install]

  Request a new certificate using the current user context but for an alternate name (if supported):

    Certified-PreOwned.exe request /ca:SERVER\ca-name /template:Y /altname:USER
    
  Request a new certificate on behalf of another user, using an enrollment agent certificate:
    
    Certified-PreOwned.exe request /ca:SERVER\ca-name /template:Y /onbehalfof:DOMAIN\USER /enrollcert:C:\Temp\enroll.pfx [/enrollcertpw:CERT_PASSWORD]


  Download an already requested certificate:

    Certified-PreOwned.exe download /ca:SERVER\ca-name /id:X [/install] [/machine]
";
            Console.WriteLine(usage);
        }
    }
}
