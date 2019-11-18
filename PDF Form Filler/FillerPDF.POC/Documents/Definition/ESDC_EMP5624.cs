using FillerPDF.Attributes;
using FillerPDF.POC.Enums;
using System;

namespace FillerPDF.POC.Documents
{

    public class ESDC_EMP5624
    {
        [ClassWithFieldsDefinition]
        public Section1 section1 { get; set; }
        [ClassWithFieldsDefinition]
        public Section2 section2 { get; set; }
        [ClassWithFieldsDefinition]
        public Section3 section3 { get; set; }
        [ClassWithFieldsDefinition]
        public Section4 section4 { get; set; }
        [ClassWithFieldsDefinition]
        public Section5 section5 { get; set; }
        [ClassWithFieldsDefinition]
        public Section6 section6 { get; set; }
        [ClassWithFieldsDefinition]
        public Section7 section7 { get; set; }
        [ClassWithFieldsDefinition]
        public Section8 section8 { get; set; }
        [ClassWithFieldsDefinition]
        public Section9 section9 { get; set; }
        [ClassWithFieldsDefinition]
        public Section10 section10 { get; set; }
        [ClassWithFieldsDefinition]
        public Section11 section11 { get; set; }
        [ClassWithFieldsDefinition]
        public SectionFee sectionFee { get; set; }
        [ClassWithFieldsDefinition]
        public SectionWorkersInformation sectionWorkersInformation { get; set; }

    }
    public class Section1
    {
        [RadioField("EMP5624_E[0].Page1[0].Yes_business[0]", true)]
        [RadioField("EMP5624_E[0].Page1[0].No_business[0]", false)]
        public bool OcuppationAppersInGlobalTalentOcuppationList { get; set; }
        [RadioField("EMP5624_E[0].Page1[0].Yes_inn[0]", true)]
        [RadioField("EMP5624_E[0].Page1[0].No_inn[0]", false)]
        public bool ReferredAsDesignatedReferralPartner { get; set; }
        [ClassWithFieldsDefinition]
        public DesignatedReferralPartnerContactInfo DesignatedReferralPartiner { get; set; }
        [ClassWithFieldsDefinition]
        public AlternateReferralPartnerContactInfo AlternateReferralPartner { get; set; }
    }
    public class DesignatedReferralPartnerContactInfo
    {
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_des_part[0]")]
        public string OrganizationName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_first_name[0]")]
        public string FirstName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_mid_name[0]")]
        public string MiddleName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_last_name[0]")]
        public string LastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_phone_number[0]")]
        public string TelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_alternate_phone[0]")]
        public string AlternateTelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_fax_number[0]")]
        public string FaxNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_Email[0]")]
        public string EmailAddress { get; set; }
        [RadioField("EMP5624_E[0].Page1[0].rb_language_oral[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page1[0].rb_language_oral[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredOralCommunicationLanguage { get; set; }
        [RadioField("EMP5624_E[0].Page1[0].rb_language_written[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page1[0].rb_language_written[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredWrittenCommunicationLanguage { get; set; }
    }
    public class AlternateReferralPartnerContactInfo
    {
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_first_name2[0]")]
        public string FirstName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_mid_name2[0]")]
        public string MiddleName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_last_name2[0]")]
        public string LastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_phone_number2[0]")]
        public string TelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_alternate_phone2[0]")]
        public string AlternateTelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_fax_number2[0]")]
        public string FaxNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page1[0].txtF_Email2[0]")]
        public string EmailAddress { get; set; }
        [RadioField("EMP5624_E[0].Page1[0].rb_language_oral2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page1[0].rb_language_oral2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredOralCommunicationLanguage { get; set; }
        [RadioField("EMP5624_E[0].Page1[0].rb_language_written2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page1[0].rb_language_written2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredWrittenCommunicationLanguage { get; set; }
    }
    public class Section2
    {
        [SimpleTextField("EMP5624_E[0].Page2[0].num_Company_Code[0]")]
        public string CanadaAgencyPayrollAccountNumber { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].num_Company_Code[1]")]
        public string CanadaAgencyPayrollAccountNumber_RP { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Emp_Legal[0]")]
        public string BusinessLegalName { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Mail_Adress1[0]")]
        public string BusinessAddressLine1 { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Mail_Adress2[0]")]
        public string BusinessAddressLine2 { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_City[0]")]
        public string BusinessAddressCity { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Country[0]")]
        public string BusinessAddressCountry { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Province[0]")]
        public string BusinessAddressProvince { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Postal_Code[0]")]
        public string BusinessAddressZipCode { get; set; }

        public bool IsMailingAddressDiferentFromBusinessAddres { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Mail_Adress2-1[0]")]
        public string MailingAddressLine1 { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Mail_Adress2-2[0]")]
        public string MailingAddressLine2 { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_City2[0]")]
        public string MailingAddressCity { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Country2[0]")]
        public string MailingAddressCountry { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Province2[0]")]
        public string MailingAddressProvince { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Postal_Code2[0]")]
        public string MailingAddressZipCode { get; set; }

        [CheckboxField("EMP5624_E[0].Page2[0].cb_individual[0]", OrganizationTypeOptions.cb_individual)]
        [CheckboxField("EMP5624_E[0].Page2[0].cb_partnership[0]", OrganizationTypeOptions.cb_partnership)]
        [CheckboxField("EMP5624_E[0].Page2[0].cb_society[0]", OrganizationTypeOptions.cb_society)]
        [CheckboxField("EMP5624_E[0].Page2[0].cb_sole_propietor[0]", OrganizationTypeOptions.cb_sole_propietor)]
        [CheckboxField("EMP5624_E[0].Page2[0].cb_not_profit[0]", OrganizationTypeOptions.cb_not_profit)]
        [CheckboxField("EMP5624_E[0].Page2[0].cb_registred[0]", OrganizationTypeOptions.cb_registred)]
        public OrganizationTypeOptions[] OrganizationType { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Employer_Web_Address[0]")]
        public string WebsiteAddress { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Employer_Date_Business[0]")]
        public string DateBusinessStarted { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_amout_employees[0]")]
        public int HowManyEmployeesNationallyUnderAgencyNumber { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_business_revenu[0]")]
        public int AnnualGrossRevenueInCAD { get; set; }

        [RadioField("EMP5624_E[0].Page2[0].rb_receive_prog[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page2[0].rb_receive_prog[0]", true, "1")]
        public bool DoesReceiveSupportThroughWorkSharingProgram { get; set; }

        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_If_Yes2[0]")]
        public string Details { get; set; }

    }
    public class Section3
    {

        [ClassWithFieldsDefinition]
        public PrincipalEmployerContactInfo PrincipalEmployerContact { get; set; }

        [ClassWithFieldsDefinition]
        public AlternateEmployerContactInfo AlternateEmployerContact { get; set; }
    }
    public class PrincipalEmployerContactInfo
    {
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_position_title[0]")]
        public string PositionTitle { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_first_name2[0]")]
        public string FirstName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_mid_name2[0]")]
        public string MiddleName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_last_name2[0]")]
        public string LastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_phone_number2[0]")]
        public string TelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_alternate_phone2[0]")]
        public string AlternateTelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_fax_number2[0]")]
        public string FaxNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_Email2[0]")]
        public string EmailAddress { get; set; }
        [RadioField("EMP5624_E[0].Page2[0].rb_language_oral2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page2[0].rb_language_oral2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredOralCommunicationLanguage { get; set; }
        [RadioField("EMP5624_E[0].Page2[0].rb_language_written2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page2[0].rb_language_written2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredWrittenCommunicationLanguage { get; set; }

    }
    public class AlternateEmployerContactInfo
    {
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_position_title[0]")]
        public string PositionTitle { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_first_name2[0]")]
        public string FirstName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_mid_name2[0]")]
        public string MiddleName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_last_name2[0]")]
        public string LastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_phone_number2[0]")]
        public string TelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_alternate_phone2[0]")]
        public string AlternateTelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_fax_number2[0]")]
        public string FaxNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page2[0].txtF_other_Email2[0]")]
        public string EmailAddress { get; set; }
        [RadioField("EMP5624_E[0].Page2[0].rb_other_language_oral2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page2[0].rb_other_language_oral2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredOralCommunicationLanguage { get; set; }
        [RadioField("EMP5624_E[0].Page2[0].rb_other_anguage_written2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page2[0].rb_other_anguage_written2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredWrittenCommunicationLanguage { get; set; }

    }
    public class Section4
    {

        [RadioField("EMP5624_E[0].Page2[0].rb_tiers[0]", true, "0")]
        [RadioField("EMP5624_E[0].Page2[0].rb_tiers[0]", false, "1")]
        public bool AreYouAppointingAThirdPartyToRepresentYou { get; set; }

        [SimpleTextField("EMP5624_E[0].Page3[0].num_Company_Code[0]")]
        public string CanadaAgencyPayrollAccountNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].num_Company_Code[1]")]
        public string CanadaAgencyPayrollAccountNumber_RP { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_name_Legal[0]")]
        public string BusinessLegalName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_name_commercial[0]")]
        public string BusinessOperatingName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_position_title[0]")]
        public string JobTitle { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_first_name2[0]")]
        public string FirstName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_mid_name2[0]")]
        public string MiddleName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_last_name2[0]")]
        public string LastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_phone_number2[0]")]
        public string TelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_alternate_phone2[0]")]
        public string AlternateTelephoneNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_fax_number2[0]")]
        public string FaxNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_other_Email2[0]")]
        public string EmailAddress { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].rb_other_language_oral2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page3[0].rb_other_language_oral2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredOralCommunicationLanguage { get; set; }

        [RadioField("EMP5624_E[0].Page3[0].rb_other_anguage_written2[0]", LanguageOptions.English, "0")]
        [RadioField("EMP5624_E[0].Page3[0].rb_other_anguage_written2[0]", LanguageOptions.French, "1")]
        public LanguageOptions PreferredWrittenCommunicationLanguage { get; set; }

        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Mail_Adress1[0]")]
        public string BusinessAddressLine1 { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Mail_Adress2[0]")]
        public string BusinessAddressLine2 { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_City[0]")]
        public string BusinessAddressCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Province[0]")]
        public string BusinessAddressProvince { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Country[0]")]
        public string BusinessAddressCountry { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Postal_Code[0]")]
        public string BusinessAddressZipCode { get; set; }
        public bool IsMailingAddressDiferentFromBusinessAddres { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Mail_Adress2-1[0]")]
        public string MailingAddressLine1 { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Mail_Adress2-2[0]")]
        public string MailingAddressLine2 { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_City2[0]")]
        public string MailingAddressCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Province2[0]")]
        public string MailingAddressProvince { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Country2[0]")]
        public string MailingAddressCountry { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Postal_Code2[0]")]
        public string MailingAddressZipCode { get; set; }

        [RadioField("EMP5624_E[0].Page3[0].rb_tiers[0]", true, "0")]
        [RadioField("EMP5624_E[0].Page3[0].rb_tiers[0]", false, "1")]
        public bool IsTheThirdPartyBeingPaidByTheEmployer { get; set; }

        [RadioField("EMP5624_E[0].Page3[0].cb_CCRC[0]", true, "0")]
        public bool Yes_IsTheThirdPartyCCRC { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_CCRC_number[0]")]
        public string Yes_CCRCNumber { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_Law_member[0]", true, "0")]
        public bool Yes_IsTheThirdPartyLawMember { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Law_member_prov[0]")]
        public string Yes_LawMemberProvinceTerritory { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Law_member_numb[0]")]
        public string Yes_LawMemberMembershipId { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_Lawyer[0]", true, "0")]
        public bool Yes_IsTheThirdPartyChambreDesNotairesDuQuebec { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Law_numb[0]")]
        public string Yes_ChambreMembershipId { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_Other_member[0]", true, "0")]
        public bool Yes_IsTheThirdPartyOther { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Other_specify[0]")]
        public string Yes_OtherSpecify { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_family[0]", true, "0")]
        public bool No_ItIsPaidByFamilyOrFriend { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_org_member[0]", true, "0")]
        public bool No_ItIsPaidByONG { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_rules_member[0]", true, "0")]
        public bool No_ItIsPaidByICCRC { get; set; }
        [RadioField("EMP5624_E[0].Page3[0].cb_other_member[0]", true, "0")]
        public bool No_ItIsPaidByOther { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_Other_specify2[0]")]
        public string No_OtherSpecify { get; set; }
    }
    public class Section5
    {
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_position_title[0]")]
        public string JobTitle { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_code[0]")]
        public string NOC { get; set; }
        [SimpleTextField("EMP5624_E[0].Page3[0].txtF_position_title[1]")]
        public int HowManyTWFsIsTheEmployerRequestingForThisJobOffer { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_MainDuties[0]")]
        public string MainDutiesOfTheJob { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page4[0].txtF_Date_E[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime ExpectedStartDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_number_days[0]")]
        public int txtF_number_days { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].chkB_english1[0]", EmploymentDurationOptions.Days)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_english1[1]", EmploymentDurationOptions.Weeks)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_english1[2]", EmploymentDurationOptions.Months)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_english1[3]", EmploymentDurationOptions.Years)]
        public EmploymentDurationOptions chkB_english1 { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_justification[0]")]
        public string txtF_justification { get; set; }

        [RadioField("EMP5624_E[0].Page4[0].rb_job_syndic[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page4[0].rb_job_syndic[0]", true, "1")]
        public bool IsThePositionPartOfAUnion { get; set; }

        [RadioField("EMP5624_E[0].Page4[0].chkB_OrallyIn[0]", true)]
        public bool RequiresAbilityToCommunicateOrallyIn { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].chkB_english1[4]", CommunicationOptions.English)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_French1[0]", CommunicationOptions.French)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_English_French1[0]", CommunicationOptions.EnglishAndFrench)]
        public CommunicationOptions CommunicationOrally { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].chkB_TheOffer[0]", true)]
        public bool RequiresAbilityToCommunicateWritingIn { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].chkB_english2[0]", CommunicationOptions.English)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_french2[0]", CommunicationOptions.French)]
        [RadioField("EMP5624_E[0].Page4[0].chkB_English_French2[0]", CommunicationOptions.EnglishAndFrench)]
        public CommunicationOptions CommunicationWriting { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].chkB_TheOffer2[0]", true)]
        public bool TheOfferNotRequireTheAbillityToCommunicate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_ProvideDetails2[0]")]
        public string TheOfferNotRequireTheAbillityToCommunicateDetail { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].chkB_TheOffer2[1]", true)]
        public bool TheOfferRequireTheAbillityToCommunicateInLanguageOtherThanEnglishAndFrench { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_ProvideDetails3[0]")]
        public string TheOfferRequireTheAbillityToCommunicateInLanguageOtherThanEnglishAndFrenchDetail { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.DoctoratePhD, "0")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.DoctorOfMedicine, "1")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.MasterDegree, "2")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.BachelorsDegree, "3")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.CollegeLevelDiplomaCertificate, "4")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.ApprenticeshipDiplomaCertificate, "5")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.TradeDiplomaCertificate, "6")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.SecondarySchool, "7")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.VocationalSchoolDiplomaCertificate, "8")]
        [RadioField("EMP5624_E[0].Page4[0].RadioButtonList[0]", MinimumEducationOptions.NoFormalEducationRequirement, "9")]
        public MinimumEducationOptions MinimumEducation { get; set; }

        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_AdditionalInformation[0]")]
        public string MinimumEducationAdditionalInformation { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_MainDuties[1]")]
        public string MinimumExperienceSkillRequirements { get; set; }
        [RadioField("EMP5624_E[0].Page4[0].Yes_E[0]", true)]
        [RadioField("EMP5624_E[0].Page4[0].No_E[0]", false)]
        public bool HaveYouTriedToRecruitCanadiansPermanentResidentsPrior { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_AdditionalInformation[1]")]
        public string HaveYouTriedToRecruitCanadiansPermanentResidentsPrior_Yes_AdditionalInformation { get; set; }
        [SimpleTextField("EMP5624_E[0].Page4[0].txtF_No_AdditionalInformation[0]")]
        public string HaveYouTriedToRecruitCanadiansPermanentResidentsPrior_No_AdditionalInformation { get; set; }
        [RadioField("EMP5624_E[0].Page5[0].rb_canadian_empl[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page5[0].rb_canadian_empl[0]", true, "1")]
        public bool WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_canadian_how_many[0]")]
        public int? WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months_Yes_HowManyCanadiansPermResid { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_TET_how_many[0]")]
        public int? WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months_Yes_HowManyTWFs { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_info[0]")]
        public string WereAnyEmployeesWorkingInThisPositionLaidOffLast12Months_Yes_Reasons { get; set; }
        [RadioField("EMP5624_E[0].Page5[0].rb_TET_empl[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page5[0].rb_TET_empl[0]", true, "1")]
        public bool TheHiringCauseImpactInCanadianWorkForce { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_No_add_info[0]")]
        public string TheHiringCauseImpactInCanadianWorkForce_Yes_Details { get; set; }
    }
    public class Section6
    {
        [CheckboxField("EMP5624_E[0].Page5[0].chkB_no_employees[0]", true)]
        public bool ThereAreAnyEmployeesOnTheSameOccupation { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page5[0].txtF_low_wage[0]", typeof(decimal), "0.00")]
        public decimal? WageRangeSameOccupation_Low { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page5[0].txtF_high_wage[0]", typeof(decimal), "0.00")]
        public decimal? WageRangeSameOccupation_High { get; set; }
        [RadioField("EMP5624_E[0].Page5[0].rb_hours[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page5[0].rb_hours[0]", true, "1")]
        public bool IsAFullTimeJobAtLeast30HoursPerWeek { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_IfNo[0]")]
        public string IsAFullTimeJobAtLeast30HoursPerWeek_No_Explain { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtFhours[0]")]
        public int HowManyHoursEachDay { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_week[0]")]
        public int? HowManyHoursEachWeek { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_month[0]")]
        public int? HowManyHoursEachMonth { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page5[0].txtF_salary_hours[0]", typeof(decimal), "0.00")]
        public decimal SalaryPerHour { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page5[0].txtF_salary_overtime[0]", typeof(decimal), "0.00")]
        public decimal? OertimeSalaryPerHour { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_salary_after[0]")]
        public int? OvertimeStartingHoursPerDay { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_hour_week[0]")]
        public int? OvertimeStartingHoursPerWeek { get; set; }
        [RadioField("EMP5624_E[0].Page5[0].rb_salary_conversion[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page5[0].rb_salary_conversion[0]", true, "1")]
        public bool DidYouConvertTheWageFromMonthlyOrYearlyOrCurrencyToOtherThanCADOrBoth { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_yes_add_info[0]")]
        public string DidYouConvertTheWageFromMonthlyOrYearlyOrCurrencyToOtherThanCADOrBoth_Yes_Info { get; set; }

        [CheckboxField("EMP5624_E[0].Page5[0].chkB_DisabilityInsurance[0]", BenefitsOptions.DisabilityInsurance)]
        [CheckboxField("EMP5624_E[0].Page5[0].chkB_DentalInsurance[0]", BenefitsOptions.DentalInsurance)]
        [CheckboxField("EMP5624_E[0].Page5[0].chkB_Pension[0]", BenefitsOptions.Pension)]
        [CheckboxField("EMP5624_E[0].Page5[0].chkB_ExtendedMed[0]", BenefitsOptions.ExtendedMedicalInsurance)]
        public BenefitsOptions[] Benefits { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_OtherBenefits[0]")]
        public string OtherBenefits { get; set; }
        [SimpleTextField("EMP5624_E[0].Page5[0].txtF_Days[0]")]
        public int? VacationNumberOfBusinessDaysPerYear { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page5[0].txtF_Remuneration[0]", typeof(decimal), "0.00")]
        public decimal? VacationRemunarationPercentageGrossSalaray { get; set; }
    }
    public class Section7
    {

        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_principal_activity[0]")]
        public string DescribePrincipalActivity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_commercial_name[0]")]
        public string BusinessOperationName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_where[0]")]
        public string WorkLocation { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_City2[0]")]
        public string WorkLocationCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_Province2[0]")]
        public string WorkLocationProvince { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_Postal_Code2[0]")]
        public string WorkLocationPostalCode { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_where[1]")]
        public string OtherWorkLocation { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_City2[1]")]
        public string OtherWorkLocationCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_Province2[1]")]
        public string OtherWorkLocationProvince { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_Postal_Code2[1]")]
        public string OtherWorkLocationPostalCode { get; set; }
        [RadioField("EMP5624_E[0].Page6[0].rb_conflict[0]", false, "0")]
        [RadioField("EMP5624_E[0].Page6[0].rb_conflict[0]", true, "1")]
        public bool IsThereALaborDisputenProgressAtAnyWorkLocations { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_yes_add_info[0]")]
        public string IsThereALaborDisputenProgressAtAnyWorkLocations_Yes_Details { get; set; }
    }
    public class Section8
    {

        [RadioField("EMP5624_E[0].Page6[0].rb_conflict[1]", false, "0")]
        [RadioField("EMP5624_E[0].Page6[0].rb_conflict[1]", true, "1")]
        public bool DoesYourORganisationHaveActiveLaburMarketBenefitsPlan { get; set; }
    }
    public class Section9
    {
        [SimpleTextField("EMP5624_E[0].Page6[0].txtF_advantage[0]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page6[0].Table1[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page6[0].Table1[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class Section10
    {
        [ClassWithFieldsDefinition]
        public ComplementaryBenefit1 ComplementaryBenefit1 { get; set; }
        [ClassWithFieldsDefinition]
        public ComplementaryBenefit2 ComplementaryBenefit2 { get; set; }
        [ClassWithFieldsDefinition]
        public ComplementaryBenefit3 ComplementaryBenefit3 { get; set; }
        [ClassWithFieldsDefinition]
        public ComplementaryBenefit4 ComplementaryBenefit4 { get; set; }
        [ClassWithFieldsDefinition]
        public ComplementaryBenefit5 ComplementaryBenefit5 { get; set; }
        [ClassWithFieldsDefinition]
        public ComplementaryBenefit6 ComplementaryBenefit6 { get; set; }


    }
    public class ComplementaryBenefit1
    {

        [SimpleTextField("EMP5624_E[0].Page7[0].txtF_advantage1[0]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table1[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table1[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class ComplementaryBenefit2
    {

        [SimpleTextField("EMP5624_E[0].Page7[0].txtF_advantage1[1]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table2[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table2[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class ComplementaryBenefit3
    {
        [SimpleTextField("EMP5624_E[0].Page7[0].txtF_advantage1[2]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page7[0].Table3[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page7[0].Table3[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class ComplementaryBenefit4
    {

        [SimpleTextField("EMP5624_E[0].Page8[0].txtF_advantage1[1]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table1[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table1[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class ComplementaryBenefit5
    {

        [SimpleTextField("EMP5624_E[0].Page8[0].txtF_advantage1[1]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table2[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table2[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class ComplementaryBenefit6
    {

        [SimpleTextField("EMP5624_E[0].Page8[0].txtF_advantage1[2]")]
        public string WichAdavantageWillBeAchievedByHiringTFW { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row1[0].TextField1[0]")]
        public string Row1_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row1[0].TextField2[0]")]
        public string Row1_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row1[0].DateField1[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row1[0].DateField2[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row1_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row2[0].TextField3[0]")]
        public string Row2_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row2[0].TextField4[0]")]
        public string Row2_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row2[0].DateField3[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row2[0].DateField4[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row2_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row3[0].TextField5[0]")]
        public string Row3_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row3[0].TextField6[0]")]
        public string Row3_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row3[0].DateField5[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row3[0].DateField6[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row3_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row4[0].TextField7[0]")]
        public string Row4_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row4[0].TextField8[0]")]
        public string Row4_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row4[0].DateField7[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row4[0].DateField8[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row4_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row5[0].TextField9[0]")]
        public string Row5_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row5[0].TextField10[0]")]
        public string Row5_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row5[0].DateField9[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row5[0].DateField10[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row5_EndDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row6[0].TextField11[0]")]
        public string Row6_ActivityMilestone { get; set; }
        [SimpleTextField("EMP5624_E[0].Page8[0].Table3[0].Row6[0].TextField12[0]")]
        public string Row6_Target { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row6[0].DateField11[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_StartDate { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page8[0].Table3[0].Row6[0].DateField12[0]", typeof(DateTime), "MM/dd/yyyy")]
        public DateTime? Row6_EndDate { get; set; }
    }
    public class Section11
    {

        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Signature[0]")]
        public string EmployerSignature { get; set; }
        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[0]")]
        public string EmployerPrintName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Title[0]")]
        public string EmployerTitle { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page9[0].txtF_Today_Date_1[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime TodayDate { get; set; }

        [ClassWithFieldsDefinition]
        public Section11a section11a { get; set; }
        [ClassWithFieldsDefinition]
        public Section11b section11b { get; set; }
    }
    public class Section11a
    {

        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Signature[1]")]
        public string EmployerSignature { get; set; }
        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[1]")]
        public string EmployerPrintName { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page9[0].txtF_Today_Date_1[1]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime TodayDate { get; set; }
    }
    public class Section11b
    {

        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Signature[2]")]
        public string EmployerSignature { get; set; }
        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[2]")]
        public string EmployerPrintName { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page9[0].txtF_Today_Date_1[2]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime EmployerDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Signature[3]")]
        public string WitnessSignature { get; set; }
        [SimpleTextField("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[3]")]
        public string WitnessPrintName { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page9[0].txtF_Today_Date_1[3]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime WitnessDate { get; set; }
    }
    public class SectionFee
    {

        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Off_use[0]")]
        public string OfficeUseOnly => "";
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_EMployer_Name[0]")]
        public string EmployerName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_CRA_Business_Number[0]")]
        public string CRABusinessNumber { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Number_Positions[0]")]
        public string NumberPositions { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page11[0].txtF_Processing_Fee[0]", typeof(decimal), "0.00")]
        public decimal ProcessingFee { get; set; }
        [RadioField("EMP5624_E[0].Page11[0].rb_Payment[0]", PaymentMethodOptions.CertifiedChequeOrMoney, "0")]
        [RadioField("EMP5624_E[0].Page11[0].rb_Payment[0]", PaymentMethodOptions.CreditCard, "1")]
        public PaymentMethodOptions PaymentMethod { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Given_Names[0]")]
        public string CardHolderNamePrintedOnCard { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Applicant_Name[0]")]
        public string EmployerPrimaryContactName { get; set; }
        [RadioField("EMP5624_E[0].Page11[0].rb_Card_Type[0]", CreditCardOptions.Visa, "0")]
        [RadioField("EMP5624_E[0].Page11[0].rb_Card_Type[0]", CreditCardOptions.MasterCard, "1")]
        [RadioField("EMP5624_E[0].Page11[0].rb_Card_Type[0]", CreditCardOptions.AmericanExpress, "2")]
        public CreditCardOptions CreditCardType { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Applicant_Name[1]")]
        public int Last4DigitsOfCreditCard { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page11[0].txtF_Charge[0]", typeof(decimal), "0.00")]
        public decimal TotalOfCharge { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Signature_E[0]")]
        public string SignatureOfCardHolder => "";
        public DateTime CreditCardInfoDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Day[0]")]
        public int Day_DD => CreditCardInfoDate.Day;
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Month[0]")]
        public int Month_MM => CreditCardInfoDate.Month;
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Year[0]")]
        public int Year_YYYY => CreditCardInfoDate.Year;
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Card_Number[0]")]
        public string CreditCardNumber { get; set; }
        public DateTime CreditCardExpirationDate { get; set; }
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Month[1]")]
        public int CreditCardExpirationDate_Month => CreditCardExpirationDate.Month;
        [SimpleTextField("EMP5624_E[0].Page11[0].txtF_Year[1]")]
        public int CreditCardExpirationDate__Year => CreditCardExpirationDate.Year;
    }
    public class SectionWorkersInformation
    {

        [ClassWithFieldsDefinition]
        public Worker1 Workers1 { get; set; }
        [ClassWithFieldsDefinition]
        public Worker2 Workers2 { get; set; }
        [ClassWithFieldsDefinition]
        public Worker3 Workers3 { get; set; }
        [ClassWithFieldsDefinition]
        public Worker4 Workers4 { get; set; }
        [ClassWithFieldsDefinition]
        public Worker5 Workers5 { get; set; }
    }

    public class Worker1
    {
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Family_Name1[0]")]
        public string PassportLastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_First_Name1[0]")]
        public string PassportFirstName { get; set; }
        [RadioField("EMP5624_E[0].Page12[0].rb_Gender1[0]", GenderOptions.Male, "0")]
        [RadioField("EMP5624_E[0].Page12[0].rb_Gender1[0]", GenderOptions.Female, "1")]
        public GenderOptions Gender { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page12[0].txtF_Date_of_Birth1[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime DateOfBirth { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Citizenship1[0]")]
        public string Citizenship { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_City1[0]")]
        public string City { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Country1[0]")]
        public string Country { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_City1b[0]")]
        public string ResidentCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Country1b[0]")]
        public string ResidentCountry { get; set; }
        [CheckboxField("EMP5624_E[0].Page12[0].Temporary_foreign_worker1[0]", ImmigrationStatusOptions.TemporaryForeignWorker)]
        [CheckboxField("EMP5624_E[0].Page12[0].visitor[0]", ImmigrationStatusOptions.Visitor)]
        [CheckboxField("EMP5624_E[0].Page12[0].student[0]", ImmigrationStatusOptions.Student)]
        [CheckboxField("EMP5624_E[0].Page12[0].refugie_demandeur[0]", ImmigrationStatusOptions.RefugeeClaimant)]
        public ImmigrationStatusOptions[] ImmigrationStatus { get; set; }
    }
    public class Worker2
    {
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Family_Name2[0]")]
        public string PassportLastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_First_Name2[0]")]
        public string PassportFirstName { get; set; }
        [RadioField("EMP5624_E[0].Page12[0].rb_Gender2[0]", GenderOptions.Male, "0")]
        [RadioField("EMP5624_E[0].Page12[0].rb_Gender2[0]", GenderOptions.Female, "1")]
        public GenderOptions Gender { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page12[0].txtF_Date_of_Birth2[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime DateOfBirth { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Citizenship1[1]")]
        public string Citizenship { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_City2[0]")]
        public string City { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Country2[0]")]
        public string Country { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_City2b[0]")]
        public string ResidentCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Country2b[0]")]
        public string ResidentCountry { get; set; }
        [CheckboxField("EMP5624_E[0].Page12[0].Temporary_foreign_worker2[0]", ImmigrationStatusOptions.TemporaryForeignWorker)]
        [CheckboxField("EMP5624_E[0].Page12[0].visitor2[0]", ImmigrationStatusOptions.Visitor)]
        [CheckboxField("EMP5624_E[0].Page12[0].student2[0]", ImmigrationStatusOptions.Student)]
        [CheckboxField("EMP5624_E[0].Page12[0].refugie_demandeur2[0]", ImmigrationStatusOptions.RefugeeClaimant)]
        public ImmigrationStatusOptions[] ImmigrationStatus { get; set; }
    }
    public class Worker3
    {

        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Family_Name3[0]")]
        public string PassportLastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_First_Name2[1]")]
        public string PassportFirstName { get; set; }
        [RadioField("EMP5624_E[0].Page12[0].rb_Gender3[0]", GenderOptions.Male, "0")]
        [RadioField("EMP5624_E[0].Page12[0].rb_Gender3[0]", GenderOptions.Female, "1")]
        public GenderOptions Gender { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page12[0].txtF_Date_of_Birth3[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime DateOfBirth { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Citizenship3[0]")]
        public string Citizenship { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_City3[0]")]
        public string City { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Country3[0]")]
        public string Country { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_City3b[0]")]
        public string ResidentCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page12[0].txtF_Country1b[1]")]
        public string ResidentCountry { get; set; }
        [CheckboxField("EMP5624_E[0].Page12[0].Temporary_foreign_worker3[0]", ImmigrationStatusOptions.TemporaryForeignWorker)]
        [CheckboxField("EMP5624_E[0].Page12[0].visitor3[0]", ImmigrationStatusOptions.Visitor)]
        [CheckboxField("EMP5624_E[0].Page12[0].student3[0]", ImmigrationStatusOptions.Student)]
        [CheckboxField("EMP5624_E[0].Page12[0].refugie_demandeur3[0]", ImmigrationStatusOptions.RefugeeClaimant)]
        public ImmigrationStatusOptions[] ImmigrationStatus { get; set; }
    }
    public class Worker4
    {

        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Family_Name4[0]")]
        public string PassportLastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_First_Name4[0]")]
        public string PassportFirstName { get; set; }
        [RadioField("EMP5624_E[0].Page13[0].rb_Gender4[0]", GenderOptions.Male, "0")]
        [RadioField("EMP5624_E[0].Page13[0].rb_Gender4[0]", GenderOptions.Female, "1")]
        public GenderOptions Gender { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page13[0].txtF_Date_of_Birth4[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime DateOfBirth { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Citizenship4[0]")]
        public string Citizenship { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_City4[0]")]
        public string City { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Country4[0]")]
        public string Country { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_City4b[0]")]
        public string ResidentCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Country4b[0]")]
        public string ResidentCountry { get; set; }
        [CheckboxField("EMP5624_E[0].Page13[0].Temporary_foreign_worker4[0]", ImmigrationStatusOptions.TemporaryForeignWorker)]
        [CheckboxField("EMP5624_E[0].Page13[0].visitor4[0]", ImmigrationStatusOptions.Visitor)]
        [CheckboxField("EMP5624_E[0].Page13[0].student4[0]", ImmigrationStatusOptions.Student)]
        [CheckboxField("EMP5624_E[0].Page13[0].refugie_demandeur4[0]", ImmigrationStatusOptions.RefugeeClaimant)]
        public ImmigrationStatusOptions[] ImmigrationStatus { get; set; }
    }
    public class Worker5
    {

        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Family_Name5[0]")]
        public string PassportLastName { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_First_Name5[0]")]
        public string PassportFirstName { get; set; }
        [RadioField("EMP5624_E[0].Page13[0].rb_Gender5[0]", GenderOptions.Male, "0")]
        [RadioField("EMP5624_E[0].Page13[0].rb_Gender5[0]", GenderOptions.Female, "1")]
        public GenderOptions Gender { get; set; }
        [TextFieldFormatted("EMP5624_E[0].Page13[0].txtF_Date_of_Birth5[0]", typeof(DateTime), "yyyy-MM-dd")]
        public DateTime DateOfBirth { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Citizenship5[0]")]
        public string Citizenship { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_City5[0]")]
        public string City { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Country5[0]")]
        public string Country { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_City5b[0]")]
        public string ResidentCity { get; set; }
        [SimpleTextField("EMP5624_E[0].Page13[0].txtF_Country5b[0]")]
        public string ResidentCountry { get; set; }
        [CheckboxField("EMP5624_E[0].Page13[0].Temporary_foreign_worker5[0]", ImmigrationStatusOptions.TemporaryForeignWorker)]
        [CheckboxField("EMP5624_E[0].Page13[0].visitor5[0]", ImmigrationStatusOptions.Visitor)]
        [CheckboxField("EMP5624_E[0].Page13[0].student5[0]", ImmigrationStatusOptions.Student)]
        [CheckboxField("EMP5624_E[0].Page13[0].refugie_demandeur5[0]", ImmigrationStatusOptions.RefugeeClaimant)]
        public ImmigrationStatusOptions[] ImmigrationStatus { get; set; }
    }
}
