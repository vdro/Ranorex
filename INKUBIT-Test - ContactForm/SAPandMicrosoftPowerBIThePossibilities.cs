﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace INKUBIT_Test___ContactForm
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SAPandMicrosoftPowerBIThePossibilities recording.
    /// </summary>
    [TestModule("fd1fdb32-3fa7-44a5-ba4b-80a385b60afe", ModuleType.Recording, 1)]
    public partial class SAPandMicrosoftPowerBIThePossibilities : ITestModule
    {
        /// <summary>
        /// Holds an instance of the INKUBIT_Test___ContactFormRepository repository.
        /// </summary>
        public static INKUBIT_Test___ContactFormRepository repo = INKUBIT_Test___ContactFormRepository.Instance;

        static SAPandMicrosoftPowerBIThePossibilities instance = new SAPandMicrosoftPowerBIThePossibilities();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SAPandMicrosoftPowerBIThePossibilities()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SAPandMicrosoftPowerBIThePossibilities Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.inkubit.com/en-us/blog/microsoft-dynamics-365/sap-and-microsoft-power-bi-the-possibilities/' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.inkubit.com/en-us/blog/microsoft-dynamics-365/sap-and-microsoft-power-bi-the-possibilities/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='SAP® products are one of the most important data sources for corporations. The connectivity between Power BI and SAP® is a long-awaited feature by a lot of companies, that for example want to have more details about transactions that were made in the past.') on item 'HttpsWwwInkubitComEnUsCareers.SAPRProductsAreOneOfTheMostImport'.", repo.HttpsWwwInkubitComEnUsCareers.SAPRProductsAreOneOfTheMostImportInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SAPRProductsAreOneOfTheMostImportInfo, "InnerText", "SAP® products are one of the most important data sources for corporations. The connectivity between Power BI and SAP® is a long-awaited feature by a lot of companies, that for example want to have more details about transactions that were made in the past.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='SAP® and Microsoft Power BI - The Possibilities') on item 'HttpsWwwInkubitComEnUsCareers.SAPRAndMicrosoftPowerBIThePossib'.", repo.HttpsWwwInkubitComEnUsCareers.SAPRAndMicrosoftPowerBIThePossibInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SAPRAndMicrosoftPowerBIThePossibInfo, "InnerText", "SAP® and Microsoft Power BI - The Possibilities");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'HttpsWwwInkubitComEnUsCareers.SAPRAndMicrosoftPowerBIThePossib'.", repo.HttpsWwwInkubitComEnUsCareers.SAPRAndMicrosoftPowerBIThePossibInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SAPRAndMicrosoftPowerBIThePossibInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.Submenu' at 11;20.", repo.HttpsWwwInkubitComEnUsCareers.SubmenuInfo, new RecordItemIndex(4));
            repo.HttpsWwwInkubitComEnUsCareers.Submenu.Click("11;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend1' at 7;9.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend1Info, new RecordItemIndex(5));
            repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend1.Click("7;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='SAP® Produkte gehören zu den wichtigsten Datenquellen für Großunternehmen. Die  Konnektivität zwischen Power BI und SAP® ist schon ein seit langem ein gewünschtes Feature von zahlreichen Unternehmen, die beispielsweise tiefere Einsichten in die Investitionen haben wollen, die sie in der Vergangenheit getätigt haben.') on item 'HttpsWwwInkubitComEnUsCareers.SAPRProdukteGehoerenZuDenWichtigste'.", repo.HttpsWwwInkubitComEnUsCareers.SAPRProdukteGehoerenZuDenWichtigsteInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SAPRProdukteGehoerenZuDenWichtigsteInfo, "InnerText", "SAP® Produkte gehören zu den wichtigsten Datenquellen für Großunternehmen. Die  Konnektivität zwischen Power BI und SAP® ist schon ein seit langem ein gewünschtes Feature von zahlreichen Unternehmen, die beispielsweise tiefere Einsichten in die Investitionen haben wollen, die sie in der Vergangenheit getätigt haben.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend3' at 3;9.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend3Info, new RecordItemIndex(7));
            repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend3.Click("3;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend2' at 8;7.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend2Info, new RecordItemIndex(8));
            repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend2.Click("8;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='SAP® products are one of the most important data sources for corporations. The connectivity between Power BI and SAP® is a long-awaited feature by a lot of companies, that for example want to have more details about transactions that were made in the past.') on item 'HttpsWwwInkubitComEnUsCareers.SAPRProductsAreOneOfTheMostImport'.", repo.HttpsWwwInkubitComEnUsCareers.SAPRProductsAreOneOfTheMostImportInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SAPRProductsAreOneOfTheMostImportInfo, "InnerText", "SAP® products are one of the most important data sources for corporations. The connectivity between Power BI and SAP® is a long-awaited feature by a lot of companies, that for example want to have more details about transactions that were made in the past.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HttpsWwwInkubitComEnUsCareers'.", repo.HttpsWwwInkubitComEnUsCareers.SelfInfo, new RecordItemIndex(10));
            Host.Current.CloseApplication(repo.HttpsWwwInkubitComEnUsCareers.Self, 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}