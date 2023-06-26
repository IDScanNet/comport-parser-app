using Nautilus;
using System;
using System.Text;

namespace comportParserApp
{
    internal class Parser
    {
        readonly DriverLicense resDL;

        public Parser()
        {
            resDL = new DriverLicense();
        }//end constructor

        public void Parse(string trackString)
        {
            resDL.ExtractInfo(trackString.ToString());

            Console.Out.WriteLine($"To learn about a specific field visit\nhttps://docs.idscan.net/idparsing/dotnet.html\n");
            Console.WriteLine($"Address : {resDL.Address1} {resDL.Address2}");
            Console.WriteLine($"\nDocument Type : {resDL.DocumentType}");
            Console.WriteLine($"\nBirthday:{resDL.Birthdate}");
            Console.WriteLine($"\nCity : {resDL.City}");
            Console.WriteLine($"\nVehicle Classification Code : {resDL.VehicleClassCode}");
            Console.WriteLine($"\nCompliance Type: {resDL.ComplianceType}");
            Console.WriteLine($"\nCountry : {resDL.Country}");
            //  Console.WriteLine($"\nDiscretionary ID Number : {resDL.DiscretionaryIdNumber}");
            Console.WriteLine($"\nDocument Type : {resDL.DocumentType}");
            Console.WriteLine($"\nDocument Discriminator : {resDL.DocumentDiscriminator}");
            Console.WriteLine($"\nEndorsment Code Description : {resDL.EndorsementCodeDescription}");
            Console.WriteLine($"\nEndorsements Code : {resDL.EndorsementsCode}");
            Console.WriteLine($"\nExpiration Date : {resDL.ExpirationDate}");
            Console.WriteLine($"\nEye Color : {resDL.EyeColor}");
            Console.WriteLine($"\nFirst Name : {resDL.FirstName}");
            Console.WriteLine($"\nFull Name : {resDL.FullName}");
            Console.WriteLine($"\nGender : {resDL.Gender}");
            Console.WriteLine($"\nHair Color : {resDL.HairColor}");
            Console.WriteLine($"\nHazmat Exp Date : {resDL.HAZMATExpDate}");
            Console.WriteLine($"\nHeight : {resDL.Height}");
            Console.WriteLine($"\nIIN : {resDL.IIN}");
            Console.WriteLine($"\nIssueDate : {resDL.EndorsementsCode}");
            Console.WriteLine($"\nJurisdiction Code : {resDL.JurisdictionCode}");
            Console.WriteLine($"\nLast Name : {resDL.LastName}");
            Console.WriteLine($"\nLicense Number : {resDL.LicenseNumber}");
            Console.WriteLine($"\nLimited Duration Document : {resDL.LimitedDurationDocument}");
            Console.WriteLine($"\nMiddle Name : {resDL.MiddleName}");
            Console.WriteLine($"\nName Prefix : {resDL.NamePrefix}");
            Console.WriteLine($"\nName Suffix : {resDL.NameSuffix}");
            Console.WriteLine($"\nOrgan Donor : {resDL.OrganDonor}");
            Console.WriteLine($"\nPostal Box : {resDL.PostalBox}");
            Console.WriteLine($"\nPostal Code : {resDL.PostalCode}");

            Console.WriteLine($"\nRace : {resDL.Race}");
            Console.WriteLine($"\nRealId  : {resDL.RealId}");
            Console.WriteLine($"\nRestriction Code : {resDL.RestrictionCode}");
            Console.WriteLine($"\nRestriction Code Description : {resDL.RestrictionCodeDescription}");
            Console.WriteLine($"\nSpecification : {resDL.Specification}");
            Console.WriteLine($"\nVehicle Class Code Description : {resDL.VehicleClassCodeDescription}");
            Console.WriteLine($"\nVechile Registration Data : {resDL.vehicleRegistrationData}");
            Console.WriteLine($"\nVehicle Class Code  : {resDL.VehicleClassCode}");
            Console.WriteLine($"\nValidation Conf : {resDL.ValidationConfidence}");
            foreach (string s in resDL.ValidationCodes)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"\nWeight KG : {resDL.WeightKG}");
            Console.WriteLine($"\nWeight LBS : {resDL.WeightLBS}");

        }//end method Parse
    }//end class Parser
}
