using iText.Kernel.Pdf;
using FillerPDF.Contracts;
using FillerPDF.Fillers;
using System;
using System.IO;
using FillerPDF.POC.Documents;
using FillerPDF.POC.Enums;
using System.Reflection;
using System.Diagnostics;

namespace FillerPDF.POC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base location of the pdf's files to be filled
            string basePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Documents\Files";
            //Directory.SetCurrentDirectory(basePath);

            // https://catalogue.servicecanada.gc.ca/apps/EForms/pdf/en/ESDC-EMP5624.pdf
            var inputFile = "ESDC-EMP5624.pdf";
            var _fileInput = $"{Path.Combine(basePath, inputFile)}";
            var _fileOutput = $"{Path.Combine(basePath, $"Filled_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{inputFile}")}";

            // reads the pdf file into memory
            var pdfReader = new PdfReader(_fileInput);
            // [https://itextpdf.com/en/resources/faq/technical-support/itext-7/how-decrypt-pdf-document-owner-password]
            // [...] We still need to know the owner password if we want to manipulate the PDF [...]
            // [...]
            //  What if the PDF was produced by a third party and we do not want to respect the wishes of that third party?
            //  In that case, you can deliberately be unethical and change the value of the unethicalReading variable
            // [...]
            pdfReader.SetUnethicalReading(true);

            // create a new version of the pdf
            PdfDocument pdf = new PdfDocument(pdfReader, new PdfWriter(_fileOutput));

            // Model decorated with field definition attributes
            var doc2 = GenerateData();
            // Basically a "filler" is the one who knows how to fill the pdf file based on model class attributes
            IFiller filler = new BasePdfFiller<ESDC_EMP5624>(doc2);

            //Fill the pdf
            filler.Fill(pdf);

            Console.WriteLine("The PDF was successfully filled");
            Process.Start($"\"{_fileOutput}\"");
        }
        static ESDC_EMP5624 GenerateData()
        {
            return new ESDC_EMP5624
            {
                section1 = new Section1()
                {
                    OcuppationAppersInGlobalTalentOcuppationList = false,
                    ReferredAsDesignatedReferralPartner = true,
                    DesignatedReferralPartiner = new DesignatedReferralPartnerContactInfo()
                    {
                        OrganizationName = "OrganizationName 1",
                        FirstName = "FirstName 1",
                        MiddleName = "MiddleName 1",
                        LastName = "LastName 1",
                        TelephoneNumber = "TelephoneNumber 1",
                        AlternateTelephoneNumber = "AlternateTelephoneNumber 1",
                        FaxNumber = "FaxNumber 1",
                        EmailAddress = "EmailAddress 1",
                        PreferredOralCommunicationLanguage = LanguageOptions.English,
                        PreferredWrittenCommunicationLanguage = LanguageOptions.French
                    },
                    AlternateReferralPartner = new AlternateReferralPartnerContactInfo()
                    {
                        FirstName = "FirstName 2",
                        MiddleName = "MiddleName 2",
                        LastName = "LastName 2",
                        TelephoneNumber = "TelephoneNumber 2",
                        AlternateTelephoneNumber = "AlternateTelephoneNumber 2",
                        FaxNumber = "FaxNumber 2",
                        EmailAddress = "EmailAddress 2",
                        PreferredOralCommunicationLanguage = LanguageOptions.French,
                        PreferredWrittenCommunicationLanguage = LanguageOptions.English


                    }
                },
                section2 = new Section2()
                {
                    CanadaAgencyPayrollAccountNumber = "123456789",
                    CanadaAgencyPayrollAccountNumber_RP = "1234",
                    BusinessLegalName = "BusinessLegalName",
                    BusinessAddressLine1 = "BusinessAddressLine1",
                    BusinessAddressLine2 = "BusinessAddressLine2",
                    BusinessAddressCity = "BusinessAddressCity",
                    BusinessAddressCountry = "BusinessAddressCountry",
                    BusinessAddressProvince = "BusinessAddressProvince",
                    BusinessAddressZipCode = "BusinessAddressZipCode",
                    IsMailingAddressDiferentFromBusinessAddres = true,
                    MailingAddressLine1 = "MailingAddressLine1",
                    MailingAddressLine2 = "MailingAddressLine2",
                    MailingAddressCity = "MailingAddressCity",
                    MailingAddressCountry = "MailingAddressCountry",
                    MailingAddressProvince = "MailingAddressProvince",
                    MailingAddressZipCode = "MailingAddressZipCode",
                    OrganizationType = new OrganizationTypeOptions[] { OrganizationTypeOptions.cb_individual, OrganizationTypeOptions.cb_society, OrganizationTypeOptions.cb_not_profit },
                    WebsiteAddress = "WebsiteAddress",
                    DateBusinessStarted = "DateBusinessStarted",
                    HowManyEmployeesNationallyUnderAgencyNumber = 12,
                    AnnualGrossRevenueInCAD = 105000,
                    DoesReceiveSupportThroughWorkSharingProgram = true,
                    Details = "Details"

                },
                section3 = new Section3()
                {
                    PrincipalEmployerContact = new PrincipalEmployerContactInfo()
                    {
                        PositionTitle = "txtF_position_title",
                        FirstName = "txtF_first_name2",
                        MiddleName = "txtF_mid_name2",
                        LastName = "txtF_last_name2",
                        TelephoneNumber = "txtF_phone_number2",
                        AlternateTelephoneNumber = "txtF_alternate_phone2",
                        FaxNumber = "txtF_fax_number2",
                        EmailAddress = "txtF_Email2",
                        PreferredOralCommunicationLanguage = LanguageOptions.French,
                        PreferredWrittenCommunicationLanguage = LanguageOptions.English
                    },
                    AlternateEmployerContact = new AlternateEmployerContactInfo()
                    {
                        PositionTitle = "txtF_position_title 2",
                        FirstName = "txtF_first_name2 2",
                        MiddleName = "txtF_mid_name o",
                        LastName = "txtF_last_name2 2",
                        TelephoneNumber = "txtF_phone_number2 2",
                        AlternateTelephoneNumber = "txtF_alternate_phone2 2",
                        FaxNumber = "txtF_fax_number2 2",
                        EmailAddress = "txtF_Email2 2",
                        PreferredOralCommunicationLanguage = LanguageOptions.English,
                        PreferredWrittenCommunicationLanguage = LanguageOptions.French
                    },

                },
                section4 = new Section4
                {

                    AreYouAppointingAThirdPartyToRepresentYou = false,
                    CanadaAgencyPayrollAccountNumber = "987654321",
                    CanadaAgencyPayrollAccountNumber_RP = "4321",
                    BusinessLegalName = "txtF_name_Legal",
                    BusinessOperatingName = "txtF_name_commercial",
                    JobTitle = "txtF_other_position_title2",
                    FirstName = "txtF_other_first_name22",
                    MiddleName = "txtF_other_mid_name22",
                    LastName = "txtF_other_last_name22",
                    TelephoneNumber = "txtF_other_phone_number22",
                    AlternateTelephoneNumber = "txtF_other_alternate_phone22",
                    FaxNumber = "txtF_other_fax_number22",
                    EmailAddress = "txtF_other_Email22",
                    PreferredOralCommunicationLanguage = LanguageOptions.French,
                    PreferredWrittenCommunicationLanguage = LanguageOptions.English,
                    BusinessAddressLine1 = "txtF_Mail_Adress1",
                    BusinessAddressLine2 = "txtF_Mail_Adress2",
                    BusinessAddressCity = "txtF_City",
                    BusinessAddressProvince = "txtF_Province",
                    BusinessAddressCountry = "txtF_Country",
                    BusinessAddressZipCode = "txtF_Postal_Code",
                    IsMailingAddressDiferentFromBusinessAddres = true,
                    MailingAddressLine1 = "txtF_Mail_Adress21",
                    MailingAddressLine2 = "txtF_Mail_Adress22",
                    MailingAddressCity = "txtF_City2",
                    MailingAddressProvince = "txtF_Province2",
                    MailingAddressCountry = "txtF_Country2",
                    MailingAddressZipCode = "txtF_Postal_Code2",
                    IsTheThirdPartyBeingPaidByTheEmployer = true,
                    Yes_IsTheThirdPartyCCRC = true,
                    Yes_CCRCNumber = "txtF_CCRC_number",
                    Yes_IsTheThirdPartyLawMember = false,
                    Yes_LawMemberProvinceTerritory = "txtF_Law_member_prov",
                    Yes_LawMemberMembershipId = "txtF_Law_member_numb",
                    Yes_IsTheThirdPartyChambreDesNotairesDuQuebec = false,
                    Yes_ChambreMembershipId = "txtF_Law_numb",
                    Yes_IsTheThirdPartyOther = false,
                    Yes_OtherSpecify = "txtF_Other_specify",
                    No_ItIsPaidByFamilyOrFriend = false,
                    No_ItIsPaidByONG = false,
                    No_ItIsPaidByICCRC = false,
                    No_ItIsPaidByOther = true,
                    No_OtherSpecify = "txtF_Other_specify2",
                },
                section5 = new Section5()
                {
                    JobTitle = "txtF_position_title2",
                    NOC = "txtF_code",
                    HowManyTWFsIsTheEmployerRequestingForThisJobOffer = 3,
                    MainDutiesOfTheJob = "txtF_MainDuties",
                    ExpectedStartDate = DateTime.Now,
                    txtF_number_days = 30,
                    chkB_english1 = EmploymentDurationOptions.Months,
                    txtF_justification = "txtF_justification",
                    IsThePositionPartOfAUnion = true,
                    RequiresAbilityToCommunicateOrallyIn = true,
                    CommunicationOrally = CommunicationOptions.French,
                    RequiresAbilityToCommunicateWritingIn = true,
                    CommunicationWriting = CommunicationOptions.EnglishAndFrench,
                    TheOfferNotRequireTheAbillityToCommunicate = false,
                    TheOfferNotRequireTheAbillityToCommunicateDetail = "txtF_ProvideDetails2",
                    TheOfferRequireTheAbillityToCommunicateInLanguageOtherThanEnglishAndFrench = false,
                    TheOfferRequireTheAbillityToCommunicateInLanguageOtherThanEnglishAndFrenchDetail = "txtF_ProvideDetails3",
                    MinimumEducation = MinimumEducationOptions.VocationalSchoolDiplomaCertificate,
                    MinimumEducationAdditionalInformation = "txtF_AdditionalInformation",
                    MinimumExperienceSkillRequirements = "txtF_MainDuties2",
                    HaveYouTriedToRecruitCanadiansPermanentResidentsPrior = false,
                    HaveYouTriedToRecruitCanadiansPermanentResidentsPrior_Yes_AdditionalInformation = "txtF_AdditionalInformation2",
                    HaveYouTriedToRecruitCanadiansPermanentResidentsPrior_No_AdditionalInformation = "txtF_No_AdditionalInformation",
                    WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months = true,
                    WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months_Yes_HowManyCanadiansPermResid = 12,
                    WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months_Yes_HowManyTWFs = 2,
                    WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months_Yes_Reasons = "txtF_info",
                    TheHiringCauseImpactInCanadianWorkForce = true,
                    TheHiringCauseImpactInCanadianWorkForce_Yes_Details = "txtF_No_add_info"
                },
                section6 = new Section6()
                {
                    WageRangeSameOccupation_Low = 55.1m,
                    WageRangeSameOccupation_High = 78.99m,
                    ThereAreAnyEmployeesOnTheSameOccupation = true,
                    IsAFullTimeJobAtLeast30HoursPerWeek = true,
                    IsAFullTimeJobAtLeast30HoursPerWeek_No_Explain = "txtF_IfNo",
                    HowManyHoursEachDay = 8,
                    HowManyHoursEachWeek = 40,
                    HowManyHoursEachMonth = null,
                    SalaryPerHour = 60.2m,
                    OertimeSalaryPerHour = 72.1m,
                    OvertimeStartingHoursPerDay = null,
                    OvertimeStartingHoursPerWeek = 5,
                    DidYouConvertTheWageFromMonthlyOrYearlyOrCurrencyToOtherThanCADOrBoth = true,
                    DidYouConvertTheWageFromMonthlyOrYearlyOrCurrencyToOtherThanCADOrBoth_Yes_Info = "txtF_yes_add_info",
                    Benefits = new BenefitsOptions[] { BenefitsOptions.DentalInsurance, BenefitsOptions.ExtendedMedicalInsurance },
                    OtherBenefits = "txtF_OtherBenefits",
                    VacationNumberOfBusinessDaysPerYear = 30,
                    VacationRemunarationPercentageGrossSalaray = 10.5m,
                },
                section7 = new Section7()
                {
                    DescribePrincipalActivity = "txtF_principal_activity",
                    BusinessOperationName = "txtF_commercial_name",
                    WorkLocation = "txtF_where",
                    WorkLocationCity = "txtF_City23",
                    WorkLocationProvince = "txtF_Province23",
                    WorkLocationPostalCode = "txtF_Postal_Code23",
                    OtherWorkLocation = "txtF_where3",
                    OtherWorkLocationCity = "txtF_City24",
                    OtherWorkLocationProvince = "txtF_Province24",
                    OtherWorkLocationPostalCode = "txtF_Postal_Code3",
                    IsThereALaborDisputenProgressAtAnyWorkLocations = true,
                    IsThereALaborDisputenProgressAtAnyWorkLocations_Yes_Details = "txtF_yes_add_info2",
                },
                section8 = new Section8()
                {
                    DoesYourORganisationHaveActiveLaburMarketBenefitsPlan = true,
                },
                section9 = new Section9()
                {
                    WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                    Row1_ActivityMilestone = "Row1_ActivityMilestone",
                    Row1_Target = "Row1_Target",
                    Row1_StartDate = DateTime.Now,
                    Row1_EndDate = DateTime.Now.AddYears(1).AddDays(45),
                    Row2_ActivityMilestone = "Row2_ActivityMilestone",
                    Row2_Target = "Row2_Target",
                    Row2_StartDate = DateTime.Now.AddDays(1),
                    Row2_EndDate = DateTime.Now.AddYears(1).AddDays(46),
                    Row3_ActivityMilestone = "Row3_ActivityMilestone",
                    Row3_Target = "Row3_Target",
                    Row3_StartDate = DateTime.Now.AddDays(2),
                    Row3_EndDate = DateTime.Now.AddYears(1).AddDays(47),
                    Row4_ActivityMilestone = "Row4_ActivityMilestone",
                    Row4_Target = "Row4_Target",
                    Row4_StartDate = DateTime.Now.AddDays(3),
                    Row4_EndDate = DateTime.Now.AddYears(1).AddDays(48),
                    Row5_ActivityMilestone = "Row5_ActivityMilestone",
                    Row5_Target = "Row5_Target",
                    Row5_StartDate = DateTime.Now.AddDays(4),
                    Row5_EndDate = DateTime.Now.AddYears(1).AddDays(49),
                    Row6_ActivityMilestone = "Row6_ActivityMilestone",
                    Row6_Target = "Row6_Target",
                    Row6_StartDate = DateTime.Now.AddDays(5),
                    Row6_EndDate = DateTime.Now.AddYears(1).AddDays(50),
                },
                section10 = new Section10()
                {
                    ComplementaryBenefit1 = new ComplementaryBenefit1()
                    {
                        WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                        Row1_ActivityMilestone = "Row1_ActivityMilestone",
                        Row1_Target = "Row1_Target",
                        Row1_StartDate = DateTime.Now,
                        Row1_EndDate = DateTime.Now.AddYears(1).AddDays(45),
                        Row2_ActivityMilestone = "Row2_ActivityMilestone",
                        Row2_Target = "Row2_Target",
                        Row2_StartDate = DateTime.Now.AddDays(1),
                        Row2_EndDate = DateTime.Now.AddYears(1).AddDays(46),
                        Row3_ActivityMilestone = "Row3_ActivityMilestone",
                        Row3_Target = "Row3_Target",
                        Row3_StartDate = DateTime.Now.AddDays(2),
                        Row3_EndDate = DateTime.Now.AddYears(1).AddDays(47),
                        Row4_ActivityMilestone = "Row4_ActivityMilestone",
                        Row4_Target = "Row4_Target",
                        Row4_StartDate = DateTime.Now.AddDays(3),
                        Row4_EndDate = DateTime.Now.AddYears(1).AddDays(48),
                        Row5_ActivityMilestone = "Row5_ActivityMilestone",
                        Row5_Target = "Row5_Target",
                        Row5_StartDate = DateTime.Now.AddDays(4),
                        Row5_EndDate = DateTime.Now.AddYears(1).AddDays(49),
                        Row6_ActivityMilestone = "Row6_ActivityMilestone",
                        Row6_Target = "Row6_Target",
                        Row6_StartDate = DateTime.Now.AddDays(5),
                        Row6_EndDate = DateTime.Now.AddYears(1).AddDays(50),
                    },
                    ComplementaryBenefit2 = new ComplementaryBenefit2()
                    {
                        WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                        Row2_ActivityMilestone = "Row2_ActivityMilestone",
                        Row2_Target = "Row2_Target",
                        Row2_StartDate = DateTime.Now.AddDays(1),
                        Row2_EndDate = DateTime.Now.AddYears(1).AddDays(46),
                    },
                    ComplementaryBenefit3 = new ComplementaryBenefit3()
                    {
                        WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                        Row3_ActivityMilestone = "Row3_ActivityMilestone",
                        Row3_Target = "Row3_Target",
                        Row3_StartDate = DateTime.Now.AddDays(2),
                        Row3_EndDate = DateTime.Now.AddYears(1).AddDays(47),
                    },
                    ComplementaryBenefit4 = new ComplementaryBenefit4()
                    {
                        WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                        Row4_ActivityMilestone = "Row4_ActivityMilestone",
                        Row4_Target = "Row4_Target",
                        Row4_StartDate = DateTime.Now.AddDays(3),
                        Row4_EndDate = DateTime.Now.AddYears(1).AddDays(48),

                    },
                    ComplementaryBenefit5 = new ComplementaryBenefit5()
                    {
                        WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                        Row5_ActivityMilestone = "Row5_ActivityMilestone",
                        Row5_Target = "Row5_Target",
                        Row5_StartDate = DateTime.Now.AddDays(4),
                        Row5_EndDate = DateTime.Now.AddYears(1).AddDays(49),
                    },
                    ComplementaryBenefit6 = new ComplementaryBenefit6()
                    {
                        WichAdavantageWillBeAchievedByHiringTFW = "txtF_advantage",
                        Row6_ActivityMilestone = "Row6_ActivityMilestone",
                        Row6_Target = "Row6_Target",
                        Row6_StartDate = DateTime.Now.AddDays(5),
                        Row6_EndDate = DateTime.Now.AddYears(1).AddDays(50),
                    },
                },
                section11 = new Section11()
                {
                    EmployerSignature = "txtF_Employer_Signature",
                    EmployerPrintName = "txtF_Employer_Print_Name",
                    EmployerTitle = "txtF_Employer_Title",
                    TodayDate = DateTime.Now,
                    section11a = new Section11a()
                    {
                        EmployerSignature = "txtF_Employer_Signature2",
                        EmployerPrintName = "txtF_Employer_Print_Name2",
                        TodayDate = DateTime.Now.AddDays(1),
                    },
                    section11b = new Section11b()
                    {
                        EmployerSignature = "txtF_Employer_Signature3",
                        EmployerPrintName = "txtF_Employer_Print_Name3",
                        EmployerDate = DateTime.Now.AddDays(2),
                        WitnessSignature = "txtF_Employer_Signature4",
                        WitnessPrintName = "txtF_Employer_Print_Name4",
                        WitnessDate = DateTime.Now.AddDays(3),
                    }
                },
                sectionFee = new SectionFee()
                {
                    EmployerName = "txtF_EMployer_Name",
                    CRABusinessNumber = "txtF_CRA_Business_Number",
                    NumberPositions = "txtF_Number_Positions",
                    ProcessingFee = 350.99m,
                    PaymentMethod = PaymentMethodOptions.CreditCard,
                    CardHolderNamePrintedOnCard = "txtF_Given_Names",
                    EmployerPrimaryContactName = "txtF_Applicant_Name",
                    CreditCardType = CreditCardOptions.AmericanExpress,
                    Last4DigitsOfCreditCard = 999,
                    TotalOfCharge = 351.99m,
                    CreditCardInfoDate = DateTime.Now,
                    CreditCardNumber = "txtF_Card_Number",
                    CreditCardExpirationDate = new DateTime(2027, 12, 1)
                },
                sectionWorkersInformation = new SectionWorkersInformation()
                {
                    Workers1 = new Worker1()
                    {
                        PassportLastName = "txtF_Family_Name1",
                        PassportFirstName = "txtF_First_Name1",
                        Gender = GenderOptions.Female,
                        DateOfBirth = new DateTime(1974, 5, 25),
                        Citizenship = "txtF_Citizenship1",
                        City = "txtF_City1",
                        Country = "txtF_Country1",
                        ResidentCity = "txtF_City1b",
                        ResidentCountry = "txtF_Country1b",
                        ImmigrationStatus = new ImmigrationStatusOptions[] { ImmigrationStatusOptions.RefugeeClaimant, ImmigrationStatusOptions.TemporaryForeignWorker },


                    },
                    Workers2 = new Worker2()
                    {
                        PassportLastName = "txtF_Family_Name2",
                        PassportFirstName = "txtF_First_Name2",
                        Gender = GenderOptions.Female,
                        DateOfBirth = new DateTime(1964, 5, 25),
                        Citizenship = "txtF_Citizenship12",
                        City = "txtF_City22",
                        Country = "txtF_Country22",
                        ResidentCity = "txtF_City2b",
                        ResidentCountry = "txtF_Country2b",
                        ImmigrationStatus = new ImmigrationStatusOptions[] { ImmigrationStatusOptions.RefugeeClaimant, ImmigrationStatusOptions.TemporaryForeignWorker },


                    },
                    Workers3 = new Worker3()
                    {
                        PassportLastName = "txtF_Family_Name3",
                        PassportFirstName = "txtF_First_Name22",
                        Gender = GenderOptions.Female,
                        DateOfBirth = new DateTime(1954, 5, 25),
                        Citizenship = "txtF_Citizenship3",
                        City = "txtF_City3",
                        Country = "txtF_Country3",
                        ResidentCity = "txtF_City3b",
                        ResidentCountry = "txtF_Country1b2",
                        ImmigrationStatus = new ImmigrationStatusOptions[] { ImmigrationStatusOptions.RefugeeClaimant, ImmigrationStatusOptions.TemporaryForeignWorker },


                    },
                    Workers4 = new Worker4()
                    {
                        PassportLastName = "txtF_Family_Name4",
                        PassportFirstName = "txtF_First_Name4",
                        Gender = GenderOptions.Female,
                        DateOfBirth = new DateTime(1944, 5, 25),
                        Citizenship = "txtF_Citizenship4",
                        City = "txtF_City4",
                        Country = "txtF_Country4",
                        ResidentCity = "txtF_City4b",
                        ResidentCountry = "txtF_Country4b",
                        ImmigrationStatus = new ImmigrationStatusOptions[] { ImmigrationStatusOptions.RefugeeClaimant, ImmigrationStatusOptions.TemporaryForeignWorker },


                    },
                    Workers5 = new Worker5
                    {
                        PassportLastName = "txtF_Family_Name5",
                        PassportFirstName = "txtF_First_Name5",
                        Gender = GenderOptions.Female,
                        DateOfBirth = new DateTime(1934, 5, 25),
                        Citizenship = "txtF_Citizenship5",
                        City = "txtF_City5",
                        Country = "txtF_Country5",
                        ResidentCity = "txtF_City5b",
                        ResidentCountry = "txtF_Country5b",
                        ImmigrationStatus = new ImmigrationStatusOptions[] { ImmigrationStatusOptions.RefugeeClaimant, ImmigrationStatusOptions.TemporaryForeignWorker },


                    }
                }
            };
        }
    }
}
