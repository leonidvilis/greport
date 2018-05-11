
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTest;
namespace GetReport.BL

{
    public static class WordPublisherReportOSR //: IPublisher<DocsHierarchy.ReportOSR>
    {
        /// <summary>
        /// Список для хранения констант попадающих в акт при импорте.
        /// </summary>
        public static List<string> PublishRules = new List<string>();

        public static string templatePath;
        public static void GetPublishRulesReportOSR(string rulesPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(rulesPath, Encoding.Default))
                {
                    string line = " ";
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        PublishRules.Add(line);
                    }
                }

            }
            catch (FileLoadException)
            {
                throw;
            }
        }

        public static Dictionary<string, string> SetDictionaryValues(List<string> list, DocsHierarchy.ReportOSR entity)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Clear();
            foreach (var item in list)
            {
                switch (item)
                {
                    case ("NameAndAddressOfObject"):                        
                        if (entity.NameAndAddressOfObject == null)
                        {
                            dict.Add("NameAndAddressOfObject", " ");
                        }
                        else
                        {
                            dict.Add("NameAndAddressOfObject", entity.NameAndAddressOfObject);
                        }
                        break;
                    case ("RequisitesOfConsumer"):                        
                        if (entity.RequisitesOfConsumer == null)
                        {
                            dict.Add("RequisitesOfConsumer", " ");
                        }
                        else
                        {
                            dict.Add("RequisitesOfConsumer", entity.RequisitesOfConsumer);
                        }
                        break;
                    case ("RequisitesOfPrimeContractor"):                        
                        if (entity.RequisitesOfPrimeContractor == null)
                        {
                            dict.Add("RequisitesOfPrimeContractor", " ");
                        }
                        else
                        {
                            dict.Add("RequisitesOfPrimeContractor", entity.RequisitesOfPrimeContractor);
                        }
                        break;
                    case ("RequisitesOfProjectDeveloper"):                        
                        if (entity.RequisitesOfProjectDeveloper == null)
                        {
                            dict.Add("RequisitesOfProjectDeveloper", " ");
                        }
                        else
                        {
                            dict.Add("RequisitesOfProjectDeveloper", entity.RequisitesOfProjectDeveloper);
                        }
                        break;
                    case ("RequisitesOfBuilder"):                        
                        if (entity.RequisitesOfBuilder == null)
                        {
                            dict.Add("RequisitesOfBuilder", " ");
                        }
                        else
                        {
                            dict.Add("RequisitesOfBuilder", entity.RequisitesOfBuilder);
                        }
                        break;
                    case ("NumberOfReport"):                        
                        if (entity.NumberOfReport == null)
                        {
                            dict.Add("NumberOfReport", " ");
                        }
                        else
                        {
                            dict.Add("NumberOfReport", entity.NumberOfReport);
                        }
                        break;
                    case ("DateOfPreparationOfReport"):                        
                        if (entity.DateOfPreparationOfReport == null)
                        {
                            dict.Add("DateOfPreparationOfReport", " ");
                        }
                        else
                        {
                            dict.Add("DateOfPreparationOfReport", entity.DateOfPreparationOfReport.ToShortDateString());
                        }
                        break;
                    case ("DelegateOfConsumer"):
                        if (entity.DelegateOfConsumer == null)
                        {
                            dict.Add("DelegateOfConsumer", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfConsumer", String.Format(
                                  entity.DelegateOfConsumer.Post + " "
                                + entity.DelegateOfConsumer.Company + " "
                                + entity.DelegateOfConsumer.LastName + " "
                                + entity.DelegateOfConsumer.FirstName.First<char>() + "."
                                + entity.DelegateOfConsumer.Patronymic.First<char>() + ". "
                                + entity.DelegateOfConsumer.Order));
                        }
                        break;
                    case ("DelegateOfPrimeContractor"):
                        if (entity.DelegateOfPrimeContractor == null)
                        {
                            dict.Add("DelegateOfPrimeContractor", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfPrimeContractor", String.Format(
                                  entity.DelegateOfPrimeContractor.Post + " "
                                + entity.DelegateOfPrimeContractor.Company + " "
                                + entity.DelegateOfPrimeContractor.LastName + " "
                                + entity.DelegateOfPrimeContractor.FirstName.First<char>() + "."
                                + entity.DelegateOfPrimeContractor.Patronymic.First<char>() + ". "
                                + entity.DelegateOfPrimeContractor.Order));
                        }
                            break;
                    case ("DelegateOfBuildControlPrimeContractor"):
                        if (entity.DelegateOfBuildControlPrimeContractor == null)
                        {
                            dict.Add("DelegateOfBuildControlPrimeContractor", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfBuildControlPrimeContractor", String.Format(
                                  entity.DelegateOfBuildControlPrimeContractor.Post + " "
                                + entity.DelegateOfBuildControlPrimeContractor.Company + " "
                                + entity.DelegateOfBuildControlPrimeContractor.LastName + " "
                                + entity.DelegateOfBuildControlPrimeContractor.FirstName.First<char>() + "."
                                + entity.DelegateOfBuildControlPrimeContractor.Patronymic.First<char>() + ". "
                                + entity.DelegateOfBuildControlPrimeContractor.Order));
                        }
                            break;
                    case ("DelegateOfProjectDeveloper"):
                        if (entity.DelegateOfProjectDeveloper == null)
                        {
                            dict.Add("DelegateOfProjectDeveloper", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfProjectDeveloper", String.Format(
                                  entity.DelegateOfProjectDeveloper.Post + " "
                                + entity.DelegateOfProjectDeveloper.Company + " "
                                + entity.DelegateOfProjectDeveloper.LastName + " "
                                + entity.DelegateOfProjectDeveloper.FirstName.First<char>() + "."
                                + entity.DelegateOfProjectDeveloper.Patronymic.First<char>() + ". "
                                + entity.DelegateOfProjectDeveloper.Order));
                        }
                            break;
                    case ("DelegateOfBuilder"):
                        if (entity.DelegateOfBuilder == null)
                        {
                            dict.Add("DelegateOfBuilder", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfBuilder", String.Format(
                              entity.DelegateOfBuilder.Post + " "
                            + entity.DelegateOfBuilder.Company + " "
                            + entity.DelegateOfBuilder.LastName + " "
                            + entity.DelegateOfBuilder.FirstName.First<char>() + "."
                            + entity.DelegateOfBuilder.Patronymic.First<char>() + ". "
                            + entity.DelegateOfBuilder.Order));
                        }
                        break;
                    case ("DelegateOfOtherCompany"):
                        if (entity.DelegateOfOtherCompany == null)
                        {
                            dict.Add("DelegateOfOtherCompany", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfOtherCompany", String.Format(
                              entity.DelegateOfOtherCompany.Post + " "
                            + entity.DelegateOfOtherCompany.Company + " "
                            + entity.DelegateOfOtherCompany.LastName + " "
                            + entity.DelegateOfOtherCompany.FirstName.First<char>() + "."
                            + entity.DelegateOfOtherCompany.Patronymic.First<char>() + ". "
                            + entity.DelegateOfOtherCompany.Order));
                        }
                        break;
                    case ("DelegateOfOtherCompany2"):
                        if (entity.DelegateOfOtherCompany2 == null)
                        {
                            dict.Add("DelegateOfOtherCompany2", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfOtherCompany2", String.Format(
                              entity.DelegateOfOtherCompany2.Post + " "
                            + entity.DelegateOfOtherCompany2.Company + " "
                            + entity.DelegateOfOtherCompany2.LastName + " "
                            + entity.DelegateOfOtherCompany2.FirstName.First<char>() + "."
                            + entity.DelegateOfOtherCompany2.Patronymic.First<char>() + ". "
                            + entity.DelegateOfOtherCompany2.Order));
                        }
                        break;
                    case ("DelegateOfOtherCompany3"):
                        if (entity.DelegateOfOtherCompany3 == null)
                        {
                            dict.Add("DelegateOfOtherCompany3", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfOtherCompany3", String.Format(
                              entity.DelegateOfOtherCompany3.Post + " "
                            + entity.DelegateOfOtherCompany3.Company + " "
                            + entity.DelegateOfOtherCompany3.LastName + " "
                            + entity.DelegateOfOtherCompany3.FirstName.First<char>() + "."
                            + entity.DelegateOfOtherCompany3.Patronymic.First<char>() + ". "
                            + entity.DelegateOfOtherCompany3.Order));
                        }
                        break;
                    case ("Builder"):                        
                        if (entity.DelegateOfBuilder == null)
                        {
                            dict.Add("Builder", " ");
                        }
                        else
                        {
                            dict.Add("Builder", entity.DelegateOfBuilder.Company);
                        }
                        break;
                    case ("WorkName"):                        
                        if (entity.WorkName == null)
                        {
                            dict.Add("WorkName", " ");
                        }
                        else
                        {
                            dict.Add("WorkName", entity.WorkName);
                        }
                        break;
                    case ("ProjectTheWorkIncluded"):                        
                        if (entity.ProjectTheWorkIncluded == null)
                        {
                            dict.Add("ProjectTheWorkIncluded", " ");
                        }
                        else
                        {
                            dict.Add("ProjectTheWorkIncluded", entity.ProjectTheWorkIncluded);
                        }
                        break;
                    case ("TheListOfMaterial"):                        
                        if (entity.TheListOfMaterial == null)
                        {
                            dict.Add("TheListOfMaterial", " ");
                        }
                        else
                        {
                            dict.Add("TheListOfMaterial", entity.TheListOfMaterial);
                        }
                        break;
                    case ("TheListOfQuantityConsistDocs"):                        
                        if (entity.TheListOfQuantityConsistDocs == null)
                        {
                            dict.Add("TheListOfQuantityConsistDocs", " ");
                        }
                        else
                        {
                            dict.Add("TheListOfQuantityConsistDocs", entity.TheListOfQuantityConsistDocs);
                        }
                        break;
                    case ("TheDateOfWorkStart"):                        
                        if (entity.TheDateOfWorkStart == null)
                        {
                            dict.Add("TheDateOfWorkStart", " ");
                        }
                        else
                        {
                            dict.Add("TheDateOfWorkStart", entity.TheDateOfWorkStart.ToShortDateString());
                        }
                        break;
                    case ("TheDateOfWorkEnding"):                        
                        if (entity.TheDateOfWorkEnding == null)
                        {
                            dict.Add("TheDateOfWorkEnding", " ");
                        }
                        else
                        {
                            dict.Add("TheDateOfWorkEnding", entity.TheDateOfWorkEnding.ToShortDateString());
                        }
                        break;
                    case ("TheListOfDocumentConsists"):                        
                        if (entity.TheListOfDocumentConsists == null)
                        {
                            dict.Add("TheListOfDocumentConsists", " ");
                        }
                        else
                        {
                            dict.Add("TheListOfDocumentConsists", entity.TheListOfDocumentConsists);
                        }
                        break;
                    case ("TheNextWorkIsAccepted"):                        
                        if (entity.TheNextWorkIsAccepted == null)
                        {
                            dict.Add("TheNextWorkIsAccepted", " ");
                        }
                        else
                        {
                            dict.Add("TheNextWorkIsAccepted", entity.TheNextWorkIsAccepted);
                        }
                        break;
                    case ("Annexes"):                        
                        if (entity.Annexes == null)
                        {
                            dict.Add("Annexes", " ");
                        }
                        else
                        {
                            dict.Add("Annexes", entity.Annexes);
                        }
                        break;
                    case ("DelegateOfConsumerShort"):
                        if (entity.DelegateOfConsumer == null)
                        {
                            dict.Add("DelegateOfConsumerShort", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfConsumerShort", String.Format(
                              entity.DelegateOfConsumer.Post + " "
                            + entity.DelegateOfConsumer.LastName + " "
                            + entity.DelegateOfConsumer.FirstName.First<char>() + "."
                            + entity.DelegateOfConsumer.Patronymic.First<char>() + "."));
                        }
                        break;
                    case ("DelegateOfPrimeContractorShort"):
                        if (entity.DelegateOfPrimeContractor == null)
                        {
                            dict.Add("DelegateOfPrimeContractorShort", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfPrimeContractorShort", String.Format(
                              entity.DelegateOfPrimeContractor.Post + " "
                            + entity.DelegateOfPrimeContractor.LastName + " "
                            + entity.DelegateOfPrimeContractor.FirstName.First<char>() + "."
                            + entity.DelegateOfPrimeContractor.Patronymic.First<char>() + ". "));
                        }
                        break;
                    case ("DelegateOfBuildControlPrimeContractorShort"):
                        if (entity.DelegateOfBuildControlPrimeContractor == null)
                        {
                            dict.Add("DelegateOfBuildControlPrimeContractorShort", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfBuildControlPrimeContractorShort", String.Format(
                              entity.DelegateOfBuildControlPrimeContractor.Post + " "
                            + entity.DelegateOfBuildControlPrimeContractor.LastName + " "
                            + entity.DelegateOfBuildControlPrimeContractor.FirstName.First<char>() + "."
                            + entity.DelegateOfBuildControlPrimeContractor.Patronymic.First<char>() + ". "));
                        }
                        break;
                    case ("DelegateOfProjectDeveloperShort"):
                        if (entity.DelegateOfProjectDeveloper == null)
                        {
                            dict.Add("DelegateOfProjectDeveloperShort", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfProjectDeveloperShort", String.Format(
                              entity.DelegateOfProjectDeveloper.Post + " "
                            + entity.DelegateOfProjectDeveloper.LastName + " "
                            + entity.DelegateOfProjectDeveloper.FirstName.First<char>() + "."
                            + entity.DelegateOfProjectDeveloper.Patronymic.First<char>() + ". "));
                        }
                        break;
                    case ("DelegateOfBuilderShort"):
                        if (entity.DelegateOfBuilder == null)
                        {
                            dict.Add("DelegateOfBuilderShort", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfBuilderShort", String.Format(
                              entity.DelegateOfBuilder.Post + " "
                            + entity.DelegateOfBuilder.LastName + " "
                            + entity.DelegateOfBuilder.FirstName.First<char>() + "."
                            + entity.DelegateOfBuilder.Patronymic.First<char>() + ". "));
                        }
                        break;
                    case ("DelegateOfOtherCompanyShort"):
                        if (entity.DelegateOfOtherCompany == null)
                        {
                            dict.Add("DelegateOfOtherCompanyShort", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfOtherCompanyShort", String.Format(
                              entity.DelegateOfOtherCompany.Post + " "
                            + entity.DelegateOfOtherCompany.LastName + " "
                            + entity.DelegateOfOtherCompany.FirstName.First<char>() + "."
                            + entity.DelegateOfOtherCompany.Patronymic.First<char>() + ". "));
                        }
                        break;
                    case ("DelegateOfOtherCompany2Short"):
                        if (entity.DelegateOfOtherCompany2 == null)
                        {
                            dict.Add("DelegateOfOtherCompany2Short", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfOtherCompany2Short", String.Format(
                              entity.DelegateOfOtherCompany2.Post + " "
                            + entity.DelegateOfOtherCompany2.LastName + " "
                            + entity.DelegateOfOtherCompany2.FirstName.First<char>() + "."
                            + entity.DelegateOfOtherCompany2.Patronymic.First<char>() + ". "));
                        }
                        break;
                    case ("DelegateOfOtherCompany3Short"):
                        if (entity.DelegateOfOtherCompany3 == null)
                        {
                            dict.Add("DelegateOfOtherCompany3Short", " ");
                            break;
                        }
                        else
                        {
                            dict.Add("DelegateOfOtherCompany3Short", String.Format(
                              entity.DelegateOfOtherCompany3.Post + " "
                            + entity.DelegateOfOtherCompany3.LastName + " "
                            + entity.DelegateOfOtherCompany3.FirstName.First<char>() + "."
                            + entity.DelegateOfOtherCompany3.Patronymic.First<char>() + ". "));
                        }
                        break;
                    default:
                        break;
                }
            }
            return dict;
        }

        public static void GetPublish(System.Collections.ObjectModel.ObservableCollection<DocsHierarchy.ReportOSR> collect, string folderPath)
        {
            Dictionary<string, string> dict;          
                            
            foreach (var item in collect)
            {
                WordDocument doc = new WordDocument(templatePath, true);
                dict = SetDictionaryValues(PublishRules, item);
                foreach (var stroke in dict)
                {
                    doc.ReplaceAllStrings(stroke.Key, stroke.Value);
                }
                //doc.Save(folderPath + "\\" + item.NumberOfReport);
            }            
            
        }

        public static void GetPublish(Dictionary<string, string> publishRules, DocsHierarchy.ReportOSR entity, string fileName)
        {
            throw new NotImplementedException();
        }





    }
}
